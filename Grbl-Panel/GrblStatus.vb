Imports System.Threading
Imports GrblPanel.GrblIF
Imports GrblPanel.My.Resources


Partial Class GrblGui
    Public Class GrblStatus
        ' A class to display status of Grbl onto the UI
        Private _gui As GrblGui
        Public timerState As timerInfo   ' For sending a request every x times, e.g. for Parser state request

        Public Sub New(ByRef gui As GrblGui)
            ' do setup stuff
            _gui = gui

            _gui.prgBarQ.Maximum = Convert.ToInt16(My.Settings.QBuffMaxSize)
            _gui.prgbRxBuf.Maximum = Convert.ToInt16(My.Settings.RBuffMaxSize)

            timerState = New timerInfo
            timerState.count = 0
        End Sub

        Public Function enableStatus(ByVal action As Boolean) As Boolean
            _gui.gbStatus.Enabled = action
            If action = True Then
                _gui.grblPort.addRcvDelegate(AddressOf _gui.showGrblStatus)
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.showGrblStatus)
            End If
            Return True

        End Function

        Public Sub shutdown()
            ' Close up shop
            _gui.statusPrompt(GrblGui_btnConnDisconnect_Click_End)

            enableStatus(False)
        End Sub

        Public Class timerInfo
            ' An object to pass info to Timer event
            Public count As Integer
        End Class
    End Class       ' Class GrblStatus

    'Private __statusThread As New _statusThread()
    Public Sub statusPrompt(ByVal operation As String)

        Dim tcb As TimerCallback = AddressOf _statusThreadProc
        Dim state As Object = 0
        ' Start/stop status probe thread
        If operation = MsgFilter_PreFilterMessage_Start Then
            _statusTimer = New Timer(tcb, status.timerState, 0, Convert.ToInt16(My.Settings.StatusPollInterval))
        End If
        If operation = GrblGui_btnConnDisconnect_Click_End Then
            If Not IsNothing(_statusTimer) Then     ' if close before Connect to Grbl
                _statusTimer.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite)
            End If
        End If
    End Sub

    Public Sub changeStatusRate(ByVal newrate As Integer)
        ' Change the status polling rate
        If Not IsNothing(_statusTimer) Then
            _statusTimer.Change(0, newrate)
        End If
    End Sub

    Private _statusTimer As Timer

    Public Sub _statusThreadProc(stateInfo As Object)
        ' Send a ? status request every 200ms

        ' We can't poll for Parser status until Grbl stops requiring a vbLF at end of $ commands
        ' This is because that results in an ok response, which messes up Gcode file send ack's!! :-(
        Dim state As GrblStatus.timerInfo = DirectCast(stateInfo, GrblStatus.timerInfo)
        state.count += 1
        If state.count = 10 Then
            state.count = 0
            ' TODO , Change Grbl command for $G grblPort.sendData("$G")     ' Ask for Parser status
        End If
        If cbStatusPollEnable.CheckState Then
            grblPort.sendData("?")
        End If
    End Sub

    'End Class
    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        ' Send Unlock ($x) to Grbl
        grblPort.sendData("$x")
        tabCtlPosition.SelectedTab = tpWork         ' refocus to Work tab
        btnHome.BackColor = Color.Transparent       ' Use decided not to Home Cycle, so clear hint
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Send Reset command to Grbl
        gcode.ResetGcode(False)
        grblPort.sendData(Chr(24))      ' ctl-X
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        ' Send Reset command to Grbl
        grblPort.sendData("!")
    End Sub

    Private Sub btnStartResume_Click(sender As Object, e As EventArgs) Handles btnStartResume.Click
        ' Send Reset command to Grbl
        grblPort.sendData("~")
    End Sub

    Private GrblErrors As GrblErrorsSingleton = GrblErrorsSingleton.GetInstance()
    Private _errors As Dictionary(Of String, String) = GrblErrors.GetErrorsDct()

    Public Sub showGrblStatus(ByVal data As String)

        ' TODO This needs tidying up, pre-process message to remove leading, trailing < [ , etc. so 
        ' we have a clean code flow below, create a messageType variable?
        'Console.WriteLine("showGrblStatus: " + data)
        If data(0) = vbLf Or data(0) = vbCr Then
            Return                  ' nothing to do
        End If
        If Me.cbVerbose.Checked Then
            ' Show data in the Status screen (from our own thread)
            Me.lbResponses.Items.Add(data)
            If Me.lbResponses.Items.Count > 1 Then      ' handle case where user doesn't have 
                Me.lbResponses.TopIndex = Me.lbResponses.Items.Count - 1
            End If
        Else
            ' filter out <> , ok, $G, $$ response messages
            If data.Length > 0 And Not (data.First() = "<") And Not (data.First = "o") And Not (data.First = "$") And
                               Not (data.First = "G") And Not (data.First = "[" And data.Contains("F")) And Not data.StartsWith("error:") Then
                ' Show data in the Status screen (from our own thread)
                Me.lbResponses.Items.Add(data)
                Me.lbResponses.TopIndex = Me.lbResponses.Items.Count - 1
            End If
        End If
        If Me.lbResponses.Items.Count > 100 Then
            ' keep the list reasonably short
            lbResponses.Items.RemoveAt(0)
            Me.lbResponses.TopIndex = Me.lbResponses.Items.Count - 1
        End If

        If data.StartsWith("Grbl") Then
            ' set Grbl version, 0.x or 1.x
            GrblVersion = data.Substring(5, 1)
            If GrblVersion = 1 Then
                pins.PinsSeen = True      ' Show all pins
            Else
                pins.LimitsSeen = True      ' Show limit pins only
            End If
            ' Set version into Settings page
            tbGrblVersion.Text = Split(data, "[")(0)

            ' Something reset the Grbl device, likely a physical Reset
            ' Stop what we are doing and clear out for restart
            state.GrblConnected("Connected")   ' Reset State object
            gcode.ResetGcode(False)

        End If

        ' BG Modification to get errors in plain text. Looks like this is the same, independantly of Grbl version, which is why its here.
        Dim errorCode As Integer

        If (data.StartsWith("error:")) Then
            If IsNumeric(data("error:".Length + 1)) Then ' If Grbl in GUI mode, then char follwing the : is number
                ' We are in GUI mode so expand the message
                errorCode = Convert.ToInt16(data.Substring(6, data.Length - 6 - 2))
                data = data + " -> " + _errors(errorCode)
                Me.lbResponses.Items.Add(data)
                Me.lbResponses.TopIndex = Me.lbResponses.Items.Count - 1
            End If
        End If

        ' We switch processing based on Grbl version, 1.x is quite different

        If GrblVersion = 0 Then
            ' Split out the Q and Buffer sizes
            ' (Look for Buf:nn,RX:nnn)
            If (data.Contains("Buf:")) Then     ' Pre Grbl 1.0
                ' Lets display the values
                data = data.Remove(data.Length - 3, 3)   ' Remove the "> " at end
                Dim positions = Split(data, ":")
                Try
                    Dim buffer = Split(positions(3), ",")
                    Dim rx = Split(positions(4), ",")
                    prgbRxBuf.Value = rx(0)
                    prgBarQ.Value = buffer(0)
                Catch
                    ' do nothing, should have Status Report mask = 15
                End Try
            End If

            ' Show status on the buttons
            ' Extract status
            Dim status = Split(data, ",")
            ' Set indicators
            If Not IsNothing(status) Then 'And status(0).StartsWith("<") Then
                statusSetIndicators(status(0))
            End If

            ' Set button states
            If status(0) = "<Idle" Or status(0) = "<Run" Then
                ' Clear the button lights
                Me.btnUnlock.BackColor = Color.Transparent
                Me.btnHold.BackColor = Color.Transparent
                Me.btnReset.BackColor = Color.Transparent
                Me.btnStartResume.BackColor = Color.Transparent
                Me.btnStartResume.Text = Resources.MsgFilter_PreFilterMessage_Start
            End If
            If data.StartsWith("<Queue") Or data.StartsWith("<Hold") Then   ' This might become Hold later when fixed in Grbl
                Me.btnStartResume.BackColor = Color.Crimson
                Me.btnStartResume.Text = Resources.GrblGui_showGrblStatus_Resume
            End If
            If status(0) = "<Alarm" Then
                Me.btnUnlock.BackColor = Color.Crimson
            End If
            If status(0) = "<Alarm" Or status(0).StartsWith("ALARM") Then
                statusSetIndicators(status(0).Substring(0, 6))       ' Messy Status messages make for messy code :(
            End If

            ' Display the Parser state if that is the message type
            If data(0) = "[" And data.Contains("F") Then        ' we have a Parser status message
                state.ProcessGCode(data)
            End If
        End If ' Grbl 0.x proccessing Then

        If GrblVersion = 1 Then
            If data.StartsWith("[MSG:") Then

            End If
            If data.StartsWith("[GC:") Then
                ' Parser State message
                state.ProcessGCode(data)
            End If

            If data.StartsWith("<") Then
                data = data.Remove(data.Length - 3, 3)
                Dim statusMessage = Split(data, "|")
                For Each item As String In statusMessage
                    Dim portion() As String = Split(item, ":")
                    ' Pn, Ov, T are andled in their respective objects
                    Select Case portion(0)
                        Case "<Idle"
                            ' Clear the button lights
                            Me.btnUnlock.BackColor = Color.Transparent
                            Me.btnHold.BackColor = Color.Transparent
                            Me.btnReset.BackColor = Color.Transparent
                            Me.btnCheckMode.BackColor = Color.Transparent
                            Me.btnStartResume.BackColor = Color.Transparent
                            Me.btnStartResume.Text = MsgFilter_PreFilterMessage_Start
                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = GrblGui_showGrblStatus_IDLE
                        Case "<Run"
                            Me.btnUnlock.BackColor = Color.Transparent
                            Me.btnHold.BackColor = Color.Transparent
                            Me.btnReset.BackColor = Color.Transparent
                            Me.btnStartResume.BackColor = Color.Transparent
                            Me.btnStartResume.Text = MsgFilter_PreFilterMessage_Start
                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = GrblGui_showGrblStatus_RUN
                        Case "<Hold"
                            Me.btnStartResume.BackColor = Color.Crimson
                            Me.btnStartResume.Text = GrblGui_showGrblStatus_Resume

                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = GrblGui_showGrblStatus_HOLD
                        Case "<Alarm"
                            Me.btnUnlock.BackColor = Color.Crimson
                            statusSetIndicators("<Alarm")       ' Messy Status messages make for messy code :(
                        Case "<Jog"
                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = "JOG"
                        Case "<Door"
                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = "DOOR"
                        Case "<Check"
                            Me.btnCheckMode.BackColor = Color.Crimson

                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = Resources.GrblGui_showGrblStatus_CHECK
                        Case "<Home"
                            tbCurrentStatus.BackColor = Color.LightGreen
                            tbCurrentStatus.Text = "HOME"
                        Case "Bf"
                            Dim values = Split(portion(1), ",")
                            Try
                                prgBarQ.Value = 15 - values(0)
                                prgbRxBuf.Value = 128 - values(1)
                            Catch
                            End Try
                        Case "F"
                        Case "FS"
                            ' TODO Figure out where to display Grbl's actual feedrate, if at all
                    End Select
                Next
            End If
            ' A bit messy but it doesn't really fit anywhere else
            If data.StartsWith("ALARM") Then
                statusSetIndicators(data.Substring(0, 6))
            End If

            ' TODO Move to Settings handler
            If data(0) = "$" And IsNumeric(data(1)) Then
                ' we have a Grbl Settings response
                settings.FillSettings(data)
            End If
        End If



    End Sub

    Private Sub statusSetIndicators(ByVal status As String)
        ' Version 0.x only
        ' Set status indicators depending on Grbl's status
        Select Case status
            Case "<Alarm", "ALARM:", "ALARM"
                tbCurrentStatus.BackColor = Color.Red
                tbCurrentStatus.Text = "ALARM"
            Case "<Run"
                tbCurrentStatus.BackColor = Color.LightGreen
                tbCurrentStatus.Text = GrblGui_showGrblStatus_RUN
            Case "<Idle"
                tbCurrentStatus.BackColor = Color.LightGreen
                tbCurrentStatus.Text = GrblGui_showGrblStatus_IDLE
            Case "<Check"
                tbCurrentStatus.BackColor = Color.YellowGreen
                tbCurrentStatus.Text = GrblGui_showGrblStatus_CHECK
            Case "<Queue"
                tbCurrentStatus.BackColor = Color.YellowGreen
                tbCurrentStatus.Text = "QUEUE"
        End Select
    End Sub

End Class   ' partial grblgui