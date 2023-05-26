using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(defaultValue: true);
            try
            {
                
                string bckapi;
                string bcktextbox;
                string bcktheme;
                string bckautoinj;

                string bckscript1;
                string bckscript2;
                string bckscript3;
                string bckscript4;
                string bckscript5;
                string bckscript6;
                string bckscript7;
                string bckscript1text;
                string bckscript2text;
                string bckscript3text;
                string bckscript4text;
                string bckscript5text;
                string bckscript6text;
                string bckscript7text;



                Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit");

                Console.WriteLine("IF EZSPLOIT IS DROPPING FILE ERRORS, THEN RENAME 'Configs' folder to 'updatetemp' in ezsploit directory");

                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt", "c:\\mikusdevPrograms\\ezsploit\\versionew.txt");
                int version = int.Parse(File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt"));
                int lastversion = int.Parse(File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\versionew.txt"));
                if (version < lastversion)
                {
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    Thread.Sleep(100);
                    Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    Thread.Sleep(50);
                    Application.Exit();
                }
               
                Console.WriteLine("Downloading Runtime DLL's");
                Console.WriteLine("]Downloading Guna.UI2.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Guna.UI2.dll", "c:\\mikusdevPrograms\\ezsploit\\Guna.UI2.dll");
                Console.WriteLine("]Downloading DiscordRPC.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/DiscordRPC.dll", "c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll");
                Console.WriteLine("]Downloading Newtonsoft.Json.dll");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Newtonsoft.Json.dll", "c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll");
                if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\runtimes"))
                {
                    Console.WriteLine("]]Downloading runtimes.zip");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/runtimes.zip", "c:\\mikusdevPrograms\\ezsploit\\runtimes.zip");
                    Console.WriteLine("]]Extracting runtimes.zip");
                    ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\runtimes.zip", "c:\\mikusdevPrograms\\ezsploit");
                }
                if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\oxygen_injector.dll"))
                {
                    Console.WriteLine("]Downloading oxygen_injector.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/oxygen_injector.dll", "c:\\mikusdevPrograms\\ezsploit\\oxygen_injector.dll");
                }
                if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\oxygen_auth.dll"))
                {
                    Console.WriteLine("]Downloading oxygen_auth.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/oxygen_auth.dll", "c:\\mikusdevPrograms\\ezsploit\\oxygen_auth.dll");
                }
                if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Core.dll"))
                {
                    Console.WriteLine("]Downloading Microsoft.Web.WebView2.Core.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Microsoft.Web.WebView2.Core.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.Core.dll");
                }
                if (!File.Exists("c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.WinForms.dll"))
                {
                    Console.WriteLine("]Downloading Microsoft.Web.WebView2.WinForms.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Microsoft.Web.WebView2.WinForms.dll", "c:\\mikusdevPrograms\\ezsploit\\Microsoft.Web.WebView2.WinForms.dll");
                }
                if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\Configs"))
                {
                    Console.WriteLine("]Triggered redownload by user/update");
                    Console.WriteLine("]]Downloading WeAreDevs_API.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/WeAreDevs_API.dll", "c:\\mikusdevPrograms\\ezsploit\\WeAreDevs_API.dll");
                    Console.WriteLine("]]Downloading EasyExploits.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EasyExploits.dll", "c:\\mikusdevPrograms\\ezsploit\\EasyExploits.dll");
                    Console.WriteLine("]]Downloading KrnlAPI.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/KrnlAPI.dll", "c:\\mikusdevPrograms\\ezsploit\\KrnlAPI.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/injector.dll", "c:\\mikusdevPrograms\\ezsploit\\injector.dll");
                    Console.WriteLine("]]Downloading Oxygen_API.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Oxygen_API.dll", "c:\\mikusdevPrograms\\ezsploit\\Oxygen API.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Oxygen_API.dll", "c:\\mikusdevPrograms\\ezsploit\\Oxygen_API.dll");
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/oxygen.dll", "c:\\mikusdevPrograms\\ezsploit\\oxygen.dll");

                    if (!Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
                    {
                        Console.WriteLine("]]Downloading monaco-editor.zip");
                        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
                        Console.WriteLine("]]Extracting monaco-editor.zip");
                        ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit");
                    }
                    
                    if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                    {
                        bckapi = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedAPI.txt");
                        bcktextbox = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\textboxconf.txt");
                        bcktheme = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\selectedTheme.txt");
                        bckautoinj = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\autoinject.txt");
                        bckscript2 = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script2.txt");
                        bckscript3 = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script3.txt");
                        bckscript4 = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script4.txt");
                        bckscript5 = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script5.txt");
                        bckscript6 = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script6.txt");
                        bckscript7 = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script7.txt");
                        bckscript1text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script1text.txt");
                        bckscript2text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script2text.txt");
                        bckscript3text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script3text.txt");
                        bckscript4text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script4text.txt");
                        bckscript5text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script5text.txt");
                        bckscript6text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script6text.txt");
                        bckscript7text = File.ReadAllText(@"c:\mikusdevPrograms\ezsploit\updatetemp\script7text.txt");

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
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt"))
                        {
                        }
                        using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt"))
                        {
                        }
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt", bcktheme);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt", bckapi);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", bcktextbox);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\autoinject.txt", bckautoinj);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", bckscript2);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", bckscript3);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", bckscript4);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", bckscript5);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", bckscript6);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", bckscript7);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt", bckscript1text);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", bckscript2text);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", bckscript3text);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", bckscript4text);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", bckscript5text);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", bckscript6text);
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", bckscript7text);
                        Thread.Sleep(100);
                        Directory.Delete(@"c:\mikusdevPrograms\ezsploit\updatetemp", true);
                        if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\monaco-editor"))
                        {
                            Console.WriteLine("ReDownloading monaco-editor");
                            Console.WriteLine("]Deleting monaco-editor");
                            Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\monaco-editor", true);
                            Console.WriteLine("]Downloading monaco-editor.zip");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip");
                            Console.WriteLine("]Extracting monaco-editor.zip");
                            ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\monaco-editor.zip", "c:\\mikusdevPrograms\\ezsploit");
                        }
                        if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\runtimes"))
                        {
                            Console.WriteLine("ReDownloading runtimes");
                            Console.WriteLine("]Deleting runtimes");
                            Directory.Delete("c:\\mikusdevPrograms\\ezsploit\\runtimes", true);
                            Console.WriteLine("]Downloading runtimes.zip");
                            webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/runtimes.zip", "c:\\mikusdevPrograms\\ezsploit\\runtimes.zip");
                            Console.WriteLine("]Extracting runtimes.zip");
                            ZipFile.ExtractToDirectory("c:\\mikusdevPrograms\\ezsploit\\runtimes.zip", "c:\\mikusdevPrograms\\ezsploit");
                        }
                        Thread.Sleep(100);
                        Console.WriteLine("Restored Configs!");
                        Console.WriteLine("Close this window and launch EzSploit again");
                        Application.Run(new Form1());
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
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt"))
                    {
                    }
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "off");
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt"))
                    {
                    }
                    using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt"))
                    {
                    }
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt", "EzSploit \rBy mikusdev/mikusgszyp");
                    Console.WriteLine("Configs set to def!");

                }
                Application.Run(new Form1());
            }
            catch (Exception)
            {
                string answer;
                Console.WriteLine(" ");
                Console.WriteLine("Problem occured!");
                Console.WriteLine("Possible reasons: nework connection, server error, missing file/folder");
                Console.WriteLine(" ");
                Console.WriteLine("If you want to try launch ezsploit, type 'run' and press ENTER");
                Console.WriteLine("If you want to launch updater, type 'update' and press ENTER");
                answer = Console.ReadLine();
                if (answer == "run")
                {
                    Application.Run(new Form1());
                }
                else if (answer == "update")
                {
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", "c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    Thread.Sleep(100);
                    Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploit Updater.exe");
                    Thread.Sleep(50);
                    Application.Exit();
                }
                else
                {
                    Console.WriteLine("Unknown command! Exiting...");
                    Thread.Sleep(1000);
                    Application.Exit();
                }
            }
        }
    }
}
