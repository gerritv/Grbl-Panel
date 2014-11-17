Imports System.IO
Imports GrblPanel.GrblCOM
Imports GrblPanel.GrblIP

Partial Class GrblGui

    Public Class GrblGcode

        ' A Class to handle reading, parsing, removing white space
        '   - Handles the sending to Grbl using either the simple or advanced protocols
        '   - Handles introducing canned cycles (M06, G81/2/3)
        Private _gui As GrblGui
        Private _wtgForAck As Boolean = False         '
        Private _runMode As Boolean = True            '
        Private _sendAnotherLine As Boolean = False   '
        Private _lineCount As Integer = 0               ' No of lines left to send
        Private _linesDone As Integer = 0

        ' Handle file read (Gcode in) and Write (Gcode save)
        ' While we are sending the file, lock out manual functions
        Private _inputfh As StreamReader
        Private _inputcount As Integer

        Public Sub New(ByRef gui As GrblGui)
            _gui = gui
        End Sub

        Public Sub enableGCode(ByVal action As Boolean)
            ' Can't use new if we need to reference _gui as it causes Form creation errors
            _gui.gbGcode.Enabled = action
            If action = True Then
                ' Enable looking at responses now, for use by manual commands
                _gui.grblPort.addRcvDelegate(AddressOf _gui.processLineEvent)
                _gui.grblIP.addRcvDelegate(AddressOf _gui.processLineEvent)
                _gui.btnFileSelect.Enabled = True
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.processLineEvent)
                _gui.grblIP.deleteRcvDelegate(AddressOf _gui.processLineEvent)
            End If
        End Sub

        Public Function loadGCodeFile(ByVal file As String) As Boolean

            ' Start from clean slate
            resetGcode(True)
            ' Load the file, count lines
            _inputfh = My.Computer.FileSystem.OpenTextFileReader(file)
            ' count the lines while loading up
            _inputcount = 0
            Do While Not _inputfh.EndOfStream
                _gui.gcodeview.Insert(_inputfh.ReadLine(), _inputcount)
                _inputcount += 1
            Loop

            lineCount = _inputcount
            Return True

        End Function
        Public Sub closeGCodeFile()
            If Not IsNothing(_inputfh) Then
                _inputfh.Close()
            End If
            _gui.tbGcodeFile.Text = ""
            _inputcount = 0

        End Sub
        Public Function readGcode() As String
            ' Read a line, if EOF then return EOF
            Dim lv As ListView = _gui.lvGcode
            If _lineCount > 0 Then
                Return lv.Items(_linesDone).SubItems(2).Text
            Else
                Return "EOF"
            End If
        End Function

        Public Sub sendGcodeFile()

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
            _gui.gcodeview.fileMode = True
            _gui.processLineEvent("")              ' Prime the pump

        End Sub

        Public Sub sendGCodeLine(ByVal data As String)
            ' Send a line immediately
            ' This can only happen when not sending a file, buttons are interlocked
            _runMode = False
            _gui.gcodeview.fileMode = False

            If Not (data.StartsWith("$") Or data.StartsWith("?")) Then
                ' add to display
                _gui.gcodeview.Insert(data, 0)
                gcode.lineCount += 1        ' TODO is this necessary?
                ' we are always be the last item in manual mode
                _gui.gcodeview.UpdateGcodeSent(-1)
                ' Expect a response from Grbl
                wtgForAck = True
            End If
            _gui.state.ProcessGCode(data)            ' Keep Gcode State object in the loop

            If _gui.grblPort.Connected Then
                _gui.grblPort.sendData(data)
            ElseIf _gui.grblIP.Connected Then
                _gui.grblIP.sendData(data)
            End If

        End Sub

        Public Sub sendGCodeFilePause()
            ' Pause the file send
            _sendAnotherLine = False
            _runMode = False
        End Sub

        Public Sub sendGCodeFileResume()
            ' Resume sending of file
            _sendAnotherLine = True
            _runMode = True
            _gui.gcodeview.fileMode = True
            _gui.processLineEvent("")              ' Prime the pump again

        End Sub
        Public Sub sendGCodeFileStop()

            ' reset state variables
            If runMode Then
                wtgForAck = False
                runMode = False
                sendAnotherLine = False
                _gui.gcodeview.fileMode = False        ' allow manual mode gcode send

                ' Make the fileStop button go click, to stop the file send
                ' and set the buttons
                _gui.btnFileGroup_Click(_gui.btnFileStop, Nothing)
            End If

        End Sub

        Public Sub shutdown()
            ' Close up shop
            resetGcode(True)
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
        Property sendAnotherLine() As Boolean
            Get
                Return _sendAnotherLine
            End Get
            Set(value As Boolean)
                _sendAnotherLine = value
            End Set
        End Property

        Property linesDone As Int64
            Get
                Return _linesDone
            End Get
            Set(value As Int64)
                _linesDone = value
            End Set
        End Property

        Property lineCount As Int64
            Get
                Return _lineCount
            End Get
            Set(value As Int64)
                _lineCount = value
            End Set
        End Property
