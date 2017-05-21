#!/bin/bash
usage="$(basename "$0") [-h] [-n] -- script to download xbox one homebrew

where:
    -h  show this help text
    -n  set what program to download
    
---------------------------------------                                     
                                       |
   [Emulators for Xbox One]            |
a.Chip8     - (Chip 8 Games)           |
b.Nesbox    - (NES,SNES,GEN,GB,GBC,GBA)|
c.PSX-BOX   - (PS1 *Work in Progress*) |
d.PPSSPP    - (PSP Games)              |
e.VBA10     - (GBA Games)              |
f.Win64e10  - (N64 Games)              |
                                       | 
                                       | 
    [Xbox One Indie Games]             |
g.Dungeon Run - 2D Zelda Clone         |
                                       |
                                       |
    [Miscellaneous/Tools]              |
i.WinIRC - IRC Chat Client             |
                                       |
----------------------------------------"
    

while getopts ':abcdefghi' option; do
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
    c) echo "Downloading PSX-BOX!" >&2
       curl -L "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBckdaXzJ0U0dSMVE" -o ~/Desktop/psxbox.zip
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
    i) echo "Downloading WinIRC!" >&2
       curl -L  "https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbGZYTVlmY2ViX1k" -o ~/Desktop/WinIRC.zip
       exit
	   ;;
   \?) printf "illegal option: -%s\n" "$OPTARG" >&2
       echo "$usage" >&2
       exit 1
       ;;
  esac
done
echo "$usage"