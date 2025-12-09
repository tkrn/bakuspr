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
      this.grpHexInfomation = new System.Windows.Forms.GroupBox();
      this.lblSpriteTotalDataBytes = new System.Windows.Forms.Label();
      this.lblSpriteWidthByte = new System.Windows.Forms.Label();
      this.lblSpriteByteLength = new System.Windows.Forms.Label();
      this.lblSpriteHeightByte = new System.Windows.Forms.Label();
      this.grpInformation = new System.Windows.Forms.GroupBox();
      this.lblSpriteWidth = new System.Windows.Forms.Label();
      this.lblSpriteHeight = new System.Windows.Forms.Label();
      this.lblSpriteNumber = new System.Windows.Forms.Label();
      this.sfdSprite = new System.Windows.Forms.SaveFileDialog();
      this.fbdSprites = new System.Windows.Forms.FolderBrowserDialog();
      this.menuMain = new System.Windows.Forms.MenuStrip();
      this.openSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.oldPaletteMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.newPaletteMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.horizontalContainer = new System.Windows.Forms.SplitContainer();
      this.verticalContainer = new System.Windows.Forms.SplitContainer();
      this.grpPalette = new System.Windows.Forms.GroupBox();
      this.panelPalette = new System.Windows.Forms.Panel();
      this.tbViewer = new ThumbnailViewer.ThumbnailViewerControl();
      this.grpHexInfomation.SuspendLayout();
      this.grpInformation.SuspendLayout();
      this.menuMain.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.horizontalContainer)).BeginInit();
      this.horizontalContainer.Panel1.SuspendLayout();
      this.horizontalContainer.Panel2.SuspendLayout();
      this.horizontalContainer.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.verticalContainer)).BeginInit();
      this.verticalContainer.Panel1.SuspendLayout();
      this.verticalContainer.Panel2.SuspendLayout();
      this.verticalContainer.SuspendLayout();
      this.grpPalette.SuspendLayout();
      this.SuspendLayout();
      // 
      // ofdPalette
      // 
      this.ofdPalette.Filter = "Baku Baku Palette (*.bin)|*.bin";
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
      // 
      // grpHexInfomation
      // 
      this.grpHexInfomation.Controls.Add(this.lblSpriteTotalDataBytes);
      this.grpHexInfomation.Controls.Add(this.lblSpriteWidthByte);
      this.grpHexInfomation.Controls.Add(this.lblSpriteByteLength);
      this.grpHexInfomation.Controls.Add(this.lblSpriteHeightByte);
      this.grpHexInfomation.Location = new System.Drawing.Point(11, 88);
      this.grpHexInfomation.Margin = new System.Windows.Forms.Padding(2);
      this.grpHexInfomation.Name = "grpHexInfomation";
      this.grpHexInfomation.Padding = new System.Windows.Forms.Padding(2);
      this.grpHexInfomation.Size = new System.Drawing.Size(167, 97);
      this.grpHexInfomation.TabIndex = 33;
      this.grpHexInfomation.TabStop = false;
      this.grpHexInfomation.Text = "Hex";
      // 
      // lblSpriteTotalDataBytes
      // 
      this.lblSpriteTotalDataBytes.AutoSize = true;
      this.lblSpriteTotalDataBytes.Location = new System.Drawing.Point(8, 69);
      this.lblSpriteTotalDataBytes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteTotalDataBytes.Name = "lblSpriteTotalDataBytes";
      this.lblSpriteTotalDataBytes.Size = new System.Drawing.Size(89, 13);
      this.lblSpriteTotalDataBytes.TabIndex = 0;
      this.lblSpriteTotalDataBytes.Text = "Total Data Bytes:";
      // 
      // lblSpriteWidthByte
      // 
      this.lblSpriteWidthByte.AutoSize = true;
      this.lblSpriteWidthByte.Location = new System.Drawing.Point(8, 20);
      this.lblSpriteWidthByte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteWidthByte.Name = "lblSpriteWidthByte";
      this.lblSpriteWidthByte.Size = new System.Drawing.Size(62, 13);
      this.lblSpriteWidthByte.TabIndex = 12;
      this.lblSpriteWidthByte.Text = "Width Byte:";
      // 
      // lblSpriteByteLength
      // 
      this.lblSpriteByteLength.AutoSize = true;
      this.lblSpriteByteLength.Location = new System.Drawing.Point(8, 52);
      this.lblSpriteByteLength.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteByteLength.Name = "lblSpriteByteLength";
      this.lblSpriteByteLength.Size = new System.Drawing.Size(67, 13);
      this.lblSpriteByteLength.TabIndex = 14;
      this.lblSpriteByteLength.Text = "Byte Length:";
      // 
      // lblSpriteHeightByte
      // 
      this.lblSpriteHeightByte.AutoSize = true;
      this.lblSpriteHeightByte.Location = new System.Drawing.Point(8, 36);
      this.lblSpriteHeightByte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteHeightByte.Name = "lblSpriteHeightByte";
      this.lblSpriteHeightByte.Size = new System.Drawing.Size(65, 13);
      this.lblSpriteHeightByte.TabIndex = 13;
      this.lblSpriteHeightByte.Text = "Height Byte:";
      // 
      // grpInformation
      // 
      this.grpInformation.Controls.Add(this.lblSpriteWidth);
      this.grpInformation.Controls.Add(this.lblSpriteHeight);
      this.grpInformation.Controls.Add(this.lblSpriteNumber);
      this.grpInformation.Location = new System.Drawing.Point(11, 12);
      this.grpInformation.Margin = new System.Windows.Forms.Padding(2);
      this.grpInformation.Name = "grpInformation";
      this.grpInformation.Padding = new System.Windows.Forms.Padding(2);
      this.grpInformation.Size = new System.Drawing.Size(167, 72);
      this.grpInformation.TabIndex = 32;
      this.grpInformation.TabStop = false;
      this.grpInformation.Text = "Image";
      // 
      // lblSpriteWidth
      // 
      this.lblSpriteWidth.AutoSize = true;
      this.lblSpriteWidth.Location = new System.Drawing.Point(8, 33);
      this.lblSpriteWidth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteWidth.Name = "lblSpriteWidth";
      this.lblSpriteWidth.Size = new System.Drawing.Size(38, 13);
      this.lblSpriteWidth.TabIndex = 10;
      this.lblSpriteWidth.Text = "Width:";
      // 
      // lblSpriteHeight
      // 
      this.lblSpriteHeight.AutoSize = true;
      this.lblSpriteHeight.Location = new System.Drawing.Point(8, 50);
      this.lblSpriteHeight.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteHeight.Name = "lblSpriteHeight";
      this.lblSpriteHeight.Size = new System.Drawing.Size(41, 13);
      this.lblSpriteHeight.TabIndex = 11;
      this.lblSpriteHeight.Text = "Height:";
      // 
      // lblSpriteNumber
      // 
      this.lblSpriteNumber.AutoSize = true;
      this.lblSpriteNumber.Location = new System.Drawing.Point(10, 15);
      this.lblSpriteNumber.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.lblSpriteNumber.Name = "lblSpriteNumber";
      this.lblSpriteNumber.Size = new System.Drawing.Size(17, 13);
      this.lblSpriteNumber.TabIndex = 9;
      this.lblSpriteNumber.Text = "# ";
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
      // menuMain
      // 
      this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSpriteToolStripMenuItem,
            this.selectPaletteToolStripMenuItem,
            this.saveSelectedToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuMain.Location = new System.Drawing.Point(0, 0);
      this.menuMain.Name = "menuMain";
      this.menuMain.Size = new System.Drawing.Size(719, 24);
      this.menuMain.TabIndex = 17;
      this.menuMain.Text = "menuStrip1";
      // 
      // openSpriteToolStripMenuItem
      // 
      this.openSpriteToolStripMenuItem.Name = "openSpriteToolStripMenuItem";
      this.openSpriteToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
      this.openSpriteToolStripMenuItem.Text = "Open Sprite";
      this.openSpriteToolStripMenuItem.Click += new System.EventHandler(this.openSpriteToolStripMenuItem_Click);
      // 
      // selectPaletteToolStripMenuItem
      // 
      this.selectPaletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newPaletteMethodToolStripMenuItem,
            this.oldPaletteMethodToolStripMenuItem});
      this.selectPaletteToolStripMenuItem.Name = "selectPaletteToolStripMenuItem";
      this.selectPaletteToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
      this.selectPaletteToolStripMenuItem.Text = "Select Palette";
      this.selectPaletteToolStripMenuItem.Click += new System.EventHandler(this.selectPaletteToolStripMenuItem_Click);
      // 
      // oldPaletteMethodToolStripMenuItem
      // 
      this.oldPaletteMethodToolStripMenuItem.Name = "oldPaletteMethodToolStripMenuItem";
      this.oldPaletteMethodToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
      this.oldPaletteMethodToolStripMenuItem.Text = "Old Palette Method";
      this.oldPaletteMethodToolStripMenuItem.Click += new System.EventHandler(this.oldPaletteMethodToolStripMenuItem_Click);
      // 
      // newPaletteMethodToolStripMenuItem
      // 
      this.newPaletteMethodToolStripMenuItem.Name = "newPaletteMethodToolStripMenuItem";
      this.newPaletteMethodToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
      this.newPaletteMethodToolStripMenuItem.Text = "New Palette Method";
      this.newPaletteMethodToolStripMenuItem.Click += new System.EventHandler(this.newPaletteMethodToolStripMenuItem_Click);
      // 
      // saveSelectedToolStripMenuItem
      // 
      this.saveSelectedToolStripMenuItem.Name = "saveSelectedToolStripMenuItem";
      this.saveSelectedToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
      this.saveSelectedToolStripMenuItem.Text = "Save Selected";
      // 
      // saveAllToolStripMenuItem
      // 
      this.saveAllToolStripMenuItem.Name = "saveAllToolStripMenuItem";
      this.saveAllToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.saveAllToolStripMenuItem.Text = "Save All";
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
      this.aboutToolStripMenuItem.Text = "About";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // horizontalContainer
      // 
      this.horizontalContainer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.horizontalContainer.Location = new System.Drawing.Point(0, 24);
      this.horizontalContainer.Name = "horizontalContainer";
      this.horizontalContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // horizontalContainer.Panel1
      // 
      this.horizontalContainer.Panel1.Controls.Add(this.verticalContainer);
      // 
      // horizontalContainer.Panel2
      // 
      this.horizontalContainer.Panel2.Controls.Add(this.tbViewer);
      this.horizontalContainer.Size = new System.Drawing.Size(719, 537);
      this.horizontalContainer.SplitterDistance = 192;
      this.horizontalContainer.TabIndex = 34;
      // 
      // verticalContainer
      // 
      this.verticalContainer.Dock = System.Windows.Forms.DockStyle.Top;
      this.verticalContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
      this.verticalContainer.IsSplitterFixed = true;
      this.verticalContainer.Location = new System.Drawing.Point(0, 0);
      this.verticalContainer.Name = "verticalContainer";
      // 
      // verticalContainer.Panel1
      // 
      this.verticalContainer.Panel1.Controls.Add(this.grpInformation);
      this.verticalContainer.Panel1.Controls.Add(this.grpHexInfomation);
      // 
      // verticalContainer.Panel2
      // 
      this.verticalContainer.Panel2.Controls.Add(this.grpPalette);
      this.verticalContainer.Size = new System.Drawing.Size(719, 186);
      this.verticalContainer.SplitterDistance = 185;
      this.verticalContainer.TabIndex = 0;
      // 
      // grpPalette
      // 
      this.grpPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpPalette.Controls.Add(this.panelPalette);
      this.grpPalette.Location = new System.Drawing.Point(3, 12);
      this.grpPalette.Name = "grpPalette";
      this.grpPalette.Size = new System.Drawing.Size(519, 173);
      this.grpPalette.TabIndex = 0;
      this.grpPalette.TabStop = false;
      this.grpPalette.Text = "Palette";
      // 
      // panelPalette
      // 
      this.panelPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.panelPalette.Location = new System.Drawing.Point(8, 33);
      this.panelPalette.Name = "panelPalette";
      this.panelPalette.Size = new System.Drawing.Size(501, 130);
      this.panelPalette.TabIndex = 0;
      this.panelPalette.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPalette_Paint);
      this.panelPalette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelPalette_MouseDown);
      // 
      // tbViewer
      // 
      this.tbViewer.AutoScroll = true;
      this.tbViewer.AutoSize = true;
      this.tbViewer.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tbViewer.Location = new System.Drawing.Point(0, 0);
      this.tbViewer.Name = "tbViewer";
      this.tbViewer.Size = new System.Drawing.Size(719, 341);
      this.tbViewer.TabIndex = 0;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(719, 561);
      this.Controls.Add(this.horizontalContainer);
      this.Controls.Add(this.menuMain);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuMain;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.MinimumSize = new System.Drawing.Size(735, 350);
      this.Name = "frmMain";
      this.Text = "bakuspr by tkrn";
      this.Load += new System.EventHandler(this.frmMain_Load);
      this.grpHexInfomation.ResumeLayout(false);
      this.grpHexInfomation.PerformLayout();
      this.grpInformation.ResumeLayout(false);
      this.grpInformation.PerformLayout();
      this.menuMain.ResumeLayout(false);
      this.menuMain.PerformLayout();
      this.horizontalContainer.Panel1.ResumeLayout(false);
      this.horizontalContainer.Panel2.ResumeLayout(false);
      this.horizontalContainer.Panel2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.horizontalContainer)).EndInit();
      this.horizontalContainer.ResumeLayout(false);
      this.verticalContainer.Panel1.ResumeLayout(false);
      this.verticalContainer.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.verticalContainer)).EndInit();
      this.verticalContainer.ResumeLayout(false);
      this.grpPalette.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPalette;
        private System.Windows.Forms.OpenFileDialog ofdSprite;
        private System.ComponentModel.BackgroundWorker bgLoadSprite;
        private System.ComponentModel.BackgroundWorker bgLoadPalette;
        private System.Windows.Forms.GroupBox grpHexInfomation;
        private System.Windows.Forms.Label lblSpriteTotalDataBytes;
        private System.Windows.Forms.Label lblSpriteWidthByte;
        private System.Windows.Forms.Label lblSpriteByteLength;
        private System.Windows.Forms.Label lblSpriteHeightByte;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lblSpriteWidth;
        private System.Windows.Forms.Label lblSpriteHeight;
        private System.Windows.Forms.Label lblSpriteNumber;
        private ThumbnailViewer.ThumbnailViewerControl tbViewer;

        private System.Windows.Forms.SaveFileDialog sfdSprite;
        private System.Windows.Forms.FolderBrowserDialog fbdSprites;
    private System.Windows.Forms.MenuStrip menuMain;
    private System.Windows.Forms.ToolStripMenuItem openSpriteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem selectPaletteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveSelectedToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem saveAllToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    private System.Windows.Forms.SplitContainer horizontalContainer;
    private System.Windows.Forms.SplitContainer verticalContainer;
    private System.Windows.Forms.GroupBox grpPalette;
    private System.Windows.Forms.Panel panelPalette;
    private System.Windows.Forms.ToolStripMenuItem oldPaletteMethodToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem newPaletteMethodToolStripMenuItem;
  }
}

