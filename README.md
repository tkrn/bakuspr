# bakuspr

A utility to extract sprites from the Sega title Baku Baku Animal for PC (1996). 

#### Usage

Ideally, you want to load a color palette file (PAL\\*.bin). If not, the Windows 95 color palette will be the default. Generally speaking, this will result in incorrect color information. 

After the color file is loaded, proceed to load a sprite file (GR\\*.spr). Once the sprite is loaded, click and drag to select sprite files to save as their native bitmap format. 

#### Download

Please download a Windows .NET 4.0 compiled binary at https://github.com/tkrn/bakuspr/releases/latest 

#### Screenshots

[![bakuspr Screenshot](2025-12-11_15-53-45.png)](2025-12-11_15-53-45.png)

#### Technical / Background Information
Thanks to xdaniel on The Cutting Room Floor (tcrf.net) message boards to help reverse engineer the sprite files. With that being said, this is what I've learned about the Baku Baku Animal PC sprite files. The first two bytes are the width, and the following two bytes are the height. You multiply the width and the height to get the data image length. 

This game originally required 256 colors (8-bit) and having the sprite file is merely not enough. A palette file is required for correct color output. There are two types of known Baku Baku PC palette files. One with "VS" in the filename and another one without "VS" in the filename. The files with "VS" are 32 color palette files. The files without "VS" in the name are 112 color palette files.

There is still a missing piece of displaying all the sprites correctly and it's in the GAME.FIX files which primarily pertain to the GAME.SPR file (needs confirmation) but the graphics become scrambled towards the end of the GAME.SPR file.

#### Acknowledgements

* Thanks to xdaniel on the tcrf.net message boards
* Thanks to Sega Retro, which created a similar tool for use with Sonic PC. I reused their palette display code to visualize the loaded palette. See https://github.com/sonicretro/SCDPCTools 
* Thanks to Chris Johanson at Twin Rose Software for his contributions to MemoryBox. See http://www.twinrose.net
* Thanks to Nguyen.H.H.Dang for the base implementation of the Thumbnail Viewer Control. See https://www.codeproject.com/tips/792957/a-simple-thumbnail-viewer-control