Imports System.Windows.Forms
Imports GrblPanel.My

Partial Class GrblGui
    Private bDataChanged As Boolean = False
    ''' <summary>
    ''' The fixed names of Macros in Settings
    ''' </summary>
    Private _macroNames() As String = {"Macro1", "Macro2", "Macro3", "Macro4", "Macro5"}

    Private Sub GrblMacroButtons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim retval As Integer
        If bDataChanged Then
            retval = MsgBox(Resources.GrblGui_GrblMacroButtons_FormClosing_AreYouSureYouWantToExitWithoutSavingYourMacroChanges, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, Resources.GrblGui_GrblMacroButtons_FormClosing_ConfirmExitWithoutSaving)
            If retval = vbYes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub GrblMacroButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillListFromSettings()
        With dgMacros
            .Columns(0).Width = .Width         ' resize the first column to the width of the entire grid, this hides the Gcode column
            'If .RowCount = 0 Then              ' if there are no macros add a default one to the list as an example
            '    .Rows.Add("Probe", "G38.2 Z-30 F10")
            '    bDataChanged = True
            'End If
        End With
        btnAdd.Text = Resources.GrblGui_GrblMacroButtons_Load_Add
        tbName.Text = ""
        tbGCode.Text = ""
    End Sub

    Private Sub FillListFromSettings()
        Dim sTemp() As String

        With dgMacros
            .RowCount = 0                                    ' make sure the grid is empty
            For Each KeyName As String In _macroNames ' add records to the grid 
                sTemp = Split(My.Settings(KeyName), ":")
                If sTemp.Count = 2 Then
                    .Rows.Add(sTemp(0), sTemp(1))
                End If
            Next
            bDataChanged = False                             ' reset our changed data flag
        End With

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        SaveMacros()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
    End Sub

    Private Sub SaveMacros()

        Dim index As Integer = 0

        For Each macro In _macroNames
            My.Settings(macro) = ""
        Next

        For Each row As DataGridViewRow In dgMacros.Rows
            My.Settings(_macroNames(index)) = row.Cells(0).Value.ToString + ":" + row.Cells(1).Value.ToString
            index += 1
        Next
        My.Settings.Save()
        bDataChanged = False

        ' reload onto MDI display
        EnableMacroButtons()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
    End Sub

    Private Sub dgMacros_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgMacros.CellValueChanged
        bDataChanged = True
    End Sub

    Private Sub dgMacros_DoubleClick(sender As Object, e As EventArgs) Handles dgMacros.DoubleClick
        With dgMacros
            If .CurrentRow.Index >= 0 Then
                tbName.Text = .Item(0, .CurrentRow.Index).Value
                tbGCode.Text = .Item(1, .CurrentRow.Index).Value
                btnAdd.Text = Resources.GrblGui_dgMacros_DoubleClick_Update
            End If
        End With
    End Sub

    Private Sub btnDeleteMacro_Click(sender As Object, e As EventArgs) Handles btnDeleteMacro.Click
        Dim retval As Integer
        Dim sMsg As String

        With dgMacros
            If .CurrentRow.Index >= 0 Then
                sMsg = Resources.GrblGui_btnDeleteMacro_Click_AreYouSureYouWantToDeleteThe & .Item(0, .CurrentRow.Index).Value.ToString & " macro?"
                retval = MsgBox(sMsg, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, Resources.GrblGui_btnDeleteMacro_Click_ConfirmDelete)
                If retval = vbYes Then
                    .Rows.Remove(.CurrentRow)
                    bDataChanged = True
                End If
            End If
        End With

    End Sub

    Private Sub UpdateToolTip(sender As Object, e As EventArgs) Handles btnOK.MouseHover, btnCancel.MouseHover,
                                tbName.MouseHover, btnDeleteMacro.MouseHover, tbGCode.MouseHover,
                                dgMacros.MouseHover

        Dim sTemp As String

        If sender Is tbName Then
            sTemp = Resources.GrblGui_UpdateToolTip_NameAppearsOnTheButtonSoKeepItSmall
        ElseIf sender Is btnDeleteMacro Then
            sTemp = Resources.GrblGui_UpdateToolTip_DeleteTheSelectedMacro
        ElseIf sender Is dgMacros Then
            sTemp = Resources.GrblGui_UpdateToolTip_DblClickNameToEditMacro
        ElseIf sender Is btnCancel Then
            sTemp = Resources.GrblGui_UpdateToolTip_GetMeOuttaHereCancelAllChanges
        ElseIf sender Is tbGCode Then
            sTemp = Resources.GrblGui_UpdateToolTip_GCodeToSendWhenTheButtonIsClicked
        ElseIf sender Is btnOK Then
            sTemp = Resources.GrblGui_UpdateToolTip_CommitAllChangesToSettingsAndClose
        Else
            sTemp = Resources.GrblGui_UpdateToolTip_LimitIs5Macros
        End If

        lblStatusLabel.Text = sTemp
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim bMatchFound As Boolean

        If tbName.Text <> "" Then
            If tbGCode.Text <> "" Then
                If btnAdd.Text = Resources.GrblGui_dgMacros_DoubleClick_Update Then
                    For Each row As DataGridViewRow In dgMacros.Rows
                        If row.Cells(0).Value.ToString = tbName.Text Then
                            row.Cells(1).Value = tbGCode.Text
                            bMatchFound = True
                            Exit For
                        End If
                    Next
                    ' if the user changed the name we cannot update so we need to add
                    If Not bMatchFound Then
                        dgMacros.Rows.Add(tbName.Text, tbGCode.Text)
                    End If
                Else
                    dgMacros.Rows.Add(tbName.Text, tbGCode.Text)
                End If
                bDataChanged = True
                btnAdd.Text = Resources.GrblGui_GrblMacroButtons_Load_Add
                tbGCode.Text = ""
                tbName.Text = ""
            Else
                MsgBox(Resources.GrblGui_btnAdd_Click_YouNeedToAddSomeGCodeToSaveAMacro, MsgBoxStyle.Information, Resources.GrblGui_btnAdd_Click_DataValidationError)
            End If
        Else
            MsgBox(Resources.GrblGui_btnAdd_Click_YouCannotCreateAMacroWithoutAName, MsgBoxStyle.Information, Resources.GrblGui_btnAdd_Click_DataValidationError)
        End If
    End Sub

    Public ReadOnly Property macroNames As String()
        Get
            Return _macroNames
        End Get
    End Property
End Class