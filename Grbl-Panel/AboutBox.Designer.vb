<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AboutBox
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
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents MoreRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents AppInfoListView As System.Windows.Forms.ListView
    Friend WithEvents colKey As System.Windows.Forms.ColumnHeader
    Friend WithEvents colValue As System.Windows.Forms.ColumnHeader
    Friend WithEvents AssemblyInfoListView As System.Windows.Forms.ListView
    Friend WithEvents colAssemblyName As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAssemblyVersion As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAssemblyBuilt As System.Windows.Forms.ColumnHeader
    Friend WithEvents colAssemblyCodeBase As System.Windows.Forms.ColumnHeader
    Friend WithEvents TabPanelDetails As System.Windows.Forms.TabControl
    Friend WithEvents TabPageApplication As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAssemblies As System.Windows.Forms.TabPage
    Friend WithEvents TabPageAssemblyDetails As System.Windows.Forms.TabPage
    Friend WithEvents AssemblyDetailsListView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AssemblyNamesComboBox As System.Windows.Forms.ComboBox
    Private WithEvents OKButton As System.Windows.Forms.Button
    Private WithEvents AppTitleLabel As System.Windows.Forms.Label
    Private WithEvents AppDescriptionLabel As System.Windows.Forms.Label
    Private WithEvents AppVersionLabel As System.Windows.Forms.Label
    Private WithEvents AppCopyrightLabel As System.Windows.Forms.Label
    Private WithEvents SysInfoButton As System.Windows.Forms.Button
    Private WithEvents AppDateLabel As System.Windows.Forms.Label
    Private WithEvents ImagePictureBox As System.Windows.Forms.PictureBox
    Private WithEvents DetailsButton As System.Windows.Forms.Button

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.OKButton = New System.Windows.Forms.Button()
        Me.AppTitleLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AppDescriptionLabel = New System.Windows.Forms.Label()
        Me.AppVersionLabel = New System.Windows.Forms.Label()
        Me.AppCopyrightLabel = New System.Windows.Forms.Label()
        Me.SysInfoButton = New System.Windows.Forms.Button()
        Me.AppDateLabel = New System.Windows.Forms.Label()
        Me.ImagePictureBox = New System.Windows.Forms.PictureBox()
        Me.DetailsButton = New System.Windows.Forms.Button()
        Me.MoreRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.TabPanelDetails = New System.Windows.Forms.TabControl()
        Me.TabPageApplication = New System.Windows.Forms.TabPage()
        Me.AppInfoListView = New System.Windows.Forms.ListView()
        Me.colKey = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colValue = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageAssemblies = New System.Windows.Forms.TabPage()
        Me.AssemblyInfoListView = New System.Windows.Forms.ListView()
        Me.colAssemblyName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAssemblyVersion = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAssemblyBuilt = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colAssemblyCodeBase = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPageAssemblyDetails = New System.Windows.Forms.TabPage()
        Me.AssemblyDetailsListView = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AssemblyNamesComboBox = New System.Windows.Forms.ComboBox()
        Me.btnAboutChanges = New System.Windows.Forms.Button()
        Me.btnAboutCredits = New System.Windows.Forms.Button()
        Me.btnAboutLicense = New System.Windows.Forms.Button()
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPanelDetails.SuspendLayout()
        Me.TabPageApplication.SuspendLayout()
        Me.TabPageAssemblies.SuspendLayout()
        Me.TabPageAssemblyDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'OKButton
        '
        Me.OKButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.OKButton.Location = New System.Drawing.Point(482, 474)
        Me.OKButton.Name = "OKButton"
        Me.OKButton.Size = New System.Drawing.Size(59, 23)
        Me.OKButton.TabIndex = 1
        Me.OKButton.Text = "OK"
        '
        'AppTitleLabel
        '
        Me.AppTitleLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppTitleLabel.Location = New System.Drawing.Point(60, 8)
        Me.AppTitleLabel.Name = "AppTitleLabel"
        Me.AppTitleLabel.Size = New System.Drawing.Size(496, 16)
        Me.AppTitleLabel.TabIndex = 2
        Me.AppTitleLabel.Text = "%title%"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(548, 2)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'AppDescriptionLabel
        '
        Me.AppDescriptionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppDescriptionLabel.Location = New System.Drawing.Point(60, 28)
        Me.AppDescriptionLabel.Name = "AppDescriptionLabel"
        Me.AppDescriptionLabel.Size = New System.Drawing.Size(496, 16)
        Me.AppDescriptionLabel.TabIndex = 4
        Me.AppDescriptionLabel.Text = "%description%"
        '
        'AppVersionLabel
        '
        Me.AppVersionLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppVersionLabel.Location = New System.Drawing.Point(8, 60)
        Me.AppVersionLabel.Name = "AppVersionLabel"
        Me.AppVersionLabel.Size = New System.Drawing.Size(548, 16)
        Me.AppVersionLabel.TabIndex = 5
        Me.AppVersionLabel.Text = "Version %version%"
        '
        'AppCopyrightLabel
        '
        Me.AppCopyrightLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppCopyrightLabel.Location = New System.Drawing.Point(8, 100)
        Me.AppCopyrightLabel.Name = "AppCopyrightLabel"
        Me.AppCopyrightLabel.Size = New System.Drawing.Size(548, 16)
        Me.AppCopyrightLabel.TabIndex = 6
        Me.AppCopyrightLabel.Text = "Copyright © %year%, %trademark%"
        '
        'SysInfoButton
        '
        Me.SysInfoButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SysInfoButton.Location = New System.Drawing.Point(395, 474)
        Me.SysInfoButton.Name = "SysInfoButton"
        Me.SysInfoButton.Size = New System.Drawing.Size(81, 23)
        Me.SysInfoButton.TabIndex = 7
        Me.SysInfoButton.Text = "&System Info"
        Me.SysInfoButton.Visible = False
        '
        'AppDateLabel
        '
        Me.AppDateLabel.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AppDateLabel.Location = New System.Drawing.Point(8, 80)
        Me.AppDateLabel.Name = "AppDateLabel"
        Me.AppDateLabel.Size = New System.Drawing.Size(548, 16)
        Me.AppDateLabel.TabIndex = 8
        Me.AppDateLabel.Text = "Built on %builddate%"
        '
        'ImagePictureBox
        '
        Me.ImagePictureBox.Location = New System.Drawing.Point(16, 8)
        Me.ImagePictureBox.Name = "ImagePictureBox"
        Me.ImagePictureBox.Size = New System.Drawing.Size(32, 32)
        Me.ImagePictureBox.TabIndex = 9
        Me.ImagePictureBox.TabStop = False
        '
        'DetailsButton
        '
        Me.DetailsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DetailsButton.Location = New System.Drawing.Point(406, 474)
        Me.DetailsButton.Name = "DetailsButton"
        Me.DetailsButton.Size = New System.Drawing.Size(59, 23)
        Me.DetailsButton.TabIndex = 10
        Me.DetailsButton.Text = "&Details >>"
        '
        'MoreRichTextBox
        '
        Me.MoreRichTextBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MoreRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MoreRichTextBox.Location = New System.Drawing.Point(8, 119)
        Me.MoreRichTextBox.Name = "MoreRichTextBox"
        Me.MoreRichTextBox.ReadOnly = True
        Me.MoreRichTextBox.Size = New System.Drawing.Size(548, 347)
        Me.MoreRichTextBox.TabIndex = 13
        Me.MoreRichTextBox.Text = ""
        Me.MoreRichTextBox.WordWrap = False
        '
        'TabPanelDetails
        '
        Me.TabPanelDetails.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabPanelDetails.Controls.Add(Me.TabPageApplication)
        Me.TabPanelDetails.Controls.Add(Me.TabPageAssemblies)
        Me.TabPanelDetails.Controls.Add(Me.TabPageAssemblyDetails)
        Me.TabPanelDetails.Location = New System.Drawing.Point(8, 119)
        Me.TabPanelDetails.Name = "TabPanelDetails"
        Me.TabPanelDetails.SelectedIndex = 0
        Me.TabPanelDetails.Size = New System.Drawing.Size(546, 347)
        Me.TabPanelDetails.TabIndex = 15
        Me.TabPanelDetails.Visible = False
        '
        'TabPageApplication
        '
        Me.TabPageApplication.Controls.Add(Me.AppInfoListView)
        Me.TabPageApplication.Location = New System.Drawing.Point(4, 22)
        Me.TabPageApplication.Name = "TabPageApplication"
        Me.TabPageApplication.Size = New System.Drawing.Size(538, 321)
        Me.TabPageApplication.TabIndex = 0
        Me.TabPageApplication.Text = "Application"
        '
        'AppInfoListView
        '
        Me.AppInfoListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colKey, Me.colValue})
        Me.AppInfoListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AppInfoListView.FullRowSelect = True
        Me.AppInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AppInfoListView.Location = New System.Drawing.Point(0, 0)
        Me.AppInfoListView.Name = "AppInfoListView"
        Me.AppInfoListView.Size = New System.Drawing.Size(538, 321)
        Me.AppInfoListView.TabIndex = 16
        Me.AppInfoListView.UseCompatibleStateImageBehavior = False
        Me.AppInfoListView.View = System.Windows.Forms.View.Details
        '
        'colKey
        '
        Me.colKey.Text = "Application Key"
        Me.colKey.Width = 120
        '
        'colValue
        '
        Me.colValue.Text = "Value"
        Me.colValue.Width = 700
        '
        'TabPageAssemblies
        '
        Me.TabPageAssemblies.Controls.Add(Me.AssemblyInfoListView)
        Me.TabPageAssemblies.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAssemblies.Name = "TabPageAssemblies"
        Me.TabPageAssemblies.Size = New System.Drawing.Size(368, 121)
        Me.TabPageAssemblies.TabIndex = 1
        Me.TabPageAssemblies.Text = "Assemblies"
        '
        'AssemblyInfoListView
        '
        Me.AssemblyInfoListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colAssemblyName, Me.colAssemblyVersion, Me.colAssemblyBuilt, Me.colAssemblyCodeBase})
        Me.AssemblyInfoListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssemblyInfoListView.FullRowSelect = True
        Me.AssemblyInfoListView.Location = New System.Drawing.Point(0, 0)
        Me.AssemblyInfoListView.MultiSelect = False
        Me.AssemblyInfoListView.Name = "AssemblyInfoListView"
        Me.AssemblyInfoListView.Size = New System.Drawing.Size(368, 121)
        Me.AssemblyInfoListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AssemblyInfoListView.TabIndex = 13
        Me.AssemblyInfoListView.UseCompatibleStateImageBehavior = False
        Me.AssemblyInfoListView.View = System.Windows.Forms.View.Details
        '
        'colAssemblyName
        '
        Me.colAssemblyName.Text = "Assembly"
        Me.colAssemblyName.Width = 123
        '
        'colAssemblyVersion
        '
        Me.colAssemblyVersion.Text = "Version"
        Me.colAssemblyVersion.Width = 100
        '
        'colAssemblyBuilt
        '
        Me.colAssemblyBuilt.Text = "Built"
        Me.colAssemblyBuilt.Width = 130
        '
        'colAssemblyCodeBase
        '
        Me.colAssemblyCodeBase.Text = "CodeBase"
        Me.colAssemblyCodeBase.Width = 750
        '
        'TabPageAssemblyDetails
        '
        Me.TabPageAssemblyDetails.Controls.Add(Me.AssemblyDetailsListView)
        Me.TabPageAssemblyDetails.Controls.Add(Me.AssemblyNamesComboBox)
        Me.TabPageAssemblyDetails.Location = New System.Drawing.Point(4, 22)
        Me.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails"
        Me.TabPageAssemblyDetails.Size = New System.Drawing.Size(368, 121)
        Me.TabPageAssemblyDetails.TabIndex = 2
        Me.TabPageAssemblyDetails.Text = "Assembly Details"
        '
        'AssemblyDetailsListView
        '
        Me.AssemblyDetailsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
        Me.AssemblyDetailsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AssemblyDetailsListView.FullRowSelect = True
        Me.AssemblyDetailsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.AssemblyDetailsListView.Location = New System.Drawing.Point(0, 21)
        Me.AssemblyDetailsListView.Name = "AssemblyDetailsListView"
        Me.AssemblyDetailsListView.Size = New System.Drawing.Size(368, 100)
        Me.AssemblyDetailsListView.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AssemblyDetailsListView.TabIndex = 19
        Me.AssemblyDetailsListView.UseCompatibleStateImageBehavior = False
        Me.AssemblyDetailsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Assembly Key"
        Me.ColumnHeader1.Width = 120
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Value"
        Me.ColumnHeader2.Width = 700
        '
        'AssemblyNamesComboBox
        '
        Me.AssemblyNamesComboBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.AssemblyNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.AssemblyNamesComboBox.Location = New System.Drawing.Point(0, 0)
        Me.AssemblyNamesComboBox.Name = "AssemblyNamesComboBox"
        Me.AssemblyNamesComboBox.Size = New System.Drawing.Size(368, 21)
        Me.AssemblyNamesComboBox.Sorted = True
        Me.AssemblyNamesComboBox.TabIndex = 18
        '
        'btnAboutChanges
        '
        Me.btnAboutChanges.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAboutChanges.Location = New System.Drawing.Point(178, 474)
        Me.btnAboutChanges.Name = "btnAboutChanges"
        Me.btnAboutChanges.Size = New System.Drawing.Size(59, 23)
        Me.btnAboutChanges.TabIndex = 16
        Me.btnAboutChanges.Text = "Changes"
        Me.btnAboutChanges.UseVisualStyleBackColor = True
        '
        'btnAboutCredits
        '
        Me.btnAboutCredits.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAboutCredits.Location = New System.Drawing.Point(254, 474)
        Me.btnAboutCredits.Name = "btnAboutCredits"
        Me.btnAboutCredits.Size = New System.Drawing.Size(59, 23)
        Me.btnAboutCredits.TabIndex = 17
        Me.btnAboutCredits.Text = "Credits"
        Me.btnAboutCredits.UseVisualStyleBackColor = True
        '
        'btnAboutLicense
        '
        Me.btnAboutLicense.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAboutLicense.Location = New System.Drawing.Point(330, 474)
        Me.btnAboutLicense.Name = "btnAboutLicense"
        Me.btnAboutLicense.Size = New System.Drawing.Size(59, 23)
        Me.btnAboutLicense.TabIndex = 18
        Me.btnAboutLicense.Text = "License"
        Me.btnAboutLicense.UseVisualStyleBackColor = True
        '
        'AboutBox
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.OKButton
        Me.ClientSize = New System.Drawing.Size(564, 505)
        Me.Controls.Add(Me.btnAboutLicense)
        Me.Controls.Add(Me.btnAboutCredits)
        Me.Controls.Add(Me.btnAboutChanges)
        Me.Controls.Add(Me.DetailsButton)
        Me.Controls.Add(Me.ImagePictureBox)
        Me.Controls.Add(Me.AppDateLabel)
        Me.Controls.Add(Me.SysInfoButton)
        Me.Controls.Add(Me.AppCopyrightLabel)
        Me.Controls.Add(Me.AppVersionLabel)
        Me.Controls.Add(Me.AppDescriptionLabel)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.AppTitleLabel)
        Me.Controls.Add(Me.OKButton)
        Me.Controls.Add(Me.MoreRichTextBox)
        Me.Controls.Add(Me.TabPanelDetails)
        Me.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBox"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About %title%"
        CType(Me.ImagePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPanelDetails.ResumeLayout(False)
        Me.TabPageApplication.ResumeLayout(False)
        Me.TabPageAssemblies.ResumeLayout(False)
        Me.TabPageAssemblyDetails.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnAboutChanges As System.Windows.Forms.Button
    Friend WithEvents btnAboutCredits As System.Windows.Forms.Button
    Friend WithEvents btnAboutLicense As System.Windows.Forms.Button




End Class
