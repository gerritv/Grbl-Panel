Imports GrblPanel.GrblIF

Partial Class GrblGui
    Public Class GrblPosition
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)
            _gui = gui
            ' For Connected events
            AddHandler(GrblGui.Connected), AddressOf GrblConnected
            AddHandler(_gui.settings.GrblSettingsRetrievedEvent), AddressOf GrblSettingsRetrieved
        End Sub

        Public Sub enablePosition(ByVal action As Boolean)
            _gui.gbPosition.Enabled = action
            If action = True Then
                _gui.grblPort.addRcvDelegate(AddressOf _gui.showGrblPositions)
            Else
                _gui.grblPort.deleteRcvDelegate(AddressOf _gui.showGrblPositions)
            End If
        End Sub

        Public Sub shutdown()
            ' Close up shop
            enablePosition(False)
        End Sub

        Private Sub GrblConnected(ByVal msg As String)     ' Handles GrblGui.Connected Event
            If msg = "Connected" Then

                ' We are connected to Grbl so highlight need for Homing Cycle
                _gui.btnHome.BackColor = Color.Crimson
            End If
        End Sub

        Private Sub GrblSettingsRetrieved()  ' Handles the named event
            ' Settings from Grbl are now available to query
            If _gui.settings.IsHomingEnabled = 1 Then
                ' Enable the Home Cycle button
                _gui.btnHome.Visible = True
            End If

            _gui.cbUnits.Checked = _gui.settings.IsGrblMetric

        End Sub

        Private _wcoX As Decimal
        Public Property WcoX() As Decimal
            Get
                Return _wcoX
            End Get
            Set(ByVal value As Decimal)
                _wcoX = value
            End Set
        End Property
        Private _wcoY As Decimal
        Public Property WcoY() As Decimal
            Get
                Return _wcoY
            End Get
            Set(ByVal value As Decimal)
                _wcoY = value
            End Set
        End Property

        Private _wcoZ As Decimal
        Public Property WcoZ() As Decimal
            Get
                Return _wcoZ
            End Get
            Set(ByVal value As Decimal)
                _wcoZ = value
            End Set
        End Property
    End Class


    Public Sub showGrblPositions(ByVal data As String)
        Dim positions() As String

        ' Show data in the Positions group (from our own thread)
        If data = vbCrLf Then Return

        If GrblVersion = 0 Then
            ' Grbl versions 0.x, assume/expect $10=3 or equivalent 
            data = data.Remove(data.Length - 3, 3)   ' Remove the "> " at end
            If (data.Contains("MPos:")) Then
                ' Lets display the values
                positions = Split(data, ":")
                ' MPos will always be first
                Dim machPos = Split(positions(1), ",")

                tbMachX.Text = machPos(0).ToString
                tbMachY.Text = machPos(1).ToString
                tbMachZ.Text = machPos(2).ToString
                'Set same values into the repeater view on Offsets page
                tbOffSetsMachX.Text = machPos(0).ToString
                tbOffSetsMachY.Text = machPos(1).ToString
                tbOffSetsMachZ.Text = machPos(2).ToString

            End If
            If (data.Contains("WPos:")) Then
                Dim workPos() As String
                positions = Split(data, ":")
                ' WPos might be first or it might be second (if MPos is also present)
                If positions.Count = 2 Then
                    workPos = Split(positions(1), ",")
                Else
                    workPos = Split(positions(2), ",")
                End If
                tbWorkX.Text = workPos(0).ToString
                tbWorkY.Text = workPos(1).ToString
                tbWorkZ.Text = workPos(2).ToString
            End If

        End If

        If GrblVersion = 1 Then
            ' Grbl/Gnea versions 1.x
            If data.StartsWith("<") Then
                data = data.Remove(data.Length - 3, 3)
                Dim statusMessage = Split(data, "|")
                For Each item As String In statusMessage
                    Dim portion() As String = Split(item, ":")
                    ' Pn, Ov, T are handled in their respective objects
                    Select Case portion(0)
                        Case "WCO"
                            ' WCO appears now and then or if it changes
                            Dim wco = Split(portion(1), ",")
                            position.WcoX = wco(0)
                            position.WcoY = wco(1)
                            position.WcoZ = wco(2)
                        Case "MPos"
                            ' We get Mpos but no WPos depending on $10
                            Dim machPos = Split(portion(1), ",")
                            tbMachX.Text = TruncRound(Convert.ToDecimal(machPos(0))).ToString
                            tbMachY.Text = TruncRound(Convert.ToDecimal(machPos(1))).ToString
                            tbMachZ.Text = TruncRound(Convert.ToDecimal(machPos(2))).ToString
                            If Not tbWorkX.ContainsFocus Then
                                tbWorkX.Text = TruncRound(Convert.ToDecimal(machPos(0)) - position.WcoX).ToString
                            End If
                            If Not tbWorkY.ContainsFocus Then
                                tbWorkY.Text = TruncRound(Convert.ToDecimal(machPos(1)) - position.WcoY).ToString
                            End If
                            If Not tbWorkZ.ContainsFocus Then
                                tbWorkZ.Text = TruncRound(Convert.ToDecimal(machPos(2)) - position.WcoZ).ToString
                            End If
                            'Set same values into the repeater view on Offsets page
                            tbOffSetsMachX.Text = tbMachX.Text
                            tbOffSetsMachY.Text = tbMachY.Text
                            tbOffSetsMachZ.Text = tbMachZ.Text
                        Case "WPos"
                            ' We get WPos but no MPos depending on $10
                            Dim workPos = Split(portion(1), ",")
                            If Not tbWorkX.ContainsFocus Then
                                tbWorkX.Text = TruncRound(Convert.ToDecimal(workPos(0))).ToString
                            End If
                            If Not tbWorkY.ContainsFocus Then
                                tbWorkY.Text = TruncRound(Convert.ToDecimal(workPos(1))).ToString
                            End If
                            If Not tbWorkZ.ContainsFocus Then
                                tbWorkZ.Text = TruncRound(Convert.ToDecimal(workPos(2))).ToString
                            End If
                            tbMachX.Text = TruncRound(Convert.ToDecimal(workPos(0)) + position.WcoX).ToString
                            tbMachY.Text = TruncRound(Convert.ToDecimal(workPos(1)) + position.WcoY).ToString
                            tbMachZ.Text = TruncRound(Convert.ToDecimal(workPos(2)) + position.WcoZ).ToString

                    End Select
                Next

            End If
        End If
    End Sub

    ''' <summary>
    ''' Round per Settings
    ''' </summary>
    ''' <returns></returns>
    Private Function TruncRound(value As Decimal) As Decimal


        If tbTruncationDigits.Text = "0" Then
            Return value
        Else
            If IsNumeric(tbTruncationDigits.Text) Then
                Return Math.Round(Convert.ToDecimal(value), Convert.ToInt16(tbTruncationDigits.Text))
            End If
            Return value
        End If



    End Function
    Private Sub btnPosition_Click(sender As Object, e As EventArgs) Handles btnWork0.Click, btnHome.Click, btnWorkSoftHome.Click, btnWorkSpclPosition.Click
        Dim b As Button = sender
        Select Case DirectCast(b.Tag, String)
            Case "HomeCycle"
                ' Send Home command string
                gcode.sendGCodeLine("$H")
                btnHome.BackColor = Color.Transparent       ' In case it was crimson for inital connect
                tabCtlPosition.SelectedTab = tpWork         ' And show them the Work tab
            Case "Spcl Posn1"
                gcode.sendGCodeLine(tbSettingsSpclPosition1.Text)
            Case "Spcl Posn2"
                gcode.sendGCodeLine(tbSettingsSpclPosition2.Text)
            Case "ZeroXYZ"
                gcode.sendGCodeLine(tbSettingsZeroXYZCmd.Text)
        End Select

    End Sub
    Private Sub btnWorkXYZ0_Click(sender As Object, e As EventArgs) Handles btnWorkX0.Click, btnWorkY0.Click, btnWorkZ0.Click
        Dim btn As Button = sender
        Select Case DirectCast(btn.Tag, String)
            Case "X"
                gcode.sendGCodeLine(My.Settings.WorkX0Cmd)
            Case "Y"
                gcode.sendGCodeLine(My.Settings.WorkY0Cmd)
            Case "Z"
                gcode.sendGCodeLine(My.Settings.WorkZ0Cmd)
        End Select

    End Sub
    ''' <summary>
    ''' Support for entering Work Pos directly, clear text on focus
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub tbWork_Click(sender As Object, e As EventArgs) Handles tbWorkX.Click, tbWorkY.Click, tbWorkZ.Click
        Dim tb As TextBox = sender

        tb.Text = ""
    End Sub

End Class
