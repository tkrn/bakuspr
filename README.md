# bakuspr

A utility to extract sprites from the Sega title Baku Baku Animal for PC (1996). 

#### Usage

Ideally, you want to load a color pallette file (PAL\\*.bin). If not, the Windows 95 color pallette will be default. Generally speaking, this will result in incorrect color information. 

After the color file is loaded, proceed to loading a sprite file (GR\\*.spr). Once the sprite is loaded, click and drag to select sprite files to save as their native bitmap format. 

#### Download


#### Screenshots

[![bakuspr Screenshot](http://nthnk.com/github/bakuspr_1_thumb.png)](http://nthnk.com/github/bakuspr_1.png)
[![bakuspr Screenshot](http://nthnk.com/github/bakuspr_2_thumb.png)](http://nthnk.com/github/bakuspr_2.png)

#### Technical / Background Information
Thanks to xdaniel on The Cutting Room Floor (tcrf.net) message boards to help reverse engineer the sprite files. With that being said, this is what I've learned about the Baku Baku Animal PC sprite files. The first two bytes are the width, the following two bytes after that are the height. You multiply the width and the height to get the data image length. 

This game orignally requires 256 colors (8-bit) and having the sprite file is merely not enough. A palette file is required for correct color output. There are two type of known Baku Baku PC palette files. One with "VS" in the filename and another one without "VS" inn the filename. The files with "VS" are 32 color palette files. The files without "VS" in the name are 112 color palette files.

There is still a missing piece of the displaying all the sprites correctly and it's in the GAME.FIX files which primarily pertain to the GAME.SPR file (needs confirmation) but the graphics become scrambled towards the end of the GAME.SPR file.