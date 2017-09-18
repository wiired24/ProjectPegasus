#!/bin/bash
usage="$(basename "$0") [-h] [-n] -- script to download xbox one homebrew

where:
    -h  show this help text
    -n  set what program to download
    
---------------------------------------                                     
                                        |
   [Emulators for Xbox One]             |
a.Chip8     - (Chip 8 Games)            |
b.Nesbox    - (NES,SNES,GEN,GB,GBC,GBA) |
c.Retrix    - (Libretro Port)           |
d.PPSSPP    - (PSP Games)               |
e.VBA10     - (GBA Games)               |
f.Win64e10  - (N64 Games)               |
                                        |  
    [Xbox One Homebrew Games]           |
g.Dungeon Run - 2D Zelda Clone          |
h.Hedgephysics - Fan made sonic game    |                                  |
i.Sonic Realms - New fan made sonic game|
                                        |
[Miscellaneous/Tools]                   |
j.WinIRC - IRC Chat Client              |
k.Boxify - Spotify Music Client         |
l.UWPStreamer - Stream 3DS to XB1       |
----------------------------------------"
    

while getopts ':abcdefghijkl' option; do
  case "$option" in
    h) echo "$usage" >&2
       exit
       ;;
    a) echo "Downloading Chip8!" >&2
       curl -L "https://github.com/wiired24/ProjectPegasus/releases/download/appx_chip8/CHIP8.rar" -o ~/Desktop/chip8.rar
       exit
       ;;
    b) echo "Downloading Nesbox!" >&2
       curl -L "https://github.com/wiired24/ProjectPegasus/releases/download/appx_nesbox/Nesbox.zip" -o ~/Desktop/nesbox.zip
       exit
       ;;
    c) echo "Downloading Retrix!" >&2
       curl -L "https://github.com/wiired24/ProjectPegasus/releases/download/appx_retrix/RetriX_v1.8.zip" -o ~/Desktop/Retrix.zip
       
       exit
       ;;
    d) echo "Downloading PPSSPP!" >&2
       curl -L  "https://github.com/wiired24/ProjectPegasus/releases/download/appx_ppsspp/PPSSPP.rar" -o ~/Desktop/PPSSPP.rar
       exit
       ;;
    e) echo "Downloading VBA10!" >&2
       curl -L  "https://github.com/wiired24/ProjectPegasus/releases/download/appx_vba10/VBA10.rar" -o ~/Desktop/VBA10.rar
       exit
       ;;
    f) echo "Downloading Win64e10!" >&2
       curl -L  "https://github.com/wiired24/ProjectPegasus/releases/download/appx_win64e10/Win64e10.zip" -o ~/Desktop/Win64e10.zip
       exit
	   ;;
    g) echo "Downloading Dungeon Run!" >&2
       curl -L  "https://github.com/wiired24/ProjectPegasus/releases/download/appx_dungeon_run/DungeonRUN.zip" -o ~/Desktop/DungeonRUN.zip
     
       exit
       ;;
    
    h) echo "Downloading Hedgephysics!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBN29vb18ycHM0djg" -o ~/Desktop/Hedgephysics_part1.zip
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBSTlzeWFqanhMWGc" -o ~/Desktop/Hedgephysics_part2.zip
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBd0JNRkhMRFVBZ1U" -O ~/Desktop/Hedgephysics_part3.zip
       exit
       ;;
    
    i) echo "Downloading Sonic Realms!" >&2
       curl -L  "https://github.com/tunip3/ProjectPegasus/releases/download/0.00000000001/Sonic.Realms_1.0.1.0_x64_Master.appxbundle" -o ~/Desktop/SonicRealms.appxbundle
       exit
       ;;
    
    
    
    
    j) echo "Downloading WinIRC!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbGZYTVlmY2ViX1k" -o ~/Desktop/WinIRC.zip
       exit
       ;;
       
    k) echo "Downloading Boxify!" >&2
       curl -L "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBWTYxYW0tNFFTRjQ" -o ~/Desktop/Boxify.zip
       exit
       
       
     l) echo "Downloading UWPStreamer!" >&2
       curl -L "https://raw.githubusercontent.com/wiired24/ProjectPegasus/appx_releases/UWPstreamer.zip" -o ~/Desktop/UWPStreamer.zip
       exit
              
	   ;;
	   
   \?) printf "illegal option: -%s\n" "$OPTARG" >&2
       echo "$usage" >&2
       exit 1
       ;;
  esac
done
echo "$usage"
