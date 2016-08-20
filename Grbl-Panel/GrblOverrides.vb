
Imports GrblPanel.GrblIF

Partial Class grblgui
    ''' <summary>
    ''' Class to handle overrides related functionality
    ''' </summary>
    Public Enum overrideChars
        CMD_SAFETY_DOOR = 132 '0x84
        CMD_DEBUG_REPORT = 133 '0x85 ' Only When DEBUG enabled, sends debug report In '{}' braces. 
        CMD_FEED_OVR_RESET = 144 '0x90         ' Restores feed override value To 100%.
        CMD_FEED_OVR_COARSE_PLUS = 145 '0x91
        CMD_FEED_OVR_COARSE_MINUS = 146 ' 0x92
        CMD_FEED_OVR_FINE_PLUS = 147 ' 0x93
        CMD_FEED_OVR_FINE_MINUS = 148 ' 0x94
        CMD_RAPID_OVR_RESET = 149 ' 0x95       'Restores rapid override value To 100%.
        CMD_RAPID_OVR_MEDIUM = 150 '0x96
        CMD_RAPID_OVR_LOW = 151 ' 0x97
        ' CMD_RAPID_OVR_EXTRA_LOW 0x98 ' *Not SUPPORTED*
        CMD_SPINDLE_OVR_RESET = 153 ' 0x99      ' Restores spindle override value To 100%.
        CMD_SPINDLE_OVR_COARSE_PLUS = 154 ' 0x9A
        CMD_SPINDLE_OVR_COARSE_MINUS = 155 ' 0x9B
        CMD_SPINDLE_OVR_FINE_PLUS = 156 ' 0x9C
        CMD_SPINDLE_OVR_FINE_MINUS = 157 '0x9D
        CMD_SPINDLE_OVR_STOP = 158 '0x9E
    End Enum
    Public Class GrblOverrides
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)
            _gui = gui

            ' We wait to enable Overrides panel until we know if Grbl supports it (V1.0 and later)
            AddHandler(_gui.settings.GrblSettingsRetrieved), AddressOf GrblSettingsRetrieved

            ' For Connected events
            AddHandler(GrblGui.Connected), AddressOf GrblConnected
        End Sub

        Private Sub GrblSettingsRetrieved()  ' Handles the named event
            ' Settings from Grbl are now available to query
            If _gui.settings.IsOverrideCapable Then
                ' Enable the Overrides section
                _gui.gbOverrides.Visible = True
            End If

        End Sub

        Private Sub GrblConnected(ByVal msg As String)

            If msg = "Connected" Then
                _gui.grblPort.addRcvDelegate(AddressOf _gui.showOverrides)
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.showOverrides)
            End If
        End Sub
    End Class

    Public Sub showOverrides(ByVal data As String)

        Dim _ovrIndex As Integer
        Dim _ovr As String()

        _ovrIndex = data.LastIndexOf("OVR:")
        If _ovrIndex = -1 Then
            Return
        Else
            data = data.Remove(data.Length - 3, 3) ' Remove > and vbCrLf
            ' We have Grbl V1.0 or later so display overrides
            _ovr = data.Substring(_ovrIndex + 4).Split(",")
            tbFeedOvr.Text = _ovr(0) + "%"
            tbRapidOvr.Text = _ovr(1) + "%"
            tbSpindleOvr.Text = _ovr(2) + "%"
        End If
    End Sub
    ''' <summary>
    ''' Handles the Click event of the btnFeedOverride controls.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub btnFeedOverride_Click(sender As Object, e As EventArgs) Handles btnFeedPlus.Click, btnFeedMinus.Click

        Dim btn As Button = sender

        Select Case DirectCast(btn.Tag, String)
            Case "plus"
                If cbFeedCoarse.Checked Then
                    grblPort.sendData(Chr(overrideChars.CMD_FEED_OVR_COARSE_PLUS))
                Else
                    grblPort.sendData(Chr(overrideChars.CMD_FEED_OVR_FINE_PLUS))
                End If
            Case "minus"
                If cbFeedCoarse.Checked Then
                    grblPort.sendData(Chr(overrideChars.CMD_FEED_OVR_COARSE_MINUS))
                Else
                    grblPort.sendData(Chr(overrideChars.CMD_FEED_OVR_FINE_MINUS))
                End If
        End Select
    End Sub
    Private Sub btnRapidOverride_Click(sender As Object, e As EventArgs) Handles btnRapidPlus.Click, btnRapidMinus.Click
        Dim btn As Button = sender

        Select Case DirectCast(btn.Tag, String)
            Case "plus"
                grblPort.sendData(Chr(overrideChars.CMD_RAPID_OVR_MEDIUM))
            Case "minus"
                grblPort.sendData(Chr(overrideChars.CMD_RAPID_OVR_LOW))
        End Select
    End Sub
    Private Sub btnSpindleOverride_Click(sender As Object, e As EventArgs) Handles btnSpindlePlus.Click, btnSpindleMinus.Click
        Dim btn As Button = sender

        Select Case DirectCast(btn.Tag, String)
            Case "plus"
                If cbSpindleCoarse.Checked Then
                    grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_COARSE_PLUS))
                Else
                    grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_FINE_PLUS))
                End If
            Case "minus"
                If cbSpindleCoarse.Checked Then
                    grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_COARSE_MINUS))
                Else
                    grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_FINE_MINUS))
                End If
        End Select
    End Sub

    Private Sub btnFeedOverrideReset_Click(sender As Object, e As EventArgs) Handles btnFeedOverrideReset.Click, btnSpindleOverrideReset.Click, btnRapidOverrideReset.Click
        Dim btn As Button = sender
        Select Case DirectCast(btn.Tag, String)
            Case "Feed"
                grblPort.sendData(Chr(overrideChars.CMD_FEED_OVR_RESET))
            Case "Rapid"
                grblPort.sendData(Chr(overrideChars.CMD_RAPID_OVR_RESET))
            Case "Spindle"
                grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_RESET))
        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnRapidMinus.Click

        grblPort.sendData(Chr(overrideChars.CMD_DEBUG_REPORT))
    End Sub
End Class
