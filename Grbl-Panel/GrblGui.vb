Imports System.Globalization
Imports System.Threading
Imports System.Threading.Thread
Imports GrblPanel.My.Resources

'TODO BG Generic Note: maybe it would be nice if a GCode file could call in a macro. But I have no idea how to get that to work! Well, In fact, maybe I have....:-)
Public Class GrblGui

    Public GrblVersion As Integer           ' 0 for 0.x, 1 for 1.x version
    Public WithEvents grblPort As GrblIF    ' Public so that the timer thread can see grblPort
    Private status As GrblStatus            ' For status polling
    Private jogging As GrblJogging          ' for jogging control
    Private position As GrblPosition        ' for machine and work positioning
    Public Shared gcode As GrblGcode        ' For processing gcode file
    Public Shared gcodeview As GrblGcodeView       ' for display of gcode
    Public offsets As GrblOffsets           ' for handling of offsets
    Public state As GrblState              ' to track gcode state
    Public settings As GrblSettings         ' To handle Settings related ops
    Public ovrrides As GrblOverrides       ' to display overrides
    Public pins As GrblPins               ' to display Pin states
    Public info As GrblInfo                 ' to display Grbl information

    Private _exitClicked As Boolean = False   ' to separate Close (x) from File/Exit

    Public Sub myhandler(ByVal sender As Object, args As UnhandledExceptionEventArgs)
        ' Show exception in usable manner
        Dim e As Exception = DirectCast(args.ExceptionObject, Exception)
        MessageBox.Show("Exception: " + e.Message + vbLf + e.InnerException.Message + vbLf + e.StackTrace)
    End Sub


    Private Sub grblgui_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Use handler below to trap wierd problems at Form creation, e.g. when going from .Net 4 to 3.5
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf myhandler

        ' Ensure that we always interpret things such as '.' as decimal (instead of ',' in EU)
        Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-CA")

        ' Set user preferences/defaults
        Application.EnableVisualStyles()

        ' Check to see if this is a new install, if so then copy Settings from previous version
        If My.Settings.UpgradeSettings Then
            My.Settings.Upgrade()
            My.Settings.UpgradeSettings = False
            My.Settings.Save()
        End If

        ' Trick the Settings tab page into loading its controls so that
        ' the config settings are avail to rest of program. Seems kludgy but  there is no other solution
        ' if you want to use Tab pages this way. It makes sense as controls are not run until they get focus.
        tabPgSettings.Show()
        tabPgInterface.Show()

        ' Are we right handed?

        SwitchSides(cbSettingsLeftHanded.Checked)

        grblPort = New GrblIF
        settings = New GrblSettings(Me)
        status = New GrblStatus(Me)
        jogging = New GrblJogging(Me)
        position = New GrblPosition(Me)
        gcode = New GrblGcode(Me)
        gcodeview = New GrblGcodeView(dgvGcode)
        offsets = New GrblOffsets(Me)
        state = New GrblState(Me)
        ovrrides = New GrblOverrides(Me)
        pins = New GrblPins(Me)
        info = New GrblInfo(Me)

        rescanPorts()
        If My.Settings.Port <> "" Then
            cbPorts.SelectedIndex = cbPorts.FindStringExact(My.Settings.Port)
        End If

        cbBaud.SelectedText = My.Settings.Baud
        grblPort.baudrate = Convert.ToInt32(My.Settings.Baud)

        tcConnection.SelectedIndex = My.Settings.ConnectionType
        tbIPAddress.Text = My.Settings.IPAddress

        If cbSettingsConnectOnLoad.Checked Then
            ' auto connect
            btnConnDisconnect_Click(btnConnect, Nothing)
        End If

        EnableMacroButtons()

        ' Capture all keyboard events so that we get to see arrow keys. If we don't do this then
        ' the various controls keep the arrow keys if one gets focus
        Application.AddMessageFilter(New MsgFilter(Me))
    End Sub

    Private Sub grblgui_unload(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.FormClosing
        If _exitClicked Then  ' from File/Exit
            tidyClose()
            Return
        Else
            ' Ignore attempt to exit
            If MsgBox(GrblGui_grblgui_unload_AreYouCertainThatYouWantToClose, MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' The only valid way to exit
        _exitClicked = True
        tidyClose()
    End Sub

    Private Sub tidyClose()
        ' Close down in a tidy fashion
        grblPort.Disconnect()
        gcode.shutdown()
        status.shutdown()
        jogging.shutdown()
        position.shutdown()

        Application.Exit()
    End Sub
    Public Class MsgFilter : Implements IMessageFilter
        Private _gui As GrblGui
        Public Sub New(ByRef owner As GrblGui)
            _gui = owner
        End Sub

        ''' <summary>
        ''' Handle key press overrides and keyboard mapping
        ''' </summary>
        ''' <param name="msg"></param>
        ''' <returns>True if key msg was handled</returns>
        Private Function PreFilterMessage(ByRef msg As Message) As Boolean Implements IMessageFilter.PreFilterMessage
            Dim handled As Boolean = False

            If msg.Msg = &H100 Then  ' We have a KeyDown event

                If _gui.gbJogging.Enabled And Not _gui.tbSendData.ContainsFocus Then
                    If _gui.cbSettingsKeyboardJogging.Checked Then
                        Select Case msg.WParam   ' ignoring modifiers for now
                            Case Keys.Left
                                _gui.btnXMinus.PerformClick()
                                handled = True
                            Case Keys.Right
                                _gui.btnXPlus.PerformClick()
                                handled = True
                            Case Keys.Up
                                _gui.btnYPlus.PerformClick()
                                handled = True
                            Case Keys.Down
                                _gui.btnYMinus.PerformClick()
                                handled = True
                            Case Keys.PageUp
                                _gui.btnZPlus.PerformClick()
                                handled = True
                            Case Keys.PageDown
                                _gui.btnZMinus.PerformClick()
                                handled = True
                        End Select
                        If handled Then
                            Return True
                        End If
                    End If
                End If

                ' Non-jog mappings
                If Not _gui.tbSendData.ContainsFocus And
                    Not _gui.gbEditor.ContainsFocus And
                    Not _gui.gbSettingsMisc.ContainsFocus And
                    Not _gui.gbSettingsJogging.ContainsFocus And
                    Not _gui.gbSettingsPosition.ContainsFocus And
                    Not _gui.tbWorkX.ContainsFocus And
                    Not _gui.tbWorkY.ContainsFocus And
                    Not _gui.tbWorkZ.ContainsFocus Then ' in case user is working in MDI
                    Select Case msg.WParam
                        ' Act on Distance Increment keyboard requests
                        Case Keys.Add, Keys.Oemplus And My.Computer.Keyboard.ShiftKeyDown
                            _gui.changeDistanceIncrement(True)
                            handled = True
                        Case Keys.Subtract, Keys.OemMinus
                            _gui.changeDistanceIncrement(False)
                            handled = True

                        ' Act on Feed Rate keyboard requests
                        Case Keys.Divide, &HBF
                            _gui.changeFeedRate(True)
                            handled = True
                        Case Keys.Multiply, Keys.D8 And My.Computer.Keyboard.ShiftKeyDown
                            _gui.changeFeedRate(False)
                            handled = True

                        ' Reset x,y,z axis to 0
                        Case Keys.X And Not My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnWorkX0.PerformClick()
                            handled = True
                        Case Keys.Y
                            _gui.btnWorkY0.PerformClick()
                            handled = True
                        Case Keys.Z
                            _gui.btnWorkZ0.PerformClick()
                            handled = True

                        ' Reset all axes to 0
                        Case Keys.Insert
                        Case Keys.A
                            _gui.btnWork0.PerformClick()
                            handled = True

                        ' Motion
                        Case Keys.Space
                            If _gui.btnStartResume.Text = "Start" Then
                                _gui.btnHold.PerformClick()
                            Else
                                _gui.btnStartResume.PerformClick()
                            End If
                            handled = True

                        ' Single Step
                        Case Keys.O
                            _gui.btnFileStep.PerformClick()
                            handled = True

                        ' Macro 1 execute
                        Case Keys.F2
                            Dim macro1 As Button = _gui.IsMacroBtn(1)
                            If Not IsNothing(macro1) Then
                                macro1.PerformClick()
                                handled = True
                            End If
                        Case Keys.F3
                            Dim macro1 As Button = _gui.IsMacroBtn(2)
                            If Not IsNothing(macro1) Then
                                macro1.PerformClick()
                                handled = True
                            End If
                        Case Keys.F4
                            Dim macro1 As Button = _gui.IsMacroBtn(3)
                            If Not IsNothing(macro1) Then
                                macro1.PerformClick()
                                handled = True
                            End If
                        Case Keys.F5
                            Dim macro1 As Button = _gui.IsMacroBtn(4)
                            If Not IsNothing(macro1) Then
                                macro1.PerformClick()
                                handled = True
                            End If
                        Case Keys.F6
                            Dim macro1 As Button = _gui.IsMacroBtn(5)
                            If Not IsNothing(macro1) Then
                                macro1.PerformClick()
                                handled = True
                            End If

                        ' Grbl State
                        Case Keys.H And My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnHold.PerformClick()
                            handled = True
                        Case Keys.U And My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnUnlock.PerformClick()
                            handled = True
                        Case Keys.X And My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnReset.PerformClick()
                            handled = True

                        ' Overrides
                        Case Keys.F And My.Computer.Keyboard.ShiftKeyDown
                            _gui.btnFeedPlus.PerformClick()
                            handled = True
                        Case Keys.F And Not (My.Computer.Keyboard.ShiftKeyDown Or My.Computer.Keyboard.CtrlKeyDown)
                            _gui.btnFeedMinus.PerformClick()
                            handled = True
                        Case Keys.F And My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnFeedOverrideReset.PerformClick()
                            handled = True
                        Case Keys.S And My.Computer.Keyboard.ShiftKeyDown
                            _gui.btnSpindlePlus.PerformClick()
                            handled = True
                        Case Keys.S And Not (My.Computer.Keyboard.ShiftKeyDown Or My.Computer.Keyboard.CtrlKeyDown)
                            _gui.btnSpindleMinus.PerformClick()
                            handled = True
                        Case Keys.S And My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnSpindleOverrideReset.PerformClick()
                            handled = True
                        Case Keys.R And My.Computer.Keyboard.ShiftKeyDown
                            _gui.btnRapidOverrideReset.PerformClick()
                            handled = True
                        Case Keys.R And My.Computer.Keyboard.CtrlKeyDown
                            _gui.btnRapidOverride25.PerformClick()
                            handled = True
                        Case Keys.R And Not (My.Computer.Keyboard.ShiftKeyDown Or My.Computer.Keyboard.CtrlKeyDown)
                            _gui.btnRapidOverride50.PerformClick()
                            handled = True

                    End Select
                End If

                If handled Then
                    Return True
                End If

            End If

            ' We didn't handle event so pass it along
            Return False
        End Function
    End Class

    ''' <summary>
    ''' Override key handling for Enter
    ''' </summary>
    ''' <param name="msg"></param>
    ''' <param name="keyData"></param>
    ''' <returns></returns>
    ''' We do this to capture Enter key for some controls, so that users can use Enter instead of Double Click
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, keyData As Keys) As Boolean
        ' Return True if we handled the key press
        If keyData = Keys.Enter Then
            Dim ctrl As Control = Me.ActiveControl

            If ctrl.Parent.Name = "tpOffsets" Then
                ' we are editing the offsets
                SendOffsets(DirectCast(ctrl.Tag, String), ctrl.Text)
                Return True
            End If

            If dgGrblSettings.IsCurrentCellDirty Then
                ' we are editing in the Grbl Settings grid
                If Not IsNothing(dgGrblSettings.CurrentRow) Then
                    ' we have something to change (aka ignore errant double clicks)
                    Dim param As String = dgGrblSettings.CurrentRow.Cells(0).Value.ToString & "=" & dgGrblSettings.CurrentCell.EditedFormattedValue.ToString
                    gcode.sendGCodeLine(param)
                    Sleep(200)              ' Have to wait for EEProm write
                    gcode.sendGCodeLine("$$")   ' Refresh
                    Return True
                End If
            End If
            ' Process setting of offset from main display
            If tbWorkX.ContainsFocus Then
                SendOffsets(lblPositionCurrentOffset.Text + "X", tbWorkX.Text)
                tabCtlPosition.Focus()
                Return True
            End If
            If tbWorkY.ContainsFocus Then
                SendOffsets(lblPositionCurrentOffset.Text + "Y", tbWorkY.Text)
                tabCtlPosition.Focus()
                Return True
            End If
            If tbWorkZ.ContainsFocus Then
                SendOffsets(lblPositionCurrentOffset.Text + "Z", tbWorkZ.Text)
                tabCtlPosition.Focus()
                Return True
            End If
        End If

        ' we didn't do anything with the key so pass it on
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub SwitchSides(ByVal side As Boolean)
        ' We switch GUI sides

        Dim ctl As Control

        ' Get existing locations for X      ' Issue #17,18 and others fix
        Dim left_X As Integer
        Dim right_X As Integer
        left_X = gbJogging.Width + 3
        right_X = gbPosition.Width + 3

        If side Then    ' we are going left handed
            For Each ctl In {gbGrbl, gbJogging, gbGcode}
                ctl.Location = New Point(3, ctl.Location.Y)
            Next
            gbMDI.Location = New Point(3 + gbGrbl.Width + 3, gbMDI.Location.Y)

            For Each ctl In {gbPosition, gbStatus, gbControl}
                ctl.Location = New Point(3 + left_X, ctl.Location.Y)
            Next
        Else
            For Each ctl In {gbGrbl, gbJogging, gbGcode}
                ctl.Location = New Point(3 + right_X, ctl.Location.Y)
            Next
            gbMDI.Location = New Point(3 + right_X + gbGrbl.Width + 3, gbMDI.Location.Y)

            For Each ctl In {gbPosition, gbStatus, gbControl}
                ctl.Location = New Point(3, ctl.Location.Y)
            Next
        End If

    End Sub

    Private Sub cbSettingsLeftHanded_CheckedChanged(sender As Object, e As EventArgs) Handles cbSettingsLeftHanded.CheckedChanged
        ' Use is switching sides
        SwitchSides(cbSettingsLeftHanded.Checked)
    End Sub

    Private Sub lbPorts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPorts.SelectedIndexChanged
        ' set desired com port
        ' always remember as new default
        ' allow re-connect to new port
        grblPort.comport = cbPorts.SelectedItem
        ' Set as new default
        My.Settings.Port = cbPorts.SelectedItem
        btnConnect.Enabled = True

    End Sub

    Private Sub cbBaud_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBaud.SelectedIndexChanged
        ' set desired baud rate
        grblPort.baudrate = cbBaud.SelectedItem.ToString
        My.Settings.Baud = grblPort.baudrate ' always remember as new default
        My.Settings.Save()
        btnConnect.Enabled = True

    End Sub

    Private Sub btnConnDisconnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click, btnIPConnect.Click
        ' Open connection to Grbl
        ' This routine is used for both Com and IP connections. Buttons are differentiated by using Tag property.

        Dim btn As Button = sender
        Dim connected As Boolean

        Select Case btn.Text
            Case Button_Connection_Text_Connect
                Select Case DirectCast(btn.Tag, String)
                    Case "COM"
                        connected = grblPort.Connect(GrblIF.ConnectionType.Serial)
                        If connected = True Then
                            ' disable other Connect button to prevent reconnects
                            btn.Text = GrblGui_btnConnDisconnect_Click_Disconnect
                            btnIPConnect.Enabled = False
                        Else
                            MessageBox.Show(GrblGui_btnConnDisconnect_Click_PleaseSelectAComPort + vbCr + GrblGui_btnConnDisconnect_Click_OrConnectTheCable, GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK)
                            grblPort.rescan()
                            Return
                        End If
                    Case "IP"
                        If tbIPAddress.TextLength <= 0 Then
                            MessageBox.Show(GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + vbCr + GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + vbCr + """<ip address>:<port number>""", GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK)
                            Return
                        End If

                        Dim address As String() = tbIPAddress.Text.Split({":"}, StringSplitOptions.RemoveEmptyEntries)
                        grblPort.ipaddress = System.Net.IPAddress.Parse(address(0))
                        grblPort.portnum = Integer.Parse(address(1))

                        If grblPort.portnum = 0 Then
                            MessageBox.Show(GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + vbCr + Resources.GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + vbCr + """<ip address>:<port number>""", GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK)
                            Return
                        End If
                        ' finally we try to connect
                        connected = grblPort.Connect(GrblIF.ConnectionType.IP)
                        If connected = True Then
                            ' disable other Connect button to prevent reconnects
                            btn.Text = GrblGui_btnConnDisconnect_Click_Disconnect
                            btnConnect.Enabled = False
                        Else
                            MessageBox.Show(GrblGui_btnConnDisconnect_Click_PleaseEnterAnIPAddress + vbCr + GrblGui_btnConnDisconnect_Click_AndAPortNumberInTheFormat + vbCr + """<ip address>:<port number>""", GrblGui_btnConnDisconnect_Click_Connect_Error, MessageBoxButtons.OK)
                            Return
                        End If
                End Select
                If connected = True Then
                    ' Wake up the subsystems
                    ' TODO Replace these calls with Event Connected handling in each object
                    status.enableStatus(True)
                    Sleep(tbSettingsStartupDelay.Text * 1000)             ' Give Grbl time to wake up from Reset

                    gcode.enableGCode(True)
                    jogging.enableJogging(True)
                    position.enablePosition(True)
                    offsets.enableOffsets(True)
                    state.EnableState(True)
                    settings.EnableState(True)

                    RaiseEvent connected("Connected")      ' tell everyone of the happy event
                    setSubPanels(GrblGui_btnConnDisconnect_Click_Idle)
                    ' Start the status poller
                    statusPrompt(MsgFilter_PreFilterMessage_Start)
                End If
            Case GrblGui_btnConnDisconnect_Click_Disconnect
                ' it must be a disconnect
                grblPort.Disconnect()
                btnConnect.Text = Button_Connection_Text_Connect
                btnIPConnect.Text = Button_Connection_Text_Connect
                btnConnect.Enabled = True
                btnIPConnect.Enabled = True

                ' Stop the status poller
                ' TODO Replace these calls with Event Disconnected handling in each object
                statusPrompt(GrblGui_btnConnDisconnect_Click_End)
                status.enableStatus(False)
                jogging.enableJogging(False)
                position.enablePosition(False)
                gcode.enableGCode(False)
                offsets.enableOffsets(False)
                state.EnableState(False)
                settings.EnableState(False)

                RaiseEvent connected("Disconnected")
                setSubPanels(GrblGui_btnConnDisconnect_Click_Disconnected) ' block GUI 
                Return
        End Select
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        ' Send a line to Grbl
        gcode.sendGCodeLine(tbSendData.Text)
    End Sub

    Private Sub tbSendData_KeyDown(sender As Object, e As KeyEventArgs) Handles tbSendData.KeyDown
        ' Do same as clicking Send button
        If e.KeyCode = Keys.Return Then
            ' Send a line to Grbl
            gcode.sendGCodeLine(tbSendData.Text)
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        AboutBox.ShowDialog()
        AboutBox.BringToFront()
    End Sub

    Private Sub OptionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OptionsToolStripMenuItem.Click
        TabControl1.SelectedTab = tabPgSettings
        TabControl1.SelectedTab.Show()

    End Sub

    Private Sub btnFileSend_MouseHover(sender As Object, e As EventArgs) Handles btnFileSend.MouseHover

    End Sub
    Private Sub rescanPorts()
        With cbPorts
            .Items.Clear()
            .Items.AddRange(grblPort.rescan)
        End With
    End Sub
    Private Sub btnRescanPorts_Click(sender As Object, e As EventArgs) Handles btnRescanPorts.Click
        ' Refresh the list of ports
        rescanPorts()
    End Sub

    Public Sub enableGrbl(ByVal action As Boolean)
        ' enable the Grbl connect group
        gbGrbl.Enabled = action

    End Sub

    Public Sub setSubPanels(ByVal active As String)
        ' enable/disable the various groups/panels on the GUI
        ' This prevents user from doing things such as jogging while running a gcode file
        Select Case active
            Case "GCodeStream"
                ' We are running a file
                gbJogging.Enabled = False
                gbPosition.Enabled = False
                gbMDI.Enabled = False
                gbGrbl.Enabled = False
                gbState.Enabled = False

                gbSettingsJogging.Enabled = False
                gbSettingsMisc.Enabled = False
                gbSettingsOffsets.Enabled = False
                gbSettingsPosition.Enabled = False
                gbGrblSettings.Enabled = False

                btnStatusClearPins.Enabled = False
            Case GrblGui_btnConnDisconnect_Click_Disconnected
                ' We are not connected so not much you can do
                gbJogging.Enabled = False
                gbPosition.Enabled = False
                gbMDI.Enabled = False
                gbGrbl.Enabled = True   ' Allow only Connect
                gbState.Enabled = False

                gbSettingsJogging.Enabled = False
                gbSettingsMisc.Enabled = False
                gbSettingsOffsets.Enabled = False
                gbSettingsPosition.Enabled = False
                gbGrblSettings.Enabled = False

                btnStatusClearPins.Enabled = False
            Case GrblGui_btnConnDisconnect_Click_Idle
                ' General use, no gcode streaming
                gbJogging.Enabled = True
                gbPosition.Enabled = True
                gbMDI.Enabled = True
                gbGrbl.Enabled = True
                gbState.Enabled = True

                gbSettingsJogging.Enabled = True
                gbSettingsMisc.Enabled = True
                gbSettingsOffsets.Enabled = True
                gbSettingsPosition.Enabled = True
                gbGrblSettings.Enabled = True

                btnStatusClearPins.Enabled = True
        End Select
    End Sub

    ' Event Handler definitions

    ' These are used to tell other objects that something meaningful happened

    ' Raised when we succesfully connected to Grbl
    Public Event Connected(ByVal msg As String)
    ' Event template for Settings Retrieved indication
    Public Event GrblSettingsRetrieved()


    'Private Sub MacroButtonEditorToolStripMenuItem_Click(sender As Object, e As EventArgs)
    '    GrblMacroButtons.ShowDialog()
    '    EnableMacroButtons()
    'End Sub

    Private Sub EnableMacroButtons()
        Dim b As Button
        Dim iButtonCounter As Integer
        Dim iButtonMargin As Integer = 7
        Dim iButtonRowSum As Integer = 0
        Dim iButtonRowTop As Integer = 62
        Dim DefaultDimension As Size = New Size(58, 20)

        Dim macro As String()

        ' make sure there are no macro buttons in the group before we add new ones
        For iLoopCounter As Integer = (gbMDI.Controls.Count - 1) To 0 Step -1
            Dim mButton As Control = gbMDI.Controls(iLoopCounter)

            If mButton.Name Like "btnMacro*" Then
                gbMDI.Controls.Remove(mButton)
                mButton.Dispose()
            End If
        Next iLoopCounter


        ' now start adding buttons for each macro item in the registry
        'If Not (instance Is Nothing) Then
        For Each item As String In macroNames
            macro = Split(My.Settings(item), ":")
            If macro.Count = 2 Then
                b = New Button
                b.Size = DefaultDimension
                b.Location = New Point(iButtonRowSum + iButtonMargin, iButtonRowTop)
                b.Name = "btnMacro" & iButtonCounter
                b.Text = macro(0).ToString
                b.Tag = macro(1).ToString

                AddHandler b.Click, AddressOf MacroButton_Click
                gbMDI.Controls.Add(b)
                iButtonRowSum += iButtonMargin + b.Width
                iButtonCounter += 1
            End If
        Next
        'End If
    End Sub

    Private Sub MacroButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim iCounter As Integer
        Dim aData() As String

        aData = Split(Trim(CType(sender, Button).Tag), vbCrLf) ' split the gcode in case the user uses multiple lines 
        For iCounter = 0 To aData.Count - 1
            gcode.sendGCodeLine(aData(iCounter))
        Next
    End Sub

    Private Sub tbWorkX_TextChanged(sender As Object, e As EventArgs) Handles tbWorkX.DoubleClick
        Dim Index As String = ""
        Dim sndr As TextBox = DirectCast(sender, TextBox)
        Select Case lblPositionCurrentOffset.Text.Substring(0, 3) ' Get the offset value
            Case "G54"
                Index = "P1"
            Case "G55"
                Index = "P2"
            Case "G56"
                Index = "P3"
            Case "G57"
                Index = "P4"
            Case "G58"
                Index = "P5"
            Case "G59"
                Index = "P6"
        End Select
        gcode.sendGCodeLine("G10 L2 " + Index + " " + sndr.Tag.ToString + sndr.Text)
    End Sub

End Class