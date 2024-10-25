namespace minecraftWorldManager
{
    partial class WFeditor
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
            this.tbWorldVersion = new System.Windows.Forms.TextBox();
            this.cbMcVersion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMark = new System.Windows.Forms.Button();
            this.tbDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbWorldVersion
            // 
            this.tbWorldVersion.Location = new System.Drawing.Point(28, 47);
            this.tbWorldVersion.Name = "tbWorldVersion";
            this.tbWorldVersion.Size = new System.Drawing.Size(207, 20);
            this.tbWorldVersion.TabIndex = 0;
            // 
            // cbMcVersion
            // 
            this.cbMcVersion.FormattingEnabled = true;
            this.cbMcVersion.Items.AddRange(new object[] {
            "1.1",
            "1.3",
            "1.2",
            "1.4",
            "1.5",
            "1.6",
            "1.7",
            "1.8",
            "1.9",
            "1.10",
            "1.11",
            "1.12",
            "1.13",
            "1.14",
            "1.15",
            "1.16",
            "1.17",
            "1.18",
            "1.19",
            "1.20",
            "1.21"});
            this.cbMcVersion.Location = new System.Drawing.Point(28, 126);
            this.cbMcVersion.Name = "cbMcVersion";
            this.cbMcVersion.Size = new System.Drawing.Size(207, 21);
            this.cbMcVersion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "World Version";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mc Version";
            // 
            // btnMark
            // 
            this.btnMark.Location = new System.Drawing.Point(12, 368);
            this.btnMark.Name = "btnMark";
            this.btnMark.Size = new System.Drawing.Size(253, 45);
            this.btnMark.TabIndex = 4;
            this.btnMark.Text = "Mark ";
            this.btnMark.UseVisualStyleBackColor = true;
            this.btnMark.Click += new System.EventHandler(this.btnMark_Click);
            // 
            // tbDescription
            // 
            this.tbDescription.Location = new System.Drawing.Point(28, 183);
            this.tbDescription.Multiline = true;
            this.tbDescription.Name = "tbDescription";
            this.tbDescription.Size = new System.Drawing.Size(207, 167);
            this.tbDescription.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description";
            // 
            // WFeditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 438);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbDescription);
            this.Controls.Add(this.btnMark);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbMcVersion);
            this.Controls.Add(this.tbWorldVersion);
            this.Name = "WFeditor";
            this.Text = "WF editor";
            this.Load += new System.EventHandler(this.WFeditor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbWorldVersion;
        private System.Windows.Forms.ComboBox cbMcVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMark;
        private System.Windows.Forms.TextBox tbDescription;
        private System.Windows.Forms.Label label3;
    }
}