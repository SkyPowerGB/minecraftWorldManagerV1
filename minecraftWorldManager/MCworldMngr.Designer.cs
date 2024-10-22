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
            this.btnLoadQuickBackup = new System.Windows.Forms.Button();
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
            this.btnLoadSaves.Text = "Open Saves";
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
            this.tbMcSavesLocPath.Location = new System.Drawing.Point(12, 88);
            this.tbMcSavesLocPath.Name = "tbMcSavesLocPath";
            this.tbMcSavesLocPath.Size = new System.Drawing.Size(233, 20);
            this.tbMcSavesLocPath.TabIndex = 29;
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
            // 
            // btnCutBckpToSaves
            // 
            this.btnCutBckpToSaves.Location = new System.Drawing.Point(305, 182);
            this.btnCutBckpToSaves.Name = "btnCutBckpToSaves";
            this.btnCutBckpToSaves.Size = new System.Drawing.Size(41, 41);
            this.btnCutBckpToSaves.TabIndex = 33;
            this.btnCutBckpToSaves.Text = "<";
            this.btnCutBckpToSaves.UseVisualStyleBackColor = true;
            // 
            // btnCopyBckpToSaves
            // 
            this.btnCopyBckpToSaves.Location = new System.Drawing.Point(305, 276);
            this.btnCopyBckpToSaves.Name = "btnCopyBckpToSaves";
            this.btnCopyBckpToSaves.Size = new System.Drawing.Size(41, 41);
            this.btnCopyBckpToSaves.TabIndex = 34;
            this.btnCopyBckpToSaves.Text = "<<";
            this.btnCopyBckpToSaves.UseVisualStyleBackColor = true;
            // 
            // btnCopySavesToBackup
            // 
            this.btnCopySavesToBackup.Location = new System.Drawing.Point(305, 229);
            this.btnCopySavesToBackup.Name = "btnCopySavesToBackup";
            this.btnCopySavesToBackup.Size = new System.Drawing.Size(41, 41);
            this.btnCopySavesToBackup.TabIndex = 35;
            this.btnCopySavesToBackup.Text = ">>";
            this.btnCopySavesToBackup.UseVisualStyleBackColor = true;
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
            this.btnQuickBackup.Location = new System.Drawing.Point(12, 720);
            this.btnQuickBackup.Name = "btnQuickBackup";
            this.btnQuickBackup.Size = new System.Drawing.Size(95, 40);
            this.btnQuickBackup.TabIndex = 48;
            this.btnQuickBackup.Text = "Quick backup";
            this.btnQuickBackup.UseVisualStyleBackColor = true;
            // 
            // btnLoadQuickBackup
            // 
            this.btnLoadQuickBackup.Location = new System.Drawing.Point(113, 720);
            this.btnLoadQuickBackup.Name = "btnLoadQuickBackup";
            this.btnLoadQuickBackup.Size = new System.Drawing.Size(95, 40);
            this.btnLoadQuickBackup.TabIndex = 49;
            this.btnLoadQuickBackup.Text = "Load Quick";
            this.btnLoadQuickBackup.UseVisualStyleBackColor = true;
            // 
            // lbQuickBackups
            // 
            this.lbQuickBackups.FormattingEnabled = true;
            this.lbQuickBackups.Location = new System.Drawing.Point(12, 410);
            this.lbQuickBackups.Name = "lbQuickBackups";
            this.lbQuickBackups.ScrollAlwaysVisible = true;
            this.lbQuickBackups.Size = new System.Drawing.Size(286, 199);
            this.lbQuickBackups.TabIndex = 50;
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
            this.rTbDisplayWFdata.ReadOnly = true;
            this.rTbDisplayWFdata.Size = new System.Drawing.Size(432, 262);
            this.rTbDisplayWFdata.TabIndex = 52;
            this.rTbDisplayWFdata.Text = "";
            // 
            // btnQuickBackupImport
            // 
            this.btnQuickBackupImport.Location = new System.Drawing.Point(214, 720);
            this.btnQuickBackupImport.Name = "btnQuickBackupImport";
            this.btnQuickBackupImport.Size = new System.Drawing.Size(95, 40);
            this.btnQuickBackupImport.TabIndex = 53;
            this.btnQuickBackupImport.Text = "Import Quick";
            this.btnQuickBackupImport.UseVisualStyleBackColor = true;
            // 
            // lbBranchContents
            // 
            this.lbBranchContents.FormattingEnabled = true;
            this.lbBranchContents.Location = new System.Drawing.Point(672, 115);
            this.lbBranchContents.Name = "lbBranchContents";
            this.lbBranchContents.ScrollAlwaysVisible = true;
            this.lbBranchContents.Size = new System.Drawing.Size(293, 225);
            this.lbBranchContents.TabIndex = 54;
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
            this.button2.Size = new System.Drawing.Size(95, 23);
            this.button2.TabIndex = 56;
            this.button2.Text = "CopyToBranch";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(113, 347);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 23);
            this.button3.TabIndex = 57;
            this.button3.Text = "CutToBranch";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(773, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 40);
            this.button4.TabIndex = 59;
            this.button4.Text = "Cut to saves";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(672, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(95, 40);
            this.button5.TabIndex = 58;
            this.button5.Text = "Copy To Saves";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(214, 347);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(84, 22);
            this.button7.TabIndex = 61;
            this.button7.Text = "Delete";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(550, 347);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(95, 22);
            this.button8.TabIndex = 62;
            this.button8.Text = "Delete";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(870, 346);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(95, 22);
            this.button9.TabIndex = 63;
            this.button9.Text = "Delete";
            this.button9.UseVisualStyleBackColor = true;
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
            this.btnEditMark.Location = new System.Drawing.Point(452, 12);
            this.btnEditMark.Name = "btnEditMark";
            this.btnEditMark.Size = new System.Drawing.Size(95, 40);
            this.btnEditMark.TabIndex = 39;
            this.btnEditMark.Text = "WF editor";
            this.btnEditMark.UseVisualStyleBackColor = true;
            // 
            // btnSelectSavesFold
            // 
            this.btnSelectSavesFold.Location = new System.Drawing.Point(251, 88);
            this.btnSelectSavesFold.Name = "btnSelectSavesFold";
            this.btnSelectSavesFold.Size = new System.Drawing.Size(47, 20);
            this.btnSelectSavesFold.TabIndex = 30;
            this.btnSelectSavesFold.Text = "Open";
            this.btnSelectSavesFold.UseVisualStyleBackColor = true;
            // 
            // MCworldMngr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 772);
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
            this.Controls.Add(this.btnLoadQuickBackup);
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
        private System.Windows.Forms.Button btnLoadQuickBackup;
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
    }
}

