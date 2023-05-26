using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DiscordRPC;
using EasyExploits;
using EzSploit.Properties;
using KrnlAPI;
using WeAreDevs_API;

namespace EzSploit.usercontrols
{
    public partial class uc_options : UserControl
    {

        KrnlApi ezsploitkrnl = new KrnlApi();

        Module ezsploitex = new Module();

        ExploitAPI ezsploitwrd = new ExploitAPI();

        WebClient webClient = new WebClient();

        string internalui = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/nicknemz/internalufd/main/EzSploitINT.lua\", true))()";

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int inject_dll();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int run_script(string script);

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int set_obs(bool setting);
        public uc_options()
        {
            InitializeComponent();

            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
            {
                BackgroundImage = Resources._0_0_0;
            } else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skull_emoji")
            {
                BackgroundImage = Resources.options;
            }

            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                guna2Button6.CustomBorderColor = Color.White;
            } 
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                guna2Button7.CustomBorderColor = Color.White;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                guna2Button8.CustomBorderColor = Color.White;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                guna2Button11.CustomBorderColor = Color.White;
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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            ezsploitex.killRoblox();
            Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
            for (int i = 0; i < processesByName.Length; i++)
            {
                processesByName[i].Kill();
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "c:\\mikusdevPrograms\\ezsploit");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "c:\\mikusdevPrograms\\ezsploit\\workspace");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", "c:");
            MessageBox.Show("easyexploits is in folder named like 'furk ultra' or something");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            Process.Start("explorer.exe", folderPath + "\\Krnl\\workspace");
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "WRD");
            guna2Button6.CustomBorderColor = Color.White;
            guna2Button7.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button8.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button11.CustomBorderColor = Color.FromArgb(30, 30, 30);
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "EasyExploits");
            guna2Button6.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button7.CustomBorderColor = Color.White;
            guna2Button8.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button11.CustomBorderColor = Color.FromArgb(30, 30, 30);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "Krnl");
            guna2Button6.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button7.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button8.CustomBorderColor = Color.White;
            guna2Button11.CustomBorderColor = Color.FromArgb(30, 30, 30);
        }

        private void uc_options_Load(object sender, EventArgs e)
        {
            autoinjbutton.Text = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned on")
            {
                autoinjbutton.ForeColor = System.Drawing.Color.Green;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt") == "Turned off")
            {
                autoinjbutton.ForeColor = System.Drawing.Color.Red;
            }
            
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            string path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            if (path == "Turned off")
            {
                autoinjbutton.Text = "Turned on";
                autoinjbutton.ForeColor = System.Drawing.Color.Green;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned on");
                wait(100);
                path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            }
            else if (path == "Turned on")
            {
                autoinjbutton.Text = "Turned off";
                autoinjbutton.ForeColor = System.Drawing.Color.Red;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned off");
                wait(100);
                path = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt");
            }
            var message = "You need to restart ezsploit to turn on/off auto inject. Do you want to restart?";
            var title = "EzSploit notification";
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void guna2Button9_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\Configs\selectedTheme.txt", "classic");
            BackgroundImage = Resources._0_0_0;
        }

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                ezsploitex.ExecuteScript(internalui);
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                ezsploitkrnl.Execute(internalui);
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                ezsploitwrd.SendLuaScript(internalui);
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                run_script(internalui);
            }
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "Oxygen");
            guna2Button6.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button7.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button8.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button11.CustomBorderColor = Color.White;
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
            Thread.Sleep(100);
            Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
            Thread.Sleep(50);
            Application.Exit();
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            var message = "KRNL key bypass will take about 1 minute, just do captcha and click continue on KRNL.place websites, but if you are on linkversite then click yes on next notifications. Do you want to start?";
            var title = "EzSploit notification";
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    Console.WriteLine("Starting bypass! Dont do anything in ezsploit, it can now easily crash");
                    System.Diagnostics.Process.Start("https://cdn.krnl.place/getkey");
                    var message1 = "Click 'yes' if you are on first linkversite";
                    var title1 = "EzSploit notification";
                    var result1 = MessageBox.Show(
                        message1,
                        title1,
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question);

                    switch (result1)
                    {
                        case DialogResult.Yes:
                            Console.WriteLine("]Bypassing step 1, wait for next checkpoint");
                            wait(16000);
                            System.Diagnostics.Process.Start("https://cdn.krnl.place/getkey_games");
                            var message2 = "Click 'yes' if you are on second linkversite";
                            var title2 = "EzSploit notification";
                            var result2 = MessageBox.Show(
                                message,
                                title,
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

                            switch (result2)
                            {
                                case DialogResult.Yes:
                                    Console.WriteLine("]Bypassing step 2, wait for next checkpoint");
                                    wait(16000);
                                    System.Diagnostics.Process.Start("https://cdn.krnl.place/getkey_interface");
                                    var message3 = "Click 'yes' if you are on third linkversite";
                                    var title3 = "EzSploit notification";
                                    var result3 = MessageBox.Show(
                                        message3,
                                        title3,
                                        MessageBoxButtons.YesNo,
                                        MessageBoxIcon.Question);

                                    switch (result3)
                                    {
                                        case DialogResult.Yes:
                                            Console.WriteLine("]Bypassing step 3, wait for next checkpoint");
                                            wait(16000);
                                            System.Diagnostics.Process.Start("https://cdn.krnl.place/getkey_scripts");
                                            var message4 = "Click 'yes' if you are on fourth linkversite";
                                            var title4 = "EzSploit notification";
                                            var result4 = MessageBox.Show(
                                                message4,
                                                title4,
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Question);

                                            switch (result4)
                                            {
                                                case DialogResult.Yes:
                                                    Console.WriteLine("]Bypassing step 4, wait for next checkpoint");
                                                    wait(16000);
                                                    System.Diagnostics.Process.Start("https://cdn.krnl.place/getkey.php");
                                                    Console.WriteLine("Bypass stopped");
                                                    break;
                                                case DialogResult.No:
                                                    break;
                                            }
                                            break;
                                        case DialogResult.No:
                                            break;
                                    }

                                    break;
                                case DialogResult.No:
                                    break;
                            }
                            break;
                        case DialogResult.No:
                            break;
                    }
                    break;
                case DialogResult.No:
                    break;
            }
            
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            var message = "Oxygen key bypass will take 20 seconds, just look on EzSploit Console and wait for 'bypass stopped' line to show, then key should appear on your web browser. Do you want to start bypassing?";
            var title = "EzSploit notification";
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    Console.WriteLine("Starting bypass! Dont do anything in ezsploit, it can now easily crash");
                    System.Diagnostics.Process.Start("https://linkvertise.com/133881/sdfdsa5f664d65z?o=sharing");
                    wait(5000);
                    System.Diagnostics.Process.Start("https://oxygenu.xyz/KeySystem/Check1.php");
                    wait(7000);
                    System.Diagnostics.Process.Start("https://oxygenu.xyz/KeySystem/Main.php");
                    Console.WriteLine("Bypass stopped");
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\Configs\selectedTheme.txt", "skull_emoji");
            BackgroundImage = Resources.options;
        }

        private void guna2Button22_Click(object sender, EventArgs e)
        {
            var message = "Fix Update will fix missing error files, but it will delete: ScriptTabs, configs. Your saved scripts will be preserved. I reccomend you to hit 'ReDownload' button after this action.";
            var title = "EzSploit notification";
            var result = MessageBox.Show(
                message,
                title,
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (result)
            {
                case DialogResult.Yes:
                    Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
                    if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                    {
                        Directory.Delete(@"c:\mikusdevPrograms\ezsploit\updatetemp", true);
                    }
                    wait(500);
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void guna2Button23_Click(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "selery");
            guna2Button6.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button7.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button8.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button11.CustomBorderColor = Color.FromArgb(30, 30, 30);
        }

        private void guna2Button23_Click_1(object sender, EventArgs e)
        {
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "selery");
            guna2Button6.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button7.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button8.CustomBorderColor = Color.FromArgb(30, 30, 30);
            guna2Button11.CustomBorderColor = Color.FromArgb(30, 30, 30);
        }
    }
}
