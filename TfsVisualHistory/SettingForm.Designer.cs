﻿namespace Sitronics.TfsVisualHistory
{
    partial class SettingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.okButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.pathTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.historySettingsGroupBox = new System.Windows.Forms.GroupBox();
			this.dateToLabel = new System.Windows.Forms.Label();
			this.dateFromLabel = new System.Windows.Forms.Label();
			this.timeScaleComboBox = new System.Windows.Forms.ComboBox();
			this.loopPlaybackCheckBox = new System.Windows.Forms.CheckBox();
			this.label11 = new System.Windows.Forms.Label();
			this.dateToPicker = new System.Windows.Forms.DateTimePicker();
			this.dateFromPicker = new System.Windows.Forms.DateTimePicker();
			this.secondsPerDayTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.userExcludeTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.userIncludeTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.resetToDefaultButton = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.filesExcludeTextBox = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.filesIncludeTextBox = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.LogoFileTextBox = new System.Windows.Forms.TextBox();
			this.ViewLogoCheckBox = new System.Windows.Forms.CheckBox();
			this.viewAvatarsCheckBox = new System.Windows.Forms.CheckBox();
			this.viewFilesExtentionMapCheckBox = new System.Windows.Forms.CheckBox();
			this.label12 = new System.Windows.Forms.Label();
			this.viewUserNamesCheckBox = new System.Windows.Forms.CheckBox();
			this.viewDirNamesCheckBox = new System.Windows.Forms.CheckBox();
			this.maxFilesTextBox = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.viewFileNamesCheckBox = new System.Windows.Forms.CheckBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.loadSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.saveSettingsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.restoreDefaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.interactiveKeyboardCommandsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.setResolutionCheckBox = new System.Windows.Forms.CheckBox();
			this.fullScreenCheckBox = new System.Windows.Forms.CheckBox();
			this.resolutionHeightTextBox = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.resolutionWidthTextBox = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.liveStreamRadioButton = new System.Windows.Forms.RadioButton();
			this.historyRadioButton = new System.Windows.Forms.RadioButton();
			this.selectLogoFileButton = new System.Windows.Forms.Button();
			this.historySettingsGroupBox.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.SuspendLayout();
			// 
			// okButton
			// 
			this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.okButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.okButton.Location = new System.Drawing.Point(391, 409);
			this.okButton.Name = "okButton";
			this.okButton.Size = new System.Drawing.Size(135, 23);
			this.okButton.TabIndex = 0;
			this.okButton.Text = "Start";
			this.okButton.UseVisualStyleBackColor = true;
			this.okButton.Click += new System.EventHandler(this.okButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(532, 409);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 1;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// pathTextBox
			// 
			this.pathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pathTextBox.Location = new System.Drawing.Point(47, 27);
			this.pathTextBox.Name = "pathTextBox";
			this.pathTextBox.ReadOnly = true;
			this.pathTextBox.Size = new System.Drawing.Size(560, 20);
			this.pathTextBox.TabIndex = 4;
			this.pathTextBox.TabStop = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 27);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Path";
			// 
			// historySettingsGroupBox
			// 
			this.historySettingsGroupBox.Controls.Add(this.dateToLabel);
			this.historySettingsGroupBox.Controls.Add(this.dateFromLabel);
			this.historySettingsGroupBox.Controls.Add(this.timeScaleComboBox);
			this.historySettingsGroupBox.Controls.Add(this.loopPlaybackCheckBox);
			this.historySettingsGroupBox.Controls.Add(this.label11);
			this.historySettingsGroupBox.Controls.Add(this.dateToPicker);
			this.historySettingsGroupBox.Controls.Add(this.dateFromPicker);
			this.historySettingsGroupBox.Controls.Add(this.secondsPerDayTextBox);
			this.historySettingsGroupBox.Controls.Add(this.label8);
			this.historySettingsGroupBox.Location = new System.Drawing.Point(12, 131);
			this.historySettingsGroupBox.Name = "historySettingsGroupBox";
			this.historySettingsGroupBox.Size = new System.Drawing.Size(308, 125);
			this.historySettingsGroupBox.TabIndex = 6;
			this.historySettingsGroupBox.TabStop = false;
			this.historySettingsGroupBox.Text = "History setting";
			// 
			// dateToLabel
			// 
			this.dateToLabel.AutoSize = true;
			this.dateToLabel.Location = new System.Drawing.Point(159, 25);
			this.dateToLabel.Name = "dateToLabel";
			this.dateToLabel.Size = new System.Drawing.Size(23, 13);
			this.dateToLabel.TabIndex = 2;
			this.dateToLabel.Text = "To:";
			// 
			// dateFromLabel
			// 
			this.dateFromLabel.AutoSize = true;
			this.dateFromLabel.Location = new System.Drawing.Point(6, 25);
			this.dateFromLabel.Name = "dateFromLabel";
			this.dateFromLabel.Size = new System.Drawing.Size(33, 13);
			this.dateFromLabel.TabIndex = 0;
			this.dateFromLabel.Text = "From:";
			// 
			// timeScaleComboBox
			// 
			this.timeScaleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.timeScaleComboBox.FormattingEnabled = true;
			this.timeScaleComboBox.Items.AddRange(new object[] {
            "<None>",
            "Slow x1/8",
            "Slow x1/4",
            "Slow x1/2",
            "Fast x2",
            "Fast x3",
            "Fast x4"});
			this.timeScaleComboBox.Location = new System.Drawing.Point(144, 77);
			this.timeScaleComboBox.Name = "timeScaleComboBox";
			this.timeScaleComboBox.Size = new System.Drawing.Size(82, 21);
			this.timeScaleComboBox.TabIndex = 7;
			// 
			// loopPlaybackCheckBox
			// 
			this.loopPlaybackCheckBox.AutoSize = true;
			this.loopPlaybackCheckBox.Location = new System.Drawing.Point(10, 104);
			this.loopPlaybackCheckBox.Name = "loopPlaybackCheckBox";
			this.loopPlaybackCheckBox.Size = new System.Drawing.Size(96, 17);
			this.loopPlaybackCheckBox.TabIndex = 10;
			this.loopPlaybackCheckBox.Text = "Loop playback";
			this.loopPlaybackCheckBox.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(7, 80);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 13);
			this.label11.TabIndex = 6;
			this.label11.Text = "Time scale:";
			// 
			// dateToPicker
			// 
			this.dateToPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateToPicker.Location = new System.Drawing.Point(188, 23);
			this.dateToPicker.Name = "dateToPicker";
			this.dateToPicker.Size = new System.Drawing.Size(105, 20);
			this.dateToPicker.TabIndex = 3;
			// 
			// dateFromPicker
			// 
			this.dateFromPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateFromPicker.Location = new System.Drawing.Point(45, 22);
			this.dateFromPicker.Name = "dateFromPicker";
			this.dateFromPicker.Size = new System.Drawing.Size(105, 20);
			this.dateFromPicker.TabIndex = 1;
			// 
			// secondsPerDayTextBox
			// 
			this.secondsPerDayTextBox.Location = new System.Drawing.Point(144, 53);
			this.secondsPerDayTextBox.MaxLength = 5;
			this.secondsPerDayTextBox.Name = "secondsPerDayTextBox";
			this.secondsPerDayTextBox.Size = new System.Drawing.Size(51, 20);
			this.secondsPerDayTextBox.TabIndex = 5;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(6, 57);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(132, 13);
			this.label8.TabIndex = 4;
			this.label8.Text = "Seconds per day (1-1000):";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.userExcludeTextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.userIncludeTextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(328, 53);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(280, 89);
			this.groupBox1.TabIndex = 11;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "User name filter";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(61, 67);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(147, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Example: John*; *Eva; *robot*";
			// 
			// userExcludeTextBox
			// 
			this.userExcludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userExcludeTextBox.Location = new System.Drawing.Point(59, 44);
			this.userExcludeTextBox.Name = "userExcludeTextBox";
			this.userExcludeTextBox.Size = new System.Drawing.Size(215, 20);
			this.userExcludeTextBox.TabIndex = 3;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(8, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Exclude:";
			// 
			// userIncludeTextBox
			// 
			this.userIncludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.userIncludeTextBox.Location = new System.Drawing.Point(59, 18);
			this.userIncludeTextBox.Name = "userIncludeTextBox";
			this.userIncludeTextBox.Size = new System.Drawing.Size(215, 20);
			this.userIncludeTextBox.TabIndex = 1;
			this.userIncludeTextBox.Text = "*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(8, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 13);
			this.label2.TabIndex = 0;
			this.label2.Text = "Include:";
			// 
			// resetToDefaultButton
			// 
			this.resetToDefaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.resetToDefaultButton.Location = new System.Drawing.Point(15, 409);
			this.resetToDefaultButton.Name = "resetToDefaultButton";
			this.resetToDefaultButton.Size = new System.Drawing.Size(96, 23);
			this.resetToDefaultButton.TabIndex = 14;
			this.resetToDefaultButton.Text = "Restore &Defaults";
			this.resetToDefaultButton.UseVisualStyleBackColor = true;
			this.resetToDefaultButton.Click += new System.EventHandler(this.resetToDefaultButton_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.filesExcludeTextBox);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.filesIncludeTextBox);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Location = new System.Drawing.Point(328, 148);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(280, 89);
			this.groupBox2.TabIndex = 12;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "File type filter";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(61, 67);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Example: *.cs;*.txt";
			// 
			// filesExcludeTextBox
			// 
			this.filesExcludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.filesExcludeTextBox.Location = new System.Drawing.Point(59, 44);
			this.filesExcludeTextBox.Name = "filesExcludeTextBox";
			this.filesExcludeTextBox.Size = new System.Drawing.Size(215, 20);
			this.filesExcludeTextBox.TabIndex = 3;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(8, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 2;
			this.label6.Text = "Exclude:";
			// 
			// filesIncludeTextBox
			// 
			this.filesIncludeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.filesIncludeTextBox.Location = new System.Drawing.Point(59, 18);
			this.filesIncludeTextBox.Name = "filesIncludeTextBox";
			this.filesIncludeTextBox.Size = new System.Drawing.Size(215, 20);
			this.filesIncludeTextBox.TabIndex = 1;
			this.filesIncludeTextBox.Text = "*";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(8, 21);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(45, 13);
			this.label7.TabIndex = 0;
			this.label7.Text = "Include:";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.selectLogoFileButton);
			this.groupBox3.Controls.Add(this.LogoFileTextBox);
			this.groupBox3.Controls.Add(this.ViewLogoCheckBox);
			this.groupBox3.Controls.Add(this.viewAvatarsCheckBox);
			this.groupBox3.Controls.Add(this.viewFilesExtentionMapCheckBox);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.viewUserNamesCheckBox);
			this.groupBox3.Controls.Add(this.viewDirNamesCheckBox);
			this.groupBox3.Controls.Add(this.maxFilesTextBox);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.viewFileNamesCheckBox);
			this.groupBox3.Location = new System.Drawing.Point(12, 262);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(306, 131);
			this.groupBox3.TabIndex = 7;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Visualization";
			// 
			// LogoFileTextBox
			// 
			this.LogoFileTextBox.Location = new System.Drawing.Point(79, 102);
			this.LogoFileTextBox.Name = "LogoFileTextBox";
			this.LogoFileTextBox.Size = new System.Drawing.Size(191, 20);
			this.LogoFileTextBox.TabIndex = 9;
			// 
			// ViewLogoCheckBox
			// 
			this.ViewLogoCheckBox.AutoSize = true;
			this.ViewLogoCheckBox.Location = new System.Drawing.Point(9, 104);
			this.ViewLogoCheckBox.Name = "ViewLogoCheckBox";
			this.ViewLogoCheckBox.Size = new System.Drawing.Size(69, 17);
			this.ViewLogoCheckBox.TabIndex = 8;
			this.ViewLogoCheckBox.Text = "Logo file:";
			this.ViewLogoCheckBox.ThreeState = true;
			this.ViewLogoCheckBox.UseVisualStyleBackColor = true;
			this.ViewLogoCheckBox.CheckStateChanged += new System.EventHandler(this.ViewLogoCheckBox_CheckStateChanged);
			// 
			// viewAvatarsCheckBox
			// 
			this.viewAvatarsCheckBox.AutoSize = true;
			this.viewAvatarsCheckBox.Location = new System.Drawing.Point(240, 25);
			this.viewAvatarsCheckBox.Name = "viewAvatarsCheckBox";
			this.viewAvatarsCheckBox.Size = new System.Drawing.Size(62, 17);
			this.viewAvatarsCheckBox.TabIndex = 4;
			this.viewAvatarsCheckBox.Text = "Avatars";
			this.viewAvatarsCheckBox.UseVisualStyleBackColor = true;
			// 
			// viewFilesExtentionMapCheckBox
			// 
			this.viewFilesExtentionMapCheckBox.AutoSize = true;
			this.viewFilesExtentionMapCheckBox.Location = new System.Drawing.Point(10, 78);
			this.viewFilesExtentionMapCheckBox.Name = "viewFilesExtentionMapCheckBox";
			this.viewFilesExtentionMapCheckBox.Size = new System.Drawing.Size(141, 17);
			this.viewFilesExtentionMapCheckBox.TabIndex = 7;
			this.viewFilesExtentionMapCheckBox.Text = "View files extension map";
			this.viewFilesExtentionMapCheckBox.UseVisualStyleBackColor = true;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(7, 26);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(33, 13);
			this.label12.TabIndex = 0;
			this.label12.Text = "View:";
			// 
			// viewUserNamesCheckBox
			// 
			this.viewUserNamesCheckBox.AutoSize = true;
			this.viewUserNamesCheckBox.Location = new System.Drawing.Point(181, 25);
			this.viewUserNamesCheckBox.Name = "viewUserNamesCheckBox";
			this.viewUserNamesCheckBox.Size = new System.Drawing.Size(53, 17);
			this.viewUserNamesCheckBox.TabIndex = 3;
			this.viewUserNamesCheckBox.Text = "Users";
			this.viewUserNamesCheckBox.UseVisualStyleBackColor = true;
			// 
			// viewDirNamesCheckBox
			// 
			this.viewDirNamesCheckBox.AutoSize = true;
			this.viewDirNamesCheckBox.Location = new System.Drawing.Point(99, 25);
			this.viewDirNamesCheckBox.Name = "viewDirNamesCheckBox";
			this.viewDirNamesCheckBox.Size = new System.Drawing.Size(76, 17);
			this.viewDirNamesCheckBox.TabIndex = 2;
			this.viewDirNamesCheckBox.Text = "Directories";
			this.viewDirNamesCheckBox.UseVisualStyleBackColor = true;
			// 
			// maxFilesTextBox
			// 
			this.maxFilesTextBox.Location = new System.Drawing.Point(149, 52);
			this.maxFilesTextBox.MaxLength = 7;
			this.maxFilesTextBox.Name = "maxFilesTextBox";
			this.maxFilesTextBox.Size = new System.Drawing.Size(51, 20);
			this.maxFilesTextBox.TabIndex = 6;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(7, 55);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(133, 13);
			this.label9.TabIndex = 5;
			this.label9.Text = "Max number of active files:";
			// 
			// viewFileNamesCheckBox
			// 
			this.viewFileNamesCheckBox.AutoSize = true;
			this.viewFileNamesCheckBox.Location = new System.Drawing.Point(46, 25);
			this.viewFileNamesCheckBox.Name = "viewFileNamesCheckBox";
			this.viewFileNamesCheckBox.Size = new System.Drawing.Size(47, 17);
			this.viewFileNamesCheckBox.TabIndex = 1;
			this.viewFileNamesCheckBox.Text = "Files";
			this.viewFileNamesCheckBox.UseVisualStyleBackColor = true;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(619, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadSettingsToolStripMenuItem,
            this.toolStripMenuItem2,
            this.saveSettingsToFileToolStripMenuItem,
            this.toolStripMenuItem1,
            this.restoreDefaultToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// loadSettingsToolStripMenuItem
			// 
			this.loadSettingsToolStripMenuItem.Name = "loadSettingsToolStripMenuItem";
			this.loadSettingsToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.loadSettingsToolStripMenuItem.Text = "&Load Settings";
			this.loadSettingsToolStripMenuItem.Click += new System.EventHandler(this.loadSettingsToolStripMenuItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(195, 6);
			// 
			// saveSettingsToFileToolStripMenuItem
			// 
			this.saveSettingsToFileToolStripMenuItem.Name = "saveSettingsToFileToolStripMenuItem";
			this.saveSettingsToFileToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.saveSettingsToFileToolStripMenuItem.Text = "&Save Settings As...";
			this.saveSettingsToFileToolStripMenuItem.Click += new System.EventHandler(this.saveSettingsToFileToolStripMenuItem_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(195, 6);
			// 
			// restoreDefaultToolStripMenuItem
			// 
			this.restoreDefaultToolStripMenuItem.Name = "restoreDefaultToolStripMenuItem";
			this.restoreDefaultToolStripMenuItem.Size = new System.Drawing.Size(198, 22);
			this.restoreDefaultToolStripMenuItem.Text = "Restore Default settings";
			this.restoreDefaultToolStripMenuItem.Click += new System.EventHandler(this.resetToDefaultButton_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.interactiveKeyboardCommandsToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// interactiveKeyboardCommandsToolStripMenuItem
			// 
			this.interactiveKeyboardCommandsToolStripMenuItem.Name = "interactiveKeyboardCommandsToolStripMenuItem";
			this.interactiveKeyboardCommandsToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
			this.interactiveKeyboardCommandsToolStripMenuItem.Text = "Interactive keyboard commands";
			this.interactiveKeyboardCommandsToolStripMenuItem.Click += new System.EventHandler(this.interactiveKeyboardCommandsToolStripMenuItem_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "VHCfg";
			this.saveFileDialog1.FileName = "VisualHistorySettings1.VHCfg";
			this.saveFileDialog1.Filter = "Setting|*.VHCfg";
			this.saveFileDialog1.Title = "Save Visualization Settings";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.DefaultExt = "VHCfg";
			this.openFileDialog1.FileName = "VisualHistorySettings1.VHCfg";
			this.openFileDialog1.Filter = "Setting|*.VHCfg";
			this.openFileDialog1.Title = "Open Visualization Settings";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.setResolutionCheckBox);
			this.groupBox4.Controls.Add(this.fullScreenCheckBox);
			this.groupBox4.Controls.Add(this.resolutionHeightTextBox);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.resolutionWidthTextBox);
			this.groupBox4.Location = new System.Drawing.Point(327, 263);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(280, 103);
			this.groupBox4.TabIndex = 13;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "View Size";
			// 
			// setResolutionCheckBox
			// 
			this.setResolutionCheckBox.AutoSize = true;
			this.setResolutionCheckBox.Location = new System.Drawing.Point(14, 44);
			this.setResolutionCheckBox.Name = "setResolutionCheckBox";
			this.setResolutionCheckBox.Size = new System.Drawing.Size(95, 17);
			this.setResolutionCheckBox.TabIndex = 1;
			this.setResolutionCheckBox.Text = "Set Resolution";
			this.setResolutionCheckBox.UseVisualStyleBackColor = true;
			this.setResolutionCheckBox.CheckedChanged += new System.EventHandler(this.setResolutionCheckBox_CheckedChanged);
			// 
			// fullScreenCheckBox
			// 
			this.fullScreenCheckBox.AutoSize = true;
			this.fullScreenCheckBox.Location = new System.Drawing.Point(14, 19);
			this.fullScreenCheckBox.Name = "fullScreenCheckBox";
			this.fullScreenCheckBox.Size = new System.Drawing.Size(192, 17);
			this.fullScreenCheckBox.TabIndex = 0;
			this.fullScreenCheckBox.Text = "Full Screen mode (toggle Alt+Enter)";
			this.fullScreenCheckBox.UseVisualStyleBackColor = true;
			// 
			// resolutionHeightTextBox
			// 
			this.resolutionHeightTextBox.Enabled = false;
			this.resolutionHeightTextBox.Location = new System.Drawing.Point(190, 42);
			this.resolutionHeightTextBox.MaxLength = 4;
			this.resolutionHeightTextBox.Name = "resolutionHeightTextBox";
			this.resolutionHeightTextBox.Size = new System.Drawing.Size(43, 20);
			this.resolutionHeightTextBox.TabIndex = 3;
			this.resolutionHeightTextBox.Text = "600";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(172, 45);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(12, 13);
			this.label10.TabIndex = 3;
			this.label10.Text = "x";
			// 
			// resolutionWidthTextBox
			// 
			this.resolutionWidthTextBox.Enabled = false;
			this.resolutionWidthTextBox.Location = new System.Drawing.Point(119, 42);
			this.resolutionWidthTextBox.MaxLength = 4;
			this.resolutionWidthTextBox.Name = "resolutionWidthTextBox";
			this.resolutionWidthTextBox.Size = new System.Drawing.Size(47, 20);
			this.resolutionWidthTextBox.TabIndex = 2;
			this.resolutionWidthTextBox.Text = "800";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.liveStreamRadioButton);
			this.groupBox5.Controls.Add(this.historyRadioButton);
			this.groupBox5.Location = new System.Drawing.Point(12, 53);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(308, 72);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Play Mode";
			// 
			// liveStreamRadioButton
			// 
			this.liveStreamRadioButton.AutoSize = true;
			this.liveStreamRadioButton.Location = new System.Drawing.Point(149, 33);
			this.liveStreamRadioButton.Name = "liveStreamRadioButton";
			this.liveStreamRadioButton.Size = new System.Drawing.Size(138, 17);
			this.liveStreamRadioButton.TabIndex = 1;
			this.liveStreamRadioButton.Text = "Live Changes (real time)";
			this.liveStreamRadioButton.UseVisualStyleBackColor = true;
			this.liveStreamRadioButton.CheckedChanged += new System.EventHandler(this.historyRadioButton_CheckedChanged);
			// 
			// historyRadioButton
			// 
			this.historyRadioButton.AutoSize = true;
			this.historyRadioButton.Checked = true;
			this.historyRadioButton.Location = new System.Drawing.Point(22, 33);
			this.historyRadioButton.Name = "historyRadioButton";
			this.historyRadioButton.Size = new System.Drawing.Size(101, 17);
			this.historyRadioButton.TabIndex = 0;
			this.historyRadioButton.TabStop = true;
			this.historyRadioButton.Text = "Visualize History";
			this.historyRadioButton.UseVisualStyleBackColor = true;
			this.historyRadioButton.CheckedChanged += new System.EventHandler(this.historyRadioButton_CheckedChanged);
			// 
			// selectLogoFileButton
			// 
			this.selectLogoFileButton.Location = new System.Drawing.Point(272, 101);
			this.selectLogoFileButton.Name = "selectLogoFileButton";
			this.selectLogoFileButton.Size = new System.Drawing.Size(30, 22);
			this.selectLogoFileButton.TabIndex = 10;
			this.selectLogoFileButton.Text = "...";
			this.selectLogoFileButton.UseVisualStyleBackColor = true;
			this.selectLogoFileButton.Click += new System.EventHandler(this.selectLogoFileButton_Click);
			// 
			// SettingForm
			// 
			this.AcceptButton = this.okButton;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(619, 444);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.resetToDefaultButton);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.historySettingsGroupBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pathTextBox);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.okButton);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "SettingForm";
			this.ShowIcon = false;
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Visualization Settings";
			this.historySettingsGroupBox.ResumeLayout(false);
			this.historySettingsGroupBox.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox historySettingsGroupBox;
        private System.Windows.Forms.Label dateToLabel;
        private System.Windows.Forms.Label dateFromLabel;
        private System.Windows.Forms.DateTimePicker dateToPicker;
        private System.Windows.Forms.DateTimePicker dateFromPicker;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox userExcludeTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userIncludeTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button resetToDefaultButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox filesExcludeTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox filesIncludeTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox viewFileNamesCheckBox;
        private System.Windows.Forms.TextBox secondsPerDayTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox maxFilesTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveSettingsToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem restoreDefaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem interactiveKeyboardCommandsToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox resolutionHeightTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox resolutionWidthTextBox;
        private System.Windows.Forms.CheckBox setResolutionCheckBox;
        private System.Windows.Forms.CheckBox fullScreenCheckBox;
        private System.Windows.Forms.CheckBox loopPlaybackCheckBox;
        private System.Windows.Forms.CheckBox viewDirNamesCheckBox;
        private System.Windows.Forms.ComboBox timeScaleComboBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox viewUserNamesCheckBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton liveStreamRadioButton;
        private System.Windows.Forms.RadioButton historyRadioButton;
		private System.Windows.Forms.CheckBox viewFilesExtentionMapCheckBox;
		private System.Windows.Forms.CheckBox viewAvatarsCheckBox;
		private System.Windows.Forms.TextBox LogoFileTextBox;
		private System.Windows.Forms.CheckBox ViewLogoCheckBox;
		private System.Windows.Forms.Button selectLogoFileButton;
    }
}