using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace EzSploit_Updater_V2
{
    internal class Program
    {
        
        static void Main(string[] args)
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
            try
            {
                Process[] procs = Process.GetProcessesByName("ezsploitv");
                foreach (Process p in procs) { p.Kill(); }
            }
            catch (Exception)
            {

            }
            try
            {
                Process[] procs = Process.GetProcessesByName("EzSploitV4");
                foreach (Process p in procs) { p.Kill(); }
            }
            catch (Exception)
            {

            }
            try
            {
                Console.WriteLine("Checking internet connection...");
                string iswebavible = webClient.DownloadString("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt");
                Console.WriteLine("Updating...");
                try
                {
                    foreach (Process process in Process.GetProcessesByName("tmp"))
                    {
                        process.Kill();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Failed to kill EzSploit.exe");
                }
                

                string configsfolder = @"c:\mikusdevPrograms\ezsploit";
                string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                if (Directory.Exists(configsfolder))
                {
                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                }
                else
                {
                    DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");

                    webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploitV4.exe", @"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
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
                Thread.Sleep(100);
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
                Thread.Sleep(100);
                Console.WriteLine("Update completed! ReLaunching EzSploit");
                Process.Start(@"c:\mikusdevPrograms\ezsploit\EzSploitV4.exe");
                Console.WriteLine("Exiting...");
                Thread.Sleep(500);
            }
            catch (Exception)
            {
                Console.WriteLine("No internet connection! Exiting...");
                Thread.Sleep(1000);
            }
        }
    }
}
