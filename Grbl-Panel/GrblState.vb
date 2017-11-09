Partial Class GrblGui
    Public Class GrblState

        ' A class to track and display Gcode state
        ' e.g. to show active G90/91 or Work/Fixture offset

        ' Gets fed each line of Gcode before it is sent to 
        ' Gets fed the response to $G (Parser state)
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)
            ' Get ref to parent object
            _gui = gui
            ' For Connected events
            AddHandler (GrblGui.Connected), AddressOf GrblConnected

        End Sub
        Public Sub EnableState(ByVal yes As Boolean)

            If yes Then
                _gui.gbState.Enabled = True
            Else
                _gui.gbState.Enabled = False
            End If
        End Sub

        Public Sub GrblConnected(ByVal msg As String)     ' Handles GrblGui.Connected Event
            If msg = "Connected" Then

                ' We are connected to Grbl so populate the State
                gcode.sendGCodeLine("$G")
            End If
        End Sub

        Public Sub ProcessGCode(ByVal line As String)
            ' parse the line for codes we are interested in
            ' We get our data from:
            ' - Outbound Gcode
            ' - Response from Grbl to $G

            Dim ignore As Char() = {"$", "!", "~", "?", "("}
            Dim codes As Char() = {"M", "T", "S", "G", "F"}
            Dim allcodes As Char() = {"M", "T", "F", "G", "P", "S", "X", "Y", "Z", "I", "J", "K", " ", "[", "]", vbLf}
            Dim spclcodes As Char() = {"T", "S", "F"}
            Dim collect As Boolean = False          ' collect code characters
            Dim gcodes() As String = {}      ' the gcodes found
            Dim gcodeIndex As Integer = 0           ' current entry being processed

            Dim comment As Boolean = False
            If line.Length = 0 Then     ' Deal with blank lines
                Return
            End If
            If ignore.Contains(line(0)) Or (Not allcodes.Contains(line(0))) Then
                Return                              ' ignore lines with no gcode
            End If
            For Each c As Char In line
                If c = "(" Then
                    Exit For    ' we are done parsing this line
                End If
                If allcodes.Contains(c) Then        ' did we find a gcode block?
                    collect = False                 ' we reached end of what we were collecting
                    If codes.Contains(c) Then       ' is it one we care about?
                        collect = True
                        ReDim Preserve gcodes(gcodeIndex + 1)
                        gcodes(gcodeIndex) = c
                        gcodeIndex += 1
                    End If
                Else
                    If collect Then                     ' are we in a gcode block?
                        gcodes(gcodeIndex - 1) += c
                    End If
                End If
            Next
            ' parsing done, lets see what we 
            '(settings are explicit to avoid showing an assumed value. If we don't know, then box is empty)
            ' TODO Remove leading 0's from numbers
            For Each code In gcodes
                If IsNothing(code) Then
                    Exit For
                End If
                If spclcodes.Contains(code(0)) Then
                    ' Handle F, S and T
                    Select Case code(0)
                        Case "T"
                            _gui.tbStateTool.Text = code.Remove(0, 1)
                        Case "S"
                            _gui.tbStateSpindleRPM.Text = code.Remove(0, 1)
                        Case "F"
                            _gui.tbStateFeedRate.Text = code.Remove(0, 1)
                    End Select
                Else
                    Select Case code
                        Case "G20", "G21"
                            _gui.cbxStateUnits.SelectedItem = find(_gui.cbxStateUnits, code)
                        Case "G54", "G55", "G56", "G57", "G58", "G59"
                            _gui.cbxStateOffset.SelectedItem = find(_gui.cbxStateOffset, code)
                            _gui.lblPositionCurrentOffset.Text = code 'find(_gui.cbxStateOffset, code)
                        Case "G90", "G91"
                            _gui.cbxStateDistance.SelectedItem = find(_gui.cbxStateDistance, code)
                        Case "G93", "G94"
                            _gui.cbxStateFeedMode.SelectedItem = find(_gui.cbxStateFeedMode, code)
                        Case "G17", "G18", "G19"
                            ' Plane           
                            _gui.cbxStatePlane.SelectedItem = find(_gui.cbxStatePlane, code)
                        Case "M3", "M4", "M5"
                            ' Motor control
                            _gui.cbxStateSpindle.SelectedItem = find(_gui.cbxStateSpindle, code)
                        Case "M8", "M9"
                            _gui.cbxStateCoolant.SelectedItem = find(_gui.cbxStateCoolant, code)
                    End Select
                End If
                Dim x = 1
            Next

        End Sub

        Private Function find(ByVal bx As ComboBox, ByVal code As String) As Object
            ' I should overload ComboBox FindString but then we get a custom control :-(
            ' so we do this instead
            For Each i As Object In bx.Items
                If i.ToString.Contains(code) Then
                    Return i
                End If
            Next
            Return Nothing
        End Function
    End Class

    Private Sub cbxState_SelectionChangeCommittted(sender As Object, e As EventArgs) Handles cbxStateDistance.SelectionChangeCommitted, cbxStateFeedMode.SelectionChangeCommitted, _
                                                                            cbxStateUnits.SelectionChangeCommitted, cbxStateCoolant.SelectionChangeCommitted, _
                                                                            cbxStateOffset.SelectionChangeCommitted, cbxStatePlane.SelectionChangeCommitted, _
                                                                            cbxStateSpindle.SelectionChangeCommitted
        ' Send new setting to Grbl
        Dim cbx As ComboBox = sender
        Dim code As String = cbx.SelectedItem
        If code <> "" Then
            code = code.Substring(code.Length - 3, 3)
            gcode.sendGCodeLine(code)
        End If
    End Sub
End Class
