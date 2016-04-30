using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.Linq;
using System.Xml.Linq;
namespace GrblPanel
{
	[Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]
	partial class GrblGui : System.Windows.Forms.Form
	{

		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]
		protected override void Dispose(bool disposing)
		{
			try {
				if (disposing && components != null) {
					components.Dispose();
				}
			} finally {
				base.Dispose(disposing);
			}
		}

		//Required by the Windows Form Designer

		private System.ComponentModel.IContainer components;
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.  
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GrblGui));
			this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
			this.ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.SaveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.OptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.HelpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.TabControl1 = new System.Windows.Forms.TabControl();
			this.tabPgInterface = new System.Windows.Forms.TabPage();
			this.GroupBox2 = new System.Windows.Forms.GroupBox();
			this.Button1 = new System.Windows.Forms.Button();
			this.Label46 = new System.Windows.Forms.Label();
			this.Label44 = new System.Windows.Forms.Label();
			this.btnFeedFineMinus = new System.Windows.Forms.Button();
			this.btnFeedFinePlus = new System.Windows.Forms.Button();
			this.Label22 = new System.Windows.Forms.Label();
			this.btnFeedCoarseMinus = new System.Windows.Forms.Button();
			this.btnFeedCoarsePlus = new System.Windows.Forms.Button();
			this.gbState = new System.Windows.Forms.GroupBox();
			this.Panel2 = new System.Windows.Forms.Panel();
			this.tbStateFeedRate = new System.Windows.Forms.TextBox();
			this.Label14 = new System.Windows.Forms.Label();
			this.tbStateTool = new System.Windows.Forms.TextBox();
			this.Label53 = new System.Windows.Forms.Label();
			this.Label50 = new System.Windows.Forms.Label();
			this.tbStateSpindleRPM = new System.Windows.Forms.TextBox();
			this.Panel1 = new System.Windows.Forms.Panel();
			this.cbxStateFeedMode = new System.Windows.Forms.ComboBox();
			this.cbxStateDistance = new System.Windows.Forms.ComboBox();
			this.Label16 = new System.Windows.Forms.Label();
			this.cbxStateUnits = new System.Windows.Forms.ComboBox();
			this.Label123 = new System.Windows.Forms.Label();
			this.Lalbel49 = new System.Windows.Forms.Label();
			this.cbxStatePlane = new System.Windows.Forms.ComboBox();
			this.Label47 = new System.Windows.Forms.Label();
			this.Label15 = new System.Windows.Forms.Label();
			this.cbxStateOffset = new System.Windows.Forms.ComboBox();
			this.cbxStateCoolant = new System.Windows.Forms.ComboBox();
			this.Label45 = new System.Windows.Forms.Label();
			this.Label17 = new System.Windows.Forms.Label();
			this.cbxStateSpindle = new System.Windows.Forms.ComboBox();
			this.btnStatusGetParser = new System.Windows.Forms.Button();
			this.gbControl = new System.Windows.Forms.GroupBox();
			this.btnCheckMode = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnHold = new System.Windows.Forms.Button();
			this.btnStartResume = new System.Windows.Forms.Button();
			this.btnUnlock = new System.Windows.Forms.Button();
			this.gbMDI = new System.Windows.Forms.GroupBox();
			this.Label9 = new System.Windows.Forms.Label();
			this.btnSend = new System.Windows.Forms.Button();
			this.tbSendData = new System.Windows.Forms.TextBox();
			this.gbJogging = new System.Windows.Forms.GroupBox();
			this.btnZMinus = new RepeatButton.RepeatButton();
			this.btnZPlus = new RepeatButton.RepeatButton();
			this.btnXPlus = new RepeatButton.RepeatButton();
			this.btnYMinus = new RepeatButton.RepeatButton();
			this.btnXMinus = new RepeatButton.RepeatButton();
			this.btnYPlus = new RepeatButton.RepeatButton();
			this.gbFeedRate = new System.Windows.Forms.GroupBox();
			this.rbFeedRate1 = new System.Windows.Forms.RadioButton();
			this.rbFeedRate2 = new System.Windows.Forms.RadioButton();
			this.rbFeedRate3 = new System.Windows.Forms.RadioButton();
			this.rbFeedRate4 = new System.Windows.Forms.RadioButton();
			this.gbDistance = new System.Windows.Forms.GroupBox();
			this.rbDistance1 = new System.Windows.Forms.RadioButton();
			this.rbDistance2 = new System.Windows.Forms.RadioButton();
			this.rbDistance3 = new System.Windows.Forms.RadioButton();
			this.rbDistance4 = new System.Windows.Forms.RadioButton();
			this.cbUnits = new System.Windows.Forms.CheckBox();
			this.gbStatus = new System.Windows.Forms.GroupBox();
			this.Label25 = new System.Windows.Forms.Label();
			this.tbCurrentStatus = new System.Windows.Forms.TextBox();
			this.Label24 = new System.Windows.Forms.Label();
			this.prgbRxBuf = new System.Windows.Forms.ProgressBar();
			this.prgBarQ = new System.Windows.Forms.ProgressBar();
			this.cbVerbose = new System.Windows.Forms.CheckBox();
			this.lbResponses = new System.Windows.Forms.ListBox();
			this.gbGcode = new System.Windows.Forms.GroupBox();
			this.dgvGcode = new System.Windows.Forms.DataGridView();
			this.stat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lineNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.data = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnFileReload = new System.Windows.Forms.Button();
			this.tbGCodeMessage = new System.Windows.Forms.TextBox();
			this.Label27 = new System.Windows.Forms.Label();
			this.lblTotalLines = new System.Windows.Forms.Label();
			this.Label23 = new System.Windows.Forms.Label();
			this.btnFilePause = new System.Windows.Forms.Button();
			this.tbGcodeFile = new System.Windows.Forms.TextBox();
			this.btnFileSelect = new System.Windows.Forms.Button();
			this.btnFileSend = new System.Windows.Forms.Button();
			this.btnFileStop = new System.Windows.Forms.Button();
			this.gbGrbl = new System.Windows.Forms.GroupBox();
			this.tcConnection = new System.Windows.Forms.TabControl();
			this.tbGrblCOM = new System.Windows.Forms.TabPage();
			this.btnRescanPorts = new System.Windows.Forms.Button();
			this.cbPorts = new System.Windows.Forms.ComboBox();
			this.btnConnect = new System.Windows.Forms.Button();
			this.cbBaud = new System.Windows.Forms.ComboBox();
			this.tbGrblIP = new System.Windows.Forms.TabPage();
			this.btnIPConnect = new System.Windows.Forms.Button();
			this.tbIPAddress = new System.Windows.Forms.TextBox();
			this.gbPosition = new System.Windows.Forms.GroupBox();
			this.tabCtlPosition = new System.Windows.Forms.TabControl();
			this.tpWork = new System.Windows.Forms.TabPage();
			this.Panel5 = new System.Windows.Forms.Panel();
			this.tbWorkZ = new System.Windows.Forms.TextBox();
			this.tbMachZ = new System.Windows.Forms.TextBox();
			this.Panel4 = new System.Windows.Forms.Panel();
			this.tbWorkY = new System.Windows.Forms.TextBox();
			this.tbMachY = new System.Windows.Forms.TextBox();
			this.Panel3 = new System.Windows.Forms.Panel();
			this.tbMachX = new System.Windows.Forms.TextBox();
			this.tbWorkX = new System.Windows.Forms.TextBox();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.lblPositionCurrentOffset = new System.Windows.Forms.Label();
			this.btnWorkSoftHome = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.btnWorkSpclPosition = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.btnWork0 = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.btnWorkX0 = new System.Windows.Forms.Button();
			this.Label1 = new System.Windows.Forms.Label();
			this.btnWorkZ0 = new System.Windows.Forms.Button();
			this.btnWorkY0 = new System.Windows.Forms.Button();
			this.tpOffsets = new System.Windows.Forms.TabPage();
			this.btnSetOffsetG59 = new System.Windows.Forms.Button();
			this.btnSetOffsetG58 = new System.Windows.Forms.Button();
			this.btnSetOffsetG57 = new System.Windows.Forms.Button();
			this.btnSetOffsetG56 = new System.Windows.Forms.Button();
			this.btnSetOffsetG55 = new System.Windows.Forms.Button();
			this.btnSetOffsetG54 = new System.Windows.Forms.Button();
			this.Label10 = new System.Windows.Forms.Label();
			this.Label71 = new System.Windows.Forms.Label();
			this.tbOffSetsMachZ = new System.Windows.Forms.TextBox();
			this.Label19 = new System.Windows.Forms.Label();
			this.tbOffsetsG56Y = new System.Windows.Forms.TextBox();
			this.tbOffSetsMachY = new System.Windows.Forms.TextBox();
			this.tbOffsetsG56X = new System.Windows.Forms.TextBox();
			this.tbOffsetsG56Z = new System.Windows.Forms.TextBox();
			this.tbOffSetsMachX = new System.Windows.Forms.TextBox();
			this.btnOffsetsG57Zero = new System.Windows.Forms.Button();
			this.tbOffsetsG54X = new System.Windows.Forms.TextBox();
			this.btnOffsetsG56Zero = new System.Windows.Forms.Button();
			this.tbOffsetsG54Y = new System.Windows.Forms.TextBox();
			this.tbOffsetsG57Z = new System.Windows.Forms.TextBox();
			this.btnOffsetsSave = new System.Windows.Forms.Button();
			this.tbOffsetsG55X = new System.Windows.Forms.TextBox();
			this.tbOffsetsG54Z = new System.Windows.Forms.TextBox();
			this.tbOffsetsG57Y = new System.Windows.Forms.TextBox();
			this.btnOffsetsRetrieve = new System.Windows.Forms.Button();
			this.tbOffsetsG55Y = new System.Windows.Forms.TextBox();
			this.btnOffsetsG54Zero = new System.Windows.Forms.Button();
			this.tbOffsetsG57X = new System.Windows.Forms.TextBox();
			this.btnOffsetsLoad = new System.Windows.Forms.Button();
			this.tbOffsetsG55Z = new System.Windows.Forms.TextBox();
			this.tbOffsetsG59X = new System.Windows.Forms.TextBox();
			this.btnOffsetsG58Zero = new System.Windows.Forms.Button();
			this.btnOffsetsG43Zero = new System.Windows.Forms.Button();
			this.tbOffsetsG59Y = new System.Windows.Forms.TextBox();
			this.tbOffsetsG43Z = new System.Windows.Forms.TextBox();
			this.btnOffsetsG55Zero = new System.Windows.Forms.Button();
			this.tbOffsetsG59Z = new System.Windows.Forms.TextBox();
			this.tbOffsetsG58Z = new System.Windows.Forms.TextBox();
			this.Label60 = new System.Windows.Forms.Label();
			this.tbOffsetsG58Y = new System.Windows.Forms.TextBox();
			this.Label20 = new System.Windows.Forms.Label();
			this.Label43 = new System.Windows.Forms.Label();
			this.btnOffsetsG59Zero = new System.Windows.Forms.Button();
			this.tbOffsetsG58X = new System.Windows.Forms.TextBox();
			this.Label21 = new System.Windows.Forms.Label();
			this.tabPgSettings = new System.Windows.Forms.TabPage();
			this.gbGrblSettings = new System.Windows.Forms.GroupBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.tbSettingsGrblLastParam = new System.Windows.Forms.TextBox();
			this.dgGrblSettings = new System.Windows.Forms.DataGridView();
			this.btnSettingsGrbl = new System.Windows.Forms.Button();
			this.gbSettingsOffsets = new System.Windows.Forms.GroupBox();
			this.btnOffsetsG28Set = new System.Windows.Forms.Button();
			this.btnSettingsRetrieveLocations = new System.Windows.Forms.Button();
			this.Label7 = new System.Windows.Forms.Label();
			this.Label18 = new System.Windows.Forms.Label();
			this.tbOffsetsG30Y = new System.Windows.Forms.TextBox();
			this.tbOffsetsG30X = new System.Windows.Forms.TextBox();
			this.tbOffsetsG30Z = new System.Windows.Forms.TextBox();
			this.tbOffsetsG28X = new System.Windows.Forms.TextBox();
			this.btnOffsetsG30Set = new System.Windows.Forms.Button();
			this.tbOffsetsG28Y = new System.Windows.Forms.TextBox();
			this.Label68 = new System.Windows.Forms.Label();
			this.tbOffsetsG28Z = new System.Windows.Forms.TextBox();
			this.Label69 = new System.Windows.Forms.Label();
			this.Label42 = new System.Windows.Forms.Label();
			this.gbSettingsMisc = new System.Windows.Forms.GroupBox();
			this.tbSettingsDefaultExt = new System.Windows.Forms.TextBox();
			this.Label5 = new System.Windows.Forms.Label();
			this.Label6 = new System.Windows.Forms.Label();
			this.tbSettingsStartupDelay = new System.Windows.Forms.TextBox();
			this.cbSettingsLeftHanded = new System.Windows.Forms.CheckBox();
			this.cbSettingsConnectOnLoad = new System.Windows.Forms.CheckBox();
			this.cbSettingsPauseOnError = new System.Windows.Forms.CheckBox();
			this.cbStatusPollEnable = new System.Windows.Forms.CheckBox();
			this.btnSettingsRefreshMisc = new System.Windows.Forms.Button();
			this.Label37 = new System.Windows.Forms.Label();
			this.Label36 = new System.Windows.Forms.Label();
			this.tbSettingsRBuffSize = new System.Windows.Forms.TextBox();
			this.tbSettingsQSize = new System.Windows.Forms.TextBox();
			this.Label26 = new System.Windows.Forms.Label();
			this.tbSettingsPollRate = new System.Windows.Forms.TextBox();
			this.gbSettingsPosition = new System.Windows.Forms.GroupBox();
			this.Label8 = new System.Windows.Forms.Label();
			this.tbSettingsSpclPosition2 = new System.Windows.Forms.TextBox();
			this.btnSettingsRefreshPosition = new System.Windows.Forms.Button();
			this.Label29 = new System.Windows.Forms.Label();
			this.tbWorkZ0Cmd = new System.Windows.Forms.TextBox();
			this.Label28 = new System.Windows.Forms.Label();
			this.tbWorkY0Cmd = new System.Windows.Forms.TextBox();
			this.Label13 = new System.Windows.Forms.Label();
			this.Label12 = new System.Windows.Forms.Label();
			this.tbWorkX0Cmd = new System.Windows.Forms.TextBox();
			this.tbSettingsZeroXYZCmd = new System.Windows.Forms.TextBox();
			this.Label11 = new System.Windows.Forms.Label();
			this.tbSettingsSpclPosition1 = new System.Windows.Forms.TextBox();
			this.gbSettingsJogging = new System.Windows.Forms.GroupBox();
			this.cbSettingsKeyboardJogging = new System.Windows.Forms.CheckBox();
			this.btnSettingsRefreshJogging = new System.Windows.Forms.Button();
			this.Label41 = new System.Windows.Forms.Label();
			this.Label40 = new System.Windows.Forms.Label();
			this.Label39 = new System.Windows.Forms.Label();
			this.Label38 = new System.Windows.Forms.Label();
			this.tbSettingsZRepeat = new System.Windows.Forms.TextBox();
			this.tbSettingsYRepeat = new System.Windows.Forms.TextBox();
			this.tbSettingsXRepeat = new System.Windows.Forms.TextBox();
			this.Label35 = new System.Windows.Forms.Label();
			this.Label34 = new System.Windows.Forms.Label();
			this.Label32 = new System.Windows.Forms.Label();
			this.tbSettingsFRMetric = new System.Windows.Forms.TextBox();
			this.Label33 = new System.Windows.Forms.Label();
			this.tbSettingsFIMetric = new System.Windows.Forms.TextBox();
			this.Label31 = new System.Windows.Forms.Label();
			this.tbSettingsFRImperial = new System.Windows.Forms.TextBox();
			this.Label30 = new System.Windows.Forms.Label();
			this.cbSettingsMetric = new System.Windows.Forms.CheckBox();
			this.tbSettingsFIImperial = new System.Windows.Forms.TextBox();
			this.TabPage1 = new System.Windows.Forms.TabPage();
			this.gbEditor = new System.Windows.Forms.GroupBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.lblGCode = new System.Windows.Forms.Label();
			this.tbGCode = new System.Windows.Forms.TextBox();
			this.lblName = new System.Windows.Forms.Label();
			this.tbName = new System.Windows.Forms.TextBox();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnOK = new System.Windows.Forms.Button();
			this.dgMacros = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lblStatusLabel = new System.Windows.Forms.Label();
			this.btnDeleteMacro = new System.Windows.Forms.Button();
			this.ofdGcodeFile = new System.Windows.Forms.OpenFileDialog();
			this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
			this.sfdOffsets = new System.Windows.Forms.SaveFileDialog();
			this.ofdOffsets = new System.Windows.Forms.OpenFileDialog();
			this.GrblSettingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.MenuStrip1.SuspendLayout();
			this.TabControl1.SuspendLayout();
			this.tabPgInterface.SuspendLayout();
			this.GroupBox2.SuspendLayout();
			this.gbState.SuspendLayout();
			this.Panel2.SuspendLayout();
			this.Panel1.SuspendLayout();
			this.gbControl.SuspendLayout();
			this.gbMDI.SuspendLayout();
			this.gbJogging.SuspendLayout();
			this.gbFeedRate.SuspendLayout();
			this.gbDistance.SuspendLayout();
			this.gbStatus.SuspendLayout();
			this.gbGcode.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvGcode).BeginInit();
			this.gbGrbl.SuspendLayout();
			this.tcConnection.SuspendLayout();
			this.tbGrblCOM.SuspendLayout();
			this.tbGrblIP.SuspendLayout();
			this.gbPosition.SuspendLayout();
			this.tabCtlPosition.SuspendLayout();
			this.tpWork.SuspendLayout();
			this.Panel5.SuspendLayout();
			this.Panel4.SuspendLayout();
			this.Panel3.SuspendLayout();
			this.GroupBox1.SuspendLayout();
			this.tpOffsets.SuspendLayout();
			this.tabPgSettings.SuspendLayout();
			this.gbGrblSettings.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgGrblSettings).BeginInit();
			this.gbSettingsOffsets.SuspendLayout();
			this.gbSettingsMisc.SuspendLayout();
			this.gbSettingsPosition.SuspendLayout();
			this.gbSettingsJogging.SuspendLayout();
			this.TabPage1.SuspendLayout();
			this.gbEditor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)this.dgMacros).BeginInit();
			((System.ComponentModel.ISupportInitialize)this.GrblSettingsBindingSource).BeginInit();
			this.SuspendLayout();
			//
			//MenuStrip1
			//
			this.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
			this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.ToolStripMenuItem1,
				this.ToolsToolStripMenuItem,
				this.HelpToolStripMenuItem
			});
			this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
			this.MenuStrip1.Name = "MenuStrip1";
			this.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
			this.MenuStrip1.Size = new System.Drawing.Size(1143, 24);
			this.MenuStrip1.TabIndex = 0;
			this.MenuStrip1.Text = "MenuStrip1";
			//
			//ToolStripMenuItem1
			//
			this.ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
				this.SaveToolStripMenuItem,
				this.ExitToolStripMenuItem
			});
			this.ToolStripMenuItem1.Name = "ToolStripMenuItem1";
			this.ToolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
			this.ToolStripMenuItem1.Text = "File";
			//
			//SaveToolStripMenuItem
			//
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.SaveToolStripMenuItem.Text = "Save";
			this.SaveToolStripMenuItem.Visible = false;
			//
			//ExitToolStripMenuItem
			//
			this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
			this.ExitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.ExitToolStripMenuItem.Text = "Exit";
			//
			//ToolsToolStripMenuItem
			//
			this.ToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.OptionsToolStripMenuItem });
			this.ToolsToolStripMenuItem.Name = "ToolsToolStripMenuItem";
			this.ToolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
			this.ToolsToolStripMenuItem.Text = "Tools";
			//
			//OptionsToolStripMenuItem
			//
			this.OptionsToolStripMenuItem.Name = "OptionsToolStripMenuItem";
			this.OptionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
			this.OptionsToolStripMenuItem.Text = "Options";
			//
			//HelpToolStripMenuItem
			//
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.AboutToolStripMenuItem });
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.HelpToolStripMenuItem.Text = "Help";
			//
			//AboutToolStripMenuItem
			//
			this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
			this.AboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.AboutToolStripMenuItem.Text = "About";
			//
			//TabControl1
			//
			this.TabControl1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.TabControl1.Controls.Add(this.tabPgInterface);
			this.TabControl1.Controls.Add(this.tabPgSettings);
			this.TabControl1.Controls.Add(this.TabPage1);
			this.TabControl1.Location = new System.Drawing.Point(0, 24);
			this.TabControl1.Name = "TabControl1";
			this.TabControl1.SelectedIndex = 0;
			this.TabControl1.Size = new System.Drawing.Size(1142, 703);
			this.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
			this.TabControl1.TabIndex = 1;
			//
			//tabPgInterface
			//
			this.tabPgInterface.Controls.Add(this.GroupBox2);
			this.tabPgInterface.Controls.Add(this.gbState);
			this.tabPgInterface.Controls.Add(this.gbControl);
			this.tabPgInterface.Controls.Add(this.gbMDI);
			this.tabPgInterface.Controls.Add(this.gbJogging);
			this.tabPgInterface.Controls.Add(this.gbStatus);
			this.tabPgInterface.Controls.Add(this.gbGcode);
			this.tabPgInterface.Controls.Add(this.gbGrbl);
			this.tabPgInterface.Controls.Add(this.gbPosition);
			this.tabPgInterface.Location = new System.Drawing.Point(4, 22);
			this.tabPgInterface.Name = "tabPgInterface";
			this.tabPgInterface.Padding = new System.Windows.Forms.Padding(3);
			this.tabPgInterface.Size = new System.Drawing.Size(1134, 677);
			this.tabPgInterface.TabIndex = 0;
			this.tabPgInterface.Text = "Interface";
			this.tabPgInterface.UseVisualStyleBackColor = true;
			//
			//GroupBox2
			//
			this.GroupBox2.Controls.Add(this.Button1);
			this.GroupBox2.Controls.Add(this.Label46);
			this.GroupBox2.Controls.Add(this.Label44);
			this.GroupBox2.Controls.Add(this.btnFeedFineMinus);
			this.GroupBox2.Controls.Add(this.btnFeedFinePlus);
			this.GroupBox2.Controls.Add(this.Label22);
			this.GroupBox2.Controls.Add(this.btnFeedCoarseMinus);
			this.GroupBox2.Controls.Add(this.btnFeedCoarsePlus);
			this.GroupBox2.Location = new System.Drawing.Point(939, 412);
			this.GroupBox2.Name = "GroupBox2";
			this.GroupBox2.Size = new System.Drawing.Size(190, 197);
			this.GroupBox2.TabIndex = 37;
			this.GroupBox2.TabStop = false;
			this.GroupBox2.Text = "Overrides";
			this.GroupBox2.Visible = false;
			//
			//Button1
			//
			this.Button1.Location = new System.Drawing.Point(6, 108);
			this.Button1.Name = "Button1";
			this.Button1.Size = new System.Drawing.Size(75, 23);
			this.Button1.TabIndex = 7;
			this.Button1.Text = "Get OVR Status";
			this.Button1.UseVisualStyleBackColor = true;
			//
			//Label46
			//
			this.Label46.AutoSize = true;
			this.Label46.Location = new System.Drawing.Point(12, 43);
			this.Label46.Name = "Label46";
			this.Label46.Size = new System.Drawing.Size(31, 13);
			this.Label46.TabIndex = 6;
			this.Label46.Text = "Feed";
			//
			//Label44
			//
			this.Label44.AutoSize = true;
			this.Label44.Location = new System.Drawing.Point(110, 16);
			this.Label44.Name = "Label44";
			this.Label44.Size = new System.Drawing.Size(27, 13);
			this.Label44.TabIndex = 5;
			this.Label44.Text = "Fine";
			//
			//btnFeedFineMinus
			//
			this.btnFeedFineMinus.Location = new System.Drawing.Point(113, 58);
			this.btnFeedFineMinus.Name = "btnFeedFineMinus";
			this.btnFeedFineMinus.Size = new System.Drawing.Size(35, 23);
			this.btnFeedFineMinus.TabIndex = 4;
			this.btnFeedFineMinus.Tag = "Fine";
			this.btnFeedFineMinus.Text = "-";
			this.btnFeedFineMinus.UseVisualStyleBackColor = true;
			//
			//btnFeedFinePlus
			//
			this.btnFeedFinePlus.Location = new System.Drawing.Point(113, 21);
			this.btnFeedFinePlus.Name = "btnFeedFinePlus";
			this.btnFeedFinePlus.Size = new System.Drawing.Size(35, 23);
			this.btnFeedFinePlus.TabIndex = 3;
			this.btnFeedFinePlus.Tag = "Fine";
			this.btnFeedFinePlus.Text = "+";
			this.btnFeedFinePlus.UseVisualStyleBackColor = true;
			//
			//Label22
			//
			this.Label22.AutoSize = true;
			this.Label22.Location = new System.Drawing.Point(60, 16);
			this.Label22.Name = "Label22";
			this.Label22.Size = new System.Drawing.Size(40, 13);
			this.Label22.TabIndex = 2;
			this.Label22.Text = "Coarse";
			//
			//btnFeedCoarseMinus
			//
			this.btnFeedCoarseMinus.Location = new System.Drawing.Point(63, 58);
			this.btnFeedCoarseMinus.Name = "btnFeedCoarseMinus";
			this.btnFeedCoarseMinus.Size = new System.Drawing.Size(35, 23);
			this.btnFeedCoarseMinus.TabIndex = 1;
			this.btnFeedCoarseMinus.Tag = "Coarse";
			this.btnFeedCoarseMinus.Text = "-";
			this.btnFeedCoarseMinus.UseVisualStyleBackColor = true;
			//
			//btnFeedCoarsePlus
			//
			this.btnFeedCoarsePlus.Location = new System.Drawing.Point(63, 31);
			this.btnFeedCoarsePlus.Name = "btnFeedCoarsePlus";
			this.btnFeedCoarsePlus.Size = new System.Drawing.Size(35, 23);
			this.btnFeedCoarsePlus.TabIndex = 0;
			this.btnFeedCoarsePlus.Tag = "Coarse";
			this.btnFeedCoarsePlus.Text = "+";
			this.btnFeedCoarsePlus.UseVisualStyleBackColor = true;
			//
			//gbState
			//
			this.gbState.Controls.Add(this.Panel2);
			this.gbState.Controls.Add(this.Panel1);
			this.gbState.Controls.Add(this.btnStatusGetParser);
			this.gbState.Location = new System.Drawing.Point(938, 3);
			this.gbState.Name = "gbState";
			this.gbState.Size = new System.Drawing.Size(191, 403);
			this.gbState.TabIndex = 36;
			this.gbState.TabStop = false;
			this.gbState.Text = "State";
			//
			//Panel2
			//
			this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel2.Controls.Add(this.tbStateFeedRate);
			this.Panel2.Controls.Add(this.Label14);
			this.Panel2.Controls.Add(this.tbStateTool);
			this.Panel2.Controls.Add(this.Label53);
			this.Panel2.Controls.Add(this.Label50);
			this.Panel2.Controls.Add(this.tbStateSpindleRPM);
			this.Panel2.Location = new System.Drawing.Point(12, 225);
			this.Panel2.Name = "Panel2";
			this.Panel2.Size = new System.Drawing.Size(169, 100);
			this.Panel2.TabIndex = 38;
			//
			//tbStateFeedRate
			//
			this.tbStateFeedRate.Location = new System.Drawing.Point(3, 17);
			this.tbStateFeedRate.Name = "tbStateFeedRate";
			this.tbStateFeedRate.Size = new System.Drawing.Size(74, 20);
			this.tbStateFeedRate.TabIndex = 22;
			//
			//Label14
			//
			this.Label14.AutoSize = true;
			this.Label14.Location = new System.Drawing.Point(84, 17);
			this.Label14.Name = "Label14";
			this.Label14.Size = new System.Drawing.Size(54, 13);
			this.Label14.TabIndex = 17;
			this.Label14.Text = "FeedRate";
			//
			//tbStateTool
			//
			this.tbStateTool.Location = new System.Drawing.Point(3, 61);
			this.tbStateTool.Name = "tbStateTool";
			this.tbStateTool.Size = new System.Drawing.Size(74, 20);
			this.tbStateTool.TabIndex = 28;
			//
			//Label53
			//
			this.Label53.AutoSize = true;
			this.Label53.Location = new System.Drawing.Point(83, 63);
			this.Label53.Name = "Label53";
			this.Label53.Size = new System.Drawing.Size(28, 13);
			this.Label53.TabIndex = 14;
			this.Label53.Text = "Tool";
			//
			//Label50
			//
			this.Label50.AutoSize = true;
			this.Label50.Location = new System.Drawing.Point(83, 40);
			this.Label50.Name = "Label50";
			this.Label50.Size = new System.Drawing.Size(69, 13);
			this.Label50.TabIndex = 12;
			this.Label50.Text = "Spindle RPM";
			//
			//tbStateSpindleRPM
			//
			this.tbStateSpindleRPM.Location = new System.Drawing.Point(3, 39);
			this.tbStateSpindleRPM.Name = "tbStateSpindleRPM";
			this.tbStateSpindleRPM.Size = new System.Drawing.Size(74, 20);
			this.tbStateSpindleRPM.TabIndex = 27;
			//
			//Panel1
			//
			this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel1.Controls.Add(this.cbxStateFeedMode);
			this.Panel1.Controls.Add(this.cbxStateDistance);
			this.Panel1.Controls.Add(this.Label16);
			this.Panel1.Controls.Add(this.cbxStateUnits);
			this.Panel1.Controls.Add(this.Label123);
			this.Panel1.Controls.Add(this.Lalbel49);
			this.Panel1.Controls.Add(this.cbxStatePlane);
			this.Panel1.Controls.Add(this.Label47);
			this.Panel1.Controls.Add(this.Label15);
			this.Panel1.Controls.Add(this.cbxStateOffset);
			this.Panel1.Controls.Add(this.cbxStateCoolant);
			this.Panel1.Controls.Add(this.Label45);
			this.Panel1.Controls.Add(this.Label17);
			this.Panel1.Controls.Add(this.cbxStateSpindle);
			this.Panel1.Location = new System.Drawing.Point(12, 19);
			this.Panel1.Name = "Panel1";
			this.Panel1.Size = new System.Drawing.Size(169, 196);
			this.Panel1.TabIndex = 37;
			//
			//cbxStateFeedMode
			//
			this.cbxStateFeedMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStateFeedMode.FormattingEnabled = true;
			this.cbxStateFeedMode.Items.AddRange(new object[] {
				"",
				"Unit/Min                  G94",
				"Inverse Time            G93"
			});
			this.cbxStateFeedMode.Location = new System.Drawing.Point(3, 39);
			this.cbxStateFeedMode.Name = "cbxStateFeedMode";
			this.cbxStateFeedMode.Size = new System.Drawing.Size(74, 21);
			this.cbxStateFeedMode.TabIndex = 29;
			//
			//cbxStateDistance
			//
			this.cbxStateDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStateDistance.FormattingEnabled = true;
			this.cbxStateDistance.Items.AddRange(new object[] {
				"",
				"Absolute                                                    G90",
				"Incremental                                               G91"
			});
			this.cbxStateDistance.Location = new System.Drawing.Point(3, 16);
			this.cbxStateDistance.Name = "cbxStateDistance";
			this.cbxStateDistance.Size = new System.Drawing.Size(74, 21);
			this.cbxStateDistance.TabIndex = 20;
			//
			//Label16
			//
			this.Label16.AutoSize = true;
			this.Label16.Location = new System.Drawing.Point(83, 65);
			this.Label16.Name = "Label16";
			this.Label16.Size = new System.Drawing.Size(31, 13);
			this.Label16.TabIndex = 19;
			this.Label16.Text = "Units";
			//
			//cbxStateUnits
			//
			this.cbxStateUnits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStateUnits.FormattingEnabled = true;
			this.cbxStateUnits.Items.AddRange(new object[] {
				"",
				"Metric                                    G21",
				"Inch                                        G20"
			});
			this.cbxStateUnits.Location = new System.Drawing.Point(3, 62);
			this.cbxStateUnits.Name = "cbxStateUnits";
			this.cbxStateUnits.Size = new System.Drawing.Size(74, 21);
			this.cbxStateUnits.TabIndex = 21;
			//
			//Label123
			//
			this.Label123.AutoSize = true;
			this.Label123.Location = new System.Drawing.Point(83, 19);
			this.Label123.Name = "Label123";
			this.Label123.Size = new System.Drawing.Size(79, 13);
			this.Label123.TabIndex = 0;
			this.Label123.Text = "Distance Mode";
			//
			//Lalbel49
			//
			this.Lalbel49.AutoSize = true;
			this.Lalbel49.Location = new System.Drawing.Point(83, 157);
			this.Lalbel49.Name = "Lalbel49";
			this.Lalbel49.Size = new System.Drawing.Size(67, 13);
			this.Lalbel49.TabIndex = 10;
			this.Lalbel49.Text = "Active Plane";
			//
			//cbxStatePlane
			//
			this.cbxStatePlane.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStatePlane.FormattingEnabled = true;
			this.cbxStatePlane.Items.AddRange(new object[] {
				"",
				"XY                                G17",
				"YZ                                G18",
				"XZ                                G19"
			});
			this.cbxStatePlane.Location = new System.Drawing.Point(3, 154);
			this.cbxStatePlane.Name = "cbxStatePlane";
			this.cbxStatePlane.Size = new System.Drawing.Size(74, 21);
			this.cbxStatePlane.TabIndex = 26;
			//
			//Label47
			//
			this.Label47.AutoSize = true;
			this.Label47.Location = new System.Drawing.Point(83, 134);
			this.Label47.Name = "Label47";
			this.Label47.Size = new System.Drawing.Size(43, 13);
			this.Label47.TabIndex = 8;
			this.Label47.Text = "Coolant";
			//
			//Label15
			//
			this.Label15.AutoSize = true;
			this.Label15.Location = new System.Drawing.Point(83, 88);
			this.Label15.Name = "Label15";
			this.Label15.Size = new System.Drawing.Size(64, 13);
			this.Label15.TabIndex = 2;
			this.Label15.Text = "Work Offset";
			//
			//cbxStateOffset
			//
			this.cbxStateOffset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStateOffset.FormattingEnabled = true;
			this.cbxStateOffset.Items.AddRange(new object[] {
				"",
				"G54                                   G54",
				"G55                                   G55",
				"G56                                   G56",
				"G57                                   G57",
				"G58                                   G58",
				"G59                                   G59"
			});
			this.cbxStateOffset.Location = new System.Drawing.Point(3, 85);
			this.cbxStateOffset.Name = "cbxStateOffset";
			this.cbxStateOffset.Size = new System.Drawing.Size(74, 21);
			this.cbxStateOffset.TabIndex = 23;
			//
			//cbxStateCoolant
			//
			this.cbxStateCoolant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStateCoolant.FormattingEnabled = true;
			this.cbxStateCoolant.Items.AddRange(new object[] {
				"",
				"On                                       M8",
				"Off                                       M9"
			});
			this.cbxStateCoolant.Location = new System.Drawing.Point(3, 131);
			this.cbxStateCoolant.Name = "cbxStateCoolant";
			this.cbxStateCoolant.Size = new System.Drawing.Size(74, 21);
			this.cbxStateCoolant.TabIndex = 25;
			//
			//Label45
			//
			this.Label45.AutoSize = true;
			this.Label45.Location = new System.Drawing.Point(84, 111);
			this.Label45.Name = "Label45";
			this.Label45.Size = new System.Drawing.Size(42, 13);
			this.Label45.TabIndex = 6;
			this.Label45.Text = "Spindle";
			//
			//Label17
			//
			this.Label17.AutoSize = true;
			this.Label17.Location = new System.Drawing.Point(83, 42);
			this.Label17.Name = "Label17";
			this.Label17.Size = new System.Drawing.Size(84, 13);
			this.Label17.TabIndex = 4;
			this.Label17.Text = "FeedRate Mode";
			//
			//cbxStateSpindle
			//
			this.cbxStateSpindle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxStateSpindle.FormattingEnabled = true;
			this.cbxStateSpindle.Items.AddRange(new object[] {
				"",
				"CW                                       M3",
				"CCW                                    M4",
				"Off                                       M5"
			});
			this.cbxStateSpindle.Location = new System.Drawing.Point(3, 108);
			this.cbxStateSpindle.Name = "cbxStateSpindle";
			this.cbxStateSpindle.Size = new System.Drawing.Size(74, 21);
			this.cbxStateSpindle.TabIndex = 24;
			//
			//btnStatusGetParser
			//
			this.btnStatusGetParser.AutoSize = true;
			this.btnStatusGetParser.Location = new System.Drawing.Point(0, 380);
			this.btnStatusGetParser.Name = "btnStatusGetParser";
			this.btnStatusGetParser.Size = new System.Drawing.Size(72, 23);
			this.btnStatusGetParser.TabIndex = 36;
			this.btnStatusGetParser.Text = "Refresh";
			this.btnStatusGetParser.UseVisualStyleBackColor = true;
			//
			//gbControl
			//
			this.gbControl.Controls.Add(this.btnCheckMode);
			this.gbControl.Controls.Add(this.btnReset);
			this.gbControl.Controls.Add(this.btnHold);
			this.gbControl.Controls.Add(this.btnStartResume);
			this.gbControl.Controls.Add(this.btnUnlock);
			this.gbControl.Location = new System.Drawing.Point(532, 409);
			this.gbControl.Name = "gbControl";
			this.gbControl.Size = new System.Drawing.Size(400, 59);
			this.gbControl.TabIndex = 35;
			this.gbControl.TabStop = false;
			this.gbControl.Text = "Control";
			//
			//btnCheckMode
			//
			this.btnCheckMode.AutoSize = true;
			this.btnCheckMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnCheckMode.Location = new System.Drawing.Point(322, 19);
			this.btnCheckMode.Name = "btnCheckMode";
			this.btnCheckMode.Size = new System.Drawing.Size(72, 31);
			this.btnCheckMode.TabIndex = 17;
			this.btnCheckMode.Text = "Check";
			this.btnCheckMode.UseCompatibleTextRendering = true;
			this.btnCheckMode.UseVisualStyleBackColor = true;
			//
			//btnReset
			//
			this.btnReset.AutoSize = true;
			this.btnReset.BackColor = System.Drawing.Color.Transparent;
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnReset.Location = new System.Drawing.Point(85, 19);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(72, 31);
			this.btnReset.TabIndex = 1;
			this.btnReset.Text = "Reset";
			this.btnReset.UseCompatibleTextRendering = true;
			this.btnReset.UseVisualStyleBackColor = false;
			//
			//btnHold
			//
			this.btnHold.AutoSize = true;
			this.btnHold.BackColor = System.Drawing.Color.Transparent;
			this.btnHold.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnHold.Location = new System.Drawing.Point(164, 19);
			this.btnHold.Name = "btnHold";
			this.btnHold.Size = new System.Drawing.Size(72, 31);
			this.btnHold.TabIndex = 3;
			this.btnHold.Text = "Hold";
			this.btnHold.UseCompatibleTextRendering = true;
			this.btnHold.UseVisualStyleBackColor = false;
			//
			//btnStartResume
			//
			this.btnStartResume.AutoSize = true;
			this.btnStartResume.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnStartResume.Location = new System.Drawing.Point(243, 19);
			this.btnStartResume.Name = "btnStartResume";
			this.btnStartResume.Size = new System.Drawing.Size(72, 31);
			this.btnStartResume.TabIndex = 2;
			this.btnStartResume.Text = "Start";
			this.btnStartResume.UseCompatibleTextRendering = true;
			this.btnStartResume.UseVisualStyleBackColor = true;
			//
			//btnUnlock
			//
			this.btnUnlock.AutoSize = true;
			this.btnUnlock.BackColor = System.Drawing.Color.Transparent;
			this.btnUnlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnUnlock.Location = new System.Drawing.Point(6, 19);
			this.btnUnlock.Name = "btnUnlock";
			this.btnUnlock.Size = new System.Drawing.Size(72, 31);
			this.btnUnlock.TabIndex = 16;
			this.btnUnlock.Text = "Unlock";
			this.btnUnlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnUnlock.UseCompatibleTextRendering = true;
			this.btnUnlock.UseVisualStyleBackColor = false;
			//
			//gbMDI
			//
			this.gbMDI.Controls.Add(this.Label9);
			this.gbMDI.Controls.Add(this.btnSend);
			this.gbMDI.Controls.Add(this.tbSendData);
			this.gbMDI.Enabled = false;
			this.gbMDI.Location = new System.Drawing.Point(187, 3);
			this.gbMDI.Name = "gbMDI";
			this.gbMDI.Size = new System.Drawing.Size(336, 89);
			this.gbMDI.TabIndex = 15;
			this.gbMDI.TabStop = false;
			this.gbMDI.Text = "MDI";
			//
			//Label9
			//
			this.Label9.AutoSize = true;
			this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label9.Location = new System.Drawing.Point(6, 19);
			this.Label9.Name = "Label9";
			this.Label9.Size = new System.Drawing.Size(106, 13);
			this.Label9.TabIndex = 12;
			this.Label9.Text = "Manual Command";
			//
			//btnSend
			//
			this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnSend.Location = new System.Drawing.Point(281, 32);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(44, 25);
			this.btnSend.TabIndex = 5;
			this.btnSend.Text = "Send";
			this.btnSend.UseVisualStyleBackColor = true;
			//
			//tbSendData
			//
			this.tbSendData.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbSendData.Location = new System.Drawing.Point(6, 35);
			this.tbSendData.Name = "tbSendData";
			this.tbSendData.Size = new System.Drawing.Size(269, 20);
			this.tbSendData.TabIndex = 4;
			//
			//gbJogging
			//
			this.gbJogging.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.gbJogging.Controls.Add(this.btnZMinus);
			this.gbJogging.Controls.Add(this.btnZPlus);
			this.gbJogging.Controls.Add(this.btnXPlus);
			this.gbJogging.Controls.Add(this.btnYMinus);
			this.gbJogging.Controls.Add(this.btnXMinus);
			this.gbJogging.Controls.Add(this.btnYPlus);
			this.gbJogging.Controls.Add(this.gbFeedRate);
			this.gbJogging.Controls.Add(this.gbDistance);
			this.gbJogging.Controls.Add(this.cbUnits);
			this.gbJogging.Enabled = false;
			this.gbJogging.Location = new System.Drawing.Point(3, 95);
			this.gbJogging.Name = "gbJogging";
			this.gbJogging.Size = new System.Drawing.Size(520, 212);
			this.gbJogging.TabIndex = 0;
			this.gbJogging.TabStop = false;
			this.gbJogging.Text = "Jogging";
			//
			//btnZMinus
			//
			this.btnZMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnZMinus.Interval = 100;
			this.btnZMinus.Location = new System.Drawing.Point(399, 145);
			this.btnZMinus.Name = "btnZMinus";
			this.btnZMinus.Size = new System.Drawing.Size(80, 58);
			this.btnZMinus.TabIndex = 23;
			this.btnZMinus.Tag = "Z-";
			this.btnZMinus.Text = "Z-";
			this.btnZMinus.UseVisualStyleBackColor = true;
			//
			//btnZPlus
			//
			this.btnZPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnZPlus.Interval = 100;
			this.btnZPlus.Location = new System.Drawing.Point(399, 18);
			this.btnZPlus.Name = "btnZPlus";
			this.btnZPlus.Size = new System.Drawing.Size(80, 58);
			this.btnZPlus.TabIndex = 22;
			this.btnZPlus.Tag = "Z+";
			this.btnZPlus.Text = "Z+";
			this.btnZPlus.UseVisualStyleBackColor = true;
			//
			//btnXPlus
			//
			this.btnXPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnXPlus.Interval = 100;
			this.btnXPlus.Location = new System.Drawing.Point(299, 81);
			this.btnXPlus.Name = "btnXPlus";
			this.btnXPlus.Size = new System.Drawing.Size(80, 58);
			this.btnXPlus.TabIndex = 21;
			this.btnXPlus.Tag = "X+";
			this.btnXPlus.Text = "X+";
			this.btnXPlus.UseVisualStyleBackColor = true;
			//
			//btnYMinus
			//
			this.btnYMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnYMinus.Interval = 100;
			this.btnYMinus.Location = new System.Drawing.Point(233, 144);
			this.btnYMinus.Name = "btnYMinus";
			this.btnYMinus.Size = new System.Drawing.Size(80, 58);
			this.btnYMinus.TabIndex = 20;
			this.btnYMinus.Tag = "Y-";
			this.btnYMinus.Text = "Y-";
			this.btnYMinus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			this.btnYMinus.UseVisualStyleBackColor = true;
			//
			//btnXMinus
			//
			this.btnXMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnXMinus.Interval = 100;
			this.btnXMinus.Location = new System.Drawing.Point(185, 81);
			this.btnXMinus.Name = "btnXMinus";
			this.btnXMinus.Size = new System.Drawing.Size(80, 58);
			this.btnXMinus.TabIndex = 19;
			this.btnXMinus.Tag = "X-";
			this.btnXMinus.Text = "X-";
			this.btnXMinus.UseVisualStyleBackColor = true;
			//
			//btnYPlus
			//
			this.btnYPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnYPlus.Interval = 100;
			this.btnYPlus.Location = new System.Drawing.Point(233, 18);
			this.btnYPlus.Name = "btnYPlus";
			this.btnYPlus.Size = new System.Drawing.Size(80, 58);
			this.btnYPlus.TabIndex = 18;
			this.btnYPlus.Tag = "Y+";
			this.btnYPlus.Text = "Y+";
			this.btnYPlus.UseVisualStyleBackColor = true;
			//
			//gbFeedRate
			//
			this.gbFeedRate.Controls.Add(this.rbFeedRate1);
			this.gbFeedRate.Controls.Add(this.rbFeedRate2);
			this.gbFeedRate.Controls.Add(this.rbFeedRate3);
			this.gbFeedRate.Controls.Add(this.rbFeedRate4);
			this.gbFeedRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.gbFeedRate.Location = new System.Drawing.Point(21, 117);
			this.gbFeedRate.Name = "gbFeedRate";
			this.gbFeedRate.Size = new System.Drawing.Size(82, 92);
			this.gbFeedRate.TabIndex = 16;
			this.gbFeedRate.TabStop = false;
			this.gbFeedRate.Text = "Feed Rate";
			//
			//rbFeedRate1
			//
			this.rbFeedRate1.AutoSize = true;
			this.rbFeedRate1.Cursor = System.Windows.Forms.Cursors.Default;
			this.rbFeedRate1.Location = new System.Drawing.Point(6, 19);
			this.rbFeedRate1.Name = "rbFeedRate1";
			this.rbFeedRate1.Size = new System.Drawing.Size(14, 13);
			this.rbFeedRate1.TabIndex = 11;
			this.rbFeedRate1.TabStop = true;
			this.rbFeedRate1.Tag = "F1";
			this.rbFeedRate1.UseVisualStyleBackColor = true;
			//
			//rbFeedRate2
			//
			this.rbFeedRate2.AutoSize = true;
			this.rbFeedRate2.Location = new System.Drawing.Point(6, 35);
			this.rbFeedRate2.Name = "rbFeedRate2";
			this.rbFeedRate2.Size = new System.Drawing.Size(14, 13);
			this.rbFeedRate2.TabIndex = 10;
			this.rbFeedRate2.TabStop = true;
			this.rbFeedRate2.Tag = "F2";
			this.rbFeedRate2.UseVisualStyleBackColor = true;
			//
			//rbFeedRate3
			//
			this.rbFeedRate3.AutoSize = true;
			this.rbFeedRate3.Location = new System.Drawing.Point(6, 53);
			this.rbFeedRate3.Name = "rbFeedRate3";
			this.rbFeedRate3.Size = new System.Drawing.Size(14, 13);
			this.rbFeedRate3.TabIndex = 12;
			this.rbFeedRate3.TabStop = true;
			this.rbFeedRate3.Tag = "F3";
			this.rbFeedRate3.UseVisualStyleBackColor = true;
			//
			//rbFeedRate4
			//
			this.rbFeedRate4.AutoSize = true;
			this.rbFeedRate4.Location = new System.Drawing.Point(6, 72);
			this.rbFeedRate4.Name = "rbFeedRate4";
			this.rbFeedRate4.Size = new System.Drawing.Size(14, 13);
			this.rbFeedRate4.TabIndex = 13;
			this.rbFeedRate4.TabStop = true;
			this.rbFeedRate4.Tag = "F4";
			this.rbFeedRate4.UseVisualStyleBackColor = true;
			//
			//gbDistance
			//
			this.gbDistance.Controls.Add(this.rbDistance1);
			this.gbDistance.Controls.Add(this.rbDistance2);
			this.gbDistance.Controls.Add(this.rbDistance3);
			this.gbDistance.Controls.Add(this.rbDistance4);
			this.gbDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.gbDistance.Location = new System.Drawing.Point(21, 19);
			this.gbDistance.Name = "gbDistance";
			this.gbDistance.Size = new System.Drawing.Size(82, 92);
			this.gbDistance.TabIndex = 17;
			this.gbDistance.TabStop = false;
			this.gbDistance.Text = "Distance";
			//
			//rbDistance1
			//
			this.rbDistance1.AutoSize = true;
			this.rbDistance1.Location = new System.Drawing.Point(6, 16);
			this.rbDistance1.Name = "rbDistance1";
			this.rbDistance1.Size = new System.Drawing.Size(14, 13);
			this.rbDistance1.TabIndex = 6;
			this.rbDistance1.TabStop = true;
			this.rbDistance1.Tag = "I1";
			this.rbDistance1.UseVisualStyleBackColor = true;
			//
			//rbDistance2
			//
			this.rbDistance2.AutoSize = true;
			this.rbDistance2.Location = new System.Drawing.Point(6, 35);
			this.rbDistance2.Name = "rbDistance2";
			this.rbDistance2.Size = new System.Drawing.Size(14, 13);
			this.rbDistance2.TabIndex = 7;
			this.rbDistance2.TabStop = true;
			this.rbDistance2.Tag = "I2";
			this.rbDistance2.UseVisualStyleBackColor = true;
			//
			//rbDistance3
			//
			this.rbDistance3.AutoSize = true;
			this.rbDistance3.Location = new System.Drawing.Point(6, 54);
			this.rbDistance3.Name = "rbDistance3";
			this.rbDistance3.Size = new System.Drawing.Size(14, 13);
			this.rbDistance3.TabIndex = 8;
			this.rbDistance3.TabStop = true;
			this.rbDistance3.Tag = "I3";
			this.rbDistance3.UseVisualStyleBackColor = true;
			//
			//rbDistance4
			//
			this.rbDistance4.AutoSize = true;
			this.rbDistance4.Location = new System.Drawing.Point(6, 73);
			this.rbDistance4.Name = "rbDistance4";
			this.rbDistance4.Size = new System.Drawing.Size(14, 13);
			this.rbDistance4.TabIndex = 9;
			this.rbDistance4.TabStop = true;
			this.rbDistance4.Tag = "I4";
			this.rbDistance4.UseVisualStyleBackColor = true;
			//
			//cbUnits
			//
			this.cbUnits.AutoSize = true;
			this.cbUnits.Location = new System.Drawing.Point(123, 192);
			this.cbUnits.Name = "cbUnits";
			this.cbUnits.Size = new System.Drawing.Size(73, 17);
			this.cbUnits.TabIndex = 16;
			this.cbUnits.Text = "Metric      ";
			this.cbUnits.UseVisualStyleBackColor = true;
			//
			//gbStatus
			//
			this.gbStatus.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.gbStatus.Controls.Add(this.Label25);
			this.gbStatus.Controls.Add(this.tbCurrentStatus);
			this.gbStatus.Controls.Add(this.Label24);
			this.gbStatus.Controls.Add(this.prgbRxBuf);
			this.gbStatus.Controls.Add(this.prgBarQ);
			this.gbStatus.Controls.Add(this.cbVerbose);
			this.gbStatus.Controls.Add(this.lbResponses);
			this.gbStatus.Enabled = false;
			this.gbStatus.Location = new System.Drawing.Point(532, 470);
			this.gbStatus.Name = "gbStatus";
			this.gbStatus.Size = new System.Drawing.Size(400, 204);
			this.gbStatus.TabIndex = 1;
			this.gbStatus.TabStop = false;
			this.gbStatus.Text = "Status";
			//
			//Label25
			//
			this.Label25.AutoSize = true;
			this.Label25.Location = new System.Drawing.Point(217, 21);
			this.Label25.Margin = new System.Windows.Forms.Padding(0);
			this.Label25.Name = "Label25";
			this.Label25.Size = new System.Drawing.Size(18, 13);
			this.Label25.TabIndex = 23;
			this.Label25.Text = "Q:";
			//
			//tbCurrentStatus
			//
			this.tbCurrentStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbCurrentStatus.Location = new System.Drawing.Point(6, 15);
			this.tbCurrentStatus.Name = "tbCurrentStatus";
			this.tbCurrentStatus.Size = new System.Drawing.Size(72, 26);
			this.tbCurrentStatus.TabIndex = 34;
			this.tbCurrentStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.ToolTip1.SetToolTip(this.tbCurrentStatus, "Shows status of Grbl");
			//
			//Label24
			//
			this.Label24.AutoSize = true;
			this.Label24.Location = new System.Drawing.Point(304, 21);
			this.Label24.Name = "Label24";
			this.Label24.Size = new System.Drawing.Size(25, 13);
			this.Label24.TabIndex = 22;
			this.Label24.Text = "RX:";
			//
			//prgbRxBuf
			//
			this.prgbRxBuf.Location = new System.Drawing.Point(334, 20);
			this.prgbRxBuf.Maximum = 127;
			this.prgbRxBuf.Name = "prgbRxBuf";
			this.prgbRxBuf.Size = new System.Drawing.Size(60, 15);
			this.prgbRxBuf.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prgbRxBuf.TabIndex = 21;
			//
			//prgBarQ
			//
			this.prgBarQ.Location = new System.Drawing.Point(238, 20);
			this.prgBarQ.Maximum = 25;
			this.prgBarQ.Name = "prgBarQ";
			this.prgBarQ.Size = new System.Drawing.Size(60, 15);
			this.prgBarQ.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.prgBarQ.TabIndex = 20;
			//
			//cbVerbose
			//
			this.cbVerbose.AutoSize = true;
			this.cbVerbose.Checked = global::GrblPanel.My.MySettings.Default.StatusVerbose;
			this.cbVerbose.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "statusVerbose", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbVerbose.Location = new System.Drawing.Point(87, 20);
			this.cbVerbose.Name = "cbVerbose";
			this.cbVerbose.Size = new System.Drawing.Size(83, 17);
			this.cbVerbose.TabIndex = 15;
			this.cbVerbose.Text = "Verbose      ";
			this.cbVerbose.UseVisualStyleBackColor = true;
			//
			//lbResponses
			//
			this.lbResponses.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.lbResponses.FormattingEnabled = true;
			this.lbResponses.HorizontalScrollbar = true;
			this.lbResponses.Location = new System.Drawing.Point(6, 50);
			this.lbResponses.Name = "lbResponses";
			this.lbResponses.Size = new System.Drawing.Size(388, 147);
			this.lbResponses.TabIndex = 0;
			//
			//gbGcode
			//
			this.gbGcode.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.gbGcode.Controls.Add(this.dgvGcode);
			this.gbGcode.Controls.Add(this.btnFileReload);
			this.gbGcode.Controls.Add(this.tbGCodeMessage);
			this.gbGcode.Controls.Add(this.Label27);
			this.gbGcode.Controls.Add(this.lblTotalLines);
			this.gbGcode.Controls.Add(this.Label23);
			this.gbGcode.Controls.Add(this.btnFilePause);
			this.gbGcode.Controls.Add(this.tbGcodeFile);
			this.gbGcode.Controls.Add(this.btnFileSelect);
			this.gbGcode.Controls.Add(this.btnFileSend);
			this.gbGcode.Controls.Add(this.btnFileStop);
			this.gbGcode.Enabled = false;
			this.gbGcode.Location = new System.Drawing.Point(3, 310);
			this.gbGcode.Name = "gbGcode";
			this.gbGcode.Size = new System.Drawing.Size(520, 376);
			this.gbGcode.TabIndex = 14;
			this.gbGcode.TabStop = false;
			this.gbGcode.Text = "GCode";
			//
			//dgvGcode
			//
			this.dgvGcode.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
			this.dgvGcode.AllowUserToAddRows = false;
			this.dgvGcode.AllowUserToDeleteRows = false;
			this.dgvGcode.AllowUserToResizeColumns = false;
			this.dgvGcode.AllowUserToResizeRows = false;
			this.dgvGcode.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left);
			this.dgvGcode.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGcode.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.stat,
				this.lineNum,
				this.data
			});
			this.dgvGcode.Location = new System.Drawing.Point(6, 87);
			this.dgvGcode.MultiSelect = false;
			this.dgvGcode.Name = "dgvGcode";
			this.dgvGcode.ReadOnly = true;
			this.dgvGcode.RowHeadersVisible = false;
			this.dgvGcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgvGcode.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGcode.Size = new System.Drawing.Size(503, 283);
			this.dgvGcode.StandardTab = true;
			this.dgvGcode.TabIndex = 22;
			this.dgvGcode.VirtualMode = true;
			//
			//stat
			//
			this.stat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.stat.Frozen = true;
			this.stat.HeaderText = "Sts";
			this.stat.Name = "stat";
			this.stat.ReadOnly = true;
			this.stat.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.stat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			//
			//lineNum
			//
			this.lineNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.lineNum.HeaderText = "Line";
			this.lineNum.Name = "lineNum";
			this.lineNum.ReadOnly = true;
			this.lineNum.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.lineNum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			//
			//data
			//
			this.data.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
			this.data.HeaderText = "GCode";
			this.data.Name = "data";
			this.data.ReadOnly = true;
			this.data.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			this.data.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
			//
			//btnFileReload
			//
			this.btnFileReload.Enabled = false;
			this.btnFileReload.Image = (System.Drawing.Image)resources.GetObject("btnFileReload.Image");
			this.btnFileReload.Location = new System.Drawing.Point(190, 41);
			this.btnFileReload.Name = "btnFileReload";
			this.btnFileReload.Size = new System.Drawing.Size(40, 40);
			this.btnFileReload.TabIndex = 21;
			this.btnFileReload.Tag = "Reload";
			this.ToolTip1.SetToolTip(this.btnFileReload, "Reload File");
			this.btnFileReload.UseVisualStyleBackColor = true;
			//
			//tbGCodeMessage
			//
			this.tbGCodeMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbGCodeMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbGCodeMessage.Location = new System.Drawing.Point(285, 65);
			this.tbGCodeMessage.Name = "tbGCodeMessage";
			this.tbGCodeMessage.Size = new System.Drawing.Size(223, 16);
			this.tbGCodeMessage.TabIndex = 20;
			//
			//Label27
			//
			this.Label27.AutoSize = true;
			this.Label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label27.Location = new System.Drawing.Point(282, 49);
			this.Label27.Name = "Label27";
			this.Label27.Size = new System.Drawing.Size(57, 13);
			this.Label27.TabIndex = 19;
			this.Label27.Text = "Message";
			//
			//lblTotalLines
			//
			this.lblTotalLines.AutoSize = true;
			this.lblTotalLines.Location = new System.Drawing.Point(246, 68);
			this.lblTotalLines.Name = "lblTotalLines";
			this.lblTotalLines.Size = new System.Drawing.Size(10, 13);
			this.lblTotalLines.TabIndex = 17;
			this.lblTotalLines.Text = " ";
			//
			//Label23
			//
			this.Label23.AutoSize = true;
			this.Label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label23.Location = new System.Drawing.Point(236, 49);
			this.Label23.Name = "Label23";
			this.Label23.Size = new System.Drawing.Size(37, 13);
			this.Label23.TabIndex = 15;
			this.Label23.Text = "Lines";
			//
			//btnFilePause
			//
			this.btnFilePause.Enabled = false;
			this.btnFilePause.Image = (System.Drawing.Image)resources.GetObject("btnFilePause.Image");
			this.btnFilePause.Location = new System.Drawing.Point(98, 41);
			this.btnFilePause.Name = "btnFilePause";
			this.btnFilePause.Padding = new System.Windows.Forms.Padding(3);
			this.btnFilePause.Size = new System.Drawing.Size(40, 40);
			this.btnFilePause.TabIndex = 6;
			this.btnFilePause.Tag = "Pause";
			this.ToolTip1.SetToolTip(this.btnFilePause, "Pause sending");
			this.btnFilePause.UseVisualStyleBackColor = true;
			//
			//tbGcodeFile
			//
			this.tbGcodeFile.Enabled = false;
			this.tbGcodeFile.Location = new System.Drawing.Point(6, 19);
			this.tbGcodeFile.Name = "tbGcodeFile";
			this.tbGcodeFile.Size = new System.Drawing.Size(424, 20);
			this.tbGcodeFile.TabIndex = 10;
			//
			//btnFileSelect
			//
			this.btnFileSelect.Image = (System.Drawing.Image)resources.GetObject("btnFileSelect.Image");
			this.btnFileSelect.Location = new System.Drawing.Point(6, 41);
			this.btnFileSelect.Name = "btnFileSelect";
			this.btnFileSelect.Size = new System.Drawing.Size(40, 40);
			this.btnFileSelect.TabIndex = 7;
			this.btnFileSelect.Tag = "File";
			this.ToolTip1.SetToolTip(this.btnFileSelect, "Load a file");
			this.btnFileSelect.UseVisualStyleBackColor = true;
			//
			//btnFileSend
			//
			this.btnFileSend.Enabled = false;
			this.btnFileSend.Image = (System.Drawing.Image)resources.GetObject("btnFileSend.Image");
			this.btnFileSend.Location = new System.Drawing.Point(52, 41);
			this.btnFileSend.Name = "btnFileSend";
			this.btnFileSend.Size = new System.Drawing.Size(40, 40);
			this.btnFileSend.TabIndex = 8;
			this.btnFileSend.Tag = "Send";
			this.ToolTip1.SetToolTip(this.btnFileSend, "Start/Resume sending");
			this.btnFileSend.UseVisualStyleBackColor = true;
			//
			//btnFileStop
			//
			this.btnFileStop.Enabled = false;
			this.btnFileStop.Image = (System.Drawing.Image)resources.GetObject("btnFileStop.Image");
			this.btnFileStop.Location = new System.Drawing.Point(144, 41);
			this.btnFileStop.Name = "btnFileStop";
			this.btnFileStop.Size = new System.Drawing.Size(40, 40);
			this.btnFileStop.TabIndex = 9;
			this.btnFileStop.Tag = "Stop";
			this.ToolTip1.SetToolTip(this.btnFileStop, "Stop sending");
			this.btnFileStop.UseVisualStyleBackColor = true;
			//
			//gbGrbl
			//
			this.gbGrbl.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.gbGrbl.Controls.Add(this.tcConnection);
			this.gbGrbl.Location = new System.Drawing.Point(3, 3);
			this.gbGrbl.Name = "gbGrbl";
			this.gbGrbl.Size = new System.Drawing.Size(178, 89);
			this.gbGrbl.TabIndex = 3;
			this.gbGrbl.TabStop = false;
			this.gbGrbl.Text = "Grbl";
			//
			//tcConnection
			//
			this.tcConnection.Controls.Add(this.tbGrblCOM);
			this.tcConnection.Controls.Add(this.tbGrblIP);
			this.tcConnection.Location = new System.Drawing.Point(6, 16);
			this.tcConnection.Name = "tcConnection";
			this.tcConnection.SelectedIndex = 0;
			this.tcConnection.Size = new System.Drawing.Size(162, 71);
			this.tcConnection.TabIndex = 0;
			//
			//tbGrblCOM
			//
			this.tbGrblCOM.Controls.Add(this.btnRescanPorts);
			this.tbGrblCOM.Controls.Add(this.cbPorts);
			this.tbGrblCOM.Controls.Add(this.btnConnect);
			this.tbGrblCOM.Controls.Add(this.cbBaud);
			this.tbGrblCOM.Location = new System.Drawing.Point(4, 22);
			this.tbGrblCOM.Name = "tbGrblCOM";
			this.tbGrblCOM.Padding = new System.Windows.Forms.Padding(3);
			this.tbGrblCOM.Size = new System.Drawing.Size(154, 45);
			this.tbGrblCOM.TabIndex = 0;
			this.tbGrblCOM.Text = "COM";
			this.tbGrblCOM.UseVisualStyleBackColor = true;
			//
			//btnRescanPorts
			//
			this.btnRescanPorts.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnRescanPorts.Location = new System.Drawing.Point(88, 18);
			this.btnRescanPorts.Name = "btnRescanPorts";
			this.btnRescanPorts.Size = new System.Drawing.Size(68, 23);
			this.btnRescanPorts.TabIndex = 5;
			this.btnRescanPorts.Text = "ReScan";
			this.btnRescanPorts.UseVisualStyleBackColor = true;
			//
			//cbPorts
			//
			this.cbPorts.FormattingEnabled = true;
			this.cbPorts.Location = new System.Drawing.Point(10, 0);
			this.cbPorts.Name = "cbPorts";
			this.cbPorts.Size = new System.Drawing.Size(72, 21);
			this.cbPorts.TabIndex = 3;
			//
			//btnConnect
			//
			this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnConnect.Location = new System.Drawing.Point(88, -2);
			this.btnConnect.Name = "btnConnect";
			this.btnConnect.Size = new System.Drawing.Size(68, 23);
			this.btnConnect.TabIndex = 1;
			this.btnConnect.Tag = "COM";
			this.btnConnect.Text = "Connect";
			this.btnConnect.UseVisualStyleBackColor = true;
			//
			//cbBaud
			//
			this.cbBaud.FormattingEnabled = true;
			this.cbBaud.Items.AddRange(new object[] {
				"9600",
				"115200"
			});
			this.cbBaud.Location = new System.Drawing.Point(10, 20);
			this.cbBaud.Name = "cbBaud";
			this.cbBaud.Size = new System.Drawing.Size(72, 21);
			this.cbBaud.TabIndex = 4;
			//
			//tbGrblIP
			//
			this.tbGrblIP.Controls.Add(this.btnIPConnect);
			this.tbGrblIP.Controls.Add(this.tbIPAddress);
			this.tbGrblIP.Location = new System.Drawing.Point(4, 22);
			this.tbGrblIP.Name = "tbGrblIP";
			this.tbGrblIP.Padding = new System.Windows.Forms.Padding(3);
			this.tbGrblIP.Size = new System.Drawing.Size(154, 45);
			this.tbGrblIP.TabIndex = 1;
			this.tbGrblIP.Text = "IP";
			this.tbGrblIP.UseVisualStyleBackColor = true;
			//
			//btnIPConnect
			//
			this.btnIPConnect.Location = new System.Drawing.Point(12, 20);
			this.btnIPConnect.Name = "btnIPConnect";
			this.btnIPConnect.Size = new System.Drawing.Size(131, 23);
			this.btnIPConnect.TabIndex = 1;
			this.btnIPConnect.Tag = "IP";
			this.btnIPConnect.Text = "Connect";
			this.btnIPConnect.UseVisualStyleBackColor = true;
			//
			//tbIPAddress
			//
			this.tbIPAddress.Location = new System.Drawing.Point(12, 0);
			this.tbIPAddress.Name = "tbIPAddress";
			this.tbIPAddress.Size = new System.Drawing.Size(131, 20);
			this.tbIPAddress.TabIndex = 0;
			this.ToolTip1.SetToolTip(this.tbIPAddress, "Enter IP Address and port as \"<IP>:<port>\"");
			//
			//gbPosition
			//
			this.gbPosition.Controls.Add(this.tabCtlPosition);
			this.gbPosition.Enabled = false;
			this.gbPosition.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.gbPosition.Location = new System.Drawing.Point(532, 3);
			this.gbPosition.Name = "gbPosition";
			this.gbPosition.Size = new System.Drawing.Size(400, 403);
			this.gbPosition.TabIndex = 2;
			this.gbPosition.TabStop = false;
			this.gbPosition.Text = "Position";
			//
			//tabCtlPosition
			//
			this.tabCtlPosition.Controls.Add(this.tpWork);
			this.tabCtlPosition.Controls.Add(this.tpOffsets);
			this.tabCtlPosition.Location = new System.Drawing.Point(6, 19);
			this.tabCtlPosition.Name = "tabCtlPosition";
			this.tabCtlPosition.SelectedIndex = 0;
			this.tabCtlPosition.Size = new System.Drawing.Size(388, 378);
			this.tabCtlPosition.TabIndex = 0;
			//
			//tpWork
			//
			this.tpWork.Controls.Add(this.Panel5);
			this.tpWork.Controls.Add(this.Panel4);
			this.tpWork.Controls.Add(this.Panel3);
			this.tpWork.Controls.Add(this.GroupBox1);
			this.tpWork.Controls.Add(this.btnWorkSoftHome);
			this.tpWork.Controls.Add(this.btnHome);
			this.tpWork.Controls.Add(this.btnWorkSpclPosition);
			this.tpWork.Controls.Add(this.Label3);
			this.tpWork.Controls.Add(this.btnWork0);
			this.tpWork.Controls.Add(this.Label2);
			this.tpWork.Controls.Add(this.btnWorkX0);
			this.tpWork.Controls.Add(this.Label1);
			this.tpWork.Controls.Add(this.btnWorkZ0);
			this.tpWork.Controls.Add(this.btnWorkY0);
			this.tpWork.Location = new System.Drawing.Point(4, 22);
			this.tpWork.Name = "tpWork";
			this.tpWork.Padding = new System.Windows.Forms.Padding(3);
			this.tpWork.Size = new System.Drawing.Size(380, 352);
			this.tpWork.TabIndex = 0;
			this.tpWork.Text = "Work";
			this.tpWork.UseVisualStyleBackColor = true;
			//
			//Panel5
			//
			this.Panel5.BackColor = System.Drawing.SystemColors.Control;
			this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel5.Controls.Add(this.tbWorkZ);
			this.Panel5.Controls.Add(this.tbMachZ);
			this.Panel5.Enabled = false;
			this.Panel5.Location = new System.Drawing.Point(48, 179);
			this.Panel5.Name = "Panel5";
			this.Panel5.Size = new System.Drawing.Size(287, 88);
			this.Panel5.TabIndex = 19;
			//
			//tbWorkZ
			//
			this.tbWorkZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbWorkZ.Enabled = false;
			this.tbWorkZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 45f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbWorkZ.Location = new System.Drawing.Point(-1, 0);
			this.tbWorkZ.Name = "tbWorkZ";
			this.tbWorkZ.Size = new System.Drawing.Size(287, 68);
			this.tbWorkZ.TabIndex = 5;
			this.tbWorkZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.tbWorkZ, "Work Z position");
			this.tbWorkZ.WordWrap = false;
			//
			//tbMachZ
			//
			this.tbMachZ.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbMachZ.Enabled = false;
			this.tbMachZ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbMachZ.Location = new System.Drawing.Point(188, 63);
			this.tbMachZ.Name = "tbMachZ";
			this.tbMachZ.Size = new System.Drawing.Size(98, 23);
			this.tbMachZ.TabIndex = 8;
			this.tbMachZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.tbMachZ, "Machine Z position");
			this.tbMachZ.WordWrap = false;
			//
			//Panel4
			//
			this.Panel4.BackColor = System.Drawing.SystemColors.Control;
			this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel4.Controls.Add(this.tbWorkY);
			this.Panel4.Controls.Add(this.tbMachY);
			this.Panel4.Enabled = false;
			this.Panel4.Location = new System.Drawing.Point(48, 91);
			this.Panel4.Name = "Panel4";
			this.Panel4.Size = new System.Drawing.Size(287, 88);
			this.Panel4.TabIndex = 18;
			//
			//tbWorkY
			//
			this.tbWorkY.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbWorkY.Enabled = false;
			this.tbWorkY.Font = new System.Drawing.Font("Microsoft Sans Serif", 45f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbWorkY.Location = new System.Drawing.Point(0, -3);
			this.tbWorkY.Name = "tbWorkY";
			this.tbWorkY.Size = new System.Drawing.Size(287, 68);
			this.tbWorkY.TabIndex = 4;
			this.tbWorkY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.tbWorkY, "Work Y position");
			this.tbWorkY.WordWrap = false;
			//
			//tbMachY
			//
			this.tbMachY.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbMachY.Enabled = false;
			this.tbMachY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbMachY.Location = new System.Drawing.Point(188, 64);
			this.tbMachY.Name = "tbMachY";
			this.tbMachY.Size = new System.Drawing.Size(98, 23);
			this.tbMachY.TabIndex = 7;
			this.tbMachY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.tbMachY, "Machine Y position");
			this.tbMachY.WordWrap = false;
			//
			//Panel3
			//
			this.Panel3.BackColor = System.Drawing.SystemColors.Control;
			this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Panel3.Controls.Add(this.tbMachX);
			this.Panel3.Controls.Add(this.tbWorkX);
			this.Panel3.Enabled = false;
			this.Panel3.Location = new System.Drawing.Point(48, 3);
			this.Panel3.Name = "Panel3";
			this.Panel3.Size = new System.Drawing.Size(287, 88);
			this.Panel3.TabIndex = 0;
			//
			//tbMachX
			//
			this.tbMachX.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbMachX.Enabled = false;
			this.tbMachX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbMachX.Location = new System.Drawing.Point(188, 64);
			this.tbMachX.Name = "tbMachX";
			this.tbMachX.Size = new System.Drawing.Size(98, 23);
			this.tbMachX.TabIndex = 6;
			this.tbMachX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.tbMachX, "Machine X position");
			this.tbMachX.WordWrap = false;
			//
			//tbWorkX
			//
			this.tbWorkX.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tbWorkX.Enabled = false;
			this.tbWorkX.Font = new System.Drawing.Font("Microsoft Sans Serif", 45f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.tbWorkX.Location = new System.Drawing.Point(-1, -1);
			this.tbWorkX.Name = "tbWorkX";
			this.tbWorkX.Size = new System.Drawing.Size(287, 68);
			this.tbWorkX.TabIndex = 12;
			this.tbWorkX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.ToolTip1.SetToolTip(this.tbWorkX, "Work X position");
			this.tbWorkX.WordWrap = false;
			//
			//GroupBox1
			//
			this.GroupBox1.Controls.Add(this.lblPositionCurrentOffset);
			this.GroupBox1.Location = new System.Drawing.Point(224, 282);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(82, 58);
			this.GroupBox1.TabIndex = 17;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "Active Offset";
			//
			//lblPositionCurrentOffset
			//
			this.lblPositionCurrentOffset.AutoSize = true;
			this.lblPositionCurrentOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.lblPositionCurrentOffset.Location = new System.Drawing.Point(23, 21);
			this.lblPositionCurrentOffset.Name = "lblPositionCurrentOffset";
			this.lblPositionCurrentOffset.Size = new System.Drawing.Size(0, 20);
			this.lblPositionCurrentOffset.TabIndex = 0;
			//
			//btnWorkSoftHome
			//
			this.btnWorkSoftHome.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnWorkSoftHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnWorkSoftHome.Location = new System.Drawing.Point(75, 285);
			this.btnWorkSoftHome.Name = "btnWorkSoftHome";
			this.btnWorkSoftHome.Size = new System.Drawing.Size(66, 58);
			this.btnWorkSoftHome.TabIndex = 16;
			this.btnWorkSoftHome.Tag = "Spcl Posn1";
			this.btnWorkSoftHome.Text = "Go To Spcl Posn1";
			this.ToolTip1.SetToolTip(this.btnWorkSoftHome, "GoTo Position 1 using G28");
			this.btnWorkSoftHome.UseVisualStyleBackColor = true;
			//
			//btnHome
			//
			this.btnHome.BackColor = System.Drawing.Color.Transparent;
			this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnHome.Location = new System.Drawing.Point(5, 285);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(66, 58);
			this.btnHome.TabIndex = 6;
			this.btnHome.Tag = "HomeCycle";
			this.btnHome.Text = "Home Cycle";
			this.ToolTip1.SetToolTip(this.btnHome, "Perform Homing Cycle");
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Visible = false;
			//
			//btnWorkSpclPosition
			//
			this.btnWorkSpclPosition.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnWorkSpclPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnWorkSpclPosition.Location = new System.Drawing.Point(145, 285);
			this.btnWorkSpclPosition.Name = "btnWorkSpclPosition";
			this.btnWorkSpclPosition.Size = new System.Drawing.Size(75, 58);
			this.btnWorkSpclPosition.TabIndex = 16;
			this.btnWorkSpclPosition.Tag = "Spcl Posn2";
			this.btnWorkSpclPosition.Text = "Go To Spcl Posn2";
			this.ToolTip1.SetToolTip(this.btnWorkSpclPosition, "Go To Position 2 using G30");
			this.btnWorkSpclPosition.UseVisualStyleBackColor = true;
			//
			//Label3
			//
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("Arial Unicode MS", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label3.Location = new System.Drawing.Point(7, 203);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(40, 43);
			this.Label3.TabIndex = 11;
			this.Label3.Text = "Z";
			//
			//btnWork0
			//
			this.btnWork0.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnWork0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnWork0.Location = new System.Drawing.Point(310, 285);
			this.btnWork0.Name = "btnWork0";
			this.btnWork0.Size = new System.Drawing.Size(66, 58);
			this.btnWork0.TabIndex = 5;
			this.btnWork0.Tag = "ZeroXYZ";
			this.btnWork0.Text = "Zero XYZ";
			this.ToolTip1.SetToolTip(this.btnWork0, "Set all axes to 0 on Active Offset");
			this.btnWork0.UseVisualStyleBackColor = true;
			//
			//Label2
			//
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("Arial Unicode MS", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label2.Location = new System.Drawing.Point(7, 116);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(41, 43);
			this.Label2.TabIndex = 10;
			this.Label2.Text = "Y";
			//
			//btnWorkX0
			//
			this.btnWorkX0.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnWorkX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnWorkX0.Location = new System.Drawing.Point(340, 33);
			this.btnWorkX0.Name = "btnWorkX0";
			this.btnWorkX0.Size = new System.Drawing.Size(34, 34);
			this.btnWorkX0.TabIndex = 6;
			this.btnWorkX0.Tag = "X";
			this.btnWorkX0.Text = "0";
			this.ToolTip1.SetToolTip(this.btnWorkX0, "Set X axis to 0 on Active Offset");
			this.btnWorkX0.UseVisualStyleBackColor = true;
			//
			//Label1
			//
			this.Label1.AutoSize = true;
			this.Label1.Font = new System.Drawing.Font("Arial Unicode MS", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label1.Location = new System.Drawing.Point(7, 29);
			this.Label1.Name = "Label1";
			this.Label1.Size = new System.Drawing.Size(41, 43);
			this.Label1.TabIndex = 9;
			this.Label1.Text = "X";
			//
			//btnWorkZ0
			//
			this.btnWorkZ0.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnWorkZ0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnWorkZ0.Location = new System.Drawing.Point(340, 207);
			this.btnWorkZ0.Name = "btnWorkZ0";
			this.btnWorkZ0.Size = new System.Drawing.Size(34, 34);
			this.btnWorkZ0.TabIndex = 8;
			this.btnWorkZ0.Tag = "Z";
			this.btnWorkZ0.Text = "0";
			this.ToolTip1.SetToolTip(this.btnWorkZ0, "Set Z axis to 0 on Active Offset");
			this.btnWorkZ0.UseVisualStyleBackColor = true;
			//
			//btnWorkY0
			//
			this.btnWorkY0.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.btnWorkY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 24f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnWorkY0.Location = new System.Drawing.Point(340, 120);
			this.btnWorkY0.Name = "btnWorkY0";
			this.btnWorkY0.Size = new System.Drawing.Size(34, 34);
			this.btnWorkY0.TabIndex = 7;
			this.btnWorkY0.Tag = "Y";
			this.btnWorkY0.Text = "0";
			this.ToolTip1.SetToolTip(this.btnWorkY0, "Set Y axis to 0 on Active Offset");
			this.btnWorkY0.UseVisualStyleBackColor = true;
			//
			//tpOffsets
			//
			this.tpOffsets.Controls.Add(this.btnSetOffsetG59);
			this.tpOffsets.Controls.Add(this.btnSetOffsetG58);
			this.tpOffsets.Controls.Add(this.btnSetOffsetG57);
			this.tpOffsets.Controls.Add(this.btnSetOffsetG56);
			this.tpOffsets.Controls.Add(this.btnSetOffsetG55);
			this.tpOffsets.Controls.Add(this.btnSetOffsetG54);
			this.tpOffsets.Controls.Add(this.Label10);
			this.tpOffsets.Controls.Add(this.Label71);
			this.tpOffsets.Controls.Add(this.tbOffSetsMachZ);
			this.tpOffsets.Controls.Add(this.Label19);
			this.tpOffsets.Controls.Add(this.tbOffsetsG56Y);
			this.tpOffsets.Controls.Add(this.tbOffSetsMachY);
			this.tpOffsets.Controls.Add(this.tbOffsetsG56X);
			this.tpOffsets.Controls.Add(this.tbOffsetsG56Z);
			this.tpOffsets.Controls.Add(this.tbOffSetsMachX);
			this.tpOffsets.Controls.Add(this.btnOffsetsG57Zero);
			this.tpOffsets.Controls.Add(this.tbOffsetsG54X);
			this.tpOffsets.Controls.Add(this.btnOffsetsG56Zero);
			this.tpOffsets.Controls.Add(this.tbOffsetsG54Y);
			this.tpOffsets.Controls.Add(this.tbOffsetsG57Z);
			this.tpOffsets.Controls.Add(this.btnOffsetsSave);
			this.tpOffsets.Controls.Add(this.tbOffsetsG55X);
			this.tpOffsets.Controls.Add(this.tbOffsetsG54Z);
			this.tpOffsets.Controls.Add(this.tbOffsetsG57Y);
			this.tpOffsets.Controls.Add(this.btnOffsetsRetrieve);
			this.tpOffsets.Controls.Add(this.tbOffsetsG55Y);
			this.tpOffsets.Controls.Add(this.btnOffsetsG54Zero);
			this.tpOffsets.Controls.Add(this.tbOffsetsG57X);
			this.tpOffsets.Controls.Add(this.btnOffsetsLoad);
			this.tpOffsets.Controls.Add(this.tbOffsetsG55Z);
			this.tpOffsets.Controls.Add(this.tbOffsetsG59X);
			this.tpOffsets.Controls.Add(this.btnOffsetsG58Zero);
			this.tpOffsets.Controls.Add(this.btnOffsetsG43Zero);
			this.tpOffsets.Controls.Add(this.tbOffsetsG59Y);
			this.tpOffsets.Controls.Add(this.tbOffsetsG43Z);
			this.tpOffsets.Controls.Add(this.btnOffsetsG55Zero);
			this.tpOffsets.Controls.Add(this.tbOffsetsG59Z);
			this.tpOffsets.Controls.Add(this.tbOffsetsG58Z);
			this.tpOffsets.Controls.Add(this.Label60);
			this.tpOffsets.Controls.Add(this.tbOffsetsG58Y);
			this.tpOffsets.Controls.Add(this.Label20);
			this.tpOffsets.Controls.Add(this.Label43);
			this.tpOffsets.Controls.Add(this.btnOffsetsG59Zero);
			this.tpOffsets.Controls.Add(this.tbOffsetsG58X);
			this.tpOffsets.Controls.Add(this.Label21);
			this.tpOffsets.Location = new System.Drawing.Point(4, 22);
			this.tpOffsets.Name = "tpOffsets";
			this.tpOffsets.Padding = new System.Windows.Forms.Padding(3);
			this.tpOffsets.Size = new System.Drawing.Size(380, 352);
			this.tpOffsets.TabIndex = 2;
			this.tpOffsets.Text = "Offsets";
			this.tpOffsets.ToolTipText = "Click to set to Current Machine Location";
			this.tpOffsets.UseVisualStyleBackColor = true;
			//
			//btnSetOffsetG59
			//
			this.btnSetOffsetG59.Location = new System.Drawing.Point(18, 274);
			this.btnSetOffsetG59.Name = "btnSetOffsetG59";
			this.btnSetOffsetG59.Size = new System.Drawing.Size(46, 23);
			this.btnSetOffsetG59.TabIndex = 122;
			this.btnSetOffsetG59.Tag = "G59";
			this.btnSetOffsetG59.Text = "G59";
			this.ToolTip1.SetToolTip(this.btnSetOffsetG59, "Click to set to Current Machine Location");
			this.btnSetOffsetG59.UseVisualStyleBackColor = true;
			//
			//btnSetOffsetG58
			//
			this.btnSetOffsetG58.Location = new System.Drawing.Point(18, 248);
			this.btnSetOffsetG58.Name = "btnSetOffsetG58";
			this.btnSetOffsetG58.Size = new System.Drawing.Size(46, 23);
			this.btnSetOffsetG58.TabIndex = 121;
			this.btnSetOffsetG58.Tag = "G58";
			this.btnSetOffsetG58.Text = "G58";
			this.ToolTip1.SetToolTip(this.btnSetOffsetG58, "Click to set to Current Machine Location");
			this.btnSetOffsetG58.UseVisualStyleBackColor = true;
			//
			//btnSetOffsetG57
			//
			this.btnSetOffsetG57.Location = new System.Drawing.Point(18, 222);
			this.btnSetOffsetG57.Name = "btnSetOffsetG57";
			this.btnSetOffsetG57.Size = new System.Drawing.Size(46, 23);
			this.btnSetOffsetG57.TabIndex = 120;
			this.btnSetOffsetG57.Tag = "G57";
			this.btnSetOffsetG57.Text = "G57";
			this.ToolTip1.SetToolTip(this.btnSetOffsetG57, "Click to set to Current Machine Location");
			this.btnSetOffsetG57.UseVisualStyleBackColor = true;
			//
			//btnSetOffsetG56
			//
			this.btnSetOffsetG56.Location = new System.Drawing.Point(18, 195);
			this.btnSetOffsetG56.Name = "btnSetOffsetG56";
			this.btnSetOffsetG56.Size = new System.Drawing.Size(46, 23);
			this.btnSetOffsetG56.TabIndex = 119;
			this.btnSetOffsetG56.Tag = "G56";
			this.btnSetOffsetG56.Text = "G56";
			this.ToolTip1.SetToolTip(this.btnSetOffsetG56, "Click to set to Current Machine Location");
			this.btnSetOffsetG56.UseVisualStyleBackColor = true;
			//
			//btnSetOffsetG55
			//
			this.btnSetOffsetG55.Location = new System.Drawing.Point(18, 169);
			this.btnSetOffsetG55.Name = "btnSetOffsetG55";
			this.btnSetOffsetG55.Size = new System.Drawing.Size(46, 23);
			this.btnSetOffsetG55.TabIndex = 118;
			this.btnSetOffsetG55.Tag = "G55";
			this.btnSetOffsetG55.Text = "G55";
			this.ToolTip1.SetToolTip(this.btnSetOffsetG55, "Click to set to Current Machine Location");
			this.btnSetOffsetG55.UseVisualStyleBackColor = true;
			//
			//btnSetOffsetG54
			//
			this.btnSetOffsetG54.Location = new System.Drawing.Point(18, 143);
			this.btnSetOffsetG54.Name = "btnSetOffsetG54";
			this.btnSetOffsetG54.Size = new System.Drawing.Size(46, 23);
			this.btnSetOffsetG54.TabIndex = 117;
			this.btnSetOffsetG54.Tag = "G54";
			this.btnSetOffsetG54.Text = "G54";
			this.ToolTip1.SetToolTip(this.btnSetOffsetG54, "Click to set to Current Machine Location");
			this.btnSetOffsetG54.UseVisualStyleBackColor = true;
			//
			//Label10
			//
			this.Label10.AutoSize = true;
			this.Label10.Location = new System.Drawing.Point(133, 25);
			this.Label10.Name = "Label10";
			this.Label10.Size = new System.Drawing.Size(125, 13);
			this.Label10.TabIndex = 116;
			this.Label10.Text = "Current Machine location";
			//
			//Label71
			//
			this.Label71.AutoSize = true;
			this.Label71.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label71.Location = new System.Drawing.Point(23, 108);
			this.Label71.Name = "Label71";
			this.Label71.Size = new System.Drawing.Size(41, 13);
			this.Label71.TabIndex = 115;
			this.Label71.Text = "G43.1";
			//
			//tbOffSetsMachZ
			//
			this.tbOffSetsMachZ.Enabled = false;
			this.tbOffSetsMachZ.Location = new System.Drawing.Point(245, 45);
			this.tbOffSetsMachZ.Name = "tbOffSetsMachZ";
			this.tbOffSetsMachZ.Size = new System.Drawing.Size(79, 20);
			this.tbOffSetsMachZ.TabIndex = 114;
			this.tbOffSetsMachZ.Tag = "G28Z";
			this.ToolTip1.SetToolTip(this.tbOffSetsMachZ, "Current Machine Z");
			//
			//Label19
			//
			this.Label19.AutoSize = true;
			this.Label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label19.Location = new System.Drawing.Point(23, 90);
			this.Label19.Name = "Label19";
			this.Label19.Size = new System.Drawing.Size(113, 13);
			this.Label19.TabIndex = 100;
			this.Label19.Text = "Tool Length Offset";
			//
			//tbOffsetsG56Y
			//
			this.tbOffsetsG56Y.Location = new System.Drawing.Point(160, 197);
			this.tbOffsetsG56Y.Name = "tbOffsetsG56Y";
			this.tbOffsetsG56Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG56Y.TabIndex = 76;
			this.tbOffsetsG56Y.Tag = "G56Y";
			//
			//tbOffSetsMachY
			//
			this.tbOffSetsMachY.Enabled = false;
			this.tbOffSetsMachY.Location = new System.Drawing.Point(160, 45);
			this.tbOffSetsMachY.Name = "tbOffSetsMachY";
			this.tbOffSetsMachY.Size = new System.Drawing.Size(79, 20);
			this.tbOffSetsMachY.TabIndex = 113;
			this.tbOffSetsMachY.Tag = "G28Y";
			this.ToolTip1.SetToolTip(this.tbOffSetsMachY, "Current Machine Y");
			//
			//tbOffsetsG56X
			//
			this.tbOffsetsG56X.Location = new System.Drawing.Point(75, 197);
			this.tbOffsetsG56X.Name = "tbOffsetsG56X";
			this.tbOffsetsG56X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG56X.TabIndex = 75;
			this.tbOffsetsG56X.Tag = "G56X";
			//
			//tbOffsetsG56Z
			//
			this.tbOffsetsG56Z.Location = new System.Drawing.Point(245, 197);
			this.tbOffsetsG56Z.Name = "tbOffsetsG56Z";
			this.tbOffsetsG56Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG56Z.TabIndex = 77;
			this.tbOffsetsG56Z.Tag = "G56Z";
			//
			//tbOffSetsMachX
			//
			this.tbOffSetsMachX.Enabled = false;
			this.tbOffSetsMachX.Location = new System.Drawing.Point(75, 45);
			this.tbOffSetsMachX.Name = "tbOffSetsMachX";
			this.tbOffSetsMachX.Size = new System.Drawing.Size(79, 20);
			this.tbOffSetsMachX.TabIndex = 112;
			this.tbOffSetsMachX.Tag = "G28X";
			this.ToolTip1.SetToolTip(this.tbOffSetsMachX, "Current Machine X");
			//
			//btnOffsetsG57Zero
			//
			this.btnOffsetsG57Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG57Zero.Location = new System.Drawing.Point(330, 222);
			this.btnOffsetsG57Zero.Name = "btnOffsetsG57Zero";
			this.btnOffsetsG57Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG57Zero.TabIndex = 74;
			this.btnOffsetsG57Zero.Tag = "G57Zero";
			this.btnOffsetsG57Zero.Text = "0";
			this.btnOffsetsG57Zero.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG54X
			//
			this.tbOffsetsG54X.Location = new System.Drawing.Point(75, 145);
			this.tbOffsetsG54X.Name = "tbOffsetsG54X";
			this.tbOffsetsG54X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG54X.TabIndex = 56;
			this.tbOffsetsG54X.Tag = "G54X";
			//
			//btnOffsetsG56Zero
			//
			this.btnOffsetsG56Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG56Zero.Location = new System.Drawing.Point(330, 196);
			this.btnOffsetsG56Zero.Name = "btnOffsetsG56Zero";
			this.btnOffsetsG56Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG56Zero.TabIndex = 79;
			this.btnOffsetsG56Zero.Tag = "G56Zero";
			this.btnOffsetsG56Zero.Text = "0";
			this.btnOffsetsG56Zero.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG54Y
			//
			this.tbOffsetsG54Y.Location = new System.Drawing.Point(160, 145);
			this.tbOffsetsG54Y.Name = "tbOffsetsG54Y";
			this.tbOffsetsG54Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG54Y.TabIndex = 57;
			this.tbOffsetsG54Y.Tag = "G54Y";
			//
			//tbOffsetsG57Z
			//
			this.tbOffsetsG57Z.Location = new System.Drawing.Point(245, 223);
			this.tbOffsetsG57Z.Name = "tbOffsetsG57Z";
			this.tbOffsetsG57Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG57Z.TabIndex = 72;
			this.tbOffsetsG57Z.Tag = "G57Z";
			//
			//btnOffsetsSave
			//
			this.btnOffsetsSave.Location = new System.Drawing.Point(160, 299);
			this.btnOffsetsSave.Name = "btnOffsetsSave";
			this.btnOffsetsSave.Size = new System.Drawing.Size(75, 23);
			this.btnOffsetsSave.TabIndex = 107;
			this.btnOffsetsSave.Text = "Save";
			this.ToolTip1.SetToolTip(this.btnOffsetsSave, "Save Work Offsets to File");
			this.btnOffsetsSave.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG55X
			//
			this.tbOffsetsG55X.Location = new System.Drawing.Point(75, 171);
			this.tbOffsetsG55X.Name = "tbOffsetsG55X";
			this.tbOffsetsG55X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG55X.TabIndex = 80;
			this.tbOffsetsG55X.Tag = "G55X";
			//
			//tbOffsetsG54Z
			//
			this.tbOffsetsG54Z.Location = new System.Drawing.Point(245, 145);
			this.tbOffsetsG54Z.Name = "tbOffsetsG54Z";
			this.tbOffsetsG54Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG54Z.TabIndex = 58;
			this.tbOffsetsG54Z.Tag = "G54Z";
			//
			//tbOffsetsG57Y
			//
			this.tbOffsetsG57Y.Location = new System.Drawing.Point(160, 223);
			this.tbOffsetsG57Y.Name = "tbOffsetsG57Y";
			this.tbOffsetsG57Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG57Y.TabIndex = 71;
			this.tbOffsetsG57Y.Tag = "G57Y";
			//
			//btnOffsetsRetrieve
			//
			this.btnOffsetsRetrieve.Location = new System.Drawing.Point(245, 299);
			this.btnOffsetsRetrieve.Name = "btnOffsetsRetrieve";
			this.btnOffsetsRetrieve.Size = new System.Drawing.Size(75, 23);
			this.btnOffsetsRetrieve.TabIndex = 106;
			this.btnOffsetsRetrieve.Text = "Retrieve";
			this.ToolTip1.SetToolTip(this.btnOffsetsRetrieve, "Get from Grbl");
			this.btnOffsetsRetrieve.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG55Y
			//
			this.tbOffsetsG55Y.Location = new System.Drawing.Point(160, 171);
			this.tbOffsetsG55Y.Name = "tbOffsetsG55Y";
			this.tbOffsetsG55Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG55Y.TabIndex = 81;
			this.tbOffsetsG55Y.Tag = "G55Y";
			//
			//btnOffsetsG54Zero
			//
			this.btnOffsetsG54Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG54Zero.Location = new System.Drawing.Point(330, 144);
			this.btnOffsetsG54Zero.Name = "btnOffsetsG54Zero";
			this.btnOffsetsG54Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG54Zero.TabIndex = 59;
			this.btnOffsetsG54Zero.Tag = "G54Zero";
			this.btnOffsetsG54Zero.Text = "0";
			this.btnOffsetsG54Zero.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG57X
			//
			this.tbOffsetsG57X.Location = new System.Drawing.Point(75, 223);
			this.tbOffsetsG57X.Name = "tbOffsetsG57X";
			this.tbOffsetsG57X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG57X.TabIndex = 70;
			this.tbOffsetsG57X.Tag = "G57X";
			//
			//btnOffsetsLoad
			//
			this.btnOffsetsLoad.Location = new System.Drawing.Point(75, 300);
			this.btnOffsetsLoad.Name = "btnOffsetsLoad";
			this.btnOffsetsLoad.Size = new System.Drawing.Size(75, 23);
			this.btnOffsetsLoad.TabIndex = 105;
			this.btnOffsetsLoad.Text = "Load";
			this.ToolTip1.SetToolTip(this.btnOffsetsLoad, "Load Work Offsets from File");
			this.btnOffsetsLoad.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG55Z
			//
			this.tbOffsetsG55Z.Location = new System.Drawing.Point(245, 171);
			this.tbOffsetsG55Z.Name = "tbOffsetsG55Z";
			this.tbOffsetsG55Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG55Z.TabIndex = 82;
			this.tbOffsetsG55Z.Tag = "G55Z";
			//
			//tbOffsetsG59X
			//
			this.tbOffsetsG59X.Location = new System.Drawing.Point(75, 275);
			this.tbOffsetsG59X.Name = "tbOffsetsG59X";
			this.tbOffsetsG59X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG59X.TabIndex = 60;
			this.tbOffsetsG59X.Tag = "G59X";
			//
			//btnOffsetsG58Zero
			//
			this.btnOffsetsG58Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG58Zero.Location = new System.Drawing.Point(330, 248);
			this.btnOffsetsG58Zero.Name = "btnOffsetsG58Zero";
			this.btnOffsetsG58Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG58Zero.TabIndex = 69;
			this.btnOffsetsG58Zero.Tag = "G58Zero";
			this.btnOffsetsG58Zero.Text = "0";
			this.btnOffsetsG58Zero.UseVisualStyleBackColor = true;
			//
			//btnOffsetsG43Zero
			//
			this.btnOffsetsG43Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG43Zero.Location = new System.Drawing.Point(330, 104);
			this.btnOffsetsG43Zero.Name = "btnOffsetsG43Zero";
			this.btnOffsetsG43Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG43Zero.TabIndex = 103;
			this.btnOffsetsG43Zero.Tag = "G43Zero";
			this.btnOffsetsG43Zero.Text = "0";
			this.btnOffsetsG43Zero.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG59Y
			//
			this.tbOffsetsG59Y.Location = new System.Drawing.Point(160, 275);
			this.tbOffsetsG59Y.Name = "tbOffsetsG59Y";
			this.tbOffsetsG59Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG59Y.TabIndex = 61;
			this.tbOffsetsG59Y.Tag = "G59Y";
			//
			//tbOffsetsG43Z
			//
			this.tbOffsetsG43Z.Location = new System.Drawing.Point(245, 105);
			this.tbOffsetsG43Z.Name = "tbOffsetsG43Z";
			this.tbOffsetsG43Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG43Z.TabIndex = 102;
			this.tbOffsetsG43Z.Tag = "G43Z";
			//
			//btnOffsetsG55Zero
			//
			this.btnOffsetsG55Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG55Zero.Location = new System.Drawing.Point(330, 170);
			this.btnOffsetsG55Zero.Name = "btnOffsetsG55Zero";
			this.btnOffsetsG55Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG55Zero.TabIndex = 84;
			this.btnOffsetsG55Zero.Tag = "G55Zero";
			this.btnOffsetsG55Zero.Text = "0";
			this.btnOffsetsG55Zero.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG59Z
			//
			this.tbOffsetsG59Z.Location = new System.Drawing.Point(245, 275);
			this.tbOffsetsG59Z.Name = "tbOffsetsG59Z";
			this.tbOffsetsG59Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG59Z.TabIndex = 62;
			this.tbOffsetsG59Z.Tag = "G59Z";
			//
			//tbOffsetsG58Z
			//
			this.tbOffsetsG58Z.Location = new System.Drawing.Point(245, 249);
			this.tbOffsetsG58Z.Name = "tbOffsetsG58Z";
			this.tbOffsetsG58Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG58Z.TabIndex = 67;
			this.tbOffsetsG58Z.Tag = "G58Z";
			//
			//Label60
			//
			this.Label60.AutoSize = true;
			this.Label60.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label60.Location = new System.Drawing.Point(116, 68);
			this.Label60.Name = "Label60";
			this.Label60.Size = new System.Drawing.Size(15, 13);
			this.Label60.TabIndex = 85;
			this.Label60.Text = "X";
			//
			//tbOffsetsG58Y
			//
			this.tbOffsetsG58Y.Location = new System.Drawing.Point(160, 249);
			this.tbOffsetsG58Y.Name = "tbOffsetsG58Y";
			this.tbOffsetsG58Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG58Y.TabIndex = 66;
			this.tbOffsetsG58Y.Tag = "G58Y";
			//
			//Label20
			//
			this.Label20.AutoSize = true;
			this.Label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label20.Location = new System.Drawing.Point(28, 129);
			this.Label20.Name = "Label20";
			this.Label20.Size = new System.Drawing.Size(81, 13);
			this.Label20.TabIndex = 99;
			this.Label20.Text = "Work Offsets";
			//
			//Label43
			//
			this.Label43.AutoSize = true;
			this.Label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label43.Location = new System.Drawing.Point(189, 68);
			this.Label43.Name = "Label43";
			this.Label43.Size = new System.Drawing.Size(15, 13);
			this.Label43.TabIndex = 86;
			this.Label43.Text = "Y";
			//
			//btnOffsetsG59Zero
			//
			this.btnOffsetsG59Zero.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG59Zero.Location = new System.Drawing.Point(330, 274);
			this.btnOffsetsG59Zero.Name = "btnOffsetsG59Zero";
			this.btnOffsetsG59Zero.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG59Zero.TabIndex = 64;
			this.btnOffsetsG59Zero.Tag = "G59Zero";
			this.btnOffsetsG59Zero.Text = "0";
			this.btnOffsetsG59Zero.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG58X
			//
			this.tbOffsetsG58X.Location = new System.Drawing.Point(75, 249);
			this.tbOffsetsG58X.Name = "tbOffsetsG58X";
			this.tbOffsetsG58X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG58X.TabIndex = 65;
			this.tbOffsetsG58X.Tag = "G58X";
			//
			//Label21
			//
			this.Label21.AutoSize = true;
			this.Label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label21.Location = new System.Drawing.Point(280, 68);
			this.Label21.Name = "Label21";
			this.Label21.Size = new System.Drawing.Size(15, 13);
			this.Label21.TabIndex = 87;
			this.Label21.Text = "Z";
			//
			//tabPgSettings
			//
			this.tabPgSettings.Controls.Add(this.gbGrblSettings);
			this.tabPgSettings.Controls.Add(this.gbSettingsOffsets);
			this.tabPgSettings.Controls.Add(this.Label42);
			this.tabPgSettings.Controls.Add(this.gbSettingsMisc);
			this.tabPgSettings.Controls.Add(this.gbSettingsPosition);
			this.tabPgSettings.Controls.Add(this.gbSettingsJogging);
			this.tabPgSettings.Location = new System.Drawing.Point(4, 22);
			this.tabPgSettings.Name = "tabPgSettings";
			this.tabPgSettings.Padding = new System.Windows.Forms.Padding(3);
			this.tabPgSettings.Size = new System.Drawing.Size(1134, 677);
			this.tabPgSettings.TabIndex = 1;
			this.tabPgSettings.Text = "Settings";
			this.tabPgSettings.UseVisualStyleBackColor = true;
			//
			//gbGrblSettings
			//
			this.gbGrblSettings.Controls.Add(this.Label4);
			this.gbGrblSettings.Controls.Add(this.tbSettingsGrblLastParam);
			this.gbGrblSettings.Controls.Add(this.dgGrblSettings);
			this.gbGrblSettings.Controls.Add(this.btnSettingsGrbl);
			this.gbGrblSettings.Location = new System.Drawing.Point(10, 19);
			this.gbGrblSettings.Name = "gbGrblSettings";
			this.gbGrblSettings.Size = new System.Drawing.Size(346, 590);
			this.gbGrblSettings.TabIndex = 111;
			this.gbGrblSettings.TabStop = false;
			this.gbGrblSettings.Text = "Grbl Settings";
			//
			//Label4
			//
			this.Label4.AutoSize = true;
			this.Label4.Location = new System.Drawing.Point(57, 555);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(82, 13);
			this.Label4.TabIndex = 7;
			this.Label4.Text = "Last Grbl Param";
			//
			//tbSettingsGrblLastParam
			//
			this.tbSettingsGrblLastParam.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "GrblLastParamID", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsGrblLastParam.Location = new System.Drawing.Point(6, 552);
			this.tbSettingsGrblLastParam.Name = "tbSettingsGrblLastParam";
			this.tbSettingsGrblLastParam.Size = new System.Drawing.Size(45, 20);
			this.tbSettingsGrblLastParam.TabIndex = 6;
			this.tbSettingsGrblLastParam.Text = global::GrblPanel.My.MySettings.Default.GrblLastParamID;
			this.ToolTip1.SetToolTip(this.tbSettingsGrblLastParam, "Change this to reflect the highest Grbl Parameter number");
			//
			//dgGrblSettings
			//
			this.dgGrblSettings.AllowUserToAddRows = false;
			this.dgGrblSettings.AllowUserToDeleteRows = false;
			this.dgGrblSettings.AllowUserToResizeColumns = false;
			this.dgGrblSettings.AllowUserToResizeRows = false;
			this.dgGrblSettings.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dgGrblSettings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgGrblSettings.Location = new System.Drawing.Point(3, 13);
			this.dgGrblSettings.MultiSelect = false;
			this.dgGrblSettings.Name = "dgGrblSettings";
			this.dgGrblSettings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dgGrblSettings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgGrblSettings.Size = new System.Drawing.Size(337, 530);
			this.dgGrblSettings.TabIndex = 4;
			//
			//btnSettingsGrbl
			//
			this.btnSettingsGrbl.Location = new System.Drawing.Point(265, 549);
			this.btnSettingsGrbl.Name = "btnSettingsGrbl";
			this.btnSettingsGrbl.Size = new System.Drawing.Size(75, 41);
			this.btnSettingsGrbl.TabIndex = 5;
			this.btnSettingsGrbl.Text = "Get Grbl Settings";
			this.btnSettingsGrbl.UseVisualStyleBackColor = true;
			//
			//gbSettingsOffsets
			//
			this.gbSettingsOffsets.Controls.Add(this.btnOffsetsG28Set);
			this.gbSettingsOffsets.Controls.Add(this.btnSettingsRetrieveLocations);
			this.gbSettingsOffsets.Controls.Add(this.Label7);
			this.gbSettingsOffsets.Controls.Add(this.Label18);
			this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30Y);
			this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30X);
			this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG30Z);
			this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28X);
			this.gbSettingsOffsets.Controls.Add(this.btnOffsetsG30Set);
			this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28Y);
			this.gbSettingsOffsets.Controls.Add(this.Label68);
			this.gbSettingsOffsets.Controls.Add(this.tbOffsetsG28Z);
			this.gbSettingsOffsets.Controls.Add(this.Label69);
			this.gbSettingsOffsets.Location = new System.Drawing.Point(362, 498);
			this.gbSettingsOffsets.Name = "gbSettingsOffsets";
			this.gbSettingsOffsets.Size = new System.Drawing.Size(351, 111);
			this.gbSettingsOffsets.TabIndex = 110;
			this.gbSettingsOffsets.TabStop = false;
			this.gbSettingsOffsets.Text = "Offsets (2)";
			//
			//btnOffsetsG28Set
			//
			this.btnOffsetsG28Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG28Set.Location = new System.Drawing.Point(311, 29);
			this.btnOffsetsG28Set.Name = "btnOffsetsG28Set";
			this.btnOffsetsG28Set.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG28Set.TabIndex = 112;
			this.btnOffsetsG28Set.Tag = "G28Set";
			this.btnOffsetsG28Set.Text = "Set";
			this.ToolTip1.SetToolTip(this.btnOffsetsG28Set, "Set Special Position 1 to current Machine position");
			this.btnOffsetsG28Set.UseVisualStyleBackColor = true;
			//
			//btnSettingsRetrieveLocations
			//
			this.btnSettingsRetrieveLocations.Location = new System.Drawing.Point(276, 88);
			this.btnSettingsRetrieveLocations.Name = "btnSettingsRetrieveLocations";
			this.btnSettingsRetrieveLocations.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsRetrieveLocations.TabIndex = 111;
			this.btnSettingsRetrieveLocations.Text = "Retrieve";
			this.ToolTip1.SetToolTip(this.btnSettingsRetrieveLocations, "Get current settings from Grbl");
			this.btnSettingsRetrieveLocations.UseVisualStyleBackColor = true;
			//
			//Label7
			//
			this.Label7.AutoSize = true;
			this.Label7.Location = new System.Drawing.Point(5, 95);
			this.Label7.Name = "Label7";
			this.Label7.Size = new System.Drawing.Size(185, 13);
			this.Label7.TabIndex = 110;
			this.Label7.Text = "(Work Offsets are set from main page)";
			//
			//Label18
			//
			this.Label18.AutoSize = true;
			this.Label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label18.Location = new System.Drawing.Point(8, 16);
			this.Label18.Name = "Label18";
			this.Label18.Size = new System.Drawing.Size(114, 13);
			this.Label18.TabIndex = 101;
			this.Label18.Text = "Machine Locations";
			//
			//tbOffsetsG30Y
			//
			this.tbOffsetsG30Y.Enabled = false;
			this.tbOffsetsG30Y.Location = new System.Drawing.Point(141, 59);
			this.tbOffsetsG30Y.Name = "tbOffsetsG30Y";
			this.tbOffsetsG30Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG30Y.TabIndex = 95;
			this.tbOffsetsG30Y.Tag = "G30Y";
			//
			//tbOffsetsG30X
			//
			this.tbOffsetsG30X.Enabled = false;
			this.tbOffsetsG30X.Location = new System.Drawing.Point(56, 59);
			this.tbOffsetsG30X.Name = "tbOffsetsG30X";
			this.tbOffsetsG30X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG30X.TabIndex = 94;
			this.tbOffsetsG30X.Tag = "G30X";
			//
			//tbOffsetsG30Z
			//
			this.tbOffsetsG30Z.Enabled = false;
			this.tbOffsetsG30Z.Location = new System.Drawing.Point(226, 59);
			this.tbOffsetsG30Z.Name = "tbOffsetsG30Z";
			this.tbOffsetsG30Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG30Z.TabIndex = 96;
			this.tbOffsetsG30Z.Tag = "G30Z";
			//
			//tbOffsetsG28X
			//
			this.tbOffsetsG28X.Enabled = false;
			this.tbOffsetsG28X.Location = new System.Drawing.Point(56, 31);
			this.tbOffsetsG28X.Name = "tbOffsetsG28X";
			this.tbOffsetsG28X.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG28X.TabIndex = 89;
			this.tbOffsetsG28X.Tag = "G28X";
			//
			//btnOffsetsG30Set
			//
			this.btnOffsetsG30Set.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.btnOffsetsG30Set.Location = new System.Drawing.Point(311, 58);
			this.btnOffsetsG30Set.Name = "btnOffsetsG30Set";
			this.btnOffsetsG30Set.Size = new System.Drawing.Size(35, 23);
			this.btnOffsetsG30Set.TabIndex = 97;
			this.btnOffsetsG30Set.Tag = "G30Set";
			this.btnOffsetsG30Set.Text = "Set";
			this.ToolTip1.SetToolTip(this.btnOffsetsG30Set, "Set Special Position 2 to current Machine position");
			this.btnOffsetsG30Set.UseVisualStyleBackColor = true;
			//
			//tbOffsetsG28Y
			//
			this.tbOffsetsG28Y.Enabled = false;
			this.tbOffsetsG28Y.Location = new System.Drawing.Point(141, 31);
			this.tbOffsetsG28Y.Name = "tbOffsetsG28Y";
			this.tbOffsetsG28Y.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG28Y.TabIndex = 90;
			this.tbOffsetsG28Y.Tag = "G28Y";
			//
			//Label68
			//
			this.Label68.AutoSize = true;
			this.Label68.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label68.Location = new System.Drawing.Point(4, 35);
			this.Label68.Name = "Label68";
			this.Label68.Size = new System.Drawing.Size(30, 13);
			this.Label68.TabIndex = 108;
			this.Label68.Text = "G28";
			//
			//tbOffsetsG28Z
			//
			this.tbOffsetsG28Z.Enabled = false;
			this.tbOffsetsG28Z.Location = new System.Drawing.Point(226, 31);
			this.tbOffsetsG28Z.Name = "tbOffsetsG28Z";
			this.tbOffsetsG28Z.Size = new System.Drawing.Size(79, 20);
			this.tbOffsetsG28Z.TabIndex = 91;
			this.tbOffsetsG28Z.Tag = "G28Z";
			//
			//Label69
			//
			this.Label69.AutoSize = true;
			this.Label69.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label69.Location = new System.Drawing.Point(4, 63);
			this.Label69.Name = "Label69";
			this.Label69.Size = new System.Drawing.Size(30, 13);
			this.Label69.TabIndex = 109;
			this.Label69.Text = "G30";
			//
			//Label42
			//
			this.Label42.AutoSize = true;
			this.Label42.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label42.Location = new System.Drawing.Point(359, 3);
			this.Label42.Name = "Label42";
			this.Label42.Size = new System.Drawing.Size(283, 13);
			this.Label42.TabIndex = 3;
			this.Label42.Text = "These settings always save on exit of Grbl-Panel";
			//
			//gbSettingsMisc
			//
			this.gbSettingsMisc.Controls.Add(this.tbSettingsDefaultExt);
			this.gbSettingsMisc.Controls.Add(this.Label5);
			this.gbSettingsMisc.Controls.Add(this.Label6);
			this.gbSettingsMisc.Controls.Add(this.tbSettingsStartupDelay);
			this.gbSettingsMisc.Controls.Add(this.cbSettingsLeftHanded);
			this.gbSettingsMisc.Controls.Add(this.cbSettingsConnectOnLoad);
			this.gbSettingsMisc.Controls.Add(this.cbSettingsPauseOnError);
			this.gbSettingsMisc.Controls.Add(this.cbStatusPollEnable);
			this.gbSettingsMisc.Controls.Add(this.btnSettingsRefreshMisc);
			this.gbSettingsMisc.Controls.Add(this.Label37);
			this.gbSettingsMisc.Controls.Add(this.Label36);
			this.gbSettingsMisc.Controls.Add(this.tbSettingsRBuffSize);
			this.gbSettingsMisc.Controls.Add(this.tbSettingsQSize);
			this.gbSettingsMisc.Controls.Add(this.Label26);
			this.gbSettingsMisc.Controls.Add(this.tbSettingsPollRate);
			this.gbSettingsMisc.Location = new System.Drawing.Point(362, 234);
			this.gbSettingsMisc.Name = "gbSettingsMisc";
			this.gbSettingsMisc.Size = new System.Drawing.Size(239, 258);
			this.gbSettingsMisc.TabIndex = 2;
			this.gbSettingsMisc.TabStop = false;
			this.gbSettingsMisc.Text = "Misc";
			//
			//tbSettingsDefaultExt
			//
			this.tbSettingsDefaultExt.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "DefaultFileExt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsDefaultExt.Location = new System.Drawing.Point(12, 120);
			this.tbSettingsDefaultExt.Name = "tbSettingsDefaultExt";
			this.tbSettingsDefaultExt.Size = new System.Drawing.Size(43, 20);
			this.tbSettingsDefaultExt.TabIndex = 22;
			this.tbSettingsDefaultExt.Text = global::GrblPanel.My.MySettings.Default.DefaultFileExt;
			//
			//Label5
			//
			this.Label5.AutoSize = true;
			this.Label5.Location = new System.Drawing.Point(70, 96);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(69, 13);
			this.Label5.TabIndex = 20;
			this.Label5.Text = "Startup delay";
			//
			//Label6
			//
			this.Label6.AutoSize = true;
			this.Label6.Location = new System.Drawing.Point(70, 123);
			this.Label6.Name = "Label6";
			this.Label6.Size = new System.Drawing.Size(77, 13);
			this.Label6.TabIndex = 21;
			this.Label6.Text = "Default File ext";
			//
			//tbSettingsStartupDelay
			//
			this.tbSettingsStartupDelay.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "StartupDelay", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsStartupDelay.Location = new System.Drawing.Point(12, 94);
			this.tbSettingsStartupDelay.Name = "tbSettingsStartupDelay";
			this.tbSettingsStartupDelay.Size = new System.Drawing.Size(44, 20);
			this.tbSettingsStartupDelay.TabIndex = 19;
			this.tbSettingsStartupDelay.Text = global::GrblPanel.My.MySettings.Default.StartupDelay;
			//
			//cbSettingsLeftHanded
			//
			this.cbSettingsLeftHanded.AutoSize = true;
			this.cbSettingsLeftHanded.Checked = global::GrblPanel.My.MySettings.Default.LeftHandedGUI;
			this.cbSettingsLeftHanded.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "LeftHandedGUI", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbSettingsLeftHanded.Location = new System.Drawing.Point(124, 187);
			this.cbSettingsLeftHanded.Name = "cbSettingsLeftHanded";
			this.cbSettingsLeftHanded.Size = new System.Drawing.Size(107, 17);
			this.cbSettingsLeftHanded.TabIndex = 18;
			this.cbSettingsLeftHanded.Text = "Left Handed GUI";
			this.cbSettingsLeftHanded.UseVisualStyleBackColor = true;
			//
			//cbSettingsConnectOnLoad
			//
			this.cbSettingsConnectOnLoad.AutoSize = true;
			this.cbSettingsConnectOnLoad.Checked = global::GrblPanel.My.MySettings.Default.GrblConnectOnLoad;
			this.cbSettingsConnectOnLoad.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "GrblConnectOnLoad", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbSettingsConnectOnLoad.Location = new System.Drawing.Point(11, 169);
			this.cbSettingsConnectOnLoad.Name = "cbSettingsConnectOnLoad";
			this.cbSettingsConnectOnLoad.Size = new System.Drawing.Size(108, 17);
			this.cbSettingsConnectOnLoad.TabIndex = 12;
			this.cbSettingsConnectOnLoad.Text = "Connect on Load";
			this.ToolTip1.SetToolTip(this.cbSettingsConnectOnLoad, "Connect automatically to last port");
			this.cbSettingsConnectOnLoad.UseVisualStyleBackColor = true;
			//
			//cbSettingsPauseOnError
			//
			this.cbSettingsPauseOnError.AutoSize = true;
			this.cbSettingsPauseOnError.Checked = global::GrblPanel.My.MySettings.Default.GCodePauseOnError;
			this.cbSettingsPauseOnError.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSettingsPauseOnError.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "GCodePauseOnError", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbSettingsPauseOnError.Location = new System.Drawing.Point(11, 152);
			this.cbSettingsPauseOnError.Name = "cbSettingsPauseOnError";
			this.cbSettingsPauseOnError.Size = new System.Drawing.Size(96, 17);
			this.cbSettingsPauseOnError.TabIndex = 7;
			this.cbSettingsPauseOnError.Text = "Pause on Error";
			this.cbSettingsPauseOnError.UseVisualStyleBackColor = true;
			//
			//cbStatusPollEnable
			//
			this.cbStatusPollEnable.AutoSize = true;
			this.cbStatusPollEnable.Checked = global::GrblPanel.My.MySettings.Default.StatusPollEnabled;
			this.cbStatusPollEnable.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbStatusPollEnable.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "StatusPollEnabled", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbStatusPollEnable.Location = new System.Drawing.Point(10, 187);
			this.cbStatusPollEnable.Name = "cbStatusPollEnable";
			this.cbStatusPollEnable.Size = new System.Drawing.Size(76, 17);
			this.cbStatusPollEnable.TabIndex = 17;
			this.cbStatusPollEnable.Text = "Status Poll";
			this.cbStatusPollEnable.UseVisualStyleBackColor = true;
			//
			//btnSettingsRefreshMisc
			//
			this.btnSettingsRefreshMisc.Location = new System.Drawing.Point(0, 235);
			this.btnSettingsRefreshMisc.Name = "btnSettingsRefreshMisc";
			this.btnSettingsRefreshMisc.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsRefreshMisc.TabIndex = 6;
			this.btnSettingsRefreshMisc.Tag = "Misc";
			this.btnSettingsRefreshMisc.Text = "Refresh";
			this.btnSettingsRefreshMisc.UseVisualStyleBackColor = true;
			//
			//Label37
			//
			this.Label37.AutoSize = true;
			this.Label37.Location = new System.Drawing.Point(70, 70);
			this.Label37.Name = "Label37";
			this.Label37.Size = new System.Drawing.Size(77, 13);
			this.Label37.TabIndex = 5;
			this.Label37.Text = "RBuf Max Size";
			//
			//Label36
			//
			this.Label36.AutoSize = true;
			this.Label36.Location = new System.Drawing.Point(70, 44);
			this.Label36.Name = "Label36";
			this.Label36.Size = new System.Drawing.Size(61, 13);
			this.Label36.TabIndex = 4;
			this.Label36.Text = "Q Max Size";
			//
			//tbSettingsRBuffSize
			//
			this.tbSettingsRBuffSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "RBuffMaxSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsRBuffSize.Location = new System.Drawing.Point(12, 68);
			this.tbSettingsRBuffSize.Name = "tbSettingsRBuffSize";
			this.tbSettingsRBuffSize.Size = new System.Drawing.Size(43, 20);
			this.tbSettingsRBuffSize.TabIndex = 3;
			this.tbSettingsRBuffSize.Text = global::GrblPanel.My.MySettings.Default.RBuffMaxSize;
			//
			//tbSettingsQSize
			//
			this.tbSettingsQSize.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "QBuffMaxSize", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsQSize.Location = new System.Drawing.Point(12, 42);
			this.tbSettingsQSize.Name = "tbSettingsQSize";
			this.tbSettingsQSize.Size = new System.Drawing.Size(43, 20);
			this.tbSettingsQSize.TabIndex = 2;
			this.tbSettingsQSize.Text = global::GrblPanel.My.MySettings.Default.QBuffMaxSize;
			//
			//Label26
			//
			this.Label26.AutoSize = true;
			this.Label26.Location = new System.Drawing.Point(70, 22);
			this.Label26.Name = "Label26";
			this.Label26.Size = new System.Drawing.Size(84, 13);
			this.Label26.TabIndex = 1;
			this.Label26.Text = "Poll Interval (ms)";
			//
			//tbSettingsPollRate
			//
			this.tbSettingsPollRate.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "statusPollInterval", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsPollRate.Location = new System.Drawing.Point(12, 19);
			this.tbSettingsPollRate.Name = "tbSettingsPollRate";
			this.tbSettingsPollRate.Size = new System.Drawing.Size(43, 20);
			this.tbSettingsPollRate.TabIndex = 0;
			this.tbSettingsPollRate.Text = global::GrblPanel.My.MySettings.Default.StatusPollInterval;
			//
			//gbSettingsPosition
			//
			this.gbSettingsPosition.Controls.Add(this.Label8);
			this.gbSettingsPosition.Controls.Add(this.tbSettingsSpclPosition2);
			this.gbSettingsPosition.Controls.Add(this.btnSettingsRefreshPosition);
			this.gbSettingsPosition.Controls.Add(this.Label29);
			this.gbSettingsPosition.Controls.Add(this.tbWorkZ0Cmd);
			this.gbSettingsPosition.Controls.Add(this.Label28);
			this.gbSettingsPosition.Controls.Add(this.tbWorkY0Cmd);
			this.gbSettingsPosition.Controls.Add(this.Label13);
			this.gbSettingsPosition.Controls.Add(this.Label12);
			this.gbSettingsPosition.Controls.Add(this.tbWorkX0Cmd);
			this.gbSettingsPosition.Controls.Add(this.tbSettingsZeroXYZCmd);
			this.gbSettingsPosition.Controls.Add(this.Label11);
			this.gbSettingsPosition.Controls.Add(this.tbSettingsSpclPosition1);
			this.gbSettingsPosition.Location = new System.Drawing.Point(362, 19);
			this.gbSettingsPosition.Name = "gbSettingsPosition";
			this.gbSettingsPosition.Size = new System.Drawing.Size(239, 209);
			this.gbSettingsPosition.TabIndex = 1;
			this.gbSettingsPosition.TabStop = false;
			this.gbSettingsPosition.Text = "Position";
			//
			//Label8
			//
			this.Label8.AutoSize = true;
			this.Label8.Location = new System.Drawing.Point(135, 47);
			this.Label8.Name = "Label8";
			this.Label8.Size = new System.Drawing.Size(94, 13);
			this.Label8.TabIndex = 12;
			this.Label8.Text = "GoTo Spcl Posn 2";
			//
			//tbSettingsSpclPosition2
			//
			this.tbSettingsSpclPosition2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "MachineSpclPosition2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsSpclPosition2.Location = new System.Drawing.Point(12, 44);
			this.tbSettingsSpclPosition2.Name = "tbSettingsSpclPosition2";
			this.tbSettingsSpclPosition2.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsSpclPosition2.TabIndex = 11;
			this.tbSettingsSpclPosition2.Text = global::GrblPanel.My.MySettings.Default.MachineSpclPosition2;
			//
			//btnSettingsRefreshPosition
			//
			this.btnSettingsRefreshPosition.Location = new System.Drawing.Point(-2, 182);
			this.btnSettingsRefreshPosition.Name = "btnSettingsRefreshPosition";
			this.btnSettingsRefreshPosition.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsRefreshPosition.TabIndex = 10;
			this.btnSettingsRefreshPosition.Tag = "Position";
			this.btnSettingsRefreshPosition.Text = "Refresh";
			this.btnSettingsRefreshPosition.UseVisualStyleBackColor = true;
			//
			//Label29
			//
			this.Label29.AutoSize = true;
			this.Label29.Location = new System.Drawing.Point(135, 150);
			this.Label29.Name = "Label29";
			this.Label29.Size = new System.Drawing.Size(75, 13);
			this.Label29.TabIndex = 9;
			this.Label29.Text = "Work Z 0 cmd";
			//
			//tbWorkZ0Cmd
			//
			this.tbWorkZ0Cmd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "WorkZ0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbWorkZ0Cmd.Location = new System.Drawing.Point(12, 147);
			this.tbWorkZ0Cmd.Name = "tbWorkZ0Cmd";
			this.tbWorkZ0Cmd.Size = new System.Drawing.Size(117, 20);
			this.tbWorkZ0Cmd.TabIndex = 8;
			this.tbWorkZ0Cmd.Text = global::GrblPanel.My.MySettings.Default.WorkZ0Cmd;
			//
			//Label28
			//
			this.Label28.AutoSize = true;
			this.Label28.Location = new System.Drawing.Point(135, 124);
			this.Label28.Name = "Label28";
			this.Label28.Size = new System.Drawing.Size(75, 13);
			this.Label28.TabIndex = 7;
			this.Label28.Text = "Work Y 0 cmd";
			//
			//tbWorkY0Cmd
			//
			this.tbWorkY0Cmd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "WorkY0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbWorkY0Cmd.Location = new System.Drawing.Point(12, 121);
			this.tbWorkY0Cmd.Name = "tbWorkY0Cmd";
			this.tbWorkY0Cmd.Size = new System.Drawing.Size(117, 20);
			this.tbWorkY0Cmd.TabIndex = 6;
			this.tbWorkY0Cmd.Text = global::GrblPanel.My.MySettings.Default.WorkY0Cmd;
			//
			//Label13
			//
			this.Label13.AutoSize = true;
			this.Label13.Location = new System.Drawing.Point(135, 99);
			this.Label13.Name = "Label13";
			this.Label13.Size = new System.Drawing.Size(75, 13);
			this.Label13.TabIndex = 5;
			this.Label13.Text = "Work X 0 cmd";
			//
			//Label12
			//
			this.Label12.AutoSize = true;
			this.Label12.Location = new System.Drawing.Point(135, 73);
			this.Label12.Name = "Label12";
			this.Label12.Size = new System.Drawing.Size(67, 13);
			this.Label12.TabIndex = 4;
			this.Label12.Text = "Zero All Cmd";
			//
			//tbWorkX0Cmd
			//
			this.tbWorkX0Cmd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "WorkX0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbWorkX0Cmd.Location = new System.Drawing.Point(12, 96);
			this.tbWorkX0Cmd.Name = "tbWorkX0Cmd";
			this.tbWorkX0Cmd.Size = new System.Drawing.Size(117, 20);
			this.tbWorkX0Cmd.TabIndex = 3;
			this.tbWorkX0Cmd.Text = global::GrblPanel.My.MySettings.Default.WorkX0Cmd;
			//
			//tbSettingsZeroXYZCmd
			//
			this.tbSettingsZeroXYZCmd.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "Work0Cmd", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsZeroXYZCmd.Location = new System.Drawing.Point(12, 70);
			this.tbSettingsZeroXYZCmd.Name = "tbSettingsZeroXYZCmd";
			this.tbSettingsZeroXYZCmd.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsZeroXYZCmd.TabIndex = 2;
			this.tbSettingsZeroXYZCmd.Text = global::GrblPanel.My.MySettings.Default.Work0Cmd;
			//
			//Label11
			//
			this.Label11.AutoSize = true;
			this.Label11.Location = new System.Drawing.Point(135, 21);
			this.Label11.Name = "Label11";
			this.Label11.Size = new System.Drawing.Size(94, 13);
			this.Label11.TabIndex = 1;
			this.Label11.Text = "Go To Spcl Posn1";
			this.ToolTip1.SetToolTip(this.Label11, "Also known as Soft Home");
			//
			//tbSettingsSpclPosition1
			//
			this.tbSettingsSpclPosition1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "MachineSpclPosition1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsSpclPosition1.Location = new System.Drawing.Point(12, 18);
			this.tbSettingsSpclPosition1.Name = "tbSettingsSpclPosition1";
			this.tbSettingsSpclPosition1.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsSpclPosition1.TabIndex = 0;
			this.tbSettingsSpclPosition1.Text = global::GrblPanel.My.MySettings.Default.MachineSpclPosition1;
			//
			//gbSettingsJogging
			//
			this.gbSettingsJogging.Controls.Add(this.cbSettingsKeyboardJogging);
			this.gbSettingsJogging.Controls.Add(this.btnSettingsRefreshJogging);
			this.gbSettingsJogging.Controls.Add(this.Label41);
			this.gbSettingsJogging.Controls.Add(this.Label40);
			this.gbSettingsJogging.Controls.Add(this.Label39);
			this.gbSettingsJogging.Controls.Add(this.Label38);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsZRepeat);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsYRepeat);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsXRepeat);
			this.gbSettingsJogging.Controls.Add(this.Label35);
			this.gbSettingsJogging.Controls.Add(this.Label34);
			this.gbSettingsJogging.Controls.Add(this.Label32);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsFRMetric);
			this.gbSettingsJogging.Controls.Add(this.Label33);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsFIMetric);
			this.gbSettingsJogging.Controls.Add(this.Label31);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsFRImperial);
			this.gbSettingsJogging.Controls.Add(this.Label30);
			this.gbSettingsJogging.Controls.Add(this.cbSettingsMetric);
			this.gbSettingsJogging.Controls.Add(this.tbSettingsFIImperial);
			this.gbSettingsJogging.Location = new System.Drawing.Point(607, 19);
			this.gbSettingsJogging.Name = "gbSettingsJogging";
			this.gbSettingsJogging.Size = new System.Drawing.Size(220, 324);
			this.gbSettingsJogging.TabIndex = 0;
			this.gbSettingsJogging.TabStop = false;
			this.gbSettingsJogging.Text = "Jogging";
			//
			//cbSettingsKeyboardJogging
			//
			this.cbSettingsKeyboardJogging.AutoSize = true;
			this.cbSettingsKeyboardJogging.Checked = global::GrblPanel.My.MySettings.Default.JoggingUseKeyboard;
			this.cbSettingsKeyboardJogging.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "JoggingUseKeyboard", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbSettingsKeyboardJogging.Location = new System.Drawing.Point(6, 267);
			this.cbSettingsKeyboardJogging.Name = "cbSettingsKeyboardJogging";
			this.cbSettingsKeyboardJogging.Size = new System.Drawing.Size(140, 17);
			this.cbSettingsKeyboardJogging.TabIndex = 27;
			this.cbSettingsKeyboardJogging.Text = "Enable keyboard arrows";
			this.ToolTip1.SetToolTip(this.cbSettingsKeyboardJogging, "Allow arrows, pg up, pg dn to do jogging");
			this.cbSettingsKeyboardJogging.UseVisualStyleBackColor = true;
			//
			//btnSettingsRefreshJogging
			//
			this.btnSettingsRefreshJogging.Location = new System.Drawing.Point(0, 301);
			this.btnSettingsRefreshJogging.Name = "btnSettingsRefreshJogging";
			this.btnSettingsRefreshJogging.Size = new System.Drawing.Size(75, 23);
			this.btnSettingsRefreshJogging.TabIndex = 11;
			this.btnSettingsRefreshJogging.Tag = "Jogging";
			this.btnSettingsRefreshJogging.Text = "Refresh";
			this.btnSettingsRefreshJogging.UseVisualStyleBackColor = true;
			//
			//Label41
			//
			this.Label41.AutoSize = true;
			this.Label41.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label41.Location = new System.Drawing.Point(48, 167);
			this.Label41.Name = "Label41";
			this.Label41.Size = new System.Drawing.Size(158, 13);
			this.Label41.TabIndex = 26;
			this.Label41.Text = "Button Repeat Rate, r/sec";
			//
			//Label40
			//
			this.Label40.AutoSize = true;
			this.Label40.Location = new System.Drawing.Point(129, 244);
			this.Label40.Name = "Label40";
			this.Label40.Size = new System.Drawing.Size(78, 13);
			this.Label40.TabIndex = 25;
			this.Label40.Text = "Z Repeat Rate";
			//
			//Label39
			//
			this.Label39.AutoSize = true;
			this.Label39.Location = new System.Drawing.Point(129, 218);
			this.Label39.Name = "Label39";
			this.Label39.Size = new System.Drawing.Size(78, 13);
			this.Label39.TabIndex = 24;
			this.Label39.Text = "Y Repeat Rate";
			//
			//Label38
			//
			this.Label38.AutoSize = true;
			this.Label38.Location = new System.Drawing.Point(129, 192);
			this.Label38.Name = "Label38";
			this.Label38.Size = new System.Drawing.Size(78, 13);
			this.Label38.TabIndex = 23;
			this.Label38.Text = "X Repeat Rate";
			//
			//tbSettingsZRepeat
			//
			this.tbSettingsZRepeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingZRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsZRepeat.Location = new System.Drawing.Point(6, 241);
			this.tbSettingsZRepeat.Name = "tbSettingsZRepeat";
			this.tbSettingsZRepeat.Size = new System.Drawing.Size(45, 20);
			this.tbSettingsZRepeat.TabIndex = 22;
			this.tbSettingsZRepeat.Text = global::GrblPanel.My.MySettings.Default.JoggingZRepeat;
			//
			//tbSettingsYRepeat
			//
			this.tbSettingsYRepeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingYRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsYRepeat.Location = new System.Drawing.Point(6, 215);
			this.tbSettingsYRepeat.Name = "tbSettingsYRepeat";
			this.tbSettingsYRepeat.Size = new System.Drawing.Size(45, 20);
			this.tbSettingsYRepeat.TabIndex = 21;
			this.tbSettingsYRepeat.Text = global::GrblPanel.My.MySettings.Default.JoggingYRepeat;
			//
			//tbSettingsXRepeat
			//
			this.tbSettingsXRepeat.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingXRepeat", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsXRepeat.Location = new System.Drawing.Point(6, 189);
			this.tbSettingsXRepeat.Name = "tbSettingsXRepeat";
			this.tbSettingsXRepeat.Size = new System.Drawing.Size(45, 20);
			this.tbSettingsXRepeat.TabIndex = 20;
			this.tbSettingsXRepeat.Text = global::GrblPanel.My.MySettings.Default.JoggingXRepeat;
			//
			//Label35
			//
			this.Label35.AutoSize = true;
			this.Label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label35.Location = new System.Drawing.Point(136, 104);
			this.Label35.Name = "Label35";
			this.Label35.Size = new System.Drawing.Size(42, 13);
			this.Label35.TabIndex = 19;
			this.Label35.Text = "Metric";
			//
			//Label34
			//
			this.Label34.AutoSize = true;
			this.Label34.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, Convert.ToByte(0));
			this.Label34.Location = new System.Drawing.Point(136, 38);
			this.Label34.Name = "Label34";
			this.Label34.Size = new System.Drawing.Size(51, 13);
			this.Label34.TabIndex = 18;
			this.Label34.Text = "Imperial";
			//
			//Label32
			//
			this.Label32.AutoSize = true;
			this.Label32.Location = new System.Drawing.Point(129, 146);
			this.Label32.Name = "Label32";
			this.Label32.Size = new System.Drawing.Size(62, 13);
			this.Label32.TabIndex = 17;
			this.Label32.Text = "Feed Rates";
			//
			//tbSettingsFRMetric
			//
			this.tbSettingsFRMetric.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingFRMetric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsFRMetric.Location = new System.Drawing.Point(6, 143);
			this.tbSettingsFRMetric.Name = "tbSettingsFRMetric";
			this.tbSettingsFRMetric.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsFRMetric.TabIndex = 16;
			this.tbSettingsFRMetric.Text = global::GrblPanel.My.MySettings.Default.JoggingFRMetric;
			//
			//Label33
			//
			this.Label33.AutoSize = true;
			this.Label33.Location = new System.Drawing.Point(129, 120);
			this.Label33.Name = "Label33";
			this.Label33.Size = new System.Drawing.Size(86, 13);
			this.Label33.TabIndex = 15;
			this.Label33.Text = "Feed Increments";
			//
			//tbSettingsFIMetric
			//
			this.tbSettingsFIMetric.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingFIMEtric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsFIMetric.Location = new System.Drawing.Point(6, 117);
			this.tbSettingsFIMetric.Name = "tbSettingsFIMetric";
			this.tbSettingsFIMetric.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsFIMetric.TabIndex = 14;
			this.tbSettingsFIMetric.Text = global::GrblPanel.My.MySettings.Default.JoggingFIMEtric;
			//
			//Label31
			//
			this.Label31.AutoSize = true;
			this.Label31.Location = new System.Drawing.Point(129, 85);
			this.Label31.Name = "Label31";
			this.Label31.Size = new System.Drawing.Size(62, 13);
			this.Label31.TabIndex = 13;
			this.Label31.Text = "Feed Rates";
			//
			//tbSettingsFRImperial
			//
			this.tbSettingsFRImperial.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingFRImperial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsFRImperial.Location = new System.Drawing.Point(6, 82);
			this.tbSettingsFRImperial.Name = "tbSettingsFRImperial";
			this.tbSettingsFRImperial.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsFRImperial.TabIndex = 12;
			this.tbSettingsFRImperial.Text = global::GrblPanel.My.MySettings.Default.JoggingFRImperial;
			//
			//Label30
			//
			this.Label30.AutoSize = true;
			this.Label30.Location = new System.Drawing.Point(129, 59);
			this.Label30.Name = "Label30";
			this.Label30.Size = new System.Drawing.Size(86, 13);
			this.Label30.TabIndex = 11;
			this.Label30.Text = "Feed Increments";
			//
			//cbSettingsMetric
			//
			this.cbSettingsMetric.AutoSize = true;
			this.cbSettingsMetric.Checked = global::GrblPanel.My.MySettings.Default.JoggingUnitsMetric;
			this.cbSettingsMetric.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::GrblPanel.My.MySettings.Default, "joggingUnitsMetric", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.cbSettingsMetric.Location = new System.Drawing.Point(3, 21);
			this.cbSettingsMetric.Name = "cbSettingsMetric";
			this.cbSettingsMetric.Size = new System.Drawing.Size(55, 17);
			this.cbSettingsMetric.TabIndex = 0;
			this.cbSettingsMetric.Text = "Metric";
			this.cbSettingsMetric.UseVisualStyleBackColor = true;
			//
			//tbSettingsFIImperial
			//
			this.tbSettingsFIImperial.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GrblPanel.My.MySettings.Default, "JoggingFIImperial", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
			this.tbSettingsFIImperial.Location = new System.Drawing.Point(6, 56);
			this.tbSettingsFIImperial.Name = "tbSettingsFIImperial";
			this.tbSettingsFIImperial.Size = new System.Drawing.Size(117, 20);
			this.tbSettingsFIImperial.TabIndex = 10;
			this.tbSettingsFIImperial.Text = global::GrblPanel.My.MySettings.Default.JoggingFIImperial;
			//
			//TabPage1
			//
			this.TabPage1.Controls.Add(this.gbEditor);
			this.TabPage1.Controls.Add(this.btnCancel);
			this.TabPage1.Controls.Add(this.btnOK);
			this.TabPage1.Controls.Add(this.dgMacros);
			this.TabPage1.Controls.Add(this.lblStatusLabel);
			this.TabPage1.Controls.Add(this.btnDeleteMacro);
			this.TabPage1.Location = new System.Drawing.Point(4, 22);
			this.TabPage1.Name = "TabPage1";
			this.TabPage1.Size = new System.Drawing.Size(1134, 677);
			this.TabPage1.TabIndex = 2;
			this.TabPage1.Text = "Macros";
			this.TabPage1.UseVisualStyleBackColor = true;
			//
			//gbEditor
			//
			this.gbEditor.Controls.Add(this.btnAdd);
			this.gbEditor.Controls.Add(this.lblGCode);
			this.gbEditor.Controls.Add(this.tbGCode);
			this.gbEditor.Controls.Add(this.lblName);
			this.gbEditor.Controls.Add(this.tbName);
			this.gbEditor.Location = new System.Drawing.Point(6, 147);
			this.gbEditor.Name = "gbEditor";
			this.gbEditor.Size = new System.Drawing.Size(246, 111);
			this.gbEditor.TabIndex = 8;
			this.gbEditor.TabStop = false;
			this.gbEditor.Text = "Editor";
			//
			//btnAdd
			//
			this.btnAdd.Location = new System.Drawing.Point(166, 17);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(64, 23);
			this.btnAdd.TabIndex = 4;
			this.btnAdd.Text = "Add";
			this.btnAdd.UseVisualStyleBackColor = true;
			//
			//lblGCode
			//
			this.lblGCode.Location = new System.Drawing.Point(9, 51);
			this.lblGCode.Name = "lblGCode";
			this.lblGCode.Size = new System.Drawing.Size(50, 15);
			this.lblGCode.TabIndex = 3;
			this.lblGCode.Text = "G Code:";
			this.lblGCode.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//tbGCode
			//
			this.tbGCode.AcceptsReturn = true;
			this.tbGCode.Location = new System.Drawing.Point(62, 48);
			this.tbGCode.Multiline = true;
			this.tbGCode.Name = "tbGCode";
			this.tbGCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbGCode.Size = new System.Drawing.Size(168, 57);
			this.tbGCode.TabIndex = 2;
			//
			//lblName
			//
			this.lblName.Location = new System.Drawing.Point(9, 22);
			this.lblName.Name = "lblName";
			this.lblName.Size = new System.Drawing.Size(50, 15);
			this.lblName.TabIndex = 1;
			this.lblName.Text = "Name:";
			this.lblName.TextAlign = System.Drawing.ContentAlignment.TopRight;
			//
			//tbName
			//
			this.tbName.Location = new System.Drawing.Point(61, 19);
			this.tbName.Name = "tbName";
			this.tbName.Size = new System.Drawing.Size(99, 20);
			this.tbName.TabIndex = 0;
			//
			//btnCancel
			//
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(177, 32);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 10;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			//
			//btnOK
			//
			this.btnOK.Location = new System.Drawing.Point(177, 3);
			this.btnOK.Name = "btnOK";
			this.btnOK.Size = new System.Drawing.Size(75, 23);
			this.btnOK.TabIndex = 9;
			this.btnOK.Text = "OK";
			this.btnOK.UseVisualStyleBackColor = true;
			//
			//dgMacros
			//
			this.dgMacros.AllowUserToAddRows = false;
			this.dgMacros.AllowUserToDeleteRows = false;
			this.dgMacros.AllowUserToResizeColumns = false;
			this.dgMacros.AllowUserToResizeRows = false;
			this.dgMacros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMacros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
				this.Column1,
				this.Column2
			});
			this.dgMacros.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
			this.dgMacros.Location = new System.Drawing.Point(18, 3);
			this.dgMacros.Name = "dgMacros";
			this.dgMacros.ReadOnly = true;
			this.dgMacros.RowHeadersVisible = false;
			this.dgMacros.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dgMacros.ScrollBars = System.Windows.Forms.ScrollBars.None;
			this.dgMacros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgMacros.Size = new System.Drawing.Size(148, 134);
			this.dgMacros.TabIndex = 11;
			//
			//Column1
			//
			this.Column1.HeaderText = "Name";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			//
			//Column2
			//
			this.Column2.HeaderText = "GCode";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			//
			//lblStatusLabel
			//
			this.lblStatusLabel.Location = new System.Drawing.Point(9, 263);
			this.lblStatusLabel.Name = "lblStatusLabel";
			this.lblStatusLabel.Size = new System.Drawing.Size(242, 23);
			this.lblStatusLabel.TabIndex = 13;
			//
			//btnDeleteMacro
			//
			this.btnDeleteMacro.Location = new System.Drawing.Point(177, 102);
			this.btnDeleteMacro.Name = "btnDeleteMacro";
			this.btnDeleteMacro.Size = new System.Drawing.Size(74, 34);
			this.btnDeleteMacro.TabIndex = 12;
			this.btnDeleteMacro.Text = "Delete Selected";
			this.btnDeleteMacro.UseVisualStyleBackColor = true;
			//
			//ofdGcodeFile
			//
			this.ofdGcodeFile.DefaultExt = "ngc";
			this.ofdGcodeFile.FileName = "*.*";
			this.ofdGcodeFile.Filter = "All files (*.*)|*.*";
			//
			//sfdOffsets
			//
			this.sfdOffsets.DefaultExt = "xml";
			this.sfdOffsets.Filter = "WorkOffset Files|*.xml";
			//
			//ofdOffsets
			//
			this.ofdOffsets.DefaultExt = "xml";
			this.ofdOffsets.FileName = "OpenFileDialog1";
			this.ofdOffsets.Filter = "WorkOffset Files|*.xml";
			//
			//GrblGui
			//
			this.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(1143, 729);
			this.Controls.Add(this.TabControl1);
			this.Controls.Add(this.MenuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.KeyPreview = true;
			this.MainMenuStrip = this.MenuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "GrblGui";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Panneau de Contrôle GRBL - Le Bear CNC -";
			this.MenuStrip1.ResumeLayout(false);
			this.MenuStrip1.PerformLayout();
			this.TabControl1.ResumeLayout(false);
			this.tabPgInterface.ResumeLayout(false);
			this.GroupBox2.ResumeLayout(false);
			this.GroupBox2.PerformLayout();
			this.gbState.ResumeLayout(false);
			this.gbState.PerformLayout();
			this.Panel2.ResumeLayout(false);
			this.Panel2.PerformLayout();
			this.Panel1.ResumeLayout(false);
			this.Panel1.PerformLayout();
			this.gbControl.ResumeLayout(false);
			this.gbControl.PerformLayout();
			this.gbMDI.ResumeLayout(false);
			this.gbMDI.PerformLayout();
			this.gbJogging.ResumeLayout(false);
			this.gbJogging.PerformLayout();
			this.gbFeedRate.ResumeLayout(false);
			this.gbFeedRate.PerformLayout();
			this.gbDistance.ResumeLayout(false);
			this.gbDistance.PerformLayout();
			this.gbStatus.ResumeLayout(false);
			this.gbStatus.PerformLayout();
			this.gbGcode.ResumeLayout(false);
			this.gbGcode.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgvGcode).EndInit();
			this.gbGrbl.ResumeLayout(false);
			this.tcConnection.ResumeLayout(false);
			this.tbGrblCOM.ResumeLayout(false);
			this.tbGrblIP.ResumeLayout(false);
			this.tbGrblIP.PerformLayout();
			this.gbPosition.ResumeLayout(false);
			this.tabCtlPosition.ResumeLayout(false);
			this.tpWork.ResumeLayout(false);
			this.tpWork.PerformLayout();
			this.Panel5.ResumeLayout(false);
			this.Panel5.PerformLayout();
			this.Panel4.ResumeLayout(false);
			this.Panel4.PerformLayout();
			this.Panel3.ResumeLayout(false);
			this.Panel3.PerformLayout();
			this.GroupBox1.ResumeLayout(false);
			this.GroupBox1.PerformLayout();
			this.tpOffsets.ResumeLayout(false);
			this.tpOffsets.PerformLayout();
			this.tabPgSettings.ResumeLayout(false);
			this.tabPgSettings.PerformLayout();
			this.gbGrblSettings.ResumeLayout(false);
			this.gbGrblSettings.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgGrblSettings).EndInit();
			this.gbSettingsOffsets.ResumeLayout(false);
			this.gbSettingsOffsets.PerformLayout();
			this.gbSettingsMisc.ResumeLayout(false);
			this.gbSettingsMisc.PerformLayout();
			this.gbSettingsPosition.ResumeLayout(false);
			this.gbSettingsPosition.PerformLayout();
			this.gbSettingsJogging.ResumeLayout(false);
			this.gbSettingsJogging.PerformLayout();
			this.TabPage1.ResumeLayout(false);
			this.gbEditor.ResumeLayout(false);
			this.gbEditor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)this.dgMacros).EndInit();
			((System.ComponentModel.ISupportInitialize)this.GrblSettingsBindingSource).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		internal System.Windows.Forms.MenuStrip MenuStrip1;
		internal System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem1;
		internal System.Windows.Forms.ToolStripMenuItem SaveToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_ExitToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem {
			get { return withEventsField_ExitToolStripMenuItem; }
			set {
				if (withEventsField_ExitToolStripMenuItem != null) {
					withEventsField_ExitToolStripMenuItem.Click -= ExitToolStripMenuItem_Click;
				}
				withEventsField_ExitToolStripMenuItem = value;
				if (withEventsField_ExitToolStripMenuItem != null) {
					withEventsField_ExitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem ToolsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_OptionsToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem OptionsToolStripMenuItem {
			get { return withEventsField_OptionsToolStripMenuItem; }
			set {
				if (withEventsField_OptionsToolStripMenuItem != null) {
					withEventsField_OptionsToolStripMenuItem.Click -= OptionsToolStripMenuItem_Click;
				}
				withEventsField_OptionsToolStripMenuItem = value;
				if (withEventsField_OptionsToolStripMenuItem != null) {
					withEventsField_OptionsToolStripMenuItem.Click += OptionsToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.ToolStripMenuItem HelpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem withEventsField_AboutToolStripMenuItem;
		internal System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem {
			get { return withEventsField_AboutToolStripMenuItem; }
			set {
				if (withEventsField_AboutToolStripMenuItem != null) {
					withEventsField_AboutToolStripMenuItem.Click -= AboutToolStripMenuItem_Click;
				}
				withEventsField_AboutToolStripMenuItem = value;
				if (withEventsField_AboutToolStripMenuItem != null) {
					withEventsField_AboutToolStripMenuItem.Click += AboutToolStripMenuItem_Click;
				}
			}
		}
		internal System.Windows.Forms.TabControl TabControl1;
		internal System.Windows.Forms.TabPage tabPgInterface;
		internal System.Windows.Forms.GroupBox gbJogging;
		private System.Windows.Forms.RadioButton withEventsField_rbFeedRate4;
		internal System.Windows.Forms.RadioButton rbFeedRate4 {
			get { return withEventsField_rbFeedRate4; }
			set {
				if (withEventsField_rbFeedRate4 != null) {
					withEventsField_rbFeedRate4.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbFeedRate4 = value;
				if (withEventsField_rbFeedRate4 != null) {
					withEventsField_rbFeedRate4.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbFeedRate3;
		internal System.Windows.Forms.RadioButton rbFeedRate3 {
			get { return withEventsField_rbFeedRate3; }
			set {
				if (withEventsField_rbFeedRate3 != null) {
					withEventsField_rbFeedRate3.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbFeedRate3 = value;
				if (withEventsField_rbFeedRate3 != null) {
					withEventsField_rbFeedRate3.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbFeedRate1;
		internal System.Windows.Forms.RadioButton rbFeedRate1 {
			get { return withEventsField_rbFeedRate1; }
			set {
				if (withEventsField_rbFeedRate1 != null) {
					withEventsField_rbFeedRate1.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbFeedRate1 = value;
				if (withEventsField_rbFeedRate1 != null) {
					withEventsField_rbFeedRate1.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbFeedRate2;
		internal System.Windows.Forms.RadioButton rbFeedRate2 {
			get { return withEventsField_rbFeedRate2; }
			set {
				if (withEventsField_rbFeedRate2 != null) {
					withEventsField_rbFeedRate2.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbFeedRate2 = value;
				if (withEventsField_rbFeedRate2 != null) {
					withEventsField_rbFeedRate2.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbDistance4;
		internal System.Windows.Forms.RadioButton rbDistance4 {
			get { return withEventsField_rbDistance4; }
			set {
				if (withEventsField_rbDistance4 != null) {
					withEventsField_rbDistance4.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbDistance4 = value;
				if (withEventsField_rbDistance4 != null) {
					withEventsField_rbDistance4.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbDistance3;
		internal System.Windows.Forms.RadioButton rbDistance3 {
			get { return withEventsField_rbDistance3; }
			set {
				if (withEventsField_rbDistance3 != null) {
					withEventsField_rbDistance3.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbDistance3 = value;
				if (withEventsField_rbDistance3 != null) {
					withEventsField_rbDistance3.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbDistance2;
		internal System.Windows.Forms.RadioButton rbDistance2 {
			get { return withEventsField_rbDistance2; }
			set {
				if (withEventsField_rbDistance2 != null) {
					withEventsField_rbDistance2.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbDistance2 = value;
				if (withEventsField_rbDistance2 != null) {
					withEventsField_rbDistance2.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.RadioButton withEventsField_rbDistance1;
		internal System.Windows.Forms.RadioButton rbDistance1 {
			get { return withEventsField_rbDistance1; }
			set {
				if (withEventsField_rbDistance1 != null) {
					withEventsField_rbDistance1.CheckedChanged -= rbDistancex_CheckedChanged;
				}
				withEventsField_rbDistance1 = value;
				if (withEventsField_rbDistance1 != null) {
					withEventsField_rbDistance1.CheckedChanged += rbDistancex_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.TabPage tabPgSettings;
		internal System.Windows.Forms.GroupBox gbPosition;
		internal System.Windows.Forms.GroupBox gbGrbl;
		private System.Windows.Forms.Button withEventsField_btnConnect;
		internal System.Windows.Forms.Button btnConnect {
			get { return withEventsField_btnConnect; }
			set {
				if (withEventsField_btnConnect != null) {
					withEventsField_btnConnect.Click -= btnConnDisconnect_Click;
				}
				withEventsField_btnConnect = value;
				if (withEventsField_btnConnect != null) {
					withEventsField_btnConnect.Click += btnConnDisconnect_Click;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cbPorts;
		internal System.Windows.Forms.ComboBox cbPorts {
			get { return withEventsField_cbPorts; }
			set {
				if (withEventsField_cbPorts != null) {
					withEventsField_cbPorts.SelectedIndexChanged -= lbPorts_SelectedIndexChanged;
				}
				withEventsField_cbPorts = value;
				if (withEventsField_cbPorts != null) {
					withEventsField_cbPorts.SelectedIndexChanged += lbPorts_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cbBaud;
		internal System.Windows.Forms.ComboBox cbBaud {
			get { return withEventsField_cbBaud; }
			set {
				if (withEventsField_cbBaud != null) {
					withEventsField_cbBaud.SelectedIndexChanged -= cbBaud_SelectedIndexChanged;
				}
				withEventsField_cbBaud = value;
				if (withEventsField_cbBaud != null) {
					withEventsField_cbBaud.SelectedIndexChanged += cbBaud_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.ListBox lbResponses;
		private System.Windows.Forms.Button withEventsField_btnSend;
		internal System.Windows.Forms.Button btnSend {
			get { return withEventsField_btnSend; }
			set {
				if (withEventsField_btnSend != null) {
					withEventsField_btnSend.Click -= btnSend_Click;
				}
				withEventsField_btnSend = value;
				if (withEventsField_btnSend != null) {
					withEventsField_btnSend.Click += btnSend_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbSendData;
		internal System.Windows.Forms.TextBox tbSendData {
			get { return withEventsField_tbSendData; }
			set {
				if (withEventsField_tbSendData != null) {
					withEventsField_tbSendData.KeyDown -= tbSendData_KeyDown;
				}
				withEventsField_tbSendData = value;
				if (withEventsField_tbSendData != null) {
					withEventsField_tbSendData.KeyDown += tbSendData_KeyDown;
				}
			}
		}
		internal System.Windows.Forms.TextBox tbMachX;
		internal System.Windows.Forms.TextBox tbMachY;
		internal System.Windows.Forms.TextBox tbMachZ;
		internal System.Windows.Forms.TextBox tbWorkZ;
		internal System.Windows.Forms.TextBox tbWorkY;
		private System.Windows.Forms.Button withEventsField_btnWorkZ0;
		internal System.Windows.Forms.Button btnWorkZ0 {
			get { return withEventsField_btnWorkZ0; }
			set {
				if (withEventsField_btnWorkZ0 != null) {
					withEventsField_btnWorkZ0.Click -= btnWorkXYZ0_Click;
				}
				withEventsField_btnWorkZ0 = value;
				if (withEventsField_btnWorkZ0 != null) {
					withEventsField_btnWorkZ0.Click += btnWorkXYZ0_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnWorkY0;
		internal System.Windows.Forms.Button btnWorkY0 {
			get { return withEventsField_btnWorkY0; }
			set {
				if (withEventsField_btnWorkY0 != null) {
					withEventsField_btnWorkY0.Click -= btnWorkXYZ0_Click;
				}
				withEventsField_btnWorkY0 = value;
				if (withEventsField_btnWorkY0 != null) {
					withEventsField_btnWorkY0.Click += btnWorkXYZ0_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnWorkX0;
		internal System.Windows.Forms.Button btnWorkX0 {
			get { return withEventsField_btnWorkX0; }
			set {
				if (withEventsField_btnWorkX0 != null) {
					withEventsField_btnWorkX0.Click -= btnWorkXYZ0_Click;
				}
				withEventsField_btnWorkX0 = value;
				if (withEventsField_btnWorkX0 != null) {
					withEventsField_btnWorkX0.Click += btnWorkXYZ0_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.Label Label1;
		private System.Windows.Forms.Button withEventsField_btnHome;
		internal System.Windows.Forms.Button btnHome {
			get { return withEventsField_btnHome; }
			set {
				if (withEventsField_btnHome != null) {
					withEventsField_btnHome.Click -= btnPosition_Click;
				}
				withEventsField_btnHome = value;
				if (withEventsField_btnHome != null) {
					withEventsField_btnHome.Click += btnPosition_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnWork0;
		internal System.Windows.Forms.Button btnWork0 {
			get { return withEventsField_btnWork0; }
			set {
				if (withEventsField_btnWork0 != null) {
					withEventsField_btnWork0.Click -= btnPosition_Click;
				}
				withEventsField_btnWork0 = value;
				if (withEventsField_btnWork0 != null) {
					withEventsField_btnWork0.Click += btnPosition_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnReset;
		public System.Windows.Forms.Button btnReset {
			get { return withEventsField_btnReset; }
			set {
				if (withEventsField_btnReset != null) {
					withEventsField_btnReset.Click -= btnReset_Click;
				}
				withEventsField_btnReset = value;
				if (withEventsField_btnReset != null) {
					withEventsField_btnReset.Click += btnReset_Click;
				}
			}
		}
		internal System.Windows.Forms.CheckBox cbVerbose;
		private System.Windows.Forms.CheckBox withEventsField_cbUnits;
		internal System.Windows.Forms.CheckBox cbUnits {
			get { return withEventsField_cbUnits; }
			set {
				if (withEventsField_cbUnits != null) {
					withEventsField_cbUnits.CheckedChanged -= cbUnits_CheckedChanged;
				}
				withEventsField_cbUnits = value;
				if (withEventsField_cbUnits != null) {
					withEventsField_cbUnits.CheckedChanged += cbUnits_CheckedChanged;
				}
			}
		}
		internal System.Windows.Forms.GroupBox gbFeedRate;
		internal System.Windows.Forms.GroupBox gbDistance;
		internal System.Windows.Forms.GroupBox gbSettingsJogging;
		private System.Windows.Forms.CheckBox withEventsField_cbSettingsMetric;
		internal System.Windows.Forms.CheckBox cbSettingsMetric {
			get { return withEventsField_cbSettingsMetric; }
			set {
				if (withEventsField_cbSettingsMetric != null) {
					withEventsField_cbSettingsMetric.CheckedChanged -= cbSettingsMetric_CheckedChanged;
				}
				withEventsField_cbSettingsMetric = value;
				if (withEventsField_cbSettingsMetric != null) {
					withEventsField_cbSettingsMetric.CheckedChanged += cbSettingsMetric_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnFileSend;
		internal System.Windows.Forms.Button btnFileSend {
			get { return withEventsField_btnFileSend; }
			set {
				if (withEventsField_btnFileSend != null) {
					withEventsField_btnFileSend.Click -= btnFileGroup_Click;
					withEventsField_btnFileSend.MouseHover -= btnFileSend_MouseHover;
				}
				withEventsField_btnFileSend = value;
				if (withEventsField_btnFileSend != null) {
					withEventsField_btnFileSend.Click += btnFileGroup_Click;
					withEventsField_btnFileSend.MouseHover += btnFileSend_MouseHover;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnFileSelect;
		internal System.Windows.Forms.Button btnFileSelect {
			get { return withEventsField_btnFileSelect; }
			set {
				if (withEventsField_btnFileSelect != null) {
					withEventsField_btnFileSelect.Click -= btnFileGroup_Click;
				}
				withEventsField_btnFileSelect = value;
				if (withEventsField_btnFileSelect != null) {
					withEventsField_btnFileSelect.Click += btnFileGroup_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnFilePause;
		internal System.Windows.Forms.Button btnFilePause {
			get { return withEventsField_btnFilePause; }
			set {
				if (withEventsField_btnFilePause != null) {
					withEventsField_btnFilePause.Click -= btnFileGroup_Click;
				}
				withEventsField_btnFilePause = value;
				if (withEventsField_btnFilePause != null) {
					withEventsField_btnFilePause.Click += btnFileGroup_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnFileStop;
		internal System.Windows.Forms.Button btnFileStop {
			get { return withEventsField_btnFileStop; }
			set {
				if (withEventsField_btnFileStop != null) {
					withEventsField_btnFileStop.Click -= btnFileGroup_Click;
				}
				withEventsField_btnFileStop = value;
				if (withEventsField_btnFileStop != null) {
					withEventsField_btnFileStop.Click += btnFileGroup_Click;
				}
			}
		}
		private System.Windows.Forms.OpenFileDialog ofdGcodeFile;
		internal System.Windows.Forms.TextBox tbGcodeFile;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.GroupBox gbSettingsPosition;
		internal System.Windows.Forms.Label Label13;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.TextBox tbWorkX0Cmd;
		internal System.Windows.Forms.TextBox tbSettingsZeroXYZCmd;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.TextBox tbSettingsSpclPosition1;
		private System.Windows.Forms.Button withEventsField_btnUnlock;
		public System.Windows.Forms.Button btnUnlock {
			get { return withEventsField_btnUnlock; }
			set {
				if (withEventsField_btnUnlock != null) {
					withEventsField_btnUnlock.Click -= btnUnlock_Click;
				}
				withEventsField_btnUnlock = value;
				if (withEventsField_btnUnlock != null) {
					withEventsField_btnUnlock.Click += btnUnlock_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox gbGcode;
		internal System.Windows.Forms.Label lblTotalLines;
		internal System.Windows.Forms.Label Label23;
		internal System.Windows.Forms.CheckBox cbStatusPollEnable;
		internal System.Windows.Forms.ProgressBar prgBarQ;
		internal System.Windows.Forms.Label Label25;
		internal System.Windows.Forms.Label Label24;
		internal System.Windows.Forms.ProgressBar prgbRxBuf;
		internal System.Windows.Forms.GroupBox gbSettingsMisc;
		internal System.Windows.Forms.Label Label26;
		internal System.Windows.Forms.TextBox tbSettingsPollRate;
		internal System.Windows.Forms.TextBox tbGCodeMessage;
		internal System.Windows.Forms.Label Label27;
		internal System.Windows.Forms.Label Label29;
		internal System.Windows.Forms.TextBox tbWorkZ0Cmd;
		internal System.Windows.Forms.Label Label28;
		internal System.Windows.Forms.TextBox tbWorkY0Cmd;
		private System.Windows.Forms.Button withEventsField_btnHold;
		public System.Windows.Forms.Button btnHold {
			get { return withEventsField_btnHold; }
			set {
				if (withEventsField_btnHold != null) {
					withEventsField_btnHold.Click -= btnHold_Click;
				}
				withEventsField_btnHold = value;
				if (withEventsField_btnHold != null) {
					withEventsField_btnHold.Click += btnHold_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnStartResume;
		public System.Windows.Forms.Button btnStartResume {
			get { return withEventsField_btnStartResume; }
			set {
				if (withEventsField_btnStartResume != null) {
					withEventsField_btnStartResume.Click -= btnStartResume_Click;
				}
				withEventsField_btnStartResume = value;
				if (withEventsField_btnStartResume != null) {
					withEventsField_btnStartResume.Click += btnStartResume_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnRescanPorts;
		internal System.Windows.Forms.Button btnRescanPorts {
			get { return withEventsField_btnRescanPorts; }
			set {
				if (withEventsField_btnRescanPorts != null) {
					withEventsField_btnRescanPorts.Click -= btnRescanPorts_Click;
				}
				withEventsField_btnRescanPorts = value;
				if (withEventsField_btnRescanPorts != null) {
					withEventsField_btnRescanPorts.Click += btnRescanPorts_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label35;
		internal System.Windows.Forms.Label Label34;
		internal System.Windows.Forms.Label Label32;
		internal System.Windows.Forms.TextBox tbSettingsFRMetric;
		internal System.Windows.Forms.Label Label33;
		internal System.Windows.Forms.TextBox tbSettingsFIMetric;
		internal System.Windows.Forms.Label Label31;
		internal System.Windows.Forms.TextBox tbSettingsFRImperial;
		internal System.Windows.Forms.Label Label30;
		internal System.Windows.Forms.TextBox tbSettingsFIImperial;
		internal System.Windows.Forms.Label Label37;
		internal System.Windows.Forms.Label Label36;
		internal System.Windows.Forms.TextBox tbSettingsRBuffSize;
		internal System.Windows.Forms.TextBox tbSettingsQSize;
		internal System.Windows.Forms.Label Label40;
		internal System.Windows.Forms.Label Label39;
		internal System.Windows.Forms.Label Label38;
		internal System.Windows.Forms.TextBox tbSettingsZRepeat;
		internal System.Windows.Forms.TextBox tbSettingsYRepeat;
		internal System.Windows.Forms.TextBox tbSettingsXRepeat;
		internal System.Windows.Forms.Label Label41;
		private System.Windows.Forms.Button withEventsField_btnSettingsRefreshMisc;
		internal System.Windows.Forms.Button btnSettingsRefreshMisc {
			get { return withEventsField_btnSettingsRefreshMisc; }
			set {
				if (withEventsField_btnSettingsRefreshMisc != null) {
					withEventsField_btnSettingsRefreshMisc.Click -= btnSettingsRefreshMisc_Click;
				}
				withEventsField_btnSettingsRefreshMisc = value;
				if (withEventsField_btnSettingsRefreshMisc != null) {
					withEventsField_btnSettingsRefreshMisc.Click += btnSettingsRefreshMisc_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnSettingsRefreshPosition;
		internal System.Windows.Forms.Button btnSettingsRefreshPosition {
			get { return withEventsField_btnSettingsRefreshPosition; }
			set {
				if (withEventsField_btnSettingsRefreshPosition != null) {
					withEventsField_btnSettingsRefreshPosition.Click -= btnSettingsRefreshMisc_Click;
				}
				withEventsField_btnSettingsRefreshPosition = value;
				if (withEventsField_btnSettingsRefreshPosition != null) {
					withEventsField_btnSettingsRefreshPosition.Click += btnSettingsRefreshMisc_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnSettingsRefreshJogging;
		internal System.Windows.Forms.Button btnSettingsRefreshJogging {
			get { return withEventsField_btnSettingsRefreshJogging; }
			set {
				if (withEventsField_btnSettingsRefreshJogging != null) {
					withEventsField_btnSettingsRefreshJogging.Click -= btnSettingsRefreshMisc_Click;
				}
				withEventsField_btnSettingsRefreshJogging = value;
				if (withEventsField_btnSettingsRefreshJogging != null) {
					withEventsField_btnSettingsRefreshJogging.Click += btnSettingsRefreshMisc_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label42;
		internal System.Windows.Forms.CheckBox cbSettingsPauseOnError;
		internal System.Windows.Forms.ToolTip ToolTip1;
		private System.Windows.Forms.Button withEventsField_btnSettingsGrbl;
		internal System.Windows.Forms.Button btnSettingsGrbl {
			get { return withEventsField_btnSettingsGrbl; }
			set {
				if (withEventsField_btnSettingsGrbl != null) {
					withEventsField_btnSettingsGrbl.Click -= btnSettingsGrbl_Click;
				}
				withEventsField_btnSettingsGrbl = value;
				if (withEventsField_btnSettingsGrbl != null) {
					withEventsField_btnSettingsGrbl.Click += btnSettingsGrbl_Click;
				}
			}
		}
		private System.Windows.Forms.DataGridView withEventsField_dgGrblSettings;
		internal System.Windows.Forms.DataGridView dgGrblSettings {
			get { return withEventsField_dgGrblSettings; }
			set {
				if (withEventsField_dgGrblSettings != null) {
					withEventsField_dgGrblSettings.CellMouseDoubleClick -= dgGrblSettings_CellMouseDoubleClick;
				}
				withEventsField_dgGrblSettings = value;
				if (withEventsField_dgGrblSettings != null) {
					withEventsField_dgGrblSettings.CellMouseDoubleClick += dgGrblSettings_CellMouseDoubleClick;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsSave;
		internal System.Windows.Forms.Button btnOffsetsSave {
			get { return withEventsField_btnOffsetsSave; }
			set {
				if (withEventsField_btnOffsetsSave != null) {
					withEventsField_btnOffsetsSave.Click -= btnOffsetsSave_Click;
				}
				withEventsField_btnOffsetsSave = value;
				if (withEventsField_btnOffsetsSave != null) {
					withEventsField_btnOffsetsSave.Click += btnOffsetsSave_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsRetrieve;
		internal System.Windows.Forms.Button btnOffsetsRetrieve {
			get { return withEventsField_btnOffsetsRetrieve; }
			set {
				if (withEventsField_btnOffsetsRetrieve != null) {
					withEventsField_btnOffsetsRetrieve.Click -= btnOffsetsRetrieve_Click;
				}
				withEventsField_btnOffsetsRetrieve = value;
				if (withEventsField_btnOffsetsRetrieve != null) {
					withEventsField_btnOffsetsRetrieve.Click += btnOffsetsRetrieve_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsLoad;
		internal System.Windows.Forms.Button btnOffsetsLoad {
			get { return withEventsField_btnOffsetsLoad; }
			set {
				if (withEventsField_btnOffsetsLoad != null) {
					withEventsField_btnOffsetsLoad.Click -= btnOffsetsLoad_Click;
				}
				withEventsField_btnOffsetsLoad = value;
				if (withEventsField_btnOffsetsLoad != null) {
					withEventsField_btnOffsetsLoad.Click += btnOffsetsLoad_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG43Zero;
		internal System.Windows.Forms.Button btnOffsetsG43Zero {
			get { return withEventsField_btnOffsetsG43Zero; }
			set {
				if (withEventsField_btnOffsetsG43Zero != null) {
					withEventsField_btnOffsetsG43Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG43Zero = value;
				if (withEventsField_btnOffsetsG43Zero != null) {
					withEventsField_btnOffsetsG43Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG43Z;
		internal System.Windows.Forms.TextBox tbOffsetsG43Z {
			get { return withEventsField_tbOffsetsG43Z; }
			set {
				if (withEventsField_tbOffsetsG43Z != null) {
					withEventsField_tbOffsetsG43Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG43Z = value;
				if (withEventsField_tbOffsetsG43Z != null) {
					withEventsField_tbOffsetsG43Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		internal System.Windows.Forms.Label Label18;
		internal System.Windows.Forms.Label Label19;
		internal System.Windows.Forms.Label Label20;
		private System.Windows.Forms.Button withEventsField_btnOffsetsG30Set;
		internal System.Windows.Forms.Button btnOffsetsG30Set {
			get { return withEventsField_btnOffsetsG30Set; }
			set {
				if (withEventsField_btnOffsetsG30Set != null) {
					withEventsField_btnOffsetsG30Set.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG30Set = value;
				if (withEventsField_btnOffsetsG30Set != null) {
					withEventsField_btnOffsetsG30Set.Click += btnOffsetsZero_Click;
				}
			}
		}
		internal System.Windows.Forms.TextBox tbOffsetsG30Z;
		internal System.Windows.Forms.TextBox tbOffsetsG30Y;
		internal System.Windows.Forms.TextBox tbOffsetsG30X;
		internal System.Windows.Forms.TextBox tbOffsetsG28Z;
		internal System.Windows.Forms.TextBox tbOffsetsG28Y;
		internal System.Windows.Forms.TextBox tbOffsetsG28X;
		internal System.Windows.Forms.Label Label21;
		internal System.Windows.Forms.Label Label43;
		internal System.Windows.Forms.Label Label60;
		private System.Windows.Forms.Button withEventsField_btnOffsetsG55Zero;
		internal System.Windows.Forms.Button btnOffsetsG55Zero {
			get { return withEventsField_btnOffsetsG55Zero; }
			set {
				if (withEventsField_btnOffsetsG55Zero != null) {
					withEventsField_btnOffsetsG55Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG55Zero = value;
				if (withEventsField_btnOffsetsG55Zero != null) {
					withEventsField_btnOffsetsG55Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG55Z;
		internal System.Windows.Forms.TextBox tbOffsetsG55Z {
			get { return withEventsField_tbOffsetsG55Z; }
			set {
				if (withEventsField_tbOffsetsG55Z != null) {
					withEventsField_tbOffsetsG55Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG55Z = value;
				if (withEventsField_tbOffsetsG55Z != null) {
					withEventsField_tbOffsetsG55Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG55Y;
		internal System.Windows.Forms.TextBox tbOffsetsG55Y {
			get { return withEventsField_tbOffsetsG55Y; }
			set {
				if (withEventsField_tbOffsetsG55Y != null) {
					withEventsField_tbOffsetsG55Y.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG55Y = value;
				if (withEventsField_tbOffsetsG55Y != null) {
					withEventsField_tbOffsetsG55Y.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG55X;
		internal System.Windows.Forms.TextBox tbOffsetsG55X {
			get { return withEventsField_tbOffsetsG55X; }
			set {
				if (withEventsField_tbOffsetsG55X != null) {
					withEventsField_tbOffsetsG55X.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG55X = value;
				if (withEventsField_tbOffsetsG55X != null) {
					withEventsField_tbOffsetsG55X.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG56Zero;
		internal System.Windows.Forms.Button btnOffsetsG56Zero {
			get { return withEventsField_btnOffsetsG56Zero; }
			set {
				if (withEventsField_btnOffsetsG56Zero != null) {
					withEventsField_btnOffsetsG56Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG56Zero = value;
				if (withEventsField_btnOffsetsG56Zero != null) {
					withEventsField_btnOffsetsG56Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG56Z;
		internal System.Windows.Forms.TextBox tbOffsetsG56Z {
			get { return withEventsField_tbOffsetsG56Z; }
			set {
				if (withEventsField_tbOffsetsG56Z != null) {
					withEventsField_tbOffsetsG56Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG56Z = value;
				if (withEventsField_tbOffsetsG56Z != null) {
					withEventsField_tbOffsetsG56Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG56Y;
		internal System.Windows.Forms.TextBox tbOffsetsG56Y {
			get { return withEventsField_tbOffsetsG56Y; }
			set {
				if (withEventsField_tbOffsetsG56Y != null) {
					withEventsField_tbOffsetsG56Y.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG56Y = value;
				if (withEventsField_tbOffsetsG56Y != null) {
					withEventsField_tbOffsetsG56Y.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG56X;
		internal System.Windows.Forms.TextBox tbOffsetsG56X {
			get { return withEventsField_tbOffsetsG56X; }
			set {
				if (withEventsField_tbOffsetsG56X != null) {
					withEventsField_tbOffsetsG56X.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG56X = value;
				if (withEventsField_tbOffsetsG56X != null) {
					withEventsField_tbOffsetsG56X.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG57Zero;
		internal System.Windows.Forms.Button btnOffsetsG57Zero {
			get { return withEventsField_btnOffsetsG57Zero; }
			set {
				if (withEventsField_btnOffsetsG57Zero != null) {
					withEventsField_btnOffsetsG57Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG57Zero = value;
				if (withEventsField_btnOffsetsG57Zero != null) {
					withEventsField_btnOffsetsG57Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG57Z;
		internal System.Windows.Forms.TextBox tbOffsetsG57Z {
			get { return withEventsField_tbOffsetsG57Z; }
			set {
				if (withEventsField_tbOffsetsG57Z != null) {
					withEventsField_tbOffsetsG57Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG57Z = value;
				if (withEventsField_tbOffsetsG57Z != null) {
					withEventsField_tbOffsetsG57Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG57Y;
		internal System.Windows.Forms.TextBox tbOffsetsG57Y {
			get { return withEventsField_tbOffsetsG57Y; }
			set {
				if (withEventsField_tbOffsetsG57Y != null) {
					withEventsField_tbOffsetsG57Y.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG57Y = value;
				if (withEventsField_tbOffsetsG57Y != null) {
					withEventsField_tbOffsetsG57Y.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG57X;
		internal System.Windows.Forms.TextBox tbOffsetsG57X {
			get { return withEventsField_tbOffsetsG57X; }
			set {
				if (withEventsField_tbOffsetsG57X != null) {
					withEventsField_tbOffsetsG57X.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG57X = value;
				if (withEventsField_tbOffsetsG57X != null) {
					withEventsField_tbOffsetsG57X.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG58Zero;
		internal System.Windows.Forms.Button btnOffsetsG58Zero {
			get { return withEventsField_btnOffsetsG58Zero; }
			set {
				if (withEventsField_btnOffsetsG58Zero != null) {
					withEventsField_btnOffsetsG58Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG58Zero = value;
				if (withEventsField_btnOffsetsG58Zero != null) {
					withEventsField_btnOffsetsG58Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG58Z;
		internal System.Windows.Forms.TextBox tbOffsetsG58Z {
			get { return withEventsField_tbOffsetsG58Z; }
			set {
				if (withEventsField_tbOffsetsG58Z != null) {
					withEventsField_tbOffsetsG58Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG58Z = value;
				if (withEventsField_tbOffsetsG58Z != null) {
					withEventsField_tbOffsetsG58Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG58Y;
		internal System.Windows.Forms.TextBox tbOffsetsG58Y {
			get { return withEventsField_tbOffsetsG58Y; }
			set {
				if (withEventsField_tbOffsetsG58Y != null) {
					withEventsField_tbOffsetsG58Y.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG58Y = value;
				if (withEventsField_tbOffsetsG58Y != null) {
					withEventsField_tbOffsetsG58Y.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG58X;
		internal System.Windows.Forms.TextBox tbOffsetsG58X {
			get { return withEventsField_tbOffsetsG58X; }
			set {
				if (withEventsField_tbOffsetsG58X != null) {
					withEventsField_tbOffsetsG58X.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG58X = value;
				if (withEventsField_tbOffsetsG58X != null) {
					withEventsField_tbOffsetsG58X.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG59Zero;
		internal System.Windows.Forms.Button btnOffsetsG59Zero {
			get { return withEventsField_btnOffsetsG59Zero; }
			set {
				if (withEventsField_btnOffsetsG59Zero != null) {
					withEventsField_btnOffsetsG59Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG59Zero = value;
				if (withEventsField_btnOffsetsG59Zero != null) {
					withEventsField_btnOffsetsG59Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG59Z;
		internal System.Windows.Forms.TextBox tbOffsetsG59Z {
			get { return withEventsField_tbOffsetsG59Z; }
			set {
				if (withEventsField_tbOffsetsG59Z != null) {
					withEventsField_tbOffsetsG59Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG59Z = value;
				if (withEventsField_tbOffsetsG59Z != null) {
					withEventsField_tbOffsetsG59Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG59Y;
		internal System.Windows.Forms.TextBox tbOffsetsG59Y {
			get { return withEventsField_tbOffsetsG59Y; }
			set {
				if (withEventsField_tbOffsetsG59Y != null) {
					withEventsField_tbOffsetsG59Y.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG59Y = value;
				if (withEventsField_tbOffsetsG59Y != null) {
					withEventsField_tbOffsetsG59Y.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG59X;
		internal System.Windows.Forms.TextBox tbOffsetsG59X {
			get { return withEventsField_tbOffsetsG59X; }
			set {
				if (withEventsField_tbOffsetsG59X != null) {
					withEventsField_tbOffsetsG59X.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG59X = value;
				if (withEventsField_tbOffsetsG59X != null) {
					withEventsField_tbOffsetsG59X.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG54Zero;
		internal System.Windows.Forms.Button btnOffsetsG54Zero {
			get { return withEventsField_btnOffsetsG54Zero; }
			set {
				if (withEventsField_btnOffsetsG54Zero != null) {
					withEventsField_btnOffsetsG54Zero.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG54Zero = value;
				if (withEventsField_btnOffsetsG54Zero != null) {
					withEventsField_btnOffsetsG54Zero.Click += btnOffsetsZero_Click;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG54Z;
		internal System.Windows.Forms.TextBox tbOffsetsG54Z {
			get { return withEventsField_tbOffsetsG54Z; }
			set {
				if (withEventsField_tbOffsetsG54Z != null) {
					withEventsField_tbOffsetsG54Z.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG54Z = value;
				if (withEventsField_tbOffsetsG54Z != null) {
					withEventsField_tbOffsetsG54Z.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG54Y;
		internal System.Windows.Forms.TextBox tbOffsetsG54Y {
			get { return withEventsField_tbOffsetsG54Y; }
			set {
				if (withEventsField_tbOffsetsG54Y != null) {
					withEventsField_tbOffsetsG54Y.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG54Y = value;
				if (withEventsField_tbOffsetsG54Y != null) {
					withEventsField_tbOffsetsG54Y.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		private System.Windows.Forms.TextBox withEventsField_tbOffsetsG54X;
		internal System.Windows.Forms.TextBox tbOffsetsG54X {
			get { return withEventsField_tbOffsetsG54X; }
			set {
				if (withEventsField_tbOffsetsG54X != null) {
					withEventsField_tbOffsetsG54X.DoubleClick -= tbOffsets_DoubleClick;
				}
				withEventsField_tbOffsetsG54X = value;
				if (withEventsField_tbOffsetsG54X != null) {
					withEventsField_tbOffsetsG54X.DoubleClick += tbOffsets_DoubleClick;
				}
			}
		}
		internal System.Windows.Forms.Label Label69;
		internal System.Windows.Forms.Label Label68;
		internal System.Windows.Forms.TextBox tbOffSetsMachZ;
		internal System.Windows.Forms.TextBox tbOffSetsMachY;
		internal System.Windows.Forms.TextBox tbOffSetsMachX;
		internal System.Windows.Forms.SaveFileDialog sfdOffsets;
		internal System.Windows.Forms.OpenFileDialog ofdOffsets;
		internal System.Windows.Forms.TabControl tabCtlPosition;
		internal System.Windows.Forms.TabPage tpWork;
		internal System.Windows.Forms.TabPage tpOffsets;
		internal System.Windows.Forms.GroupBox gbMDI;
		internal System.Windows.Forms.GroupBox gbControl;
		internal System.Windows.Forms.TextBox tbCurrentStatus;
		private RepeatButton.RepeatButton withEventsField_btnZMinus;
		internal RepeatButton.RepeatButton btnZMinus {
			get { return withEventsField_btnZMinus; }
			set {
				if (withEventsField_btnZMinus != null) {
					withEventsField_btnZMinus.Click -= btnJogArray_Click;
				}
				withEventsField_btnZMinus = value;
				if (withEventsField_btnZMinus != null) {
					withEventsField_btnZMinus.Click += btnJogArray_Click;
				}
			}
		}
		private RepeatButton.RepeatButton withEventsField_btnZPlus;
		internal RepeatButton.RepeatButton btnZPlus {
			get { return withEventsField_btnZPlus; }
			set {
				if (withEventsField_btnZPlus != null) {
					withEventsField_btnZPlus.Click -= btnJogArray_Click;
				}
				withEventsField_btnZPlus = value;
				if (withEventsField_btnZPlus != null) {
					withEventsField_btnZPlus.Click += btnJogArray_Click;
				}
			}
		}
		private RepeatButton.RepeatButton withEventsField_btnXPlus;
		internal RepeatButton.RepeatButton btnXPlus {
			get { return withEventsField_btnXPlus; }
			set {
				if (withEventsField_btnXPlus != null) {
					withEventsField_btnXPlus.Click -= btnJogArray_Click;
				}
				withEventsField_btnXPlus = value;
				if (withEventsField_btnXPlus != null) {
					withEventsField_btnXPlus.Click += btnJogArray_Click;
				}
			}
		}
		private RepeatButton.RepeatButton withEventsField_btnYMinus;
		internal RepeatButton.RepeatButton btnYMinus {
			get { return withEventsField_btnYMinus; }
			set {
				if (withEventsField_btnYMinus != null) {
					withEventsField_btnYMinus.Click -= btnJogArray_Click;
				}
				withEventsField_btnYMinus = value;
				if (withEventsField_btnYMinus != null) {
					withEventsField_btnYMinus.Click += btnJogArray_Click;
				}
			}
		}
		private RepeatButton.RepeatButton withEventsField_btnXMinus;
		internal RepeatButton.RepeatButton btnXMinus {
			get { return withEventsField_btnXMinus; }
			set {
				if (withEventsField_btnXMinus != null) {
					withEventsField_btnXMinus.Click -= btnJogArray_Click;
				}
				withEventsField_btnXMinus = value;
				if (withEventsField_btnXMinus != null) {
					withEventsField_btnXMinus.Click += btnJogArray_Click;
				}
			}
		}
		private RepeatButton.RepeatButton withEventsField_btnYPlus;
		internal RepeatButton.RepeatButton btnYPlus {
			get { return withEventsField_btnYPlus; }
			set {
				if (withEventsField_btnYPlus != null) {
					withEventsField_btnYPlus.Click -= btnJogArray_Click;
				}
				withEventsField_btnYPlus = value;
				if (withEventsField_btnYPlus != null) {
					withEventsField_btnYPlus.Click += btnJogArray_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label71;
		internal System.Windows.Forms.CheckBox cbSettingsConnectOnLoad;
		private System.Windows.Forms.Button withEventsField_btnStatusGetParser;
		internal System.Windows.Forms.Button btnStatusGetParser {
			get { return withEventsField_btnStatusGetParser; }
			set {
				if (withEventsField_btnStatusGetParser != null) {
					withEventsField_btnStatusGetParser.Click -= btnStatusGetParser_Click;
				}
				withEventsField_btnStatusGetParser = value;
				if (withEventsField_btnStatusGetParser != null) {
					withEventsField_btnStatusGetParser.Click += btnStatusGetParser_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox gbSettingsOffsets;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox tbWorkX;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.TextBox tbSettingsSpclPosition2;
		internal System.Windows.Forms.CheckBox cbSettingsKeyboardJogging;
		private System.Windows.Forms.Button withEventsField_btnCheckMode;
		public System.Windows.Forms.Button btnCheckMode {
			get { return withEventsField_btnCheckMode; }
			set {
				if (withEventsField_btnCheckMode != null) {
					withEventsField_btnCheckMode.Click -= btnCheckMode_Click;
				}
				withEventsField_btnCheckMode = value;
				if (withEventsField_btnCheckMode != null) {
					withEventsField_btnCheckMode.Click += btnCheckMode_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnSettingsRetrieveLocations;
		internal System.Windows.Forms.Button btnSettingsRetrieveLocations {
			get { return withEventsField_btnSettingsRetrieveLocations; }
			set {
				if (withEventsField_btnSettingsRetrieveLocations != null) {
					withEventsField_btnSettingsRetrieveLocations.Click -= btnOffsetsRetrieve_Click;
				}
				withEventsField_btnSettingsRetrieveLocations = value;
				if (withEventsField_btnSettingsRetrieveLocations != null) {
					withEventsField_btnSettingsRetrieveLocations.Click += btnOffsetsRetrieve_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label10;
		private System.Windows.Forms.CheckBox withEventsField_cbSettingsLeftHanded;
		internal System.Windows.Forms.CheckBox cbSettingsLeftHanded {
			get { return withEventsField_cbSettingsLeftHanded; }
			set {
				if (withEventsField_cbSettingsLeftHanded != null) {
					withEventsField_cbSettingsLeftHanded.CheckedChanged -= cbSettingsLeftHanded_CheckedChanged;
				}
				withEventsField_cbSettingsLeftHanded = value;
				if (withEventsField_cbSettingsLeftHanded != null) {
					withEventsField_cbSettingsLeftHanded.CheckedChanged += cbSettingsLeftHanded_CheckedChanged;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnWorkSoftHome;
		private System.Windows.Forms.Button btnWorkSoftHome {
			get { return withEventsField_btnWorkSoftHome; }
			set {
				if (withEventsField_btnWorkSoftHome != null) {
					withEventsField_btnWorkSoftHome.Click -= btnPosition_Click;
				}
				withEventsField_btnWorkSoftHome = value;
				if (withEventsField_btnWorkSoftHome != null) {
					withEventsField_btnWorkSoftHome.Click += btnPosition_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnWorkSpclPosition;
		internal System.Windows.Forms.Button btnWorkSpclPosition {
			get { return withEventsField_btnWorkSpclPosition; }
			set {
				if (withEventsField_btnWorkSpclPosition != null) {
					withEventsField_btnWorkSpclPosition.Click -= btnPosition_Click;
				}
				withEventsField_btnWorkSpclPosition = value;
				if (withEventsField_btnWorkSpclPosition != null) {
					withEventsField_btnWorkSpclPosition.Click += btnPosition_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox gbState;
		internal System.Windows.Forms.Label Label123;
		internal System.Windows.Forms.Label Lalbel49;
		internal System.Windows.Forms.Label Label47;
		internal System.Windows.Forms.Label Label45;
		internal System.Windows.Forms.Label Label17;
		internal System.Windows.Forms.Label Label15;
		internal System.Windows.Forms.Label Label53;
		internal System.Windows.Forms.Label Label50;
		internal System.Windows.Forms.Label Label14;
		internal System.Windows.Forms.Label Label16;
		private System.Windows.Forms.ComboBox withEventsField_cbxStateUnits;
		internal System.Windows.Forms.ComboBox cbxStateUnits {
			get { return withEventsField_cbxStateUnits; }
			set {
				if (withEventsField_cbxStateUnits != null) {
					withEventsField_cbxStateUnits.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStateUnits = value;
				if (withEventsField_cbxStateUnits != null) {
					withEventsField_cbxStateUnits.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cbxStateDistance;
		internal System.Windows.Forms.ComboBox cbxStateDistance {
			get { return withEventsField_cbxStateDistance; }
			set {
				if (withEventsField_cbxStateDistance != null) {
					withEventsField_cbxStateDistance.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStateDistance = value;
				if (withEventsField_cbxStateDistance != null) {
					withEventsField_cbxStateDistance.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		internal System.Windows.Forms.TextBox tbStateFeedRate;
		private System.Windows.Forms.ComboBox withEventsField_cbxStateFeedMode;
		internal System.Windows.Forms.ComboBox cbxStateFeedMode {
			get { return withEventsField_cbxStateFeedMode; }
			set {
				if (withEventsField_cbxStateFeedMode != null) {
					withEventsField_cbxStateFeedMode.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStateFeedMode = value;
				if (withEventsField_cbxStateFeedMode != null) {
					withEventsField_cbxStateFeedMode.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		internal System.Windows.Forms.TextBox tbStateTool;
		internal System.Windows.Forms.TextBox tbStateSpindleRPM;
		private System.Windows.Forms.ComboBox withEventsField_cbxStatePlane;
		internal System.Windows.Forms.ComboBox cbxStatePlane {
			get { return withEventsField_cbxStatePlane; }
			set {
				if (withEventsField_cbxStatePlane != null) {
					withEventsField_cbxStatePlane.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStatePlane = value;
				if (withEventsField_cbxStatePlane != null) {
					withEventsField_cbxStatePlane.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cbxStateCoolant;
		internal System.Windows.Forms.ComboBox cbxStateCoolant {
			get { return withEventsField_cbxStateCoolant; }
			set {
				if (withEventsField_cbxStateCoolant != null) {
					withEventsField_cbxStateCoolant.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStateCoolant = value;
				if (withEventsField_cbxStateCoolant != null) {
					withEventsField_cbxStateCoolant.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cbxStateSpindle;
		internal System.Windows.Forms.ComboBox cbxStateSpindle {
			get { return withEventsField_cbxStateSpindle; }
			set {
				if (withEventsField_cbxStateSpindle != null) {
					withEventsField_cbxStateSpindle.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStateSpindle = value;
				if (withEventsField_cbxStateSpindle != null) {
					withEventsField_cbxStateSpindle.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		private System.Windows.Forms.ComboBox withEventsField_cbxStateOffset;
		internal System.Windows.Forms.ComboBox cbxStateOffset {
			get { return withEventsField_cbxStateOffset; }
			set {
				if (withEventsField_cbxStateOffset != null) {
					withEventsField_cbxStateOffset.SelectionChangeCommitted -= cbxState_SelectionChangeCommittted;
				}
				withEventsField_cbxStateOffset = value;
				if (withEventsField_cbxStateOffset != null) {
					withEventsField_cbxStateOffset.SelectionChangeCommitted += cbxState_SelectionChangeCommittted;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnOffsetsG28Set;
		internal System.Windows.Forms.Button btnOffsetsG28Set {
			get { return withEventsField_btnOffsetsG28Set; }
			set {
				if (withEventsField_btnOffsetsG28Set != null) {
					withEventsField_btnOffsetsG28Set.Click -= btnOffsetsZero_Click;
				}
				withEventsField_btnOffsetsG28Set = value;
				if (withEventsField_btnOffsetsG28Set != null) {
					withEventsField_btnOffsetsG28Set.Click += btnOffsetsZero_Click;
				}
			}
		}
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.Label lblPositionCurrentOffset;
		internal System.Windows.Forms.GroupBox gbGrblSettings;
		internal System.Windows.Forms.BindingSource GrblSettingsBindingSource;
		internal System.Windows.Forms.GroupBox gbStatus;
		internal System.Windows.Forms.Panel Panel2;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Panel Panel3;
		internal System.Windows.Forms.Panel Panel5;
		internal System.Windows.Forms.Panel Panel4;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox tbSettingsGrblLastParam;
		private System.Windows.Forms.Button withEventsField_btnFileReload;
		internal System.Windows.Forms.Button btnFileReload {
			get { return withEventsField_btnFileReload; }
			set {
				if (withEventsField_btnFileReload != null) {
					withEventsField_btnFileReload.Click -= btnFileGroup_Click;
				}
				withEventsField_btnFileReload = value;
				if (withEventsField_btnFileReload != null) {
					withEventsField_btnFileReload.Click += btnFileGroup_Click;
				}
			}
		}
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox tbSettingsStartupDelay;
		internal System.Windows.Forms.TextBox tbSettingsDefaultExt;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TabControl tcConnection;
		internal System.Windows.Forms.TabPage tbGrblCOM;
		internal System.Windows.Forms.TabPage tbGrblIP;
		private System.Windows.Forms.Button withEventsField_btnIPConnect;
		internal System.Windows.Forms.Button btnIPConnect {
			get { return withEventsField_btnIPConnect; }
			set {
				if (withEventsField_btnIPConnect != null) {
					withEventsField_btnIPConnect.Click -= btnConnDisconnect_Click;
				}
				withEventsField_btnIPConnect = value;
				if (withEventsField_btnIPConnect != null) {
					withEventsField_btnIPConnect.Click += btnConnDisconnect_Click;
				}
			}
		}
		internal System.Windows.Forms.TextBox tbIPAddress;
		internal TabPage TabPage1;
		public GroupBox gbEditor;
		private Button withEventsField_btnAdd;
		private Button btnAdd {
			get { return withEventsField_btnAdd; }
			set {
				if (withEventsField_btnAdd != null) {
					withEventsField_btnAdd.Click -= btnAdd_Click;
				}
				withEventsField_btnAdd = value;
				if (withEventsField_btnAdd != null) {
					withEventsField_btnAdd.Click += btnAdd_Click;
				}
			}
		}
		private Label lblGCode;
		private TextBox withEventsField_tbGCode;
		public TextBox tbGCode {
			get { return withEventsField_tbGCode; }
			set {
				if (withEventsField_tbGCode != null) {
					withEventsField_tbGCode.MouseHover -= UpdateToolTip;
				}
				withEventsField_tbGCode = value;
				if (withEventsField_tbGCode != null) {
					withEventsField_tbGCode.MouseHover += UpdateToolTip;
				}
			}
		}
		private Label lblName;
		private TextBox withEventsField_tbName;
		public TextBox tbName {
			get { return withEventsField_tbName; }
			set {
				if (withEventsField_tbName != null) {
					withEventsField_tbName.MouseHover -= UpdateToolTip;
				}
				withEventsField_tbName = value;
				if (withEventsField_tbName != null) {
					withEventsField_tbName.MouseHover += UpdateToolTip;
				}
			}
		}
		private Button withEventsField_btnCancel;
		private Button btnCancel {
			get { return withEventsField_btnCancel; }
			set {
				if (withEventsField_btnCancel != null) {
					withEventsField_btnCancel.Click -= btnCancel_Click;
					withEventsField_btnCancel.MouseHover -= UpdateToolTip;
				}
				withEventsField_btnCancel = value;
				if (withEventsField_btnCancel != null) {
					withEventsField_btnCancel.Click += btnCancel_Click;
					withEventsField_btnCancel.MouseHover += UpdateToolTip;
				}
			}
		}
		private Button withEventsField_btnOK;
		private Button btnOK {
			get { return withEventsField_btnOK; }
			set {
				if (withEventsField_btnOK != null) {
					withEventsField_btnOK.Click -= btnOK_Click;
					withEventsField_btnOK.MouseHover -= UpdateToolTip;
				}
				withEventsField_btnOK = value;
				if (withEventsField_btnOK != null) {
					withEventsField_btnOK.Click += btnOK_Click;
					withEventsField_btnOK.MouseHover += UpdateToolTip;
				}
			}
		}
		private DataGridView withEventsField_dgMacros;
		private DataGridView dgMacros {
			get { return withEventsField_dgMacros; }
			set {
				if (withEventsField_dgMacros != null) {
					withEventsField_dgMacros.CellValueChanged -= dgMacros_CellValueChanged;
					withEventsField_dgMacros.DoubleClick -= dgMacros_DoubleClick;
					withEventsField_dgMacros.MouseHover -= UpdateToolTip;
				}
				withEventsField_dgMacros = value;
				if (withEventsField_dgMacros != null) {
					withEventsField_dgMacros.CellValueChanged += dgMacros_CellValueChanged;
					withEventsField_dgMacros.DoubleClick += dgMacros_DoubleClick;
					withEventsField_dgMacros.MouseHover += UpdateToolTip;
				}
			}
		}
		internal DataGridViewTextBoxColumn Column1;
		internal DataGridViewTextBoxColumn Column2;
		private Label lblStatusLabel;
		private Button withEventsField_btnDeleteMacro;
		private Button btnDeleteMacro {
			get { return withEventsField_btnDeleteMacro; }
			set {
				if (withEventsField_btnDeleteMacro != null) {
					withEventsField_btnDeleteMacro.Click -= btnDeleteMacro_Click;
					withEventsField_btnDeleteMacro.MouseHover -= UpdateToolTip;
				}
				withEventsField_btnDeleteMacro = value;
				if (withEventsField_btnDeleteMacro != null) {
					withEventsField_btnDeleteMacro.Click += btnDeleteMacro_Click;
					withEventsField_btnDeleteMacro.MouseHover += UpdateToolTip;
				}
			}
		}
		internal GroupBox GroupBox2;
		internal Label Label46;
		internal Label Label44;
		private Button withEventsField_btnFeedFineMinus;
		internal Button btnFeedFineMinus {
			get { return withEventsField_btnFeedFineMinus; }
			set {
				if (withEventsField_btnFeedFineMinus != null) {
					withEventsField_btnFeedFineMinus.Click -= btnFeedOverride_Click;
				}
				withEventsField_btnFeedFineMinus = value;
				if (withEventsField_btnFeedFineMinus != null) {
					withEventsField_btnFeedFineMinus.Click += btnFeedOverride_Click;
				}
			}
		}
		private Button withEventsField_btnFeedFinePlus;
		internal Button btnFeedFinePlus {
			get { return withEventsField_btnFeedFinePlus; }
			set {
				if (withEventsField_btnFeedFinePlus != null) {
					withEventsField_btnFeedFinePlus.Click -= btnFeedOverride_Click;
				}
				withEventsField_btnFeedFinePlus = value;
				if (withEventsField_btnFeedFinePlus != null) {
					withEventsField_btnFeedFinePlus.Click += btnFeedOverride_Click;
				}
			}
		}
		internal Label Label22;
		private Button withEventsField_btnFeedCoarseMinus;
		internal Button btnFeedCoarseMinus {
			get { return withEventsField_btnFeedCoarseMinus; }
			set {
				if (withEventsField_btnFeedCoarseMinus != null) {
					withEventsField_btnFeedCoarseMinus.Click -= btnFeedOverride_Click;
				}
				withEventsField_btnFeedCoarseMinus = value;
				if (withEventsField_btnFeedCoarseMinus != null) {
					withEventsField_btnFeedCoarseMinus.Click += btnFeedOverride_Click;
				}
			}
		}
		private Button withEventsField_btnFeedCoarsePlus;
		internal Button btnFeedCoarsePlus {
			get { return withEventsField_btnFeedCoarsePlus; }
			set {
				if (withEventsField_btnFeedCoarsePlus != null) {
					withEventsField_btnFeedCoarsePlus.Click -= btnFeedOverride_Click;
				}
				withEventsField_btnFeedCoarsePlus = value;
				if (withEventsField_btnFeedCoarsePlus != null) {
					withEventsField_btnFeedCoarsePlus.Click += btnFeedOverride_Click;
				}
			}
		}
		private Button withEventsField_Button1;
		internal Button Button1 {
			get { return withEventsField_Button1; }
			set {
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click -= Button1_Click;
				}
				withEventsField_Button1 = value;
				if (withEventsField_Button1 != null) {
					withEventsField_Button1.Click += Button1_Click;
				}
			}
		}
		private Button withEventsField_btnSetOffsetG59;
		internal Button btnSetOffsetG59 {
			get { return withEventsField_btnSetOffsetG59; }
			set {
				if (withEventsField_btnSetOffsetG59 != null) {
					withEventsField_btnSetOffsetG59.Click -= btnSetOffset_Click;
				}
				withEventsField_btnSetOffsetG59 = value;
				if (withEventsField_btnSetOffsetG59 != null) {
					withEventsField_btnSetOffsetG59.Click += btnSetOffset_Click;
				}
			}
		}
		private Button withEventsField_btnSetOffsetG58;
		internal Button btnSetOffsetG58 {
			get { return withEventsField_btnSetOffsetG58; }
			set {
				if (withEventsField_btnSetOffsetG58 != null) {
					withEventsField_btnSetOffsetG58.Click -= btnSetOffset_Click;
				}
				withEventsField_btnSetOffsetG58 = value;
				if (withEventsField_btnSetOffsetG58 != null) {
					withEventsField_btnSetOffsetG58.Click += btnSetOffset_Click;
				}
			}
		}
		private Button withEventsField_btnSetOffsetG57;
		internal Button btnSetOffsetG57 {
			get { return withEventsField_btnSetOffsetG57; }
			set {
				if (withEventsField_btnSetOffsetG57 != null) {
					withEventsField_btnSetOffsetG57.Click -= btnSetOffset_Click;
				}
				withEventsField_btnSetOffsetG57 = value;
				if (withEventsField_btnSetOffsetG57 != null) {
					withEventsField_btnSetOffsetG57.Click += btnSetOffset_Click;
				}
			}
		}
		private Button withEventsField_btnSetOffsetG56;
		internal Button btnSetOffsetG56 {
			get { return withEventsField_btnSetOffsetG56; }
			set {
				if (withEventsField_btnSetOffsetG56 != null) {
					withEventsField_btnSetOffsetG56.Click -= btnSetOffset_Click;
				}
				withEventsField_btnSetOffsetG56 = value;
				if (withEventsField_btnSetOffsetG56 != null) {
					withEventsField_btnSetOffsetG56.Click += btnSetOffset_Click;
				}
			}
		}
		private Button withEventsField_btnSetOffsetG55;
		internal Button btnSetOffsetG55 {
			get { return withEventsField_btnSetOffsetG55; }
			set {
				if (withEventsField_btnSetOffsetG55 != null) {
					withEventsField_btnSetOffsetG55.Click -= btnSetOffset_Click;
				}
				withEventsField_btnSetOffsetG55 = value;
				if (withEventsField_btnSetOffsetG55 != null) {
					withEventsField_btnSetOffsetG55.Click += btnSetOffset_Click;
				}
			}
		}
		private Button withEventsField_btnSetOffsetG54;
		internal Button btnSetOffsetG54 {
			get { return withEventsField_btnSetOffsetG54; }
			set {
				if (withEventsField_btnSetOffsetG54 != null) {
					withEventsField_btnSetOffsetG54.Click -= btnSetOffset_Click;
				}
				withEventsField_btnSetOffsetG54 = value;
				if (withEventsField_btnSetOffsetG54 != null) {
					withEventsField_btnSetOffsetG54.Click += btnSetOffset_Click;
				}
			}
		}
		private DataGridView withEventsField_dgvGcode;
		internal DataGridView dgvGcode {
			get { return withEventsField_dgvGcode; }
			set {
				if (withEventsField_dgvGcode != null) {
					withEventsField_dgvGcode.CellValueNeeded -= dgvGcode_CellValueNeeded;
				}
				withEventsField_dgvGcode = value;
				if (withEventsField_dgvGcode != null) {
					withEventsField_dgvGcode.CellValueNeeded += dgvGcode_CellValueNeeded;
				}
			}
		}
		internal DataGridViewTextBoxColumn stat;
		internal DataGridViewTextBoxColumn lineNum;
		internal DataGridViewTextBoxColumn data;
	}
}
