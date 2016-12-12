
Imports GrblPanel.GrblIF

Partial Class grblgui
    ''' <summary>
    ''' Class to handle overrides related functionality
    ''' </summary>
    Public Enum overrideChars
        CMD_SAFETY_DOOR = 132       '0x84
        CMD_JOG_CANCEL = 133        ' 0x85
        CMD_DEBUG_REPORT = 133      '0x86 ' Only When DEBUG enabled, sends debug report In '{}' braces. 
        CMD_FEED_OVR_RESET = 144    '0x90         ' Restores feed override value To 100%.
        CMD_FEED_OVR_COARSE_PLUS = 145 '0x91
        CMD_FEED_OVR_COARSE_MINUS = 146 ' 0x92
        CMD_FEED_OVR_FINE_PLUS = 147 ' 0x93
        CMD_FEED_OVR_FINE_MINUS = 148 ' 0x94
        CMD_RAPID_OVR_FULL = 149 ' 0x95       'Restores rapid override value To 100%.
        CMD_RAPID_OVR_MEDIUM = 150 '0x96
        CMD_RAPID_OVR_LOW = 151 ' 0x97
        ' CMD_RAPID_OVR_EXTRA_LOW 0x98 ' *Not SUPPORTED*
        CMD_SPINDLE_OVR_RESET = 153     ' 0x99      ' Restores spindle override value To 100%.
        CMD_SPINDLE_OVR_COARSE_PLUS = 154 ' 0x9A
        CMD_SPINDLE_OVR_COARSE_MINUS = 155 ' 0x9B
        CMD_SPINDLE_OVR_FINE_PLUS = 156 ' 0x9C
        CMD_SPINDLE_OVR_FINE_MINUS = 157 '0x9D
        CMD_SPINDLE_OVR_STOP = 158  '0x9E aka Toogle Spindle Stop
        CMD_TOGGLE_FLOOD = 160      ' 0xA0
        CMD_TOGGLE_MIST = 161       ' 0xA1
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

        ' Process Override values, Grbl 1.x only
        If data.Contains("Ov:") Or data.Contains("A:") Then
            data = data.Remove(data.Length - 3, 3)
            Dim statusMessage = Split(data, "|")
            For Each item As String In statusMessage
                Dim portion() As String = Split(item, ":")
                Select Case portion(0)
                    Case "Ov"
                        Dim ovr = Split(portion(1), ",")
                        tbFeedOvr.Text = ovr(0) + "%"
                        tbRapidOvr.Text = ovr(1) + "%"
                        tbSpindleOvr.Text = ovr(2) + "%"
                        If Not data.Contains("A") Then
                            btnSpindleOverride.BackColor = Color.Transparent
                            btnFloodOverride.BackColor = Color.Transparent
                            btnMistOverride.BackColor = Color.Transparent
                        End If
                    Case "A"
                        If portion(1).Contains("S") Then
                            btnSpindleOverride.BackColor = Color.Crimson
                        Else
                            btnSpindleOverride.BackColor = Color.Transparent
                        End If
                        If portion(1).Contains("F") Then
                            btnFloodOverride.BackColor = Color.Crimson
                        Else
                            btnFloodOverride.BackColor = Color.Transparent
                        End If
                        If portion(1).Contains("M") Then
                            btnMistOverride.BackColor = Color.Crimson
                        Else
                            btnMistOverride.BackColor = Color.Transparent
                        End If
                End Select
            Next
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
    Private Sub btnRapidOverride_Click(sender As Object, e As EventArgs) Handles btnRapidOverrideReset.Click, btnRapidOverride50.Click, btnRapidOverride25.Click
        Dim btn As Button = sender

        Select Case DirectCast(btn.Tag, String)
            Case "50"
                grblPort.sendData(Chr(overrideChars.CMD_RAPID_OVR_MEDIUM))
            Case "25"
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
            Case "Rapid"
                grblPort.sendData(Chr(overrideChars.CMD_RAPID_OVR_FULL))
            Case "Feed"
                grblPort.sendData(Chr(overrideChars.CMD_FEED_OVR_RESET))
            Case "Spindle"
                grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_RESET))
        End Select
    End Sub
    ''' <summary>
    ''' Handle toggle of some overrides, constrained by present state
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnToggleOverride_Click(sender As Object, e As EventArgs) Handles btnSpindleOverride.Click, btnMistOverride.Click, btnFloodOverride.Click
        ' Spindle toggle only in Hold
        ' Coolant and Mist in Idle,Run or Hold
        Dim btn As Button = sender
        Select Case DirectCast(btn.Tag, String)
            Case "SpindleOverride"
                grblPort.sendData(Chr(overrideChars.CMD_SPINDLE_OVR_STOP))
            Case "FloodOverride"
                grblPort.sendData(Chr(overrideChars.CMD_TOGGLE_FLOOD))
            Case "MistOverride"
                grblPort.sendData(Chr(overrideChars.CMD_TOGGLE_MIST))
        End Select
        ' btn colour changes based on A:SFM response handled in showOverrides()
    End Sub
End Class
