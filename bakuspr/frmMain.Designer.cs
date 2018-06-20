namespace bakuspr
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ofdPalette = new System.Windows.Forms.OpenFileDialog();
            this.ofdSprite = new System.Windows.Forms.OpenFileDialog();
            this.bgLoadSprite = new System.ComponentModel.BackgroundWorker();
            this.bgLoadPalette = new System.ComponentModel.BackgroundWorker();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.grpHexInfomation = new System.Windows.Forms.GroupBox();
            this.lblSpriteTotalDataBytes = new System.Windows.Forms.Label();
            this.lblSpriteWidthByte = new System.Windows.Forms.Label();
            this.lblSpriteByteLength = new System.Windows.Forms.Label();
            this.lblSpriteHeightByte = new System.Windows.Forms.Label();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.lblSpriteWidth = new System.Windows.Forms.Label();
            this.lblSpriteHeight = new System.Windows.Forms.Label();
            this.lblSpriteNumber = new System.Windows.Forms.Label();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnOpenSprite = new System.Windows.Forms.Button();
            this.grpPalette = new System.Windows.Forms.GroupBox();
            this.lblCustomPaletteFilename = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.rbCustom = new System.Windows.Forms.RadioButton();
            this.rbWin95Default = new System.Windows.Forms.RadioButton();
            this.tbViewer = new ThumbnailViewer.ThumbnailViewerControl();
            this.transparentPanel = new System.Windows.Forms.Panel();
            this.sfdSprite = new System.Windows.Forms.SaveFileDialog();
            this.fbdSprites = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.grpHexInfomation.SuspendLayout();
            this.grpInformation.SuspendLayout();
            this.grpPalette.SuspendLayout();
            this.tbViewer.SuspendLayout();
            this.SuspendLayout();
            // 
            // ofdPalette
            // 
            this.ofdPalette.Filter = "Baku Baku Palette (*.bin)|*.bin|*.*|*.*";
            this.ofdPalette.Title = "Open a Custom Palette File";
            // 
            // ofdSprite
            // 
            this.ofdSprite.Filter = "Baku Baku Sprite File (*.spr)|*.spr|*.*|*.*";
            this.ofdSprite.Title = "Open a Sprite File";
            // 
            // bgLoadSprite
            // 
            this.bgLoadSprite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoadSprite_DoWork);
            this.bgLoadSprite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoadSprite_RunWorkerCompleted);
            // 
            // bgLoadPalette
            // 
            this.bgLoadPalette.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoadPalette_DoWork);
            this.bgLoadPalette.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoadPalette_RunWorkerCompleted);
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.grpHexInfomation);
            this.splitContainer.Panel1.Controls.Add(this.grpInformation);
            this.splitContainer.Panel1.Controls.Add(this.btnAbout);
            this.splitContainer.Panel1.Controls.Add(this.btnSave);
            this.splitContainer.Panel1.Controls.Add(this.btnOpenSprite);
            this.splitContainer.Panel1.Controls.Add(this.grpPalette);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.tbViewer);
            this.splitContainer.Size = new System.Drawing.Size(782, 523);
            this.splitContainer.SplitterDistance = 190;
            this.splitContainer.TabIndex = 16;
            // 
            // grpHexInfomation
            // 
            this.grpHexInfomation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpHexInfomation.Controls.Add(this.lblSpriteTotalDataBytes);
            this.grpHexInfomation.Controls.Add(this.lblSpriteWidthByte);
            this.grpHexInfomation.Controls.Add(this.lblSpriteByteLength);
            this.grpHexInfomation.Controls.Add(this.lblSpriteHeightByte);
            this.grpHexInfomation.Location = new System.Drawing.Point(12, 392);
            this.grpHexInfomation.Name = "grpHexInfomation";
            this.grpHexInfomation.Size = new System.Drawing.Size(223, 119);
            this.grpHexInfomation.TabIndex = 33;
            this.grpHexInfomation.TabStop = false;
            this.grpHexInfomation.Text = "Hex Information";
            // 
            // lblSpriteTotalDataBytes
            // 
            this.lblSpriteTotalDataBytes.AutoSize = true;
            this.lblSpriteTotalDataBytes.Location = new System.Drawing.Point(11, 85);
            this.lblSpriteTotalDataBytes.Name = "lblSpriteTotalDataBytes";
            this.lblSpriteTotalDataBytes.Size = new System.Drawing.Size(117, 17);
            this.lblSpriteTotalDataBytes.TabIndex = 0;
            this.lblSpriteTotalDataBytes.Text = "Total Data Bytes:";
            // 
            // lblSpriteWidthByte
            // 
            this.lblSpriteWidthByte.AutoSize = true;
            this.lblSpriteWidthByte.Location = new System.Drawing.Point(11, 24);
            this.lblSpriteWidthByte.Name = "lblSpriteWidthByte";
            this.lblSpriteWidthByte.Size = new System.Drawing.Size(80, 17);
            this.lblSpriteWidthByte.TabIndex = 12;
            this.lblSpriteWidthByte.Text = "Width Byte:";
            // 
            // lblSpriteByteLength
            // 
            this.lblSpriteByteLength.AutoSize = true;
            this.lblSpriteByteLength.Location = new System.Drawing.Point(11, 64);
            this.lblSpriteByteLength.Name = "lblSpriteByteLength";
            this.lblSpriteByteLength.Size = new System.Drawing.Size(88, 17);
            this.lblSpriteByteLength.TabIndex = 14;
            this.lblSpriteByteLength.Text = "Byte Length:";
            // 
            // lblSpriteHeightByte
            // 
            this.lblSpriteHeightByte.AutoSize = true;
            this.lblSpriteHeightByte.Location = new System.Drawing.Point(11, 44);
            this.lblSpriteHeightByte.Name = "lblSpriteHeightByte";
            this.lblSpriteHeightByte.Size = new System.Drawing.Size(85, 17);
            this.lblSpriteHeightByte.TabIndex = 13;
            this.lblSpriteHeightByte.Text = "Height Byte:";
            // 
            // grpInformation
            // 
            this.grpInformation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.grpInformation.Controls.Add(this.lblSpriteWidth);
            this.grpInformation.Controls.Add(this.lblSpriteHeight);
            this.grpInformation.Controls.Add(this.lblSpriteNumber);
            this.grpInformation.Location = new System.Drawing.Point(12, 298);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(223, 88);
            this.grpInformation.TabIndex = 32;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "General Information";
            // 
            // lblSpriteWidth
            // 
            this.lblSpriteWidth.AutoSize = true;
            this.lblSpriteWidth.Location = new System.Drawing.Point(11, 41);
            this.lblSpriteWidth.Name = "lblSpriteWidth";
            this.lblSpriteWidth.Size = new System.Drawing.Size(48, 17);
            this.lblSpriteWidth.TabIndex = 10;
            this.lblSpriteWidth.Text = "Width:";
            // 
            // lblSpriteHeight
            // 
            this.lblSpriteHeight.AutoSize = true;
            this.lblSpriteHeight.Location = new System.Drawing.Point(11, 62);
            this.lblSpriteHeight.Name = "lblSpriteHeight";
            this.lblSpriteHeight.Size = new System.Drawing.Size(53, 17);
            this.lblSpriteHeight.TabIndex = 11;
            this.lblSpriteHeight.Text = "Height:";
            // 
            // lblSpriteNumber
            // 
            this.lblSpriteNumber.AutoSize = true;
            this.lblSpriteNumber.Location = new System.Drawing.Point(13, 19);
            this.lblSpriteNumber.Name = "lblSpriteNumber";
            this.lblSpriteNumber.Size = new System.Drawing.Size(20, 17);
            this.lblSpriteNumber.TabIndex = 9;
            this.lblSpriteNumber.Text = "# ";
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 246);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(223, 43);
            this.btnAbout.TabIndex = 31;
            this.btnAbout.Text = "&About";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(12, 197);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(223, 43);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "&Save All";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnOpenSprite
            // 
            this.btnOpenSprite.Enabled = false;
            this.btnOpenSprite.Location = new System.Drawing.Point(12, 148);
            this.btnOpenSprite.Name = "btnOpenSprite";
            this.btnOpenSprite.Size = new System.Drawing.Size(223, 43);
            this.btnOpenSprite.TabIndex = 29;
            this.btnOpenSprite.Text = "&Open Sprite";
            this.btnOpenSprite.UseVisualStyleBackColor = true;
            this.btnOpenSprite.Click += new System.EventHandler(this.btnOpenSprite_Click);
            // 
            // grpPalette
            // 
            this.grpPalette.Controls.Add(this.lblCustomPaletteFilename);
            this.grpPalette.Controls.Add(this.btnImport);
            this.grpPalette.Controls.Add(this.rbCustom);
            this.grpPalette.Controls.Add(this.rbWin95Default);
            this.grpPalette.Location = new System.Drawing.Point(12, 12);
            this.grpPalette.Name = "grpPalette";
            this.grpPalette.Size = new System.Drawing.Size(223, 130);
            this.grpPalette.TabIndex = 28;
            this.grpPalette.TabStop = false;
            this.grpPalette.Text = "Palette";
            // 
            // lblCustomPaletteFilename
            // 
            this.lblCustomPaletteFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomPaletteFilename.Location = new System.Drawing.Point(36, 89);
            this.lblCustomPaletteFilename.Name = "lblCustomPaletteFilename";
            this.lblCustomPaletteFilename.Size = new System.Drawing.Size(177, 17);
            this.lblCustomPaletteFilename.TabIndex = 4;
            this.lblCustomPaletteFilename.Text = "<           filename           >";
            this.lblCustomPaletteFilename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnImport
            // 
            this.btnImport.Enabled = false;
            this.btnImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImport.Location = new System.Drawing.Point(102, 54);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(115, 28);
            this.btnImport.TabIndex = 3;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // rbCustom
            // 
            this.rbCustom.AutoSize = true;
            this.rbCustom.Location = new System.Drawing.Point(20, 58);
            this.rbCustom.Name = "rbCustom";
            this.rbCustom.Size = new System.Drawing.Size(76, 21);
            this.rbCustom.TabIndex = 2;
            this.rbCustom.Text = "Custom";
            this.rbCustom.UseVisualStyleBackColor = true;
            this.rbCustom.CheckedChanged += new System.EventHandler(this.rbCustom_CheckedChanged);
            // 
            // rbWin95Default
            // 
            this.rbWin95Default.AutoSize = true;
            this.rbWin95Default.Checked = true;
            this.rbWin95Default.Location = new System.Drawing.Point(20, 27);
            this.rbWin95Default.Name = "rbWin95Default";
            this.rbWin95Default.Size = new System.Drawing.Size(154, 21);
            this.rbWin95Default.TabIndex = 1;
            this.rbWin95Default.TabStop = true;
            this.rbWin95Default.Text = "Windows 95 Default";
            this.rbWin95Default.UseVisualStyleBackColor = true;
            this.rbWin95Default.CheckedChanged += new System.EventHandler(this.rbWin95Default_CheckedChanged);
            // 
            // tbViewer
            // 
            this.tbViewer.AutoScroll = true;
            this.tbViewer.AutoSize = true;
            this.tbViewer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tbViewer.Controls.Add(this.transparentPanel);
            this.tbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbViewer.Location = new System.Drawing.Point(0, 0);
            this.tbViewer.Name = "tbViewer";
            this.tbViewer.Size = new System.Drawing.Size(588, 523);
            this.tbViewer.TabIndex = 0;
            // 
            // transparentPanel
            // 
            this.transparentPanel.AutoSize = true;
            this.transparentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.transparentPanel.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel.ForeColor = System.Drawing.Color.Transparent;
            this.transparentPanel.Location = new System.Drawing.Point(3, 3);
            this.transparentPanel.Name = "transparentPanel";
            this.transparentPanel.Size = new System.Drawing.Size(0, 0);
            this.transparentPanel.TabIndex = 1;
            // 
            // sfdSprite
            // 
            this.sfdSprite.Filter = "Bitmap|*.bmp";
            // 
            // fbdSprites
            // 
            this.fbdSprites.Description = "Browse for a folder to save multiple sprites in.";
            this.fbdSprites.RootFolder = System.Environment.SpecialFolder.DesktopDirectory;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 523);
            this.Controls.Add(this.splitContainer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(800, 570);
            this.Name = "frmMain";
            this.Text = "bakuspr by tkrn";
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.grpHexInfomation.ResumeLayout(false);
            this.grpHexInfomation.PerformLayout();
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpPalette.ResumeLayout(false);
            this.grpPalette.PerformLayout();
            this.tbViewer.ResumeLayout(false);
            this.tbViewer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPalette;
        private System.Windows.Forms.OpenFileDialog ofdSprite;
        private System.ComponentModel.BackgroundWorker bgLoadSprite;
        private System.ComponentModel.BackgroundWorker bgLoadPalette;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.GroupBox grpHexInfomation;
        private System.Windows.Forms.Label lblSpriteTotalDataBytes;
        private System.Windows.Forms.Label lblSpriteWidthByte;
        private System.Windows.Forms.Label lblSpriteByteLength;
        private System.Windows.Forms.Label lblSpriteHeightByte;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblSpriteWidth;
        private System.Windows.Forms.Label lblSpriteHeight;
        private System.Windows.Forms.Label lblSpriteNumber;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnOpenSprite;
        private System.Windows.Forms.GroupBox grpPalette;
        private System.Windows.Forms.Label lblCustomPaletteFilename;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.RadioButton rbCustom;
        private System.Windows.Forms.RadioButton rbWin95Default;
        private ThumbnailViewer.ThumbnailViewerControl tbViewer;
        private System.Windows.Forms.Panel transparentPanel;
        private System.Windows.Forms.SaveFileDialog sfdSprite;
        private System.Windows.Forms.FolderBrowserDialog fbdSprites;
    }
}

