using EzSploit.usercontrols;
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
using System.Reflection;
using System.Security.Cryptography;
using EzSploit.Properties;
using static DiscordRPC.User;
using System.IO.Compression;
using System.Runtime.InteropServices;

namespace EzSploit
{
    public partial class Form1 : Form
    {
        WebClient webClient = new WebClient();

        KrnlApi ezsploitkrnl = new KrnlApi();

        EasyExploits.Module ezsploitex = new EasyExploits.Module();

        ExploitAPI ezsploitwrd = new ExploitAPI();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int inject_dll();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int run_script(string script);

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int set_obs(bool setting);

        


        public DiscordRpcClient client;
        public Form1()
        {
            InitializeComponent();
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
            {
                BackgroundImage = Resources._0_0_0;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skull_emoji")
            {
                BackgroundImage = Resources.textbox;
            }
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
            Console.WriteLine("Trying inject...");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                ezsploitex.LaunchExploit();
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                ezsploitkrnl.Initialize();
                wait(500);
                ezsploitkrnl.Inject();

            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                ezsploitwrd.LaunchExploit();
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                Console.WriteLine("Checking oxygenU key");
                oxygenkeysystem f2 = new oxygenkeysystem();
                f2.ShowDialog(); // Shows Form2


                Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
                if (processesByName.Length == 0)
                {
                    
                    Console.WriteLine("]Please Open the Roblox Microsoft Store version before injecting Oxygen U!");
                    
                    return;
                }
                new Thread((ThreadStart)async delegate
                {
                    Console.WriteLine("]Downloading DLL...");
                    ProcessModule mainModule = Process.GetProcessById(processesByName[0].Id).MainModule;
                    try
                    {
                        webClient.DownloadFile("https://oxygenu.xyz/windows/dll/575.dll", "c:\\mikusdevPrograms\\ezsploit\\oxygen.dll");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("]Download error!");
                    }
                    Console.WriteLine("]Injecting...");
                    switch (inject_dll())
                    {
                        case 0:
                            {
                                Console.WriteLine("Injected");
                            }
                            break;
                            
                        case 1:
                            {
                                Console.WriteLine("Dll not found");
                            }
                            break;
                        case 2:
                            {
                                Console.WriteLine("Roblox not found");
                            }
                            break;
                        case 4:
                            {
                                Console.WriteLine("An unknown error occured");
                            }
                            break;
                    }
                }).Start();
            }
            
        }
        private void Form1_Load(object sender1, EventArgs e1)
        {

                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
                {
                ProcessWatcher processWatcher = new ProcessWatcher("Windows10Universal");

                processWatcher.Created += (sender, proc) =>
                {
                    Process RobloxProcess = proc;
                    Console.WriteLine("Auto inject found roblox process!");
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
               Console.WriteLine("Loaded Discord API");
                
            };
            client.OnPresenceUpdate += delegate (object sender, PresenceMessage e)
            {
                Console.WriteLine("Discord integration initialized");
                
               
            };
            client.Initialize();
            client.SetPresence(new RichPresence
            {
                Details = "Roblox Script Executor",
                State = "join discord plz",
                Timestamps = Timestamps.Now,
                Assets = new Assets
                {
                    LargeImageKey = "https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/ezsploit5.png"
                },
                Buttons = new DiscordRPC.Button[2]
                {
                    new DiscordRPC.Button
                    {
                        Label = "Download",
                        Url = "https://mikusgszyp.github.io/ezsploit/"
                    },
                    new DiscordRPC.Button
                    {
                        Label = "Discord",
                        Url = "https://discord.gg/JJ4Qpe9gSC"
                    }
                }
            }) ;

            
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
            foreach (Process process in Process.GetProcessesByName("tmp"))
            {
                process.Kill();
            }
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
 


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uc_main userControl = new uc_main();
            addUserControl(userControl);
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

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            games userControl = new games();
            addUserControl(userControl);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        { 
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
