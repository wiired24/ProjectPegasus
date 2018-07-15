using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Media;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
           
              



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

      

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

      
        /// <summary>
        /// Start Editing the Code Here
        /// </summary>
               
        // If the User Selects CHIP8
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\chip8");         
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/ig7bpsxqreaxxxe/CHIP8.rar?dl=1"), @"C:\Users\Public\homebrew\chip8\CHIP8.rar");
            


        }

        // If the User Selects Nesbox
        private void button1_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\nesbox");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/fyagaey5kj7573r/Nesbox.zip?dl=1"), @"C:\Users\Public\homebrew\nesbox\Nesbox.zip");

        }

        // If the User Selects RetriX
        private void button3_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\RetriX");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/pe5pjdm0zkk0lr2/RetriX_v1.8.zip?dl=1"), @"C:\Users\Public\homebrew\RetriX\RetriX.zip");

        }

        // If the User Selects PPSSPP
        private void button4_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\PPSSPP");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/nv1ltltyn4os4ux/PPSSPP.rar?dl=1"), @"C:\Users\Public\homebrew\ppsspp\PPSSPP.rar");

        }

        // If the User Selects VBA10
        private void button5_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\vba10");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/6bz2q9atgocgxlw/VBA10.rar?dl=1"), @"C:\Users\Public\homebrew\vba10\VBA10.rar");

        }

        // If the User Selects Win64e10
        private void button6_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\win64e10");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/84r7dprnxgch61v/Win64e10.zip?dl=1"), @"C:\Users\Public\homebrew\win64e10\Win64e10.zip");
        }

        // If the User Selects DungeonRUN
        private void button7_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\DungeonRun");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/zk4u2i216sh73ef/DungeonRUN.zip?dl=1"), @"C:\Users\Public\homebrew\DungeonRun\DungeonRUN.zip");
        }

        // If the User Selects Hedgephysics
        private void button8_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\Hedge-physics");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/sy5irc7v529h48d/Hedgephysics.zip?dl=1"), @"C:\Users\Public\homebrew\Hedge-physics\hedgephysics.zip");

        }

        // If the User Selects SonicContinuim
        private void button9_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\SonicContinuim");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/tn6cpkvm0bjysvq/sonic_continuim.zip?dl=1"), @"C:\Users\Public\homebrew\SonicContinuim\sonic_continuim.zip");

        }

        // If the User Selects WinIRC
        private void button10_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\WinIRC");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/6lstunaaleu3xpe/winirc.zip?dl=1"), @"C:\Users\Public\homebrew\WinIRC\winirc.zip");

        }

        // If the User Selects Boxify
        private void button11_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\Boxify");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/2981nlpbtun0m29/boxify.zip?dl=1"), @"C:\Users\Public\homebrew\Boxify\boxify.zip");

        }

        // If the User Selects UWPStreamer
        private void button12_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(@"C:\Users\Public\homebrew\UWPstreamer");
            WebClient Client = new WebClient();
            Client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            Client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);
            Client.DownloadFileAsync(new Uri("https://www.dropbox.com/s/cnfxhw4gt843gky/UWPstreamer.zip?dl=1"), @"C:\Users\Public\homebrew\UWPstreamer\UWPstreamer.zip");
            
        }



        // Prints a message and plays a special sound to the user when the Download has completed     
        void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            SystemSounds.Hand.Play();
            MessageBox.Show("Download complete! \nEnjoy Homebrew on Xbox One :)\n\n-wiired24 ");
            
        }
        
        // Updates the Progress Bar as the Download progresses
        void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            progressBar1.Maximum = (int)e.TotalBytesToReceive / 100;
            progressBar1.Value = (int)e.BytesReceived / 100;
        }   
        
        /// <summary>
        /// Stop Here
        /// </summary>
       

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
