Imports System.ConsoleKey
Imports RepeatButton

Partial Class GrblGui
    Public Class GrblJogging
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)

            _gui = gui

            AddHandler(_gui.settings.GrblSettingsRetrievedEvent), AddressOf GrblSettingsRetrieved
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

                ' Set the default feed rate and increment
                For Each rb As RadioButton In _gui.gbDistance.Controls
                    If DirectCast(rb.Tag, String) = My.Settings.JoggingFIDefault Then
                        rb.Checked = True
                    End If
                Next
                For Each rb As RadioButton In _gui.gbFeedRate.Controls
                    If DirectCast(rb.Tag, String) = My.Settings.JoggingFRDefault Then
                        rb.Checked = True
                    End If
                Next
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

        Private Sub GrblSettingsRetrieved()  ' Handles the named event

            _gui.cbUnits.Checked = _gui.settings.IsGrblMetric

        End Sub
    End Class

    Private Sub btnJogArray_Click(sender As Object, e As EventArgs) Handles btnXPlus.Click, btnXMinus.Click, btnYPlus.Click, btnYMinus.Click, _
                                                                           btnZPlus.Click, btnZMinus.Click
        Dim btn As RepeatButton.RepeatButton = sender
        Select Case DirectCast(btn.Tag, String)
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
        If GrblVersion = 0 Then
            gcode.sendGCodeLine("G90")
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
    ''' <summary>
    ''' Changes Distance and Feed Rate to new units
    ''' </summary>
    ''' <param name="sender">The sender.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub cbUnits_CheckedChanged(sender As CheckBox, e As EventArgs) Handles cbUnits.CheckedChanged
        ' Set reasonable values into the Distance and Feed Rate radio buttons

        setDistanceMetric(sender.Checked)
    End Sub
    ''' <summary>
    ''' Creates a jog command string.
    ''' </summary>
    ''' <param name="axis">The axis.</param>
    ''' <returns></returns>
    Public Function createJogCommand(ByVal axis As String) As String
        ' Builds a jog command from various inputs
        ' Jog in incremental mode, leave parser in absolute mode!
        If GrblVersion = 0 Then
            Return "G91 " + whichUnits() + " G01 " + axis + whichDistance() + " F" + whichFeedRate()
        End If
        If GrblVersion = 1 Then
            Return "$J=G91" + whichUnits() + axis + whichDistance() + " F" + whichFeedRate()
        End If
        Return ""
    End Function
    ''' <summary>
    ''' Return value of current Distance Increment
    ''' </summary>
    ''' <returns>distance</returns>
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
    ''' <summary>
    ''' Return value of current feed rate.
    ''' </summary>
    ''' <returns>feed rate</returns>
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
    ''' <summary>
    ''' Returns Units gcode
    ''' </summary>
    ''' <returns>G20 or G21</returns>
    Private Function whichUnits() As String
        If cbUnits.Checked Then
            Return "G21"
        Else
            Return "G20"
        End If
    End Function
    ''' <summary>
    ''' Handles the CheckedChanged event of the rbDistancex control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    Private Sub rbDistancex_CheckedChanged(sender As Object, e As EventArgs) Handles rbDistance1.CheckedChanged, rbDistance2.CheckedChanged, rbDistance3.CheckedChanged,
                                                                                    rbDistance4.CheckedChanged, rbFeedRate2.CheckedChanged, rbFeedRate1.CheckedChanged,
                                                                                   rbFeedRate3.CheckedChanged, rbFeedRate4.CheckedChanged
        ' Remember the setting
        Dim rbtn As RadioButton = sender
        Select Case DirectCast(rbtn.Tag, String)
            Case "I1", "I2", "I3", "I4"
                My.Settings.JoggingFIDefault = rbtn.Tag
            Case "F1", "F2", "F3", "F4"
                My.Settings.JoggingFRDefault = rbtn.Tag
        End Select
    End Sub
    ''' <summary>
    ''' Changes the distance increment, up or down.
    ''' </summary>
    ''' <param name="up">if set to <c>true</c> [direction].</param>
    Public Sub changeDistanceIncrement(ByVal up As Boolean)
        ' We don't wrap, if we are at bottom of group and asked to go down again, we ignore request
        Dim index As Integer = 0
        ' find the one selected at present
        For Each rb As RadioButton In gbDistance.Controls
            If rb.Checked Then
                Exit For
            End If
            index += 1
        Next
        If up = False Then
            If index < 3 Then
                ' we check the next one down
                Dim rb As RadioButton = gbDistance.Controls(index + 1)
                rb.Checked = True
            End If
        Else
            If index > 0 Then
                ' we check the next one up
                Dim rb As RadioButton = gbDistance.Controls(index - 1)
                rb.Checked = True
            End If
        End If
    End Sub
    ''' <summary>
    ''' Changes the feed rate, up or down.
    ''' </summary>
    ''' <param name="up">if set to <c>true</c> [up].</param>
    Public Sub changeFeedRate(ByVal up As Boolean)
        ' We don't wrap, if we are at bottom of group and asked to go down again, we ignore request
        Dim index As Integer = 0
        ' find the one selected at present
        For Each rb As RadioButton In gbFeedRate.Controls
            If rb.Checked Then
                Exit For
            End If
            index += 1
        Next
        If up = False Then
            If index < 3 Then
                ' we check the next one down
                Dim rb As RadioButton = gbFeedRate.Controls(index + 1)
                rb.Checked = True
            End If
        Else
            If index > 0 Then
                ' we check the next one up
                Dim rb As RadioButton = gbFeedRate.Controls(index - 1)
                rb.Checked = True
            End If
        End If
    End Sub
End Class

