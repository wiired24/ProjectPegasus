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
                Console.WriteLine(" # Note: If running Windows your homebrew will be downloaded to");
                Console.WriteLine(" C:\\Users\\Public\\homebrew. You should look there for your files");
                Console.WriteLine(" If you haven't already created this directory one will be made for you.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                                                                          ");
                Console.WriteLine("---------------------------------------                                     ");
                Console.WriteLine("                                       |");
                Console.WriteLine("   [Emulators for Xbox One]            |");
                Console.WriteLine("1.Chip8     - (Chip 8 Games)           |");
                Console.WriteLine("2.Nesbox    - (NES,SNES,GEN,GB,GBC,GBA)|");
                Console.WriteLine("3.PSX-BOX   - (PS1 *Work in Progress*) |");
                Console.WriteLine("4.PPSSPP    - (PSP Games)              |");
                Console.WriteLine("5.VBA10     - (GBA Games)              |");
                Console.WriteLine("6.Win64e10  - (N64 Games)              |");
                Console.WriteLine("                                       | ");
                Console.WriteLine("                                       | ");
                Console.WriteLine("    [Xbox One Indie Games]             |");
                Console.WriteLine("7.Dungeon Run - 2D Zelda Clone         |");
                Console.WriteLine("                                       |");
                Console.WriteLine("                                       |");
                Console.WriteLine("    [Miscellaneous/Tools]              |");
                Console.WriteLine("8.WinIRC - IRC Chat Client             |");
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
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Chip8 Please Wait....");
                        WebClient Client = new WebClient();
                        Client.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbWpNQ19hUlc4RnM", @"C:\Users\Public\homebrew\CHIP8_XBOX_ONE_V3.rar");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;




                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Nesbox Please Wait....");
                        WebClient Client2 = new WebClient();
                        Client2.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBcW9xMWw0Wlg2UjQ", @"C:\Users\Public\homebrew\NESBOX+RELEASE2+APPX+PKG.rar");
                        Console.WriteLine("Succesfully Downloaded Press Enter to Download Again...... :-)");
                        Console.ResetColor();
                        break;



                    case 3:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading PSX-BOX Please Wait....");
                        WebClient Client3 = new WebClient();
                        Client3.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBckdaXzJ0U0dSMVE", @"C:\Users\Public\homebrew\psx-box-master.zip");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 4:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading PPPSSPP Please Wait....");
                        WebClient Client4 = new WebClient();
                        Client4.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBRlk3N1BHQkpRYmM", @"C:\Users\Public\homebrew\PPSSPP+Release+APPX+PKG.rar");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 5:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading VBA10 Please Wait....");
                        WebClient Client5 = new WebClient();
                        Client5.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBb25qVjJQRE1iUEE", @"C:\Users\Public\homebrew\VBA10_1.22.197.0_Test.rar");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 6:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Win64e10 Please Wait....");
                        WebClient Client6 = new WebClient();
                        Client6.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBTWJPeWhZU0hXRTQ", @"C:\Users\Public\homebrew\Win64e10+PKG.rar");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();

                        break;


                    case 7:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading Dungeon Run Please Wait....");
                        WebClient Client7 = new WebClient();
                        Client7.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBdmRJajZYazVFR0k", @"C:\Users\Public\homebrew\DungeonRUN1.rar");
                        Client7.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBeVo2Y29NMWNJT2c", @"C:\Users\Public\homebrew\DungeonRUN2.rar");
                        Client7.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbGFUN1JvT0t1cWs", @"C:\Users\Public\homebrew\DungeonRUN3.rar");
                        Client7.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBMk1tbHJObUNXQnM", @"C:\Users\Public\homebrew\DungeonRun4.rar");
                        Client7.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBWjBtb1pOVVJId3c", @"C:\Users\Public\homebrew\DungeonRun_README");
                        Console.WriteLine("Succesfully Downloaded..... Press Enter to Download Again :-)");
                        Console.ResetColor();
                        break;


                    case 8:
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Downloading WinIRC Please Wait....");
                        WebClient Client8 = new WebClient();
                        Client8.DownloadFile("https://drive.google.com/uc?export=download&id=0B6C6WFjsJozBbGZYTVlmY2ViX1k", @"C:\Users\Public\homebrew\WinIRC.zip");
                        Console.WriteLine("Succesfully Downloaded.... Press Enter to Download Again :-)");
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
