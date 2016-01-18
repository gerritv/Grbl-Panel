<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GrblGui
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GrblGui))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tabPgInterface = New System.Windows.Forms.TabPage()
        Me.gbState = New System.Windows.Forms.GroupBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbStateFeedRate = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbStateTool = New System.Windows.Forms.TextBox()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.tbStateSpindleRPM = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbxStateFeedMode = New System.Windows.Forms.ComboBox()
        Me.cbxStateDistance = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cbxStateUnits = New System.Windows.Forms.ComboBox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Lalbel49 = New System.Windows.Forms.Label()
        Me.cbxStatePlane = New System.Windows.Forms.ComboBox()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cbxStateOffset = New System.Windows.Forms.ComboBox()
        Me.cbxStateCoolant = New System.Windows.Forms.ComboBox()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cbxStateSpindle = New System.Windows.Forms.ComboBox()
        Me.btnStatusGetParser = New System.Windows.Forms.Button()
        Me.gbControl = New System.Windows.Forms.GroupBox()
        Me.btnCheckMode = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnHold = New System.Windows.Forms.Button()
        Me.btnStartResume = New System.Windows.Forms.Button()
        Me.btnUnlock = New System.Windows.Forms.Button()
        Me.gbMDI = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnSend = New System.Windows.Forms.Button()
        Me.tbSendData = New System.Windows.Forms.TextBox()
        Me.gbJogging = New System.Windows.Forms.GroupBox()
        Me.btnZMinus = New RepeatButton.RepeatButton()
        Me.btnZPlus = New RepeatButton.RepeatButton()
        Me.btnXPlus = New RepeatButton.RepeatButton()
        Me.btnYMinus = New RepeatButton.RepeatButton()
        Me.btnXMinus = New RepeatButton.RepeatButton()
        Me.btnYPlus = New RepeatButton.RepeatButton()
        Me.gbFeedRate = New System.Windows.Forms.GroupBox()
        Me.rbFeedRate1 = New System.Windows.Forms.RadioButton()
        Me.rbFeedRate2 = New System.Windows.Forms.RadioButton()
        Me.rbFeedRate3 = New System.Windows.Forms.RadioButton()
        Me.rbFeedRate4 = New System.Windows.Forms.RadioButton()
        Me.gbDistance = New System.Windows.Forms.GroupBox()
        Me.rbDistance1 = New System.Windows.Forms.RadioButton()
        Me.rbDistance2 = New System.Windows.Forms.RadioButton()
        Me.rbDistance3 = New System.Windows.Forms.RadioButton()
        Me.rbDistance4 = New System.Windows.Forms.RadioButton()
        Me.cbUnits = New System.Windows.Forms.CheckBox()
        Me.gbStatus = New System.Windows.Forms.GroupBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.tbCurrentStatus = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.prgbRxBuf = New System.Windows.Forms.ProgressBar()
        Me.prgBarQ = New System.Windows.Forms.ProgressBar()
        Me.cbVerbose = New System.Windows.Forms.CheckBox()
        Me.lbResponses = New System.Windows.Forms.ListBox()
        Me.gbGcode = New System.Windows.Forms.GroupBox()
        Me.btnFileReload = New System.Windows.Forms.Button()
        Me.tbGCodeMessage = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTotalLines = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.btnFilePause = New System.Windows.Forms.Button()
        Me.tbGcodeFile = New System.Windows.Forms.TextBox()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.btnFileSend = New System.Windows.Forms.Button()
        Me.lvGcode = New System.Windows.Forms.ListView()
        Me.lvColStatus = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColLineNo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvColGCode = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnFileStop = New System.Windows.Forms.Button()
        Me.gbGrbl = New System.Windows.Forms.GroupBox()
        Me.tcConnection = New System.Windows.Forms.TabControl()
        Me.tbGrblCOM = New System.Windows.Forms.TabPage()
        Me.btnRescanPorts = New System.Windows.Forms.Button()
        Me.cbPorts = New System.Windows.Forms.ComboBox()
        Me.btnConnect = New System.Windows.Forms.Button()
        Me.cbBaud = New System.Windows.Forms.ComboBox()
        Me.tbGrblIP = New System.Windows.Forms.TabPage()
        Me.btnIPConnect = New System.Windows.Forms.Button()
        Me.tbIPAddress = New System.Windows.Forms.TextBox()
        Me.gbPosition = New System.Windows.Forms.GroupBox()
        Me.tabCtlPosition = New System.Windows.Forms.TabControl()
        Me.tpWork = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tbWorkZ = New System.Windows.Forms.TextBox()
        Me.tbMachZ = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tbWorkY = New System.Windows.Forms.TextBox()
        Me.tbMachY = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbMachX = New System.Windows.Forms.TextBox()
        Me.tbWorkX = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblPositionCurrentOffset = New System.Windows.Forms.Label()
        Me.btnWorkSoftHome = New System.Windows.Forms.Button()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.btnWorkSpclPosition = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnWork0 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnWorkX0 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnWorkZ0 = New System.Windows.Forms.Button()
        Me.btnWorkY0 = New System.Windows.Forms.Button()
        Me.tpOffsets = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.tbOffSetsMachZ = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.tbOffsetsG56Y = New System.Windows.Forms.TextBox()
        Me.tbOffSetsMachY = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG56X = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG56Z = New System.Windows.Forms.TextBox()
        Me.tbOffSetsMachX = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG57Zero = New System.Windows.Forms.Button()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.tbOffsetsG54X = New System.Windows.Forms.TextBox()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.btnOffsetsG56Zero = New System.Windows.Forms.Button()
        Me.tbOffsetsG54Y = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG57Z = New System.Windows.Forms.TextBox()
        Me.btnOffsetsSave = New System.Windows.Forms.Button()
        Me.tbOffsetsG55X = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG54Z = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG57Y = New System.Windows.Forms.TextBox()
        Me.btnOffsetsRetrieve = New System.Windows.Forms.Button()
        Me.tbOffsetsG55Y = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG54Zero = New System.Windows.Forms.Button()
        Me.tbOffsetsG57X = New System.Windows.Forms.TextBox()
        Me.btnOffsetsLoad = New System.Windows.Forms.Button()
        Me.tbOffsetsG55Z = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG59X = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG58Zero = New System.Windows.Forms.Button()
        Me.btnOffsetsG43Zero = New System.Windows.Forms.Button()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.tbOffsetsG59Y = New System.Windows.Forms.TextBox()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.tbOffsetsG43Z = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG55Zero = New System.Windows.Forms.Button()
        Me.tbOffsetsG59Z = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG58Z = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label67 = New System.Windows.Forms.Label()
        Me.tbOffsetsG58Y = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.btnOffsetsG59Zero = New System.Windows.Forms.Button()
        Me.tbOffsetsG58X = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tabPgSettings = New System.Windows.Forms.TabPage()
        Me.gbGrblSettings = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSettingsGrblLastParam = New System.Windows.Forms.TextBox()
        Me.dgGrblSettings = New System.Windows.Forms.DataGridView()
        Me.btnSettingsGrbl = New System.Windows.Forms.Button()
        Me.gbSettingsOffsets = New System.Windows.Forms.GroupBox()
        Me.btnOffsetsG28Set = New System.Windows.Forms.Button()
        Me.btnSettingsRetrieveLocations = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tbOffsetsG30Y = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG30X = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG30Z = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG28X = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG30Set = New System.Windows.Forms.Button()
        Me.tbOffsetsG28Y = New System.Windows.Forms.TextBox()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.tbOffsetsG28Z = New System.Windows.Forms.TextBox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.gbSettingsMisc = New System.Windows.Forms.GroupBox()
        Me.tbSettingsDefaultExt = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbSettingsStartupDelay = New System.Windows.Forms.TextBox()
        Me.cbSettingsLeftHanded = New System.Windows.Forms.CheckBox()
        Me.cbSettingsConnectOnLoad = New System.Windows.Forms.CheckBox()
        Me.cbSettingsPauseOnError = New System.Windows.Forms.CheckBox()
        Me.cbStatusPollEnable = New System.Windows.Forms.CheckBox()
        Me.btnSettingsRefreshMisc = New System.Windows.Forms.Button()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.tbSettingsRBuffSize = New System.Windows.Forms.TextBox()
        Me.tbSettingsQSize = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.tbSettingsPollRate = New System.Windows.Forms.TextBox()
        Me.gbSettingsPosition = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbSettingsSpclPosition2 = New System.Windows.Forms.TextBox()
        Me.btnSettingsRefreshPosition = New System.Windows.Forms.Button()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.tbWorkZ0Cmd = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.tbWorkY0Cmd = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbWorkX0Cmd = New System.Windows.Forms.TextBox()
        Me.tbSettingsZeroXYZCmd = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbSettingsSpclPosition1 = New System.Windows.Forms.TextBox()
        Me.gbSettingsJogging = New System.Windows.Forms.GroupBox()
        Me.cbSettingsKeyboardJogging = New System.Windows.Forms.CheckBox()
        Me.btnSettingsRefreshJogging = New System.Windows.Forms.Button()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.tbSettingsZRepeat = New System.Windows.Forms.TextBox()
        Me.tbSettingsYRepeat = New System.Windows.Forms.TextBox()
        Me.tbSettingsXRepeat = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.tbSettingsFRMetric = New System.Windows.Forms.TextBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.tbSettingsFIMetric = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.tbSettingsFRImperial = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.cbSettingsMetric = New System.Windows.Forms.CheckBox()
        Me.tbSettingsFIImperial = New System.Windows.Forms.TextBox()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbEditor = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblGCode = New System.Windows.Forms.Label()
        Me.tbGCode = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.dgMacros = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblStatusLabel = New System.Windows.Forms.Label()
        Me.btnDeleteMacro = New System.Windows.Forms.Button()
        Me.ofdGcodeFile = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.sfdOffsets = New System.Windows.Forms.SaveFileDialog()
        Me.ofdOffsets = New System.Windows.Forms.OpenFileDialog()
        Me.GrblSettingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tabPgInterface.SuspendLayout()
        Me.gbState.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.gbControl.SuspendLayout()
        Me.gbMDI.SuspendLayout()
        Me.gbJogging.SuspendLayout()
        Me.gbFeedRate.SuspendLayout()
        Me.gbDistance.SuspendLayout()
        Me.gbStatus.SuspendLayout()
        Me.gbGcode.SuspendLayout()
        Me.gbGrbl.SuspendLayout()
        Me.tcConnection.SuspendLayout()
        Me.tbGrblCOM.SuspendLayout()
        Me.tbGrblIP.SuspendLayout()
        Me.gbPosition.SuspendLayout()
        Me.tabCtlPosition.SuspendLayout()
        Me.tpWork.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tpOffsets.SuspendLayout()
        Me.tabPgSettings.SuspendLayout()
        Me.gbGrblSettings.SuspendLayout()
        CType(Me.dgGrblSettings, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbSettingsOffsets.SuspendLayout()
        Me.gbSettingsMisc.SuspendLayout()
        Me.gbSettingsPosition.SuspendLayout()
        Me.gbSettingsJogging.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbEditor.SuspendLayout()
        CType(Me.dgMacros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrblSettingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(1143, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        Me.SaveToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        Me.ToolsToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.ToolsToolStripMenuItem.Text = "Tools"
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        Me.OptionsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.OptionsToolStripMenuItem.Text = "Options"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tabPgInterface)
        Me.TabControl1.Controls.Add(Me.tabPgSettings)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(0, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1142, 703)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.TabControl1.TabIndex = 1
        '
        'tabPgInterface
        '
        Me.tabPgInterface.Controls.Add(Me.gbState)
        Me.tabPgInterface.Controls.Add(Me.gbControl)
        Me.tabPgInterface.Controls.Add(Me.gbMDI)
        Me.tabPgInterface.Controls.Add(Me.gbJogging)
        Me.tabPgInterface.Controls.Add(Me.gbStatus)
        Me.tabPgInterface.Controls.Add(Me.gbGcode)
        Me.tabPgInterface.Controls.Add(Me.gbGrbl)
        Me.tabPgInterface.Controls.Add(Me.gbPosition)
        Me.tabPgInterface.Location = New System.Drawing.Point(4, 22)
        Me.tabPgInterface.Name = "tabPgInterface"
        Me.tabPgInterface.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPgInterface.Size = New System.Drawing.Size(1134, 677)
        Me.tabPgInterface.TabIndex = 0
        Me.tabPgInterface.Text = "Interface"
        Me.tabPgInterface.UseVisualStyleBackColor = True
        '
        'gbState
        '
        Me.gbState.Controls.Add(Me.Panel2)
        Me.gbState.Controls.Add(Me.Panel1)
        Me.gbState.Controls.Add(Me.btnStatusGetParser)
        Me.gbState.Location = New System.Drawing.Point(938, 3)
        Me.gbState.Name = "gbState"
        Me.gbState.Size = New System.Drawing.Size(191, 403)
        Me.gbState.TabIndex = 36
        Me.gbState.TabStop = False
        Me.gbState.Text = "State"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.tbStateFeedRate)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.tbStateTool)
        Me.Panel2.Controls.Add(Me.Label53)
        Me.Panel2.Controls.Add(Me.Label50)
        Me.Panel2.Controls.Add(Me.tbStateSpindleRPM)
        Me.Panel2.Location = New System.Drawing.Point(12, 225)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(169, 100)
        Me.Panel2.TabIndex = 38
        '
        'tbStateFeedRate
        '
        Me.tbStateFeedRate.Location = New System.Drawing.Point(3, 17)
        Me.tbStateFeedRate.Name = "tbStateFeedRate"
        Me.tbStateFeedRate.Size = New System.Drawing.Size(74, 20)
        Me.tbStateFeedRate.TabIndex = 22
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(84, 17)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 17
        Me.Label14.Text = "FeedRate"
        '
        'tbStateTool
        '
        Me.tbStateTool.Location = New System.Drawing.Point(3, 61)
        Me.tbStateTool.Name = "tbStateTool"
        Me.tbStateTool.Size = New System.Drawing.Size(74, 20)
        Me.tbStateTool.TabIndex = 28
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Location = New System.Drawing.Point(83, 63)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(28, 13)
        Me.Label53.TabIndex = 14
        Me.Label53.Text = "Tool"
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Location = New System.Drawing.Point(83, 40)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(69, 13)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "Spindle RPM"
        '
        'tbStateSpindleRPM
        '
        Me.tbStateSpindleRPM.Location = New System.Drawing.Point(3, 39)
        Me.tbStateSpindleRPM.Name = "tbStateSpindleRPM"
        Me.tbStateSpindleRPM.Size = New System.Drawing.Size(74, 20)
        Me.tbStateSpindleRPM.TabIndex = 27
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cbxStateFeedMode)
        Me.Panel1.Controls.Add(Me.cbxStateDistance)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.cbxStateUnits)
        Me.Panel1.Controls.Add(Me.Label123)
        Me.Panel1.Controls.Add(Me.Lalbel49)
        Me.Panel1.Controls.Add(Me.cbxStatePlane)
        Me.Panel1.Controls.Add(Me.Label47)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.cbxStateOffset)
        Me.Panel1.Controls.Add(Me.cbxStateCoolant)
        Me.Panel1.Controls.Add(Me.Label45)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.cbxStateSpindle)
        Me.Panel1.Location = New System.Drawing.Point(12, 19)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(169, 196)
        Me.Panel1.TabIndex = 37
        '
        'cbxStateFeedMode
        '
        Me.cbxStateFeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateFeedMode.FormattingEnabled = True
        Me.cbxStateFeedMode.Items.AddRange(New Object() {"", "Unit/Min                  G94", "Inverse Time            G93"})
        Me.cbxStateFeedMode.Location = New System.Drawing.Point(3, 39)
        Me.cbxStateFeedMode.Name = "cbxStateFeedMode"
        Me.cbxStateFeedMode.Size = New System.Drawing.Size(74, 21)
        Me.cbxStateFeedMode.TabIndex = 29
        '
        'cbxStateDistance
        '
        Me.cbxStateDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateDistance.FormattingEnabled = True
        Me.cbxStateDistance.Items.AddRange(New Object() {"", "Absolute                                                    G90", "Incremental                                               G91"})
        Me.cbxStateDistance.Location = New System.Drawing.Point(3, 16)
        Me.cbxStateDistance.Name = "cbxStateDistance"
        Me.cbxStateDistance.Size = New System.Drawing.Size(74, 21)
        Me.cbxStateDistance.TabIndex = 20
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(83, 65)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Units"
        '
        'cbxStateUnits
        '
        Me.cbxStateUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateUnits.FormattingEnabled = True
        Me.cbxStateUnits.Items.AddRange(New Object() {"", "Metric                                    G21", "Inch                                        G20"})
        Me.cbxStateUnits.Location = New System.Drawing.Point(3, 62)
        Me.cbxStateUnits.Name = "cbxStateUnits"
        Me.cbxStateUnits.Size = New System.Drawing.Size(74, 21)
        Me.cbxStateUnits.TabIndex = 21
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Location = New System.Drawing.Point(83, 19)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(79, 13)
        Me.Label123.TabIndex = 0
        Me.Label123.Text = "Distance Mode"
        '
        'Lalbel49
        '
        Me.Lalbel49.AutoSize = True
        Me.Lalbel49.Location = New System.Drawing.Point(83, 157)
        Me.Lalbel49.Name = "Lalbel49"
        Me.Lalbel49.Size = New System.Drawing.Size(67, 13)
        Me.Lalbel49.TabIndex = 10
        Me.Lalbel49.Text = "Active Plane"
        '
        'cbxStatePlane
        '
        Me.cbxStatePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatePlane.FormattingEnabled = True
        Me.cbxStatePlane.Items.AddRange(New Object() {"", "XY                                G17", "YZ                                G18", "XZ                                G19"})
        Me.cbxStatePlane.Location = New System.Drawing.Point(3, 154)
        Me.cbxStatePlane.Name = "cbxStatePlane"
        Me.cbxStatePlane.Size = New System.Drawing.Size(74, 21)
        Me.cbxStatePlane.TabIndex = 26
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(83, 134)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(43, 13)
        Me.Label47.TabIndex = 8
        Me.Label47.Text = "Coolant"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(83, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(64, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Work Offset"
        '
        'cbxStateOffset
        '
        Me.cbxStateOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateOffset.FormattingEnabled = True
        Me.cbxStateOffset.Items.AddRange(New Object() {"", "G54                                   G54", "G55                                   G55", "G56                                   G56", "G57                                   G57", "G58                                   G58", "G59                                   G59"})
        Me.cbxStateOffset.Location = New System.Drawing.Point(3, 85)
        Me.cbxStateOffset.Name = "cbxStateOffset"
        Me.cbxStateOffset.Size = New System.Drawing.Size(74, 21)
        Me.cbxStateOffset.TabIndex = 23
        '
        'cbxStateCoolant
        '
        Me.cbxStateCoolant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateCoolant.FormattingEnabled = True
        Me.cbxStateCoolant.Items.AddRange(New Object() {"", "On                                       M8", "Off                                       M9"})
        Me.cbxStateCoolant.Location = New System.Drawing.Point(3, 131)
        Me.cbxStateCoolant.Name = "cbxStateCoolant"
        Me.cbxStateCoolant.Size = New System.Drawing.Size(74, 21)
        Me.cbxStateCoolant.TabIndex = 25
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Location = New System.Drawing.Point(84, 111)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(42, 13)
        Me.Label45.TabIndex = 6
        Me.Label45.Text = "Spindle"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(83, 42)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(84, 13)
        Me.Label17.TabIndex = 4
        Me.Label17.Text = "FeedRate Mode"
        '
        'cbxStateSpindle
        '
        Me.cbxStateSpindle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateSpindle.FormattingEnabled = True
        Me.cbxStateSpindle.Items.AddRange(New Object() {"", "CW                                       M3", "CCW                                    M4", "Off                                       M5"})
        Me.cbxStateSpindle.Location = New System.Drawing.Point(3, 108)
        Me.cbxStateSpindle.Name = "cbxStateSpindle"
        Me.cbxStateSpindle.Size = New System.Drawing.Size(74, 21)
        Me.cbxStateSpindle.TabIndex = 24
        '
        'btnStatusGetParser
        '
        Me.btnStatusGetParser.AutoSize = True
        Me.btnStatusGetParser.Location = New System.Drawing.Point(0, 380)
        Me.btnStatusGetParser.Name = "btnStatusGetParser"
        Me.btnStatusGetParser.Size = New System.Drawing.Size(72, 23)
        Me.btnStatusGetParser.TabIndex = 36
        Me.btnStatusGetParser.Text = "Refresh"
        Me.btnStatusGetParser.UseVisualStyleBackColor = True
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.btnCheckMode)
        Me.gbControl.Controls.Add(Me.btnReset)
        Me.gbControl.Controls.Add(Me.btnHold)
        Me.gbControl.Controls.Add(Me.btnStartResume)
        Me.gbControl.Controls.Add(Me.btnUnlock)
        Me.gbControl.Location = New System.Drawing.Point(532, 409)
        Me.gbControl.Name = "gbControl"
        Me.gbControl.Size = New System.Drawing.Size(400, 59)
        Me.gbControl.TabIndex = 35
        Me.gbControl.TabStop = False
        Me.gbControl.Text = "Control"
        '
        'btnCheckMode
        '
        Me.btnCheckMode.AutoSize = True
        Me.btnCheckMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCheckMode.Location = New System.Drawing.Point(322, 19)
        Me.btnCheckMode.Name = "btnCheckMode"
        Me.btnCheckMode.Size = New System.Drawing.Size(72, 31)
        Me.btnCheckMode.TabIndex = 17
        Me.btnCheckMode.Text = "Check"
        Me.btnCheckMode.UseCompatibleTextRendering = True
        Me.btnCheckMode.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.AutoSize = True
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(85, 19)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(72, 31)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseCompatibleTextRendering = True
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnHold
        '
        Me.btnHold.AutoSize = True
        Me.btnHold.BackColor = System.Drawing.Color.Transparent
        Me.btnHold.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHold.Location = New System.Drawing.Point(164, 19)
        Me.btnHold.Name = "btnHold"
        Me.btnHold.Size = New System.Drawing.Size(72, 31)
        Me.btnHold.TabIndex = 3
        Me.btnHold.Text = "Hold"
        Me.btnHold.UseCompatibleTextRendering = True
        Me.btnHold.UseVisualStyleBackColor = False
        '
        'btnStartResume
        '
        Me.btnStartResume.AutoSize = True
        Me.btnStartResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStartResume.Location = New System.Drawing.Point(243, 19)
        Me.btnStartResume.Name = "btnStartResume"
        Me.btnStartResume.Size = New System.Drawing.Size(72, 31)
        Me.btnStartResume.TabIndex = 2
        Me.btnStartResume.Text = "Start"
        Me.btnStartResume.UseCompatibleTextRendering = True
        Me.btnStartResume.UseVisualStyleBackColor = True
        '
        'btnUnlock
        '
        Me.btnUnlock.AutoSize = True
        Me.btnUnlock.BackColor = System.Drawing.Color.Transparent
        Me.btnUnlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUnlock.Location = New System.Drawing.Point(6, 19)
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.Size = New System.Drawing.Size(72, 31)
        Me.btnUnlock.TabIndex = 16
        Me.btnUnlock.Text = "Unlock"
        Me.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUnlock.UseCompatibleTextRendering = True
        Me.btnUnlock.UseVisualStyleBackColor = False
        '
        'gbMDI
        '
        Me.gbMDI.Controls.Add(Me.Label9)
        Me.gbMDI.Controls.Add(Me.btnSend)
        Me.gbMDI.Controls.Add(Me.tbSendData)
        Me.gbMDI.Location = New System.Drawing.Point(187, 3)
        Me.gbMDI.Name = "gbMDI"
        Me.gbMDI.Size = New System.Drawing.Size(336, 89)
        Me.gbMDI.TabIndex = 15
        Me.gbMDI.TabStop = False
        Me.gbMDI.Text = "MDI"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(106, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Manual Command"
        '
        'btnSend
        '
        Me.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSend.Location = New System.Drawing.Point(281, 32)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(44, 25)
        Me.btnSend.TabIndex = 5
        Me.btnSend.Text = "Send"
        Me.btnSend.UseVisualStyleBackColor = True
        '
        'tbSendData
        '
        Me.tbSendData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbSendData.Location = New System.Drawing.Point(6, 35)
        Me.tbSendData.Name = "tbSendData"
        Me.tbSendData.Size = New System.Drawing.Size(269, 20)
        Me.tbSendData.TabIndex = 4
        '
        'gbJogging
        '
        Me.gbJogging.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbJogging.Controls.Add(Me.btnZMinus)
        Me.gbJogging.Controls.Add(Me.btnZPlus)
        Me.gbJogging.Controls.Add(Me.btnXPlus)
        Me.gbJogging.Controls.Add(Me.btnYMinus)
        Me.gbJogging.Controls.Add(Me.btnXMinus)
        Me.gbJogging.Controls.Add(Me.btnYPlus)
        Me.gbJogging.Controls.Add(Me.gbFeedRate)
        Me.gbJogging.Controls.Add(Me.gbDistance)
        Me.gbJogging.Controls.Add(Me.cbUnits)
        Me.gbJogging.Enabled = False
        Me.gbJogging.Location = New System.Drawing.Point(3, 95)
        Me.gbJogging.Name = "gbJogging"
        Me.gbJogging.Size = New System.Drawing.Size(520, 212)
        Me.gbJogging.TabIndex = 0
        Me.gbJogging.TabStop = False
        Me.gbJogging.Text = "Jogging"
        '
        'btnZMinus
        '
        Me.btnZMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZMinus.Interval = 100
        Me.btnZMinus.Location = New System.Drawing.Point(399, 145)
        Me.btnZMinus.Name = "btnZMinus"
        Me.btnZMinus.Size = New System.Drawing.Size(80, 58)
        Me.btnZMinus.TabIndex = 23
        Me.btnZMinus.Tag = "Z-"
        Me.btnZMinus.Text = "Z-"
        Me.btnZMinus.UseVisualStyleBackColor = True
        '
        'btnZPlus
        '
        Me.btnZPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZPlus.Interval = 100
        Me.btnZPlus.Location = New System.Drawing.Point(399, 18)
        Me.btnZPlus.Name = "btnZPlus"
        Me.btnZPlus.Size = New System.Drawing.Size(80, 58)
        Me.btnZPlus.TabIndex = 22
        Me.btnZPlus.Tag = "Z+"
        Me.btnZPlus.Text = "Z+"
        Me.btnZPlus.UseVisualStyleBackColor = True
        '
        'btnXPlus
        '
        Me.btnXPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXPlus.Interval = 100
        Me.btnXPlus.Location = New System.Drawing.Point(299, 81)
        Me.btnXPlus.Name = "btnXPlus"
        Me.btnXPlus.Size = New System.Drawing.Size(80, 58)
        Me.btnXPlus.TabIndex = 21
        Me.btnXPlus.Tag = "X+"
        Me.btnXPlus.Text = "X+"
        Me.btnXPlus.UseVisualStyleBackColor = True
        '
        'btnYMinus
        '
        Me.btnYMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYMinus.Interval = 100
        Me.btnYMinus.Location = New System.Drawing.Point(233, 144)
        Me.btnYMinus.Name = "btnYMinus"
        Me.btnYMinus.Size = New System.Drawing.Size(80, 58)
        Me.btnYMinus.TabIndex = 20
        Me.btnYMinus.Tag = "Y-"
        Me.btnYMinus.Text = "Y-"
        Me.btnYMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnYMinus.UseVisualStyleBackColor = True
        '
        'btnXMinus
        '
        Me.btnXMinus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXMinus.Interval = 100
        Me.btnXMinus.Location = New System.Drawing.Point(185, 81)
        Me.btnXMinus.Name = "btnXMinus"
        Me.btnXMinus.Size = New System.Drawing.Size(80, 58)
        Me.btnXMinus.TabIndex = 19
        Me.btnXMinus.Tag = "X-"
        Me.btnXMinus.Text = "X-"
        Me.btnXMinus.UseVisualStyleBackColor = True
        '
        'btnYPlus
        '
        Me.btnYPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnYPlus.Interval = 100
        Me.btnYPlus.Location = New System.Drawing.Point(233, 18)
        Me.btnYPlus.Name = "btnYPlus"
        Me.btnYPlus.Size = New System.Drawing.Size(80, 58)
        Me.btnYPlus.TabIndex = 18
        Me.btnYPlus.Tag = "Y+"
        Me.btnYPlus.Text = "Y+"
        Me.btnYPlus.UseVisualStyleBackColor = True
        '
        'gbFeedRate
        '
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate1)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate2)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate3)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate4)
        Me.gbFeedRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbFeedRate.Location = New System.Drawing.Point(21, 117)
        Me.gbFeedRate.Name = "gbFeedRate"
        Me.gbFeedRate.Size = New System.Drawing.Size(82, 92)
        Me.gbFeedRate.TabIndex = 16
        Me.gbFeedRate.TabStop = False
        Me.gbFeedRate.Text = "Feed Rate"
        '
        'rbFeedRate1
        '
        Me.rbFeedRate1.AutoSize = True
        Me.rbFeedRate1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbFeedRate1.Location = New System.Drawing.Point(6, 19)
        Me.rbFeedRate1.Name = "rbFeedRate1"
        Me.rbFeedRate1.Size = New System.Drawing.Size(14, 13)
        Me.rbFeedRate1.TabIndex = 11
        Me.rbFeedRate1.TabStop = True
        Me.rbFeedRate1.Tag = "F1"
        Me.rbFeedRate1.UseVisualStyleBackColor = True
        '
        'rbFeedRate2
        '
        Me.rbFeedRate2.AutoSize = True
        Me.rbFeedRate2.Location = New System.Drawing.Point(6, 35)
        Me.rbFeedRate2.Name = "rbFeedRate2"
        Me.rbFeedRate2.Size = New System.Drawing.Size(14, 13)
        Me.rbFeedRate2.TabIndex = 10
        Me.rbFeedRate2.TabStop = True
        Me.rbFeedRate2.Tag = "F2"
        Me.rbFeedRate2.UseVisualStyleBackColor = True
        '
        'rbFeedRate3
        '
        Me.rbFeedRate3.AutoSize = True
        Me.rbFeedRate3.Location = New System.Drawing.Point(6, 53)
        Me.rbFeedRate3.Name = "rbFeedRate3"
        Me.rbFeedRate3.Size = New System.Drawing.Size(14, 13)
        Me.rbFeedRate3.TabIndex = 12
        Me.rbFeedRate3.TabStop = True
        Me.rbFeedRate3.Tag = "F3"
        Me.rbFeedRate3.UseVisualStyleBackColor = True
        '
        'rbFeedRate4
        '
        Me.rbFeedRate4.AutoSize = True
        Me.rbFeedRate4.Location = New System.Drawing.Point(6, 72)
        Me.rbFeedRate4.Name = "rbFeedRate4"
        Me.rbFeedRate4.Size = New System.Drawing.Size(14, 13)
        Me.rbFeedRate4.TabIndex = 13
        Me.rbFeedRate4.TabStop = True
        Me.rbFeedRate4.Tag = "F4"
        Me.rbFeedRate4.UseVisualStyleBackColor = True
        '
        'gbDistance
        '
        Me.gbDistance.Controls.Add(Me.rbDistance1)
        Me.gbDistance.Controls.Add(Me.rbDistance2)
        Me.gbDistance.Controls.Add(Me.rbDistance3)
        Me.gbDistance.Controls.Add(Me.rbDistance4)
        Me.gbDistance.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDistance.Location = New System.Drawing.Point(21, 19)
        Me.gbDistance.Name = "gbDistance"
        Me.gbDistance.Size = New System.Drawing.Size(82, 92)
        Me.gbDistance.TabIndex = 17
        Me.gbDistance.TabStop = False
        Me.gbDistance.Text = "Distance"
        '
        'rbDistance1
        '
        Me.rbDistance1.AutoSize = True
        Me.rbDistance1.Location = New System.Drawing.Point(6, 16)
        Me.rbDistance1.Name = "rbDistance1"
        Me.rbDistance1.Size = New System.Drawing.Size(14, 13)
        Me.rbDistance1.TabIndex = 6
        Me.rbDistance1.TabStop = True
        Me.rbDistance1.Tag = "I1"
        Me.rbDistance1.UseVisualStyleBackColor = True
        '
        'rbDistance2
        '
        Me.rbDistance2.AutoSize = True
        Me.rbDistance2.Location = New System.Drawing.Point(6, 35)
        Me.rbDistance2.Name = "rbDistance2"
        Me.rbDistance2.Size = New System.Drawing.Size(14, 13)
        Me.rbDistance2.TabIndex = 7
        Me.rbDistance2.TabStop = True
        Me.rbDistance2.Tag = "I2"
        Me.rbDistance2.UseVisualStyleBackColor = True
        '
        'rbDistance3
        '
        Me.rbDistance3.AutoSize = True
        Me.rbDistance3.Location = New System.Drawing.Point(6, 54)
        Me.rbDistance3.Name = "rbDistance3"
        Me.rbDistance3.Size = New System.Drawing.Size(14, 13)
        Me.rbDistance3.TabIndex = 8
        Me.rbDistance3.TabStop = True
        Me.rbDistance3.Tag = "I3"
        Me.rbDistance3.UseVisualStyleBackColor = True
        '
        'rbDistance4
        '
        Me.rbDistance4.AutoSize = True
        Me.rbDistance4.Location = New System.Drawing.Point(6, 73)
        Me.rbDistance4.Name = "rbDistance4"
        Me.rbDistance4.Size = New System.Drawing.Size(14, 13)
        Me.rbDistance4.TabIndex = 9
        Me.rbDistance4.TabStop = True
        Me.rbDistance4.Tag = "I4"
        Me.rbDistance4.UseVisualStyleBackColor = True
        '
        'cbUnits
        '
        Me.cbUnits.AutoSize = True
        Me.cbUnits.Location = New System.Drawing.Point(123, 192)
        Me.cbUnits.Name = "cbUnits"
        Me.cbUnits.Size = New System.Drawing.Size(73, 17)
        Me.cbUnits.TabIndex = 16
        Me.cbUnits.Text = "Metric      "
        Me.cbUnits.UseVisualStyleBackColor = True
        '
        'gbStatus
        '
        Me.gbStatus.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbStatus.Controls.Add(Me.Label25)
        Me.gbStatus.Controls.Add(Me.tbCurrentStatus)
        Me.gbStatus.Controls.Add(Me.Label24)
        Me.gbStatus.Controls.Add(Me.prgbRxBuf)
        Me.gbStatus.Controls.Add(Me.prgBarQ)
        Me.gbStatus.Controls.Add(Me.cbVerbose)
        Me.gbStatus.Controls.Add(Me.lbResponses)
        Me.gbStatus.Enabled = False
        Me.gbStatus.Location = New System.Drawing.Point(532, 470)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.Size = New System.Drawing.Size(400, 204)
        Me.gbStatus.TabIndex = 1
        Me.gbStatus.TabStop = False
        Me.gbStatus.Text = "Status"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(217, 21)
        Me.Label25.Margin = New System.Windows.Forms.Padding(0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(18, 13)
        Me.Label25.TabIndex = 23
        Me.Label25.Text = "Q:"
        '
        'tbCurrentStatus
        '
        Me.tbCurrentStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCurrentStatus.Location = New System.Drawing.Point(6, 15)
        Me.tbCurrentStatus.Name = "tbCurrentStatus"
        Me.tbCurrentStatus.Size = New System.Drawing.Size(72, 26)
        Me.tbCurrentStatus.TabIndex = 34
        Me.tbCurrentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tbCurrentStatus, "Shows status of Grbl")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(304, 21)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(25, 13)
        Me.Label24.TabIndex = 22
        Me.Label24.Text = "RX:"
        '
        'prgbRxBuf
        '
        Me.prgbRxBuf.Location = New System.Drawing.Point(334, 20)
        Me.prgbRxBuf.Maximum = 127
        Me.prgbRxBuf.Name = "prgbRxBuf"
        Me.prgbRxBuf.Size = New System.Drawing.Size(60, 15)
        Me.prgbRxBuf.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgbRxBuf.TabIndex = 21
        '
        'prgBarQ
        '
        Me.prgBarQ.Location = New System.Drawing.Point(238, 20)
        Me.prgBarQ.Maximum = 25
        Me.prgBarQ.Name = "prgBarQ"
        Me.prgBarQ.Size = New System.Drawing.Size(60, 15)
        Me.prgBarQ.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.prgBarQ.TabIndex = 20
        '
        'cbVerbose
        '
        Me.cbVerbose.AutoSize = True
        Me.cbVerbose.Checked = Global.GrblPanel.My.MySettings.Default.StatusVerbose
        Me.cbVerbose.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "statusVerbose", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbVerbose.Location = New System.Drawing.Point(87, 20)
        Me.cbVerbose.Name = "cbVerbose"
        Me.cbVerbose.Size = New System.Drawing.Size(83, 17)
        Me.cbVerbose.TabIndex = 15
        Me.cbVerbose.Text = "Verbose      "
        Me.cbVerbose.UseVisualStyleBackColor = True
        '
        'lbResponses
        '
        Me.lbResponses.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbResponses.FormattingEnabled = True
        Me.lbResponses.HorizontalScrollbar = True
        Me.lbResponses.Location = New System.Drawing.Point(6, 50)
        Me.lbResponses.Name = "lbResponses"
        Me.lbResponses.Size = New System.Drawing.Size(388, 147)
        Me.lbResponses.TabIndex = 0
        '
        'gbGcode
        '
        Me.gbGcode.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGcode.Controls.Add(Me.btnFileReload)
        Me.gbGcode.Controls.Add(Me.tbGCodeMessage)
        Me.gbGcode.Controls.Add(Me.Label27)
        Me.gbGcode.Controls.Add(Me.lblTotalLines)
        Me.gbGcode.Controls.Add(Me.Label23)
        Me.gbGcode.Controls.Add(Me.btnFilePause)
        Me.gbGcode.Controls.Add(Me.tbGcodeFile)
        Me.gbGcode.Controls.Add(Me.btnFileSelect)
        Me.gbGcode.Controls.Add(Me.btnFileSend)
        Me.gbGcode.Controls.Add(Me.lvGcode)
        Me.gbGcode.Controls.Add(Me.btnFileStop)
        Me.gbGcode.Enabled = False
        Me.gbGcode.Location = New System.Drawing.Point(3, 310)
        Me.gbGcode.Name = "gbGcode"
        Me.gbGcode.Size = New System.Drawing.Size(520, 376)
        Me.gbGcode.TabIndex = 14
        Me.gbGcode.TabStop = False
        Me.gbGcode.Text = "GCode"
        '
        'btnFileReload
        '
        Me.btnFileReload.Enabled = False
        Me.btnFileReload.Image = CType(resources.GetObject("btnFileReload.Image"), System.Drawing.Image)
        Me.btnFileReload.Location = New System.Drawing.Point(190, 41)
        Me.btnFileReload.Name = "btnFileReload"
        Me.btnFileReload.Size = New System.Drawing.Size(40, 40)
        Me.btnFileReload.TabIndex = 21
        Me.btnFileReload.Tag = "Reload"
        Me.ToolTip1.SetToolTip(Me.btnFileReload, "Reload File")
        Me.btnFileReload.UseVisualStyleBackColor = True
        '
        'tbGCodeMessage
        '
        Me.tbGCodeMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbGCodeMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbGCodeMessage.Location = New System.Drawing.Point(285, 65)
        Me.tbGCodeMessage.Name = "tbGCodeMessage"
        Me.tbGCodeMessage.Size = New System.Drawing.Size(223, 16)
        Me.tbGCodeMessage.TabIndex = 20
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(282, 49)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(57, 13)
        Me.Label27.TabIndex = 19
        Me.Label27.Text = "Message"
        '
        'lblTotalLines
        '
        Me.lblTotalLines.AutoSize = True
        Me.lblTotalLines.Location = New System.Drawing.Point(246, 68)
        Me.lblTotalLines.Name = "lblTotalLines"
        Me.lblTotalLines.Size = New System.Drawing.Size(10, 13)
        Me.lblTotalLines.TabIndex = 17
        Me.lblTotalLines.Text = " "
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(236, 49)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(37, 13)
        Me.Label23.TabIndex = 15
        Me.Label23.Text = "Lines"
        '
        'btnFilePause
        '
        Me.btnFilePause.Enabled = False
        Me.btnFilePause.Image = CType(resources.GetObject("btnFilePause.Image"), System.Drawing.Image)
        Me.btnFilePause.Location = New System.Drawing.Point(98, 41)
        Me.btnFilePause.Name = "btnFilePause"
        Me.btnFilePause.Padding = New System.Windows.Forms.Padding(3)
        Me.btnFilePause.Size = New System.Drawing.Size(40, 40)
        Me.btnFilePause.TabIndex = 6
        Me.btnFilePause.Tag = "Pause"
        Me.ToolTip1.SetToolTip(Me.btnFilePause, "Pause sending")
        Me.btnFilePause.UseVisualStyleBackColor = True
        '
        'tbGcodeFile
        '
        Me.tbGcodeFile.Enabled = False
        Me.tbGcodeFile.Location = New System.Drawing.Point(6, 19)
        Me.tbGcodeFile.Name = "tbGcodeFile"
        Me.tbGcodeFile.Size = New System.Drawing.Size(424, 20)
        Me.tbGcodeFile.TabIndex = 10
        '
        'btnFileSelect
        '
        Me.btnFileSelect.Image = CType(resources.GetObject("btnFileSelect.Image"), System.Drawing.Image)
        Me.btnFileSelect.Location = New System.Drawing.Point(6, 41)
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Size = New System.Drawing.Size(40, 40)
        Me.btnFileSelect.TabIndex = 7
        Me.btnFileSelect.Tag = "File"
        Me.ToolTip1.SetToolTip(Me.btnFileSelect, "Load a file")
        Me.btnFileSelect.UseVisualStyleBackColor = True
        '
        'btnFileSend
        '
        Me.btnFileSend.Enabled = False
        Me.btnFileSend.Image = CType(resources.GetObject("btnFileSend.Image"), System.Drawing.Image)
        Me.btnFileSend.Location = New System.Drawing.Point(52, 41)
        Me.btnFileSend.Name = "btnFileSend"
        Me.btnFileSend.Size = New System.Drawing.Size(40, 40)
        Me.btnFileSend.TabIndex = 8
        Me.btnFileSend.Tag = "Send"
        Me.ToolTip1.SetToolTip(Me.btnFileSend, "Start/Resume sending")
        Me.btnFileSend.UseVisualStyleBackColor = True
        '
        'lvGcode
        '
        Me.lvGcode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvGcode.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lvColStatus, Me.lvColLineNo, Me.lvColGCode})
        Me.lvGcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvGcode.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvGcode.Location = New System.Drawing.Point(6, 84)
        Me.lvGcode.Name = "lvGcode"
        Me.lvGcode.Size = New System.Drawing.Size(503, 283)
        Me.lvGcode.TabIndex = 18
        Me.lvGcode.UseCompatibleStateImageBehavior = False
        Me.lvGcode.View = System.Windows.Forms.View.Details
        '
        'lvColStatus
        '
        Me.lvColStatus.Text = "Sts"
        Me.lvColStatus.Width = 46
        '
        'lvColLineNo
        '
        Me.lvColLineNo.Text = "Line"
        Me.lvColLineNo.Width = 46
        '
        'lvColGCode
        '
        Me.lvColGCode.Text = "GCode"
        Me.lvColGCode.Width = 459
        '
        'btnFileStop
        '
        Me.btnFileStop.Enabled = False
        Me.btnFileStop.Image = CType(resources.GetObject("btnFileStop.Image"), System.Drawing.Image)
        Me.btnFileStop.Location = New System.Drawing.Point(144, 41)
        Me.btnFileStop.Name = "btnFileStop"
        Me.btnFileStop.Size = New System.Drawing.Size(40, 40)
        Me.btnFileStop.TabIndex = 9
        Me.btnFileStop.Tag = "Stop"
        Me.ToolTip1.SetToolTip(Me.btnFileStop, "Stop sending")
        Me.btnFileStop.UseVisualStyleBackColor = True
        '
        'gbGrbl
        '
        Me.gbGrbl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbGrbl.Controls.Add(Me.tcConnection)
        Me.gbGrbl.Location = New System.Drawing.Point(3, 3)
        Me.gbGrbl.Name = "gbGrbl"
        Me.gbGrbl.Size = New System.Drawing.Size(178, 89)
        Me.gbGrbl.TabIndex = 3
        Me.gbGrbl.TabStop = False
        Me.gbGrbl.Text = "Grbl"
        '
        'tcConnection
        '
        Me.tcConnection.Controls.Add(Me.tbGrblCOM)
        Me.tcConnection.Controls.Add(Me.tbGrblIP)
        Me.tcConnection.Location = New System.Drawing.Point(6, 16)
        Me.tcConnection.Name = "tcConnection"
        Me.tcConnection.SelectedIndex = 0
        Me.tcConnection.Size = New System.Drawing.Size(162, 71)
        Me.tcConnection.TabIndex = 0
        '
        'tbGrblCOM
        '
        Me.tbGrblCOM.Controls.Add(Me.btnRescanPorts)
        Me.tbGrblCOM.Controls.Add(Me.cbPorts)
        Me.tbGrblCOM.Controls.Add(Me.btnConnect)
        Me.tbGrblCOM.Controls.Add(Me.cbBaud)
        Me.tbGrblCOM.Location = New System.Drawing.Point(4, 22)
        Me.tbGrblCOM.Name = "tbGrblCOM"
        Me.tbGrblCOM.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGrblCOM.Size = New System.Drawing.Size(154, 45)
        Me.tbGrblCOM.TabIndex = 0
        Me.tbGrblCOM.Text = "COM"
        Me.tbGrblCOM.UseVisualStyleBackColor = True
        '
        'btnRescanPorts
        '
        Me.btnRescanPorts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnRescanPorts.Location = New System.Drawing.Point(88, 18)
        Me.btnRescanPorts.Name = "btnRescanPorts"
        Me.btnRescanPorts.Size = New System.Drawing.Size(68, 23)
        Me.btnRescanPorts.TabIndex = 5
        Me.btnRescanPorts.Text = "ReScan"
        Me.btnRescanPorts.UseVisualStyleBackColor = True
        '
        'cbPorts
        '
        Me.cbPorts.FormattingEnabled = True
        Me.cbPorts.Location = New System.Drawing.Point(10, 0)
        Me.cbPorts.Name = "cbPorts"
        Me.cbPorts.Size = New System.Drawing.Size(72, 21)
        Me.cbPorts.TabIndex = 3
        '
        'btnConnect
        '
        Me.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnConnect.Location = New System.Drawing.Point(88, -2)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(68, 23)
        Me.btnConnect.TabIndex = 1
        Me.btnConnect.Tag = "COM"
        Me.btnConnect.Text = "Connect"
        Me.btnConnect.UseVisualStyleBackColor = True
        '
        'cbBaud
        '
        Me.cbBaud.FormattingEnabled = True
        Me.cbBaud.Items.AddRange(New Object() {"9600", "115200"})
        Me.cbBaud.Location = New System.Drawing.Point(10, 20)
        Me.cbBaud.Name = "cbBaud"
        Me.cbBaud.Size = New System.Drawing.Size(72, 21)
        Me.cbBaud.TabIndex = 4
        '
        'tbGrblIP
        '
        Me.tbGrblIP.Controls.Add(Me.btnIPConnect)
        Me.tbGrblIP.Controls.Add(Me.tbIPAddress)
        Me.tbGrblIP.Location = New System.Drawing.Point(4, 22)
        Me.tbGrblIP.Name = "tbGrblIP"
        Me.tbGrblIP.Padding = New System.Windows.Forms.Padding(3)
        Me.tbGrblIP.Size = New System.Drawing.Size(154, 45)
        Me.tbGrblIP.TabIndex = 1
        Me.tbGrblIP.Text = "IP"
        Me.tbGrblIP.UseVisualStyleBackColor = True
        '
        'btnIPConnect
        '
        Me.btnIPConnect.Location = New System.Drawing.Point(12, 20)
        Me.btnIPConnect.Name = "btnIPConnect"
        Me.btnIPConnect.Size = New System.Drawing.Size(131, 23)
        Me.btnIPConnect.TabIndex = 1
        Me.btnIPConnect.Tag = "IP"
        Me.btnIPConnect.Text = "Connect"
        Me.btnIPConnect.UseVisualStyleBackColor = True
        '
        'tbIPAddress
        '
        Me.tbIPAddress.Location = New System.Drawing.Point(12, 0)
        Me.tbIPAddress.Name = "tbIPAddress"
        Me.tbIPAddress.Size = New System.Drawing.Size(131, 20)
        Me.tbIPAddress.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbIPAddress, "Enter IP Address and port as ""<IP>:<port>""")
        '
        'gbPosition
        '
        Me.gbPosition.Controls.Add(Me.tabCtlPosition)
        Me.gbPosition.Enabled = False
        Me.gbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbPosition.Location = New System.Drawing.Point(532, 3)
        Me.gbPosition.Name = "gbPosition"
        Me.gbPosition.Size = New System.Drawing.Size(400, 403)
        Me.gbPosition.TabIndex = 2
        Me.gbPosition.TabStop = False
        Me.gbPosition.Text = "Position"
        '
        'tabCtlPosition
        '
        Me.tabCtlPosition.Controls.Add(Me.tpWork)
        Me.tabCtlPosition.Controls.Add(Me.tpOffsets)
        Me.tabCtlPosition.Location = New System.Drawing.Point(6, 19)
        Me.tabCtlPosition.Name = "tabCtlPosition"
        Me.tabCtlPosition.SelectedIndex = 0
        Me.tabCtlPosition.Size = New System.Drawing.Size(388, 378)
        Me.tabCtlPosition.TabIndex = 0
        '
        'tpWork
        '
        Me.tpWork.Controls.Add(Me.Panel5)
        Me.tpWork.Controls.Add(Me.Panel4)
        Me.tpWork.Controls.Add(Me.Panel3)
        Me.tpWork.Controls.Add(Me.GroupBox1)
        Me.tpWork.Controls.Add(Me.btnWorkSoftHome)
        Me.tpWork.Controls.Add(Me.btnHome)
        Me.tpWork.Controls.Add(Me.btnWorkSpclPosition)
        Me.tpWork.Controls.Add(Me.Label3)
        Me.tpWork.Controls.Add(Me.btnWork0)
        Me.tpWork.Controls.Add(Me.Label2)
        Me.tpWork.Controls.Add(Me.btnWorkX0)
        Me.tpWork.Controls.Add(Me.Label1)
        Me.tpWork.Controls.Add(Me.btnWorkZ0)
        Me.tpWork.Controls.Add(Me.btnWorkY0)
        Me.tpWork.Location = New System.Drawing.Point(4, 22)
        Me.tpWork.Name = "tpWork"
        Me.tpWork.Padding = New System.Windows.Forms.Padding(3)
        Me.tpWork.Size = New System.Drawing.Size(380, 352)
        Me.tpWork.TabIndex = 0
        Me.tpWork.Text = "Work"
        Me.tpWork.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.tbWorkZ)
        Me.Panel5.Controls.Add(Me.tbMachZ)
        Me.Panel5.Enabled = False
        Me.Panel5.Location = New System.Drawing.Point(48, 179)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(287, 88)
        Me.Panel5.TabIndex = 19
        '
        'tbWorkZ
        '
        Me.tbWorkZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbWorkZ.Enabled = False
        Me.tbWorkZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWorkZ.Location = New System.Drawing.Point(-1, 0)
        Me.tbWorkZ.Name = "tbWorkZ"
        Me.tbWorkZ.Size = New System.Drawing.Size(287, 68)
        Me.tbWorkZ.TabIndex = 5
        Me.tbWorkZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbWorkZ, "Work Z position")
        Me.tbWorkZ.WordWrap = False
        '
        'tbMachZ
        '
        Me.tbMachZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMachZ.Enabled = False
        Me.tbMachZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMachZ.Location = New System.Drawing.Point(188, 63)
        Me.tbMachZ.Name = "tbMachZ"
        Me.tbMachZ.Size = New System.Drawing.Size(98, 23)
        Me.tbMachZ.TabIndex = 8
        Me.tbMachZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbMachZ, "Machine Z position")
        Me.tbMachZ.WordWrap = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.tbWorkY)
        Me.Panel4.Controls.Add(Me.tbMachY)
        Me.Panel4.Enabled = False
        Me.Panel4.Location = New System.Drawing.Point(48, 91)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(287, 88)
        Me.Panel4.TabIndex = 18
        '
        'tbWorkY
        '
        Me.tbWorkY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbWorkY.Enabled = False
        Me.tbWorkY.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWorkY.Location = New System.Drawing.Point(0, -3)
        Me.tbWorkY.Name = "tbWorkY"
        Me.tbWorkY.Size = New System.Drawing.Size(287, 68)
        Me.tbWorkY.TabIndex = 4
        Me.tbWorkY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbWorkY, "Work Y position")
        Me.tbWorkY.WordWrap = False
        '
        'tbMachY
        '
        Me.tbMachY.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMachY.Enabled = False
        Me.tbMachY.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMachY.Location = New System.Drawing.Point(188, 64)
        Me.tbMachY.Name = "tbMachY"
        Me.tbMachY.Size = New System.Drawing.Size(98, 23)
        Me.tbMachY.TabIndex = 7
        Me.tbMachY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbMachY, "Machine Y position")
        Me.tbMachY.WordWrap = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tbMachX)
        Me.Panel3.Controls.Add(Me.tbWorkX)
        Me.Panel3.Enabled = False
        Me.Panel3.Location = New System.Drawing.Point(48, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(287, 88)
        Me.Panel3.TabIndex = 0
        '
        'tbMachX
        '
        Me.tbMachX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbMachX.Enabled = False
        Me.tbMachX.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbMachX.Location = New System.Drawing.Point(188, 64)
        Me.tbMachX.Name = "tbMachX"
        Me.tbMachX.Size = New System.Drawing.Size(98, 23)
        Me.tbMachX.TabIndex = 6
        Me.tbMachX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbMachX, "Machine X position")
        Me.tbMachX.WordWrap = False
        '
        'tbWorkX
        '
        Me.tbWorkX.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbWorkX.Enabled = False
        Me.tbWorkX.Font = New System.Drawing.Font("Microsoft Sans Serif", 45.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbWorkX.Location = New System.Drawing.Point(-1, -1)
        Me.tbWorkX.Name = "tbWorkX"
        Me.tbWorkX.Size = New System.Drawing.Size(287, 68)
        Me.tbWorkX.TabIndex = 12
        Me.tbWorkX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.tbWorkX, "Work X position")
        Me.tbWorkX.WordWrap = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPositionCurrentOffset)
        Me.GroupBox1.Location = New System.Drawing.Point(224, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(82, 58)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Active Offset"
        '
        'lblPositionCurrentOffset
        '
        Me.lblPositionCurrentOffset.AutoSize = True
        Me.lblPositionCurrentOffset.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPositionCurrentOffset.Location = New System.Drawing.Point(23, 21)
        Me.lblPositionCurrentOffset.Name = "lblPositionCurrentOffset"
        Me.lblPositionCurrentOffset.Size = New System.Drawing.Size(0, 20)
        Me.lblPositionCurrentOffset.TabIndex = 0
        '
        'btnWorkSoftHome
        '
        Me.btnWorkSoftHome.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnWorkSoftHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkSoftHome.Location = New System.Drawing.Point(75, 285)
        Me.btnWorkSoftHome.Name = "btnWorkSoftHome"
        Me.btnWorkSoftHome.Size = New System.Drawing.Size(66, 58)
        Me.btnWorkSoftHome.TabIndex = 16
        Me.btnWorkSoftHome.Tag = "Spcl Posn1"
        Me.btnWorkSoftHome.Text = "Go To Spcl Posn1"
        Me.ToolTip1.SetToolTip(Me.btnWorkSoftHome, "GoTo Position 1 using G28")
        Me.btnWorkSoftHome.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        Me.btnHome.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHome.Location = New System.Drawing.Point(5, 285)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(66, 58)
        Me.btnHome.TabIndex = 6
        Me.btnHome.Tag = "HomeCycle"
        Me.btnHome.Text = "Home Cycle"
        Me.ToolTip1.SetToolTip(Me.btnHome, "Perform Homing Cycle")
        Me.btnHome.UseVisualStyleBackColor = False
        Me.btnHome.Visible = False
        '
        'btnWorkSpclPosition
        '
        Me.btnWorkSpclPosition.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnWorkSpclPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkSpclPosition.Location = New System.Drawing.Point(145, 285)
        Me.btnWorkSpclPosition.Name = "btnWorkSpclPosition"
        Me.btnWorkSpclPosition.Size = New System.Drawing.Size(75, 58)
        Me.btnWorkSpclPosition.TabIndex = 16
        Me.btnWorkSpclPosition.Tag = "Spcl Posn2"
        Me.btnWorkSpclPosition.Text = "Go To Spcl Posn2"
        Me.ToolTip1.SetToolTip(Me.btnWorkSpclPosition, "Go To Position 2 using G30")
        Me.btnWorkSpclPosition.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 43)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Z"
        '
        'btnWork0
        '
        Me.btnWork0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnWork0.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWork0.Location = New System.Drawing.Point(310, 285)
        Me.btnWork0.Name = "btnWork0"
        Me.btnWork0.Size = New System.Drawing.Size(66, 58)
        Me.btnWork0.TabIndex = 5
        Me.btnWork0.Tag = "ZeroXYZ"
        Me.btnWork0.Text = "Zero XYZ"
        Me.ToolTip1.SetToolTip(Me.btnWork0, "Set all axes to 0 on Active Offset")
        Me.btnWork0.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 43)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Y"
        '
        'btnWorkX0
        '
        Me.btnWorkX0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnWorkX0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkX0.Location = New System.Drawing.Point(340, 33)
        Me.btnWorkX0.Name = "btnWorkX0"
        Me.btnWorkX0.Size = New System.Drawing.Size(34, 34)
        Me.btnWorkX0.TabIndex = 6
        Me.btnWorkX0.Tag = "X"
        Me.btnWorkX0.Text = "0"
        Me.ToolTip1.SetToolTip(Me.btnWorkX0, "Set X axis to 0 on Active Offset")
        Me.btnWorkX0.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Unicode MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 43)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "X"
        '
        'btnWorkZ0
        '
        Me.btnWorkZ0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnWorkZ0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkZ0.Location = New System.Drawing.Point(340, 207)
        Me.btnWorkZ0.Name = "btnWorkZ0"
        Me.btnWorkZ0.Size = New System.Drawing.Size(34, 34)
        Me.btnWorkZ0.TabIndex = 8
        Me.btnWorkZ0.Tag = "Z"
        Me.btnWorkZ0.Text = "0"
        Me.ToolTip1.SetToolTip(Me.btnWorkZ0, "Set Z axis to 0 on Active Offset")
        Me.btnWorkZ0.UseVisualStyleBackColor = True
        '
        'btnWorkY0
        '
        Me.btnWorkY0.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnWorkY0.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWorkY0.Location = New System.Drawing.Point(340, 120)
        Me.btnWorkY0.Name = "btnWorkY0"
        Me.btnWorkY0.Size = New System.Drawing.Size(34, 34)
        Me.btnWorkY0.TabIndex = 7
        Me.btnWorkY0.Tag = "Y"
        Me.btnWorkY0.Text = "0"
        Me.ToolTip1.SetToolTip(Me.btnWorkY0, "Set Y axis to 0 on Active Offset")
        Me.btnWorkY0.UseVisualStyleBackColor = True
        '
        'tpOffsets
        '
        Me.tpOffsets.Controls.Add(Me.Label10)
        Me.tpOffsets.Controls.Add(Me.Label71)
        Me.tpOffsets.Controls.Add(Me.tbOffSetsMachZ)
        Me.tpOffsets.Controls.Add(Me.Label19)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG56Y)
        Me.tpOffsets.Controls.Add(Me.tbOffSetsMachY)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG56X)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG56Z)
        Me.tpOffsets.Controls.Add(Me.tbOffSetsMachX)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG57Zero)
        Me.tpOffsets.Controls.Add(Me.Label64)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG54X)
        Me.tpOffsets.Controls.Add(Me.Label65)
        Me.tpOffsets.Controls.Add(Me.Label70)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG56Zero)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG54Y)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG57Z)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsSave)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG55X)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG54Z)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG57Y)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsRetrieve)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG55Y)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG54Zero)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG57X)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsLoad)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG55Z)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG59X)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG58Zero)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG43Zero)
        Me.tpOffsets.Controls.Add(Me.Label63)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG59Y)
        Me.tpOffsets.Controls.Add(Me.Label66)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG43Z)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG55Zero)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG59Z)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG58Z)
        Me.tpOffsets.Controls.Add(Me.Label60)
        Me.tpOffsets.Controls.Add(Me.Label67)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG58Y)
        Me.tpOffsets.Controls.Add(Me.Label20)
        Me.tpOffsets.Controls.Add(Me.Label43)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG59Zero)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG58X)
        Me.tpOffsets.Controls.Add(Me.Label21)
        Me.tpOffsets.Location = New System.Drawing.Point(4, 22)
        Me.tpOffsets.Name = "tpOffsets"
        Me.tpOffsets.Padding = New System.Windows.Forms.Padding(3)
        Me.tpOffsets.Size = New System.Drawing.Size(380, 352)
        Me.tpOffsets.TabIndex = 2
        Me.tpOffsets.Text = "Offsets"
        Me.tpOffsets.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(133, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(125, 13)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Current Machine location"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.Location = New System.Drawing.Point(23, 108)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(41, 13)
        Me.Label71.TabIndex = 115
        Me.Label71.Text = "G43.1"
        '
        'tbOffSetsMachZ
        '
        Me.tbOffSetsMachZ.Enabled = False
        Me.tbOffSetsMachZ.Location = New System.Drawing.Point(245, 45)
        Me.tbOffSetsMachZ.Name = "tbOffSetsMachZ"
        Me.tbOffSetsMachZ.Size = New System.Drawing.Size(79, 20)
        Me.tbOffSetsMachZ.TabIndex = 114
        Me.tbOffSetsMachZ.Tag = "G28Z"
        Me.ToolTip1.SetToolTip(Me.tbOffSetsMachZ, "Current Machine Z")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(23, 90)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(113, 13)
        Me.Label19.TabIndex = 100
        Me.Label19.Text = "Tool Length Offset"
        '
        'tbOffsetsG56Y
        '
        Me.tbOffsetsG56Y.Location = New System.Drawing.Point(160, 197)
        Me.tbOffsetsG56Y.Name = "tbOffsetsG56Y"
        Me.tbOffsetsG56Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG56Y.TabIndex = 76
        Me.tbOffsetsG56Y.Tag = "G56Y"
        '
        'tbOffSetsMachY
        '
        Me.tbOffSetsMachY.Enabled = False
        Me.tbOffSetsMachY.Location = New System.Drawing.Point(160, 45)
        Me.tbOffSetsMachY.Name = "tbOffSetsMachY"
        Me.tbOffSetsMachY.Size = New System.Drawing.Size(79, 20)
        Me.tbOffSetsMachY.TabIndex = 113
        Me.tbOffSetsMachY.Tag = "G28Y"
        Me.ToolTip1.SetToolTip(Me.tbOffSetsMachY, "Current Machine Y")
        '
        'tbOffsetsG56X
        '
        Me.tbOffsetsG56X.Location = New System.Drawing.Point(75, 197)
        Me.tbOffsetsG56X.Name = "tbOffsetsG56X"
        Me.tbOffsetsG56X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG56X.TabIndex = 75
        Me.tbOffsetsG56X.Tag = "G56X"
        '
        'tbOffsetsG56Z
        '
        Me.tbOffsetsG56Z.Location = New System.Drawing.Point(245, 197)
        Me.tbOffsetsG56Z.Name = "tbOffsetsG56Z"
        Me.tbOffsetsG56Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG56Z.TabIndex = 77
        Me.tbOffsetsG56Z.Tag = "G56Z"
        '
        'tbOffSetsMachX
        '
        Me.tbOffSetsMachX.Enabled = False
        Me.tbOffSetsMachX.Location = New System.Drawing.Point(75, 45)
        Me.tbOffSetsMachX.Name = "tbOffSetsMachX"
        Me.tbOffSetsMachX.Size = New System.Drawing.Size(79, 20)
        Me.tbOffSetsMachX.TabIndex = 112
        Me.tbOffSetsMachX.Tag = "G28X"
        Me.ToolTip1.SetToolTip(Me.tbOffSetsMachX, "Current Machine X")
        '
        'btnOffsetsG57Zero
        '
        Me.btnOffsetsG57Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG57Zero.Location = New System.Drawing.Point(330, 222)
        Me.btnOffsetsG57Zero.Name = "btnOffsetsG57Zero"
        Me.btnOffsetsG57Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG57Zero.TabIndex = 74
        Me.btnOffsetsG57Zero.Tag = "G57Zero"
        Me.btnOffsetsG57Zero.Text = "0"
        Me.btnOffsetsG57Zero.UseVisualStyleBackColor = True
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.Location = New System.Drawing.Point(23, 200)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(30, 13)
        Me.Label64.TabIndex = 78
        Me.Label64.Text = "G56"
        '
        'tbOffsetsG54X
        '
        Me.tbOffsetsG54X.Location = New System.Drawing.Point(75, 145)
        Me.tbOffsetsG54X.Name = "tbOffsetsG54X"
        Me.tbOffsetsG54X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG54X.TabIndex = 56
        Me.tbOffsetsG54X.Tag = "G54X"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.Location = New System.Drawing.Point(23, 226)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(30, 13)
        Me.Label65.TabIndex = 73
        Me.Label65.Text = "G57"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.Location = New System.Drawing.Point(23, 147)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(30, 13)
        Me.Label70.TabIndex = 110
        Me.Label70.Text = "G54"
        '
        'btnOffsetsG56Zero
        '
        Me.btnOffsetsG56Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG56Zero.Location = New System.Drawing.Point(330, 196)
        Me.btnOffsetsG56Zero.Name = "btnOffsetsG56Zero"
        Me.btnOffsetsG56Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG56Zero.TabIndex = 79
        Me.btnOffsetsG56Zero.Tag = "G56Zero"
        Me.btnOffsetsG56Zero.Text = "0"
        Me.btnOffsetsG56Zero.UseVisualStyleBackColor = True
        '
        'tbOffsetsG54Y
        '
        Me.tbOffsetsG54Y.Location = New System.Drawing.Point(160, 145)
        Me.tbOffsetsG54Y.Name = "tbOffsetsG54Y"
        Me.tbOffsetsG54Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG54Y.TabIndex = 57
        Me.tbOffsetsG54Y.Tag = "G54Y"
        '
        'tbOffsetsG57Z
        '
        Me.tbOffsetsG57Z.Location = New System.Drawing.Point(245, 223)
        Me.tbOffsetsG57Z.Name = "tbOffsetsG57Z"
        Me.tbOffsetsG57Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG57Z.TabIndex = 72
        Me.tbOffsetsG57Z.Tag = "G57Z"
        '
        'btnOffsetsSave
        '
        Me.btnOffsetsSave.Location = New System.Drawing.Point(160, 299)
        Me.btnOffsetsSave.Name = "btnOffsetsSave"
        Me.btnOffsetsSave.Size = New System.Drawing.Size(75, 23)
        Me.btnOffsetsSave.TabIndex = 107
        Me.btnOffsetsSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsSave, "Save Work Offsets to File")
        Me.btnOffsetsSave.UseVisualStyleBackColor = True
        '
        'tbOffsetsG55X
        '
        Me.tbOffsetsG55X.Location = New System.Drawing.Point(75, 171)
        Me.tbOffsetsG55X.Name = "tbOffsetsG55X"
        Me.tbOffsetsG55X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG55X.TabIndex = 80
        Me.tbOffsetsG55X.Tag = "G55X"
        '
        'tbOffsetsG54Z
        '
        Me.tbOffsetsG54Z.Location = New System.Drawing.Point(245, 145)
        Me.tbOffsetsG54Z.Name = "tbOffsetsG54Z"
        Me.tbOffsetsG54Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG54Z.TabIndex = 58
        Me.tbOffsetsG54Z.Tag = "G54Z"
        '
        'tbOffsetsG57Y
        '
        Me.tbOffsetsG57Y.Location = New System.Drawing.Point(160, 223)
        Me.tbOffsetsG57Y.Name = "tbOffsetsG57Y"
        Me.tbOffsetsG57Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG57Y.TabIndex = 71
        Me.tbOffsetsG57Y.Tag = "G57Y"
        '
        'btnOffsetsRetrieve
        '
        Me.btnOffsetsRetrieve.Location = New System.Drawing.Point(245, 299)
        Me.btnOffsetsRetrieve.Name = "btnOffsetsRetrieve"
        Me.btnOffsetsRetrieve.Size = New System.Drawing.Size(75, 23)
        Me.btnOffsetsRetrieve.TabIndex = 106
        Me.btnOffsetsRetrieve.Text = "Retrieve"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsRetrieve, "Get from Grbl")
        Me.btnOffsetsRetrieve.UseVisualStyleBackColor = True
        '
        'tbOffsetsG55Y
        '
        Me.tbOffsetsG55Y.Location = New System.Drawing.Point(160, 171)
        Me.tbOffsetsG55Y.Name = "tbOffsetsG55Y"
        Me.tbOffsetsG55Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG55Y.TabIndex = 81
        Me.tbOffsetsG55Y.Tag = "G55Y"
        '
        'btnOffsetsG54Zero
        '
        Me.btnOffsetsG54Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG54Zero.Location = New System.Drawing.Point(330, 144)
        Me.btnOffsetsG54Zero.Name = "btnOffsetsG54Zero"
        Me.btnOffsetsG54Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG54Zero.TabIndex = 59
        Me.btnOffsetsG54Zero.Tag = "G54Zero"
        Me.btnOffsetsG54Zero.Text = "0"
        Me.btnOffsetsG54Zero.UseVisualStyleBackColor = True
        '
        'tbOffsetsG57X
        '
        Me.tbOffsetsG57X.Location = New System.Drawing.Point(75, 223)
        Me.tbOffsetsG57X.Name = "tbOffsetsG57X"
        Me.tbOffsetsG57X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG57X.TabIndex = 70
        Me.tbOffsetsG57X.Tag = "G57X"
        '
        'btnOffsetsLoad
        '
        Me.btnOffsetsLoad.Location = New System.Drawing.Point(75, 300)
        Me.btnOffsetsLoad.Name = "btnOffsetsLoad"
        Me.btnOffsetsLoad.Size = New System.Drawing.Size(75, 23)
        Me.btnOffsetsLoad.TabIndex = 105
        Me.btnOffsetsLoad.Text = "Load"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsLoad, "Load Work Offsets from File")
        Me.btnOffsetsLoad.UseVisualStyleBackColor = True
        '
        'tbOffsetsG55Z
        '
        Me.tbOffsetsG55Z.Location = New System.Drawing.Point(245, 171)
        Me.tbOffsetsG55Z.Name = "tbOffsetsG55Z"
        Me.tbOffsetsG55Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG55Z.TabIndex = 82
        Me.tbOffsetsG55Z.Tag = "G55Z"
        '
        'tbOffsetsG59X
        '
        Me.tbOffsetsG59X.Location = New System.Drawing.Point(75, 275)
        Me.tbOffsetsG59X.Name = "tbOffsetsG59X"
        Me.tbOffsetsG59X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG59X.TabIndex = 60
        Me.tbOffsetsG59X.Tag = "G59X"
        '
        'btnOffsetsG58Zero
        '
        Me.btnOffsetsG58Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG58Zero.Location = New System.Drawing.Point(330, 248)
        Me.btnOffsetsG58Zero.Name = "btnOffsetsG58Zero"
        Me.btnOffsetsG58Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG58Zero.TabIndex = 69
        Me.btnOffsetsG58Zero.Tag = "G58Zero"
        Me.btnOffsetsG58Zero.Text = "0"
        Me.btnOffsetsG58Zero.UseVisualStyleBackColor = True
        '
        'btnOffsetsG43Zero
        '
        Me.btnOffsetsG43Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG43Zero.Location = New System.Drawing.Point(330, 104)
        Me.btnOffsetsG43Zero.Name = "btnOffsetsG43Zero"
        Me.btnOffsetsG43Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG43Zero.TabIndex = 103
        Me.btnOffsetsG43Zero.Tag = "G43Zero"
        Me.btnOffsetsG43Zero.Text = "0"
        Me.btnOffsetsG43Zero.UseVisualStyleBackColor = True
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.Location = New System.Drawing.Point(23, 174)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(30, 13)
        Me.Label63.TabIndex = 83
        Me.Label63.Text = "G55"
        '
        'tbOffsetsG59Y
        '
        Me.tbOffsetsG59Y.Location = New System.Drawing.Point(160, 275)
        Me.tbOffsetsG59Y.Name = "tbOffsetsG59Y"
        Me.tbOffsetsG59Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG59Y.TabIndex = 61
        Me.tbOffsetsG59Y.Tag = "G59Y"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.Location = New System.Drawing.Point(23, 252)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(30, 13)
        Me.Label66.TabIndex = 68
        Me.Label66.Text = "G58"
        '
        'tbOffsetsG43Z
        '
        Me.tbOffsetsG43Z.Location = New System.Drawing.Point(245, 105)
        Me.tbOffsetsG43Z.Name = "tbOffsetsG43Z"
        Me.tbOffsetsG43Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG43Z.TabIndex = 102
        Me.tbOffsetsG43Z.Tag = "G43Z"
        '
        'btnOffsetsG55Zero
        '
        Me.btnOffsetsG55Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG55Zero.Location = New System.Drawing.Point(330, 170)
        Me.btnOffsetsG55Zero.Name = "btnOffsetsG55Zero"
        Me.btnOffsetsG55Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG55Zero.TabIndex = 84
        Me.btnOffsetsG55Zero.Tag = "G55Zero"
        Me.btnOffsetsG55Zero.Text = "0"
        Me.btnOffsetsG55Zero.UseVisualStyleBackColor = True
        '
        'tbOffsetsG59Z
        '
        Me.tbOffsetsG59Z.Location = New System.Drawing.Point(245, 275)
        Me.tbOffsetsG59Z.Name = "tbOffsetsG59Z"
        Me.tbOffsetsG59Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG59Z.TabIndex = 62
        Me.tbOffsetsG59Z.Tag = "G59Z"
        '
        'tbOffsetsG58Z
        '
        Me.tbOffsetsG58Z.Location = New System.Drawing.Point(245, 249)
        Me.tbOffsetsG58Z.Name = "tbOffsetsG58Z"
        Me.tbOffsetsG58Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG58Z.TabIndex = 67
        Me.tbOffsetsG58Z.Tag = "G58Z"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.Location = New System.Drawing.Point(116, 68)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(15, 13)
        Me.Label60.TabIndex = 85
        Me.Label60.Text = "X"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.Location = New System.Drawing.Point(23, 278)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(30, 13)
        Me.Label67.TabIndex = 63
        Me.Label67.Text = "G59"
        '
        'tbOffsetsG58Y
        '
        Me.tbOffsetsG58Y.Location = New System.Drawing.Point(160, 249)
        Me.tbOffsetsG58Y.Name = "tbOffsetsG58Y"
        Me.tbOffsetsG58Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG58Y.TabIndex = 66
        Me.tbOffsetsG58Y.Tag = "G58Y"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(28, 129)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(81, 13)
        Me.Label20.TabIndex = 99
        Me.Label20.Text = "Work Offsets"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(189, 68)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(15, 13)
        Me.Label43.TabIndex = 86
        Me.Label43.Text = "Y"
        '
        'btnOffsetsG59Zero
        '
        Me.btnOffsetsG59Zero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG59Zero.Location = New System.Drawing.Point(330, 274)
        Me.btnOffsetsG59Zero.Name = "btnOffsetsG59Zero"
        Me.btnOffsetsG59Zero.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG59Zero.TabIndex = 64
        Me.btnOffsetsG59Zero.Tag = "G59Zero"
        Me.btnOffsetsG59Zero.Text = "0"
        Me.btnOffsetsG59Zero.UseVisualStyleBackColor = True
        '
        'tbOffsetsG58X
        '
        Me.tbOffsetsG58X.Location = New System.Drawing.Point(75, 249)
        Me.tbOffsetsG58X.Name = "tbOffsetsG58X"
        Me.tbOffsetsG58X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG58X.TabIndex = 65
        Me.tbOffsetsG58X.Tag = "G58X"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(280, 68)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(15, 13)
        Me.Label21.TabIndex = 87
        Me.Label21.Text = "Z"
        '
        'tabPgSettings
        '
        Me.tabPgSettings.Controls.Add(Me.gbGrblSettings)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsOffsets)
        Me.tabPgSettings.Controls.Add(Me.Label42)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsMisc)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsPosition)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsJogging)
        Me.tabPgSettings.Location = New System.Drawing.Point(4, 22)
        Me.tabPgSettings.Name = "tabPgSettings"
        Me.tabPgSettings.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPgSettings.Size = New System.Drawing.Size(1134, 677)
        Me.tabPgSettings.TabIndex = 1
        Me.tabPgSettings.Text = "Settings"
        Me.tabPgSettings.UseVisualStyleBackColor = True
        '
        'gbGrblSettings
        '
        Me.gbGrblSettings.Controls.Add(Me.Label4)
        Me.gbGrblSettings.Controls.Add(Me.tbSettingsGrblLastParam)
        Me.gbGrblSettings.Controls.Add(Me.dgGrblSettings)
        Me.gbGrblSettings.Controls.Add(Me.btnSettingsGrbl)
        Me.gbGrblSettings.Location = New System.Drawing.Point(10, 19)
        Me.gbGrblSettings.Name = "gbGrblSettings"
        Me.gbGrblSettings.Size = New System.Drawing.Size(346, 590)
        Me.gbGrblSettings.TabIndex = 111
        Me.gbGrblSettings.TabStop = False
        Me.gbGrblSettings.Text = "Grbl Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(57, 555)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Grbl Param"
        '
        'tbSettingsGrblLastParam
        '
        Me.tbSettingsGrblLastParam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "GrblLastParamID", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsGrblLastParam.Location = New System.Drawing.Point(6, 552)
        Me.tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam"
        Me.tbSettingsGrblLastParam.Size = New System.Drawing.Size(45, 20)
        Me.tbSettingsGrblLastParam.TabIndex = 6
        Me.tbSettingsGrblLastParam.Text = Global.GrblPanel.My.MySettings.Default.GrblLastParamID
        Me.ToolTip1.SetToolTip(Me.tbSettingsGrblLastParam, "Change this to reflect the highest Grbl Parameter number")
        '
        'dgGrblSettings
        '
        Me.dgGrblSettings.AllowUserToAddRows = False
        Me.dgGrblSettings.AllowUserToDeleteRows = False
        Me.dgGrblSettings.AllowUserToResizeColumns = False
        Me.dgGrblSettings.AllowUserToResizeRows = False
        Me.dgGrblSettings.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgGrblSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgGrblSettings.Location = New System.Drawing.Point(3, 13)
        Me.dgGrblSettings.MultiSelect = False
        Me.dgGrblSettings.Name = "dgGrblSettings"
        Me.dgGrblSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgGrblSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgGrblSettings.Size = New System.Drawing.Size(337, 530)
        Me.dgGrblSettings.TabIndex = 4
        '
        'btnSettingsGrbl
        '
        Me.btnSettingsGrbl.Location = New System.Drawing.Point(265, 549)
        Me.btnSettingsGrbl.Name = "btnSettingsGrbl"
        Me.btnSettingsGrbl.Size = New System.Drawing.Size(75, 41)
        Me.btnSettingsGrbl.TabIndex = 5
        Me.btnSettingsGrbl.Text = "Get Grbl Settings"
        Me.btnSettingsGrbl.UseVisualStyleBackColor = True
        '
        'gbSettingsOffsets
        '
        Me.gbSettingsOffsets.Controls.Add(Me.btnOffsetsG28Set)
        Me.gbSettingsOffsets.Controls.Add(Me.btnSettingsRetrieveLocations)
        Me.gbSettingsOffsets.Controls.Add(Me.Label7)
        Me.gbSettingsOffsets.Controls.Add(Me.Label18)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG30Y)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG30X)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG30Z)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG28X)
        Me.gbSettingsOffsets.Controls.Add(Me.btnOffsetsG30Set)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG28Y)
        Me.gbSettingsOffsets.Controls.Add(Me.Label68)
        Me.gbSettingsOffsets.Controls.Add(Me.tbOffsetsG28Z)
        Me.gbSettingsOffsets.Controls.Add(Me.Label69)
        Me.gbSettingsOffsets.Location = New System.Drawing.Point(362, 498)
        Me.gbSettingsOffsets.Name = "gbSettingsOffsets"
        Me.gbSettingsOffsets.Size = New System.Drawing.Size(351, 111)
        Me.gbSettingsOffsets.TabIndex = 110
        Me.gbSettingsOffsets.TabStop = False
        Me.gbSettingsOffsets.Text = "Offsets (2)"
        '
        'btnOffsetsG28Set
        '
        Me.btnOffsetsG28Set.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG28Set.Location = New System.Drawing.Point(311, 29)
        Me.btnOffsetsG28Set.Name = "btnOffsetsG28Set"
        Me.btnOffsetsG28Set.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG28Set.TabIndex = 112
        Me.btnOffsetsG28Set.Tag = "G28Set"
        Me.btnOffsetsG28Set.Text = "Set"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsG28Set, "Set Special Position 1 to current Machine position")
        Me.btnOffsetsG28Set.UseVisualStyleBackColor = True
        '
        'btnSettingsRetrieveLocations
        '
        Me.btnSettingsRetrieveLocations.Location = New System.Drawing.Point(276, 88)
        Me.btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations"
        Me.btnSettingsRetrieveLocations.Size = New System.Drawing.Size(75, 23)
        Me.btnSettingsRetrieveLocations.TabIndex = 111
        Me.btnSettingsRetrieveLocations.Text = "Retrieve"
        Me.ToolTip1.SetToolTip(Me.btnSettingsRetrieveLocations, "Get current settings from Grbl")
        Me.btnSettingsRetrieveLocations.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(5, 95)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(185, 13)
        Me.Label7.TabIndex = 110
        Me.Label7.Text = "(Work Offsets are set from main page)"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(8, 16)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(114, 13)
        Me.Label18.TabIndex = 101
        Me.Label18.Text = "Machine Locations"
        '
        'tbOffsetsG30Y
        '
        Me.tbOffsetsG30Y.Enabled = False
        Me.tbOffsetsG30Y.Location = New System.Drawing.Point(141, 59)
        Me.tbOffsetsG30Y.Name = "tbOffsetsG30Y"
        Me.tbOffsetsG30Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG30Y.TabIndex = 95
        Me.tbOffsetsG30Y.Tag = "G30Y"
        '
        'tbOffsetsG30X
        '
        Me.tbOffsetsG30X.Enabled = False
        Me.tbOffsetsG30X.Location = New System.Drawing.Point(56, 59)
        Me.tbOffsetsG30X.Name = "tbOffsetsG30X"
        Me.tbOffsetsG30X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG30X.TabIndex = 94
        Me.tbOffsetsG30X.Tag = "G30X"
        '
        'tbOffsetsG30Z
        '
        Me.tbOffsetsG30Z.Enabled = False
        Me.tbOffsetsG30Z.Location = New System.Drawing.Point(226, 59)
        Me.tbOffsetsG30Z.Name = "tbOffsetsG30Z"
        Me.tbOffsetsG30Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG30Z.TabIndex = 96
        Me.tbOffsetsG30Z.Tag = "G30Z"
        '
        'tbOffsetsG28X
        '
        Me.tbOffsetsG28X.Enabled = False
        Me.tbOffsetsG28X.Location = New System.Drawing.Point(56, 31)
        Me.tbOffsetsG28X.Name = "tbOffsetsG28X"
        Me.tbOffsetsG28X.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG28X.TabIndex = 89
        Me.tbOffsetsG28X.Tag = "G28X"
        '
        'btnOffsetsG30Set
        '
        Me.btnOffsetsG30Set.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOffsetsG30Set.Location = New System.Drawing.Point(311, 58)
        Me.btnOffsetsG30Set.Name = "btnOffsetsG30Set"
        Me.btnOffsetsG30Set.Size = New System.Drawing.Size(35, 23)
        Me.btnOffsetsG30Set.TabIndex = 97
        Me.btnOffsetsG30Set.Tag = "G30Set"
        Me.btnOffsetsG30Set.Text = "Set"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsG30Set, "Set Special Position 2 to current Machine position")
        Me.btnOffsetsG30Set.UseVisualStyleBackColor = True
        '
        'tbOffsetsG28Y
        '
        Me.tbOffsetsG28Y.Enabled = False
        Me.tbOffsetsG28Y.Location = New System.Drawing.Point(141, 31)
        Me.tbOffsetsG28Y.Name = "tbOffsetsG28Y"
        Me.tbOffsetsG28Y.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG28Y.TabIndex = 90
        Me.tbOffsetsG28Y.Tag = "G28Y"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.Location = New System.Drawing.Point(4, 35)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(30, 13)
        Me.Label68.TabIndex = 108
        Me.Label68.Text = "G28"
        '
        'tbOffsetsG28Z
        '
        Me.tbOffsetsG28Z.Enabled = False
        Me.tbOffsetsG28Z.Location = New System.Drawing.Point(226, 31)
        Me.tbOffsetsG28Z.Name = "tbOffsetsG28Z"
        Me.tbOffsetsG28Z.Size = New System.Drawing.Size(79, 20)
        Me.tbOffsetsG28Z.TabIndex = 91
        Me.tbOffsetsG28Z.Tag = "G28Z"
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.Location = New System.Drawing.Point(4, 63)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(30, 13)
        Me.Label69.TabIndex = 109
        Me.Label69.Text = "G30"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(359, 3)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(283, 13)
        Me.Label42.TabIndex = 3
        Me.Label42.Text = "These settings always save on exit of Grbl-Panel"
        '
        'gbSettingsMisc
        '
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsDefaultExt)
        Me.gbSettingsMisc.Controls.Add(Me.Label5)
        Me.gbSettingsMisc.Controls.Add(Me.Label6)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsStartupDelay)
        Me.gbSettingsMisc.Controls.Add(Me.cbSettingsLeftHanded)
        Me.gbSettingsMisc.Controls.Add(Me.cbSettingsConnectOnLoad)
        Me.gbSettingsMisc.Controls.Add(Me.cbSettingsPauseOnError)
        Me.gbSettingsMisc.Controls.Add(Me.cbStatusPollEnable)
        Me.gbSettingsMisc.Controls.Add(Me.btnSettingsRefreshMisc)
        Me.gbSettingsMisc.Controls.Add(Me.Label37)
        Me.gbSettingsMisc.Controls.Add(Me.Label36)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsRBuffSize)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsQSize)
        Me.gbSettingsMisc.Controls.Add(Me.Label26)
        Me.gbSettingsMisc.Controls.Add(Me.tbSettingsPollRate)
        Me.gbSettingsMisc.Location = New System.Drawing.Point(362, 234)
        Me.gbSettingsMisc.Name = "gbSettingsMisc"
        Me.gbSettingsMisc.Size = New System.Drawing.Size(239, 258)
        Me.gbSettingsMisc.TabIndex = 2
        Me.gbSettingsMisc.TabStop = False
        Me.gbSettingsMisc.Text = "Misc"
        '
        'tbSettingsDefaultExt
        '
        Me.tbSettingsDefaultExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "DefaultFileExt", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsDefaultExt.Location = New System.Drawing.Point(12, 120)
        Me.tbSettingsDefaultExt.Name = "tbSettingsDefaultExt"
        Me.tbSettingsDefaultExt.Size = New System.Drawing.Size(43, 20)
        Me.tbSettingsDefaultExt.TabIndex = 22
        Me.tbSettingsDefaultExt.Text = Global.GrblPanel.My.MySettings.Default.DefaultFileExt
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(70, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Startup delay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(70, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Default File ext"
        '
        'tbSettingsStartupDelay
        '
        Me.tbSettingsStartupDelay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "StartupDelay", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsStartupDelay.Location = New System.Drawing.Point(12, 94)
        Me.tbSettingsStartupDelay.Name = "tbSettingsStartupDelay"
        Me.tbSettingsStartupDelay.Size = New System.Drawing.Size(44, 20)
        Me.tbSettingsStartupDelay.TabIndex = 19
        Me.tbSettingsStartupDelay.Text = Global.GrblPanel.My.MySettings.Default.StartupDelay
        '
        'cbSettingsLeftHanded
        '
        Me.cbSettingsLeftHanded.AutoSize = True
        Me.cbSettingsLeftHanded.Checked = Global.GrblPanel.My.MySettings.Default.LeftHandedGUI
        Me.cbSettingsLeftHanded.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "LeftHandedGUI", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsLeftHanded.Location = New System.Drawing.Point(124, 187)
        Me.cbSettingsLeftHanded.Name = "cbSettingsLeftHanded"
        Me.cbSettingsLeftHanded.Size = New System.Drawing.Size(107, 17)
        Me.cbSettingsLeftHanded.TabIndex = 18
        Me.cbSettingsLeftHanded.Text = "Left Handed GUI"
        Me.cbSettingsLeftHanded.UseVisualStyleBackColor = True
        '
        'cbSettingsConnectOnLoad
        '
        Me.cbSettingsConnectOnLoad.AutoSize = True
        Me.cbSettingsConnectOnLoad.Checked = Global.GrblPanel.My.MySettings.Default.GrblConnectOnLoad
        Me.cbSettingsConnectOnLoad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "GrblConnectOnLoad", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsConnectOnLoad.Location = New System.Drawing.Point(11, 169)
        Me.cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad"
        Me.cbSettingsConnectOnLoad.Size = New System.Drawing.Size(108, 17)
        Me.cbSettingsConnectOnLoad.TabIndex = 12
        Me.cbSettingsConnectOnLoad.Text = "Connect on Load"
        Me.ToolTip1.SetToolTip(Me.cbSettingsConnectOnLoad, "Connect automatically to last port")
        Me.cbSettingsConnectOnLoad.UseVisualStyleBackColor = True
        '
        'cbSettingsPauseOnError
        '
        Me.cbSettingsPauseOnError.AutoSize = True
        Me.cbSettingsPauseOnError.Checked = Global.GrblPanel.My.MySettings.Default.GCodePauseOnError
        Me.cbSettingsPauseOnError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsPauseOnError.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "GCodePauseOnError", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsPauseOnError.Location = New System.Drawing.Point(11, 152)
        Me.cbSettingsPauseOnError.Name = "cbSettingsPauseOnError"
        Me.cbSettingsPauseOnError.Size = New System.Drawing.Size(96, 17)
        Me.cbSettingsPauseOnError.TabIndex = 7
        Me.cbSettingsPauseOnError.Text = "Pause on Error"
        Me.cbSettingsPauseOnError.UseVisualStyleBackColor = True
        '
        'cbStatusPollEnable
        '
        Me.cbStatusPollEnable.AutoSize = True
        Me.cbStatusPollEnable.Checked = Global.GrblPanel.My.MySettings.Default.StatusPollEnabled
        Me.cbStatusPollEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusPollEnable.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "StatusPollEnabled", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbStatusPollEnable.Location = New System.Drawing.Point(10, 187)
        Me.cbStatusPollEnable.Name = "cbStatusPollEnable"
        Me.cbStatusPollEnable.Size = New System.Drawing.Size(76, 17)
        Me.cbStatusPollEnable.TabIndex = 17
        Me.cbStatusPollEnable.Text = "Status Poll"
        Me.cbStatusPollEnable.UseVisualStyleBackColor = True
        '
        'btnSettingsRefreshMisc
        '
        Me.btnSettingsRefreshMisc.Location = New System.Drawing.Point(0, 235)
        Me.btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc"
        Me.btnSettingsRefreshMisc.Size = New System.Drawing.Size(75, 23)
        Me.btnSettingsRefreshMisc.TabIndex = 6
        Me.btnSettingsRefreshMisc.Tag = "Misc"
        Me.btnSettingsRefreshMisc.Text = "Refresh"
        Me.btnSettingsRefreshMisc.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(70, 70)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(77, 13)
        Me.Label37.TabIndex = 5
        Me.Label37.Text = "RBuf Max Size"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(70, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(61, 13)
        Me.Label36.TabIndex = 4
        Me.Label36.Text = "Q Max Size"
        '
        'tbSettingsRBuffSize
        '
        Me.tbSettingsRBuffSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "RBuffMaxSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsRBuffSize.Location = New System.Drawing.Point(12, 68)
        Me.tbSettingsRBuffSize.Name = "tbSettingsRBuffSize"
        Me.tbSettingsRBuffSize.Size = New System.Drawing.Size(43, 20)
        Me.tbSettingsRBuffSize.TabIndex = 3
        Me.tbSettingsRBuffSize.Text = Global.GrblPanel.My.MySettings.Default.RBuffMaxSize
        '
        'tbSettingsQSize
        '
        Me.tbSettingsQSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "QBuffMaxSize", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsQSize.Location = New System.Drawing.Point(12, 42)
        Me.tbSettingsQSize.Name = "tbSettingsQSize"
        Me.tbSettingsQSize.Size = New System.Drawing.Size(43, 20)
        Me.tbSettingsQSize.TabIndex = 2
        Me.tbSettingsQSize.Text = Global.GrblPanel.My.MySettings.Default.QBuffMaxSize
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(70, 22)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(84, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Poll Interval (ms)"
        '
        'tbSettingsPollRate
        '
        Me.tbSettingsPollRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "statusPollInterval", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsPollRate.Location = New System.Drawing.Point(12, 19)
        Me.tbSettingsPollRate.Name = "tbSettingsPollRate"
        Me.tbSettingsPollRate.Size = New System.Drawing.Size(43, 20)
        Me.tbSettingsPollRate.TabIndex = 0
        Me.tbSettingsPollRate.Text = Global.GrblPanel.My.MySettings.Default.StatusPollInterval
        '
        'gbSettingsPosition
        '
        Me.gbSettingsPosition.Controls.Add(Me.Label8)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsSpclPosition2)
        Me.gbSettingsPosition.Controls.Add(Me.btnSettingsRefreshPosition)
        Me.gbSettingsPosition.Controls.Add(Me.Label29)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkZ0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label28)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkY0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label13)
        Me.gbSettingsPosition.Controls.Add(Me.Label12)
        Me.gbSettingsPosition.Controls.Add(Me.tbWorkX0Cmd)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsZeroXYZCmd)
        Me.gbSettingsPosition.Controls.Add(Me.Label11)
        Me.gbSettingsPosition.Controls.Add(Me.tbSettingsSpclPosition1)
        Me.gbSettingsPosition.Location = New System.Drawing.Point(362, 19)
        Me.gbSettingsPosition.Name = "gbSettingsPosition"
        Me.gbSettingsPosition.Size = New System.Drawing.Size(239, 209)
        Me.gbSettingsPosition.TabIndex = 1
        Me.gbSettingsPosition.TabStop = False
        Me.gbSettingsPosition.Text = "Position"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(135, 47)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "GoTo Spcl Posn 2"
        '
        'tbSettingsSpclPosition2
        '
        Me.tbSettingsSpclPosition2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition2", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsSpclPosition2.Location = New System.Drawing.Point(12, 44)
        Me.tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2"
        Me.tbSettingsSpclPosition2.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsSpclPosition2.TabIndex = 11
        Me.tbSettingsSpclPosition2.Text = Global.GrblPanel.My.MySettings.Default.MachineSpclPosition2
        '
        'btnSettingsRefreshPosition
        '
        Me.btnSettingsRefreshPosition.Location = New System.Drawing.Point(-2, 182)
        Me.btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition"
        Me.btnSettingsRefreshPosition.Size = New System.Drawing.Size(75, 23)
        Me.btnSettingsRefreshPosition.TabIndex = 10
        Me.btnSettingsRefreshPosition.Tag = "Position"
        Me.btnSettingsRefreshPosition.Text = "Refresh"
        Me.btnSettingsRefreshPosition.UseVisualStyleBackColor = True
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(135, 150)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(75, 13)
        Me.Label29.TabIndex = 9
        Me.Label29.Text = "Work Z 0 cmd"
        '
        'tbWorkZ0Cmd
        '
        Me.tbWorkZ0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkZ0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbWorkZ0Cmd.Location = New System.Drawing.Point(12, 147)
        Me.tbWorkZ0Cmd.Name = "tbWorkZ0Cmd"
        Me.tbWorkZ0Cmd.Size = New System.Drawing.Size(117, 20)
        Me.tbWorkZ0Cmd.TabIndex = 8
        Me.tbWorkZ0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkZ0Cmd
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(135, 124)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(75, 13)
        Me.Label28.TabIndex = 7
        Me.Label28.Text = "Work Y 0 cmd"
        '
        'tbWorkY0Cmd
        '
        Me.tbWorkY0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkY0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbWorkY0Cmd.Location = New System.Drawing.Point(12, 121)
        Me.tbWorkY0Cmd.Name = "tbWorkY0Cmd"
        Me.tbWorkY0Cmd.Size = New System.Drawing.Size(117, 20)
        Me.tbWorkY0Cmd.TabIndex = 6
        Me.tbWorkY0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkY0Cmd
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(135, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Work X 0 cmd"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(135, 73)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Zero All Cmd"
        '
        'tbWorkX0Cmd
        '
        Me.tbWorkX0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkX0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbWorkX0Cmd.Location = New System.Drawing.Point(12, 96)
        Me.tbWorkX0Cmd.Name = "tbWorkX0Cmd"
        Me.tbWorkX0Cmd.Size = New System.Drawing.Size(117, 20)
        Me.tbWorkX0Cmd.TabIndex = 3
        Me.tbWorkX0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkX0Cmd
        '
        'tbSettingsZeroXYZCmd
        '
        Me.tbSettingsZeroXYZCmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "Work0Cmd", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsZeroXYZCmd.Location = New System.Drawing.Point(12, 70)
        Me.tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd"
        Me.tbSettingsZeroXYZCmd.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsZeroXYZCmd.TabIndex = 2
        Me.tbSettingsZeroXYZCmd.Text = Global.GrblPanel.My.MySettings.Default.Work0Cmd
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(135, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(94, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "Go To Spcl Posn1"
        Me.ToolTip1.SetToolTip(Me.Label11, "Also known as Soft Home")
        '
        'tbSettingsSpclPosition1
        '
        Me.tbSettingsSpclPosition1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition1", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsSpclPosition1.Location = New System.Drawing.Point(12, 18)
        Me.tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1"
        Me.tbSettingsSpclPosition1.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsSpclPosition1.TabIndex = 0
        Me.tbSettingsSpclPosition1.Text = Global.GrblPanel.My.MySettings.Default.MachineSpclPosition1
        '
        'gbSettingsJogging
        '
        Me.gbSettingsJogging.Controls.Add(Me.cbSettingsKeyboardJogging)
        Me.gbSettingsJogging.Controls.Add(Me.btnSettingsRefreshJogging)
        Me.gbSettingsJogging.Controls.Add(Me.Label41)
        Me.gbSettingsJogging.Controls.Add(Me.Label40)
        Me.gbSettingsJogging.Controls.Add(Me.Label39)
        Me.gbSettingsJogging.Controls.Add(Me.Label38)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsZRepeat)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsYRepeat)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsXRepeat)
        Me.gbSettingsJogging.Controls.Add(Me.Label35)
        Me.gbSettingsJogging.Controls.Add(Me.Label34)
        Me.gbSettingsJogging.Controls.Add(Me.Label32)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFRMetric)
        Me.gbSettingsJogging.Controls.Add(Me.Label33)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFIMetric)
        Me.gbSettingsJogging.Controls.Add(Me.Label31)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFRImperial)
        Me.gbSettingsJogging.Controls.Add(Me.Label30)
        Me.gbSettingsJogging.Controls.Add(Me.cbSettingsMetric)
        Me.gbSettingsJogging.Controls.Add(Me.tbSettingsFIImperial)
        Me.gbSettingsJogging.Location = New System.Drawing.Point(607, 19)
        Me.gbSettingsJogging.Name = "gbSettingsJogging"
        Me.gbSettingsJogging.Size = New System.Drawing.Size(220, 324)
        Me.gbSettingsJogging.TabIndex = 0
        Me.gbSettingsJogging.TabStop = False
        Me.gbSettingsJogging.Text = "Jogging"
        '
        'cbSettingsKeyboardJogging
        '
        Me.cbSettingsKeyboardJogging.AutoSize = True
        Me.cbSettingsKeyboardJogging.Checked = Global.GrblPanel.My.MySettings.Default.JoggingUseKeyboard
        Me.cbSettingsKeyboardJogging.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "JoggingUseKeyboard", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsKeyboardJogging.Location = New System.Drawing.Point(6, 267)
        Me.cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging"
        Me.cbSettingsKeyboardJogging.Size = New System.Drawing.Size(140, 17)
        Me.cbSettingsKeyboardJogging.TabIndex = 27
        Me.cbSettingsKeyboardJogging.Text = "Enable keyboard arrows"
        Me.ToolTip1.SetToolTip(Me.cbSettingsKeyboardJogging, "Allow arrows, pg up, pg dn to do jogging")
        Me.cbSettingsKeyboardJogging.UseVisualStyleBackColor = True
        '
        'btnSettingsRefreshJogging
        '
        Me.btnSettingsRefreshJogging.Location = New System.Drawing.Point(0, 301)
        Me.btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging"
        Me.btnSettingsRefreshJogging.Size = New System.Drawing.Size(75, 23)
        Me.btnSettingsRefreshJogging.TabIndex = 11
        Me.btnSettingsRefreshJogging.Tag = "Jogging"
        Me.btnSettingsRefreshJogging.Text = "Refresh"
        Me.btnSettingsRefreshJogging.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(48, 167)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(158, 13)
        Me.Label41.TabIndex = 26
        Me.Label41.Text = "Button Repeat Rate, r/sec"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Location = New System.Drawing.Point(129, 244)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(78, 13)
        Me.Label40.TabIndex = 25
        Me.Label40.Text = "Z Repeat Rate"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(129, 218)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(78, 13)
        Me.Label39.TabIndex = 24
        Me.Label39.Text = "Y Repeat Rate"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(129, 192)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(78, 13)
        Me.Label38.TabIndex = 23
        Me.Label38.Text = "X Repeat Rate"
        '
        'tbSettingsZRepeat
        '
        Me.tbSettingsZRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingZRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsZRepeat.Location = New System.Drawing.Point(6, 241)
        Me.tbSettingsZRepeat.Name = "tbSettingsZRepeat"
        Me.tbSettingsZRepeat.Size = New System.Drawing.Size(45, 20)
        Me.tbSettingsZRepeat.TabIndex = 22
        Me.tbSettingsZRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingZRepeat
        '
        'tbSettingsYRepeat
        '
        Me.tbSettingsYRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingYRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsYRepeat.Location = New System.Drawing.Point(6, 215)
        Me.tbSettingsYRepeat.Name = "tbSettingsYRepeat"
        Me.tbSettingsYRepeat.Size = New System.Drawing.Size(45, 20)
        Me.tbSettingsYRepeat.TabIndex = 21
        Me.tbSettingsYRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingYRepeat
        '
        'tbSettingsXRepeat
        '
        Me.tbSettingsXRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingXRepeat", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsXRepeat.Location = New System.Drawing.Point(6, 189)
        Me.tbSettingsXRepeat.Name = "tbSettingsXRepeat"
        Me.tbSettingsXRepeat.Size = New System.Drawing.Size(45, 20)
        Me.tbSettingsXRepeat.TabIndex = 20
        Me.tbSettingsXRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingXRepeat
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(136, 104)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(42, 13)
        Me.Label35.TabIndex = 19
        Me.Label35.Text = "Metric"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(136, 38)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(51, 13)
        Me.Label34.TabIndex = 18
        Me.Label34.Text = "Imperial"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(129, 146)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(62, 13)
        Me.Label32.TabIndex = 17
        Me.Label32.Text = "Feed Rates"
        '
        'tbSettingsFRMetric
        '
        Me.tbSettingsFRMetric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFRMetric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsFRMetric.Location = New System.Drawing.Point(6, 143)
        Me.tbSettingsFRMetric.Name = "tbSettingsFRMetric"
        Me.tbSettingsFRMetric.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsFRMetric.TabIndex = 16
        Me.tbSettingsFRMetric.Text = Global.GrblPanel.My.MySettings.Default.JoggingFRMetric
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(129, 120)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(86, 13)
        Me.Label33.TabIndex = 15
        Me.Label33.Text = "Feed Increments"
        '
        'tbSettingsFIMetric
        '
        Me.tbSettingsFIMetric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFIMEtric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsFIMetric.Location = New System.Drawing.Point(6, 117)
        Me.tbSettingsFIMetric.Name = "tbSettingsFIMetric"
        Me.tbSettingsFIMetric.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsFIMetric.TabIndex = 14
        Me.tbSettingsFIMetric.Text = Global.GrblPanel.My.MySettings.Default.JoggingFIMEtric
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(129, 85)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(62, 13)
        Me.Label31.TabIndex = 13
        Me.Label31.Text = "Feed Rates"
        '
        'tbSettingsFRImperial
        '
        Me.tbSettingsFRImperial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFRImperial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsFRImperial.Location = New System.Drawing.Point(6, 82)
        Me.tbSettingsFRImperial.Name = "tbSettingsFRImperial"
        Me.tbSettingsFRImperial.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsFRImperial.TabIndex = 12
        Me.tbSettingsFRImperial.Text = Global.GrblPanel.My.MySettings.Default.JoggingFRImperial
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(129, 59)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(86, 13)
        Me.Label30.TabIndex = 11
        Me.Label30.Text = "Feed Increments"
        '
        'cbSettingsMetric
        '
        Me.cbSettingsMetric.AutoSize = True
        Me.cbSettingsMetric.Checked = Global.GrblPanel.My.MySettings.Default.JoggingUnitsMetric
        Me.cbSettingsMetric.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "joggingUnitsMetric", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsMetric.Location = New System.Drawing.Point(3, 21)
        Me.cbSettingsMetric.Name = "cbSettingsMetric"
        Me.cbSettingsMetric.Size = New System.Drawing.Size(55, 17)
        Me.cbSettingsMetric.TabIndex = 0
        Me.cbSettingsMetric.Text = "Metric"
        Me.cbSettingsMetric.UseVisualStyleBackColor = True
        '
        'tbSettingsFIImperial
        '
        Me.tbSettingsFIImperial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFIImperial", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.tbSettingsFIImperial.Location = New System.Drawing.Point(6, 56)
        Me.tbSettingsFIImperial.Name = "tbSettingsFIImperial"
        Me.tbSettingsFIImperial.Size = New System.Drawing.Size(117, 20)
        Me.tbSettingsFIImperial.TabIndex = 10
        Me.tbSettingsFIImperial.Text = Global.GrblPanel.My.MySettings.Default.JoggingFIImperial
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbEditor)
        Me.TabPage1.Controls.Add(Me.btnCancel)
        Me.TabPage1.Controls.Add(Me.btnOK)
        Me.TabPage1.Controls.Add(Me.dgMacros)
        Me.TabPage1.Controls.Add(Me.lblStatusLabel)
        Me.TabPage1.Controls.Add(Me.btnDeleteMacro)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(1134, 677)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Macros"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbEditor
        '
        Me.gbEditor.Controls.Add(Me.btnAdd)
        Me.gbEditor.Controls.Add(Me.lblGCode)
        Me.gbEditor.Controls.Add(Me.tbGCode)
        Me.gbEditor.Controls.Add(Me.lblName)
        Me.gbEditor.Controls.Add(Me.tbName)
        Me.gbEditor.Location = New System.Drawing.Point(6, 147)
        Me.gbEditor.Name = "gbEditor"
        Me.gbEditor.Size = New System.Drawing.Size(246, 111)
        Me.gbEditor.TabIndex = 8
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
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(177, 32)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(177, 3)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
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
        Me.dgMacros.Location = New System.Drawing.Point(18, 3)
        Me.dgMacros.Name = "dgMacros"
        Me.dgMacros.ReadOnly = True
        Me.dgMacros.RowHeadersVisible = False
        Me.dgMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMacros.ScrollBars = System.Windows.Forms.ScrollBars.None
        Me.dgMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgMacros.Size = New System.Drawing.Size(148, 134)
        Me.dgMacros.TabIndex = 11
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
        'lblStatusLabel
        '
        Me.lblStatusLabel.Location = New System.Drawing.Point(9, 263)
        Me.lblStatusLabel.Name = "lblStatusLabel"
        Me.lblStatusLabel.Size = New System.Drawing.Size(242, 23)
        Me.lblStatusLabel.TabIndex = 13
        '
        'btnDeleteMacro
        '
        Me.btnDeleteMacro.Location = New System.Drawing.Point(177, 102)
        Me.btnDeleteMacro.Name = "btnDeleteMacro"
        Me.btnDeleteMacro.Size = New System.Drawing.Size(74, 34)
        Me.btnDeleteMacro.TabIndex = 12
        Me.btnDeleteMacro.Text = "Delete Selected"
        Me.btnDeleteMacro.UseVisualStyleBackColor = True
        '
        'ofdGcodeFile
        '
        Me.ofdGcodeFile.DefaultExt = "ngc"
        Me.ofdGcodeFile.FileName = "*.*"
        Me.ofdGcodeFile.Filter = "All files (*.*)|*.*"
        '
        'sfdOffsets
        '
        Me.sfdOffsets.DefaultExt = "xml"
        Me.sfdOffsets.Filter = "WorkOffset Files|*.xml"
        '
        'ofdOffsets
        '
        Me.ofdOffsets.DefaultExt = "xml"
        Me.ofdOffsets.FileName = "OpenFileDialog1"
        Me.ofdOffsets.Filter = "WorkOffset Files|*.xml"
        '
        'GrblGui
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1143, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "GrblGui"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.Text = "Grbl Panel"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tabPgInterface.ResumeLayout(False)
        Me.gbState.ResumeLayout(False)
        Me.gbState.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.gbControl.ResumeLayout(False)
        Me.gbControl.PerformLayout()
        Me.gbMDI.ResumeLayout(False)
        Me.gbMDI.PerformLayout()
        Me.gbJogging.ResumeLayout(False)
        Me.gbJogging.PerformLayout()
        Me.gbFeedRate.ResumeLayout(False)
        Me.gbFeedRate.PerformLayout()
        Me.gbDistance.ResumeLayout(False)
        Me.gbDistance.PerformLayout()
        Me.gbStatus.ResumeLayout(False)
        Me.gbStatus.PerformLayout()
        Me.gbGcode.ResumeLayout(False)
        Me.gbGcode.PerformLayout()
        Me.gbGrbl.ResumeLayout(False)
        Me.tcConnection.ResumeLayout(False)
        Me.tbGrblCOM.ResumeLayout(False)
        Me.tbGrblIP.ResumeLayout(False)
        Me.tbGrblIP.PerformLayout()
        Me.gbPosition.ResumeLayout(False)
        Me.tabCtlPosition.ResumeLayout(False)
        Me.tpWork.ResumeLayout(False)
        Me.tpWork.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tpOffsets.ResumeLayout(False)
        Me.tpOffsets.PerformLayout()
        Me.tabPgSettings.ResumeLayout(False)
        Me.tabPgSettings.PerformLayout()
        Me.gbGrblSettings.ResumeLayout(False)
        Me.gbGrblSettings.PerformLayout()
        CType(Me.dgGrblSettings, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbSettingsOffsets.ResumeLayout(False)
        Me.gbSettingsOffsets.PerformLayout()
        Me.gbSettingsMisc.ResumeLayout(False)
        Me.gbSettingsMisc.PerformLayout()
        Me.gbSettingsPosition.ResumeLayout(False)
        Me.gbSettingsPosition.PerformLayout()
        Me.gbSettingsJogging.ResumeLayout(False)
        Me.gbSettingsJogging.PerformLayout()
        Me.TabPage1.ResumeLayout(False)
        Me.gbEditor.ResumeLayout(False)
        Me.gbEditor.PerformLayout()
        CType(Me.dgMacros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrblSettingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SaveToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tabPgInterface As System.Windows.Forms.TabPage
    Friend WithEvents gbJogging As System.Windows.Forms.GroupBox
    Friend WithEvents rbFeedRate4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeedRate3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeedRate1 As System.Windows.Forms.RadioButton
    Friend WithEvents rbFeedRate2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance4 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance3 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance2 As System.Windows.Forms.RadioButton
    Friend WithEvents rbDistance1 As System.Windows.Forms.RadioButton
    Friend WithEvents tabPgSettings As System.Windows.Forms.TabPage
    Friend WithEvents gbPosition As System.Windows.Forms.GroupBox
    Friend WithEvents gbGrbl As System.Windows.Forms.GroupBox
    Friend WithEvents btnConnect As System.Windows.Forms.Button
    Friend WithEvents cbPorts As System.Windows.Forms.ComboBox
    Friend WithEvents cbBaud As System.Windows.Forms.ComboBox
    Friend WithEvents lbResponses As System.Windows.Forms.ListBox
    Friend WithEvents btnSend As System.Windows.Forms.Button
    Friend WithEvents tbSendData As System.Windows.Forms.TextBox
    Friend WithEvents tbMachX As System.Windows.Forms.TextBox
    Friend WithEvents tbMachY As System.Windows.Forms.TextBox
    Friend WithEvents tbMachZ As System.Windows.Forms.TextBox
    Friend WithEvents tbWorkZ As System.Windows.Forms.TextBox
    Friend WithEvents tbWorkY As System.Windows.Forms.TextBox
    Friend WithEvents btnWorkZ0 As System.Windows.Forms.Button
    Friend WithEvents btnWorkY0 As System.Windows.Forms.Button
    Friend WithEvents btnWorkX0 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnHome As System.Windows.Forms.Button
    Friend WithEvents btnWork0 As System.Windows.Forms.Button
    Public WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents cbVerbose As System.Windows.Forms.CheckBox
    Friend WithEvents cbUnits As System.Windows.Forms.CheckBox
    Friend WithEvents gbFeedRate As System.Windows.Forms.GroupBox
    Friend WithEvents gbDistance As System.Windows.Forms.GroupBox
    Friend WithEvents gbSettingsJogging As System.Windows.Forms.GroupBox
    Friend WithEvents cbSettingsMetric As System.Windows.Forms.CheckBox
    Friend WithEvents btnFileSend As System.Windows.Forms.Button
    Friend WithEvents btnFileSelect As System.Windows.Forms.Button
    Friend WithEvents btnFilePause As System.Windows.Forms.Button
    Friend WithEvents btnFileStop As System.Windows.Forms.Button
    Private WithEvents ofdGcodeFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tbGcodeFile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents gbSettingsPosition As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbWorkX0Cmd As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsZeroXYZCmd As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsSpclPosition1 As System.Windows.Forms.TextBox
    Public WithEvents btnUnlock As System.Windows.Forms.Button
    Friend WithEvents gbGcode As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalLines As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents cbStatusPollEnable As System.Windows.Forms.CheckBox
    Friend WithEvents lvGcode As System.Windows.Forms.ListView
    Friend WithEvents lvColStatus As System.Windows.Forms.ColumnHeader
    Friend WithEvents lvColGCode As System.Windows.Forms.ColumnHeader
    Friend WithEvents prgBarQ As System.Windows.Forms.ProgressBar
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents prgbRxBuf As System.Windows.Forms.ProgressBar
    Friend WithEvents gbSettingsMisc As System.Windows.Forms.GroupBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsPollRate As System.Windows.Forms.TextBox
    Friend WithEvents tbGCodeMessage As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents tbWorkZ0Cmd As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents tbWorkY0Cmd As System.Windows.Forms.TextBox
    Public WithEvents btnHold As System.Windows.Forms.Button
    Public WithEvents btnStartResume As System.Windows.Forms.Button
    Friend WithEvents btnRescanPorts As System.Windows.Forms.Button
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFRMetric As System.Windows.Forms.TextBox
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFIMetric As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFRImperial As System.Windows.Forms.TextBox
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsFIImperial As System.Windows.Forms.TextBox
    Friend WithEvents Label37 As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsRBuffSize As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsQSize As System.Windows.Forms.TextBox
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsZRepeat As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsYRepeat As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsXRepeat As System.Windows.Forms.TextBox
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents btnSettingsRefreshMisc As System.Windows.Forms.Button
    Friend WithEvents btnSettingsRefreshPosition As System.Windows.Forms.Button
    Friend WithEvents btnSettingsRefreshJogging As System.Windows.Forms.Button
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents cbSettingsPauseOnError As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnSettingsGrbl As System.Windows.Forms.Button
    Friend WithEvents dgGrblSettings As System.Windows.Forms.DataGridView
    Friend WithEvents btnOffsetsSave As System.Windows.Forms.Button
    Friend WithEvents btnOffsetsRetrieve As System.Windows.Forms.Button
    Friend WithEvents btnOffsetsLoad As System.Windows.Forms.Button
    Friend WithEvents btnOffsetsG43Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG43Z As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents btnOffsetsG30Set As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG30Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG30Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG30X As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG28Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG28Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG28X As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents btnOffsetsG55Zero As System.Windows.Forms.Button
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents tbOffsetsG55Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG55Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG55X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG56Zero As System.Windows.Forms.Button
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents tbOffsetsG56Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG56Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG56X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG57Zero As System.Windows.Forms.Button
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents tbOffsetsG57Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG57Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG57X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG58Zero As System.Windows.Forms.Button
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents tbOffsetsG58Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG58Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG58X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG59Zero As System.Windows.Forms.Button
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents tbOffsetsG59Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG59Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG59X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG54Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG54Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG54Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG54X As System.Windows.Forms.TextBox
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents tbOffSetsMachZ As System.Windows.Forms.TextBox
    Friend WithEvents tbOffSetsMachY As System.Windows.Forms.TextBox
    Friend WithEvents tbOffSetsMachX As System.Windows.Forms.TextBox
    Friend WithEvents sfdOffsets As System.Windows.Forms.SaveFileDialog
    Friend WithEvents ofdOffsets As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tabCtlPosition As System.Windows.Forms.TabControl
    Friend WithEvents tpWork As System.Windows.Forms.TabPage
    Friend WithEvents tpOffsets As System.Windows.Forms.TabPage
    Friend WithEvents gbMDI As System.Windows.Forms.GroupBox
    Friend WithEvents gbControl As System.Windows.Forms.GroupBox
    Friend WithEvents tbCurrentStatus As System.Windows.Forms.TextBox
    Friend WithEvents btnZMinus As RepeatButton.RepeatButton
    Friend WithEvents btnZPlus As RepeatButton.RepeatButton
    Friend WithEvents btnXPlus As RepeatButton.RepeatButton
    Friend WithEvents btnYMinus As RepeatButton.RepeatButton
    Friend WithEvents btnXMinus As RepeatButton.RepeatButton
    Friend WithEvents btnYPlus As RepeatButton.RepeatButton
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents cbSettingsConnectOnLoad As System.Windows.Forms.CheckBox
    Friend WithEvents btnStatusGetParser As System.Windows.Forms.Button
    Friend WithEvents gbSettingsOffsets As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tbWorkX As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsSpclPosition2 As System.Windows.Forms.TextBox
    Friend WithEvents cbSettingsKeyboardJogging As System.Windows.Forms.CheckBox
    Public WithEvents btnCheckMode As System.Windows.Forms.Button
    Friend WithEvents btnSettingsRetrieveLocations As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbSettingsLeftHanded As System.Windows.Forms.CheckBox
    Private WithEvents btnWorkSoftHome As System.Windows.Forms.Button
    Friend WithEvents btnWorkSpclPosition As System.Windows.Forms.Button
    Friend WithEvents gbState As System.Windows.Forms.GroupBox
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Lalbel49 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cbxStateUnits As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateDistance As System.Windows.Forms.ComboBox
    Friend WithEvents tbStateFeedRate As System.Windows.Forms.TextBox
    Friend WithEvents cbxStateFeedMode As System.Windows.Forms.ComboBox
    Friend WithEvents tbStateTool As System.Windows.Forms.TextBox
    Friend WithEvents tbStateSpindleRPM As System.Windows.Forms.TextBox
    Friend WithEvents cbxStatePlane As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateCoolant As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateSpindle As System.Windows.Forms.ComboBox
    Friend WithEvents cbxStateOffset As System.Windows.Forms.ComboBox
    Friend WithEvents btnOffsetsG28Set As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblPositionCurrentOffset As System.Windows.Forms.Label
    Friend WithEvents gbGrblSettings As System.Windows.Forms.GroupBox
    Friend WithEvents GrblSettingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents gbStatus As System.Windows.Forms.GroupBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents lvColLineNo As System.Windows.Forms.ColumnHeader
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsGrblLastParam As System.Windows.Forms.TextBox
    Friend WithEvents btnFileReload As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbSettingsStartupDelay As System.Windows.Forms.TextBox
    Friend WithEvents tbSettingsDefaultExt As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tcConnection As System.Windows.Forms.TabControl
    Friend WithEvents tbGrblCOM As System.Windows.Forms.TabPage
    Friend WithEvents tbGrblIP As System.Windows.Forms.TabPage
    Friend WithEvents btnIPConnect As System.Windows.Forms.Button
    Friend WithEvents tbIPAddress As System.Windows.Forms.TextBox
    Friend WithEvents TabPage1 As TabPage
    Public WithEvents gbEditor As GroupBox
    Private WithEvents btnAdd As Button
    Private WithEvents lblGCode As Label
    Public WithEvents tbGCode As TextBox
    Private WithEvents lblName As Label
    Public WithEvents tbName As TextBox
    Private WithEvents btnCancel As Button
    Private WithEvents btnOK As Button
    Private WithEvents dgMacros As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Private WithEvents lblStatusLabel As Label
    Private WithEvents btnDeleteMacro As Button
End Class
