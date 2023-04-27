using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzSploit
{
    internal static class Program
    {
        /// <summary>
        /// Główny punkt wejścia dla aplikacji.
        /// </summary>
        [STAThread]
        static void Main()
        {
            WebClient webClient = new WebClient();
            string bckapi;
            string bcktextbox;
            string bcktheme;
            string bckautoinj;
            string instver = "60";
            string lastver = webClient.DownloadString("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt");
            Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit");
            
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
            {
                Thread.Sleep(50);
            }
            Console.WriteLine("Checking version..");
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt", instver);
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt", "c:\\mikusdevPrograms\\ezsploit\\versionew.txt");
            Console.WriteLine("]Installed Version: ", instver);
            Console.WriteLine("]Newest Version: ", lastver);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: true);
            Console.WriteLine("Downloading Runtime DLL's");
            Console.WriteLine("]Downloading Guna.UI2.dll");
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Guna.UI2.dll", "c:\\mikusdevPrograms\\ezsploit\\Guna.UI2.dll");
            Console.WriteLine("]Downloading FastColoredTextBox.dll");
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/FastColoredTextBox.dll", "c:\\mikusdevPrograms\\ezsploit\\FastColoredTextBox.dll");
            Console.WriteLine("]Downloading DiscordRPC.dll"); 
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/DiscordRPC.dll", "c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll");
            Console.WriteLine("]Downloading Newtonsoft.Json.dll"); 
            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Newtonsoft.Json.dll", "c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll");

            if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\Configs"))
            {
                Console.WriteLine("]Triggered redownload by user/update");
                Console.WriteLine("]]Downloading WeAreDevs_API.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/WeAreDevs_API.dll", "c:\\mikusdevPrograms\\ezsploit\\WeAreDevs_API.dll");
                Console.WriteLine("]]Downloading EasyExploits.dll"); 
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EasyExploits.dll", "c:\\mikusdevPrograms\\ezsploit\\EasyExploits.dll");
                Console.WriteLine("]]Downloading KrnlAPI.dll"); 
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/KrnlAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\KrnlAPI.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/krnl.dll", "c:\\mikusdevPrograms\\ezsploit\\krnl.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/injector.dll", "c:\\mikusdevPrograms\\ezsploit\\injector.dll");
                Console.WriteLine("]]Downloading Oxygen_API.dll"); 
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Oxygen_API.dll", "c:\\mikusdevPrograms\\ezsploit\\Oxygen API.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Oxygen_API.dll", "c:\\mikusdevPrograms\\ezsploit\\Oxygen_API.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/oxygen.dll", "c:\\mikusdevPrograms\\ezsploit\\oxygen.dll");
                if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                {
                    bckapi = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedAPI.txt");
                    bcktextbox = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\textboxconf.txt");
                    bcktheme = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedTheme.txt");
                    bckautoinj = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\autoinject.txt");
                    Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Configs");
                    Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Scripts");
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt"))
                    {
                    }
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt", bcktheme);
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", bckapi);
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", bcktextbox);
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", bckautoinj);
                    
                    
                    Thread.Sleep(100);
                    Directory.Delete(@"c:\mikusdevPrograms\ezsploit\updatetemp", true);
                    Thread.Sleep(100);
                    Console.WriteLine("Restored Configs!");
                    Console.WriteLine("Close this windows and launch EzSploit again");
                    Console.ReadKey();
                    return;
                }
                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Configs");
                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit\\Scripts");
                using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt"))
                {
                }
                using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt"))
                {
                }
                using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt"))
                {
                }
                using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt"))
                {
                }
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt", "classic");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", "Turned off");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", "WeAreDevs");
                Console.WriteLine("Configs set to def!");
                
            }
            Application.Run(new Form1());
        }
    }
}
