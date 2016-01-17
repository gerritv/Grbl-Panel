<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrblMacroButtons
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbEditor = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblGCode = New System.Windows.Forms.Label()
        Me.tbGCode = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgMacros = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnDeleteMacro = New System.Windows.Forms.Button()
        Me.lblStatusLabel = New System.Windows.Forms.Label()
        Me.gbEditor.SuspendLayout()
        CType(Me.dgMacros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbEditor
        '
        Me.gbEditor.Controls.Add(Me.btnAdd)
        Me.gbEditor.Controls.Add(Me.lblGCode)
        Me.gbEditor.Controls.Add(Me.tbGCode)
        Me.gbEditor.Controls.Add(Me.lblName)
        Me.gbEditor.Controls.Add(Me.tbName)
        Me.gbEditor.Location = New System.Drawing.Point(9, 156)
        Me.gbEditor.Name = "gbEditor"
        Me.gbEditor.Size = New System.Drawing.Size(246, 111)
        Me.gbEditor.TabIndex = 1
        Me.gbEditor.TabStop = False
        Me.gbEditor.Text = "Editor"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(166, 17)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(64, 23)
        Me.btnAdd.TabIndex = 4
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblGCode
        '
        Me.lblGCode.Location = New System.Drawing.Point(9, 51)
        Me.lblGCode.Name = "lblGCode"
        Me.lblGCode.Size = New System.Drawing.Size(50, 15)
        Me.lblGCode.TabIndex = 3
        Me.lblGCode.Text = "G Code:"
        Me.lblGCode.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbGCode
        '
        Me.tbGCode.AcceptsReturn = True
        Me.tbGCode.Location = New System.Drawing.Point(62, 48)
        Me.tbGCode.Multiline = True
        Me.tbGCode.Name = "tbGCode"
        Me.tbGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.tbGCode.Size = New System.Drawing.Size(168, 57)
        Me.tbGCode.TabIndex = 2
        '
        'lblName
        '
        Me.lblName.Location = New System.Drawing.Point(9, 22)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(50, 15)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name:"
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'tbName
        '
        Me.tbName.Location = New System.Drawing.Point(61, 19)
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(99, 20)
        Me.tbName.TabIndex = 0
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(180, 12)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(180, 41)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgMacros
        '
        Me.dgMacros.AllowUserToAddRows = False
        Me.dgMacros.AllowUserToDeleteRows = False
        Me.dgMacros.AllowUserToResizeColumns = False
        Me.dgMacros.AllowUserToResizeRows = False
        Me.dgMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgMacros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgMacros.Location = New System.Drawing.Point(21, 12)
        Me.dgMacros.Name = "dgMacros"
        Me.dgMacros.ReadOnly = True
        Me.dgMacros.RowHeadersVisible = False
        Me.dgMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMacros.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMacros.Size = New System.Drawing.Size(148, 134)
        Me.dgMacros.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Name"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "GCode"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'btnDeleteMacro
        '
        Me.btnDeleteMacro.Location = New System.Drawing.Point(180, 111)
        Me.btnDeleteMacro.Name = "btnDeleteMacro"
        Me.btnDeleteMacro.Size = New System.Drawing.Size(74, 34)
        Me.btnDeleteMacro.TabIndex = 5
        Me.btnDeleteMacro.Text = "Delete Selected"
        Me.btnDeleteMacro.UseVisualStyleBackColor = True
        '
        'lblStatusLabel
        '
        Me.lblStatusLabel.Location = New System.Drawing.Point(12, 272)
        Me.lblStatusLabel.Name = "lblStatusLabel"
        Me.lblStatusLabel.Size = New System.Drawing.Size(242, 23)
        Me.lblStatusLabel.TabIndex = 7
        '
        'GrblMacroButtons
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(271, 294)
        Me.ControlBox = False
        Me.Controls.Add(Me.lblStatusLabel)
        Me.Controls.Add(Me.btnDeleteMacro)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.gbEditor)
        Me.Controls.Add(Me.dgMacros)
        Me.MaximumSize = New System.Drawing.Size(287, 333)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(287, 333)
        Me.Name = "GrblMacroButtons"
        Me.Text = "Macro Button Editor"
        Me.gbEditor.ResumeLayout(False)
        Me.gbEditor.PerformLayout()
        CType(Me.dgMacros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbEditor As System.Windows.Forms.GroupBox
    Private WithEvents btnAdd As System.Windows.Forms.Button
    Private WithEvents lblGCode As System.Windows.Forms.Label
    Private WithEvents tbGCode As System.Windows.Forms.TextBox
    Private WithEvents lblName As System.Windows.Forms.Label
    Private WithEvents tbName As System.Windows.Forms.TextBox
    Private WithEvents btnOK As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private WithEvents dgMacros As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents btnDeleteMacro As System.Windows.Forms.Button
    Private WithEvents lblStatusLabel As System.Windows.Forms.Label
End Class
