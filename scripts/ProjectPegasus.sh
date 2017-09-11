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
                                        | 
    [Xbox One Homebrew Games]           |
g.Dungeon Run - 2D Zelda Clone          |
h.Hedgephysics - Fan made sonic game    |                                  |
i.Sonic Realms - New fan made sonic game|
                                        |
[Miscellaneous/Tools]                   |
j.WinIRC - IRC Chat Client              |
k.Boxify - Spotify Music Client         |
----------------------------------------"
    

while getopts ':abcdefghijk' option; do
  case "$option" in
    h) echo "$usage" >&2
       exit
       ;;
    a) echo "Downloading Chip8!" >&2
       curl -L "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbWpNQ19hUlc4RnM" -o ~/Desktop/chip8.rar
       exit
       ;;
    b) echo "Downloading Nesbox!" >&2
       curl -L "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBcW9xMWw0Wlg2UjQ" -o ~/Desktop/nesbox.rar
       exit
       ;;
    c) echo "Downloading Retrix!" >&2
       curl -L "https://github.com/Aftnet/LibretroRT/releases/download/v1.8/RetriX.UWP_1.8.14.0_x86_x64_arm.appxbundle" -o ~/Desktop/Retrix_v.1.8.zip
       curl -L "https://github.com/Aftnet/LibretroRT/releases/download/v1.8/RetriX.UWP_1.8.14.0_x86_x64_arm.dependencies.zip" -o ~/Desktop/Retrix_v.1.8.dependencies.zip
       exit
       ;;
    d) echo "Downloading PPSSPP!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBRlk3N1BHQkpRYmM" -o ~/Desktop/ppsspp.rar
       exit
       ;;
    e) echo "Downloading VBA10!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBb25qVjJQRE1iUEE" -o ~/Desktop/vba10.rar
       exit
       ;;
    f) echo "Downloading Win64e10!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBTWJPeWhZU0hXRTQ" -o ~/Desktop/win64e10.rar
       exit
	   ;;
    g) echo "Downloading Dungeon Run!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBdmRJajZYazVFR0k" -o ~/Desktop/DungeonRUN1.rar
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBeVo2Y29NMWNJT2c" -o ~/Desktop/DungeonRUN2.rar
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbGFUN1JvT0t1cWs" -o ~/Desktop/DungeonRUN3.rar
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBMk1tbHJObUNXQnM" -o ~/Desktop/DungeonRun4.rar
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBWjBtb1pOVVJId3c" -o ~/Desktop/DungeonRun_README
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
       
	   ;;
	   
   \?) printf "illegal option: -%s\n" "$OPTARG" >&2
       echo "$usage" >&2
       exit 1
       ;;
  esac
done
echo "$usage"
