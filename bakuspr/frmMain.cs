//    bakuspr - A utility to extract sprites from Baku Baku Animal for PC
//
//    Copyright (C) 2018-2019 tkrn
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

        String WndTitle = "bakuspr by tkrn";
      
        public frmMain()
        {
            InitializeComponent();
            bgLoadPalette.RunWorkerAsync();
        }

        //public static List<Sprite> sprites = new List<Sprite>();
        public static Color[] palette = new Color[256];
        public static Color[] defaultpalette = new Color[256];
        public List<string> palettes = new List<string>();

        private void btnOpenSprite_Click(object sender, EventArgs e)
        {
      
          if (ofdSprite.ShowDialog() == DialogResult.OK)
          {
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
              /*
              sprites = new List<Sprite>();
              int numSprites = BitConverter.ToInt32(file, 8);
              int spriteOff = BitConverter.ToInt32(file, 0xC);
              for (int i = 0; i < numSprites; i++)
              {
                int data = (i * 0xC) + 0x10;
                int width = BitConverter.ToInt16(file, data + 4);
                int height = BitConverter.ToInt16(file, data + 6);
                int dw = width;
                if ((dw & 4) == 4)
                  dw += 4;
                byte[] sprite = new byte[(dw / 2) * height];
                Array.Copy(file, spriteOff, sprite, 0, sprite.Length);
                spriteOff += sprite.Length;
                sprites.Add(new Sprite(new BitmapBits(width, height, sprite), new Point(BitConverter.ToInt16(file, data), BitConverter.ToInt16(file, data + 2)), BitConverter.ToInt16(file, data + 8) - 16));
              }
              tileList1.SelectedIndex = 0;
              tileList1.ChangeSize();
              this.Text = String.Format(WndTitle + " - {0}", ofdSprite.SafeFileName);
             */
              //tbViewer.Clear();
              //bgLoadSprite.RunWorkerAsync();
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

        private void bgLoadPalette_DoWork(object sender, DoWorkEventArgs e)
        {        
            if (File.Exists(ofdPalette.FileName))
            {
                byte[] buffer = File.ReadAllBytes(ofdPalette.FileName);
                CurrentPalette = ImageHandler.LoadCustomPalette(buffer);
            }
            else
            {
                CurrentPalette = ImageHandler.LoadDefaultPalette();
            }

            ImageHandler.SetColorPalette(CurrentPalette);
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

        private void bgLoadSprite_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tbViewer.UseWaitCursor = false;
        }


        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          frmAbout about = new frmAbout();
          about.ShowDialog();
        }

        private void openSpriteToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if (ofdSprite.ShowDialog() == DialogResult.OK)
          {
            this.Text = String.Format(WndTitle + " - {0}", ofdSprite.SafeFileName);
            tbViewer.Clear();
            bgLoadSprite.RunWorkerAsync();
          }
        }

        private void selectPaletteToolStripMenuItem_Click(object sender, EventArgs e)
        {
         
        }

        private void saveAllToolStripMenuItem_Click(object sender, EventArgs e)
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

              for (int i = 0; i < currentBitmaps.Count(); i++)
              {

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
        Point selectedColor = new Point();

        private void frmMain_Load(object sender, EventArgs e)
        {
          defaultpalette = ImageHandler.LoadDefaultPalette();
          Array.Copy(defaultpalette, palette, defaultpalette.Length);
        }

        private void panelPalette_Paint(object sender, PaintEventArgs e)
        {
          e.Graphics.Clear(SystemColors.Control);
          int i = 0;
          for (int y = 0; y <= 3; y++)
            for (int x = 0; x <= 15; x++)
            {
              e.Graphics.FillRectangle(new SolidBrush(palette[i]), x * 32, y * 32, 32, 32);
              e.Graphics.DrawRectangle(Pens.White, x * 32, y * 32, 31, 31);
              i++;
            }
          e.Graphics.DrawRectangle(new Pen(Color.Yellow, 2), selectedColor.X * 32, selectedColor.Y * 32, 32, 32);
        }

        private void panelPalette_MouseDown(object sender, MouseEventArgs e)
        {

        }

    private void newPaletteMethodToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog fd = new OpenFileDialog())
      {
        fd.DefaultExt = "bin";
        fd.Filter = "Palette Files|*.bin;*.*";
        fd.RestoreDirectory = true;
        if (fd.ShowDialog(this) == DialogResult.OK)
        {
          byte[] file = File.ReadAllBytes(fd.FileName);
          Color[] loadedPalette = ImageHandler.LoadCustomPalette(file);
          Array.Copy(loadedPalette, palette, loadedPalette.Length);
          panelPalette.Invalidate();
        }
      }
    }

    private void oldPaletteMethodToolStripMenuItem_Click(object sender, EventArgs e)
    {
      using (OpenFileDialog fd = new OpenFileDialog())
      {
        fd.DefaultExt = "bin";
        fd.Filter = "Palette Files|*.bin;*.*";
        fd.RestoreDirectory = true;
        if (fd.ShowDialog(this) == DialogResult.OK)
        {
          byte[] file = File.ReadAllBytes(fd.FileName);
          Color[] loadedPalette = ImageHandler.LoadLegacyPaletteMethod(file);
          Array.Copy(loadedPalette, palette, loadedPalette.Length);
          panelPalette.Invalidate();
        }
      }
    }
  } // End - public partial class frmMain : Form

} // End - namespace bakuspr
