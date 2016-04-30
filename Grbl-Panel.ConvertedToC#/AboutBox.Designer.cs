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
	partial class AboutBox : System.Windows.Forms.Form
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
		private System.Windows.Forms.GroupBox GroupBox1;
		private System.Windows.Forms.RichTextBox withEventsField_MoreRichTextBox;
		internal System.Windows.Forms.RichTextBox MoreRichTextBox {
			get { return withEventsField_MoreRichTextBox; }
			set {
				if (withEventsField_MoreRichTextBox != null) {
					withEventsField_MoreRichTextBox.LinkClicked -= MoreRichTextBox_LinkClicked;
				}
				withEventsField_MoreRichTextBox = value;
				if (withEventsField_MoreRichTextBox != null) {
					withEventsField_MoreRichTextBox.LinkClicked += MoreRichTextBox_LinkClicked;
				}
			}
		}
		internal System.Windows.Forms.ListView AppInfoListView;
		internal System.Windows.Forms.ColumnHeader colKey;
		internal System.Windows.Forms.ColumnHeader colValue;
		private System.Windows.Forms.ListView withEventsField_AssemblyInfoListView;
		internal System.Windows.Forms.ListView AssemblyInfoListView {
			get { return withEventsField_AssemblyInfoListView; }
			set {
				if (withEventsField_AssemblyInfoListView != null) {
					withEventsField_AssemblyInfoListView.DoubleClick -= AssemblyInfoListView_DoubleClick;
					withEventsField_AssemblyInfoListView.ColumnClick -= AssemblyInfoListView_ColumnClick;
				}
				withEventsField_AssemblyInfoListView = value;
				if (withEventsField_AssemblyInfoListView != null) {
					withEventsField_AssemblyInfoListView.DoubleClick += AssemblyInfoListView_DoubleClick;
					withEventsField_AssemblyInfoListView.ColumnClick += AssemblyInfoListView_ColumnClick;
				}
			}
		}
		internal System.Windows.Forms.ColumnHeader colAssemblyName;
		internal System.Windows.Forms.ColumnHeader colAssemblyVersion;
		internal System.Windows.Forms.ColumnHeader colAssemblyBuilt;
		internal System.Windows.Forms.ColumnHeader colAssemblyCodeBase;
		private System.Windows.Forms.TabControl withEventsField_TabPanelDetails;
		internal System.Windows.Forms.TabControl TabPanelDetails {
			get { return withEventsField_TabPanelDetails; }
			set {
				if (withEventsField_TabPanelDetails != null) {
					withEventsField_TabPanelDetails.SelectedIndexChanged -= TabPanelDetails_SelectedIndexChanged;
				}
				withEventsField_TabPanelDetails = value;
				if (withEventsField_TabPanelDetails != null) {
					withEventsField_TabPanelDetails.SelectedIndexChanged += TabPanelDetails_SelectedIndexChanged;
				}
			}
		}
		internal System.Windows.Forms.TabPage TabPageApplication;
		internal System.Windows.Forms.TabPage TabPageAssemblies;
		internal System.Windows.Forms.TabPage TabPageAssemblyDetails;
		internal System.Windows.Forms.ListView AssemblyDetailsListView;
		internal System.Windows.Forms.ColumnHeader ColumnHeader1;
		internal System.Windows.Forms.ColumnHeader ColumnHeader2;
		private System.Windows.Forms.ComboBox withEventsField_AssemblyNamesComboBox;
		internal System.Windows.Forms.ComboBox AssemblyNamesComboBox {
			get { return withEventsField_AssemblyNamesComboBox; }
			set {
				if (withEventsField_AssemblyNamesComboBox != null) {
					withEventsField_AssemblyNamesComboBox.SelectedIndexChanged -= AssemblyNamesComboBox_SelectedIndexChanged;
				}
				withEventsField_AssemblyNamesComboBox = value;
				if (withEventsField_AssemblyNamesComboBox != null) {
					withEventsField_AssemblyNamesComboBox.SelectedIndexChanged += AssemblyNamesComboBox_SelectedIndexChanged;
				}
			}
		}
		private System.Windows.Forms.Button OKButton;
		private System.Windows.Forms.Label AppTitleLabel;
		private System.Windows.Forms.Label AppDescriptionLabel;
		private System.Windows.Forms.Label AppVersionLabel;
		private System.Windows.Forms.Label AppCopyrightLabel;
		private System.Windows.Forms.Button withEventsField_SysInfoButton;
		private System.Windows.Forms.Button SysInfoButton {
			get { return withEventsField_SysInfoButton; }
			set {
				if (withEventsField_SysInfoButton != null) {
					withEventsField_SysInfoButton.Click -= SysInfoButton_Click;
				}
				withEventsField_SysInfoButton = value;
				if (withEventsField_SysInfoButton != null) {
					withEventsField_SysInfoButton.Click += SysInfoButton_Click;
				}
			}
		}
		private System.Windows.Forms.Label AppDateLabel;
		private System.Windows.Forms.PictureBox ImagePictureBox;
		private System.Windows.Forms.Button withEventsField_DetailsButton;
		private System.Windows.Forms.Button DetailsButton {
			get { return withEventsField_DetailsButton; }
			set {
				if (withEventsField_DetailsButton != null) {
					withEventsField_DetailsButton.Click -= DetailsButton_Click;
				}
				withEventsField_DetailsButton = value;
				if (withEventsField_DetailsButton != null) {
					withEventsField_DetailsButton.Click += DetailsButton_Click;
				}
			}

		}
		[System.Diagnostics.DebuggerStepThrough()]
		private void InitializeComponent()
		{
			this.OKButton = new System.Windows.Forms.Button();
			this.AppTitleLabel = new System.Windows.Forms.Label();
			this.GroupBox1 = new System.Windows.Forms.GroupBox();
			this.AppDescriptionLabel = new System.Windows.Forms.Label();
			this.AppVersionLabel = new System.Windows.Forms.Label();
			this.AppCopyrightLabel = new System.Windows.Forms.Label();
			this.SysInfoButton = new System.Windows.Forms.Button();
			this.AppDateLabel = new System.Windows.Forms.Label();
			this.ImagePictureBox = new System.Windows.Forms.PictureBox();
			this.DetailsButton = new System.Windows.Forms.Button();
			this.MoreRichTextBox = new System.Windows.Forms.RichTextBox();
			this.TabPanelDetails = new System.Windows.Forms.TabControl();
			this.TabPageApplication = new System.Windows.Forms.TabPage();
			this.AppInfoListView = new System.Windows.Forms.ListView();
			this.colKey = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.colValue = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.TabPageAssemblies = new System.Windows.Forms.TabPage();
			this.AssemblyInfoListView = new System.Windows.Forms.ListView();
			this.colAssemblyName = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.colAssemblyVersion = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.colAssemblyBuilt = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.colAssemblyCodeBase = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.TabPageAssemblyDetails = new System.Windows.Forms.TabPage();
			this.AssemblyDetailsListView = new System.Windows.Forms.ListView();
			this.ColumnHeader1 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.ColumnHeader2 = (System.Windows.Forms.ColumnHeader)new System.Windows.Forms.ColumnHeader();
			this.AssemblyNamesComboBox = new System.Windows.Forms.ComboBox();
			this.btnAboutChanges = new System.Windows.Forms.Button();
			this.btnAboutCredits = new System.Windows.Forms.Button();
			this.btnAboutLicense = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)this.ImagePictureBox).BeginInit();
			this.TabPanelDetails.SuspendLayout();
			this.TabPageApplication.SuspendLayout();
			this.TabPageAssemblies.SuspendLayout();
			this.TabPageAssemblyDetails.SuspendLayout();
			this.SuspendLayout();
			//
			//OKButton
			//
			this.OKButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.OKButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.OKButton.Location = new System.Drawing.Point(482, 474);
			this.OKButton.Name = "OKButton";
			this.OKButton.Size = new System.Drawing.Size(59, 23);
			this.OKButton.TabIndex = 1;
			this.OKButton.Text = "OK";
			//
			//AppTitleLabel
			//
			this.AppTitleLabel.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.AppTitleLabel.Location = new System.Drawing.Point(60, 8);
			this.AppTitleLabel.Name = "AppTitleLabel";
			this.AppTitleLabel.Size = new System.Drawing.Size(496, 16);
			this.AppTitleLabel.TabIndex = 2;
			this.AppTitleLabel.Text = "%title%";
			//
			//GroupBox1
			//
			this.GroupBox1.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.GroupBox1.Location = new System.Drawing.Point(8, 48);
			this.GroupBox1.Name = "GroupBox1";
			this.GroupBox1.Size = new System.Drawing.Size(548, 2);
			this.GroupBox1.TabIndex = 3;
			this.GroupBox1.TabStop = false;
			this.GroupBox1.Text = "GroupBox1";
			//
			//AppDescriptionLabel
			//
			this.AppDescriptionLabel.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.AppDescriptionLabel.Location = new System.Drawing.Point(60, 28);
			this.AppDescriptionLabel.Name = "AppDescriptionLabel";
			this.AppDescriptionLabel.Size = new System.Drawing.Size(496, 16);
			this.AppDescriptionLabel.TabIndex = 4;
			this.AppDescriptionLabel.Text = "%description%";
			//
			//AppVersionLabel
			//
			this.AppVersionLabel.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.AppVersionLabel.Location = new System.Drawing.Point(8, 60);
			this.AppVersionLabel.Name = "AppVersionLabel";
			this.AppVersionLabel.Size = new System.Drawing.Size(548, 16);
			this.AppVersionLabel.TabIndex = 5;
			this.AppVersionLabel.Text = "Version %version%";
			//
			//AppCopyrightLabel
			//
			this.AppCopyrightLabel.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.AppCopyrightLabel.Location = new System.Drawing.Point(8, 100);
			this.AppCopyrightLabel.Name = "AppCopyrightLabel";
			this.AppCopyrightLabel.Size = new System.Drawing.Size(548, 16);
			this.AppCopyrightLabel.TabIndex = 6;
			this.AppCopyrightLabel.Text = "Copyright © %year%, %trademark%";
			//
			//SysInfoButton
			//
			this.SysInfoButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.SysInfoButton.Location = new System.Drawing.Point(395, 474);
			this.SysInfoButton.Name = "SysInfoButton";
			this.SysInfoButton.Size = new System.Drawing.Size(81, 23);
			this.SysInfoButton.TabIndex = 7;
			this.SysInfoButton.Text = "&System Info";
			this.SysInfoButton.Visible = false;
			//
			//AppDateLabel
			//
			this.AppDateLabel.Anchor = (System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.AppDateLabel.Location = new System.Drawing.Point(8, 80);
			this.AppDateLabel.Name = "AppDateLabel";
			this.AppDateLabel.Size = new System.Drawing.Size(548, 16);
			this.AppDateLabel.TabIndex = 8;
			this.AppDateLabel.Text = "Built on %builddate%";
			//
			//ImagePictureBox
			//
			this.ImagePictureBox.Location = new System.Drawing.Point(16, 8);
			this.ImagePictureBox.Name = "ImagePictureBox";
			this.ImagePictureBox.Size = new System.Drawing.Size(32, 32);
			this.ImagePictureBox.TabIndex = 9;
			this.ImagePictureBox.TabStop = false;
			//
			//DetailsButton
			//
			this.DetailsButton.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.DetailsButton.Location = new System.Drawing.Point(406, 474);
			this.DetailsButton.Name = "DetailsButton";
			this.DetailsButton.Size = new System.Drawing.Size(59, 23);
			this.DetailsButton.TabIndex = 10;
			this.DetailsButton.Text = "&Details >>";
			//
			//MoreRichTextBox
			//
			this.MoreRichTextBox.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.MoreRichTextBox.BackColor = System.Drawing.SystemColors.ControlLight;
			this.MoreRichTextBox.Location = new System.Drawing.Point(8, 119);
			this.MoreRichTextBox.Name = "MoreRichTextBox";
			this.MoreRichTextBox.ReadOnly = true;
			this.MoreRichTextBox.Size = new System.Drawing.Size(548, 347);
			this.MoreRichTextBox.TabIndex = 13;
			this.MoreRichTextBox.Text = "";
			this.MoreRichTextBox.WordWrap = false;
			//
			//TabPanelDetails
			//
			this.TabPanelDetails.Anchor = (System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right);
			this.TabPanelDetails.Controls.Add(this.TabPageApplication);
			this.TabPanelDetails.Controls.Add(this.TabPageAssemblies);
			this.TabPanelDetails.Controls.Add(this.TabPageAssemblyDetails);
			this.TabPanelDetails.Location = new System.Drawing.Point(8, 119);
			this.TabPanelDetails.Name = "TabPanelDetails";
			this.TabPanelDetails.SelectedIndex = 0;
			this.TabPanelDetails.Size = new System.Drawing.Size(546, 347);
			this.TabPanelDetails.TabIndex = 15;
			this.TabPanelDetails.Visible = false;
			//
			//TabPageApplication
			//
			this.TabPageApplication.Controls.Add(this.AppInfoListView);
			this.TabPageApplication.Location = new System.Drawing.Point(4, 22);
			this.TabPageApplication.Name = "TabPageApplication";
			this.TabPageApplication.Size = new System.Drawing.Size(538, 321);
			this.TabPageApplication.TabIndex = 0;
			this.TabPageApplication.Text = "Application";
			//
			//AppInfoListView
			//
			this.AppInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.colKey,
				this.colValue
			});
			this.AppInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AppInfoListView.FullRowSelect = true;
			this.AppInfoListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.AppInfoListView.Location = new System.Drawing.Point(0, 0);
			this.AppInfoListView.Name = "AppInfoListView";
			this.AppInfoListView.Size = new System.Drawing.Size(538, 321);
			this.AppInfoListView.TabIndex = 16;
			this.AppInfoListView.UseCompatibleStateImageBehavior = false;
			this.AppInfoListView.View = System.Windows.Forms.View.Details;
			//
			//colKey
			//
			this.colKey.Text = "Application Key";
			this.colKey.Width = 120;
			//
			//colValue
			//
			this.colValue.Text = "Value";
			this.colValue.Width = 700;
			//
			//TabPageAssemblies
			//
			this.TabPageAssemblies.Controls.Add(this.AssemblyInfoListView);
			this.TabPageAssemblies.Location = new System.Drawing.Point(4, 22);
			this.TabPageAssemblies.Name = "TabPageAssemblies";
			this.TabPageAssemblies.Size = new System.Drawing.Size(368, 121);
			this.TabPageAssemblies.TabIndex = 1;
			this.TabPageAssemblies.Text = "Assemblies";
			//
			//AssemblyInfoListView
			//
			this.AssemblyInfoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.colAssemblyName,
				this.colAssemblyVersion,
				this.colAssemblyBuilt,
				this.colAssemblyCodeBase
			});
			this.AssemblyInfoListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AssemblyInfoListView.FullRowSelect = true;
			this.AssemblyInfoListView.Location = new System.Drawing.Point(0, 0);
			this.AssemblyInfoListView.MultiSelect = false;
			this.AssemblyInfoListView.Name = "AssemblyInfoListView";
			this.AssemblyInfoListView.Size = new System.Drawing.Size(368, 121);
			this.AssemblyInfoListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.AssemblyInfoListView.TabIndex = 13;
			this.AssemblyInfoListView.UseCompatibleStateImageBehavior = false;
			this.AssemblyInfoListView.View = System.Windows.Forms.View.Details;
			//
			//colAssemblyName
			//
			this.colAssemblyName.Text = "Assembly";
			this.colAssemblyName.Width = 123;
			//
			//colAssemblyVersion
			//
			this.colAssemblyVersion.Text = "Version";
			this.colAssemblyVersion.Width = 100;
			//
			//colAssemblyBuilt
			//
			this.colAssemblyBuilt.Text = "Built";
			this.colAssemblyBuilt.Width = 130;
			//
			//colAssemblyCodeBase
			//
			this.colAssemblyCodeBase.Text = "CodeBase";
			this.colAssemblyCodeBase.Width = 750;
			//
			//TabPageAssemblyDetails
			//
			this.TabPageAssemblyDetails.Controls.Add(this.AssemblyDetailsListView);
			this.TabPageAssemblyDetails.Controls.Add(this.AssemblyNamesComboBox);
			this.TabPageAssemblyDetails.Location = new System.Drawing.Point(4, 22);
			this.TabPageAssemblyDetails.Name = "TabPageAssemblyDetails";
			this.TabPageAssemblyDetails.Size = new System.Drawing.Size(368, 121);
			this.TabPageAssemblyDetails.TabIndex = 2;
			this.TabPageAssemblyDetails.Text = "Assembly Details";
			//
			//AssemblyDetailsListView
			//
			this.AssemblyDetailsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
				this.ColumnHeader1,
				this.ColumnHeader2
			});
			this.AssemblyDetailsListView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.AssemblyDetailsListView.FullRowSelect = true;
			this.AssemblyDetailsListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.AssemblyDetailsListView.Location = new System.Drawing.Point(0, 21);
			this.AssemblyDetailsListView.Name = "AssemblyDetailsListView";
			this.AssemblyDetailsListView.Size = new System.Drawing.Size(368, 100);
			this.AssemblyDetailsListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.AssemblyDetailsListView.TabIndex = 19;
			this.AssemblyDetailsListView.UseCompatibleStateImageBehavior = false;
			this.AssemblyDetailsListView.View = System.Windows.Forms.View.Details;
			//
			//ColumnHeader1
			//
			this.ColumnHeader1.Text = "Assembly Key";
			this.ColumnHeader1.Width = 120;
			//
			//ColumnHeader2
			//
			this.ColumnHeader2.Text = "Value";
			this.ColumnHeader2.Width = 700;
			//
			//AssemblyNamesComboBox
			//
			this.AssemblyNamesComboBox.Dock = System.Windows.Forms.DockStyle.Top;
			this.AssemblyNamesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.AssemblyNamesComboBox.Location = new System.Drawing.Point(0, 0);
			this.AssemblyNamesComboBox.Name = "AssemblyNamesComboBox";
			this.AssemblyNamesComboBox.Size = new System.Drawing.Size(368, 21);
			this.AssemblyNamesComboBox.Sorted = true;
			this.AssemblyNamesComboBox.TabIndex = 18;
			//
			//btnAboutChanges
			//
			this.btnAboutChanges.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnAboutChanges.Location = new System.Drawing.Point(178, 474);
			this.btnAboutChanges.Name = "btnAboutChanges";
			this.btnAboutChanges.Size = new System.Drawing.Size(59, 23);
			this.btnAboutChanges.TabIndex = 16;
			this.btnAboutChanges.Text = "Changes";
			this.btnAboutChanges.UseVisualStyleBackColor = true;
			//
			//btnAboutCredits
			//
			this.btnAboutCredits.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnAboutCredits.Location = new System.Drawing.Point(254, 474);
			this.btnAboutCredits.Name = "btnAboutCredits";
			this.btnAboutCredits.Size = new System.Drawing.Size(59, 23);
			this.btnAboutCredits.TabIndex = 17;
			this.btnAboutCredits.Text = "Credits";
			this.btnAboutCredits.UseVisualStyleBackColor = true;
			//
			//btnAboutLicense
			//
			this.btnAboutLicense.Anchor = (System.Windows.Forms.AnchorStyles)(System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right);
			this.btnAboutLicense.Location = new System.Drawing.Point(330, 474);
			this.btnAboutLicense.Name = "btnAboutLicense";
			this.btnAboutLicense.Size = new System.Drawing.Size(59, 23);
			this.btnAboutLicense.TabIndex = 18;
			this.btnAboutLicense.Text = "License";
			this.btnAboutLicense.UseVisualStyleBackColor = true;
			//
			//AboutBox
			//
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.OKButton;
			this.ClientSize = new System.Drawing.Size(564, 505);
			this.Controls.Add(this.btnAboutLicense);
			this.Controls.Add(this.btnAboutCredits);
			this.Controls.Add(this.btnAboutChanges);
			this.Controls.Add(this.DetailsButton);
			this.Controls.Add(this.ImagePictureBox);
			this.Controls.Add(this.AppDateLabel);
			this.Controls.Add(this.SysInfoButton);
			this.Controls.Add(this.AppCopyrightLabel);
			this.Controls.Add(this.AppVersionLabel);
			this.Controls.Add(this.AppDescriptionLabel);
			this.Controls.Add(this.GroupBox1);
			this.Controls.Add(this.AppTitleLabel);
			this.Controls.Add(this.OKButton);
			this.Controls.Add(this.MoreRichTextBox);
			this.Controls.Add(this.TabPanelDetails);
			this.Font = new System.Drawing.Font("Tahoma", 8f);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "AboutBox";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "About %title%";
			((System.ComponentModel.ISupportInitialize)this.ImagePictureBox).EndInit();
			this.TabPanelDetails.ResumeLayout(false);
			this.TabPageApplication.ResumeLayout(false);
			this.TabPageAssemblies.ResumeLayout(false);
			this.TabPageAssemblyDetails.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button withEventsField_btnAboutChanges;
		internal System.Windows.Forms.Button btnAboutChanges {
			get { return withEventsField_btnAboutChanges; }
			set {
				if (withEventsField_btnAboutChanges != null) {
					withEventsField_btnAboutChanges.Click -= btnAboutChanges_Click;
				}
				withEventsField_btnAboutChanges = value;
				if (withEventsField_btnAboutChanges != null) {
					withEventsField_btnAboutChanges.Click += btnAboutChanges_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnAboutCredits;
		internal System.Windows.Forms.Button btnAboutCredits {
			get { return withEventsField_btnAboutCredits; }
			set {
				if (withEventsField_btnAboutCredits != null) {
					withEventsField_btnAboutCredits.Click -= btnAboutCredits_Click;
				}
				withEventsField_btnAboutCredits = value;
				if (withEventsField_btnAboutCredits != null) {
					withEventsField_btnAboutCredits.Click += btnAboutCredits_Click;
				}
			}
		}
		private System.Windows.Forms.Button withEventsField_btnAboutLicense;
		internal System.Windows.Forms.Button btnAboutLicense {
			get { return withEventsField_btnAboutLicense; }
			set {
				if (withEventsField_btnAboutLicense != null) {
					withEventsField_btnAboutLicense.Click -= btnAboutLicense_Click;
				}
				withEventsField_btnAboutLicense = value;
				if (withEventsField_btnAboutLicense != null) {
					withEventsField_btnAboutLicense.Click += btnAboutLicense_Click;
				}
			}

		}
		public AboutBox()
		{
			Paint += AboutBox_Paint;
			Load += AboutBox_Load;
			InitializeComponent();
		}



	}
}
