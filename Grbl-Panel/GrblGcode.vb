Imports System.IO
Imports GrblPanel.GrblIF
Imports GrblPanel.My.Resources


Partial Class GrblGui


    Public Class GrblGcode
        ' A Class to handle reading, parsing, removing white space
        '   - Handles the sending to Grbl using either the simple or advanced protocols
        '   - Handles introducing canned cycles (M06, G81/2/3)
        ' While we are sending the file, lock out manual functions
        Private _gui As GrblGui
        Private _wtgForAck As Boolean = False         '
        Private _runMode As Boolean = True            '
        Private _stepMode As Boolean = False              ' for single stepping gcode
        Private _sendAnotherLine As Boolean = False   '
        Private _lineCount As Integer = 0               ' No of lines left to send
        Private _linesDone As Integer = 0
        Private _m30Flag As Boolean = False             ' M30 detected in gcode stream

        ' Handle file read (Gcode in) and Write (Gcode save)
        Private _inputfh As StreamReader
        Private _inputcount As Integer

        ' For timings
        Dim _elapsed As Elapsed


        Public Sub New(ByRef gui As GrblGui)
            _gui = gui
            _elapsed = New Elapsed(_gui.lblElapsedTime)
        End Sub

        Public Sub enableGCode(ByVal action As Boolean)
            ' Can't use new if we need to reference _gui as it causes Form creation errors
            _gui.gbGcode.Enabled = action
            If action = True Then
                ' Enable looking at responses now, for use by manual commands
                _gui.grblPort.addRcvDelegate(AddressOf _gui.processLineEvent)
                _gui.btnFileSelect.Enabled = True
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.processLineEvent)
            End If
        End Sub

        Public Function loadGCodeFile(ByVal file As String) As Boolean
            Dim data As String
            ' Start from clean slate
            ResetGcode(True)
            ' Load the file, count lines
            _inputfh = My.Computer.FileSystem.OpenTextFileReader(file)
            ' count the lines while loading up
            _inputcount = 0

            Do While Not _inputfh.EndOfStream
                data = _inputfh.ReadLine()    ' Issue #20, ignore '%'
                If data <> "%" Then
                    gcodeview.Insert(data, "File", (_inputcount + 1).ToString)         ' Plan B
                    _inputcount += 1
                End If
            Loop
            lineCount = _inputcount

            _gui.lblTotalLines.Text = _inputcount.ToString      ' Issue #60

            gcodeview.RefreshView(lineCount) ' refresh data to the DataGridView

            If Not IsNothing(_inputfh) Then
                _inputfh.Close()
            End If        ' Issue #19

            Return True

        End Function
        Public Sub closeGCodeFile()
            If Not IsNothing(_inputfh) Then
                _inputfh.Close()
            End If
            _gui.tbGcodeFile.Text = ""
            _inputcount = 0

        End Sub

        Public Sub sendGcodeFile()

            _elapsed.BeginTimer()

            ' Workflow:
            ' Disable other panels to prevent operator error
            _gui.setSubPanels("GCodeStream")
            ' set sendAnotherLine
            ' raise processLineEvent
            lineCount = _inputcount
            linesDone = 0
            wtgForAck = False
            runMode = True
            sendAnotherLine = True
            gcodeview.fileMode = True
            _gui.processLineEvent("")              ' Prime the pump
        End Sub

        Public Sub sendGCodeLine(ByVal data As String)
            ' Send a line immediately
            ' This can only happen when not sending a file, buttons are interlocked
            _runMode = False
            gcodeview.fileMode = False

            If (data.StartsWith("$J") Or Not (data.StartsWith("$") Or data.StartsWith("?"))) Then
                ' add to display
                ' _gui.gcodeview.Insert(data, 0)
                With gcodeview
                    .Insert(data, "MDI", 0)
                    gcode.lineCount += 1
                    ' we are always be the last item in manual mode
                    .UpdateGcodeSent(-1)
                End With
                ' Expect a response from Grbl
                wtgForAck = True
            End If
            _gui.state.ProcessGCode(data)            ' Keep Gcode State object in the loop
            _gui.grblPort.sendData(data)

        End Sub

        Public Sub sendGCodeFilePause()

            _elapsed.StopTimer()

            ' Pause the file send
            _sendAnotherLine = False
            _runMode = False
        End Sub

        Public Sub sendGCodeFileResume()

            _elapsed.ResumeTimer()

            ' Resume sending of file
            _sendAnotherLine = True
            _runMode = True
            _stepMode = False
            gcodeview.fileMode = True
            _gui.processLineEvent("")              ' Prime the pump again

        End Sub

        Public Sub sendGCodeFileStep()
            ' Single Step Line from file
            _sendAnotherLine = True
            _runMode = False
            _stepMode = True
            gcodeview.fileMode = True
            _gui.processLineEvent("")              ' Prime the pump again

        End Sub
        Public Sub sendGCodeFileStop()

            _elapsed.StopTimer()

            ' reset state variables
            If runMode Then
                wtgForAck = False
                runMode = False
                sendAnotherLine = False
                gcodeview.fileMode = False        ' allow manual mode gcode send

                ' Make the fileStop button go click, to stop the file send
                ' and set the buttons
                _gui.btnFileGroup_Click(_gui.btnFileStop, Nothing)
            End If

        End Sub
        Public Sub sendGCodeFileRewind()

            _elapsed.StopTimer()

            ' reset state variables
            If runMode Then
                wtgForAck = False
                runMode = False
                sendAnotherLine = False
                gcodeview.fileMode = False        ' allow manual mode gcode send

                gcode.sendGCodeFilePause()
                'gcode.closeGCodeFile()
                With _gui
                    ' Re-enable manual control
                    .setSubPanels(Resources.GrblGui_btnConnDisconnect_Click_Idle)
                    .btnFileSelect.Enabled = True
                    .btnFileSend.Tag = "Send"
                    .btnFileSend.Enabled = True
                    .btnFilePause.Enabled = False
                    .btnFileStop.Enabled = False
                    .btnFileReload.Enabled = True

                    .lblCurrentLine.Text = "0"          ' Issue #60
                End With
            End If
            gcodeview.Rewind()
        End Sub

        Public Sub shutdown()
            ' Close up shop
            ResetGcode(True)
        End Sub

        Public Sub ResetGcode(ByVal fullstop As Boolean)
            ' Clear out all variables etc to initial state
            lineCount = 0
            linesDone = 0
            _gui.lblTotalLines.Text = ""
            _gui.lblCurrentLine.Text = "0"
            _gui.tbGCodeMessage.Text = ""

            _elapsed.ResetTimer()

            ' reset state variables
            wtgForAck = False
            runMode = False
            sendAnotherLine = False

            If fullstop Then
                ' clear out the file name etc
                closeGCodeFile()
                ' Clear the list of gcode block sent
                gcodeview.Clear()
            End If
        End Sub

