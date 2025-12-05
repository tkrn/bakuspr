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
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections.Generic;

namespace bakuspr
{
    public static class ImageHandler
    {
        static Color[] colorPalette = new Color[256];

        public static Color[] LoadDefaultPalette()
        {
          // --- Create an 8bpp Indexed Image and copy it's color palette --- //
          Bitmap bmp = new Bitmap(1, 1, System.Drawing.Imaging.PixelFormat.Format8bppIndexed);
          Color [] palette = bmp.Palette.Entries;

          for (int i = 16; i < palette.Length; i++)
            palette[i] = palette[i & 15];

          return palette;
        }

        public static Color[] LoadCustomPalette(byte[] sender)
        {
          Color[] colors = new Color[sender.Length / 4];
          for (int i = 0; i < colors.Length; i++)
            colors[i] = Color.FromArgb(sender[i * 4], sender[i * 4 + 1], sender[i * 4 + 2]);
          return colors;
        }

        private static Bitmap MakeBitmap(byte[] sender, int width, int height, Color[] pal)
        {
            Bitmap bmp = new Bitmap(width, height, PixelFormat.Format24bppRgb);
            
            bmp.SetResolution(72.0f, 72.0f);

            for (int i = 0; i < sender.Count(); i++)
            {
                int x = i % width;
                int y = i / width;              
                Color c = pal[sender[i]];

                bmp.SetPixel(x, y, c);
            }

            return bmp;
        }

        public static SprItem[] ReadSpriteFile(byte[] sender)
        {
            // define variables
            bool headerFound = false;
            decimal imageLength = 0;
            ushort intWidth = 0;
            ushort intHeight = 0;
            int imageNumber = 0;
            int currentImageIterator = 0;
            int dimensionIterator = 0;
            short[] hexWidth = new short[2];
            short[] hexHeight = new short[2];
            List<byte> currentImageBuffer = new List<byte>();
            List<SprItem> currentSprList = new List<SprItem>();

            for (int x = 0; x < sender.Length; x++)
            {
                if (headerFound)
                {
                    currentImageBuffer.Add(sender[x]);
                    currentImageIterator++;

                    if (currentImageIterator == imageLength)
                    {
                        Bitmap bmp = MakeBitmap(currentImageBuffer.ToArray(),
                            intWidth,
                            intHeight,
                            colorPalette
                        );

                        SprItemMeta m = new SprItemMeta();
                        m.xStart = ((int)(x - imageLength - 3)).ToString("X");
                        m.xEnd = ((int)(x - imageLength - 2)).ToString("X");
                        m.yStart = ((int)(x - imageLength - 1)).ToString("X");
                        m.yEnd = ((int)(x - imageLength)).ToString("X");
                        m.dataStart = ((int)(x - imageLength + 1)).ToString("X");
                        m.dataEnd = x.ToString("X");
                        m.dataLength = imageLength.ToString();

                        SprItem spr = new SprItem();
                        spr.bmp = bmp;
                        spr.meta = m;

                        currentSprList.Add(spr);

                        currentImageBuffer.Clear();

                        // reset variables for next image
                        imageLength = 0;
                        currentImageIterator = 0;
                        dimensionIterator = 0;
                        headerFound = false;
                        intWidth = 0;
                        intHeight = 0;
                        hexWidth = new short[2];
                        hexHeight = new short[2];
                    }
                }
                else
                {
                    // reading in the sprite dimensions from the header portion of the payload
                    switch (dimensionIterator)
                    {
                        case 0:
                            hexWidth[0] = sender[x];
                            break;
                        case 1:
                            hexWidth[1] = sender[x];
                            break;
                        case 2:
                            hexHeight[0] = sender[x];
                            break;
                        case 3:
                            hexHeight[1] = sender[x];
                            break;
                    }

                    if (dimensionIterator < 4)
                    {
                        dimensionIterator++;
                    }

                    // calculate dimensions once dimensions are in buffer
                    if (dimensionIterator == 4 && headerFound == false)
                    {
                        headerFound = true;
                        imageNumber++;
                        
                        // get sizing
                        intWidth = GetIntDimension(hexWidth);
                        intHeight = GetIntDimension(hexHeight);

                        imageLength = GetIntDimension(hexWidth) * GetIntDimension(hexHeight);
                    }

                }
            }

            return currentSprList.ToArray();
        }

        private static ushort GetIntDimension(short[] input)
        {
            string part1 = input[0].ToString("X2");
            string part2 = input[1].ToString("X2");
            string s = string.Format("{0}{1}", part1, part2);
            return (ushort)Convert.ToInt16(s, 16);
        }
    }
}