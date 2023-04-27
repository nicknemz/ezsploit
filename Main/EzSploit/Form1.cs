using EzSploit.usercontrols;
using FastColoredTextBoxNS;
using KrnlAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using EasyExploits;
using System.IO;
using DiscordRPC.Logging;
using DiscordRPC.Message;
using DiscordRPC;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Threading;
using Oxygen;

namespace EzSploit
{
    public partial class Form1 : Form
    {
        WebClient webClient = new WebClient();

        KrnlApi ezsploitkrnl = new KrnlApi();

        Module ezsploitex = new Module();

        ExploitAPI ezsploitwrd = new ExploitAPI();

        int latestverint;

        int installedverint;

        public DiscordRpcClient client;
        public Form1()
        {
            InitializeComponent();
            ezsploitkrnl.Initialize();
        }
        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds != 0 && milliseconds >= 0)
            {
                timer1.Interval = milliseconds;
                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += delegate
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                };
                while (timer1.Enabled)
                {
                    Application.DoEvents();
                }
            }
        }

        public void injectEzsploit()
        {
            Console.WriteLine("Trying injection...");
            Console.WriteLine(" ");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                ezsploitex.LaunchExploit();
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                ezsploitkrnl.Inject();
               
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                ezsploitwrd.LaunchExploit();
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                API.Inject();
            }
        }
        private void Form1_Load(object sender1, EventArgs e1)
        {
            string latestver = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\versionew.txt");
            string installedver = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt");
            latestverint = int.Parse(latestver);
            installedverint = int.Parse(installedver);
            if (latestverint > installedverint)
            {
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                Thread.Sleep(100);
                Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                Thread.Sleep(50);
                Application.Exit();
            }

                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
                {
                ProcessWatcher processWatcher = new ProcessWatcher("RobloxPlayerBeta");

                processWatcher.Created += (sender, proc) =>
                {
                    Process RobloxProcess = proc;
                    wait(1000);
                    injectEzsploit();
                };
            }


            client = new DiscordRpcClient("1078735530654707772");
            client.Logger = new ConsoleLogger
            {
                Level = LogLevel.Warning
            };
            client.OnReady += delegate (object sender, ReadyMessage e)
            {
                Console.WriteLine("Loaded EzSploit from memory");
                Console.WriteLine("Welcome to EzSploit", e.User.Username);
            };
            client.OnPresenceUpdate += delegate (object sender, PresenceMessage e)
            {
                Console.WriteLine("Discord integration initialized");
                
               
            };
            client.Initialize();
            client.SetPresence(new RichPresence
            {
                Details = "Roblox Script Executor",
                State = "eating kids",
                Timestamps = Timestamps.Now,
                Assets = new Assets
                {
                    LargeImageKey = "https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezsploit5.png"
                },
                Buttons = new DiscordRPC.Button[1]
                {
                new DiscordRPC.Button
                {
                    Label = "Download",
                    Url = "https://sites.google.com/view/mksdv/gry-i-pliki/ezsploit"
                }
                }
            });

            
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UC_WINDOW.Controls.Clear();
            UC_WINDOW.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2GradientCircleButton1_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void guna2GradientCircleButton2_Click(object sender, EventArgs e)
        {
            base.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_WINDOW_Paint(object sender, PaintEventArgs e)
        {

        }
        public void IgnoreExceptions(Action act)
        {
            try
            {
                act.Invoke();
            }
            catch { }
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_main userControl = new uc_main();
            addUserControl(userControl);
            IgnoreExceptions(() => foo());
        }

        private void foo()
        {
            throw new NotImplementedException();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            uc_options userControl = new uc_options();
            addUserControl(userControl);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            uc_info userControl = new uc_info();
            addUserControl(userControl);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            injectEzsploit();
        }
    }
}
