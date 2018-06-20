//    bakuspr - A utility to extract sprites from Baku Baku Animal for PC
//
//    Copyright (C) 2018 tkrn
//
//    This program is free software: you can redistribute it and/or modify
//    it under the terms of the GNU General Public License as published by
//    the Free Software Foundation, either version 3 of the License, or
//    (at your option) any later version.
//
//    This program is distributed in the hope that it will be useful,
//    but WITHOUT ANY WARRANTY; without even the implied warranty of
//    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//    GNU General Public License for more details.
//
//    You should have received a copy of the GNU General Public License
//    along with this program.  If not, see <https://www.gnu.org/licenses/>.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Diagnostics;
using System.Collections;
using ThumbnailViewer;
using TRSDialogs;

namespace bakuspr
{
    public partial class frmMain : Form
    {
        Color[] CurrentPalette;
      
        public frmMain()
        {
            InitializeComponent();
            lblCustomPaletteFilename.Text = null;
            bgLoadPalette.RunWorkerAsync();
        }

        private void btnOpenSprite_Click(object sender, EventArgs e)
        {
            if (ofdSprite.ShowDialog() == DialogResult.OK)
            {
                tbViewer.Clear();
                btnSave.Enabled = false;
                bgLoadSprite.RunWorkerAsync();
            }
        }

        private void rbWin95Default_CheckedChanged(object sender, EventArgs e)
        {
            btnImport.Enabled = false;
            lblCustomPaletteFilename.Text = null;
            bgLoadPalette.RunWorkerAsync();
        }

        private void rbCustom_CheckedChanged(object sender, EventArgs e)
        {
            btnImport.Enabled = true;     
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            if (ofdPalette.ShowDialog() == DialogResult.OK)
            {
                lblCustomPaletteFilename.Text = ofdPalette.SafeFileName;
                bgLoadPalette.RunWorkerAsync();
            }
        }

        public void SetSpriteNumber(string number)
        {
            lblSpriteNumber.Text = String.Format("# {0}", number);
        }

        public void SetSpriteWidthLabel(string width)
        {
            lblSpriteWidth.Text = String.Format("Width: {0}", width);
        }

        public void SetSpriteWidthByteLabel(string start, string end)
        {
            if (start != null && end != null)
            {
                lblSpriteWidthByte.Text = String.Format("Width Byte: {0}:{1}", start, end);
            }
            else
            {
                lblSpriteWidthByte.Text = "Width Byte:";
            }
        }

        public void SetSpriteHeightLabel(string height)
        {
            lblSpriteHeight.Text = String.Format("Height: {0}", height);           
        }

        public void SetSpriteHeightByteLabel(string start, string end)
        {
            if (start != null && end != null)
            {
                lblSpriteHeightByte.Text = String.Format("Height Byte: {0}:{1}", start, end);
            }
            else
            {
                lblSpriteHeightByte.Text = "Height Byte:";
            }
        }

        public void SetSpriteByteLengthLabel(string start, string end)
        {
            if (start != null && end != null)
            {
                lblSpriteByteLength.Text = String.Format("Byte Length: {0}:{1}", start, end);
            }
            else
            {
                lblSpriteByteLength.Text = "Byte Length:";
            }
        }

        public void SetSpriteTotalDataBytesLabel(string length)
        {
            lblSpriteTotalDataBytes.Text = String.Format("Total Data Bytes: {0}", length);
        }

        public void SaveButtonSetText(string text)
        {
            btnSave.Text = text;
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.ShowDialog();
        }

        private void bgLoadPalette_DoWork(object sender, DoWorkEventArgs e)
        {
            if (rbCustom.Checked && File.Exists(ofdPalette.FileName))
            {
                byte[] buffer = File.ReadAllBytes(ofdPalette.FileName);
                CurrentPalette = ImageHandler.LoadCustomPalette(buffer);
            }
            else
            {
                CurrentPalette = ImageHandler.LoadWindows95DefaultPalette();
            }
        }

        private void bgLoadSprite_DoWork(object sender, DoWorkEventArgs e)
        {
            if (File.Exists(ofdSprite.FileName))
            {
                tbViewer.UseWaitCursor = true;
                byte[] buffer = File.ReadAllBytes(ofdSprite.FileName); 
                SprItem[] images = ImageHandler.ReadSpriteFile(buffer);
                
                foreach (SprItem i in images)
                {
                    // Update the GUI thread by invoking it
                    tbViewer.Invoke((MethodInvoker)delegate
                    {
                        tbViewer.AddImage(i);
                    });
                }
            }
        }

        private void bgLoadPalette_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnOpenSprite.Enabled = true;
        }

        private void bgLoadSprite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            btnSave.Enabled = true;
            tbViewer.UseWaitCursor = false;
            transparentPanel.BringToFront();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Bitmap[] currentBitmaps = tbViewer.GetSelectedBitmaps();

            if (currentBitmaps.Count() == 1)
            {
                if (sfdSprite.ShowDialog() == DialogResult.OK)
                {
                    currentBitmaps[0].Save(sfdSprite.FileName, 
                        System.Drawing.Imaging.ImageFormat.Bmp);
                }
            }
            else if (currentBitmaps.Count() > 1)
            {
                if (fbdSprites.ShowDialog() == DialogResult.OK)
                {
                    MemoryBoxResult result = MemoryBoxResult.Null;

                    for (int i = 0; i < currentBitmaps.Count(); i++) {

                        string filename = String.Format("{0}\\Sprite_{1}.bmp", 
                            fbdSprites.SelectedPath, 
                            i.ToString("000"));

                        if (File.Exists(filename))
                        {
                            if (result == MemoryBoxResult.Null)
                            {
                                MemoryBox memoryBox = new MemoryBox();
                                result = memoryBox.ShowMemoryDialog(
                                String.Format("The file \"Sprite_{0}.bmp\" already exists, overwrite?",
                                    i.ToString("000")),
                                "Overwrite Files?");
                            }
                            else
                            {
                                if (result == MemoryBoxResult.Cancel) { break; }

                                switch ((MemoryBoxResult)result)
                                {
                                    case MemoryBoxResult.Yes:
                                        currentBitmaps[i].Save(filename,
                                            System.Drawing.Imaging.ImageFormat.Bmp);
                                        result = MemoryBoxResult.Null;
                                        break;

                                    case MemoryBoxResult.YesToAll:
                                        currentBitmaps[i].Save(filename,
                                            System.Drawing.Imaging.ImageFormat.Bmp);
                                        break;

                                    case MemoryBoxResult.No:
                                        result = MemoryBoxResult.Null;
                                        break;
                                }
                            }
                        }
                        else
                        {
                            currentBitmaps[i].Save(filename,
                                System.Drawing.Imaging.ImageFormat.Bmp);
                        } // End - if (File.Exists(filename))

                    } // End - for (int i = 0; i < currentBitmaps.Count(); i++) {

                } // End - if (fbdSprites.ShowDialog() == DialogResult.OK)

            } // End - else if (currentBitmaps.Count() > 1)

        }

    } // End - public partial class frmMain : Form

} // End - namespace bakuspr
