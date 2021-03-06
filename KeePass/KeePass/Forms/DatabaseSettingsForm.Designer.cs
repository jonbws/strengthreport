﻿namespace KeePass.Forms
{
	partial class DatabaseSettingsForm
	{
		/// <summary>
		/// Erforderliche Designervariable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Verwendete Ressourcen bereinigen.
		/// </summary>
		/// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
		protected override void Dispose(bool disposing)
		{
			if(disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Vom Windows Form-Designer generierter Code

		/// <summary>
		/// Erforderliche Methode für die Designerunterstützung.
		/// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.m_bannerImage = new System.Windows.Forms.PictureBox();
			this.m_btnOK = new System.Windows.Forms.Button();
			this.m_btnCancel = new System.Windows.Forms.Button();
			this.m_grpEncAlgo = new System.Windows.Forms.GroupBox();
			this.m_lblEncAlgoDesc = new System.Windows.Forms.Label();
			this.m_cmbEncAlgo = new System.Windows.Forms.ComboBox();
			this.m_lblTransIntro = new System.Windows.Forms.Label();
			this.m_lblTransNum = new System.Windows.Forms.Label();
			this.m_lblTransInfo = new System.Windows.Forms.Label();
			this.m_grpKeyTrans = new System.Windows.Forms.GroupBox();
			this.m_lnkCompute1SecDelay = new System.Windows.Forms.LinkLabel();
			this.m_numEncRounds = new System.Windows.Forms.NumericUpDown();
			this.m_btnHelp = new System.Windows.Forms.Button();
			this.m_ttRect = new System.Windows.Forms.ToolTip(this.components);
			this.m_lblCompressionIntro = new System.Windows.Forms.Label();
			this.m_tabMain = new System.Windows.Forms.TabControl();
			this.m_tabGeneral = new System.Windows.Forms.TabPage();
			this.m_tbDefaultUser = new System.Windows.Forms.TextBox();
			this.m_lblDefaultUser = new System.Windows.Forms.Label();
			this.m_tbDbDesc = new KeePass.UI.PromptedTextBox();
			this.m_lblDbDesc = new System.Windows.Forms.Label();
			this.m_tbDbName = new KeePass.UI.PromptedTextBox();
			this.m_lblDbName = new System.Windows.Forms.Label();
			this.m_tabSecurity = new System.Windows.Forms.TabPage();
			this.m_lblSecIntro = new System.Windows.Forms.Label();
			this.m_tabProtection = new System.Windows.Forms.TabPage();
			this.m_lblViewHint = new System.Windows.Forms.Label();
			this.m_lblMemProtEnable = new System.Windows.Forms.Label();
			this.m_lblMemProtHint = new System.Windows.Forms.Label();
			this.m_lblMemProtDesc = new System.Windows.Forms.Label();
			this.m_lbMemProt = new System.Windows.Forms.CheckedListBox();
			this.m_lblProtIntro = new System.Windows.Forms.Label();
			this.m_tabCompression = new System.Windows.Forms.TabPage();
			this.m_lblHeaderCpAlgo = new System.Windows.Forms.Label();
			this.m_lblCpGZipPerf = new System.Windows.Forms.Label();
			this.m_lblCpGZipCp = new System.Windows.Forms.Label();
			this.m_lblCpNonePerf = new System.Windows.Forms.Label();
			this.m_lblCpNoneCp = new System.Windows.Forms.Label();
			this.m_lblHeaderPerf = new System.Windows.Forms.Label();
			this.m_lblHeaderCp = new System.Windows.Forms.Label();
			this.m_rbGZip = new System.Windows.Forms.RadioButton();
			this.m_rbNone = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).BeginInit();
			this.m_grpEncAlgo.SuspendLayout();
			this.m_grpKeyTrans.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numEncRounds)).BeginInit();
			this.m_tabMain.SuspendLayout();
			this.m_tabGeneral.SuspendLayout();
			this.m_tabSecurity.SuspendLayout();
			this.m_tabProtection.SuspendLayout();
			this.m_tabCompression.SuspendLayout();
			this.SuspendLayout();
			// 
			// m_bannerImage
			// 
			this.m_bannerImage.Dock = System.Windows.Forms.DockStyle.Top;
			this.m_bannerImage.Location = new System.Drawing.Point(0, 0);
			this.m_bannerImage.Name = "m_bannerImage";
			this.m_bannerImage.Size = new System.Drawing.Size(486, 60);
			this.m_bannerImage.TabIndex = 0;
			this.m_bannerImage.TabStop = false;
			// 
			// m_btnOK
			// 
			this.m_btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.m_btnOK.Location = new System.Drawing.Point(318, 399);
			this.m_btnOK.Name = "m_btnOK";
			this.m_btnOK.Size = new System.Drawing.Size(75, 23);
			this.m_btnOK.TabIndex = 1;
			this.m_btnOK.Text = "&OK";
			this.m_btnOK.UseVisualStyleBackColor = true;
			this.m_btnOK.Click += new System.EventHandler(this.OnBtnOK);
			// 
			// m_btnCancel
			// 
			this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.m_btnCancel.Location = new System.Drawing.Point(399, 399);
			this.m_btnCancel.Name = "m_btnCancel";
			this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
			this.m_btnCancel.TabIndex = 2;
			this.m_btnCancel.Text = "&Cancel";
			this.m_btnCancel.UseVisualStyleBackColor = true;
			this.m_btnCancel.Click += new System.EventHandler(this.OnBtnCancel);
			// 
			// m_grpEncAlgo
			// 
			this.m_grpEncAlgo.Controls.Add(this.m_lblEncAlgoDesc);
			this.m_grpEncAlgo.Controls.Add(this.m_cmbEncAlgo);
			this.m_grpEncAlgo.Location = new System.Drawing.Point(9, 37);
			this.m_grpEncAlgo.Name = "m_grpEncAlgo";
			this.m_grpEncAlgo.Size = new System.Drawing.Size(436, 53);
			this.m_grpEncAlgo.TabIndex = 1;
			this.m_grpEncAlgo.TabStop = false;
			this.m_grpEncAlgo.Text = "Encryption";
			// 
			// m_lblEncAlgoDesc
			// 
			this.m_lblEncAlgoDesc.AutoSize = true;
			this.m_lblEncAlgoDesc.Location = new System.Drawing.Point(6, 22);
			this.m_lblEncAlgoDesc.Name = "m_lblEncAlgoDesc";
			this.m_lblEncAlgoDesc.Size = new System.Drawing.Size(169, 13);
			this.m_lblEncAlgoDesc.TabIndex = 0;
			this.m_lblEncAlgoDesc.Text = "Database file encryption algorithm:";
			// 
			// m_cmbEncAlgo
			// 
			this.m_cmbEncAlgo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.m_cmbEncAlgo.FormattingEnabled = true;
			this.m_cmbEncAlgo.Location = new System.Drawing.Point(206, 19);
			this.m_cmbEncAlgo.Name = "m_cmbEncAlgo";
			this.m_cmbEncAlgo.Size = new System.Drawing.Size(219, 21);
			this.m_cmbEncAlgo.TabIndex = 1;
			// 
			// m_lblTransIntro
			// 
			this.m_lblTransIntro.Location = new System.Drawing.Point(6, 16);
			this.m_lblTransIntro.Name = "m_lblTransIntro";
			this.m_lblTransIntro.Size = new System.Drawing.Size(424, 40);
			this.m_lblTransIntro.TabIndex = 0;
			this.m_lblTransIntro.Text = "The composite master key is transformed several times before being used as encryp" +
				"tion key for the database. This adds a constant time factor and makes dictionary" +
				" and guessing attacks harder.";
			// 
			// m_lblTransNum
			// 
			this.m_lblTransNum.AutoSize = true;
			this.m_lblTransNum.Location = new System.Drawing.Point(6, 63);
			this.m_lblTransNum.Name = "m_lblTransNum";
			this.m_lblTransNum.Size = new System.Drawing.Size(183, 13);
			this.m_lblTransNum.TabIndex = 1;
			this.m_lblTransNum.Text = "Number of key transformation rounds:";
			// 
			// m_lblTransInfo
			// 
			this.m_lblTransInfo.Location = new System.Drawing.Point(6, 103);
			this.m_lblTransInfo.Name = "m_lblTransInfo";
			this.m_lblTransInfo.Size = new System.Drawing.Size(424, 28);
			this.m_lblTransInfo.TabIndex = 4;
			this.m_lblTransInfo.Text = "The higher this number the harder are dictionary attacks. But also database loadi" +
				"ng/saving takes more time.";
			// 
			// m_grpKeyTrans
			// 
			this.m_grpKeyTrans.Controls.Add(this.m_lnkCompute1SecDelay);
			this.m_grpKeyTrans.Controls.Add(this.m_numEncRounds);
			this.m_grpKeyTrans.Controls.Add(this.m_lblTransIntro);
			this.m_grpKeyTrans.Controls.Add(this.m_lblTransInfo);
			this.m_grpKeyTrans.Controls.Add(this.m_lblTransNum);
			this.m_grpKeyTrans.Location = new System.Drawing.Point(9, 96);
			this.m_grpKeyTrans.Name = "m_grpKeyTrans";
			this.m_grpKeyTrans.Size = new System.Drawing.Size(436, 140);
			this.m_grpKeyTrans.TabIndex = 2;
			this.m_grpKeyTrans.TabStop = false;
			this.m_grpKeyTrans.Text = "Key transformation";
			// 
			// m_lnkCompute1SecDelay
			// 
			this.m_lnkCompute1SecDelay.AutoSize = true;
			this.m_lnkCompute1SecDelay.Location = new System.Drawing.Point(203, 84);
			this.m_lnkCompute1SecDelay.Name = "m_lnkCompute1SecDelay";
			this.m_lnkCompute1SecDelay.Size = new System.Drawing.Size(79, 13);
			this.m_lnkCompute1SecDelay.TabIndex = 3;
			this.m_lnkCompute1SecDelay.TabStop = true;
			this.m_lnkCompute1SecDelay.Text = "1 second delay";
			this.m_lnkCompute1SecDelay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkClicked1SecondDelayRounds);
			// 
			// m_numEncRounds
			// 
			this.m_numEncRounds.Location = new System.Drawing.Point(206, 61);
			this.m_numEncRounds.Name = "m_numEncRounds";
			this.m_numEncRounds.Size = new System.Drawing.Size(219, 20);
			this.m_numEncRounds.TabIndex = 2;
			this.m_numEncRounds.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// m_btnHelp
			// 
			this.m_btnHelp.Location = new System.Drawing.Point(12, 399);
			this.m_btnHelp.Name = "m_btnHelp";
			this.m_btnHelp.Size = new System.Drawing.Size(75, 23);
			this.m_btnHelp.TabIndex = 3;
			this.m_btnHelp.Text = "&Help";
			this.m_btnHelp.UseVisualStyleBackColor = true;
			this.m_btnHelp.Click += new System.EventHandler(this.OnBtnHelp);
			// 
			// m_ttRect
			// 
			this.m_ttRect.AutomaticDelay = 250;
			this.m_ttRect.AutoPopDelay = 2500;
			this.m_ttRect.InitialDelay = 250;
			this.m_ttRect.ReshowDelay = 50;
			// 
			// m_lblCompressionIntro
			// 
			this.m_lblCompressionIntro.Location = new System.Drawing.Point(8, 10);
			this.m_lblCompressionIntro.Name = "m_lblCompressionIntro";
			this.m_lblCompressionIntro.Size = new System.Drawing.Size(430, 15);
			this.m_lblCompressionIntro.TabIndex = 0;
			this.m_lblCompressionIntro.Text = "Data compression reduces the size of the database.";
			// 
			// m_tabMain
			// 
			this.m_tabMain.Controls.Add(this.m_tabGeneral);
			this.m_tabMain.Controls.Add(this.m_tabSecurity);
			this.m_tabMain.Controls.Add(this.m_tabProtection);
			this.m_tabMain.Controls.Add(this.m_tabCompression);
			this.m_tabMain.Location = new System.Drawing.Point(12, 66);
			this.m_tabMain.Name = "m_tabMain";
			this.m_tabMain.SelectedIndex = 0;
			this.m_tabMain.Size = new System.Drawing.Size(462, 320);
			this.m_tabMain.TabIndex = 0;
			// 
			// m_tabGeneral
			// 
			this.m_tabGeneral.Controls.Add(this.m_tbDefaultUser);
			this.m_tabGeneral.Controls.Add(this.m_lblDefaultUser);
			this.m_tabGeneral.Controls.Add(this.m_tbDbDesc);
			this.m_tabGeneral.Controls.Add(this.m_lblDbDesc);
			this.m_tabGeneral.Controls.Add(this.m_tbDbName);
			this.m_tabGeneral.Controls.Add(this.m_lblDbName);
			this.m_tabGeneral.Location = new System.Drawing.Point(4, 22);
			this.m_tabGeneral.Name = "m_tabGeneral";
			this.m_tabGeneral.Padding = new System.Windows.Forms.Padding(3);
			this.m_tabGeneral.Size = new System.Drawing.Size(454, 294);
			this.m_tabGeneral.TabIndex = 0;
			this.m_tabGeneral.Text = "General";
			this.m_tabGeneral.UseVisualStyleBackColor = true;
			// 
			// m_tbDefaultUser
			// 
			this.m_tbDefaultUser.Location = new System.Drawing.Point(180, 253);
			this.m_tbDefaultUser.Name = "m_tbDefaultUser";
			this.m_tbDefaultUser.Size = new System.Drawing.Size(257, 20);
			this.m_tbDefaultUser.TabIndex = 5;
			// 
			// m_lblDefaultUser
			// 
			this.m_lblDefaultUser.AutoSize = true;
			this.m_lblDefaultUser.Location = new System.Drawing.Point(6, 256);
			this.m_lblDefaultUser.Name = "m_lblDefaultUser";
			this.m_lblDefaultUser.Size = new System.Drawing.Size(168, 13);
			this.m_lblDefaultUser.TabIndex = 4;
			this.m_lblDefaultUser.Text = "Default user name for new entries:";
			// 
			// m_tbDbDesc
			// 
			this.m_tbDbDesc.AcceptsReturn = true;
			this.m_tbDbDesc.Location = new System.Drawing.Point(9, 57);
			this.m_tbDbDesc.Multiline = true;
			this.m_tbDbDesc.Name = "m_tbDbDesc";
			this.m_tbDbDesc.PromptText = "";
			this.m_tbDbDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.m_tbDbDesc.Size = new System.Drawing.Size(428, 177);
			this.m_tbDbDesc.TabIndex = 3;
			// 
			// m_lblDbDesc
			// 
			this.m_lblDbDesc.AutoSize = true;
			this.m_lblDbDesc.Location = new System.Drawing.Point(6, 41);
			this.m_lblDbDesc.Name = "m_lblDbDesc";
			this.m_lblDbDesc.Size = new System.Drawing.Size(110, 13);
			this.m_lblDbDesc.TabIndex = 2;
			this.m_lblDbDesc.Text = "Database description:";
			// 
			// m_tbDbName
			// 
			this.m_tbDbName.Location = new System.Drawing.Point(97, 9);
			this.m_tbDbName.Name = "m_tbDbName";
			this.m_tbDbName.PromptText = "";
			this.m_tbDbName.Size = new System.Drawing.Size(340, 20);
			this.m_tbDbName.TabIndex = 0;
			// 
			// m_lblDbName
			// 
			this.m_lblDbName.AutoSize = true;
			this.m_lblDbName.Location = new System.Drawing.Point(6, 12);
			this.m_lblDbName.Name = "m_lblDbName";
			this.m_lblDbName.Size = new System.Drawing.Size(85, 13);
			this.m_lblDbName.TabIndex = 1;
			this.m_lblDbName.Text = "Database name:";
			// 
			// m_tabSecurity
			// 
			this.m_tabSecurity.Controls.Add(this.m_lblSecIntro);
			this.m_tabSecurity.Controls.Add(this.m_grpEncAlgo);
			this.m_tabSecurity.Controls.Add(this.m_grpKeyTrans);
			this.m_tabSecurity.Location = new System.Drawing.Point(4, 22);
			this.m_tabSecurity.Name = "m_tabSecurity";
			this.m_tabSecurity.Padding = new System.Windows.Forms.Padding(3);
			this.m_tabSecurity.Size = new System.Drawing.Size(454, 294);
			this.m_tabSecurity.TabIndex = 1;
			this.m_tabSecurity.Text = "Security";
			this.m_tabSecurity.UseVisualStyleBackColor = true;
			// 
			// m_lblSecIntro
			// 
			this.m_lblSecIntro.AutoSize = true;
			this.m_lblSecIntro.Location = new System.Drawing.Point(6, 12);
			this.m_lblSecIntro.Name = "m_lblSecIntro";
			this.m_lblSecIntro.Size = new System.Drawing.Size(277, 13);
			this.m_lblSecIntro.TabIndex = 0;
			this.m_lblSecIntro.Text = "On this page you can configure file-level security settings.";
			// 
			// m_tabProtection
			// 
			this.m_tabProtection.Controls.Add(this.m_lblViewHint);
			this.m_tabProtection.Controls.Add(this.m_lblMemProtEnable);
			this.m_tabProtection.Controls.Add(this.m_lblMemProtHint);
			this.m_tabProtection.Controls.Add(this.m_lblMemProtDesc);
			this.m_tabProtection.Controls.Add(this.m_lbMemProt);
			this.m_tabProtection.Controls.Add(this.m_lblProtIntro);
			this.m_tabProtection.Location = new System.Drawing.Point(4, 22);
			this.m_tabProtection.Name = "m_tabProtection";
			this.m_tabProtection.Size = new System.Drawing.Size(454, 294);
			this.m_tabProtection.TabIndex = 3;
			this.m_tabProtection.Text = "Protection";
			this.m_tabProtection.UseVisualStyleBackColor = true;
			// 
			// m_lblViewHint
			// 
			this.m_lblViewHint.Location = new System.Drawing.Point(6, 257);
			this.m_lblViewHint.Name = "m_lblViewHint";
			this.m_lblViewHint.Size = new System.Drawing.Size(434, 28);
			this.m_lblViewHint.TabIndex = 5;
			this.m_lblViewHint.Text = "Memory protection is useless if you display the fields in the main window. Theref" +
				"ore make sure that hiding by asterisks is enabled for the protected fields.";
			// 
			// m_lblMemProtEnable
			// 
			this.m_lblMemProtEnable.AutoSize = true;
			this.m_lblMemProtEnable.Location = new System.Drawing.Point(6, 119);
			this.m_lblMemProtEnable.Name = "m_lblMemProtEnable";
			this.m_lblMemProtEnable.Size = new System.Drawing.Size(247, 13);
			this.m_lblMemProtEnable.TabIndex = 3;
			this.m_lblMemProtEnable.Text = "Enable in-memory protection for the following fields:";
			// 
			// m_lblMemProtHint
			// 
			this.m_lblMemProtHint.Location = new System.Drawing.Point(6, 71);
			this.m_lblMemProtHint.Name = "m_lblMemProtHint";
			this.m_lblMemProtHint.Size = new System.Drawing.Size(434, 27);
			this.m_lblMemProtHint.TabIndex = 2;
			this.m_lblMemProtHint.Text = "It is recommended to turn on memory protection for password fields and leave it d" +
				"isabled for all others. Process memory protection slows down all operations a bi" +
				"t.";
			// 
			// m_lblMemProtDesc
			// 
			this.m_lblMemProtDesc.Location = new System.Drawing.Point(6, 34);
			this.m_lblMemProtDesc.Name = "m_lblMemProtDesc";
			this.m_lblMemProtDesc.Size = new System.Drawing.Size(434, 28);
			this.m_lblMemProtDesc.TabIndex = 1;
			this.m_lblMemProtDesc.Text = "Fields can be stored encrypted in the process memory. This ensures that no other " +
				"application can read your data by dumping the memory.";
			// 
			// m_lbMemProt
			// 
			this.m_lbMemProt.CheckOnClick = true;
			this.m_lbMemProt.FormattingEnabled = true;
			this.m_lbMemProt.Location = new System.Drawing.Point(9, 135);
			this.m_lbMemProt.Name = "m_lbMemProt";
			this.m_lbMemProt.ScrollAlwaysVisible = true;
			this.m_lbMemProt.Size = new System.Drawing.Size(431, 109);
			this.m_lbMemProt.TabIndex = 4;
			// 
			// m_lblProtIntro
			// 
			this.m_lblProtIntro.Location = new System.Drawing.Point(6, 12);
			this.m_lblProtIntro.Name = "m_lblProtIntro";
			this.m_lblProtIntro.Size = new System.Drawing.Size(434, 13);
			this.m_lblProtIntro.TabIndex = 0;
			this.m_lblProtIntro.Text = "On this page you can configure run-time memory protection settings for this datab" +
				"ase.";
			// 
			// m_tabCompression
			// 
			this.m_tabCompression.Controls.Add(this.m_lblHeaderCpAlgo);
			this.m_tabCompression.Controls.Add(this.m_lblCpGZipPerf);
			this.m_tabCompression.Controls.Add(this.m_lblCpGZipCp);
			this.m_tabCompression.Controls.Add(this.m_lblCpNonePerf);
			this.m_tabCompression.Controls.Add(this.m_lblCpNoneCp);
			this.m_tabCompression.Controls.Add(this.m_lblHeaderPerf);
			this.m_tabCompression.Controls.Add(this.m_lblHeaderCp);
			this.m_tabCompression.Controls.Add(this.m_rbGZip);
			this.m_tabCompression.Controls.Add(this.m_rbNone);
			this.m_tabCompression.Controls.Add(this.m_lblCompressionIntro);
			this.m_tabCompression.Location = new System.Drawing.Point(4, 22);
			this.m_tabCompression.Name = "m_tabCompression";
			this.m_tabCompression.Size = new System.Drawing.Size(454, 294);
			this.m_tabCompression.TabIndex = 2;
			this.m_tabCompression.Text = "Compression";
			this.m_tabCompression.UseVisualStyleBackColor = true;
			// 
			// m_lblHeaderCpAlgo
			// 
			this.m_lblHeaderCpAlgo.AutoSize = true;
			this.m_lblHeaderCpAlgo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
			this.m_lblHeaderCpAlgo.Location = new System.Drawing.Point(28, 56);
			this.m_lblHeaderCpAlgo.Name = "m_lblHeaderCpAlgo";
			this.m_lblHeaderCpAlgo.Size = new System.Drawing.Size(50, 13);
			this.m_lblHeaderCpAlgo.TabIndex = 1;
			this.m_lblHeaderCpAlgo.Text = "Algorithm";
			// 
			// m_lblCpGZipPerf
			// 
			this.m_lblCpGZipPerf.AutoSize = true;
			this.m_lblCpGZipPerf.Location = new System.Drawing.Point(194, 101);
			this.m_lblCpGZipPerf.Name = "m_lblCpGZipPerf";
			this.m_lblCpGZipPerf.Size = new System.Drawing.Size(55, 13);
			this.m_lblCpGZipPerf.TabIndex = 9;
			this.m_lblCpGZipPerf.Text = "Very good";
			// 
			// m_lblCpGZipCp
			// 
			this.m_lblCpGZipCp.AutoSize = true;
			this.m_lblCpGZipCp.Location = new System.Drawing.Point(96, 101);
			this.m_lblCpGZipCp.Name = "m_lblCpGZipCp";
			this.m_lblCpGZipCp.Size = new System.Drawing.Size(52, 13);
			this.m_lblCpGZipCp.TabIndex = 8;
			this.m_lblCpGZipCp.Text = "Moderate";
			// 
			// m_lblCpNonePerf
			// 
			this.m_lblCpNonePerf.AutoSize = true;
			this.m_lblCpNonePerf.Location = new System.Drawing.Point(194, 78);
			this.m_lblCpNonePerf.Name = "m_lblCpNonePerf";
			this.m_lblCpNonePerf.Size = new System.Drawing.Size(52, 13);
			this.m_lblCpNonePerf.TabIndex = 6;
			this.m_lblCpNonePerf.Text = "Moderate";
			// 
			// m_lblCpNoneCp
			// 
			this.m_lblCpNoneCp.AutoSize = true;
			this.m_lblCpNoneCp.Location = new System.Drawing.Point(96, 78);
			this.m_lblCpNoneCp.Name = "m_lblCpNoneCp";
			this.m_lblCpNoneCp.Size = new System.Drawing.Size(83, 13);
			this.m_lblCpNoneCp.TabIndex = 5;
			this.m_lblCpNoneCp.Text = "No compression";
			// 
			// m_lblHeaderPerf
			// 
			this.m_lblHeaderPerf.AutoSize = true;
			this.m_lblHeaderPerf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
			this.m_lblHeaderPerf.Location = new System.Drawing.Point(194, 56);
			this.m_lblHeaderPerf.Name = "m_lblHeaderPerf";
			this.m_lblHeaderPerf.Size = new System.Drawing.Size(67, 13);
			this.m_lblHeaderPerf.TabIndex = 3;
			this.m_lblHeaderPerf.Text = "Performance";
			// 
			// m_lblHeaderCp
			// 
			this.m_lblHeaderCp.AutoSize = true;
			this.m_lblHeaderCp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic);
			this.m_lblHeaderCp.Location = new System.Drawing.Point(96, 56);
			this.m_lblHeaderCp.Name = "m_lblHeaderCp";
			this.m_lblHeaderCp.Size = new System.Drawing.Size(67, 13);
			this.m_lblHeaderCp.TabIndex = 2;
			this.m_lblHeaderCp.Text = "Compression";
			// 
			// m_rbGZip
			// 
			this.m_rbGZip.AutoSize = true;
			this.m_rbGZip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.m_rbGZip.Location = new System.Drawing.Point(11, 99);
			this.m_rbGZip.Name = "m_rbGZip";
			this.m_rbGZip.Size = new System.Drawing.Size(52, 17);
			this.m_rbGZip.TabIndex = 7;
			this.m_rbGZip.TabStop = true;
			this.m_rbGZip.Text = "GZip";
			this.m_rbGZip.UseVisualStyleBackColor = true;
			// 
			// m_rbNone
			// 
			this.m_rbNone.AutoSize = true;
			this.m_rbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.m_rbNone.Location = new System.Drawing.Point(11, 76);
			this.m_rbNone.Name = "m_rbNone";
			this.m_rbNone.Size = new System.Drawing.Size(55, 17);
			this.m_rbNone.TabIndex = 4;
			this.m_rbNone.TabStop = true;
			this.m_rbNone.Text = "None";
			this.m_rbNone.UseVisualStyleBackColor = true;
			// 
			// DatabaseSettingsForm
			// 
			this.AcceptButton = this.m_btnOK;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.m_btnCancel;
			this.ClientSize = new System.Drawing.Size(486, 434);
			this.Controls.Add(this.m_tabMain);
			this.Controls.Add(this.m_btnHelp);
			this.Controls.Add(this.m_bannerImage);
			this.Controls.Add(this.m_btnOK);
			this.Controls.Add(this.m_btnCancel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "DatabaseSettingsForm";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "<DYN>";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnFormClosed);
			((System.ComponentModel.ISupportInitialize)(this.m_bannerImage)).EndInit();
			this.m_grpEncAlgo.ResumeLayout(false);
			this.m_grpEncAlgo.PerformLayout();
			this.m_grpKeyTrans.ResumeLayout(false);
			this.m_grpKeyTrans.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.m_numEncRounds)).EndInit();
			this.m_tabMain.ResumeLayout(false);
			this.m_tabGeneral.ResumeLayout(false);
			this.m_tabGeneral.PerformLayout();
			this.m_tabSecurity.ResumeLayout(false);
			this.m_tabSecurity.PerformLayout();
			this.m_tabProtection.ResumeLayout(false);
			this.m_tabProtection.PerformLayout();
			this.m_tabCompression.ResumeLayout(false);
			this.m_tabCompression.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox m_bannerImage;
		private System.Windows.Forms.Button m_btnOK;
		private System.Windows.Forms.Button m_btnCancel;
		private System.Windows.Forms.GroupBox m_grpEncAlgo;
		private System.Windows.Forms.ComboBox m_cmbEncAlgo;
		private System.Windows.Forms.Label m_lblEncAlgoDesc;
		private System.Windows.Forms.Label m_lblTransNum;
		private System.Windows.Forms.Label m_lblTransIntro;
		private System.Windows.Forms.Label m_lblTransInfo;
		private System.Windows.Forms.GroupBox m_grpKeyTrans;
		private System.Windows.Forms.NumericUpDown m_numEncRounds;
		private System.Windows.Forms.Button m_btnHelp;
		private System.Windows.Forms.LinkLabel m_lnkCompute1SecDelay;
		private System.Windows.Forms.ToolTip m_ttRect;
		private System.Windows.Forms.Label m_lblCompressionIntro;
		private System.Windows.Forms.TabControl m_tabMain;
		private System.Windows.Forms.TabPage m_tabGeneral;
		private System.Windows.Forms.TabPage m_tabSecurity;
		private System.Windows.Forms.TabPage m_tabProtection;
		private System.Windows.Forms.TabPage m_tabCompression;
		private KeePass.UI.PromptedTextBox m_tbDbDesc;
		private System.Windows.Forms.Label m_lblDbDesc;
		private KeePass.UI.PromptedTextBox m_tbDbName;
		private System.Windows.Forms.Label m_lblDbName;
		private System.Windows.Forms.Label m_lblSecIntro;
		private System.Windows.Forms.Label m_lblProtIntro;
		private System.Windows.Forms.Label m_lblMemProtHint;
		private System.Windows.Forms.Label m_lblMemProtDesc;
		private System.Windows.Forms.CheckedListBox m_lbMemProt;
		private System.Windows.Forms.Label m_lblMemProtEnable;
		private System.Windows.Forms.RadioButton m_rbGZip;
		private System.Windows.Forms.RadioButton m_rbNone;
		private System.Windows.Forms.Label m_lblCpNonePerf;
		private System.Windows.Forms.Label m_lblCpNoneCp;
		private System.Windows.Forms.Label m_lblHeaderPerf;
		private System.Windows.Forms.Label m_lblHeaderCp;
		private System.Windows.Forms.Label m_lblCpGZipPerf;
		private System.Windows.Forms.Label m_lblCpGZipCp;
		private System.Windows.Forms.Label m_lblHeaderCpAlgo;
		private System.Windows.Forms.Label m_lblViewHint;
		private System.Windows.Forms.TextBox m_tbDefaultUser;
		private System.Windows.Forms.Label m_lblDefaultUser;
	}
}