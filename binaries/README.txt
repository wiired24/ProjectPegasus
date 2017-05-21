<wiired24>

(This is Windows Specific Doesn't Apply in Linux or Mac)

--------------------------
          Windows            
--------------------------

Your homebrew will be download and installed to C:\Users\Public\homebrew
If you have not already created a folder one will be made for you.


--------------------------
         Linux/Mac
--------------------------
Note: For Linux and Mac systems we recommend you instead you use the script in the "scripts" directory.
It is much easier to work with and doesn't require as many steps. However if you insist on using the native
client on your Linux/Mac system you may keep reading on to find out how.

(Linux and Mac specific Doesn't Apply in Windows)
In order to run you will need to download and install mono. 
Just do sudo apt-get install mono. To run the client just cd into
the binaries folder and run in the terminal  mono  Project_Pegasus.exe
For extracting the files I recommend either unzip or unrar. 

Note: In order to extract the download archive from the terminal with unrar or unzip 
make sure and add an extra / in the path. So for instance if you download psx-box instead of
typing unzip C:\Users\Public\psx-box-master.zip  

You would type
unzip C:\\Users\\Public\\psx-box-master.zip 


-------------------------
       A few tips
-------------------------

There are some minor issues with PPSSPP however they are well known
and can easily be fixed. 

Problem #1: The O button keeps bringing up the menu
Solution: Map LT to the O button in Settings.

Problem #2: The Emulator isn't full screen
Solution: On the Xbox One go to Settings --> Display and Sound --> Video output
Then deselect the option that says "Apps can add a border" Now it will be full screen

Further Instructions on sideloading APPX Packages can be found in the "Installing APPX Packages" PDF


Enjoy :)
