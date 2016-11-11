<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class GrblGui
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.gbOverrides = New System.Windows.Forms.GroupBox()
        Me.btnMistOverride = New System.Windows.Forms.Button()
        Me.btnFloodOverride = New System.Windows.Forms.Button()
        Me.btnSpindleOverride = New System.Windows.Forms.Button()
        Me.cbSpindleCoarse = New System.Windows.Forms.CheckBox()
        Me.btnSpindleOverrideReset = New System.Windows.Forms.Button()
        Me.btnRapidOverrideReset = New System.Windows.Forms.Button()
        Me.btnFeedOverrideReset = New System.Windows.Forms.Button()
        Me.cbFeedCoarse = New System.Windows.Forms.CheckBox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.btnSpindleMinus = New System.Windows.Forms.Button()
        Me.btnSpindlePlus = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnRapidMinus = New System.Windows.Forms.Button()
        Me.btnRapidPlus = New System.Windows.Forms.Button()
        Me.tbSpindleOvr = New System.Windows.Forms.TextBox()
        Me.tbRapidOvr = New System.Windows.Forms.TextBox()
        Me.tbFeedOvr = New System.Windows.Forms.TextBox()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.btnFeedMinus = New System.Windows.Forms.Button()
        Me.btnFeedPlus = New System.Windows.Forms.Button()
        Me.gbState = New System.Windows.Forms.GroupBox()
        Me.gbPinStatus = New System.Windows.Forms.GroupBox()
        Me.cbFeedHold = New System.Windows.Forms.CheckBox()
        Me.cbStartResume = New System.Windows.Forms.CheckBox()
        Me.cbResetAbort = New System.Windows.Forms.CheckBox()
        Me.btnStatusClearPins = New System.Windows.Forms.Button()
        Me.cbLimitX = New System.Windows.Forms.CheckBox()
        Me.cbDoorOpen = New System.Windows.Forms.CheckBox()
        Me.cbProbePin = New System.Windows.Forms.CheckBox()
        Me.cbLimitZ = New System.Windows.Forms.CheckBox()
        Me.cbLimitY = New System.Windows.Forms.CheckBox()
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
        Me.cbMonitorEnable = New System.Windows.Forms.CheckBox()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lblCurrentLine = New System.Windows.Forms.Label()
        Me.dgvGcode = New System.Windows.Forms.DataGridView()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineNum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnFileReload = New System.Windows.Forms.Button()
        Me.tbGCodeMessage = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.lblTotalLines = New System.Windows.Forms.Label()
        Me.btnFilePause = New System.Windows.Forms.Button()
        Me.tbGcodeFile = New System.Windows.Forms.TextBox()
        Me.btnFileSelect = New System.Windows.Forms.Button()
        Me.btnFileSend = New System.Windows.Forms.Button()
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
        Me.btnSetOffsetG59 = New System.Windows.Forms.Button()
        Me.btnSetOffsetG58 = New System.Windows.Forms.Button()
        Me.btnSetOffsetG57 = New System.Windows.Forms.Button()
        Me.btnSetOffsetG56 = New System.Windows.Forms.Button()
        Me.btnSetOffsetG55 = New System.Windows.Forms.Button()
        Me.btnSetOffsetG54 = New System.Windows.Forms.Button()
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
        Me.tbOffsetsG54X = New System.Windows.Forms.TextBox()
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
        Me.tbOffsetsG59Y = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG43Z = New System.Windows.Forms.TextBox()
        Me.btnOffsetsG55Zero = New System.Windows.Forms.Button()
        Me.tbOffsetsG59Z = New System.Windows.Forms.TextBox()
        Me.tbOffsetsG58Z = New System.Windows.Forms.TextBox()
        Me.Label60 = New System.Windows.Forms.Label()
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
        Me.MenuStrip1.SuspendLayout
        Me.TabControl1.SuspendLayout
        Me.tabPgInterface.SuspendLayout
        Me.gbOverrides.SuspendLayout
        Me.gbState.SuspendLayout
        Me.gbPinStatus.SuspendLayout
        Me.Panel2.SuspendLayout
        Me.Panel1.SuspendLayout
        Me.gbControl.SuspendLayout
        Me.gbMDI.SuspendLayout
        Me.gbJogging.SuspendLayout
        Me.gbFeedRate.SuspendLayout
        Me.gbDistance.SuspendLayout
        Me.gbStatus.SuspendLayout
        Me.gbGcode.SuspendLayout
        CType(Me.dgvGcode,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbGrbl.SuspendLayout
        Me.tcConnection.SuspendLayout
        Me.tbGrblCOM.SuspendLayout
        Me.tbGrblIP.SuspendLayout
        Me.gbPosition.SuspendLayout
        Me.tabCtlPosition.SuspendLayout
        Me.tpWork.SuspendLayout
        Me.Panel5.SuspendLayout
        Me.Panel4.SuspendLayout
        Me.Panel3.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.tpOffsets.SuspendLayout
        Me.tabPgSettings.SuspendLayout
        Me.gbGrblSettings.SuspendLayout
        CType(Me.dgGrblSettings,System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbSettingsOffsets.SuspendLayout
        Me.gbSettingsMisc.SuspendLayout
        Me.gbSettingsPosition.SuspendLayout
        Me.gbSettingsJogging.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.gbEditor.SuspendLayout
        CType(Me.dgMacros,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.GrblSettingsBindingSource,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'MenuStrip1
        '
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolsToolStripMenuItem, Me.HelpToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        resources.ApplyResources(Me.ToolStripMenuItem1, "ToolStripMenuItem1")
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        resources.ApplyResources(Me.SaveToolStripMenuItem, "SaveToolStripMenuItem")
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        resources.ApplyResources(Me.ExitToolStripMenuItem, "ExitToolStripMenuItem")
        '
        'ToolsToolStripMenuItem
        '
        Me.ToolsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OptionsToolStripMenuItem})
        Me.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem"
        resources.ApplyResources(Me.ToolsToolStripMenuItem, "ToolsToolStripMenuItem")
        '
        'OptionsToolStripMenuItem
        '
        Me.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem"
        resources.ApplyResources(Me.OptionsToolStripMenuItem, "OptionsToolStripMenuItem")
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        resources.ApplyResources(Me.HelpToolStripMenuItem, "HelpToolStripMenuItem")
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        resources.ApplyResources(Me.AboutToolStripMenuItem, "AboutToolStripMenuItem")
        '
        'TabControl1
        '
        resources.ApplyResources(Me.TabControl1, "TabControl1")
        Me.TabControl1.Controls.Add(Me.tabPgInterface)
        Me.TabControl1.Controls.Add(Me.tabPgSettings)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        '
        'tabPgInterface
        '
        Me.tabPgInterface.Controls.Add(Me.gbOverrides)
        Me.tabPgInterface.Controls.Add(Me.gbState)
        Me.tabPgInterface.Controls.Add(Me.gbControl)
        Me.tabPgInterface.Controls.Add(Me.gbMDI)
        Me.tabPgInterface.Controls.Add(Me.gbJogging)
        Me.tabPgInterface.Controls.Add(Me.gbStatus)
        Me.tabPgInterface.Controls.Add(Me.gbGcode)
        Me.tabPgInterface.Controls.Add(Me.gbGrbl)
        Me.tabPgInterface.Controls.Add(Me.gbPosition)
        resources.ApplyResources(Me.tabPgInterface, "tabPgInterface")
        Me.tabPgInterface.Name = "tabPgInterface"
        Me.tabPgInterface.UseVisualStyleBackColor = true
        '
        'gbOverrides
        '
        Me.gbOverrides.Controls.Add(Me.btnMistOverride)
        Me.gbOverrides.Controls.Add(Me.btnFloodOverride)
        Me.gbOverrides.Controls.Add(Me.btnSpindleOverride)
        Me.gbOverrides.Controls.Add(Me.cbSpindleCoarse)
        Me.gbOverrides.Controls.Add(Me.btnSpindleOverrideReset)
        Me.gbOverrides.Controls.Add(Me.btnRapidOverrideReset)
        Me.gbOverrides.Controls.Add(Me.btnFeedOverrideReset)
        Me.gbOverrides.Controls.Add(Me.cbFeedCoarse)
        Me.gbOverrides.Controls.Add(Me.Label44)
        Me.gbOverrides.Controls.Add(Me.btnSpindleMinus)
        Me.gbOverrides.Controls.Add(Me.btnSpindlePlus)
        Me.gbOverrides.Controls.Add(Me.Label22)
        Me.gbOverrides.Controls.Add(Me.btnRapidMinus)
        Me.gbOverrides.Controls.Add(Me.btnRapidPlus)
        Me.gbOverrides.Controls.Add(Me.tbSpindleOvr)
        Me.gbOverrides.Controls.Add(Me.tbRapidOvr)
        Me.gbOverrides.Controls.Add(Me.tbFeedOvr)
        Me.gbOverrides.Controls.Add(Me.Label46)
        Me.gbOverrides.Controls.Add(Me.btnFeedMinus)
        Me.gbOverrides.Controls.Add(Me.btnFeedPlus)
        resources.ApplyResources(Me.gbOverrides, "gbOverrides")
        Me.gbOverrides.Name = "gbOverrides"
        Me.gbOverrides.TabStop = false
        '
        'btnMistOverride
        '
        resources.ApplyResources(Me.btnMistOverride, "btnMistOverride")
        Me.btnMistOverride.Name = "btnMistOverride"
        Me.btnMistOverride.TabStop = false
        Me.btnMistOverride.Tag = "MistOverride"
        Me.btnMistOverride.UseVisualStyleBackColor = true
        '
        'btnFloodOverride
        '
        resources.ApplyResources(Me.btnFloodOverride, "btnFloodOverride")
        Me.btnFloodOverride.Name = "btnFloodOverride"
        Me.btnFloodOverride.Tag = "FloodOverride"
        Me.btnFloodOverride.UseVisualStyleBackColor = true
        '
        'btnSpindleOverride
        '
        resources.ApplyResources(Me.btnSpindleOverride, "btnSpindleOverride")
        Me.btnSpindleOverride.Name = "btnSpindleOverride"
        Me.btnSpindleOverride.Tag = "SpindleOverride"
        Me.btnSpindleOverride.UseVisualStyleBackColor = true
        '
        'cbSpindleCoarse
        '
        resources.ApplyResources(Me.cbSpindleCoarse, "cbSpindleCoarse")
        Me.cbSpindleCoarse.Checked = true
        Me.cbSpindleCoarse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSpindleCoarse.Name = "cbSpindleCoarse"
        Me.cbSpindleCoarse.UseVisualStyleBackColor = true
        '
        'btnSpindleOverrideReset
        '
        resources.ApplyResources(Me.btnSpindleOverrideReset, "btnSpindleOverrideReset")
        Me.btnSpindleOverrideReset.Name = "btnSpindleOverrideReset"
        Me.btnSpindleOverrideReset.Tag = "Spindle"
        Me.btnSpindleOverrideReset.UseVisualStyleBackColor = true
        '
        'btnRapidOverrideReset
        '
        resources.ApplyResources(Me.btnRapidOverrideReset, "btnRapidOverrideReset")
        Me.btnRapidOverrideReset.Name = "btnRapidOverrideReset"
        Me.btnRapidOverrideReset.Tag = "Rapid"
        Me.btnRapidOverrideReset.UseVisualStyleBackColor = true
        '
        'btnFeedOverrideReset
        '
        resources.ApplyResources(Me.btnFeedOverrideReset, "btnFeedOverrideReset")
        Me.btnFeedOverrideReset.Name = "btnFeedOverrideReset"
        Me.btnFeedOverrideReset.Tag = "Feed"
        Me.btnFeedOverrideReset.UseVisualStyleBackColor = true
        '
        'cbFeedCoarse
        '
        resources.ApplyResources(Me.cbFeedCoarse, "cbFeedCoarse")
        Me.cbFeedCoarse.Checked = true
        Me.cbFeedCoarse.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbFeedCoarse.Name = "cbFeedCoarse"
        Me.cbFeedCoarse.UseVisualStyleBackColor = true
        '
        'Label44
        '
        resources.ApplyResources(Me.Label44, "Label44")
        Me.Label44.Name = "Label44"
        '
        'btnSpindleMinus
        '
        resources.ApplyResources(Me.btnSpindleMinus, "btnSpindleMinus")
        Me.btnSpindleMinus.Name = "btnSpindleMinus"
        Me.btnSpindleMinus.Tag = "minus"
        Me.btnSpindleMinus.UseVisualStyleBackColor = true
        '
        'btnSpindlePlus
        '
        resources.ApplyResources(Me.btnSpindlePlus, "btnSpindlePlus")
        Me.btnSpindlePlus.Name = "btnSpindlePlus"
        Me.btnSpindlePlus.Tag = "plus"
        Me.btnSpindlePlus.UseVisualStyleBackColor = true
        '
        'Label22
        '
        resources.ApplyResources(Me.Label22, "Label22")
        Me.Label22.Name = "Label22"
        '
        'btnRapidMinus
        '
        resources.ApplyResources(Me.btnRapidMinus, "btnRapidMinus")
        Me.btnRapidMinus.Name = "btnRapidMinus"
        Me.btnRapidMinus.Tag = "minus"
        Me.btnRapidMinus.UseVisualStyleBackColor = true
        '
        'btnRapidPlus
        '
        resources.ApplyResources(Me.btnRapidPlus, "btnRapidPlus")
        Me.btnRapidPlus.Name = "btnRapidPlus"
        Me.btnRapidPlus.Tag = "plus"
        Me.btnRapidPlus.UseVisualStyleBackColor = true
        '
        'tbSpindleOvr
        '
        resources.ApplyResources(Me.tbSpindleOvr, "tbSpindleOvr")
        Me.tbSpindleOvr.Name = "tbSpindleOvr"
        '
        'tbRapidOvr
        '
        resources.ApplyResources(Me.tbRapidOvr, "tbRapidOvr")
        Me.tbRapidOvr.Name = "tbRapidOvr"
        '
        'tbFeedOvr
        '
        resources.ApplyResources(Me.tbFeedOvr, "tbFeedOvr")
        Me.tbFeedOvr.Name = "tbFeedOvr"
        '
        'Label46
        '
        resources.ApplyResources(Me.Label46, "Label46")
        Me.Label46.Name = "Label46"
        '
        'btnFeedMinus
        '
        resources.ApplyResources(Me.btnFeedMinus, "btnFeedMinus")
        Me.btnFeedMinus.Name = "btnFeedMinus"
        Me.btnFeedMinus.Tag = "minus"
        Me.btnFeedMinus.UseVisualStyleBackColor = true
        '
        'btnFeedPlus
        '
        resources.ApplyResources(Me.btnFeedPlus, "btnFeedPlus")
        Me.btnFeedPlus.Name = "btnFeedPlus"
        Me.btnFeedPlus.Tag = "plus"
        Me.btnFeedPlus.UseVisualStyleBackColor = true
        '
        'gbState
        '
        Me.gbState.Controls.Add(Me.gbPinStatus)
        Me.gbState.Controls.Add(Me.Panel2)
        Me.gbState.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.gbState, "gbState")
        Me.gbState.Name = "gbState"
        Me.gbState.TabStop = false
        '
        'gbPinStatus
        '
        Me.gbPinStatus.Controls.Add(Me.cbFeedHold)
        Me.gbPinStatus.Controls.Add(Me.cbStartResume)
        Me.gbPinStatus.Controls.Add(Me.cbResetAbort)
        Me.gbPinStatus.Controls.Add(Me.btnStatusClearPins)
        Me.gbPinStatus.Controls.Add(Me.cbLimitX)
        Me.gbPinStatus.Controls.Add(Me.cbDoorOpen)
        Me.gbPinStatus.Controls.Add(Me.cbProbePin)
        Me.gbPinStatus.Controls.Add(Me.cbLimitZ)
        Me.gbPinStatus.Controls.Add(Me.cbLimitY)
        resources.ApplyResources(Me.gbPinStatus, "gbPinStatus")
        Me.gbPinStatus.Name = "gbPinStatus"
        Me.gbPinStatus.TabStop = false
        '
        'cbFeedHold
        '
        Me.cbFeedHold.AutoCheck = false
        resources.ApplyResources(Me.cbFeedHold, "cbFeedHold")
        Me.cbFeedHold.Name = "cbFeedHold"
        Me.ToolTip1.SetToolTip(Me.cbFeedHold, resources.GetString("cbFeedHold.ToolTip"))
        Me.cbFeedHold.UseVisualStyleBackColor = true
        '
        'cbStartResume
        '
        Me.cbStartResume.AutoCheck = false
        resources.ApplyResources(Me.cbStartResume, "cbStartResume")
        Me.cbStartResume.Name = "cbStartResume"
        Me.ToolTip1.SetToolTip(Me.cbStartResume, resources.GetString("cbStartResume.ToolTip"))
        Me.cbStartResume.UseVisualStyleBackColor = true
        '
        'cbResetAbort
        '
        Me.cbResetAbort.AutoCheck = false
        resources.ApplyResources(Me.cbResetAbort, "cbResetAbort")
        Me.cbResetAbort.Name = "cbResetAbort"
        Me.ToolTip1.SetToolTip(Me.cbResetAbort, resources.GetString("cbResetAbort.ToolTip"))
        Me.cbResetAbort.UseVisualStyleBackColor = true
        '
        'btnStatusClearPins
        '
        resources.ApplyResources(Me.btnStatusClearPins, "btnStatusClearPins")
        Me.btnStatusClearPins.Name = "btnStatusClearPins"
        Me.btnStatusClearPins.UseVisualStyleBackColor = true
        '
        'cbLimitX
        '
        Me.cbLimitX.AutoCheck = false
        resources.ApplyResources(Me.cbLimitX, "cbLimitX")
        Me.cbLimitX.Name = "cbLimitX"
        Me.ToolTip1.SetToolTip(Me.cbLimitX, resources.GetString("cbLimitX.ToolTip"))
        Me.cbLimitX.UseVisualStyleBackColor = true
        '
        'cbDoorOpen
        '
        Me.cbDoorOpen.AutoCheck = false
        resources.ApplyResources(Me.cbDoorOpen, "cbDoorOpen")
        Me.cbDoorOpen.Name = "cbDoorOpen"
        Me.ToolTip1.SetToolTip(Me.cbDoorOpen, resources.GetString("cbDoorOpen.ToolTip"))
        Me.cbDoorOpen.UseVisualStyleBackColor = true
        '
        'cbProbePin
        '
        Me.cbProbePin.AutoCheck = false
        resources.ApplyResources(Me.cbProbePin, "cbProbePin")
        Me.cbProbePin.Name = "cbProbePin"
        Me.ToolTip1.SetToolTip(Me.cbProbePin, resources.GetString("cbProbePin.ToolTip"))
        Me.cbProbePin.UseVisualStyleBackColor = true
        '
        'cbLimitZ
        '
        Me.cbLimitZ.AutoCheck = false
        resources.ApplyResources(Me.cbLimitZ, "cbLimitZ")
        Me.cbLimitZ.Name = "cbLimitZ"
        Me.ToolTip1.SetToolTip(Me.cbLimitZ, resources.GetString("cbLimitZ.ToolTip"))
        Me.cbLimitZ.UseVisualStyleBackColor = true
        '
        'cbLimitY
        '
        Me.cbLimitY.AutoCheck = false
        resources.ApplyResources(Me.cbLimitY, "cbLimitY")
        Me.cbLimitY.Name = "cbLimitY"
        Me.ToolTip1.SetToolTip(Me.cbLimitY, resources.GetString("cbLimitY.ToolTip"))
        Me.cbLimitY.UseVisualStyleBackColor = true
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
        resources.ApplyResources(Me.Panel2, "Panel2")
        Me.Panel2.Name = "Panel2"
        '
        'tbStateFeedRate
        '
        resources.ApplyResources(Me.tbStateFeedRate, "tbStateFeedRate")
        Me.tbStateFeedRate.Name = "tbStateFeedRate"
        '
        'Label14
        '
        resources.ApplyResources(Me.Label14, "Label14")
        Me.Label14.Name = "Label14"
        '
        'tbStateTool
        '
        resources.ApplyResources(Me.tbStateTool, "tbStateTool")
        Me.tbStateTool.Name = "tbStateTool"
        '
        'Label53
        '
        resources.ApplyResources(Me.Label53, "Label53")
        Me.Label53.Name = "Label53"
        '
        'Label50
        '
        resources.ApplyResources(Me.Label50, "Label50")
        Me.Label50.Name = "Label50"
        '
        'tbStateSpindleRPM
        '
        resources.ApplyResources(Me.tbStateSpindleRPM, "tbStateSpindleRPM")
        Me.tbStateSpindleRPM.Name = "tbStateSpindleRPM"
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
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'cbxStateFeedMode
        '
        Me.cbxStateFeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateFeedMode.FormattingEnabled = true
        Me.cbxStateFeedMode.Items.AddRange(New Object() {resources.GetString("cbxStateFeedMode.Items"), resources.GetString("cbxStateFeedMode.Items1"), resources.GetString("cbxStateFeedMode.Items2")})
        resources.ApplyResources(Me.cbxStateFeedMode, "cbxStateFeedMode")
        Me.cbxStateFeedMode.Name = "cbxStateFeedMode"
        '
        'cbxStateDistance
        '
        Me.cbxStateDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateDistance.FormattingEnabled = true
        Me.cbxStateDistance.Items.AddRange(New Object() {resources.GetString("cbxStateDistance.Items"), resources.GetString("cbxStateDistance.Items1"), resources.GetString("cbxStateDistance.Items2")})
        resources.ApplyResources(Me.cbxStateDistance, "cbxStateDistance")
        Me.cbxStateDistance.Name = "cbxStateDistance"
        '
        'Label16
        '
        resources.ApplyResources(Me.Label16, "Label16")
        Me.Label16.Name = "Label16"
        '
        'cbxStateUnits
        '
        Me.cbxStateUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateUnits.FormattingEnabled = true
        Me.cbxStateUnits.Items.AddRange(New Object() {resources.GetString("cbxStateUnits.Items"), resources.GetString("cbxStateUnits.Items1"), resources.GetString("cbxStateUnits.Items2")})
        resources.ApplyResources(Me.cbxStateUnits, "cbxStateUnits")
        Me.cbxStateUnits.Name = "cbxStateUnits"
        '
        'Label123
        '
        resources.ApplyResources(Me.Label123, "Label123")
        Me.Label123.Name = "Label123"
        '
        'Lalbel49
        '
        resources.ApplyResources(Me.Lalbel49, "Lalbel49")
        Me.Lalbel49.Name = "Lalbel49"
        '
        'cbxStatePlane
        '
        Me.cbxStatePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStatePlane.FormattingEnabled = true
        Me.cbxStatePlane.Items.AddRange(New Object() {resources.GetString("cbxStatePlane.Items"), resources.GetString("cbxStatePlane.Items1"), resources.GetString("cbxStatePlane.Items2"), resources.GetString("cbxStatePlane.Items3")})
        resources.ApplyResources(Me.cbxStatePlane, "cbxStatePlane")
        Me.cbxStatePlane.Name = "cbxStatePlane"
        '
        'Label47
        '
        resources.ApplyResources(Me.Label47, "Label47")
        Me.Label47.Name = "Label47"
        '
        'Label15
        '
        resources.ApplyResources(Me.Label15, "Label15")
        Me.Label15.Name = "Label15"
        '
        'cbxStateOffset
        '
        Me.cbxStateOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateOffset.FormattingEnabled = true
        Me.cbxStateOffset.Items.AddRange(New Object() {resources.GetString("cbxStateOffset.Items"), resources.GetString("cbxStateOffset.Items1"), resources.GetString("cbxStateOffset.Items2"), resources.GetString("cbxStateOffset.Items3"), resources.GetString("cbxStateOffset.Items4"), resources.GetString("cbxStateOffset.Items5"), resources.GetString("cbxStateOffset.Items6")})
        resources.ApplyResources(Me.cbxStateOffset, "cbxStateOffset")
        Me.cbxStateOffset.Name = "cbxStateOffset"
        '
        'cbxStateCoolant
        '
        Me.cbxStateCoolant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateCoolant.FormattingEnabled = true
        Me.cbxStateCoolant.Items.AddRange(New Object() {resources.GetString("cbxStateCoolant.Items"), resources.GetString("cbxStateCoolant.Items1"), resources.GetString("cbxStateCoolant.Items2")})
        resources.ApplyResources(Me.cbxStateCoolant, "cbxStateCoolant")
        Me.cbxStateCoolant.Name = "cbxStateCoolant"
        '
        'Label45
        '
        resources.ApplyResources(Me.Label45, "Label45")
        Me.Label45.Name = "Label45"
        '
        'Label17
        '
        resources.ApplyResources(Me.Label17, "Label17")
        Me.Label17.Name = "Label17"
        '
        'cbxStateSpindle
        '
        Me.cbxStateSpindle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxStateSpindle.FormattingEnabled = true
        Me.cbxStateSpindle.Items.AddRange(New Object() {resources.GetString("cbxStateSpindle.Items"), resources.GetString("cbxStateSpindle.Items1"), resources.GetString("cbxStateSpindle.Items2"), resources.GetString("cbxStateSpindle.Items3")})
        resources.ApplyResources(Me.cbxStateSpindle, "cbxStateSpindle")
        Me.cbxStateSpindle.Name = "cbxStateSpindle"
        '
        'gbControl
        '
        Me.gbControl.Controls.Add(Me.btnCheckMode)
        Me.gbControl.Controls.Add(Me.btnReset)
        Me.gbControl.Controls.Add(Me.btnHold)
        Me.gbControl.Controls.Add(Me.btnStartResume)
        Me.gbControl.Controls.Add(Me.btnUnlock)
        resources.ApplyResources(Me.gbControl, "gbControl")
        Me.gbControl.Name = "gbControl"
        Me.gbControl.TabStop = false
        '
        'btnCheckMode
        '
        resources.ApplyResources(Me.btnCheckMode, "btnCheckMode")
        Me.btnCheckMode.Name = "btnCheckMode"
        Me.btnCheckMode.UseCompatibleTextRendering = true
        Me.btnCheckMode.UseVisualStyleBackColor = true
        '
        'btnReset
        '
        resources.ApplyResources(Me.btnReset, "btnReset")
        Me.btnReset.BackColor = System.Drawing.Color.Transparent
        Me.btnReset.Name = "btnReset"
        Me.btnReset.UseCompatibleTextRendering = true
        Me.btnReset.UseVisualStyleBackColor = false
        '
        'btnHold
        '
        resources.ApplyResources(Me.btnHold, "btnHold")
        Me.btnHold.BackColor = System.Drawing.Color.Transparent
        Me.btnHold.Name = "btnHold"
        Me.btnHold.UseCompatibleTextRendering = true
        Me.btnHold.UseVisualStyleBackColor = false
        '
        'btnStartResume
        '
        resources.ApplyResources(Me.btnStartResume, "btnStartResume")
        Me.btnStartResume.Name = "btnStartResume"
        Me.btnStartResume.UseCompatibleTextRendering = true
        Me.btnStartResume.UseVisualStyleBackColor = true
        '
        'btnUnlock
        '
        resources.ApplyResources(Me.btnUnlock, "btnUnlock")
        Me.btnUnlock.BackColor = System.Drawing.Color.Transparent
        Me.btnUnlock.Name = "btnUnlock"
        Me.btnUnlock.UseCompatibleTextRendering = true
        Me.btnUnlock.UseVisualStyleBackColor = false
        '
        'gbMDI
        '
        Me.gbMDI.Controls.Add(Me.Label9)
        Me.gbMDI.Controls.Add(Me.btnSend)
        Me.gbMDI.Controls.Add(Me.tbSendData)
        resources.ApplyResources(Me.gbMDI, "gbMDI")
        Me.gbMDI.Name = "gbMDI"
        Me.gbMDI.TabStop = false
        '
        'Label9
        '
        resources.ApplyResources(Me.Label9, "Label9")
        Me.Label9.Name = "Label9"
        '
        'btnSend
        '
        resources.ApplyResources(Me.btnSend, "btnSend")
        Me.btnSend.Name = "btnSend"
        Me.btnSend.UseVisualStyleBackColor = true
        '
        'tbSendData
        '
        Me.tbSendData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        resources.ApplyResources(Me.tbSendData, "tbSendData")
        Me.tbSendData.Name = "tbSendData"
        '
        'gbJogging
        '
        resources.ApplyResources(Me.gbJogging, "gbJogging")
        Me.gbJogging.Controls.Add(Me.btnZMinus)
        Me.gbJogging.Controls.Add(Me.btnZPlus)
        Me.gbJogging.Controls.Add(Me.btnXPlus)
        Me.gbJogging.Controls.Add(Me.btnYMinus)
        Me.gbJogging.Controls.Add(Me.btnXMinus)
        Me.gbJogging.Controls.Add(Me.btnYPlus)
        Me.gbJogging.Controls.Add(Me.gbFeedRate)
        Me.gbJogging.Controls.Add(Me.gbDistance)
        Me.gbJogging.Controls.Add(Me.cbUnits)
        Me.gbJogging.Name = "gbJogging"
        Me.gbJogging.TabStop = false
        '
        'btnZMinus
        '
        resources.ApplyResources(Me.btnZMinus, "btnZMinus")
        Me.btnZMinus.Interval = 100
        Me.btnZMinus.Name = "btnZMinus"
        Me.btnZMinus.Tag = "Z-"
        Me.btnZMinus.UseVisualStyleBackColor = true
        '
        'btnZPlus
        '
        resources.ApplyResources(Me.btnZPlus, "btnZPlus")
        Me.btnZPlus.Interval = 100
        Me.btnZPlus.Name = "btnZPlus"
        Me.btnZPlus.Tag = "Z+"
        Me.btnZPlus.UseVisualStyleBackColor = true
        '
        'btnXPlus
        '
        resources.ApplyResources(Me.btnXPlus, "btnXPlus")
        Me.btnXPlus.Interval = 100
        Me.btnXPlus.Name = "btnXPlus"
        Me.btnXPlus.Tag = "X+"
        Me.btnXPlus.UseVisualStyleBackColor = true
        '
        'btnYMinus
        '
        resources.ApplyResources(Me.btnYMinus, "btnYMinus")
        Me.btnYMinus.Interval = 100
        Me.btnYMinus.Name = "btnYMinus"
        Me.btnYMinus.Tag = "Y-"
        Me.btnYMinus.UseVisualStyleBackColor = true
        '
        'btnXMinus
        '
        resources.ApplyResources(Me.btnXMinus, "btnXMinus")
        Me.btnXMinus.Interval = 100
        Me.btnXMinus.Name = "btnXMinus"
        Me.btnXMinus.Tag = "X-"
        Me.btnXMinus.UseVisualStyleBackColor = true
        '
        'btnYPlus
        '
        resources.ApplyResources(Me.btnYPlus, "btnYPlus")
        Me.btnYPlus.Interval = 100
        Me.btnYPlus.Name = "btnYPlus"
        Me.btnYPlus.Tag = "Y+"
        Me.btnYPlus.UseVisualStyleBackColor = true
        '
        'gbFeedRate
        '
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate1)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate2)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate3)
        Me.gbFeedRate.Controls.Add(Me.rbFeedRate4)
        resources.ApplyResources(Me.gbFeedRate, "gbFeedRate")
        Me.gbFeedRate.Name = "gbFeedRate"
        Me.gbFeedRate.TabStop = false
        '
        'rbFeedRate1
        '
        resources.ApplyResources(Me.rbFeedRate1, "rbFeedRate1")
        Me.rbFeedRate1.Cursor = System.Windows.Forms.Cursors.Default
        Me.rbFeedRate1.Name = "rbFeedRate1"
        Me.rbFeedRate1.TabStop = true
        Me.rbFeedRate1.Tag = "F1"
        Me.rbFeedRate1.UseVisualStyleBackColor = true
        '
        'rbFeedRate2
        '
        resources.ApplyResources(Me.rbFeedRate2, "rbFeedRate2")
        Me.rbFeedRate2.Name = "rbFeedRate2"
        Me.rbFeedRate2.TabStop = true
        Me.rbFeedRate2.Tag = "F2"
        Me.rbFeedRate2.UseVisualStyleBackColor = true
        '
        'rbFeedRate3
        '
        resources.ApplyResources(Me.rbFeedRate3, "rbFeedRate3")
        Me.rbFeedRate3.Name = "rbFeedRate3"
        Me.rbFeedRate3.TabStop = true
        Me.rbFeedRate3.Tag = "F3"
        Me.rbFeedRate3.UseVisualStyleBackColor = true
        '
        'rbFeedRate4
        '
        resources.ApplyResources(Me.rbFeedRate4, "rbFeedRate4")
        Me.rbFeedRate4.Name = "rbFeedRate4"
        Me.rbFeedRate4.TabStop = true
        Me.rbFeedRate4.Tag = "F4"
        Me.rbFeedRate4.UseVisualStyleBackColor = true
        '
        'gbDistance
        '
        Me.gbDistance.Controls.Add(Me.rbDistance1)
        Me.gbDistance.Controls.Add(Me.rbDistance2)
        Me.gbDistance.Controls.Add(Me.rbDistance3)
        Me.gbDistance.Controls.Add(Me.rbDistance4)
        resources.ApplyResources(Me.gbDistance, "gbDistance")
        Me.gbDistance.Name = "gbDistance"
        Me.gbDistance.TabStop = false
        '
        'rbDistance1
        '
        resources.ApplyResources(Me.rbDistance1, "rbDistance1")
        Me.rbDistance1.Name = "rbDistance1"
        Me.rbDistance1.TabStop = true
        Me.rbDistance1.Tag = "I1"
        Me.rbDistance1.UseVisualStyleBackColor = true
        '
        'rbDistance2
        '
        resources.ApplyResources(Me.rbDistance2, "rbDistance2")
        Me.rbDistance2.Name = "rbDistance2"
        Me.rbDistance2.TabStop = true
        Me.rbDistance2.Tag = "I2"
        Me.rbDistance2.UseVisualStyleBackColor = true
        '
        'rbDistance3
        '
        resources.ApplyResources(Me.rbDistance3, "rbDistance3")
        Me.rbDistance3.Name = "rbDistance3"
        Me.rbDistance3.TabStop = true
        Me.rbDistance3.Tag = "I3"
        Me.rbDistance3.UseVisualStyleBackColor = true
        '
        'rbDistance4
        '
        resources.ApplyResources(Me.rbDistance4, "rbDistance4")
        Me.rbDistance4.Name = "rbDistance4"
        Me.rbDistance4.TabStop = true
        Me.rbDistance4.Tag = "I4"
        Me.rbDistance4.UseVisualStyleBackColor = true
        '
        'cbUnits
        '
        resources.ApplyResources(Me.cbUnits, "cbUnits")
        Me.cbUnits.Name = "cbUnits"
        Me.cbUnits.UseVisualStyleBackColor = true
        '
        'gbStatus
        '
        resources.ApplyResources(Me.gbStatus, "gbStatus")
        Me.gbStatus.Controls.Add(Me.Label25)
        Me.gbStatus.Controls.Add(Me.tbCurrentStatus)
        Me.gbStatus.Controls.Add(Me.Label24)
        Me.gbStatus.Controls.Add(Me.prgbRxBuf)
        Me.gbStatus.Controls.Add(Me.prgBarQ)
        Me.gbStatus.Controls.Add(Me.cbVerbose)
        Me.gbStatus.Controls.Add(Me.lbResponses)
        Me.gbStatus.Name = "gbStatus"
        Me.gbStatus.TabStop = false
        '
        'Label25
        '
        resources.ApplyResources(Me.Label25, "Label25")
        Me.Label25.Name = "Label25"
        '
        'tbCurrentStatus
        '
        resources.ApplyResources(Me.tbCurrentStatus, "tbCurrentStatus")
        Me.tbCurrentStatus.Name = "tbCurrentStatus"
        Me.ToolTip1.SetToolTip(Me.tbCurrentStatus, resources.GetString("tbCurrentStatus.ToolTip"))
        '
        'Label24
        '
        resources.ApplyResources(Me.Label24, "Label24")
        Me.Label24.Name = "Label24"
        '
        'prgbRxBuf
        '
        resources.ApplyResources(Me.prgbRxBuf, "prgbRxBuf")
        Me.prgbRxBuf.Maximum = 127
        Me.prgbRxBuf.Name = "prgbRxBuf"
        Me.prgbRxBuf.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'prgBarQ
        '
        resources.ApplyResources(Me.prgBarQ, "prgBarQ")
        Me.prgBarQ.Maximum = 25
        Me.prgBarQ.Name = "prgBarQ"
        Me.prgBarQ.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'cbVerbose
        '
        resources.ApplyResources(Me.cbVerbose, "cbVerbose")
        Me.cbVerbose.Checked = Global.GrblPanel.My.MySettings.Default.StatusVerbose
        Me.cbVerbose.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "statusVerbose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbVerbose.Name = "cbVerbose"
        Me.cbVerbose.UseVisualStyleBackColor = true
        '
        'lbResponses
        '
        resources.ApplyResources(Me.lbResponses, "lbResponses")
        Me.lbResponses.FormattingEnabled = true
        Me.lbResponses.Name = "lbResponses"
        '
        'gbGcode
        '
        resources.ApplyResources(Me.gbGcode, "gbGcode")
        Me.gbGcode.Controls.Add(Me.cbMonitorEnable)
        Me.gbGcode.Controls.Add(Me.lblElapsedTime)
        Me.gbGcode.Controls.Add(Me.Label23)
        Me.gbGcode.Controls.Add(Me.Label51)
        Me.gbGcode.Controls.Add(Me.lblCurrentLine)
        Me.gbGcode.Controls.Add(Me.dgvGcode)
        Me.gbGcode.Controls.Add(Me.btnFileReload)
        Me.gbGcode.Controls.Add(Me.tbGCodeMessage)
        Me.gbGcode.Controls.Add(Me.Label27)
        Me.gbGcode.Controls.Add(Me.lblTotalLines)
        Me.gbGcode.Controls.Add(Me.btnFilePause)
        Me.gbGcode.Controls.Add(Me.tbGcodeFile)
        Me.gbGcode.Controls.Add(Me.btnFileSelect)
        Me.gbGcode.Controls.Add(Me.btnFileSend)
        Me.gbGcode.Controls.Add(Me.btnFileStop)
        Me.gbGcode.Name = "gbGcode"
        Me.gbGcode.TabStop = false
        '
        'cbMonitorEnable
        '
        resources.ApplyResources(Me.cbMonitorEnable, "cbMonitorEnable")
        Me.cbMonitorEnable.Checked = true
        Me.cbMonitorEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbMonitorEnable.Name = "cbMonitorEnable"
        Me.cbMonitorEnable.UseVisualStyleBackColor = true
        '
        'lblElapsedTime
        '
        resources.ApplyResources(Me.lblElapsedTime, "lblElapsedTime")
        Me.lblElapsedTime.Name = "lblElapsedTime"
        '
        'Label23
        '
        resources.ApplyResources(Me.Label23, "Label23")
        Me.Label23.Name = "Label23"
        '
        'Label51
        '
        resources.ApplyResources(Me.Label51, "Label51")
        Me.Label51.Name = "Label51"
        '
        'lblCurrentLine
        '
        resources.ApplyResources(Me.lblCurrentLine, "lblCurrentLine")
        Me.lblCurrentLine.Name = "lblCurrentLine"
        '
        'dgvGcode
        '
        Me.dgvGcode.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgvGcode.AllowUserToAddRows = false
        Me.dgvGcode.AllowUserToDeleteRows = false
        Me.dgvGcode.AllowUserToResizeRows = false
        resources.ApplyResources(Me.dgvGcode, "dgvGcode")
        Me.dgvGcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGcode.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.stat, Me.lineNum, Me.data})
        Me.dgvGcode.MultiSelect = false
        Me.dgvGcode.Name = "dgvGcode"
        Me.dgvGcode.ReadOnly = true
        Me.dgvGcode.RowHeadersVisible = false
        Me.dgvGcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGcode.StandardTab = true
        Me.dgvGcode.VirtualMode = true
        '
        'stat
        '
        Me.stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.stat.Frozen = true
        resources.ApplyResources(Me.stat, "stat")
        Me.stat.Name = "stat"
        Me.stat.ReadOnly = true
        Me.stat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'lineNum
        '
        Me.lineNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.lineNum, "lineNum")
        Me.lineNum.Name = "lineNum"
        Me.lineNum.ReadOnly = true
        Me.lineNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'data
        '
        Me.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        resources.ApplyResources(Me.data, "data")
        Me.data.Name = "data"
        Me.data.ReadOnly = true
        Me.data.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'btnFileReload
        '
        resources.ApplyResources(Me.btnFileReload, "btnFileReload")
        Me.btnFileReload.Name = "btnFileReload"
        Me.btnFileReload.Tag = "Reload"
        Me.ToolTip1.SetToolTip(Me.btnFileReload, resources.GetString("btnFileReload.ToolTip"))
        Me.btnFileReload.UseVisualStyleBackColor = true
        '
        'tbGCodeMessage
        '
        Me.tbGCodeMessage.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbGCodeMessage, "tbGCodeMessage")
        Me.tbGCodeMessage.Name = "tbGCodeMessage"
        '
        'Label27
        '
        resources.ApplyResources(Me.Label27, "Label27")
        Me.Label27.Name = "Label27"
        '
        'lblTotalLines
        '
        resources.ApplyResources(Me.lblTotalLines, "lblTotalLines")
        Me.lblTotalLines.Name = "lblTotalLines"
        '
        'btnFilePause
        '
        resources.ApplyResources(Me.btnFilePause, "btnFilePause")
        Me.btnFilePause.Name = "btnFilePause"
        Me.btnFilePause.Tag = "Pause"
        Me.ToolTip1.SetToolTip(Me.btnFilePause, resources.GetString("btnFilePause.ToolTip"))
        Me.btnFilePause.UseVisualStyleBackColor = true
        '
        'tbGcodeFile
        '
        resources.ApplyResources(Me.tbGcodeFile, "tbGcodeFile")
        Me.tbGcodeFile.Name = "tbGcodeFile"
        '
        'btnFileSelect
        '
        resources.ApplyResources(Me.btnFileSelect, "btnFileSelect")
        Me.btnFileSelect.Name = "btnFileSelect"
        Me.btnFileSelect.Tag = "File"
        Me.ToolTip1.SetToolTip(Me.btnFileSelect, resources.GetString("btnFileSelect.ToolTip"))
        Me.btnFileSelect.UseVisualStyleBackColor = true
        '
        'btnFileSend
        '
        resources.ApplyResources(Me.btnFileSend, "btnFileSend")
        Me.btnFileSend.Name = "btnFileSend"
        Me.btnFileSend.Tag = "Send"
        Me.ToolTip1.SetToolTip(Me.btnFileSend, resources.GetString("btnFileSend.ToolTip"))
        Me.btnFileSend.UseVisualStyleBackColor = true
        '
        'btnFileStop
        '
        resources.ApplyResources(Me.btnFileStop, "btnFileStop")
        Me.btnFileStop.Name = "btnFileStop"
        Me.btnFileStop.Tag = "Stop"
        Me.ToolTip1.SetToolTip(Me.btnFileStop, resources.GetString("btnFileStop.ToolTip"))
        Me.btnFileStop.UseVisualStyleBackColor = true
        '
        'gbGrbl
        '
        resources.ApplyResources(Me.gbGrbl, "gbGrbl")
        Me.gbGrbl.Controls.Add(Me.tcConnection)
        Me.gbGrbl.Name = "gbGrbl"
        Me.gbGrbl.TabStop = false
        '
        'tcConnection
        '
        Me.tcConnection.Controls.Add(Me.tbGrblCOM)
        Me.tcConnection.Controls.Add(Me.tbGrblIP)
        resources.ApplyResources(Me.tcConnection, "tcConnection")
        Me.tcConnection.Name = "tcConnection"
        Me.tcConnection.SelectedIndex = 0
        '
        'tbGrblCOM
        '
        Me.tbGrblCOM.Controls.Add(Me.btnRescanPorts)
        Me.tbGrblCOM.Controls.Add(Me.cbPorts)
        Me.tbGrblCOM.Controls.Add(Me.btnConnect)
        Me.tbGrblCOM.Controls.Add(Me.cbBaud)
        resources.ApplyResources(Me.tbGrblCOM, "tbGrblCOM")
        Me.tbGrblCOM.Name = "tbGrblCOM"
        Me.tbGrblCOM.UseVisualStyleBackColor = true
        '
        'btnRescanPorts
        '
        resources.ApplyResources(Me.btnRescanPorts, "btnRescanPorts")
        Me.btnRescanPorts.Name = "btnRescanPorts"
        Me.btnRescanPorts.UseVisualStyleBackColor = true
        '
        'cbPorts
        '
        Me.cbPorts.FormattingEnabled = true
        resources.ApplyResources(Me.cbPorts, "cbPorts")
        Me.cbPorts.Name = "cbPorts"
        '
        'btnConnect
        '
        resources.ApplyResources(Me.btnConnect, "btnConnect")
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Tag = "COM"
        Me.btnConnect.UseVisualStyleBackColor = true
        '
        'cbBaud
        '
        Me.cbBaud.FormattingEnabled = true
        Me.cbBaud.Items.AddRange(New Object() {resources.GetString("cbBaud.Items"), resources.GetString("cbBaud.Items1")})
        resources.ApplyResources(Me.cbBaud, "cbBaud")
        Me.cbBaud.Name = "cbBaud"
        '
        'tbGrblIP
        '
        Me.tbGrblIP.Controls.Add(Me.btnIPConnect)
        Me.tbGrblIP.Controls.Add(Me.tbIPAddress)
        resources.ApplyResources(Me.tbGrblIP, "tbGrblIP")
        Me.tbGrblIP.Name = "tbGrblIP"
        Me.tbGrblIP.UseVisualStyleBackColor = true
        '
        'btnIPConnect
        '
        resources.ApplyResources(Me.btnIPConnect, "btnIPConnect")
        Me.btnIPConnect.Name = "btnIPConnect"
        Me.btnIPConnect.Tag = "IP"
        Me.btnIPConnect.UseVisualStyleBackColor = true
        '
        'tbIPAddress
        '
        resources.ApplyResources(Me.tbIPAddress, "tbIPAddress")
        Me.tbIPAddress.Name = "tbIPAddress"
        Me.ToolTip1.SetToolTip(Me.tbIPAddress, resources.GetString("tbIPAddress.ToolTip"))
        '
        'gbPosition
        '
        Me.gbPosition.Controls.Add(Me.tabCtlPosition)
        resources.ApplyResources(Me.gbPosition, "gbPosition")
        Me.gbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.gbPosition.Name = "gbPosition"
        Me.gbPosition.TabStop = false
        '
        'tabCtlPosition
        '
        Me.tabCtlPosition.Controls.Add(Me.tpWork)
        Me.tabCtlPosition.Controls.Add(Me.tpOffsets)
        resources.ApplyResources(Me.tabCtlPosition, "tabCtlPosition")
        Me.tabCtlPosition.Name = "tabCtlPosition"
        Me.tabCtlPosition.SelectedIndex = 0
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
        resources.ApplyResources(Me.tpWork, "tpWork")
        Me.tpWork.Name = "tpWork"
        Me.tpWork.UseVisualStyleBackColor = true
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.SystemColors.Control
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.tbWorkZ)
        Me.Panel5.Controls.Add(Me.tbMachZ)
        resources.ApplyResources(Me.Panel5, "Panel5")
        Me.Panel5.Name = "Panel5"
        '
        'tbWorkZ
        '
        Me.tbWorkZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkZ, "tbWorkZ")
        Me.tbWorkZ.Name = "tbWorkZ"
        Me.ToolTip1.SetToolTip(Me.tbWorkZ, resources.GetString("tbWorkZ.ToolTip"))
        '
        'tbMachZ
        '
        Me.tbMachZ.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachZ, "tbMachZ")
        Me.tbMachZ.Name = "tbMachZ"
        Me.ToolTip1.SetToolTip(Me.tbMachZ, resources.GetString("tbMachZ.ToolTip"))
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.SystemColors.Control
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.tbWorkY)
        Me.Panel4.Controls.Add(Me.tbMachY)
        resources.ApplyResources(Me.Panel4, "Panel4")
        Me.Panel4.Name = "Panel4"
        '
        'tbWorkY
        '
        Me.tbWorkY.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkY, "tbWorkY")
        Me.tbWorkY.Name = "tbWorkY"
        Me.ToolTip1.SetToolTip(Me.tbWorkY, resources.GetString("tbWorkY.ToolTip"))
        '
        'tbMachY
        '
        Me.tbMachY.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachY, "tbMachY")
        Me.tbMachY.Name = "tbMachY"
        Me.ToolTip1.SetToolTip(Me.tbMachY, resources.GetString("tbMachY.ToolTip"))
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Control
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.tbMachX)
        Me.Panel3.Controls.Add(Me.tbWorkX)
        resources.ApplyResources(Me.Panel3, "Panel3")
        Me.Panel3.Name = "Panel3"
        '
        'tbMachX
        '
        Me.tbMachX.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbMachX, "tbMachX")
        Me.tbMachX.Name = "tbMachX"
        Me.ToolTip1.SetToolTip(Me.tbMachX, resources.GetString("tbMachX.ToolTip"))
        '
        'tbWorkX
        '
        Me.tbWorkX.BorderStyle = System.Windows.Forms.BorderStyle.None
        resources.ApplyResources(Me.tbWorkX, "tbWorkX")
        Me.tbWorkX.Name = "tbWorkX"
        Me.ToolTip1.SetToolTip(Me.tbWorkX, resources.GetString("tbWorkX.ToolTip"))
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblPositionCurrentOffset)
        resources.ApplyResources(Me.GroupBox1, "GroupBox1")
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.TabStop = false
        '
        'lblPositionCurrentOffset
        '
        resources.ApplyResources(Me.lblPositionCurrentOffset, "lblPositionCurrentOffset")
        Me.lblPositionCurrentOffset.Name = "lblPositionCurrentOffset"
        '
        'btnWorkSoftHome
        '
        resources.ApplyResources(Me.btnWorkSoftHome, "btnWorkSoftHome")
        Me.btnWorkSoftHome.Name = "btnWorkSoftHome"
        Me.btnWorkSoftHome.Tag = "Spcl Posn1"
        Me.ToolTip1.SetToolTip(Me.btnWorkSoftHome, resources.GetString("btnWorkSoftHome.ToolTip"))
        Me.btnWorkSoftHome.UseVisualStyleBackColor = true
        '
        'btnHome
        '
        Me.btnHome.BackColor = System.Drawing.Color.Transparent
        resources.ApplyResources(Me.btnHome, "btnHome")
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Tag = "HomeCycle"
        Me.ToolTip1.SetToolTip(Me.btnHome, resources.GetString("btnHome.ToolTip"))
        Me.btnHome.UseVisualStyleBackColor = false
        '
        'btnWorkSpclPosition
        '
        resources.ApplyResources(Me.btnWorkSpclPosition, "btnWorkSpclPosition")
        Me.btnWorkSpclPosition.Name = "btnWorkSpclPosition"
        Me.btnWorkSpclPosition.Tag = "Spcl Posn2"
        Me.ToolTip1.SetToolTip(Me.btnWorkSpclPosition, resources.GetString("btnWorkSpclPosition.ToolTip"))
        Me.btnWorkSpclPosition.UseVisualStyleBackColor = true
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'btnWork0
        '
        resources.ApplyResources(Me.btnWork0, "btnWork0")
        Me.btnWork0.Name = "btnWork0"
        Me.btnWork0.Tag = "ZeroXYZ"
        Me.ToolTip1.SetToolTip(Me.btnWork0, resources.GetString("btnWork0.ToolTip"))
        Me.btnWork0.UseVisualStyleBackColor = true
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'btnWorkX0
        '
        resources.ApplyResources(Me.btnWorkX0, "btnWorkX0")
        Me.btnWorkX0.Name = "btnWorkX0"
        Me.btnWorkX0.Tag = "X"
        Me.ToolTip1.SetToolTip(Me.btnWorkX0, resources.GetString("btnWorkX0.ToolTip"))
        Me.btnWorkX0.UseVisualStyleBackColor = true
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'btnWorkZ0
        '
        resources.ApplyResources(Me.btnWorkZ0, "btnWorkZ0")
        Me.btnWorkZ0.Name = "btnWorkZ0"
        Me.btnWorkZ0.Tag = "Z"
        Me.ToolTip1.SetToolTip(Me.btnWorkZ0, resources.GetString("btnWorkZ0.ToolTip"))
        Me.btnWorkZ0.UseVisualStyleBackColor = true
        '
        'btnWorkY0
        '
        resources.ApplyResources(Me.btnWorkY0, "btnWorkY0")
        Me.btnWorkY0.Name = "btnWorkY0"
        Me.btnWorkY0.Tag = "Y"
        Me.ToolTip1.SetToolTip(Me.btnWorkY0, resources.GetString("btnWorkY0.ToolTip"))
        Me.btnWorkY0.UseVisualStyleBackColor = true
        '
        'tpOffsets
        '
        Me.tpOffsets.Controls.Add(Me.btnSetOffsetG59)
        Me.tpOffsets.Controls.Add(Me.btnSetOffsetG58)
        Me.tpOffsets.Controls.Add(Me.btnSetOffsetG57)
        Me.tpOffsets.Controls.Add(Me.btnSetOffsetG56)
        Me.tpOffsets.Controls.Add(Me.btnSetOffsetG55)
        Me.tpOffsets.Controls.Add(Me.btnSetOffsetG54)
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
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG54X)
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
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG59Y)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG43Z)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG55Zero)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG59Z)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG58Z)
        Me.tpOffsets.Controls.Add(Me.Label60)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG58Y)
        Me.tpOffsets.Controls.Add(Me.Label20)
        Me.tpOffsets.Controls.Add(Me.Label43)
        Me.tpOffsets.Controls.Add(Me.btnOffsetsG59Zero)
        Me.tpOffsets.Controls.Add(Me.tbOffsetsG58X)
        Me.tpOffsets.Controls.Add(Me.Label21)
        resources.ApplyResources(Me.tpOffsets, "tpOffsets")
        Me.tpOffsets.Name = "tpOffsets"
        Me.tpOffsets.UseVisualStyleBackColor = true
        '
        'btnSetOffsetG59
        '
        resources.ApplyResources(Me.btnSetOffsetG59, "btnSetOffsetG59")
        Me.btnSetOffsetG59.Name = "btnSetOffsetG59"
        Me.btnSetOffsetG59.Tag = "G59"
        Me.ToolTip1.SetToolTip(Me.btnSetOffsetG59, resources.GetString("btnSetOffsetG59.ToolTip"))
        Me.btnSetOffsetG59.UseVisualStyleBackColor = true
        '
        'btnSetOffsetG58
        '
        resources.ApplyResources(Me.btnSetOffsetG58, "btnSetOffsetG58")
        Me.btnSetOffsetG58.Name = "btnSetOffsetG58"
        Me.btnSetOffsetG58.Tag = "G58"
        Me.ToolTip1.SetToolTip(Me.btnSetOffsetG58, resources.GetString("btnSetOffsetG58.ToolTip"))
        Me.btnSetOffsetG58.UseVisualStyleBackColor = true
        '
        'btnSetOffsetG57
        '
        resources.ApplyResources(Me.btnSetOffsetG57, "btnSetOffsetG57")
        Me.btnSetOffsetG57.Name = "btnSetOffsetG57"
        Me.btnSetOffsetG57.Tag = "G57"
        Me.ToolTip1.SetToolTip(Me.btnSetOffsetG57, resources.GetString("btnSetOffsetG57.ToolTip"))
        Me.btnSetOffsetG57.UseVisualStyleBackColor = true
        '
        'btnSetOffsetG56
        '
        resources.ApplyResources(Me.btnSetOffsetG56, "btnSetOffsetG56")
        Me.btnSetOffsetG56.Name = "btnSetOffsetG56"
        Me.btnSetOffsetG56.Tag = "G56"
        Me.ToolTip1.SetToolTip(Me.btnSetOffsetG56, resources.GetString("btnSetOffsetG56.ToolTip"))
        Me.btnSetOffsetG56.UseVisualStyleBackColor = true
        '
        'btnSetOffsetG55
        '
        resources.ApplyResources(Me.btnSetOffsetG55, "btnSetOffsetG55")
        Me.btnSetOffsetG55.Name = "btnSetOffsetG55"
        Me.btnSetOffsetG55.Tag = "G55"
        Me.ToolTip1.SetToolTip(Me.btnSetOffsetG55, resources.GetString("btnSetOffsetG55.ToolTip"))
        Me.btnSetOffsetG55.UseVisualStyleBackColor = true
        '
        'btnSetOffsetG54
        '
        resources.ApplyResources(Me.btnSetOffsetG54, "btnSetOffsetG54")
        Me.btnSetOffsetG54.Name = "btnSetOffsetG54"
        Me.btnSetOffsetG54.Tag = "G54"
        Me.ToolTip1.SetToolTip(Me.btnSetOffsetG54, resources.GetString("btnSetOffsetG54.ToolTip"))
        Me.btnSetOffsetG54.UseVisualStyleBackColor = true
        '
        'Label10
        '
        resources.ApplyResources(Me.Label10, "Label10")
        Me.Label10.Name = "Label10"
        '
        'Label71
        '
        resources.ApplyResources(Me.Label71, "Label71")
        Me.Label71.Name = "Label71"
        '
        'tbOffSetsMachZ
        '
        resources.ApplyResources(Me.tbOffSetsMachZ, "tbOffSetsMachZ")
        Me.tbOffSetsMachZ.Name = "tbOffSetsMachZ"
        Me.tbOffSetsMachZ.Tag = "G28Z"
        Me.ToolTip1.SetToolTip(Me.tbOffSetsMachZ, resources.GetString("tbOffSetsMachZ.ToolTip"))
        '
        'Label19
        '
        resources.ApplyResources(Me.Label19, "Label19")
        Me.Label19.Name = "Label19"
        '
        'tbOffsetsG56Y
        '
        resources.ApplyResources(Me.tbOffsetsG56Y, "tbOffsetsG56Y")
        Me.tbOffsetsG56Y.Name = "tbOffsetsG56Y"
        Me.tbOffsetsG56Y.Tag = "G56Y"
        '
        'tbOffSetsMachY
        '
        resources.ApplyResources(Me.tbOffSetsMachY, "tbOffSetsMachY")
        Me.tbOffSetsMachY.Name = "tbOffSetsMachY"
        Me.tbOffSetsMachY.Tag = "G28Y"
        Me.ToolTip1.SetToolTip(Me.tbOffSetsMachY, resources.GetString("tbOffSetsMachY.ToolTip"))
        '
        'tbOffsetsG56X
        '
        resources.ApplyResources(Me.tbOffsetsG56X, "tbOffsetsG56X")
        Me.tbOffsetsG56X.Name = "tbOffsetsG56X"
        Me.tbOffsetsG56X.Tag = "G56X"
        '
        'tbOffsetsG56Z
        '
        resources.ApplyResources(Me.tbOffsetsG56Z, "tbOffsetsG56Z")
        Me.tbOffsetsG56Z.Name = "tbOffsetsG56Z"
        Me.tbOffsetsG56Z.Tag = "G56Z"
        '
        'tbOffSetsMachX
        '
        resources.ApplyResources(Me.tbOffSetsMachX, "tbOffSetsMachX")
        Me.tbOffSetsMachX.Name = "tbOffSetsMachX"
        Me.tbOffSetsMachX.Tag = "G28X"
        Me.ToolTip1.SetToolTip(Me.tbOffSetsMachX, resources.GetString("tbOffSetsMachX.ToolTip"))
        '
        'btnOffsetsG57Zero
        '
        resources.ApplyResources(Me.btnOffsetsG57Zero, "btnOffsetsG57Zero")
        Me.btnOffsetsG57Zero.Name = "btnOffsetsG57Zero"
        Me.btnOffsetsG57Zero.Tag = "G57Zero"
        Me.btnOffsetsG57Zero.UseVisualStyleBackColor = true
        '
        'tbOffsetsG54X
        '
        resources.ApplyResources(Me.tbOffsetsG54X, "tbOffsetsG54X")
        Me.tbOffsetsG54X.Name = "tbOffsetsG54X"
        Me.tbOffsetsG54X.Tag = "G54X"
        '
        'btnOffsetsG56Zero
        '
        resources.ApplyResources(Me.btnOffsetsG56Zero, "btnOffsetsG56Zero")
        Me.btnOffsetsG56Zero.Name = "btnOffsetsG56Zero"
        Me.btnOffsetsG56Zero.Tag = "G56Zero"
        Me.btnOffsetsG56Zero.UseVisualStyleBackColor = true
        '
        'tbOffsetsG54Y
        '
        resources.ApplyResources(Me.tbOffsetsG54Y, "tbOffsetsG54Y")
        Me.tbOffsetsG54Y.Name = "tbOffsetsG54Y"
        Me.tbOffsetsG54Y.Tag = "G54Y"
        '
        'tbOffsetsG57Z
        '
        resources.ApplyResources(Me.tbOffsetsG57Z, "tbOffsetsG57Z")
        Me.tbOffsetsG57Z.Name = "tbOffsetsG57Z"
        Me.tbOffsetsG57Z.Tag = "G57Z"
        '
        'btnOffsetsSave
        '
        resources.ApplyResources(Me.btnOffsetsSave, "btnOffsetsSave")
        Me.btnOffsetsSave.Name = "btnOffsetsSave"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsSave, resources.GetString("btnOffsetsSave.ToolTip"))
        Me.btnOffsetsSave.UseVisualStyleBackColor = true
        '
        'tbOffsetsG55X
        '
        resources.ApplyResources(Me.tbOffsetsG55X, "tbOffsetsG55X")
        Me.tbOffsetsG55X.Name = "tbOffsetsG55X"
        Me.tbOffsetsG55X.Tag = "G55X"
        '
        'tbOffsetsG54Z
        '
        resources.ApplyResources(Me.tbOffsetsG54Z, "tbOffsetsG54Z")
        Me.tbOffsetsG54Z.Name = "tbOffsetsG54Z"
        Me.tbOffsetsG54Z.Tag = "G54Z"
        '
        'tbOffsetsG57Y
        '
        resources.ApplyResources(Me.tbOffsetsG57Y, "tbOffsetsG57Y")
        Me.tbOffsetsG57Y.Name = "tbOffsetsG57Y"
        Me.tbOffsetsG57Y.Tag = "G57Y"
        '
        'btnOffsetsRetrieve
        '
        resources.ApplyResources(Me.btnOffsetsRetrieve, "btnOffsetsRetrieve")
        Me.btnOffsetsRetrieve.Name = "btnOffsetsRetrieve"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsRetrieve, resources.GetString("btnOffsetsRetrieve.ToolTip"))
        Me.btnOffsetsRetrieve.UseVisualStyleBackColor = true
        '
        'tbOffsetsG55Y
        '
        resources.ApplyResources(Me.tbOffsetsG55Y, "tbOffsetsG55Y")
        Me.tbOffsetsG55Y.Name = "tbOffsetsG55Y"
        Me.tbOffsetsG55Y.Tag = "G55Y"
        '
        'btnOffsetsG54Zero
        '
        resources.ApplyResources(Me.btnOffsetsG54Zero, "btnOffsetsG54Zero")
        Me.btnOffsetsG54Zero.Name = "btnOffsetsG54Zero"
        Me.btnOffsetsG54Zero.Tag = "G54Zero"
        Me.btnOffsetsG54Zero.UseVisualStyleBackColor = true
        '
        'tbOffsetsG57X
        '
        resources.ApplyResources(Me.tbOffsetsG57X, "tbOffsetsG57X")
        Me.tbOffsetsG57X.Name = "tbOffsetsG57X"
        Me.tbOffsetsG57X.Tag = "G57X"
        '
        'btnOffsetsLoad
        '
        resources.ApplyResources(Me.btnOffsetsLoad, "btnOffsetsLoad")
        Me.btnOffsetsLoad.Name = "btnOffsetsLoad"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsLoad, resources.GetString("btnOffsetsLoad.ToolTip"))
        Me.btnOffsetsLoad.UseVisualStyleBackColor = true
        '
        'tbOffsetsG55Z
        '
        resources.ApplyResources(Me.tbOffsetsG55Z, "tbOffsetsG55Z")
        Me.tbOffsetsG55Z.Name = "tbOffsetsG55Z"
        Me.tbOffsetsG55Z.Tag = "G55Z"
        '
        'tbOffsetsG59X
        '
        resources.ApplyResources(Me.tbOffsetsG59X, "tbOffsetsG59X")
        Me.tbOffsetsG59X.Name = "tbOffsetsG59X"
        Me.tbOffsetsG59X.Tag = "G59X"
        '
        'btnOffsetsG58Zero
        '
        resources.ApplyResources(Me.btnOffsetsG58Zero, "btnOffsetsG58Zero")
        Me.btnOffsetsG58Zero.Name = "btnOffsetsG58Zero"
        Me.btnOffsetsG58Zero.Tag = "G58Zero"
        Me.btnOffsetsG58Zero.UseVisualStyleBackColor = true
        '
        'btnOffsetsG43Zero
        '
        resources.ApplyResources(Me.btnOffsetsG43Zero, "btnOffsetsG43Zero")
        Me.btnOffsetsG43Zero.Name = "btnOffsetsG43Zero"
        Me.btnOffsetsG43Zero.Tag = "G43Zero"
        Me.btnOffsetsG43Zero.UseVisualStyleBackColor = true
        '
        'tbOffsetsG59Y
        '
        resources.ApplyResources(Me.tbOffsetsG59Y, "tbOffsetsG59Y")
        Me.tbOffsetsG59Y.Name = "tbOffsetsG59Y"
        Me.tbOffsetsG59Y.Tag = "G59Y"
        '
        'tbOffsetsG43Z
        '
        resources.ApplyResources(Me.tbOffsetsG43Z, "tbOffsetsG43Z")
        Me.tbOffsetsG43Z.Name = "tbOffsetsG43Z"
        Me.tbOffsetsG43Z.Tag = "G43Z"
        '
        'btnOffsetsG55Zero
        '
        resources.ApplyResources(Me.btnOffsetsG55Zero, "btnOffsetsG55Zero")
        Me.btnOffsetsG55Zero.Name = "btnOffsetsG55Zero"
        Me.btnOffsetsG55Zero.Tag = "G55Zero"
        Me.btnOffsetsG55Zero.UseVisualStyleBackColor = true
        '
        'tbOffsetsG59Z
        '
        resources.ApplyResources(Me.tbOffsetsG59Z, "tbOffsetsG59Z")
        Me.tbOffsetsG59Z.Name = "tbOffsetsG59Z"
        Me.tbOffsetsG59Z.Tag = "G59Z"
        '
        'tbOffsetsG58Z
        '
        resources.ApplyResources(Me.tbOffsetsG58Z, "tbOffsetsG58Z")
        Me.tbOffsetsG58Z.Name = "tbOffsetsG58Z"
        Me.tbOffsetsG58Z.Tag = "G58Z"
        '
        'Label60
        '
        resources.ApplyResources(Me.Label60, "Label60")
        Me.Label60.Name = "Label60"
        '
        'tbOffsetsG58Y
        '
        resources.ApplyResources(Me.tbOffsetsG58Y, "tbOffsetsG58Y")
        Me.tbOffsetsG58Y.Name = "tbOffsetsG58Y"
        Me.tbOffsetsG58Y.Tag = "G58Y"
        '
        'Label20
        '
        resources.ApplyResources(Me.Label20, "Label20")
        Me.Label20.Name = "Label20"
        '
        'Label43
        '
        resources.ApplyResources(Me.Label43, "Label43")
        Me.Label43.Name = "Label43"
        '
        'btnOffsetsG59Zero
        '
        resources.ApplyResources(Me.btnOffsetsG59Zero, "btnOffsetsG59Zero")
        Me.btnOffsetsG59Zero.Name = "btnOffsetsG59Zero"
        Me.btnOffsetsG59Zero.Tag = "G59Zero"
        Me.btnOffsetsG59Zero.UseVisualStyleBackColor = true
        '
        'tbOffsetsG58X
        '
        resources.ApplyResources(Me.tbOffsetsG58X, "tbOffsetsG58X")
        Me.tbOffsetsG58X.Name = "tbOffsetsG58X"
        Me.tbOffsetsG58X.Tag = "G58X"
        '
        'Label21
        '
        resources.ApplyResources(Me.Label21, "Label21")
        Me.Label21.Name = "Label21"
        '
        'tabPgSettings
        '
        Me.tabPgSettings.Controls.Add(Me.gbGrblSettings)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsOffsets)
        Me.tabPgSettings.Controls.Add(Me.Label42)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsMisc)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsPosition)
        Me.tabPgSettings.Controls.Add(Me.gbSettingsJogging)
        resources.ApplyResources(Me.tabPgSettings, "tabPgSettings")
        Me.tabPgSettings.Name = "tabPgSettings"
        Me.tabPgSettings.UseVisualStyleBackColor = true
        '
        'gbGrblSettings
        '
        Me.gbGrblSettings.Controls.Add(Me.Label4)
        Me.gbGrblSettings.Controls.Add(Me.tbSettingsGrblLastParam)
        Me.gbGrblSettings.Controls.Add(Me.dgGrblSettings)
        Me.gbGrblSettings.Controls.Add(Me.btnSettingsGrbl)
        resources.ApplyResources(Me.gbGrblSettings, "gbGrblSettings")
        Me.gbGrblSettings.Name = "gbGrblSettings"
        Me.gbGrblSettings.TabStop = false
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.Name = "Label4"
        '
        'tbSettingsGrblLastParam
        '
        Me.tbSettingsGrblLastParam.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "GrblLastParamID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsGrblLastParam, "tbSettingsGrblLastParam")
        Me.tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam"
        Me.tbSettingsGrblLastParam.Text = Global.GrblPanel.My.MySettings.Default.GrblLastParamID
        Me.ToolTip1.SetToolTip(Me.tbSettingsGrblLastParam, resources.GetString("tbSettingsGrblLastParam.ToolTip"))
        '
        'dgGrblSettings
        '
        Me.dgGrblSettings.AllowUserToAddRows = false
        Me.dgGrblSettings.AllowUserToDeleteRows = false
        Me.dgGrblSettings.AllowUserToResizeColumns = false
        Me.dgGrblSettings.AllowUserToResizeRows = false
        Me.dgGrblSettings.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dgGrblSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgGrblSettings, "dgGrblSettings")
        Me.dgGrblSettings.MultiSelect = false
        Me.dgGrblSettings.Name = "dgGrblSettings"
        Me.dgGrblSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.ToolTip1.SetToolTip(Me.dgGrblSettings, resources.GetString("dgGrblSettings.ToolTip"))
        '
        'btnSettingsGrbl
        '
        resources.ApplyResources(Me.btnSettingsGrbl, "btnSettingsGrbl")
        Me.btnSettingsGrbl.Name = "btnSettingsGrbl"
        Me.btnSettingsGrbl.UseVisualStyleBackColor = true
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
        resources.ApplyResources(Me.gbSettingsOffsets, "gbSettingsOffsets")
        Me.gbSettingsOffsets.Name = "gbSettingsOffsets"
        Me.gbSettingsOffsets.TabStop = false
        '
        'btnOffsetsG28Set
        '
        resources.ApplyResources(Me.btnOffsetsG28Set, "btnOffsetsG28Set")
        Me.btnOffsetsG28Set.Name = "btnOffsetsG28Set"
        Me.btnOffsetsG28Set.Tag = "G28Set"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsG28Set, resources.GetString("btnOffsetsG28Set.ToolTip"))
        Me.btnOffsetsG28Set.UseVisualStyleBackColor = true
        '
        'btnSettingsRetrieveLocations
        '
        resources.ApplyResources(Me.btnSettingsRetrieveLocations, "btnSettingsRetrieveLocations")
        Me.btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations"
        Me.ToolTip1.SetToolTip(Me.btnSettingsRetrieveLocations, resources.GetString("btnSettingsRetrieveLocations.ToolTip"))
        Me.btnSettingsRetrieveLocations.UseVisualStyleBackColor = true
        '
        'Label7
        '
        resources.ApplyResources(Me.Label7, "Label7")
        Me.Label7.Name = "Label7"
        '
        'Label18
        '
        resources.ApplyResources(Me.Label18, "Label18")
        Me.Label18.Name = "Label18"
        '
        'tbOffsetsG30Y
        '
        resources.ApplyResources(Me.tbOffsetsG30Y, "tbOffsetsG30Y")
        Me.tbOffsetsG30Y.Name = "tbOffsetsG30Y"
        Me.tbOffsetsG30Y.Tag = "G30Y"
        '
        'tbOffsetsG30X
        '
        resources.ApplyResources(Me.tbOffsetsG30X, "tbOffsetsG30X")
        Me.tbOffsetsG30X.Name = "tbOffsetsG30X"
        Me.tbOffsetsG30X.Tag = "G30X"
        '
        'tbOffsetsG30Z
        '
        resources.ApplyResources(Me.tbOffsetsG30Z, "tbOffsetsG30Z")
        Me.tbOffsetsG30Z.Name = "tbOffsetsG30Z"
        Me.tbOffsetsG30Z.Tag = "G30Z"
        '
        'tbOffsetsG28X
        '
        resources.ApplyResources(Me.tbOffsetsG28X, "tbOffsetsG28X")
        Me.tbOffsetsG28X.Name = "tbOffsetsG28X"
        Me.tbOffsetsG28X.Tag = "G28X"
        '
        'btnOffsetsG30Set
        '
        resources.ApplyResources(Me.btnOffsetsG30Set, "btnOffsetsG30Set")
        Me.btnOffsetsG30Set.Name = "btnOffsetsG30Set"
        Me.btnOffsetsG30Set.Tag = "G30Set"
        Me.ToolTip1.SetToolTip(Me.btnOffsetsG30Set, resources.GetString("btnOffsetsG30Set.ToolTip"))
        Me.btnOffsetsG30Set.UseVisualStyleBackColor = true
        '
        'tbOffsetsG28Y
        '
        resources.ApplyResources(Me.tbOffsetsG28Y, "tbOffsetsG28Y")
        Me.tbOffsetsG28Y.Name = "tbOffsetsG28Y"
        Me.tbOffsetsG28Y.Tag = "G28Y"
        '
        'Label68
        '
        resources.ApplyResources(Me.Label68, "Label68")
        Me.Label68.Name = "Label68"
        '
        'tbOffsetsG28Z
        '
        resources.ApplyResources(Me.tbOffsetsG28Z, "tbOffsetsG28Z")
        Me.tbOffsetsG28Z.Name = "tbOffsetsG28Z"
        Me.tbOffsetsG28Z.Tag = "G28Z"
        '
        'Label69
        '
        resources.ApplyResources(Me.Label69, "Label69")
        Me.Label69.Name = "Label69"
        '
        'Label42
        '
        resources.ApplyResources(Me.Label42, "Label42")
        Me.Label42.Name = "Label42"
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
        resources.ApplyResources(Me.gbSettingsMisc, "gbSettingsMisc")
        Me.gbSettingsMisc.Name = "gbSettingsMisc"
        Me.gbSettingsMisc.TabStop = false
        '
        'tbSettingsDefaultExt
        '
        Me.tbSettingsDefaultExt.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "DefaultFileExt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsDefaultExt, "tbSettingsDefaultExt")
        Me.tbSettingsDefaultExt.Name = "tbSettingsDefaultExt"
        Me.tbSettingsDefaultExt.Text = Global.GrblPanel.My.MySettings.Default.DefaultFileExt
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.Name = "Label5"
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.Name = "Label6"
        '
        'tbSettingsStartupDelay
        '
        Me.tbSettingsStartupDelay.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "StartupDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsStartupDelay, "tbSettingsStartupDelay")
        Me.tbSettingsStartupDelay.Name = "tbSettingsStartupDelay"
        Me.tbSettingsStartupDelay.Text = Global.GrblPanel.My.MySettings.Default.StartupDelay
        '
        'cbSettingsLeftHanded
        '
        resources.ApplyResources(Me.cbSettingsLeftHanded, "cbSettingsLeftHanded")
        Me.cbSettingsLeftHanded.Checked = Global.GrblPanel.My.MySettings.Default.LeftHandedGUI
        Me.cbSettingsLeftHanded.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "LeftHandedGUI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsLeftHanded.Name = "cbSettingsLeftHanded"
        Me.cbSettingsLeftHanded.UseVisualStyleBackColor = true
        '
        'cbSettingsConnectOnLoad
        '
        resources.ApplyResources(Me.cbSettingsConnectOnLoad, "cbSettingsConnectOnLoad")
        Me.cbSettingsConnectOnLoad.Checked = Global.GrblPanel.My.MySettings.Default.GrblConnectOnLoad
        Me.cbSettingsConnectOnLoad.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "GrblConnectOnLoad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad"
        Me.ToolTip1.SetToolTip(Me.cbSettingsConnectOnLoad, resources.GetString("cbSettingsConnectOnLoad.ToolTip"))
        Me.cbSettingsConnectOnLoad.UseVisualStyleBackColor = true
        '
        'cbSettingsPauseOnError
        '
        resources.ApplyResources(Me.cbSettingsPauseOnError, "cbSettingsPauseOnError")
        Me.cbSettingsPauseOnError.Checked = Global.GrblPanel.My.MySettings.Default.GCodePauseOnError
        Me.cbSettingsPauseOnError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbSettingsPauseOnError.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "GCodePauseOnError", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsPauseOnError.Name = "cbSettingsPauseOnError"
        Me.cbSettingsPauseOnError.UseVisualStyleBackColor = true
        '
        'cbStatusPollEnable
        '
        resources.ApplyResources(Me.cbStatusPollEnable, "cbStatusPollEnable")
        Me.cbStatusPollEnable.Checked = Global.GrblPanel.My.MySettings.Default.StatusPollEnabled
        Me.cbStatusPollEnable.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbStatusPollEnable.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "StatusPollEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbStatusPollEnable.Name = "cbStatusPollEnable"
        Me.cbStatusPollEnable.UseVisualStyleBackColor = true
        '
        'btnSettingsRefreshMisc
        '
        resources.ApplyResources(Me.btnSettingsRefreshMisc, "btnSettingsRefreshMisc")
        Me.btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc"
        Me.btnSettingsRefreshMisc.Tag = "Misc"
        Me.btnSettingsRefreshMisc.UseVisualStyleBackColor = true
        '
        'Label37
        '
        resources.ApplyResources(Me.Label37, "Label37")
        Me.Label37.Name = "Label37"
        '
        'Label36
        '
        resources.ApplyResources(Me.Label36, "Label36")
        Me.Label36.Name = "Label36"
        '
        'tbSettingsRBuffSize
        '
        Me.tbSettingsRBuffSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "RBuffMaxSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsRBuffSize, "tbSettingsRBuffSize")
        Me.tbSettingsRBuffSize.Name = "tbSettingsRBuffSize"
        Me.tbSettingsRBuffSize.Text = Global.GrblPanel.My.MySettings.Default.RBuffMaxSize
        '
        'tbSettingsQSize
        '
        Me.tbSettingsQSize.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "QBuffMaxSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsQSize, "tbSettingsQSize")
        Me.tbSettingsQSize.Name = "tbSettingsQSize"
        Me.tbSettingsQSize.Text = Global.GrblPanel.My.MySettings.Default.QBuffMaxSize
        '
        'Label26
        '
        resources.ApplyResources(Me.Label26, "Label26")
        Me.Label26.Name = "Label26"
        '
        'tbSettingsPollRate
        '
        Me.tbSettingsPollRate.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "statusPollInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsPollRate, "tbSettingsPollRate")
        Me.tbSettingsPollRate.Name = "tbSettingsPollRate"
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
        resources.ApplyResources(Me.gbSettingsPosition, "gbSettingsPosition")
        Me.gbSettingsPosition.Name = "gbSettingsPosition"
        Me.gbSettingsPosition.TabStop = false
        '
        'Label8
        '
        resources.ApplyResources(Me.Label8, "Label8")
        Me.Label8.Name = "Label8"
        '
        'tbSettingsSpclPosition2
        '
        Me.tbSettingsSpclPosition2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsSpclPosition2, "tbSettingsSpclPosition2")
        Me.tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2"
        Me.tbSettingsSpclPosition2.Text = Global.GrblPanel.My.MySettings.Default.MachineSpclPosition2
        '
        'btnSettingsRefreshPosition
        '
        resources.ApplyResources(Me.btnSettingsRefreshPosition, "btnSettingsRefreshPosition")
        Me.btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition"
        Me.btnSettingsRefreshPosition.Tag = "Position"
        Me.btnSettingsRefreshPosition.UseVisualStyleBackColor = true
        '
        'Label29
        '
        resources.ApplyResources(Me.Label29, "Label29")
        Me.Label29.Name = "Label29"
        '
        'tbWorkZ0Cmd
        '
        Me.tbWorkZ0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkZ0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbWorkZ0Cmd, "tbWorkZ0Cmd")
        Me.tbWorkZ0Cmd.Name = "tbWorkZ0Cmd"
        Me.tbWorkZ0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkZ0Cmd
        '
        'Label28
        '
        resources.ApplyResources(Me.Label28, "Label28")
        Me.Label28.Name = "Label28"
        '
        'tbWorkY0Cmd
        '
        Me.tbWorkY0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkY0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbWorkY0Cmd, "tbWorkY0Cmd")
        Me.tbWorkY0Cmd.Name = "tbWorkY0Cmd"
        Me.tbWorkY0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkY0Cmd
        '
        'Label13
        '
        resources.ApplyResources(Me.Label13, "Label13")
        Me.Label13.Name = "Label13"
        '
        'Label12
        '
        resources.ApplyResources(Me.Label12, "Label12")
        Me.Label12.Name = "Label12"
        '
        'tbWorkX0Cmd
        '
        Me.tbWorkX0Cmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "WorkX0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbWorkX0Cmd, "tbWorkX0Cmd")
        Me.tbWorkX0Cmd.Name = "tbWorkX0Cmd"
        Me.tbWorkX0Cmd.Text = Global.GrblPanel.My.MySettings.Default.WorkX0Cmd
        '
        'tbSettingsZeroXYZCmd
        '
        Me.tbSettingsZeroXYZCmd.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "Work0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsZeroXYZCmd, "tbSettingsZeroXYZCmd")
        Me.tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd"
        Me.tbSettingsZeroXYZCmd.Text = Global.GrblPanel.My.MySettings.Default.Work0Cmd
        '
        'Label11
        '
        resources.ApplyResources(Me.Label11, "Label11")
        Me.Label11.Name = "Label11"
        Me.ToolTip1.SetToolTip(Me.Label11, resources.GetString("Label11.ToolTip"))
        '
        'tbSettingsSpclPosition1
        '
        Me.tbSettingsSpclPosition1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "MachineSpclPosition1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsSpclPosition1, "tbSettingsSpclPosition1")
        Me.tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1"
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
        resources.ApplyResources(Me.gbSettingsJogging, "gbSettingsJogging")
        Me.gbSettingsJogging.Name = "gbSettingsJogging"
        Me.gbSettingsJogging.TabStop = false
        '
        'cbSettingsKeyboardJogging
        '
        resources.ApplyResources(Me.cbSettingsKeyboardJogging, "cbSettingsKeyboardJogging")
        Me.cbSettingsKeyboardJogging.Checked = Global.GrblPanel.My.MySettings.Default.JoggingUseKeyboard
        Me.cbSettingsKeyboardJogging.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "JoggingUseKeyboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging"
        Me.ToolTip1.SetToolTip(Me.cbSettingsKeyboardJogging, resources.GetString("cbSettingsKeyboardJogging.ToolTip"))
        Me.cbSettingsKeyboardJogging.UseVisualStyleBackColor = true
        '
        'btnSettingsRefreshJogging
        '
        resources.ApplyResources(Me.btnSettingsRefreshJogging, "btnSettingsRefreshJogging")
        Me.btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging"
        Me.btnSettingsRefreshJogging.Tag = "Jogging"
        Me.btnSettingsRefreshJogging.UseVisualStyleBackColor = true
        '
        'Label41
        '
        resources.ApplyResources(Me.Label41, "Label41")
        Me.Label41.Name = "Label41"
        '
        'Label40
        '
        resources.ApplyResources(Me.Label40, "Label40")
        Me.Label40.Name = "Label40"
        '
        'Label39
        '
        resources.ApplyResources(Me.Label39, "Label39")
        Me.Label39.Name = "Label39"
        '
        'Label38
        '
        resources.ApplyResources(Me.Label38, "Label38")
        Me.Label38.Name = "Label38"
        '
        'tbSettingsZRepeat
        '
        Me.tbSettingsZRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingZRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsZRepeat, "tbSettingsZRepeat")
        Me.tbSettingsZRepeat.Name = "tbSettingsZRepeat"
        Me.tbSettingsZRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingZRepeat
        '
        'tbSettingsYRepeat
        '
        Me.tbSettingsYRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingYRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsYRepeat, "tbSettingsYRepeat")
        Me.tbSettingsYRepeat.Name = "tbSettingsYRepeat"
        Me.tbSettingsYRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingYRepeat
        '
        'tbSettingsXRepeat
        '
        Me.tbSettingsXRepeat.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingXRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsXRepeat, "tbSettingsXRepeat")
        Me.tbSettingsXRepeat.Name = "tbSettingsXRepeat"
        Me.tbSettingsXRepeat.Text = Global.GrblPanel.My.MySettings.Default.JoggingXRepeat
        '
        'Label35
        '
        resources.ApplyResources(Me.Label35, "Label35")
        Me.Label35.Name = "Label35"
        '
        'Label34
        '
        resources.ApplyResources(Me.Label34, "Label34")
        Me.Label34.Name = "Label34"
        '
        'Label32
        '
        resources.ApplyResources(Me.Label32, "Label32")
        Me.Label32.Name = "Label32"
        '
        'tbSettingsFRMetric
        '
        Me.tbSettingsFRMetric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFRMetric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFRMetric, "tbSettingsFRMetric")
        Me.tbSettingsFRMetric.Name = "tbSettingsFRMetric"
        Me.tbSettingsFRMetric.Text = Global.GrblPanel.My.MySettings.Default.JoggingFRMetric
        '
        'Label33
        '
        resources.ApplyResources(Me.Label33, "Label33")
        Me.Label33.Name = "Label33"
        '
        'tbSettingsFIMetric
        '
        Me.tbSettingsFIMetric.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFIMEtric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFIMetric, "tbSettingsFIMetric")
        Me.tbSettingsFIMetric.Name = "tbSettingsFIMetric"
        Me.tbSettingsFIMetric.Text = Global.GrblPanel.My.MySettings.Default.JoggingFIMEtric
        '
        'Label31
        '
        resources.ApplyResources(Me.Label31, "Label31")
        Me.Label31.Name = "Label31"
        '
        'tbSettingsFRImperial
        '
        Me.tbSettingsFRImperial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFRImperial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFRImperial, "tbSettingsFRImperial")
        Me.tbSettingsFRImperial.Name = "tbSettingsFRImperial"
        Me.tbSettingsFRImperial.Text = Global.GrblPanel.My.MySettings.Default.JoggingFRImperial
        '
        'Label30
        '
        resources.ApplyResources(Me.Label30, "Label30")
        Me.Label30.Name = "Label30"
        '
        'cbSettingsMetric
        '
        resources.ApplyResources(Me.cbSettingsMetric, "cbSettingsMetric")
        Me.cbSettingsMetric.Checked = Global.GrblPanel.My.MySettings.Default.JoggingUnitsMetric
        Me.cbSettingsMetric.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.GrblPanel.My.MySettings.Default, "joggingUnitsMetric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cbSettingsMetric.Name = "cbSettingsMetric"
        Me.cbSettingsMetric.UseVisualStyleBackColor = true
        '
        'tbSettingsFIImperial
        '
        Me.tbSettingsFIImperial.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.GrblPanel.My.MySettings.Default, "JoggingFIImperial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        resources.ApplyResources(Me.tbSettingsFIImperial, "tbSettingsFIImperial")
        Me.tbSettingsFIImperial.Name = "tbSettingsFIImperial"
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
        resources.ApplyResources(Me.TabPage1, "TabPage1")
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = true
        '
        'gbEditor
        '
        Me.gbEditor.Controls.Add(Me.btnAdd)
        Me.gbEditor.Controls.Add(Me.lblGCode)
        Me.gbEditor.Controls.Add(Me.tbGCode)
        Me.gbEditor.Controls.Add(Me.lblName)
        Me.gbEditor.Controls.Add(Me.tbName)
        resources.ApplyResources(Me.gbEditor, "gbEditor")
        Me.gbEditor.Name = "gbEditor"
        Me.gbEditor.TabStop = false
        '
        'btnAdd
        '
        resources.ApplyResources(Me.btnAdd, "btnAdd")
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.UseVisualStyleBackColor = true
        '
        'lblGCode
        '
        resources.ApplyResources(Me.lblGCode, "lblGCode")
        Me.lblGCode.Name = "lblGCode"
        '
        'tbGCode
        '
        Me.tbGCode.AcceptsReturn = true
        resources.ApplyResources(Me.tbGCode, "tbGCode")
        Me.tbGCode.Name = "tbGCode"
        '
        'lblName
        '
        resources.ApplyResources(Me.lblName, "lblName")
        Me.lblName.Name = "lblName"
        '
        'tbName
        '
        resources.ApplyResources(Me.tbName, "tbName")
        Me.tbName.Name = "tbName"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.btnCancel, "btnCancel")
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.UseVisualStyleBackColor = true
        '
        'btnOK
        '
        resources.ApplyResources(Me.btnOK, "btnOK")
        Me.btnOK.Name = "btnOK"
        Me.btnOK.UseVisualStyleBackColor = true
        '
        'dgMacros
        '
        Me.dgMacros.AllowUserToAddRows = false
        Me.dgMacros.AllowUserToDeleteRows = false
        Me.dgMacros.AllowUserToResizeColumns = false
        Me.dgMacros.AllowUserToResizeRows = false
        Me.dgMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgMacros.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgMacros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        resources.ApplyResources(Me.dgMacros, "dgMacros")
        Me.dgMacros.Name = "dgMacros"
        Me.dgMacros.ReadOnly = true
        Me.dgMacros.RowHeadersVisible = false
        Me.dgMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = true
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = true
        '
        'lblStatusLabel
        '
        resources.ApplyResources(Me.lblStatusLabel, "lblStatusLabel")
        Me.lblStatusLabel.Name = "lblStatusLabel"
        '
        'btnDeleteMacro
        '
        resources.ApplyResources(Me.btnDeleteMacro, "btnDeleteMacro")
        Me.btnDeleteMacro.Name = "btnDeleteMacro"
        Me.btnDeleteMacro.UseVisualStyleBackColor = true
        '
        'ofdGcodeFile
        '
        Me.ofdGcodeFile.DefaultExt = "ngc"
        Me.ofdGcodeFile.FileName = "*.*"
        resources.ApplyResources(Me.ofdGcodeFile, "ofdGcodeFile")
        '
        'sfdOffsets
        '
        Me.sfdOffsets.DefaultExt = "xml"
        resources.ApplyResources(Me.sfdOffsets, "sfdOffsets")
        '
        'ofdOffsets
        '
        Me.ofdOffsets.DefaultExt = "xml"
        Me.ofdOffsets.FileName = "OpenFileDialog1"
        resources.ApplyResources(Me.ofdOffsets, "ofdOffsets")
        '
        'GrblGui
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimizeBox = false
        Me.Name = "GrblGui"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.MenuStrip1.ResumeLayout(false)
        Me.MenuStrip1.PerformLayout
        Me.TabControl1.ResumeLayout(false)
        Me.tabPgInterface.ResumeLayout(false)
        Me.gbOverrides.ResumeLayout(false)
        Me.gbOverrides.PerformLayout
        Me.gbState.ResumeLayout(false)
        Me.gbPinStatus.ResumeLayout(false)
        Me.gbPinStatus.PerformLayout
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        Me.Panel1.ResumeLayout(false)
        Me.Panel1.PerformLayout
        Me.gbControl.ResumeLayout(false)
        Me.gbControl.PerformLayout
        Me.gbMDI.ResumeLayout(false)
        Me.gbMDI.PerformLayout
        Me.gbJogging.ResumeLayout(false)
        Me.gbJogging.PerformLayout
        Me.gbFeedRate.ResumeLayout(false)
        Me.gbFeedRate.PerformLayout
        Me.gbDistance.ResumeLayout(false)
        Me.gbDistance.PerformLayout
        Me.gbStatus.ResumeLayout(false)
        Me.gbStatus.PerformLayout
        Me.gbGcode.ResumeLayout(false)
        Me.gbGcode.PerformLayout
        CType(Me.dgvGcode,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbGrbl.ResumeLayout(false)
        Me.tcConnection.ResumeLayout(false)
        Me.tbGrblCOM.ResumeLayout(false)
        Me.tbGrblIP.ResumeLayout(false)
        Me.tbGrblIP.PerformLayout
        Me.gbPosition.ResumeLayout(false)
        Me.tabCtlPosition.ResumeLayout(false)
        Me.tpWork.ResumeLayout(false)
        Me.tpWork.PerformLayout
        Me.Panel5.ResumeLayout(false)
        Me.Panel5.PerformLayout
        Me.Panel4.ResumeLayout(false)
        Me.Panel4.PerformLayout
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.tpOffsets.ResumeLayout(false)
        Me.tpOffsets.PerformLayout
        Me.tabPgSettings.ResumeLayout(false)
        Me.tabPgSettings.PerformLayout
        Me.gbGrblSettings.ResumeLayout(false)
        Me.gbGrblSettings.PerformLayout
        CType(Me.dgGrblSettings,System.ComponentModel.ISupportInitialize).EndInit
        Me.gbSettingsOffsets.ResumeLayout(false)
        Me.gbSettingsOffsets.PerformLayout
        Me.gbSettingsMisc.ResumeLayout(false)
        Me.gbSettingsMisc.PerformLayout
        Me.gbSettingsPosition.ResumeLayout(false)
        Me.gbSettingsPosition.PerformLayout
        Me.gbSettingsJogging.ResumeLayout(false)
        Me.gbSettingsJogging.PerformLayout
        Me.TabPage1.ResumeLayout(false)
        Me.gbEditor.ResumeLayout(false)
        Me.gbEditor.PerformLayout
        CType(Me.dgMacros,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.GrblSettingsBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

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
    Friend WithEvents cbStatusPollEnable As System.Windows.Forms.CheckBox
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
    Friend WithEvents tbOffsetsG55Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG55Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG55X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG56Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG56Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG56Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG56X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG57Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG57Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG57Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG57X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG58Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG58Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG58Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG58X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG59Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG59Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG59Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG59X As System.Windows.Forms.TextBox
    Friend WithEvents btnOffsetsG54Zero As System.Windows.Forms.Button
    Friend WithEvents tbOffsetsG54Z As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG54Y As System.Windows.Forms.TextBox
    Friend WithEvents tbOffsetsG54X As System.Windows.Forms.TextBox
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
    Friend WithEvents btnStatusClearPins As System.Windows.Forms.Button
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
    Friend WithEvents gbOverrides As GroupBox
    Friend WithEvents Label46 As Label
    Friend WithEvents btnFeedMinus As Button
    Friend WithEvents btnFeedPlus As Button
    Friend WithEvents btnSetOffsetG59 As Button
    Friend WithEvents btnSetOffsetG58 As Button
    Friend WithEvents btnSetOffsetG57 As Button
    Friend WithEvents btnSetOffsetG56 As Button
    Friend WithEvents btnSetOffsetG55 As Button
    Friend WithEvents btnSetOffsetG54 As Button
    Friend WithEvents dgvGcode As DataGridView
    Friend WithEvents tbSpindleOvr As TextBox
    Friend WithEvents tbRapidOvr As TextBox
    Friend WithEvents tbFeedOvr As TextBox
    Friend WithEvents Label44 As Label
    Friend WithEvents btnSpindleMinus As Button
    Friend WithEvents btnSpindlePlus As Button
    Friend WithEvents Label22 As Label
    Friend WithEvents btnRapidMinus As Button
    Friend WithEvents btnRapidPlus As Button
    Friend WithEvents btnFeedOverrideReset As Button
    Friend WithEvents cbFeedCoarse As CheckBox
    Friend WithEvents btnSpindleOverrideReset As Button
    Friend WithEvents btnRapidOverrideReset As Button
    Friend WithEvents cbSpindleCoarse As CheckBox
    Friend WithEvents cbStartResume As CheckBox
    Friend WithEvents cbFeedHold As CheckBox
    Friend WithEvents cbResetAbort As CheckBox
    Friend WithEvents cbDoorOpen As CheckBox
    Friend WithEvents cbProbePin As CheckBox
    Friend WithEvents cbLimitZ As CheckBox
    Friend WithEvents cbLimitY As CheckBox
    Friend WithEvents cbLimitX As CheckBox
    Friend WithEvents gbPinStatus As GroupBox
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents lblCurrentLine As Label
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents lineNum As DataGridViewTextBoxColumn
    Friend WithEvents data As DataGridViewTextBoxColumn
    Friend WithEvents cbMonitorEnable As CheckBox
    Friend WithEvents btnMistOverride As Button
    Friend WithEvents btnFloodOverride As Button
    Friend WithEvents btnSpindleOverride As Button
End Class
