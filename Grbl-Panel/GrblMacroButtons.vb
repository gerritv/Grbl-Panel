Imports System.Windows.Forms
Imports Microsoft.Win32
Public Class GrblMacroButtons
    Private bDataChanged As Boolean
    Private _strRegSubKey As String = "Software\GrblPanel\Macros"

    Private Sub GrblMacroButtons_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim retval As Int16
        If bDataChanged Then
            retval = MsgBox("Are you sure you want to exit without saving your changes?", MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirm exit without saving.")
            If retval = vbYes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub GrblMacroButtons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillListFromReg()
        With dgMacros
            .Columns(0).Width = .Width         ' resize the first column to the width of the entire grid, this hides the Gcode column
            If .RowCount = 0 Then              ' if there are no macros add a default one to the list as an example
                .Rows.Add("Probe", "G38.2 Z-30 F10")
                bDataChanged = True
            End If
        End With
        btnAdd.Text = "Add"
        tbName.Text = ""
        tbGCode.Text = ""
    End Sub

    Private Sub FillListFromReg()
        Dim instance As RegistryKey = Registry.CurrentUser.CreateSubKey(_strRegSubKey)
        Dim aKeyNames() As String = instance.GetSubKeyNames()
        Dim sTemp As String

        With dgMacros
            .RowCount = 0                                    ' make sure the grid is empty
            For Each KeyName As String In aKeyNames          ' add records to the grid 
                sTemp = instance.OpenSubKey(KeyName).GetValue("GCode", "")
                .Rows.Add(KeyName, sTemp)
            Next
            bDataChanged = False                             ' reset our changed data flag
        End With

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        SaveMacros()
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub SaveMacros()
        Dim instance As RegistryKey = Registry.CurrentUser
        Dim aKeyNames() As String = instance.GetSubKeyNames()

        instance.DeleteSubKeyTree(_strRegSubKey)                    ' kill all the macros in the registry

        instance = Registry.CurrentUser.CreateSubKey(_strRegSubKey)

        For Each row As DataGridViewRow In dgMacros.Rows
            instance.CreateSubKey(row.Cells(0).Value.ToString)
            instance.OpenSubKey(row.Cells(0).Value.ToString, True).SetValue("GCode", row.Cells(1).Value.ToString)
        Next

        bDataChanged = False
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub dgMacros_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dgMacros.CellValueChanged
        bDataChanged = True
    End Sub

    Private Sub dgMacros_DoubleClick(sender As Object, e As EventArgs) Handles dgMacros.DoubleClick
        With dgMacros
            If .CurrentRow.Index >= 0 Then
                tbName.Text = .Item(0, .CurrentRow.Index).Value
                tbGCode.Text = .Item(1, .CurrentRow.Index).Value
                btnAdd.Text = "Update"
            End If
        End With
    End Sub

    Private Sub btnDeleteMacro_Click(sender As Object, e As EventArgs) Handles btnDeleteMacro.Click
        Dim retval As Int16
        Dim sMsg As String

        With dgMacros
            If .CurrentRow.Index >= 0 Then
                sMsg = "Are you sure you want to delete the " & .Item(0, .CurrentRow.Index).Value.ToString & " macro?"
                retval = MsgBox(sMsg, MsgBoxStyle.YesNo + MsgBoxStyle.Critical, "Confirm Delete")
                If retval = vbYes Then
                    .Rows.Remove(.CurrentRow)
                    bDataChanged = True
                End If
            End If
        End With

    End Sub

    Private Sub UpdateToolTip(sender As Object, e As MouseEventArgs) Handles btnOK.MouseMove, tbGCode.MouseMove, btnCancel.MouseMove, btnDeleteMacro.MouseMove, dgMacros.MouseMove, gbEditor.MouseMove, tbName.MouseMove, Me.MouseMove

        Dim sTemp As String

        If sender Is tbName Then
            sTemp = "Name appears on the button, so keep it small"
        ElseIf sender Is btnDeleteMacro Then
            sTemp = "Delete the selected macro"
        ElseIf sender Is dgMacros Then
            sTemp = "DblClick name to edit macro"
        ElseIf sender Is btnCancel Then
            sTemp = "Get me outta here, cancel all changes"
        ElseIf sender Is tbGCode Then
            sTemp = "G-Code to send when the button is clicked."
        ElseIf sender Is btnOK Then
            sTemp = "Commit all changes to registry and close"
        Else
            sTemp = "Limit macros to 5 for best results"
        End If

        lblStatusLabel.Text = sTemp
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim bMatchFound As Boolean

        If tbName.Text <> "" Then
            If tbGCode.Text <> "" Then
                If btnAdd.Text = "Update" Then
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
                btnAdd.Text = "Add"
                tbGCode.Text = ""
                tbName.Text = ""
            Else
                MsgBox("You need to add some G-code to save a macro", MsgBoxStyle.Information, "Data Validation Error")
            End If
        Else
            MsgBox("You cannot create a macro without a name.", MsgBoxStyle.Information, "Data Validation Error")
        End If
    End Sub

End Class