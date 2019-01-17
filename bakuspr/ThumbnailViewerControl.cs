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
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;
using bakuspr;

namespace ThumbnailViewer
{
    public class ThumbnailViewerControl : FlowLayoutPanel
    {
        /// <summary> Added Image will be stored in this List
        /// </summary>
        /// 
        public List<PictureBox> selected;
        public List<SprItem> ImageList;
        private Point selectionStart;
        private Point selectionEnd;
        private Rectangle selection;
        private bool mouseDown;

        public ThumbnailViewerControl()
        {
            this.AutoScroll = true;
            this.AllowDrop = false;
            this.DoubleBuffered = true;

            // List of Image
            ImageList = new List<SprItem>();
            selected = new List<PictureBox>();

            // Event handlers
            this.MouseDown += new MouseEventHandler(Mouse_MouseDown);
            this.MouseUp += new MouseEventHandler(Mouse_MouseUp);
            this.MouseMove += new MouseEventHandler(Mouse_MouseMove);
            this.Click += new EventHandler(Mouse_Click);
        }

        public void Clear()
        {
            ImageList.Clear();
            this.Controls.Clear();
            this.Refresh();
        }

        public Image[] GetSelectedImages()
        {
            List<Image> array = new List<Image>();

            foreach (PictureBox pic in selected)
            {
                array.Add(pic.Image);
            }

            return array.ToArray();
        }

        public void AddImage(SprItem spr)
        {
            ImageList.Add(spr);
            MakeThumbnail(spr);
        }

        public void MakeThumbnail(SprItem spr)
        {
            // Create a Picture Box for showing thumbnail image
            PictureBox thumb = new PictureBox();
            thumb.Visible = true;
            thumb.MaximumSize = new Size(512, 512);
            thumb.MinimumSize = new Size(16, 16);
            thumb.Size = new Size(spr.bmp.Width, spr.bmp.Height);
            thumb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            thumb.SizeMode = PictureBoxSizeMode.Normal;

            // Preview image when Mouse Double Clicked
            thumb.DoubleClick += new EventHandler(thumb_DoubleClick);

            // Event handlers
            thumb.MouseDown += new MouseEventHandler(Mouse_MouseDown);
            thumb.MouseUp += new MouseEventHandler(Mouse_MouseUp);
            thumb.MouseMove += new MouseEventHandler(Mouse_MouseMove);
            thumb.Click += new EventHandler(Mouse_Click);

            // Set thumbnail image
            thumb.Image = spr.bmp;
            
            // Add to Panel
            this.Controls.Add(thumb);
        }

        private void SetSelectBoarder(PictureBox sender)
        {
            var rc = sender.ClientRectangle;
            rc.Inflate(-2, -2);

            ControlPaint.DrawBorder(
                sender.CreateGraphics(),
                sender.ClientRectangle,
                Color.Red,
                ButtonBorderStyle.Solid
            );

            ControlPaint.DrawBorder3D(
                sender.CreateGraphics(),
                rc,
                Border3DStyle.Bump
            );
        }

        private void thumb_DoubleClick(object sender, EventArgs e)
        {
            SetSelectBoarder((PictureBox)sender);

            int index = this.Controls.GetChildIndex((PictureBox)sender);

            Form previewForm = new Form();
            previewForm.Text = "Image # " + index;
            previewForm.FormBorderStyle = FormBorderStyle.SizableToolWindow;
            previewForm.MinimizeBox = false;
            previewForm.Size = new System.Drawing.Size(200,200);
            previewForm.StartPosition = FormStartPosition.CenterScreen;

            PictureBox view = new PictureBox();
            view.Dock = DockStyle.Fill;
       
            view.Image = ImageList[index].bmp;
            
            view.SizeMode = PictureBoxSizeMode.Zoom;
            previewForm.Controls.Add(view);
            previewForm.ShowDialog();
        }

