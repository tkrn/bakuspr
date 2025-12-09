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
      this.reloadSpriteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.defaultPaletteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bgr3bppPaletteMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rgb3bppMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.bgr4bppMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rgb4bppMethodToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveSelectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.saveAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.horizontalContainer = new System.Windows.Forms.SplitContainer();
      this.verticalContainer = new System.Windows.Forms.SplitContainer();
      this.grpPalette = new System.Windows.Forms.GroupBox();
      this.panelPalette = new System.Windows.Forms.Panel();
      this.tbViewer = new ThumbnailViewer.ThumbnailViewerControl();
      this.grpPaletteMode = new System.Windows.Forms.GroupBox();
      this.rb_bgr_3bpp = new System.Windows.Forms.RadioButton();
      this.rb_rgb_3bpp = new System.Windows.Forms.RadioButton();
      this.rb_rgb_4bpp = new System.Windows.Forms.RadioButton();
      this.rb_bgr_4bpp = new System.Windows.Forms.RadioButton();
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
      this.grpPaletteMode.SuspendLayout();
      this.SuspendLayout();
      // 
      // ofdPalette
      // 
      this.ofdPalette.Filter = "Palette Files|*.bin;*.pal;*.fix;";
      this.ofdPalette.RestoreDirectory = true;
      this.ofdPalette.Title = "Open a Custom Palette File";
      // 
      // ofdSprite
      // 
      this.ofdSprite.Filter = "Sprite File (*.spr)|*.spr;*.fix;";
      this.ofdSprite.Title = "Open a Sprite File";
      // 
      // bgLoadSprite
      // 
      this.bgLoadSprite.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgLoadSprite_DoWork);
      this.bgLoadSprite.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgLoadSprite_RunWorkerCompleted);
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
            this.reloadSpriteToolStripMenuItem,
            this.selectPaletteToolStripMenuItem,
            this.saveSelectedToolStripMenuItem,
            this.saveAllToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuMain.Location = new System.Drawing.Point(0, 0);
      this.menuMain.Name = "menuMain";
      this.menuMain.Size = new System.Drawing.Size(1022, 24);
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
      // reloadSpriteToolStripMenuItem
      // 
      this.reloadSpriteToolStripMenuItem.Enabled = false;
      this.reloadSpriteToolStripMenuItem.Name = "reloadSpriteToolStripMenuItem";
      this.reloadSpriteToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
      this.reloadSpriteToolStripMenuItem.Text = "Reload Sprite";
      this.reloadSpriteToolStripMenuItem.Click += new System.EventHandler(this.reloadSpriteToolStripMenuItem_Click);
      // 
      // selectPaletteToolStripMenuItem
      // 
      this.selectPaletteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.defaultPaletteToolStripMenuItem,
            this.bgr3bppPaletteMethodToolStripMenuItem,
            this.rgb3bppMethodToolStripMenuItem,
            this.bgr4bppMethodToolStripMenuItem,
            this.rgb4bppMethodToolStripMenuItem});
      this.selectPaletteToolStripMenuItem.Name = "selectPaletteToolStripMenuItem";
      this.selectPaletteToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
      this.selectPaletteToolStripMenuItem.Text = "Select Palette";
      // 
      // defaultPaletteToolStripMenuItem
      // 
      this.defaultPaletteToolStripMenuItem.Name = "defaultPaletteToolStripMenuItem";
      this.defaultPaletteToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.defaultPaletteToolStripMenuItem.Text = "Default Palette";
      this.defaultPaletteToolStripMenuItem.Click += new System.EventHandler(this.defaultPaletteToolStripMenuItem_Click);
      // 
      // bgr3bppPaletteMethodToolStripMenuItem
      // 
      this.bgr3bppPaletteMethodToolStripMenuItem.Name = "bgr3bppPaletteMethodToolStripMenuItem";
      this.bgr3bppPaletteMethodToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.bgr3bppPaletteMethodToolStripMenuItem.Text = "bgr 3bpp Method";
      this.bgr3bppPaletteMethodToolStripMenuItem.Click += new System.EventHandler(this.bgr3bppMethodToolStripMenuItem_Click);
      // 
      // rgb3bppMethodToolStripMenuItem
      // 
      this.rgb3bppMethodToolStripMenuItem.Name = "rgb3bppMethodToolStripMenuItem";
      this.rgb3bppMethodToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.rgb3bppMethodToolStripMenuItem.Text = "rgb 3bpp Method";
      this.rgb3bppMethodToolStripMenuItem.Click += new System.EventHandler(this.rgb3bppMethodToolStripMenuItem_Click);
      // 
      // bgr4bppMethodToolStripMenuItem
      // 
      this.bgr4bppMethodToolStripMenuItem.Name = "bgr4bppMethodToolStripMenuItem";
      this.bgr4bppMethodToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.bgr4bppMethodToolStripMenuItem.Text = "bgr 4bpp Method";
      this.bgr4bppMethodToolStripMenuItem.Click += new System.EventHandler(this.bgr4bppMethodToolStripMenuItem_Click);
      // 
      // rgb4bppMethodToolStripMenuItem
      // 
      this.rgb4bppMethodToolStripMenuItem.Name = "rgb4bppMethodToolStripMenuItem";
      this.rgb4bppMethodToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
      this.rgb4bppMethodToolStripMenuItem.Text = "rgb 4bpp Method";
      this.rgb4bppMethodToolStripMenuItem.Click += new System.EventHandler(this.rgb4bppMethodToolStripMenuItem_Click);
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
      this.horizontalContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
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
      this.horizontalContainer.Size = new System.Drawing.Size(1022, 537);
      this.horizontalContainer.SplitterDistance = 186;
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
      this.verticalContainer.Panel2.Controls.Add(this.grpPaletteMode);
      this.verticalContainer.Panel2.Controls.Add(this.grpPalette);
      this.verticalContainer.Size = new System.Drawing.Size(1022, 186);
      this.verticalContainer.SplitterDistance = 185;
      this.verticalContainer.TabIndex = 0;
      // 
      // grpPalette
      // 
      this.grpPalette.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpPalette.Controls.Add(this.panelPalette);
      this.grpPalette.Location = new System.Drawing.Point(133, 12);
      this.grpPalette.Name = "grpPalette";
      this.grpPalette.Size = new System.Drawing.Size(688, 173);
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
      this.panelPalette.Size = new System.Drawing.Size(670, 130);
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
      this.tbViewer.Size = new System.Drawing.Size(1022, 347);
      this.tbViewer.TabIndex = 0;
      // 
      // grpPaletteMode
      // 
      this.grpPaletteMode.Controls.Add(this.rb_bgr_4bpp);
      this.grpPaletteMode.Controls.Add(this.rb_rgb_4bpp);
      this.grpPaletteMode.Controls.Add(this.rb_rgb_3bpp);
      this.grpPaletteMode.Controls.Add(this.rb_bgr_3bpp);
      this.grpPaletteMode.Location = new System.Drawing.Point(3, 12);
      this.grpPaletteMode.Name = "grpPaletteMode";
      this.grpPaletteMode.Size = new System.Drawing.Size(124, 173);
      this.grpPaletteMode.TabIndex = 1;
      this.grpPaletteMode.TabStop = false;
      this.grpPaletteMode.Text = "Palette Mode";
      // 
      // rb_bgr_3bpp
      // 
      this.rb_bgr_3bpp.AutoSize = true;
      this.rb_bgr_3bpp.Checked = true;
      this.rb_bgr_3bpp.Location = new System.Drawing.Point(26, 66);
      this.rb_bgr_3bpp.Name = "rb_bgr_3bpp";
      this.rb_bgr_3bpp.Size = new System.Drawing.Size(67, 17);
      this.rb_bgr_3bpp.TabIndex = 0;
      this.rb_bgr_3bpp.TabStop = true;
      this.rb_bgr_3bpp.Text = "bgr 3bpp";
      this.rb_bgr_3bpp.UseVisualStyleBackColor = true;
      // 
      // rb_rgb_3bpp
      // 
      this.rb_rgb_3bpp.AutoSize = true;
      this.rb_rgb_3bpp.Location = new System.Drawing.Point(26, 42);
      this.rb_rgb_3bpp.Name = "rb_rgb_3bpp";
      this.rb_rgb_3bpp.Size = new System.Drawing.Size(67, 17);
      this.rb_rgb_3bpp.TabIndex = 1;
      this.rb_rgb_3bpp.Text = "rgb 3bpp";
      this.rb_rgb_3bpp.UseVisualStyleBackColor = true;
      // 
      // rb_rgb_4bpp
      // 
      this.rb_rgb_4bpp.AutoSize = true;
      this.rb_rgb_4bpp.Location = new System.Drawing.Point(26, 89);
      this.rb_rgb_4bpp.Name = "rb_rgb_4bpp";
      this.rb_rgb_4bpp.Size = new System.Drawing.Size(67, 17);
      this.rb_rgb_4bpp.TabIndex = 2;
      this.rb_rgb_4bpp.Text = "rgb 4bpp";
      this.rb_rgb_4bpp.UseVisualStyleBackColor = true;
      // 
      // rb_bgr_4bpp
      // 
      this.rb_bgr_4bpp.AutoSize = true;
      this.rb_bgr_4bpp.Location = new System.Drawing.Point(26, 112);
      this.rb_bgr_4bpp.Name = "rb_bgr_4bpp";
      this.rb_bgr_4bpp.Size = new System.Drawing.Size(67, 17);
      this.rb_bgr_4bpp.TabIndex = 3;
      this.rb_bgr_4bpp.Text = "bgr 4bpp";
      this.rb_bgr_4bpp.UseVisualStyleBackColor = true;
      // 
      // frmMain
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1022, 561);
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
      this.grpPaletteMode.ResumeLayout(false);
      this.grpPaletteMode.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog ofdPalette;
        private System.Windows.Forms.OpenFileDialog ofdSprite;
        private System.ComponentModel.BackgroundWorker bgLoadSprite;
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
    private System.Windows.Forms.ToolStripMenuItem bgr3bppPaletteMethodToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rgb4bppMethodToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem defaultPaletteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem reloadSpriteToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem rgb3bppMethodToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem bgr4bppMethodToolStripMenuItem;
    private System.Windows.Forms.GroupBox grpPaletteMode;
    private System.Windows.Forms.RadioButton rb_bgr_4bpp;
    private System.Windows.Forms.RadioButton rb_rgb_4bpp;
    private System.Windows.Forms.RadioButton rb_rgb_3bpp;
    private System.Windows.Forms.RadioButton rb_bgr_3bpp;
  }
}

