namespace movingCatMagnusJanda
{
    partial class frmMovingCat
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
            this.mnuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuStrip1
            // 
            this.mnuStrip1.BackColor = System.Drawing.Color.Orange;
            this.mnuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuStrip1.Location = new System.Drawing.Point(0, 0);
            this.mnuStrip1.Name = "mnuStrip1";
            this.mnuStrip1.Size = new System.Drawing.Size(481, 24);
            this.mnuStrip1.TabIndex = 0;
            this.mnuStrip1.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(107, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 201);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(152, 22);
            this.mniCat1.Text = "Cat 1";
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(152, 22);
            this.mniCat2.Text = "Cat 2";
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(481, 415);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mnuStrip1);
            this.MainMenuStrip = this.mnuStrip1;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat";
            this.mnuStrip1.ResumeLayout(false);
            this.mnuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
    }
}