#Region "Properties"

        Property runMode() As Boolean
            Get
                Return _runMode
            End Get
            Set(value As Boolean)
                _runMode = value
            End Set
        End Property
        Property wtgForAck() As Boolean
            Get
                Return _wtgForAck
            End Get
            Set(value As Boolean)
                _wtgForAck = value
            End Set
        End Property
        Property stepMode() As Boolean
            Get
                Return _stepMode
            End Get
            Set(value As Boolean)
                _stepMode = value
            End Set
        End Property
        Property sendAnotherLine() As Boolean
            Get
                Return _sendAnotherLine
            End Get
            Set(value As Boolean)
                _sendAnotherLine = value
            End Set
        End Property

        Property linesDone As Integer
            Get
                Return _linesDone
            End Get
            Set(value As Integer)
                _linesDone = value
            End Set
        End Property

        Property lineCount As Integer
            Get
                Return _lineCount
            End Get
            Set(value As Integer)
                _lineCount = value
            End Set
        End Property
        Property m30Flag As Boolean
            Get
                Return _m30Flag
            End Get
            Set(value As Boolean)
                _m30Flag = value
            End Set
        End Property

#End Region

    End Class

    Public Sub processLineEvent(ByVal data As String)

        ' This event handles processing and sending GCode lines from the file as well as ok/error responses from Grbl
        ' Implements simple protocol (send block, wait for ok/error loop)
        ' It runs on the UI thread, and is raised for each line received from Grbl
        ' even when there is no file to send, e.g. due to status poll response

        ' we need this to run in the UI thread so:
        'Console.WriteLine("processLineEvent: " + data)

        ' are we waiting for Ack?
        If gcode.wtgForAck Then
            ' is recvData ok or error?

            If data.StartsWith("ok") Or data.StartsWith("error") Then
                ' Mark gcode item as ok/error
                gcodeview.UpdateGCodeStatus(data, gcode.linesDone - 1)
                ' No longer waiting for Ack
                gcode.wtgForAck = False
                ' Handle rewind of gcode if this ack/ok was for an M30
                If gcode.m30Flag = True Then
                    gcode.m30Flag = False
                    gcode.sendGCodeFileRewind() ' reset to beginning
                End If
                If gcode.runMode Then               ' if not paused or stopped
                    ' Mark sendAnotherLine
                    gcode.sendAnotherLine = True
                End If
            End If
        End If
        ' Do we have another line to send?
        If gcode.runMode = True Or gcode.stepMode = True Then                    ' if not paused or stopped
            If gcode.sendAnotherLine Then
                gcode.sendAnotherLine = False
                ' if count > 0
                If gcode.lineCount > 0 Then
                    Dim line As String
                    ' Read another line
                    line = gcodeview.readGcode(gcode.lineCount, gcode.linesDone)
                    If Not line.StartsWith("EOF") Then  ' We never hit this but is here just in case the file gets truncated
                        ' count - 1
                        gcode.lineCount -= 1
                        ' show as sent
                        gcodeview.UpdateGcodeSent(gcode.linesDone)                  ' Mark line as sent
                        gcode.linesDone += 1
                        lblCurrentLine.Text = gcode.linesDone.ToString              ' Issue #60
                        state.ProcessGCode(line)
                        ' Set Message if it starts with (
                        If line.StartsWith("(") Then
                            Dim templine As String = line
                            templine = templine.Remove(0, 1)
                            templine = templine.Remove(templine.Length - 1, 1)
                            tbGCodeMessage.Text = templine
                        End If
                        If line.StartsWith("m30") Or line.StartsWith("M30") Then
                            ' Set M30 flag to rewind on 'ok'
                            gcode.m30Flag = True
                        End If
                        ' Remove all whitespace
                        line = line.Replace(" ", "")
                        ' set wtg for Ack
                        gcode.wtgForAck = True
                        ' Ship it Dano!
                        grblPort.sendData(line)
                    End If
                Else
                    ' We reached the EOF aka linecount=0, yippee
                    gcode.sendGCodeFileStop()
                End If
            End If
        End If
        ' Check for status responses that we need to handle here
        ' Extract status
        Dim status = Split(data, ",")
        If status(0) = "<Alarm" Or status(0).StartsWith("ALARM") Then
            ' Major problem so cancel the file
            ' GrblStatus has set the Alarm indicator etc
            gcode.sendGCodeFileStop()
        End If
        If status(0).StartsWith("error") Then
            ' We pause file send to allow operator to determine proceed or not
            If cbSettingsPauseOnError.Checked Then
                btnFilePause.PerformClick()
            End If
        End If
    End Sub

    Private Sub btnCheckMode_Click(sender As Object, e As EventArgs) Handles btnCheckMode.Click
        ' Enable/disable Check mode in Grbl
        ' Just send a $C, this toggles Check state in Grbl
        grblPort.sendData("$C")
    End Sub

    Private Sub btnFileGroup_Click(sender As Object, e As EventArgs) Handles btnFileSend.Click, btnFileSelect.Click, btnFilePause.Click, btnFileStop.Click,
                                    btnFileReload.Click, btnFileStep.Click
        ' This event handler deals with the gcode file related buttons
        ' Implements a simple state machine to keep user from clicking the wrong buttons
        ' Uses button.tag instead of .text so the text doesn't mess up the images on the buttons
        Dim args As Button = sender
        Select Case DirectCast(args.Tag, String)
            Case "File"
                Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                ofdGcodeFile.InitialDirectory = Path.Combine(Path.GetFullPath(str), "*")
                If tbSettingsDefaultExt.Text <> "" Then
                    ofdGcodeFile.Filter = String.Format("Gcode |*.{0}|All Files |*.*", tbSettingsDefaultExt.Text)
                    ofdGcodeFile.DefaultExt = String.Format(".{0}", tbSettingsDefaultExt.Text)
                End If
                ofdGcodeFile.FileName = "File"

                If ofdGcodeFile.ShowDialog() = DialogResult.OK Then
                    'gcode.openGCodeFile(ofdGcodeFile.FileName)
                    gcode.loadGCodeFile(ofdGcodeFile.FileName)
                    tbGcodeFile.Text = ofdGcodeFile.FileName
                    lblTotalLines.Text = gcode.lineCount.ToString

                    btnFileSelect.Enabled = True    ' Allow changing your mind about the file
                    btnFileSend.Enabled = True
                    btnFileStep.Enabled = True
                    btnFilePause.Enabled = False
                    btnFileStop.Enabled = False
                    btnFileReload.Enabled = False
                    ' reset filter in case user changes ext on Settings tab
                    ofdGcodeFile.Filter = ""
                    ofdGcodeFile.DefaultExt = ""
                End If
            Case "Send"
                ' Send a gcode file to Grbl
                gcode.sendGcodeFile()

                btnFileSelect.Enabled = False
                btnFileSend.Enabled = False
                btnFilePause.Enabled = True
                btnFileStop.Enabled = True
                btnFileReload.Enabled = False

            Case "Step"
                gcode.sendGCodeFileStep()
                btnFileSend.Tag = "Resume"
                btnFileSend.Enabled = True
                btnFileSelect.Enabled = False
                btnFilePause.Enabled = True
                btnFileStop.Enabled = True
                btnFileReload.Enabled = False

            Case "Pause"
                gcode.sendGCodeFilePause()

                btnFileSelect.Enabled = False
                btnFileSend.Tag = "Resume"
                btnFileSend.Enabled = True
                btnFilePause.Enabled = False
                btnFileStop.Enabled = True
                btnFileReload.Enabled = False

            Case "Stop"
                gcode.sendGCodeFilePause()
                gcode.closeGCodeFile()
                ' Re-enable manual control
                setSubPanels(GrblGui_btnConnDisconnect_Click_Idle)

                btnFileSelect.Enabled = True
                btnFileSend.Tag = "Send"
                btnFileSend.Enabled = False
                btnFilePause.Enabled = False
                btnFileStop.Enabled = False
                btnFileReload.Enabled = True

            Case "Resume"
                gcode.sendGCodeFileResume()

                btnFileSelect.Enabled = False
                btnFileSend.Tag = "Send"
                btnFileSend.Enabled = False
                btnFilePause.Enabled = True
                btnFileStop.Enabled = True
                btnFileReload.Enabled = False

            Case "Reload"
                ' Reload the same file 
                gcode.loadGCodeFile(ofdGcodeFile.FileName)
                tbGcodeFile.Text = ofdGcodeFile.FileName
                lblTotalLines.Text = gcode.lineCount.ToString

                btnFileSelect.Enabled = True    ' Allow changing your mind about the file
                btnFileSend.Enabled = True
                btnFilePause.Enabled = False
                btnFileStop.Enabled = False
                btnFileReload.Enabled = False
                ' ensure display is at top of gcode
                gcodeview.DisplayTop()

        End Select
    End Sub

End Class