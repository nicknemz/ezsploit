using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using IWshRuntimeLibrary;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace EzSploit_Loader
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void renamecfg()
            {
                Console.WriteLine("Missing files");
                Console.WriteLine("Triggering ReDownload");
                if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit\\Configs"))
                {
                    Directory.Move("c:\\mikusdevPrograms\\ezsploit\\Configs", "c:\\mikusdevPrograms\\ezsploit\\updatetemp");
                }
            }
            
            string destkop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            WebClient webClient = new WebClient();
            if (Directory.Exists("c:\\mikusdevPrograms\\ezsploit"))
            {
                if (System.IO.File.Exists("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
                {
                    System.IO.File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt", "66");
                }
                if (!System.IO.File.Exists("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
                {
                    using (System.IO.File.Create("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
                    {
                        Thread.Sleep(50);
                    }
                    System.IO.File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt", "66");
                }
            }

            

            
            Console.WriteLine("INFO: If ezsploit is not launching, or dll's not injecting then disable antivirus or delete 'C:/mikusdevPrograms' folder on your PC.");
            Console.WriteLine("INFO: You can also install WebView2");
            if (System.IO.File.Exists("C:\\mikusdevPrograms\\ezsploit\\EzSploitV4.exe"))
            {
                

                try
                {
                    Console.WriteLine("Welcome to EzSploit V6 loader!");
                    Console.WriteLine("Running update checker...");
                    byte[] decoded = Convert.FromBase64String(webClient.DownloadString("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/antibyfron"));
                }
                catch (Exception)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("Network error or missing file on server!");
                    Console.WriteLine("Do you want to try launch ezsploit without internet connection? (yes or no)");
                    string answer = Console.ReadLine();
                    if (answer == "yes")
                    {
                        try
                        {
                            Process.Start(@"c:\mikusdevPrograms\ezsploit\tmp.exe");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("File corrupted");
                            Console.WriteLine("Can't run without internet connection");
                            Thread.Sleep(1000);
                        }
                    }
                    else if (answer == "no")
                    {

                    }
                    else
                    {
                        Console.WriteLine("Unknown command! Exiting...");
                        Thread.Sleep(1000);
                    }
                }
                byte[] decoded1 = Convert.FromBase64String(webClient.DownloadString("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/antibyfron"));
                Thread.Sleep(1000);
                if (System.IO.File.Exists(@"c:\mikusdevPrograms\ezsploit\tmp.exe"))
                {
                    System.IO.File.Delete(@"c:\mikusdevPrograms\ezsploit\tmp.exe");
                    Thread.Sleep(1000);
                }
                using (System.IO.File.Create(@"c:\mikusdevPrograms\ezsploit\tmp.exe"))
                {
                }
                Thread.Sleep(500);
                System.IO.File.WriteAllBytes(@"c:\mikusdevPrograms\ezsploit\tmp.exe", decoded1);
                Thread.Sleep(500);
                Process.Start(@"c:\mikusdevPrograms\ezsploit\tmp.exe");
                if (System.IO.Directory.Exists(@"c:\mikusdevPrograms\ezsploit\updatetemp"))
                {
                    Console.WriteLine("ReDownload triggered");
                    Console.WriteLine("Close this window and relaunch ezsploit.");
                }
            } else
            {
                Console.WriteLine("EzSploit not detected!");
                Console.WriteLine("Installing...");
                Console.WriteLine("]Creating Directory...");
                DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");
                Thread.Sleep(500);
                if (Directory.Exists(@"c:\mikusdevPrograms\ezsploit\Configs"))
                {
                    Console.WriteLine("]Deleting Configs...");
                    Directory.Delete(@"c:\mikusdevPrograms\ezsploit\Configs", true);
                }
                Console.WriteLine("]Downloading Main .exe");
                webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                Thread.Sleep(1000);
                Console.WriteLine("]Creating Desktop shortcut...");
                object shDesktop = (object)"Desktop";
                WshShell shell = new WshShell();
                string shortcutAddress = (string)shell.SpecialFolders.Item(ref shDesktop) + @"\EzSploit.lnk";
                IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutAddress);
                shortcut.Description = "EzSploit shortcut";
                shortcut.Hotkey = "Ctrl+Shift+E";
                shortcut.TargetPath = @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe";
                shortcut.WorkingDirectory = @"c:\mikusdevPrograms\ezsploit";
                shortcut.Save();
                Console.WriteLine("]Creating Start Menu shortcut...");
                string programs_path = Environment.GetFolderPath(Environment.SpecialFolder.Programs);
                string shortcutFolder = Path.Combine(programs_path, @"mikusdev");
                if (!Directory.Exists(shortcutFolder))
                {
                    Directory.CreateDirectory(shortcutFolder);
                }
                WshShell shellClass = new WshShell();
                //Create First Shortcut for Application Settings
                string settingsLink = Path.Combine(shortcutFolder, "EzSploit.lnk");
                IWshShortcut shortcutmenu = (IWshShortcut)shellClass.CreateShortcut(settingsLink);
                shortcutmenu.TargetPath = @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe";
                shortcutmenu.WorkingDirectory = @"c:\mikusdevPrograms\ezsploit";
                shortcutmenu.Description = "EzSploit shortcut";
                shortcutmenu.Save();
                Console.WriteLine("]installed!");
                Console.WriteLine("]Close this window and run EzSploit by shortcut on your desktop");
                Console.ReadKey();
            }
            
        }
    }
}
