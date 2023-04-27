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

namespace EzSploit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Thread.Sleep(2000);
            Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
            Thread.Sleep(1000);
            DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");

            using (var client = new WebClient())
            {
                Thread.Sleep(100);
                client.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
            }
        }
        string destkop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        private void CreateShortcut()
        {
            object shDesktop = (object)"Desktop";
            WshShell shell = new WshShell();
            string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\EzSploit.lnk";
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
            shortcut.Description = "EzSploit shortcut";
            shortcut.Hotkey = "Ctrl+Shift+N";
            shortcut.TargetPath = @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe";
            shortcut.WorkingDirectory = @"c:\mikusdevPrograms\ezsploit";
            shortcut.Save();
        }

        public static void CreateStartMenuShortcut()
        {
            string programs_path = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
            string shortcutFolder = Path.Combine(programs_path, @"mikusdev");
            if (!Directory.Exists(shortcutFolder))
            {
                Directory.CreateDirectory(shortcutFolder);
            }
            WshShell shellClass = new WshShell();
            //Create First Shortcut for Application Settings
            string settingsLink = Path.Combine(shortcutFolder, "EzSploit.lnk");
            IWshShortcut shortcut = (IWshShortcut)shellClass.CreateShortcut(settingsLink);
            shortcut.TargetPath = @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe";
            shortcut.WorkingDirectory = @"c:\mikusdevPrograms\ezsploit";
            shortcut.Description = "EzSploit shortcut";
            shortcut.Save();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                
                Thread.Sleep(100);
                client.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var client1 = new WebClient())
            {
                client1.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");

                CreateShortcut();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var client1 = new WebClient())
            {
                client1.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");

                CreateStartMenuShortcut();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (var client1 = new WebClient())
            {
                client1.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                Thread.Sleep(100);
                Application.Exit();
            }
        }
    }
}
