Imports System.Windows.Forms
Imports System.Threading.Thread

Partial Class GrblGui
    Public Class GrblSettings
        ' Handle settings related operations


        Private _gui As GrblGui
        Private _paramTable As DataTable    ' to hold the parameters
        Private _nextParam As Integer       ' to track which param line is next

#Region "Properties"
        ReadOnly Property IsHomingEnabled As Integer
            Get
                Dim row As DataRow
                row = _paramTable.Rows.Find("$22")
                If Not IsNothing(row) Then
                    Return row.Item("Value")
                End If
                Return 0
            End Get
        End Property
#End Region

        Public Sub New(ByRef gui As GrblGui)
            ' Get ref to parent object
            _gui = gui
            ' For Connected events
            AddHandler (_gui.Connected), AddressOf GrblConnected

        End Sub
        Public Sub EnableState(ByVal yes As Boolean)

            If yes Then
                _gui.gbGrblSettings.Enabled = True
            Else
                _gui.gbGrblSettings.Enabled = False
            End If
        End Sub

        Private Sub GrblConnected(ByVal msg As String)     ' Handles GrblGui.Connected Event
            If msg = "Connected" Then

                ' We are connected to Grbl so populate the Settings
                _nextParam = 0
                gcode.sendGCodeLine("$$")
            End If
        End Sub

        Public Sub FillSettings(ByVal data As String)
            ' Add a settings line to the display
            Console.WriteLine(" $ Data is : " + data)
            ' Return
            Dim params() As String
            If _nextParam = 0 Then
                ' We are dealing with a fresh
                _paramTable = New DataTable
                With _paramTable
                    .Columns.Add("ID")
                    .Columns.Add("Value")
                    .Columns.Add("Description")
                    .PrimaryKey = New DataColumn() {.Columns("ID")}
                End With
            End If
            params = data.Split({"="c, "("c, ")"c})
            params(1) = params(1).Replace(" ", "")         ' strip trailing blanks
            _paramTable.Rows.Add(params(0), params(1), params(2))
            _nextParam += 1
            If params(0) = _gui.tbSettingsGrblLastParam.Text Then ' We got the last one
                _nextParam = 0            ' in case user does a MDI $$
                With _gui.dgGrblSettings
                    .DataSource = _paramTable
                    .Columns("ID").Width = 40
                    .Columns("ID").ReadOnly = True
                    .Columns("ID").DefaultCellStyle.BackColor = SystemColors.Control
                    .Columns("Value").Width = 60
                    .Columns("Description").Width = 200
                    .Columns("Description").ReadOnly = True
                    .Columns("Description").DefaultCellStyle.BackColor = SystemColors.Control
                    .Refresh()
                End With
                ' Tell everyone we have the params
                RaiseEvent GrblSettingsRetrieved()
            End If

        End Sub

        ' Event template for Settings Retrieved indication
        Public Event GrblSettingsRetrieved()

    End Class

    ' We need a way to propogate changes on the Settings tab, do that here

    Private Sub btnSettingsRefreshMisc_Click(sender As Object, e As EventArgs) Handles btnSettingsRefreshMisc.Click, btnSettingsRefreshPosition.Click, btnSettingsRefreshJogging.Click
        Dim b As Button = sender
        Select Case DirectCast(b.Tag, String)
            Case "Misc"
                changeStatusRate(My.Settings.StatusPollInterval)
                prgBarQ.Maximum = My.Settings.QBuffMaxSize
                prgbRxBuf.Maximum = My.Settings.RBuffMaxSize
                cbStatusPollEnable.Checked = My.Settings.StatusPollEnabled
                cbSettingsConnectOnLoad.Checked = My.Settings.GrblConnectOnLoad

            Case "Position"
                tbSettingsSpclPosition1.Text = My.Settings.MachineSpclPosition1
                tbSettingsSpclPosition2.Text = My.Settings.MachineSpclPosition2


            Case "Jogging"
                tbSettingsFIImperial.Text = My.Settings.JoggingFIImperial
                tbSettingsFRImperial.Text = My.Settings.JoggingFRImperial
                tbSettingsFIMetric.Text = My.Settings.JoggingFIMEtric
                tbSettingsFRMetric.Text = My.Settings.JoggingFRMetric
                cbSettingsMetric.Checked = My.Settings.JoggingUnitsMetric

                setDistanceMetric(cbSettingsMetric.Checked)

                btnXPlus.Interval = 1000 / My.Settings.JoggingXRepeat
                btnXMinus.Interval = 1000 / My.Settings.JoggingXRepeat
                btnYPlus.Interval = 1000 / My.Settings.JoggingYRepeat
                btnYMinus.Interval = 1000 / My.Settings.JoggingYRepeat
                btnZPlus.Interval = 1000 / My.Settings.JoggingZRepeat
                btnZMinus.Interval = 1000 / My.Settings.JoggingZRepeat
        End Select
    End Sub


    Private Sub btnSettingsGrbl_Click(sender As Object, e As EventArgs) Handles btnSettingsGrbl.Click
        ' Retrieve settings from Grbl
        gcode.sendGCodeLine("$$")
    End Sub


    Private Sub dgGrblSettings_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgGrblSettings.CellMouseDoubleClick
        ' User wants to edit a Grbl setting
        ' We do these one at a time due to EEProm write restrictions
        'Psuedo code:
        ' Which row? Get new value, determine $id, send to Grbl, do a refresh ($$)
        If e.ColumnIndex <> 1 Then
            ' ignore the click, it is not in Value column
            Return
        End If
        Dim gridView As DataGridView = sender
        If Not IsNothing(gridView.EditingControl) Then
            ' we have something to change (aka ignore errant double clicks)
            Dim param As String = gridView.Rows(e.RowIndex).Cells(0).Value.ToString & "=" & gridView.EditingControl.Text
            gcode.sendGCodeLine(param)
            Sleep(200)              ' Have to wait for EEProm write
            gcode.sendGCodeLine("$$")   ' Refresh
        End If
    End Sub
End Class
