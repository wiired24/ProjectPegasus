using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Project_Pegasus
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setting up loop to allow repeated multiple downloads
            while (1 == 1)
            {

                //Create C:/Users/Public/homebrew directory if it doesn't already exist
                System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew");

                // Setting up the design of the Console Interface
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("________________________________________________                          ");
                Console.WriteLine("|                                               |                         ");
                Console.WriteLine("| Project Pegasus - The Xbox One homebrew client|                         ");
                Console.WriteLine("|_______________________________________________|                         ");
                Console.WriteLine("                                                                          ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(" Enjoy Homebrew on Xbox One :-)   -wiired24                               ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                                                                          ");
                Console.WriteLine("---------------------------------------                                   ");
                Console.WriteLine("                                       |");
                Console.WriteLine("   [Emulators for Xbox One]            |");
                Console.WriteLine("1.Chip8     - (Chip 8 Games)           |");
                Console.WriteLine("2.Nesbox    - (NES,SNES,GEN,GB,GBC,GBA)|");
                Console.WriteLine("3.Retrix    - (Libretro for Xbox One)  |");
                Console.WriteLine("4.PPSSPP    - (PSP Games)              |");
                Console.WriteLine("5.VBA10     - (GBA Games)              |");
                Console.WriteLine("6.Win64e10  - (N64 Games)              |");
                Console.WriteLine("                                       |");
                Console.WriteLine("                                       |");
                Console.WriteLine("    [Xbox One Homebrew Games]          |");
                Console.WriteLine("7.Dungeon Run  - 2D Zelda Clone        |");
                Console.WriteLine("8.Hedgephysics - Fan Made Sonic Game   |");
                Console.WriteLine("9.sonic realms - Fan Made Sonic Game   |");
                Console.WriteLine("                                       |");
                Console.WriteLine("                                       |");
                Console.WriteLine("    [Miscellaneous/Tools]              |");
                Console.WriteLine("10. WinIRC - IRC Chat Client           |");
                Console.WriteLine("11.Boxify - Spotify Music Client       |");
                Console.WriteLine("                                       |");
                Console.WriteLine("----------------------------------------");



                // Converting user selection from string to int for the switch block
                string menuChoice_string = Console.ReadLine();
                int menuChoice = Convert.ToInt32(menuChoice_string);



                // Setting uo switch block to handle user selections
                switch (menuChoice)
                {


                    // Using the WebClient Class to connect to the server and download the file to the specified path
                    case 1:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\chip8");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Chip8 from ProjectPegasus Repository Please Wait....");
                        WebClient Client = new WebClient();
                        Client.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_chip8/CHIP8.rar", @"C:\Users\Public\homebrew\chip8\CHIP8.rar");
                        Console.WriteLine("Downloaded Chip8 to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;




                    case 2:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\nesbox");                            
                        Console.ForegroundColor = ConsoleColor.Green;                    
                        Console.WriteLine("Downloading Nesbox from ProjectPegasus Repository Please Wait....");
                        WebClient Client2 = new WebClient();
                        Client2.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_nesbox/Nesbox.zip", @"C:\Users\Public\homebrew\nesbox\Nesbox.zip");
                        Console.WriteLine("Downloaded Nesbox to C:\\Users\\Public\\homebrew Press Enter to Download Again... :-)");
                        Console.ResetColor();
                        break;



                    case 3:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\retrix");                            
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading RetriX from ProjectPegasus Repository please wait....");
                        WebClient Client3 = new WebClient();
                        Client3.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_retrix/RetriX_v1.8.zip", @"C:\Users\Public\homebrew\retrix\RetriX.zip");
                        Console.WriteLine("Downloaded RetriX to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 4:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\ppsspp");                            
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading PPPSSPP from ProjectPegasus Repository Please Wait....");
                        WebClient Client4 = new WebClient();
                        Client4.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_ppsspp/PPSSPP.rar", @"C:\Users\Public\homebrew\ppsspp\PPSSPP.rar");
                        Console.WriteLine("Downloaded PPSSPP to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 5:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\vba10");                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading VBA10 from ProjectPegasus Repository Please Wait....");
                        WebClient Client5 = new WebClient();
                        Client5.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_vba10/VBA10.rar", @"C:\Users\Public\homebrew\vba10\VBA10.rar");
                        Console.WriteLine("Downloaded VBA10 to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 6:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\win64e10");                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Win64e10 from ProjectPegasus Repository Please Wait....");
                        WebClient Client6 = new WebClient();
                        Client6.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_win64e10/Win64e10.zip", @"C:\Users\Public\homebrew\win64e10\Win64e10.zip");
                        Console.WriteLine("Downloaded Win64e10 to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();

                        break;


                    case 7:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\DungeonRun");                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Dungeon Run from ProjectPegasus Repository Please Wait....");
                        WebClient Client7 = new WebClient();
                        Client7.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_dungeon_run/DungeonRUN.zip", @"C:\Users\Public\homebrew\DungeonRun\DungeonRUN.zip");
                        Console.WriteLine("Downloaded Dungeon Run to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 8:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\Hedge-physics");                           
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Hedgephysics from ProjectPegasus Repository Please Wait....");
                        WebClient Client8 = new WebClient();
                        Client8.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_hedge_physics/Hedgephysics.zip", @"C:\Users\Public\homebrew\Hedge-physics\hedgephysics.zip");               
                        Console.WriteLine("Downloaded Hedgephysics to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;

                    case 9:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\sonic-realms");                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading sonic realms from ProjectPegasus Repository Please Wait....");
                        WebClient Client9 = new WebClient();
                        Client9.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_sonic_realms/sonic_realms.zip", @"C:\Users\Public\homebrew\sonic-realms\sonic_realms.zip");
                        Console.WriteLine("Downloaded sonic realms to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;

                    case 10:
                        System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\WinIRC");                        
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading WinIRC from ProjectPegasus Repository Please Wait....");
                        WebClient Client10 = new WebClient();
                        Client10.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_winirc/winirc.zip", @"C:\Users\Public\homebrew\WinIRC\WinIRC.zip");
                        Console.WriteLine("Downloaded WinIRC to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 11:
                    System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\Boxify");                         
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Boxify from ProjectPegasus Repository Please Wait...");
                        WebClient Client11 = new WebClient();
                        Client11.DownloadFile("https://github.com/wiired24/ProjectPegasus/releases/download/appx_boxify/boxify.zip", @"C:\Users\Public\homebrew\Boxify\boxify.zip");
                        Console.WriteLine("Downloaded Boxify to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;
                        
                    case 11:
                    System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\UWPstreamer");                         
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading UWPstreamer from ProjectPegasus Repository Please Wait...");
                        WebClient Client11 = new WebClient();
                        Client11.DownloadFile("https://raw.githubusercontent.com/wiired24/ProjectPegasus/appx_releases/UWPstreamer.zip", @"C:\Users\Public\homebrew\UWPstreamer\UWPstreamer.zip");
                        Console.WriteLine("Downloaded UWP streamer to C:\\Users\\Public\\homebrew Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;    



                    // Throws an Exception if the user pressed an invalid option
                    default:
                        Console.WriteLine("Exception! Invalid Input Try Again");
                        break;



                }

                Console.ReadLine();
            }
        }
    }
}
