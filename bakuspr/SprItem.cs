//    bakuspr - A utility to extract sprites from Baku Baku Animal for PC
//
//    Copyright (C) 2018-2025 tkrn
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

using System.Drawing;

namespace bakuspr
{
    public class SprItem
    {
        public Bitmap bmp { get; set; }
        public SprItemMeta meta { get; set; }
    }

    // Set as string for display only
    public class SprItemMeta
    {
        public string xStart;
        public string yStart;
        public string xEnd;
        public string yEnd;
        public string dataStart;
        public string dataEnd;
        public string dataLength;
    }
}