#End Region

        Private Sub resetGcode(ByVal fullstop As Boolean)
            ' Clear out all variables etc to initial state
            lineCount = 0
            linesDone = 0
            _gui.lblTotalLines.Text = ""
            _gui.tbGCodeMessage.Text = ""
            ' clear out the file name etc
            closeGCodeFile()
            ' reset state variables
            wtgForAck = False
            runMode = False
            sendAnotherLine = False

            If fullstop Then
                ' Clear the list of gcode block sent
                _gui.gcodeview.Clear()
            End If
        End Sub
    End Class

    Public Class GrblGcodeView
        ' A class to manage the Gcode list view
        ' This contains the GCode queue going to Grbl
        ' GrblGui owns the lvGcode control but this class manages its content

        Private _lview As ListView
        Private _filemode As Boolean = False ' True if in File Send mode

        Public Sub New(ByRef view As ListView)
            _lview = view
        End Sub
        Public Sub Clear()
            _lview.Items.Clear()
            _filemode = False
            _lview.Update()
        End Sub

        Public Sub Insert(ByVal data As String, ByVal lineNumber As Integer)
            ' Insert a new item into the view
            Dim lvi As New ListViewItem
            lvi.Text = ""                       ' This is for Status of command
            lvi.SubItems.Add(lineNumber.ToString)    ' file line number
            lvi.SubItems.Add(data)              ' This is the Gcode block
            _lview.Items.Add(lvi)

            _lview.EnsureVisible(0)           ' show top of file for user to verify etc
            '_lview.Update()
        End Sub

        Public Sub UpdateGCodeStatus(ByVal stat As String, ByVal index As Integer)
            ' Set the Status column of the line item
            If _filemode Then
                _lview.Items(index).Text = stat
                _lview.EnsureVisible(index)
            Else            ' we always pick the last entry
                _lview.Items(_lview.Items.Count - 1).Text = stat
                _lview.EnsureVisible(_lview.Items.Count - 1)
            End If

            _lview.Update()
        End Sub

        Public Sub UpdateGcodeSent(ByVal index As Integer)
            '  Set background to indicate the gcode line was sent
            If _filemode Then       ' Are we running a file
                _lview.Items(index).BackColor = Color.LightBlue
                _lview.EnsureVisible(index)
            Else
                _lview.Items(_lview.Items.Count + index).BackColor = Color.LightBlue
                _lview.EnsureVisible(_lview.Items.Count + index)
            End If

            _lview.Update()

        End Sub

        ReadOnly Property count As Integer
            Get
                Return GrblGui.lvGcode.Items.Count
            End Get
        End Property
        Property fileMode As Boolean
            ' Set true if we are running a gcode file
            Get
                Return _filemode
            End Get
            Set(value As Boolean)
                _filemode = value
            End Set
        End Property
    End Class

    Public Sub processLineEvent(ByVal data As String)

        ' This event handles processing and sending GCode lines from the file as well as ok/error responses from Grbl
        ' Implements simple protocol (send block, wait for ok/error loop)
        ' TODO implement stuffing protocol
        ' It runs on the UI thread, and is raised for each line received from Grbl
        ' even when there is no file to send, e.g. due to status poll response
        ' TODO THIS WILL ALL BE REPLACED WHEN we add Gcode editing and Macro insertion (for canned cycles, tool change etc)

        ' we need this to run in the UI thread so:
        'Console.WriteLine("processLineEvent: " + data)
        If Me.lvGcode.InvokeRequired Then
            ' we need to cross thread this callback
            Dim ncb As New grblDataReceived(AddressOf Me.processLineEvent)
            Me.BeginInvoke(ncb, New Object() {data})
        Else
            ' are we waiting for Ack?
            If gcode.wtgForAck Then
                ' is recvData ok or error?
                If data.StartsWith("ok") Or data.StartsWith("error") Then
                    ' Mark gcode item as ok/error
                    gcodeview.UpdateGCodeStatus(data, gcode.linesDone - 1)
                    ' No longer waiting for Ack
                    gcode.wtgForAck = False
                    If gcode.runMode Then               ' if not paused or stopped
                        ' Mark sendAnotherLine
                        gcode.sendAnotherLine = True
                    End If
                End If
            End If
            ' Do we have another line to send?
            If gcode.runMode = True Then                    ' if not paused or stopped
                If gcode.sendAnotherLine Then
                    gcode.sendAnotherLine = False
                    ' if count > 0
                    If gcode.lineCount > 0 Then
                        Dim line As String
                        ' Read another line
                        line = gcode.readGcode()
                        If Not line.StartsWith("EOF") Then  ' We never hit this but is here just in case the file gets truncated
                            ' count - 1
                            gcode.lineCount -= 1
                            ' show as sent
                            gcodeview.UpdateGcodeSent(gcode.linesDone)                  ' Mark line as sent
                            gcode.linesDone += 1
                            state.ProcessGCode(line)
                            ' Set Message if it starts with (
                            If line.StartsWith("(") Then
                                Dim templine As String = line
                                templine = templine.Remove(0, 1)
                                templine = templine.Remove(templine.Length - 1, 1)
                                tbGCodeMessage.Text = templine
                            End If
                            ' Remove all whitespace
                            line = line.Replace(" ", "")
                            ' set wtg for Ack
                            gcode.wtgForAck = True

                            ' Ship it Dano!
                            'grblPort.sendData(line)
                            If grblPort.Connected Then
                                grblPort.sendData(line)
                            ElseIf grblIP.Connected Then
                                grblIP.sendData(line)
                            End If

                        End If
                    Else
                        ' We reached the EOF aka linecount=0, yippee
                        gcode.sendGCodeFileStop()
                    End If
                End If
            End If
            ' Check for status repsonses that we need to handle here
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
        End If
    End Sub

    Private Sub btnCheckMode_Click(sender As Object, e As EventArgs) Handles btnCheckMode.Click
        ' Enable/disable Check mode in Grbl
        ' Just send a $C, this toggles Check state in Grbl

        'grblPort.sendData("$C")
        If grblPort.Connected Then
            grblPort.sendData("$C")
        ElseIf grblIP.Connected Then
            grblIP.sendData("$C")
        End If

    End Sub

    Private Sub btnFileGroup_Click(sender As Object, e As EventArgs) Handles btnFileSend.Click, btnFileSelect.Click, btnFilePause.Click, btnFileStop.Click
        ' This event handler deals with the gcode file related buttons
        ' Implements a simple state machine to keep user from clicking the wrong buttons
        ' Uses button.tag instead of .text so the text doesn't mess up the images on the buttons
        Dim args As Button = sender
        Select Case args.Tag
            Case "File"
                Dim str As String = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
                ofdGcodeFile.InitialDirectory = Path.Combine(Path.GetFullPath(str), "*")
                ofdGcodeFile.FileName = "*"
                If ofdGcodeFile.ShowDialog() = Windows.Forms.DialogResult.OK Then
                    'gcode.openGCodeFile(ofdGcodeFile.FileName)
                    gcode.loadGCodeFile(ofdGcodeFile.FileName)
                    tbGcodeFile.Text = ofdGcodeFile.FileName
                    lblTotalLines.Text = gcode.lineCount.ToString

                    btnFileSelect.Enabled = True    ' Allow changing your mind about the file
                    btnFileSend.Enabled = True
                    btnFilePause.Enabled = False
                    btnFileStop.Enabled = False

                End If
            Case "Send"
                ' Send a gcode file to Grbl
                gcode.sendGcodeFile()

                btnFileSelect.Enabled = False
                btnFileSend.Enabled = False
                btnFilePause.Enabled = True
                btnFileStop.Enabled = True

            Case "Pause"
                gcode.sendGCodeFilePause()

                btnFileSelect.Enabled = False
                btnFileSend.Tag = "Resume"
                btnFileSend.Enabled = True
                btnFilePause.Enabled = False
                btnFileStop.Enabled = True

            Case "Stop"
                gcode.sendGCodeFilePause()
                gcode.closeGCodeFile()
                ' Re-enable manual control
                setSubPanels("Idle")

                btnFileSelect.Enabled = True
                btnFileSend.Tag = "Send"
                btnFileSend.Enabled = False
                btnFilePause.Enabled = False
                btnFileStop.Enabled = False

            Case "Resume"
                gcode.sendGCodeFileResume()

                btnFileSelect.Enabled = False
                btnFileSend.Tag = "Send"
                btnFileSend.Enabled = False
                btnFilePause.Enabled = True
                btnFileStop.Enabled = True

        End Select
    End Sub

End Class