        private void Mouse_Click(object sender, EventArgs e)
        {
            if (sender.GetType() == typeof(PictureBox))
            {
                int index = this.Controls.GetChildIndex((PictureBox)sender);
                frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
                parentForm.SetSpriteNumber(index.ToString("000"));
                parentForm.SetSpriteWidthLabel(ImageList[index].bmp.Width.ToString());
                parentForm.SetSpriteHeightLabel(ImageList[index].bmp.Height.ToString());
                parentForm.SetSpriteWidthByteLabel(ImageList[index].meta.xStart, ImageList[index].meta.xEnd);
                parentForm.SetSpriteHeightByteLabel(ImageList[index].meta.yStart, ImageList[index].meta.yEnd);
                parentForm.SetSpriteByteLengthLabel(ImageList[index].meta.dataStart, ImageList[index].meta.dataEnd);
                parentForm.SetSpriteTotalDataBytesLabel(ImageList[index].meta.dataLength);
            }
            else
            {
                ClearSpriteTextLabeles();
            }
        }

        private void Mouse_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            SetSelectionRect();
            Invalidate();
            GetSelectedPictureBoxes();          
        }

        private void Mouse_MouseDown(object sender, MouseEventArgs e)
        {
            // Clear recent selected
            foreach (Control c in Controls) {
                if (c is PictureBox) {
                    c.Invalidate();
                }
            }

            selected.Clear();

            selectionStart = PointToClient(MousePosition);
            selectionEnd = PointToClient(MousePosition);
            mouseDown = true;
        }

        private void Mouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (!mouseDown) {
                return;
            }

            selectionEnd = PointToClient(MousePosition);
            SetSelectionRect();
            Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {            
            base.OnPaint(e);

            if (mouseDown) {
                //this.Region.GetHrgn(e.Graphics);
                using (Pen pen = new Pen(Color.Red, 2F)) {
                    pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    
                    e.Graphics.DrawRectangle(pen, selection);
                }

            }
        }

        private void GetSelectedPictureBoxes()
        {
            foreach (Control c in Controls)
            {
                if (c is PictureBox) {
                    if (selection.IntersectsWith(c.Bounds)) {
                        selected.Add((PictureBox)c); 
                    }
                }
            }

            foreach (PictureBox p in selected) {
                SetSelectBoarder(p);
            }

            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);

            if (selected.Count == 0) {
                ClearSpriteTextLabeles();
                parentForm.SaveButtonSetText("Save All");
            } else if (selected.Count == 1) {
                parentForm.SaveButtonSetText("Save Selected");
            } else if (selected.Count > 1) {
                ClearSpriteTextLabeles();
                parentForm.SaveButtonSetText("Save Selected");
            }

        }

        public Bitmap[] GetSelectedBitmaps()
        {
            List<int> selectedIndexes = new List<int>();

            foreach (Control c in Controls) {
                if (c is PictureBox) {
                    if (selection.IntersectsWith(c.Bounds)) {
                        selectedIndexes.Add(this.Controls.GetChildIndex(c));
                    }
                }
            }

            Bitmap[] bmpArray = new Bitmap[selectedIndexes.Count];

            for (int i = 0; i < selectedIndexes.Count; i++) {
                bmpArray[i] = ImageList[selectedIndexes[i]].bmp;
            }

            return bmpArray;
        }

        private void ClearSpriteTextLabeles()
        {
            frmMain parentForm = (this.Parent.Parent.Parent as frmMain);
            parentForm.SetSpriteNumber(null);
            parentForm.SetSpriteWidthLabel(null);
            parentForm.SetSpriteHeightLabel(null);
            parentForm.SetSpriteWidthByteLabel(null, null);
            parentForm.SetSpriteHeightByteLabel(null, null);
            parentForm.SetSpriteByteLengthLabel(null, null);
            parentForm.SetSpriteTotalDataBytesLabel(null);
        }

        private void SetSelectionRect()
        {
            int x, y;
            int width, height;

            x = selectionStart.X > selectionEnd.X ? selectionEnd.X : selectionStart.X;
            y = selectionStart.Y > selectionEnd.Y ? selectionEnd.Y : selectionStart.Y;

            width = selectionStart.X > selectionEnd.X ? selectionStart.X - selectionEnd.X : selectionEnd.X - selectionStart.X;
            height = selectionStart.Y > selectionEnd.Y ? selectionStart.Y - selectionEnd.Y : selectionEnd.Y - selectionStart.Y;

            selection = new Rectangle(x, y, width, height);
        }
    }
}
