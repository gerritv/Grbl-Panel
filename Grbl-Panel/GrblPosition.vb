Imports GrblPanel.GrblIF

Partial Class GrblGui
    Public Class GrblPosition
        Private _gui As GrblGui

        Public Sub New(ByRef gui As GrblGui)
            _gui = gui
            ' For Connected events
            AddHandler (GrblGui.Connected), AddressOf GrblConnected
            AddHandler (_gui.settings.GrblSettingsRetrieved), AddressOf GrblSettingsRetrieved
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

        End Sub
    End Class


    Public Sub showGrblPositions(ByVal data As String)
        ' We come here from the recv_data thread so have to do this trick to cross threads
        ' (http://msdn.microsoft.com/en-ca/library/ms171728(v=vs.85).aspx)

        'Console.WriteLine("showGrblPosition: " + data)
        If Me.tbWorkX.InvokeRequired Then
            ' we need to cross thread this callback
            Dim ncb As New grblDataReceived(AddressOf Me.showGrblPositions)
            Me.BeginInvoke(ncb, New Object() {data})
            Return
        Else
            ' Show data in the Positions group (from our own thread)
            If (data.Contains("MPos:")) Then
                ' Lets display the values
                data = data.Remove(data.Length - 3, 3)   ' Remove the "> " at end
                Dim positions = Split(data, ":")
                Dim machPos = Split(positions(1), ",")
                Dim workPos = Split(positions(2), ",")

                tbMachX.Text = machPos(0).ToString
                tbMachY.Text = machPos(1).ToString
                tbMachZ.Text = machPos(2).ToString

                tbWorkX.Text = workPos(0).ToString
                tbWorkY.Text = workPos(1).ToString
                tbWorkZ.Text = workPos(2).ToString

                'Set same values into the repeater view on Offsets page
                tbOffSetsMachX.Text = machPos(0).ToString
                tbOffSetsMachY.Text = machPos(1).ToString
                tbOffSetsMachZ.Text = machPos(2).ToString

            End If
        End If
    End Sub

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

End Class
