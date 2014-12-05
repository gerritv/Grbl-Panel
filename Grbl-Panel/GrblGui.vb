Imports System.Threading.Thread

Public Class GrblGui

    Public WithEvents grblPort As GrblIF    ' Public so that the timer thread can see grblPort
    Private status As GrblStatus            ' For status polling
    Private jogging As GrblJogging          ' for jogging control
    Private position As GrblPosition        ' for machine and work positioning
    Public Shared gcode As GrblGcode        ' For processing gcode file
    Public gcodeview As GrblGcodeView       ' for display of gcode
    Public offsets As GrblOffsets           ' for handling of offsets
    Public state As GrblState              ' to track gcode state
    Public settings As GrblSettings         ' To handle Settings related ops

    Public Sub myhandler(ByVal sender As Object, args As UnhandledExceptionEventArgs)
        ' Show exception in useable manner
        Dim e As Exception = DirectCast(args.ExceptionObject, Exception)
        MessageBox.Show("Exception: " + e.Message + vbLf + e.InnerException.Message + vbLf + e.StackTrace)
    End Sub


    Private Sub grblgui_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Use handler below to trap wierd problems at Form creation, e.g. when going from .Net 4 to 3.5
        AddHandler AppDomain.CurrentDomain.UnhandledException, AddressOf myhandler

        ' Set user preferences/defaults
        Application.EnableVisualStyles()

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
        gcodeview = New GrblGcodeView(lvGcode)
        offsets = New GrblOffsets(Me)
        state = New GrblState(Me)

        rescanPorts()
        If My.Settings.Port <> "" Then
            cbPorts.SelectedIndex = cbPorts.FindStringExact(My.Settings.Port)
        End If

        cbBaud.SelectedText = My.Settings.Baud

        grblPort.baudrate = Convert.ToInt32(My.Settings.Baud)

        If cbSettingsConnectOnLoad.Checked Then
            ' auto connect
            btnConnDisconnect_Click(btnConnect, Nothing)
        End If

    End Sub

    Private Sub grblgui_unload() Handles MyBase.FormClosing
        ' TODO Is this still necessary??
        With My.Settings
            .JoggingUnitsMetric = cbUnits.Checked
            .JoggingFIImperial = tbSettingsFIImperial.Text
            .JoggingFRImperial = tbSettingsFRImperial.Text
            .JoggingFIMEtric = tbSettingsFIMetric.Text
            .JoggingFRMetric = tbSettingsFRMetric.Text
        End With

        tidyClose()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        ' On the rare occasion that someone uses File/Exit
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

    Private Sub SwitchSides(ByVal side As Boolean)
        ' We switch GUI sides, this needs to be fixed EVERYTIME that the layout changes!
        Dim ctl As Control
        If side Then    ' we are going left handed
            For Each ctl In {gbGrbl, gbJogging, gbGcode}
                ctl.Location = New Point(3, ctl.Location.Y)
            Next
            gbMDI.Location = New Point(3 + 184, gbMDI.Location.Y)

            For Each ctl In {gbPosition, gbStatus, gbControl}

                ctl.Location = New Point(3 + 3 + 520, ctl.Location.Y)
            Next
        Else
            For Each ctl In {gbGrbl, gbJogging, gbGcode}
                ctl.Location = New Point(3 + 403, ctl.Location.Y)
            Next
            gbMDI.Location = New Point(3 + 400 + 187, gbMDI.Location.Y)

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
        grblPort.port = cbPorts.SelectedItem
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

    Private Sub btnConnDisconnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        ' Open connection to Grbl
        Dim btn As Button = sender

        If grblPort.port = "" Then
            MessageBox.Show("Please select a Com port" + vbCr + "or connect the cable", "Connect Error", MessageBoxButtons.OK)
            grblPort.rescan()
            Return
        End If

        Select Case btn.Text
            Case "Connect"
                If grblPort.Connect() = True Then
                    ' disable Connect button to prevent reconnects
                    btnConnect.Text = "Disconnect"

                    ' Wake up the subsystems
                    ' TODO Replace these calls with Event Connected handling in each object
                    status.enableStatus(True)
                    jogging.enableJogging(True)
                    position.enablePosition(True)
                    gcode.enableGCode(True)
                    offsets.enableOffsets(True)
                    state.EnableState(True)
                    settings.EnableState(True)
                    ' Start the status poller
                    statusPrompt("Start")
                    Sleep(tbSettingsStartupDelay.Text * 1000)             ' Give Grbl time to wake up from Reset

                    RaiseEvent Connected("Connected")      ' tell everyone of the happy event
                Else
                    MessageBox.Show("Please select a Com port" + vbCr + "or connect the cable", "Connect Error", MessageBoxButtons.OK)
                    grblPort.rescan()
                    Return
                End If
            Case "Disconnect"
                ' it must be a disconnect
                grblPort.Disconnect()
                btnConnect.Text = "Connect"

                ' Stop the status poller
                ' TODO Replace these calls with Event Disconnected handling in each object
                statusPrompt("End")
                status.enableStatus(False)
                jogging.enableJogging(False)
                position.enablePosition(False)
                gcode.enableGCode(False)
                offsets.enableOffsets(False)
                state.EnableState(False)
                settings.EnableState(False)

                RaiseEvent Connected("Disconnected")
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

                btnStatusGetParser.Enabled = False
            Case "Idle"
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

                btnStatusGetParser.Enabled = True
        End Select
    End Sub

    ' Event Handler definitions

    ' These are used to tell other objects that something meaningful happened

    ' Raised when we succesfully connected to Grbl
    Public Event Connected(ByVal msg As String)

End Class
