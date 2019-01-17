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

        public static Color[] LoadWindows95DefaultPalette()
        {
            colorPalette[0] = Color.FromArgb(0, 0x00, 0x00, 0x00);
            colorPalette[1] = Color.FromArgb(0, 0x80, 0x00, 0x00);
            colorPalette[2] = Color.FromArgb(0, 0x00, 0x80, 0x00);
            colorPalette[3] = Color.FromArgb(0, 0x80, 0x80, 0x00);
            colorPalette[4] = Color.FromArgb(0, 0x00, 0x00, 0x80);
            colorPalette[5] = Color.FromArgb(0, 0x80, 0x00, 0x80);
            colorPalette[6] = Color.FromArgb(0, 0x00, 0x80, 0x80);
            colorPalette[7] = Color.FromArgb(0, 0xC0, 0xC0, 0xC0);
            colorPalette[8] = Color.FromArgb(0, 0xC0, 0xDC, 0xC0);
            colorPalette[9] = Color.FromArgb(0, 0xA6, 0xCA, 0xF0);
            colorPalette[10] = Color.FromArgb(0, 0x2A, 0x3F, 0xAA);
            colorPalette[11] = Color.FromArgb(0, 0x2A, 0x3F, 0xFF);
            colorPalette[12] = Color.FromArgb(0, 0x2A, 0x5F, 0x00);
            colorPalette[13] = Color.FromArgb(0, 0x2A, 0x5F, 0x55);
            colorPalette[14] = Color.FromArgb(0, 0x2A, 0x5F, 0xAA);
            colorPalette[15] = Color.FromArgb(0, 0x2A, 0x5F, 0xFF);
            colorPalette[16] = Color.FromArgb(0, 0x2A, 0x7F, 0x00);
            colorPalette[17] = Color.FromArgb(0, 0x2A, 0x7F, 0x55);
            colorPalette[18] = Color.FromArgb(0, 0x2A, 0x7F, 0xAA);
            colorPalette[19] = Color.FromArgb(0, 0x2A, 0x7F, 0xFF);
            colorPalette[20] = Color.FromArgb(0, 0x2A, 0x9F, 0x00);
            colorPalette[21] = Color.FromArgb(0, 0x2A, 0x9F, 0x55);
            colorPalette[22] = Color.FromArgb(0, 0x2A, 0x9F, 0xAA);
            colorPalette[23] = Color.FromArgb(0, 0x2A, 0x9F, 0xFF);
            colorPalette[24] = Color.FromArgb(0, 0x2A, 0xBF, 0x00);
            colorPalette[25] = Color.FromArgb(0, 0x2A, 0xBF, 0x55);
            colorPalette[26] = Color.FromArgb(0, 0x2A, 0xBF, 0xAA);
            colorPalette[27] = Color.FromArgb(0, 0x2A, 0xBF, 0xFF);
            colorPalette[28] = Color.FromArgb(0, 0x2A, 0xDF, 0x00);
            colorPalette[29] = Color.FromArgb(0, 0x2A, 0xDF, 0x55);
            colorPalette[30] = Color.FromArgb(0, 0x2A, 0xDF, 0xAA);
            colorPalette[31] = Color.FromArgb(0, 0x2A, 0xDF, 0xFF);
            colorPalette[32] = Color.FromArgb(0, 0x2A, 0xFF, 0x00);
            colorPalette[33] = Color.FromArgb(0, 0x2A, 0xFF, 0x55);
            colorPalette[34] = Color.FromArgb(0, 0x2A, 0xFF, 0xAA);
            colorPalette[35] = Color.FromArgb(0, 0x2A, 0xFF, 0xFF);
            colorPalette[36] = Color.FromArgb(0, 0x55, 0x00, 0x00);
            colorPalette[37] = Color.FromArgb(0, 0x55, 0x00, 0x55);
            colorPalette[38] = Color.FromArgb(0, 0x55, 0x00, 0xAA);
            colorPalette[39] = Color.FromArgb(0, 0x55, 0x00, 0xFF);
            colorPalette[40] = Color.FromArgb(0, 0x55, 0x1F, 0x00);
            colorPalette[41] = Color.FromArgb(0, 0x55, 0x1F, 0x55);
            colorPalette[42] = Color.FromArgb(0, 0x55, 0x1F, 0xAA);
            colorPalette[43] = Color.FromArgb(0, 0x55, 0x1F, 0xFF);
            colorPalette[44] = Color.FromArgb(0, 0x55, 0x3F, 0x00);
            colorPalette[45] = Color.FromArgb(0, 0x55, 0x3F, 0x55);
            colorPalette[46] = Color.FromArgb(0, 0x55, 0x3F, 0xAA);
            colorPalette[47] = Color.FromArgb(0, 0x55, 0x3F, 0xFF);
            colorPalette[48] = Color.FromArgb(0, 0x55, 0x5F, 0x00);
            colorPalette[49] = Color.FromArgb(0, 0x55, 0x5F, 0x55);
            colorPalette[50] = Color.FromArgb(0, 0x55, 0x5F, 0xAA);
            colorPalette[51] = Color.FromArgb(0, 0x55, 0x5F, 0xFF);
            colorPalette[52] = Color.FromArgb(0, 0x55, 0x7F, 0x00);
            colorPalette[53] = Color.FromArgb(0, 0x55, 0x7F, 0x55);
            colorPalette[54] = Color.FromArgb(0, 0x55, 0x7F, 0xAA);
            colorPalette[55] = Color.FromArgb(0, 0x55, 0x7F, 0xFF);
            colorPalette[56] = Color.FromArgb(0, 0x55, 0x9F, 0x00);
            colorPalette[57] = Color.FromArgb(0, 0x55, 0x9F, 0x55);
            colorPalette[58] = Color.FromArgb(0, 0x55, 0x9F, 0xAA);
            colorPalette[59] = Color.FromArgb(0, 0x55, 0x9F, 0xFF);
            colorPalette[60] = Color.FromArgb(0, 0x55, 0xBF, 0x00);
            colorPalette[61] = Color.FromArgb(0, 0x55, 0xBF, 0x55);
            colorPalette[62] = Color.FromArgb(0, 0x55, 0xBF, 0xAA);
            colorPalette[63] = Color.FromArgb(0, 0x55, 0xBF, 0xFF);
            colorPalette[64] = Color.FromArgb(0, 0x55, 0xDF, 0x00);
            colorPalette[65] = Color.FromArgb(0, 0x55, 0xDF, 0x55);
            colorPalette[66] = Color.FromArgb(0, 0x55, 0xDF, 0xAA);
            colorPalette[67] = Color.FromArgb(0, 0x55, 0xDF, 0xFF);
            colorPalette[68] = Color.FromArgb(0, 0x55, 0xFF, 0x00);
            colorPalette[69] = Color.FromArgb(0, 0x55, 0xFF, 0x55);
            colorPalette[70] = Color.FromArgb(0, 0x55, 0xFF, 0xAA);
            colorPalette[71] = Color.FromArgb(0, 0x55, 0xFF, 0xFF);
            colorPalette[72] = Color.FromArgb(0, 0x7F, 0x00, 0x00);
            colorPalette[73] = Color.FromArgb(0, 0x7F, 0x00, 0x55);
            colorPalette[74] = Color.FromArgb(0, 0x7F, 0x00, 0xAA);
            colorPalette[75] = Color.FromArgb(0, 0x7F, 0x00, 0xFF);
            colorPalette[76] = Color.FromArgb(0, 0x7F, 0x1F, 0x00);
            colorPalette[77] = Color.FromArgb(0, 0x7F, 0x1F, 0x55);
            colorPalette[78] = Color.FromArgb(0, 0x7F, 0x1F, 0xAA);
            colorPalette[79] = Color.FromArgb(0, 0x7F, 0x1F, 0xFF);
            colorPalette[80] = Color.FromArgb(0, 0x7F, 0x3F, 0x00);
            colorPalette[81] = Color.FromArgb(0, 0x7F, 0x3F, 0x55);
            colorPalette[82] = Color.FromArgb(0, 0x7F, 0x3F, 0xAA);
            colorPalette[83] = Color.FromArgb(0, 0x7F, 0x3F, 0xFF);
            colorPalette[84] = Color.FromArgb(0, 0x7F, 0x5F, 0x00);
            colorPalette[85] = Color.FromArgb(0, 0x7F, 0x5F, 0x55);
            colorPalette[86] = Color.FromArgb(0, 0x7F, 0x5F, 0xAA);
            colorPalette[87] = Color.FromArgb(0, 0x7F, 0x5F, 0xFF);
            colorPalette[88] = Color.FromArgb(0, 0x7F, 0x7F, 0x00);
            colorPalette[89] = Color.FromArgb(0, 0x7F, 0x7F, 0x55);
            colorPalette[90] = Color.FromArgb(0, 0x7F, 0x7F, 0xAA);
            colorPalette[91] = Color.FromArgb(0, 0x7F, 0x7F, 0xFF);
            colorPalette[92] = Color.FromArgb(0, 0x7F, 0x9F, 0x00);
            colorPalette[93] = Color.FromArgb(0, 0x7F, 0x9F, 0x55);
            colorPalette[94] = Color.FromArgb(0, 0x7F, 0x9F, 0xAA);
            colorPalette[95] = Color.FromArgb(0, 0x7F, 0x9F, 0xFF);
            colorPalette[96] = Color.FromArgb(0, 0x7F, 0xBF, 0x00);
            colorPalette[97] = Color.FromArgb(0, 0x7F, 0xBF, 0x55);
            colorPalette[98] = Color.FromArgb(0, 0x7F, 0xBF, 0xAA);
            colorPalette[99] = Color.FromArgb(0, 0x7F, 0xBF, 0xFF);
            colorPalette[100] = Color.FromArgb(0, 0x7F, 0xDF, 0x00);
            colorPalette[101] = Color.FromArgb(0, 0x7F, 0xDF, 0x55);
            colorPalette[102] = Color.FromArgb(0, 0x7F, 0xDF, 0xAA);
            colorPalette[103] = Color.FromArgb(0, 0x7F, 0xDF, 0xFF);
            colorPalette[104] = Color.FromArgb(0, 0x7F, 0xFF, 0x00);
            colorPalette[105] = Color.FromArgb(0, 0x7F, 0xFF, 0x55);
            colorPalette[106] = Color.FromArgb(0, 0x7F, 0xFF, 0xAA);
            colorPalette[107] = Color.FromArgb(0, 0x7F, 0xFF, 0xFF);
            colorPalette[108] = Color.FromArgb(0, 0xAA, 0x00, 0x00);
            colorPalette[109] = Color.FromArgb(0, 0xAA, 0x00, 0x55);
            colorPalette[110] = Color.FromArgb(0, 0xAA, 0x00, 0xAA);
            colorPalette[111] = Color.FromArgb(0, 0xAA, 0x00, 0xFF);
            colorPalette[112] = Color.FromArgb(0, 0xAA, 0x1F, 0x00);
            colorPalette[113] = Color.FromArgb(0, 0xAA, 0x1F, 0x55);
            colorPalette[114] = Color.FromArgb(0, 0xAA, 0x1F, 0xAA);
            colorPalette[115] = Color.FromArgb(0, 0xAA, 0x1F, 0xFF);
            colorPalette[116] = Color.FromArgb(0, 0xAA, 0x3F, 0x00);
            colorPalette[117] = Color.FromArgb(0, 0xAA, 0x3F, 0x55);
            colorPalette[118] = Color.FromArgb(0, 0xAA, 0x3F, 0xAA);
            colorPalette[119] = Color.FromArgb(0, 0xAA, 0x3F, 0xFF);
            colorPalette[120] = Color.FromArgb(0, 0xAA, 0x5F, 0x00);
            colorPalette[121] = Color.FromArgb(0, 0xAA, 0x5F, 0x55);
            colorPalette[122] = Color.FromArgb(0, 0xAA, 0x5F, 0xAA);
            colorPalette[123] = Color.FromArgb(0, 0xAA, 0x5F, 0xFF);
            colorPalette[124] = Color.FromArgb(0, 0xAA, 0x7F, 0x00);
            colorPalette[125] = Color.FromArgb(0, 0xAA, 0x7F, 0x55);
            colorPalette[126] = Color.FromArgb(0, 0xAA, 0x7F, 0xAA);
            colorPalette[127] = Color.FromArgb(0, 0xAA, 0x7F, 0xFF);
            colorPalette[128] = Color.FromArgb(0, 0xAA, 0x9F, 0x00);
            colorPalette[129] = Color.FromArgb(0, 0xAA, 0x9F, 0x55);
            colorPalette[130] = Color.FromArgb(0, 0xAA, 0x9F, 0xAA);
            colorPalette[131] = Color.FromArgb(0, 0xAA, 0x9F, 0xFF);
            colorPalette[132] = Color.FromArgb(0, 0xAA, 0xBF, 0x00);
            colorPalette[133] = Color.FromArgb(0, 0xAA, 0xBF, 0x55);
            colorPalette[134] = Color.FromArgb(0, 0xAA, 0xBF, 0xAA);
            colorPalette[135] = Color.FromArgb(0, 0xAA, 0xBF, 0xFF);
            colorPalette[136] = Color.FromArgb(0, 0xAA, 0xDF, 0x00);
            colorPalette[137] = Color.FromArgb(0, 0xAA, 0xDF, 0x55);
            colorPalette[138] = Color.FromArgb(0, 0xAA, 0xDF, 0xAA);
            colorPalette[139] = Color.FromArgb(0, 0xAA, 0xDF, 0xFF);
            colorPalette[140] = Color.FromArgb(0, 0xAA, 0xFF, 0x00);
            colorPalette[141] = Color.FromArgb(0, 0xAA, 0xFF, 0x55);
            colorPalette[142] = Color.FromArgb(0, 0xAA, 0xFF, 0xAA);
            colorPalette[143] = Color.FromArgb(0, 0xAA, 0xFF, 0xFF);
            colorPalette[144] = Color.FromArgb(0, 0xD4, 0x00, 0x00);
            colorPalette[145] = Color.FromArgb(0, 0xD4, 0x00, 0x55);
            colorPalette[146] = Color.FromArgb(0, 0xD4, 0x00, 0xAA);
            colorPalette[147] = Color.FromArgb(0, 0xD4, 0x00, 0xFF);
            colorPalette[148] = Color.FromArgb(0, 0xD4, 0x1F, 0x00);
            colorPalette[149] = Color.FromArgb(0, 0xD4, 0x1F, 0x55);
            colorPalette[150] = Color.FromArgb(0, 0xD4, 0x1F, 0xAA);
            colorPalette[151] = Color.FromArgb(0, 0xD4, 0x1F, 0xFF);
            colorPalette[152] = Color.FromArgb(0, 0xD4, 0x3F, 0x00);
            colorPalette[153] = Color.FromArgb(0, 0xD4, 0x3F, 0x55);
            colorPalette[154] = Color.FromArgb(0, 0xD4, 0x3F, 0xAA);
            colorPalette[155] = Color.FromArgb(0, 0xD4, 0x3F, 0xFF);
            colorPalette[156] = Color.FromArgb(0, 0xD4, 0x5F, 0x00);
            colorPalette[157] = Color.FromArgb(0, 0xD4, 0x5F, 0x55);
            colorPalette[158] = Color.FromArgb(0, 0xD4, 0x5F, 0xAA);
            colorPalette[159] = Color.FromArgb(0, 0xD4, 0x5F, 0xFF);
            colorPalette[160] = Color.FromArgb(0, 0xD4, 0x7F, 0x00);
            colorPalette[161] = Color.FromArgb(0, 0xD4, 0x7F, 0x55);
            colorPalette[162] = Color.FromArgb(0, 0xD4, 0x7F, 0xAA);
            colorPalette[163] = Color.FromArgb(0, 0xD4, 0x7F, 0xFF);
            colorPalette[164] = Color.FromArgb(0, 0xD4, 0x9F, 0x00);
            colorPalette[165] = Color.FromArgb(0, 0xD4, 0x9F, 0x55);
            colorPalette[166] = Color.FromArgb(0, 0xD4, 0x9F, 0xAA);
            colorPalette[167] = Color.FromArgb(0, 0xD4, 0x9F, 0xFF);
            colorPalette[168] = Color.FromArgb(0, 0xD4, 0xBF, 0x00);
            colorPalette[169] = Color.FromArgb(0, 0xD4, 0xBF, 0x55);
            colorPalette[170] = Color.FromArgb(0, 0xD4, 0xBF, 0xAA);
            colorPalette[171] = Color.FromArgb(0, 0xD4, 0xBF, 0xFF);
            colorPalette[172] = Color.FromArgb(0, 0xD4, 0xDF, 0x00);
            colorPalette[173] = Color.FromArgb(0, 0xD4, 0xDF, 0x55);
            colorPalette[174] = Color.FromArgb(0, 0xD4, 0xDF, 0xAA);
            colorPalette[175] = Color.FromArgb(0, 0xD4, 0xDF, 0xFF);
            colorPalette[176] = Color.FromArgb(0, 0xD4, 0xFF, 0x00);
            colorPalette[177] = Color.FromArgb(0, 0xD4, 0xFF, 0x55);
            colorPalette[178] = Color.FromArgb(0, 0xD4, 0xFF, 0xAA);
            colorPalette[179] = Color.FromArgb(0, 0xD4, 0xFF, 0xFF);
            colorPalette[180] = Color.FromArgb(0, 0xFF, 0x00, 0x55);
            colorPalette[181] = Color.FromArgb(0, 0xFF, 0x00, 0xAA);
            colorPalette[182] = Color.FromArgb(0, 0xFF, 0x1F, 0x00);
            colorPalette[183] = Color.FromArgb(0, 0xFF, 0x1F, 0x55);
            colorPalette[184] = Color.FromArgb(0, 0xFF, 0x1F, 0xAA);
            colorPalette[185] = Color.FromArgb(0, 0xFF, 0x1F, 0xFF);
            colorPalette[186] = Color.FromArgb(0, 0xFF, 0x3F, 0x00);
            colorPalette[187] = Color.FromArgb(0, 0xFF, 0x3F, 0x55);
            colorPalette[188] = Color.FromArgb(0, 0xFF, 0x3F, 0xAA);
            colorPalette[189] = Color.FromArgb(0, 0xFF, 0x3F, 0xFF);
            colorPalette[190] = Color.FromArgb(0, 0xFF, 0x5F, 0x00);
            colorPalette[191] = Color.FromArgb(0, 0xFF, 0x5F, 0x55);
            colorPalette[192] = Color.FromArgb(0, 0xFF, 0x5F, 0xAA);
            colorPalette[193] = Color.FromArgb(0, 0xFF, 0x5F, 0xFF);
            colorPalette[194] = Color.FromArgb(0, 0xFF, 0x7F, 0x00);
            colorPalette[195] = Color.FromArgb(0, 0xFF, 0x7F, 0x55);
            colorPalette[196] = Color.FromArgb(0, 0xFF, 0x7F, 0xAA);
            colorPalette[197] = Color.FromArgb(0, 0xFF, 0x7F, 0xFF);
            colorPalette[198] = Color.FromArgb(0, 0xFF, 0x9F, 0x00);
            colorPalette[199] = Color.FromArgb(0, 0xFF, 0x9F, 0x55);
            colorPalette[200] = Color.FromArgb(0, 0xFF, 0x9F, 0xAA);
            colorPalette[201] = Color.FromArgb(0, 0xFF, 0x9F, 0xFF);
            colorPalette[202] = Color.FromArgb(0, 0xFF, 0xBF, 0x00);
            colorPalette[203] = Color.FromArgb(0, 0xFF, 0xBF, 0x55);
            colorPalette[204] = Color.FromArgb(0, 0xFF, 0xBF, 0xAA);
            colorPalette[205] = Color.FromArgb(0, 0xFF, 0xBF, 0xFF);
            colorPalette[206] = Color.FromArgb(0, 0xFF, 0xDF, 0x00);
            colorPalette[207] = Color.FromArgb(0, 0xFF, 0xDF, 0x55);
            colorPalette[208] = Color.FromArgb(0, 0xFF, 0xDF, 0xAA);
            colorPalette[209] = Color.FromArgb(0, 0xFF, 0xDF, 0xFF);
            colorPalette[210] = Color.FromArgb(0, 0xFF, 0xFF, 0x55);
            colorPalette[211] = Color.FromArgb(0, 0xFF, 0xFF, 0xAA);
            colorPalette[212] = Color.FromArgb(0, 0xCC, 0xCC, 0xFF);
            colorPalette[213] = Color.FromArgb(0, 0xFF, 0xCC, 0xFF);
            colorPalette[214] = Color.FromArgb(0, 0x33, 0xFF, 0xFF);
            colorPalette[215] = Color.FromArgb(0, 0x66, 0xFF, 0xFF);
            colorPalette[216] = Color.FromArgb(0, 0x99, 0xFF, 0xFF);
            colorPalette[217] = Color.FromArgb(0, 0xCC, 0xFF, 0xFF);
            colorPalette[218] = Color.FromArgb(0, 0x00, 0x7F, 0x00);
            colorPalette[219] = Color.FromArgb(0, 0x00, 0x7F, 0x55);
            colorPalette[220] = Color.FromArgb(0, 0x00, 0x7F, 0xAA);
            colorPalette[221] = Color.FromArgb(0, 0x00, 0x7F, 0xFF);
            colorPalette[222] = Color.FromArgb(0, 0x00, 0x9F, 0x00);
            colorPalette[223] = Color.FromArgb(0, 0x00, 0x9F, 0x55);
            colorPalette[224] = Color.FromArgb(0, 0x00, 0x9F, 0xAA);
            colorPalette[225] = Color.FromArgb(0, 0x00, 0x9F, 0xFF);
            colorPalette[226] = Color.FromArgb(0, 0x00, 0xBF, 0x00);
            colorPalette[227] = Color.FromArgb(0, 0x00, 0xBF, 0x55);
            colorPalette[228] = Color.FromArgb(0, 0x00, 0xBF, 0xAA);
            colorPalette[229] = Color.FromArgb(0, 0x00, 0xBF, 0xFF);
            colorPalette[230] = Color.FromArgb(0, 0x00, 0xDF, 0x00);
            colorPalette[231] = Color.FromArgb(0, 0x00, 0xDF, 0x55);
            colorPalette[232] = Color.FromArgb(0, 0x00, 0xDF, 0xAA);
            colorPalette[233] = Color.FromArgb(0, 0x00, 0xDF, 0xFF);
            colorPalette[234] = Color.FromArgb(0, 0x00, 0xFF, 0x55);
            colorPalette[235] = Color.FromArgb(0, 0x00, 0xFF, 0xAA);
            colorPalette[236] = Color.FromArgb(0, 0x2A, 0x00, 0x00);
            colorPalette[237] = Color.FromArgb(0, 0x2A, 0x00, 0x55);
            colorPalette[238] = Color.FromArgb(0, 0x2A, 0x00, 0xAA);
            colorPalette[239] = Color.FromArgb(0, 0x2A, 0x00, 0xFF);
            colorPalette[240] = Color.FromArgb(0, 0x2A, 0x1F, 0x00);
            colorPalette[241] = Color.FromArgb(0, 0x2A, 0x1F, 0x55);
            colorPalette[242] = Color.FromArgb(0, 0x2A, 0x1F, 0xAA);
            colorPalette[243] = Color.FromArgb(0, 0x2A, 0x1F, 0xFF);
            colorPalette[244] = Color.FromArgb(0, 0x2A, 0x3F, 0x00);
            colorPalette[245] = Color.FromArgb(0, 0x2A, 0x3F, 0x55);
            colorPalette[246] = Color.FromArgb(0, 0xFF, 0xFB, 0xF0);
            colorPalette[247] = Color.FromArgb(0, 0xA0, 0xA0, 0xA4);
            colorPalette[248] = Color.FromArgb(0, 0x80, 0x80, 0x80);
            colorPalette[249] = Color.FromArgb(0, 0xFF, 0x00, 0x00);
            colorPalette[250] = Color.FromArgb(0, 0x00, 0xFF, 0x00);
            colorPalette[251] = Color.FromArgb(0, 0xFF, 0xFF, 0x00);
            colorPalette[252] = Color.FromArgb(0, 0x00, 0x00, 0xFF);
            colorPalette[253] = Color.FromArgb(0, 0xFF, 0x00, 0xFF);
            colorPalette[254] = Color.FromArgb(0, 0x00, 0xFF, 0xFF);
            colorPalette[255] = Color.FromArgb(0, 0xFF, 0xFF, 0xFF);

            return colorPalette;
        }

        public static Color[] LoadCustomPalette(byte[] sender)
        {
            colorPalette[0] = Color.FromArgb(255, 0, 0, 0);
            colorPalette[1] = Color.FromArgb(255, 128, 0, 0);
            colorPalette[2] = Color.FromArgb(255, 0, 128, 0);
            colorPalette[3] = Color.FromArgb(255, 128, 128, 0);
            colorPalette[4] = Color.FromArgb(255, 0, 0, 128);
            colorPalette[5] = Color.FromArgb(255, 128, 0, 128);
            colorPalette[6] = Color.FromArgb(255, 0, 128, 128);
            colorPalette[7] = Color.FromArgb(255, 192, 192, 192);
            colorPalette[8] = Color.FromArgb(255, 192, 220, 192);
            colorPalette[9] = Color.FromArgb(255, 166, 202, 240);
            colorPalette[10] = Color.FromArgb(255, 0, 0, 0);
            colorPalette[11] = Color.FromArgb(255, 0, 0, 0);
            colorPalette[12] = Color.FromArgb(255, 0, 0, 0);
            colorPalette[13] = Color.FromArgb(255, 0, 0, 0);
            colorPalette[14] = Color.FromArgb(255, 0, 0, 0);
            colorPalette[15] = Color.FromArgb(255, 0, 0, 0);

            int ii = 16;
            for (int i = 0; i < sender.Length; i += 3)
            {
                int r = i + 2;
                int g = i + 1;
                int b = i;

                if (ii < 256) 
                {
                    colorPalette[ii] = Color.FromArgb(0, sender[r], sender[g], sender[b]);
                    ii++;
                }
                
            }

            colorPalette[246] = Color.FromArgb(255, 255, 251, 240);
            colorPalette[247] = Color.FromArgb(255, 160, 160, 164);
            colorPalette[248] = Color.FromArgb(255, 128, 128, 128);
            colorPalette[249] = Color.FromArgb(255, 255, 0, 0);
            colorPalette[250] = Color.FromArgb(255, 0, 255, 0);
            colorPalette[251] = Color.FromArgb(255, 255, 255, 0);
            colorPalette[252] = Color.FromArgb(255, 0, 0, 255);
            colorPalette[253] = Color.FromArgb(255, 255, 0, 255);
            colorPalette[254] = Color.FromArgb(255, 0, 255, 255);
            colorPalette[255] = Color.FromArgb(255, 255, 255, 255);

            return colorPalette;
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
                    if (imageNumber == 302 ) { //Debugger.Break();
                    }

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
            string part1 = input[0].ToString("X");
            string part2 = input[1].ToString("X");
            string s = string.Format("{0}{1}", part1, part2);
            return (ushort)Convert.ToInt16(s, 16);
        }
    }
}