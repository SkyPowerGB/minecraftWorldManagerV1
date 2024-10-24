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
            this.SuspendLayout();
            // 
            // lbMcWorlds
            // 
            this.lbMcWorlds.FormattingEnabled = true;
            this.lbMcWorlds.Location = new System.Drawing.Point(12, 115);
            this.lbMcWorlds.Name = "lbMcWorlds";
            this.lbMcWorlds.ScrollAlwaysVisible = true;
            this.lbMcWorlds.Size = new System.Drawing.Size(286, 225);
            this.lbMcWorlds.TabIndex = 0;
            this.lbMcWorlds.SelectedIndexChanged += new System.EventHandler(this.lbMcWorlds_SelectedIndexChanged);
            // 
            // lbBackups
            // 
            this.lbBackups.FormattingEnabled = true;
            this.lbBackups.Location = new System.Drawing.Point(352, 116);
            this.lbBackups.Name = "lbBackups";
            this.lbBackups.ScrollAlwaysVisible = true;
            this.lbBackups.Size = new System.Drawing.Size(293, 225);
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
            this.tbBackupsPath.Location = new System.Drawing.Point(351, 89);
            this.tbBackupsPath.Name = "tbBackupsPath";
            this.tbBackupsPath.Size = new System.Drawing.Size(241, 20);
            this.tbBackupsPath.TabIndex = 7;
            // 
            // tbMcSavesLocPath
            // 
            this.tbMcSavesLocPath.Location = new System.Drawing.Point(12, 67);
            this.tbMcSavesLocPath.Name = "tbMcSavesLocPath";
            this.tbMcSavesLocPath.Size = new System.Drawing.Size(233, 20);
            this.tbMcSavesLocPath.TabIndex = 29;
            this.tbMcSavesLocPath.TextChanged += new System.EventHandler(this.tbMcSavesLocPath_TextChanged);
            // 
            // btnSelectBackups
            // 
            this.btnSelectBackups.Location = new System.Drawing.Point(597, 89);
            this.btnSelectBackups.Name = "btnSelectBackups";
            this.btnSelectBackups.Size = new System.Drawing.Size(47, 20);
            this.btnSelectBackups.TabIndex = 31;
            this.btnSelectBackups.Text = "Open";
            this.btnSelectBackups.UseVisualStyleBackColor = true;
            this.btnSelectBackups.Click += new System.EventHandler(this.btnSelectBackups_Click);
            // 
            // btnCutSavesToBackups
            // 
            this.btnCutSavesToBackups.Location = new System.Drawing.Point(305, 135);
            this.btnCutSavesToBackups.Name = "btnCutSavesToBackups";
            this.btnCutSavesToBackups.Size = new System.Drawing.Size(41, 41);
            this.btnCutSavesToBackups.TabIndex = 32;
            this.btnCutSavesToBackups.Text = ">";
            this.btnCutSavesToBackups.UseVisualStyleBackColor = true;
            this.btnCutSavesToBackups.Click += new System.EventHandler(this.btnCutSavesToBackups_Click);
            // 
            // btnCutBckpToSaves
            // 
            this.btnCutBckpToSaves.Location = new System.Drawing.Point(305, 182);
            this.btnCutBckpToSaves.Name = "btnCutBckpToSaves";
            this.btnCutBckpToSaves.Size = new System.Drawing.Size(41, 41);
            this.btnCutBckpToSaves.TabIndex = 33;
            this.btnCutBckpToSaves.Text = "<";
            this.btnCutBckpToSaves.UseVisualStyleBackColor = true;
            this.btnCutBckpToSaves.Click += new System.EventHandler(this.btnCutBckpToSaves_Click);
            // 
            // btnCopyBckpToSaves
            // 
            this.btnCopyBckpToSaves.Location = new System.Drawing.Point(305, 276);
            this.btnCopyBckpToSaves.Name = "btnCopyBckpToSaves";
            this.btnCopyBckpToSaves.Size = new System.Drawing.Size(41, 41);
            this.btnCopyBckpToSaves.TabIndex = 34;
            this.btnCopyBckpToSaves.Text = "<<";
            this.btnCopyBckpToSaves.UseVisualStyleBackColor = true;
            this.btnCopyBckpToSaves.Click += new System.EventHandler(this.btnCopyBckpToSaves_Click);
            // 
            // btnCopySavesToBackup
            // 
            this.btnCopySavesToBackup.Location = new System.Drawing.Point(305, 229);
            this.btnCopySavesToBackup.Name = "btnCopySavesToBackup";
            this.btnCopySavesToBackup.Size = new System.Drawing.Size(41, 41);
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
            this.btnQuickBackup.Location = new System.Drawing.Point(12, 661);
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
            this.lbQuickBackups.Location = new System.Drawing.Point(12, 410);
            this.lbQuickBackups.Name = "lbQuickBackups";
            this.lbQuickBackups.ScrollAlwaysVisible = true;
            this.lbQuickBackups.Size = new System.Drawing.Size(286, 199);
            this.lbQuickBackups.TabIndex = 50;
            this.lbQuickBackups.SelectedIndexChanged += new System.EventHandler(this.lbQuickBackups_SelectedIndexChanged);
            // 
            // tbQbackupsLocPath
            // 
            this.tbQbackupsLocPath.Location = new System.Drawing.Point(12, 625);
            this.tbQbackupsLocPath.Name = "tbQbackupsLocPath";
            this.tbQbackupsLocPath.Size = new System.Drawing.Size(233, 20);
            this.tbQbackupsLocPath.TabIndex = 51;
            // 
            // rTbDisplayWFdata
            // 
            this.rTbDisplayWFdata.Cursor = System.Windows.Forms.Cursors.Help;
            this.rTbDisplayWFdata.Location = new System.Drawing.Point(363, 409);
            this.rTbDisplayWFdata.Name = "rTbDisplayWFdata";
            this.rTbDisplayWFdata.Size = new System.Drawing.Size(282, 176);
            this.rTbDisplayWFdata.TabIndex = 52;
            this.rTbDisplayWFdata.Text = "";
            // 
            // btnQuickBackupImport
            // 
            this.btnQuickBackupImport.Location = new System.Drawing.Point(214, 661);
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
            this.lbBranchContents.Location = new System.Drawing.Point(672, 114);
            this.lbBranchContents.Name = "lbBranchContents";
            this.lbBranchContents.ScrollAlwaysVisible = true;
            this.lbBranchContents.Size = new System.Drawing.Size(293, 225);
            this.lbBranchContents.TabIndex = 54;
            this.lbBranchContents.SelectedIndexChanged += new System.EventHandler(this.lbBranchContents_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 40);
            this.button1.TabIndex = 55;
            this.button1.Text = "Create Branch";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 347);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "CopyToBranch";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 376);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(96, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "CutToBranch";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(773, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 40);
            this.button4.TabIndex = 59;
            this.button4.Text = "Cut to saves";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(672, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 40);
            this.button5.TabIndex = 58;
            this.button5.Text = "Copy To Saves";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(202, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(96, 22);
            this.button7.TabIndex = 61;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click_1);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(549, 348);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 22);
            this.button8.TabIndex = 62;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(870, 345);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 22);
            this.button9.TabIndex = 63;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSelectQbackupFolder
            // 
            this.btnSelectQbackupFolder.Location = new System.Drawing.Point(251, 625);
            this.btnSelectQbackupFolder.Name = "btnSelectQbackupFolder";
            this.btnSelectQbackupFolder.Size = new System.Drawing.Size(47, 20);
            this.btnSelectQbackupFolder.TabIndex = 64;
            this.btnSelectQbackupFolder.Text = "Open";
            this.btnSelectQbackupFolder.UseVisualStyleBackColor = true;
            this.btnSelectQbackupFolder.Click += new System.EventHandler(this.btnSelectQbackupFolder_Click);
            // 
            // btnEditMark
            // 
            this.btnEditMark.Location = new System.Drawing.Point(448, 12);
            this.btnEditMark.Name = "btnEditMark";
            this.btnEditMark.Size = new System.Drawing.Size(95, 40);
            this.btnEditMark.TabIndex = 39;
            this.btnEditMark.Text = "WF editor";
            this.btnEditMark.UseVisualStyleBackColor = true;
            this.btnEditMark.Click += new System.EventHandler(this.btnEditMark_Click);
            // 
            // btnSelectSavesFold
            // 
            this.btnSelectSavesFold.Location = new System.Drawing.Point(251, 67);
            this.btnSelectSavesFold.Name = "btnSelectSavesFold";
            this.btnSelectSavesFold.Size = new System.Drawing.Size(47, 20);
            this.btnSelectSavesFold.TabIndex = 30;
            this.btnSelectSavesFold.Text = "Open";
            this.btnSelectSavesFold.UseVisualStyleBackColor = true;
            this.btnSelectSavesFold.Click += new System.EventHandler(this.btnSelectSavesFold_Click);
            // 
            // tbBranch
            // 
            this.tbBranch.Location = new System.Drawing.Point(672, 88);
            this.tbBranch.Name = "tbBranch";
            this.tbBranch.ReadOnly = true;
            this.tbBranch.Size = new System.Drawing.Size(293, 20);
            this.tbBranch.TabIndex = 65;
            // 
            // tbLocalWorldPath
            // 
            this.tbLocalWorldPath.Location = new System.Drawing.Point(12, 93);
            this.tbLocalWorldPath.Name = "tbLocalWorldPath";
            this.tbLocalWorldPath.Size = new System.Drawing.Size(134, 20);
            this.tbLocalWorldPath.TabIndex = 66;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(152, 93);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 20);
            this.button10.TabIndex = 68;
            this.button10.Text = "Select";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(205, 93);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(93, 20);
            this.button11.TabIndex = 69;
            this.button11.Text = "Cut To Saves";
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
            this.button13.Location = new System.Drawing.Point(549, 12);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(95, 40);
            this.button13.TabIndex = 71;
            this.button13.Text = "Rename";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(874, 12);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(95, 40);
            this.button14.TabIndex = 72;
            this.button14.Text = "Rename";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(113, 661);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(95, 40);
            this.button6.TabIndex = 73;
            this.button6.Text = "DeleteQuick";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(114, 347);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(85, 23);
            this.button15.TabIndex = 74;
            this.button15.Text = "EditNBT";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(460, 348);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(83, 23);
            this.button16.TabIndex = 75;
            this.button16.Text = "EditNBT";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(785, 345);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(83, 23);
            this.button17.TabIndex = 76;
            this.button17.Text = "EditNBT";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // MCworldMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 723);
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
    }
}

