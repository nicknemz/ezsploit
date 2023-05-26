using IWshRuntimeLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzSploit_Launcher
{
    public partial class updating : Form
    {

        string textboxtext;
        string selectedapi;
        string selectedtheme;
        string autoinj;
        string script2;
        string script3;
        string script4;
        string script5;
        string script6;
        string script7;
        string script1text;
        string script2text;
        string script3text;
        string script4text;
        string script5text;
        string script6text;
        string script7text;

        WebClient webClient = new WebClient();
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public updating()
        {
            InitializeComponent();

            wait(500);

            string configsfolder = @"c:\mikusdevPrograms\ezsploit";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (Directory.Exists(configsfolder))
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");

                

                return;
            }
            DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");
            
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
        }
        

        Point lastPoint;
        private void Form1_Load(object sender, EventArgs e)

        {
            wait(500);
            System.IO.File.Delete(@"c:\mikusdevPrograms\ezsploit\version.txt");
            wait(500);
            if (System.IO.File.Exists(@"c:\mikusdevPrograms\ezsploit\versionew.txt"))
            {
                System.IO.File.Move(@"c:\mikusdevPrograms\ezsploit\versionew.txt", @"c:\mikusdevPrograms\ezsploit\version.txt");
                wait(500);
            }
            
            DirectoryInfo di1 = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit\updatetemp");

            textboxtext = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\textboxconf.txt");
            selectedapi = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\selectedAPI.txt");
            selectedtheme = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\selectedTheme.txt");
            autoinj = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\autoinject.txt");
            script2 = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script2.txt");
            script3 = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script3.txt");
            script4 = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script4.txt");
            script5 = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script5.txt");
            script6 = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script6.txt");
            script7 = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script7.txt");
            script1text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script1text.txt");
            script2text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script2text.txt");
            script3text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script3text.txt");
            script4text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script4text.txt");
            script5text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script5text.txt");
            script6text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script6text.txt");
            script7text = System.IO.File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\Configs\script7text.txt");

            using (FileStream fs = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\textboxconf.txt"))
            using (FileStream fs2 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedAPI.txt"))
            using (FileStream fs3 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedTheme.txt"))
            using (FileStream fs4 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\autoinject.txt"))

            using (FileStream fs23 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script1.txt"))
            using (FileStream fs22 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script2.txt"))
            using (FileStream fs32 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script3.txt"))
            using (FileStream fs42 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script4.txt"))
            using (FileStream fs221 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script5.txt"))
            using (FileStream fs321 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script6.txt"))
            using (FileStream fs421 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script7.txt"))
            using (FileStream fs233 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script1text.txt"))
            using (FileStream fs223 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script2text.txt"))
            using (FileStream fs323 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script3text.txt"))
            using (FileStream fs432 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script4text.txt"))
            using (FileStream fs2231 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script5text.txt"))
            using (FileStream fs3321 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script6text.txt"))
            using (FileStream fs4321 = System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\updatetemp\script7text.txt"))
            wait(100);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\textboxconf.txt", textboxtext);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedAPI.txt", selectedapi);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedTheme.txt", selectedtheme);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\autoinject.txt", autoinj);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script2.txt", script2);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script3.txt", script3);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script4.txt", script4);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script5.txt", script5);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script6.txt", script6);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script7.txt", script7);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script1text.txt", script1text);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script2text.txt", script2text);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script3text.txt", script3text);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script4text.txt", script4text);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script5text.txt", script5text);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script6text.txt", script6text);
            System.IO.File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script7text.txt", script7text);


            Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
            wait(200);
            completed f2 = new completed();
            f2.ShowDialog();

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void pictureBox1_LoadProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_LoadCompleted_1(object sender, AsyncCompletedEventArgs e)
        {
        }
    }
}

