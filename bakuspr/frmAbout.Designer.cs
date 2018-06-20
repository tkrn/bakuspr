namespace bakuspr
{
    partial class frmAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAbout));
            this.picAbout = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblAbout = new System.Windows.Forms.Label();
            this.lblLine = new System.Windows.Forms.Label();
            this.lblVersion = new System.Windows.Forms.Label();
            this.lblBuiltOn = new System.Windows.Forms.Label();
            this.richTextbox = new System.Windows.Forms.RichTextBox();
            this.lblCopyright = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).BeginInit();
            this.SuspendLayout();
            // 
            // picAbout
            // 
            this.picAbout.Image = global::bakuspr.Properties.Resources.bakubakulogo;
            this.picAbout.Location = new System.Drawing.Point(13, 13);
            this.picAbout.Name = "picAbout";
            this.picAbout.Size = new System.Drawing.Size(212, 144);
            this.picAbout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAbout.TabIndex = 0;
            this.picAbout.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(231, 42);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(254, 34);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "A utility to extract sprites from the Sega\r\ntitle Baku Baku Animal for PC (1996)." +
    " ";
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbout.Location = new System.Drawing.Point(231, 13);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(113, 17);
            this.lblAbout.TabIndex = 2;
            this.lblAbout.Text = "About bakuspr";
            // 
            // lblLine
            // 
            this.lblLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLine.Location = new System.Drawing.Point(229, 85);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(240, 2);
            this.lblLine.TabIndex = 3;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Location = new System.Drawing.Point(231, 96);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(80, 17);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "Version 1.0";
            // 
            // lblBuiltOn
            // 
            this.lblBuiltOn.AutoSize = true;
            this.lblBuiltOn.Location = new System.Drawing.Point(231, 118);
            this.lblBuiltOn.Name = "lblBuiltOn";
            this.lblBuiltOn.Size = new System.Drawing.Size(59, 17);
            this.lblBuiltOn.TabIndex = 5;
            this.lblBuiltOn.Text = "Built on ";
            // 
            // richTextbox
            // 
            this.richTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextbox.Location = new System.Drawing.Point(14, 163);
            this.richTextbox.Name = "richTextbox";
            this.richTextbox.Size = new System.Drawing.Size(491, 268);
            this.richTextbox.TabIndex = 6;
            this.richTextbox.Text = resources.GetString("richTextbox.Text");
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.Location = new System.Drawing.Point(231, 140);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(146, 17);
            this.lblCopyright.TabIndex = 7;
            this.lblCopyright.Text = "Copyright © 2018 tkrn";
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 446);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.richTextbox);
            this.Controls.Add(this.lblBuiltOn);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.picAbout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAbout";
            this.Text = "About bakuspr";
            this.Load += new System.EventHandler(this.frmAbout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAbout)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAbout;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblAbout;
        private System.Windows.Forms.Label lblLine;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Label lblBuiltOn;
        private System.Windows.Forms.RichTextBox richTextbox;
        private System.Windows.Forms.Label lblCopyright;
    }
}