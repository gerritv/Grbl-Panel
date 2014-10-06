Imports System.ConsoleKey
Imports RepeatButton

Partial Class GrblGui
    Public Class GrblJogging
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)

            _gui = gui

            ' Do set up things
            With My.Settings
                _gui.tbSettingsFIImperial.Text = .JoggingFIImperial
                _gui.tbSettingsFRImperial.Text = .JoggingFRImperial
                _gui.tbSettingsFIMetric.Text = .JoggingFIMEtric
                _gui.tbSettingsFRMetric.Text = .JoggingFRMetric
                _gui.cbSettingsMetric.Checked = .JoggingUnitsMetric

                _gui.setDistanceMetric(_gui.cbSettingsMetric.Checked)

                _gui.btnXPlus.Interval = 1000 / .JoggingXRepeat
                _gui.btnXMinus.Interval = 1000 / .JoggingXRepeat
                _gui.btnYPlus.Interval = 1000 / .JoggingYRepeat
                _gui.btnYMinus.Interval = 1000 / .JoggingYRepeat
                _gui.btnZPlus.Interval = 1000 / .JoggingZRepeat
                _gui.btnZMinus.Interval = 1000 / .JoggingZRepeat
            End With

        End Sub
        Public Function enableJogging(ByVal action As Boolean) As Boolean
            ' Enable/disable jogging functions
            _gui.gbJogging.Enabled = action
            Return True
        End Function

        Public Sub shutdown()
            ' Close up shop
            enableJogging(False)
        End Sub

    End Class
    'Private Sub btnJogArray_MouseClick(sender As Object, e As EventArgs) Handles btnXPlus.Click, btnXMinus.Click, btnYPlus.Click, btnYMinus.Click, _
    '                                                                       btnZPlus.Click, btnZMinus.Click
    '    If whichDistance() = "" Or whichFeedRate() = "" Then
    '        MessageBox.Show("Please set Distance and Feed Rate first")
    '        Return
    '    End If
    'End Sub
    Private Sub btnJogArray_Click(sender As Object, e As EventArgs) Handles btnXPlus.Click, btnXMinus.Click, btnYPlus.Click, btnYMinus.Click, _
                                                                           btnZPlus.Click, btnZMinus.Click
        Dim btn As RepeatButton.RepeatButton = sender
        If whichDistance() = "" Or whichFeedRate() = "" Then
            MessageBox.Show("Please set Distance and Feed Rate first", "", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
            Return
        End If
        Select Case btn.Tag
            Case "X+"
                gcode.sendGCodeLine(createJogCommand("X"))
            Case "X-"
                gcode.sendGCodeLine(createJogCommand("X-"))
            Case "Y+"
                gcode.sendGCodeLine(createJogCommand("Y"))
            Case "Y-"
                gcode.sendGCodeLine(createJogCommand("Y-"))
            Case "Z+"
                gcode.sendGCodeLine(createJogCommand("Z"))
            Case "Z-"
                gcode.sendGCodeLine(createJogCommand("Z-"))
        End Select
        gcode.sendGCodeLine("G90")
    End Sub

    Private Sub btnJogArray_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

        ' Handle key press events, if configured to do so


        If cbSettingsKeyboardJogging.Checked Then
            If whichDistance() = "" Or whichFeedRate() = "" Then
                ' We have no parameters, give message
                MessageBox.Show("Please set Distance and Feed Rate first")
                Return
            End If

            Select Case e.KeyCode
                Case Keys.Left
                    gcode.sendGCodeLine(createJogCommand("X-"))
                    e.Handled = True
                Case Keys.Right
                    gcode.sendGCodeLine(createJogCommand("X"))
                    e.Handled = True
                Case Keys.Up
                    gcode.sendGCodeLine(createJogCommand("Y"))
                    e.Handled = True
                Case Keys.Down
                    gcode.sendGCodeLine(createJogCommand("Y-"))
                    e.Handled = True
                Case Keys.PageUp
                    gcode.sendGCodeLine(createJogCommand("Z"))
                    e.Handled = True
                Case Keys.PageDown
                    gcode.sendGCodeLine(createJogCommand("Z-"))
                    e.Handled = True
            End Select
            If e.Handled Then
                gcode.sendGCodeLine("G90")
            End If
        End If
    End Sub

    Private Sub cbSettingsMetric_CheckedChanged(sender As Object, e As EventArgs) Handles cbSettingsMetric.CheckedChanged
        Dim cb As CheckBox = sender
        cbUnits.Checked = cb.Checked
    End Sub

    Public Sub setDistanceMetric(ByVal metric As Boolean)
        ' set distance units as metric or imperial
        Dim info As String()
        If metric Then
            info = Split(gbSettingsJogging.Controls("tbSettingsFIMetric").Text, ",")
            If info.Count = 4 Then
                rbDistance1.Text = info(0)
                rbDistance2.Text = info(1)
                rbDistance3.Text = info(2)
                rbDistance4.Text = info(3)
            End If
            info = Split(tbSettingsFRMetric.Text, ",")
            If info.Count = 4 Then
                rbFeedRate1.Text = info(0)
                rbFeedRate2.Text = info(1)
                rbFeedRate3.Text = info(2)
                rbFeedRate4.Text = info(3)
            End If
        Else
            info = Split(tbSettingsFIImperial.Text, ",")
            If info.Count = 4 Then
                rbDistance1.Text = info(0)
                rbDistance2.Text = info(1)
                rbDistance3.Text = info(2)
                rbDistance4.Text = info(3)
            End If

            info = Split(tbSettingsFRImperial.Text, ",")
            If info.Count = 4 Then
                rbFeedRate1.Text = info(0)
                rbFeedRate2.Text = info(1)
                rbFeedRate3.Text = info(2)
                rbFeedRate4.Text = info(3)
            End If
        End If

    End Sub
    Private Sub cbUnits_CheckedChanged(sender As CheckBox, e As EventArgs) Handles cbUnits.CheckedChanged
        ' Set reasonable values into the Distance and Feed Rate radio buttons

        setDistanceMetric(sender.Checked)
    End Sub

    Private Function createJogCommand(ByVal axis As String) As String
        ' Builds a jog command from various inputs
        ' Jog in incremental mode, leave parser in absolute mode!
        Return "G91 " + whichUnits() + " G01 " + axis + whichDistance() + " F" + whichFeedRate()
    End Function

    Private Function whichDistance() As String
        ' Return the value of cbDistance that is checked
        Dim distance As String
        For Each rb As RadioButton In gbDistance.Controls
            If rb.Checked Then
                distance = rb.Text
                Return distance
            End If
        Next
        Return ""
    End Function

    Private Function whichFeedRate() As String
        ' Return the value of cbDistance that is checked
        Dim rate As String
        For Each rb As RadioButton In gbFeedRate.Controls
            If rb.Checked Then
                rate = rb.Text
                Return rate
            End If
        Next
        Return ""
    End Function

    Private Function whichUnits() As String
        If cbUnits.Checked Then
            Return "G21"
        Else
            Return "G20"
        End If
    End Function

End Class

