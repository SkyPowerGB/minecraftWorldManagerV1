namespace minecraftWorldManager
{
    partial class EditWorldNBTform
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbWorldName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chckBxCmdAllowed = new System.Windows.Forms.CheckBox();
            this.cbGameMode = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.chckBxDifficultyLock = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDifficulty = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "World name:";
            // 
            // tbWorldName
            // 
            this.tbWorldName.Location = new System.Drawing.Point(91, 54);
            this.tbWorldName.Name = "tbWorldName";
            this.tbWorldName.Size = new System.Drawing.Size(222, 20);
            this.tbWorldName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Commands allowed:";
            // 
            // chckBxCmdAllowed
            // 
            this.chckBxCmdAllowed.AutoSize = true;
            this.chckBxCmdAllowed.Location = new System.Drawing.Point(139, 95);
            this.chckBxCmdAllowed.Name = "chckBxCmdAllowed";
            this.chckBxCmdAllowed.Size = new System.Drawing.Size(15, 14);
            this.chckBxCmdAllowed.TabIndex = 4;
            this.chckBxCmdAllowed.UseVisualStyleBackColor = true;
            // 
            // cbGameMode
            // 
            this.cbGameMode.FormattingEnabled = true;
            this.cbGameMode.Location = new System.Drawing.Point(132, 127);
            this.cbGameMode.Name = "cbGameMode";
            this.cbGameMode.Size = new System.Drawing.Size(89, 21);
            this.cbGameMode.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "GameMode:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(212, 256);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(91, 256);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 43);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Difficulty  locked:";
            // 
            // chckBxDifficultyLock
            // 
            this.chckBxDifficultyLock.AutoSize = true;
            this.chckBxDifficultyLock.Location = new System.Drawing.Point(141, 169);
            this.chckBxDifficultyLock.Name = "chckBxDifficultyLock";
            this.chckBxDifficultyLock.Size = new System.Drawing.Size(15, 14);
            this.chckBxDifficultyLock.TabIndex = 13;
            this.chckBxDifficultyLock.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 291);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(14, 208);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(50, 13);
            this.label14.TabIndex = 22;
            this.label14.Text = "Difficulty:";
            // 
            // cbDifficulty
            // 
            this.cbDifficulty.FormattingEnabled = true;
            this.cbDifficulty.Items.AddRange(new object[] {
            "Peacefull",
            "Easy",
            "Normal",
            "Hard"});
            this.cbDifficulty.Location = new System.Drawing.Point(132, 200);
            this.cbDifficulty.Name = "cbDifficulty";
            this.cbDifficulty.Size = new System.Drawing.Size(89, 21);
            this.cbDifficulty.TabIndex = 21;
            // 
            // EditWorldNBTform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 311);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbDifficulty);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chckBxDifficultyLock);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbGameMode);
            this.Controls.Add(this.chckBxCmdAllowed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbWorldName);
            this.Controls.Add(this.label1);
            this.Name = "EditWorldNBTform";
            this.Text = "Edit NBT ";
            this.Load += new System.EventHandler(this.EditWorldNBTform_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbWorldName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chckBxCmdAllowed;
        private System.Windows.Forms.ComboBox cbGameMode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chckBxDifficultyLock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbDifficulty;
    }
}