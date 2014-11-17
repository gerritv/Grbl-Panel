Imports System.Threading
Imports GrblPanel.GrblCOM
Imports GrblPanel.GrblIP

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
                _gui.grblIP.addRcvDelegate(AddressOf _gui.showGrblStatus)
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.showGrblStatus)
                _gui.grblIP.deleteRcvDelegate(AddressOf _gui.showGrblStatus)
            End If
            Return True

        End Function

        Public Sub shutdown()
            ' Close up shop
            _gui.statusPrompt("End")

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
        If operation = "Start" Then
            _statusTimer = New Timer(tcb, status.timerState, 0, Convert.ToInt16(My.Settings.StatusPollInterval))
        End If
        If operation = "End" Then
            If Not IsNothing(_statusTimer) Then     ' if close before Connect to Grbl
                _statusTimer.Change(Threading.Timeout.Infinite, Threading.Timeout.Infinite)
            End If
        End If
    End Sub

    Public Sub changeStatusRate(ByVal newrate As Integer)
        ' Change the status polling rate
        _statusTimer.Change(0, newrate)
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
            If grblPort.Connected Then
                grblPort.sendData("?")
            ElseIf grblIP.Connected Then
                grblIP.sendData("?")
            End If
        End If
    End Sub

    'End Class
    Private Sub btnUnlock_Click(sender As Object, e As EventArgs) Handles btnUnlock.Click
        ' Send Unlock ($x) to Grbl
        'grblPort.sendData("$x")
        If grblPort.Connected Then
            grblPort.sendData("$x")
        ElseIf grblIP.Connected Then
            grblIP.sendData("$x")
        End If
        tabCtlPosition.SelectedTab = tpWork         ' refocus to Work tab
        btnHome.BackColor = Color.Transparent       ' Use decided not to Home Cycle, so clear hint
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' Send Reset command to Grbl
        'grblPort.sendData(Chr(24))      ' ctl-X
        If grblPort.Connected Then
            grblPort.sendData(Chr(24))      ' ctl-X
        ElseIf grblIP.Connected Then
            grblIP.sendData(Chr(24))      ' ctl-X
        End If
    End Sub

    Private Sub btnHold_Click(sender As Object, e As EventArgs) Handles btnHold.Click
        ' Send Reset command to Grbl
        'grblPort.sendData("!")
        If grblPort.Connected Then
            grblPort.sendData("!")
        ElseIf grblIP.Connected Then
            grblIP.sendData("!")
        End If
    End Sub

    Private Sub btnStartResume_Click(sender As Object, e As EventArgs) Handles btnStartResume.Click
        ' Send Reset command to Grbl
        'grblPort.sendData("~")
        If grblPort.Connected Then
            grblPort.sendData("~")
        ElseIf grblIP.Connected Then
            grblIP.sendData("~")
        End If
    End Sub

    Private Sub btnStatusGetParser_Click(sender As Object, e As EventArgs) Handles btnStatusGetParser.Click
        ' Send request for Parser State, response handler picks it up and displays
        'grblPort.sendData("$G")
        If grblPort.Connected Then
            grblPort.sendData("$G")
        ElseIf grblIP.Connected Then
            grblIP.sendData("$G")
        End If
    End Sub

    Public Sub showGrblStatus(ByVal data As String)
        ' We come here from the recv_data thread so have to do this trick to cross threads
        ' (http://msdn.microsoft.com/en-ca/library/ms171728(v=vs.85).aspx)

        If Me.btnReset.InvokeRequired Then
            ' we need to cross thread this callback
            Dim ncb As New grblDataReceived(AddressOf Me.showGrblStatus)
            Me.BeginInvoke(ncb, New Object() {data})
            Return
        Else
            ' TODO This needs tidying up, pre-process message to remove leading, trailing < [ , etc. so 
            ' we have a clean code flow below, create a messageType variable?
            'Console.WriteLine("showGrblStatus: " + data)
            If data(0) = vbLf Then
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
                If data.Length > 0 And Not (data.First() = "<") And Not (data.First = "o") And Not (data.First = "$") And _
                                   Not (data.First = "G") And Not (data.First = "[" And data.Contains("F")) Then
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

            ' Split out the Q and Buffer sizes
            ' (Look for Buf:nn,RX:nnn)
            If (data.Contains("Buf:")) Then
                ' Lets display the values
                data = data.Remove(data.Length - 2, 2)   ' Remove the "> " at end
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
                Me.btnStartResume.Text = "Start"
            End If
            If data.StartsWith("<Queue") Or data.StartsWith("<Hold") Then   ' This might become Hold later when fixed in Grbl
                Me.btnStartResume.BackColor = Color.Crimson
                Me.btnStartResume.Text = "Resume"
            End If
            If status(0) = "<Alarm" Then
                Me.btnUnlock.BackColor = Color.Crimson
            End If
            If status(0) = "<Alarm" Or status(0).StartsWith("ALARM") Then
                statusSetIndicators(status(0).Substring(0, 6))       ' Messy Status messages make for messy code :(
            End If
            ' Major problem so cancel the file
            ' Let GrblGcode class handle the error
            'gcode.sendGCodeFileStop()
            End If

        ' Display the Parser state if that is the message type
        If data(0) = "[" And data.Contains("F") Then        ' we have a Parser status message
            state.ProcessGCode(data)
        End If

        If data(0) = "$" Then
            ' we have a Grbl Settings response
            settings.FillSettings(data)
        End If
    End Sub

    Private Sub statusSetIndicators(ByVal status As String)
        ' Set status indicators depending on Grbl's status
        Select Case status
            Case "<Alarm", "ALARM:", "ALARM"
                tbCurrentStatus.BackColor = Color.Red
                tbCurrentStatus.Text = "ALARM"
            Case "<Run"
                tbCurrentStatus.BackColor = Color.LightGreen
                tbCurrentStatus.Text = "RUN"
            Case "<Idle"
                tbCurrentStatus.BackColor = Color.LightGreen
                tbCurrentStatus.Text = "IDLE"
            Case "<Check"
                tbCurrentStatus.BackColor = Color.YellowGreen
                tbCurrentStatus.Text = "CHECK"
            Case "<Queue"
                tbCurrentStatus.BackColor = Color.YellowGreen
                tbCurrentStatus.Text = "QUEUE"
        End Select
    End Sub

End Class   ' partial grblgui