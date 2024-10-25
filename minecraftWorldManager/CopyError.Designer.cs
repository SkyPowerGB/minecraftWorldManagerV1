namespace minecraftWorldManager
{
    partial class FolderExistsErrorForm
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
            this.rtbWorld1DatF = new System.Windows.Forms.RichTextBox();
            this.rtbWorld2DatF = new System.Windows.Forms.RichTextBox();
            this.lblWorld1 = new System.Windows.Forms.Label();
            this.lblWorld2 = new System.Windows.Forms.Label();
            this.tbNewWorldName = new System.Windows.Forms.TextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnOverWrite = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbWorld1DatF
            // 
            this.rtbWorld1DatF.Location = new System.Drawing.Point(12, 110);
            this.rtbWorld1DatF.Name = "rtbWorld1DatF";
            this.rtbWorld1DatF.Size = new System.Drawing.Size(128, 256);
            this.rtbWorld1DatF.TabIndex = 0;
            this.rtbWorld1DatF.Text = "";
            // 
            // rtbWorld2DatF
            // 
            this.rtbWorld2DatF.Location = new System.Drawing.Point(258, 110);
            this.rtbWorld2DatF.Name = "rtbWorld2DatF";
            this.rtbWorld2DatF.Size = new System.Drawing.Size(129, 256);
            this.rtbWorld2DatF.TabIndex = 1;
            this.rtbWorld2DatF.Text = "";
            // 
            // lblWorld1
            // 
            this.lblWorld1.AutoSize = true;
            this.lblWorld1.Location = new System.Drawing.Point(38, 94);
            this.lblWorld1.Name = "lblWorld1";
            this.lblWorld1.Size = new System.Drawing.Size(47, 13);
            this.lblWorld1.TabIndex = 2;
            this.lblWorld1.Text = "World 1:";
            // 
            // lblWorld2
            // 
            this.lblWorld2.AutoSize = true;
            this.lblWorld2.Location = new System.Drawing.Point(300, 94);
            this.lblWorld2.Name = "lblWorld2";
            this.lblWorld2.Size = new System.Drawing.Size(47, 13);
            this.lblWorld2.TabIndex = 3;
            this.lblWorld2.Text = "World 2:";
            // 
            // tbNewWorldName
            // 
            this.tbNewWorldName.Location = new System.Drawing.Point(12, 13);
            this.tbNewWorldName.Name = "tbNewWorldName";
            this.tbNewWorldName.Size = new System.Drawing.Size(253, 20);
            this.tbNewWorldName.TabIndex = 6;
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(271, 13);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(116, 23);
            this.btnRename.TabIndex = 7;
            this.btnRename.Text = "Rename";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnOverWrite
            // 
            this.btnOverWrite.Location = new System.Drawing.Point(147, 203);
            this.btnOverWrite.Name = "btnOverWrite";
            this.btnOverWrite.Size = new System.Drawing.Size(105, 44);
            this.btnOverWrite.TabIndex = 9;
            this.btnOverWrite.Text = "Over write";
            this.btnOverWrite.UseVisualStyleBackColor = true;
            this.btnOverWrite.Click += new System.EventHandler(this.btnOverWrite_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(146, 253);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(106, 44);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FolderExistsErrorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 392);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOverWrite);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.tbNewWorldName);
            this.Controls.Add(this.lblWorld2);
            this.Controls.Add(this.lblWorld1);
            this.Controls.Add(this.rtbWorld2DatF);
            this.Controls.Add(this.rtbWorld1DatF);
            this.Name = "FolderExistsErrorForm";
            this.Text = "Folder already exists";
            this.Load += new System.EventHandler(this.CopyError_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbWorld1DatF;
        private System.Windows.Forms.RichTextBox rtbWorld2DatF;
        private System.Windows.Forms.Label lblWorld1;
        private System.Windows.Forms.Label lblWorld2;
        private System.Windows.Forms.TextBox tbNewWorldName;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.Button btnOverWrite;
        private System.Windows.Forms.Button btnCancel;
    }
}