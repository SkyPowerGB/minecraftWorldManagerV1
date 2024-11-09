namespace minecraftWorldManager
{
    partial class MCworldMngr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MCworldMngr));
            this.lbMcWorlds = new System.Windows.Forms.ListBox();
            this.lbBackups = new System.Windows.Forms.ListBox();
            this.btnLoadSaves = new System.Windows.Forms.Button();
            this.tbBackupsPath = new System.Windows.Forms.TextBox();
            this.tbMcSavesLocPath = new System.Windows.Forms.TextBox();
            this.btnSelectBackups = new System.Windows.Forms.Button();
            this.btnCutSavesToBackups = new System.Windows.Forms.Button();
            this.btnCutBckpToSaves = new System.Windows.Forms.Button();
            this.btnCopyBckpToSaves = new System.Windows.Forms.Button();
            this.btnCopySavesToBackup = new System.Windows.Forms.Button();
            this.btnOpenMarkForm = new System.Windows.Forms.Button();
            this.btnQuickBackup = new System.Windows.Forms.Button();
            this.lbQuickBackups = new System.Windows.Forms.ListBox();
            this.tbQbackupsLocPath = new System.Windows.Forms.TextBox();
            this.rTbDisplayWFdata = new System.Windows.Forms.RichTextBox();
            this.btnQuickBackupImport = new System.Windows.Forms.Button();
            this.lbBranchContents = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnSelectQbackupFolder = new System.Windows.Forms.Button();
            this.btnEditMark = new System.Windows.Forms.Button();
            this.btnSelectSavesFold = new System.Windows.Forms.Button();
            this.tbBranch = new System.Windows.Forms.TextBox();
            this.tbLocalWorldPath = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnCopyToSaves = new System.Windows.Forms.Button();
            this.chckOnlyBranches = new System.Windows.Forms.CheckBox();
            this.chckShowWorlds = new System.Windows.Forms.CheckBox();
            this.chckShowUnmarked = new System.Windows.Forms.CheckBox();
            this.tbShearch = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.cbVersionFilter = new System.Windows.Forms.ComboBox();
            this.btnReloadVersions = new System.Windows.Forms.Button();
            this.lbQbackupsContents = new System.Windows.Forms.ListBox();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbMcWorlds
            // 
            this.lbMcWorlds.FormattingEnabled = true;
            this.lbMcWorlds.Location = new System.Drawing.Point(12, 193);
            this.lbMcWorlds.Name = "lbMcWorlds";
            this.lbMcWorlds.ScrollAlwaysVisible = true;
            this.lbMcWorlds.Size = new System.Drawing.Size(286, 225);
            this.lbMcWorlds.TabIndex = 0;
            this.lbMcWorlds.SelectedIndexChanged += new System.EventHandler(this.lbMcWorlds_SelectedIndexChanged);
            // 
            // lbBackups
            // 
            this.lbBackups.FormattingEnabled = true;
            this.lbBackups.Location = new System.Drawing.Point(395, 198);
            this.lbBackups.Name = "lbBackups";
            this.lbBackups.ScrollAlwaysVisible = true;
            this.lbBackups.Size = new System.Drawing.Size(221, 225);
            this.lbBackups.TabIndex = 1;
            this.lbBackups.SelectedIndexChanged += new System.EventHandler(this.lbBackups_SelectedIndexChanged);
            // 
            // btnLoadSaves
            // 
            this.btnLoadSaves.Location = new System.Drawing.Point(12, 12);
            this.btnLoadSaves.Name = "btnLoadSaves";
            this.btnLoadSaves.Size = new System.Drawing.Size(95, 40);
            this.btnLoadSaves.TabIndex = 4;
            this.btnLoadSaves.Text = "Refresh Saves";
            this.btnLoadSaves.UseVisualStyleBackColor = true;
            this.btnLoadSaves.Click += new System.EventHandler(this.btnLoadSaves_Click);
            // 
            // tbBackupsPath
            // 
            this.tbBackupsPath.Location = new System.Drawing.Point(394, 171);
            this.tbBackupsPath.Name = "tbBackupsPath";
            this.tbBackupsPath.Size = new System.Drawing.Size(169, 20);
            this.tbBackupsPath.TabIndex = 7;
            this.tbBackupsPath.TextChanged += new System.EventHandler(this.tbBackupsPath_TextChanged);
            // 
            // tbMcSavesLocPath
            // 
            this.tbMcSavesLocPath.Location = new System.Drawing.Point(12, 145);
            this.tbMcSavesLocPath.Name = "tbMcSavesLocPath";
            this.tbMcSavesLocPath.Size = new System.Drawing.Size(233, 20);
            this.tbMcSavesLocPath.TabIndex = 29;
            this.tbMcSavesLocPath.TextChanged += new System.EventHandler(this.tbMcSavesLocPath_TextChanged);
            // 
            // btnSelectBackups
            // 
            this.btnSelectBackups.Location = new System.Drawing.Point(569, 171);
            this.btnSelectBackups.Name = "btnSelectBackups";
            this.btnSelectBackups.Size = new System.Drawing.Size(47, 20);
            this.btnSelectBackups.TabIndex = 31;
            this.btnSelectBackups.Text = "Open";
            this.btnSelectBackups.UseVisualStyleBackColor = true;
            this.btnSelectBackups.Click += new System.EventHandler(this.btnSelectBackups_Click);
            // 
            // btnCutSavesToBackups
            // 
            this.btnCutSavesToBackups.Location = new System.Drawing.Point(303, 198);
            this.btnCutSavesToBackups.Name = "btnCutSavesToBackups";
            this.btnCutSavesToBackups.Size = new System.Drawing.Size(85, 36);
            this.btnCutSavesToBackups.TabIndex = 32;
            this.btnCutSavesToBackups.Text = ">";
            this.btnCutSavesToBackups.UseVisualStyleBackColor = true;
            this.btnCutSavesToBackups.Click += new System.EventHandler(this.btnCutSavesToBackups_Click);
            // 
            // btnCutBckpToSaves
            // 
            this.btnCutBckpToSaves.Location = new System.Drawing.Point(304, 240);
            this.btnCutBckpToSaves.Name = "btnCutBckpToSaves";
            this.btnCutBckpToSaves.Size = new System.Drawing.Size(85, 36);
            this.btnCutBckpToSaves.TabIndex = 33;
            this.btnCutBckpToSaves.Text = "<";
            this.btnCutBckpToSaves.UseVisualStyleBackColor = true;
            this.btnCutBckpToSaves.Click += new System.EventHandler(this.btnCutBckpToSaves_Click);
            // 
            // btnCopyBckpToSaves
            // 
            this.btnCopyBckpToSaves.Location = new System.Drawing.Point(304, 324);
            this.btnCopyBckpToSaves.Name = "btnCopyBckpToSaves";
            this.btnCopyBckpToSaves.Size = new System.Drawing.Size(84, 36);
            this.btnCopyBckpToSaves.TabIndex = 34;
            this.btnCopyBckpToSaves.Text = "<<";
            this.btnCopyBckpToSaves.UseVisualStyleBackColor = true;
            this.btnCopyBckpToSaves.Click += new System.EventHandler(this.btnCopyBckpToSaves_Click);
            // 
            // btnCopySavesToBackup
            // 
            this.btnCopySavesToBackup.Location = new System.Drawing.Point(304, 282);
            this.btnCopySavesToBackup.Name = "btnCopySavesToBackup";
            this.btnCopySavesToBackup.Size = new System.Drawing.Size(84, 36);
            this.btnCopySavesToBackup.TabIndex = 35;
            this.btnCopySavesToBackup.Text = ">>";
            this.btnCopySavesToBackup.UseVisualStyleBackColor = true;
            this.btnCopySavesToBackup.Click += new System.EventHandler(this.btnCopySavesToBackup_Click);
            // 
            // btnOpenMarkForm
            // 
            this.btnOpenMarkForm.Location = new System.Drawing.Point(113, 12);
            this.btnOpenMarkForm.Name = "btnOpenMarkForm";
            this.btnOpenMarkForm.Size = new System.Drawing.Size(95, 40);
            this.btnOpenMarkForm.TabIndex = 40;
            this.btnOpenMarkForm.Text = "Mark";
            this.btnOpenMarkForm.UseVisualStyleBackColor = true;
            this.btnOpenMarkForm.Click += new System.EventHandler(this.btnOpenMarkForm_Click);
            // 
            // btnQuickBackup
            // 
            this.btnQuickBackup.Location = new System.Drawing.Point(12, 728);
            this.btnQuickBackup.Name = "btnQuickBackup";
            this.btnQuickBackup.Size = new System.Drawing.Size(95, 40);
            this.btnQuickBackup.TabIndex = 48;
            this.btnQuickBackup.Text = "Quick backup";
            this.btnQuickBackup.UseVisualStyleBackColor = true;
            this.btnQuickBackup.Click += new System.EventHandler(this.btnQuickBackup_Click);
            // 
            // lbQuickBackups
            // 
            this.lbQuickBackups.FormattingEnabled = true;
            this.lbQuickBackups.Location = new System.Drawing.Point(12, 488);
            this.lbQuickBackups.Name = "lbQuickBackups";
            this.lbQuickBackups.ScrollAlwaysVisible = true;
            this.lbQuickBackups.Size = new System.Drawing.Size(286, 199);
            this.lbQuickBackups.TabIndex = 50;
            this.lbQuickBackups.SelectedIndexChanged += new System.EventHandler(this.lbQuickBackups_SelectedIndexChanged);
            // 
            // tbQbackupsLocPath
            // 
            this.tbQbackupsLocPath.Location = new System.Drawing.Point(12, 703);
            this.tbQbackupsLocPath.Name = "tbQbackupsLocPath";
            this.tbQbackupsLocPath.Size = new System.Drawing.Size(233, 20);
            this.tbQbackupsLocPath.TabIndex = 51;
            // 
            // rTbDisplayWFdata
            // 
            this.rTbDisplayWFdata.Cursor = System.Windows.Forms.Cursors.Help;
            this.rTbDisplayWFdata.Location = new System.Drawing.Point(542, 488);
            this.rTbDisplayWFdata.Name = "rTbDisplayWFdata";
            this.rTbDisplayWFdata.Size = new System.Drawing.Size(193, 199);
            this.rTbDisplayWFdata.TabIndex = 52;
            this.rTbDisplayWFdata.Text = "";
            this.rTbDisplayWFdata.TextChanged += new System.EventHandler(this.rTbDisplayWFdata_TextChanged);
            // 
            // btnQuickBackupImport
            // 
            this.btnQuickBackupImport.Location = new System.Drawing.Point(214, 728);
            this.btnQuickBackupImport.Name = "btnQuickBackupImport";
            this.btnQuickBackupImport.Size = new System.Drawing.Size(95, 40);
            this.btnQuickBackupImport.TabIndex = 53;
            this.btnQuickBackupImport.Text = "Import Quick";
            this.btnQuickBackupImport.UseVisualStyleBackColor = true;
            this.btnQuickBackupImport.Click += new System.EventHandler(this.btnQuickBackupImport_Click);
            // 
            // lbBranchContents
            // 
            this.lbBranchContents.FormattingEnabled = true;
            this.lbBranchContents.Location = new System.Drawing.Point(622, 198);
            this.lbBranchContents.Name = "lbBranchContents";
            this.lbBranchContents.ScrollAlwaysVisible = true;
            this.lbBranchContents.Size = new System.Drawing.Size(218, 225);
            this.lbBranchContents.TabIndex = 54;
            this.lbBranchContents.SelectedIndexChanged += new System.EventHandler(this.lbBranchContents_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 22);
            this.button1.TabIndex = 55;
            this.button1.Text = "Create Branch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "CopyToBranch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(304, 366);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "CutToBranch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(846, 244);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 40);
            this.button4.TabIndex = 59;
            this.button4.Text = "Cut to saves";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(846, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(85, 40);
            this.button5.TabIndex = 58;
            this.button5.Text = "Copy To Saves";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(202, 425);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 22);
            this.button7.TabIndex = 61;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(544, 430);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 22);
            this.button8.TabIndex = 62;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(745, 429);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 22);
            this.button9.TabIndex = 63;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSelectQbackupFolder
            // 
            this.btnSelectQbackupFolder.Location = new System.Drawing.Point(251, 703);
            this.btnSelectQbackupFolder.Name = "btnSelectQbackupFolder";
            this.btnSelectQbackupFolder.Size = new System.Drawing.Size(47, 20);
            this.btnSelectQbackupFolder.TabIndex = 64;
            this.btnSelectQbackupFolder.Text = "Open";
            this.btnSelectQbackupFolder.UseVisualStyleBackColor = true;
            this.btnSelectQbackupFolder.Click += new System.EventHandler(this.btnSelectQbackupFolder_Click);
            // 
            // btnEditMark
            // 
            this.btnEditMark.Location = new System.Drawing.Point(454, 12);
            this.btnEditMark.Name = "btnEditMark";
            this.btnEditMark.Size = new System.Drawing.Size(87, 40);
            this.btnEditMark.TabIndex = 39;
            this.btnEditMark.Text = "WF editor";
            this.btnEditMark.UseVisualStyleBackColor = true;
            this.btnEditMark.Click += new System.EventHandler(this.btnEditMark_Click);
            // 
            // btnSelectSavesFold
            // 
            this.btnSelectSavesFold.Location = new System.Drawing.Point(251, 145);
            this.btnSelectSavesFold.Name = "btnSelectSavesFold";
            this.btnSelectSavesFold.Size = new System.Drawing.Size(47, 20);
            this.btnSelectSavesFold.TabIndex = 30;
            this.btnSelectSavesFold.Text = "Open";
            this.btnSelectSavesFold.UseVisualStyleBackColor = true;
            this.btnSelectSavesFold.Click += new System.EventHandler(this.btnSelectSavesFold_Click);
            // 
            // tbBranch
            // 
            this.tbBranch.Location = new System.Drawing.Point(622, 172);
            this.tbBranch.Name = "tbBranch";
            this.tbBranch.ReadOnly = true;
            this.tbBranch.Size = new System.Drawing.Size(218, 20);
            this.tbBranch.TabIndex = 65;
            // 
            // tbLocalWorldPath
            // 
            this.tbLocalWorldPath.Location = new System.Drawing.Point(12, 171);
            this.tbLocalWorldPath.Name = "tbLocalWorldPath";
            this.tbLocalWorldPath.Size = new System.Drawing.Size(134, 20);
            this.tbLocalWorldPath.TabIndex = 66;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(152, 171);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 20);
            this.button10.TabIndex = 68;
            this.button10.Text = "Select";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(251, 171);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 20);
            this.button11.TabIndex = 69;
            this.button11.Text = "Cut ";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(214, 12);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(95, 40);
            this.button12.TabIndex = 70;
            this.button12.Text = "Rename";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(547, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(95, 40);
            this.button13.TabIndex = 71;
            this.button13.Text = "Rename";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(846, 290);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(85, 40);
            this.button14.TabIndex = 72;
            this.button14.Text = "Rename";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 728);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 40);
            this.button6.TabIndex = 73;
            this.button6.Text = "DeleteQuick";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(114, 425);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(85, 23);
            this.button15.TabIndex = 74;
            this.button15.Text = "EditNBT";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(478, 429);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(60, 23);
            this.button16.TabIndex = 75;
            this.button16.Text = "EditNBT";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(660, 429);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(83, 23);
            this.button17.TabIndex = 76;
            this.button17.Text = "EditNBT";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // btnCopyToSaves
            // 
            this.btnCopyToSaves.Location = new System.Drawing.Point(202, 171);
            this.btnCopyToSaves.Name = "btnCopyToSaves";
            this.btnCopyToSaves.Size = new System.Drawing.Size(47, 20);
            this.btnCopyToSaves.TabIndex = 77;
            this.btnCopyToSaves.Text = "Copy";
            this.btnCopyToSaves.UseVisualStyleBackColor = true;
            this.btnCopyToSaves.Click += new System.EventHandler(this.btnCopyToSaves_Click);
            // 
            // chckOnlyBranches
            // 
            this.chckOnlyBranches.AutoSize = true;
            this.chckOnlyBranches.Checked = true;
            this.chckOnlyBranches.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckOnlyBranches.Location = new System.Drawing.Point(352, 105);
            this.chckOnlyBranches.Name = "chckOnlyBranches";
            this.chckOnlyBranches.Size = new System.Drawing.Size(96, 17);
            this.chckOnlyBranches.TabIndex = 78;
            this.chckOnlyBranches.Text = "showBranches";
            this.chckOnlyBranches.UseVisualStyleBackColor = true;
            this.chckOnlyBranches.CheckedChanged += new System.EventHandler(this.chckOnlyBranches_CheckedChanged);
            // 
            // chckShowWorlds
            // 
            this.chckShowWorlds.AutoSize = true;
            this.chckShowWorlds.Checked = true;
            this.chckShowWorlds.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chckShowWorlds.Location = new System.Drawing.Point(454, 105);
            this.chckShowWorlds.Name = "chckShowWorlds";
            this.chckShowWorlds.Size = new System.Drawing.Size(84, 17);
            this.chckShowWorlds.TabIndex = 79;
            this.chckShowWorlds.Text = "showWorlds";
            this.chckShowWorlds.UseVisualStyleBackColor = true;
            this.chckShowWorlds.CheckedChanged += new System.EventHandler(this.chckShowWorlds_CheckedChanged);
            // 
            // chckShowUnmarked
            // 
            this.chckShowUnmarked.AutoSize = true;
            this.chckShowUnmarked.Location = new System.Drawing.Point(543, 105);
            this.chckShowUnmarked.Name = "chckShowUnmarked";
            this.chckShowUnmarked.Size = new System.Drawing.Size(101, 17);
            this.chckShowUnmarked.TabIndex = 80;
            this.chckShowUnmarked.Text = "showUnMarked";
            this.chckShowUnmarked.UseVisualStyleBackColor = true;
            this.chckShowUnmarked.CheckedChanged += new System.EventHandler(this.chckShowUnmarked_CheckedChanged);
            // 
            // tbShearch
            // 
            this.tbShearch.Location = new System.Drawing.Point(371, 78);
            this.tbShearch.Name = "tbShearch";
            this.tbShearch.Size = new System.Drawing.Size(215, 20);
            this.tbShearch.TabIndex = 81;
            this.tbShearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(598, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(67, 20);
            this.btnRefresh.TabIndex = 82;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cbVersionFilter
            // 
            this.cbVersionFilter.FormattingEnabled = true;
            this.cbVersionFilter.Location = new System.Drawing.Point(244, 78);
            this.cbVersionFilter.Name = "cbVersionFilter";
            this.cbVersionFilter.Size = new System.Drawing.Size(121, 21);
            this.cbVersionFilter.TabIndex = 83;
            this.cbVersionFilter.SelectedIndexChanged += new System.EventHandler(this.cbVersionFilter_SelectedIndexChanged);
            // 
            // btnReloadVersions
            // 
            this.btnReloadVersions.Location = new System.Drawing.Point(171, 79);
            this.btnReloadVersions.Name = "btnReloadVersions";
            this.btnReloadVersions.Size = new System.Drawing.Size(67, 20);
            this.btnReloadVersions.TabIndex = 84;
            this.btnReloadVersions.Text = "Reload";
            this.btnReloadVersions.UseVisualStyleBackColor = true;
            this.btnReloadVersions.Click += new System.EventHandler(this.btnReloadVersions_Click);
            // 
            // lbQbackupsContents
            // 
            this.lbQbackupsContents.FormattingEnabled = true;
            this.lbQbackupsContents.Location = new System.Drawing.Point(351, 488);
            this.lbQbackupsContents.Name = "lbQbackupsContents";
            this.lbQbackupsContents.ScrollAlwaysVisible = true;
            this.lbQbackupsContents.Size = new System.Drawing.Size(179, 199);
            this.lbQbackupsContents.TabIndex = 85;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(350, 693);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(57, 20);
            this.button18.TabIndex = 86;
            this.button18.Text = "Import";
            this.button18.UseVisualStyleBackColor = true;
            this.button18.Click += new System.EventHandler(this.button18_Click);
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(470, 693);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(60, 20);
            this.button19.TabIndex = 87;
            this.button19.Text = "Delete";
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(950, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(116, 40);
            this.btnSettings.TabIndex = 88;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // MCworldMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 769);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.lbQbackupsContents);
            this.Controls.Add(this.btnReloadVersions);
            this.Controls.Add(this.cbVersionFilter);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.tbShearch);
            this.Controls.Add(this.chckShowUnmarked);
            this.Controls.Add(this.chckShowWorlds);
            this.Controls.Add(this.chckOnlyBranches);
            this.Controls.Add(this.btnCopyToSaves);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.tbLocalWorldPath);
            this.Controls.Add(this.tbBranch);
            this.Controls.Add(this.btnSelectQbackupFolder);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbBranchContents);
            this.Controls.Add(this.btnQuickBackupImport);
            this.Controls.Add(this.rTbDisplayWFdata);
            this.Controls.Add(this.tbQbackupsLocPath);
            this.Controls.Add(this.lbQuickBackups);
            this.Controls.Add(this.btnQuickBackup);
            this.Controls.Add(this.btnOpenMarkForm);
            this.Controls.Add(this.btnEditMark);
            this.Controls.Add(this.btnCopySavesToBackup);
            this.Controls.Add(this.btnCopyBckpToSaves);
            this.Controls.Add(this.btnCutBckpToSaves);
            this.Controls.Add(this.btnCutSavesToBackups);
            this.Controls.Add(this.btnSelectBackups);
            this.Controls.Add(this.btnSelectSavesFold);
            this.Controls.Add(this.tbMcSavesLocPath);
            this.Controls.Add(this.tbBackupsPath);
            this.Controls.Add(this.btnLoadSaves);
            this.Controls.Add(this.lbBackups);
            this.Controls.Add(this.lbMcWorlds);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MCworldMngr";
            this.Text = "Minecraft world Manager";
            this.Load += new System.EventHandler(this.MCworldMngr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbMcWorlds;
        private System.Windows.Forms.ListBox lbBackups;
        private System.Windows.Forms.Button btnLoadSaves;
        private System.Windows.Forms.TextBox tbBackupsPath;
        private System.Windows.Forms.TextBox tbMcSavesLocPath;
        private System.Windows.Forms.Button btnSelectBackups;
        private System.Windows.Forms.Button btnCutSavesToBackups;
        private System.Windows.Forms.Button btnCutBckpToSaves;
        private System.Windows.Forms.Button btnCopyBckpToSaves;
        private System.Windows.Forms.Button btnCopySavesToBackup;
        private System.Windows.Forms.Button btnOpenMarkForm;
        private System.Windows.Forms.Button btnQuickBackup;
        private System.Windows.Forms.ListBox lbQuickBackups;
        private System.Windows.Forms.TextBox tbQbackupsLocPath;
        private System.Windows.Forms.RichTextBox rTbDisplayWFdata;
        private System.Windows.Forms.Button btnQuickBackupImport;
        private System.Windows.Forms.ListBox lbBranchContents;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button btnSelectQbackupFolder;
        private System.Windows.Forms.Button btnEditMark;
        private System.Windows.Forms.Button btnSelectSavesFold;
        private System.Windows.Forms.TextBox tbBranch;
        private System.Windows.Forms.TextBox tbLocalWorldPath;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnCopyToSaves;
        private System.Windows.Forms.CheckBox chckOnlyBranches;
        private System.Windows.Forms.CheckBox chckShowWorlds;
        private System.Windows.Forms.CheckBox chckShowUnmarked;
        private System.Windows.Forms.TextBox tbShearch;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ComboBox cbVersionFilter;
        private System.Windows.Forms.Button btnReloadVersions;
        private System.Windows.Forms.ListBox lbQbackupsContents;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button btnSettings;
    }
}

