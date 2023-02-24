using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace EzSploit_REBORN;

internal static class Program
{
	[STAThread]


	private static void Main()
	{
        DirectoryInfo di = Directory.CreateDirectory(@"c:\mikusdevPrograms\ezsploit");
        WebClient webClient = new WebClient();
        
        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EzSploit%20Launcher.exe", @"c:\mikusdevPrograms\ezsploit\EzSploit Updater.exe");

        using (FileStream fs = File.Create(@"c:\mikusdevPrograms\ezsploit\version.txt"))
        Thread.Sleep(1000);
        File.WriteAllText(@"c:\mikusdevPrograms\ezsploit\version.txt", "405");
        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt", @"c:\mikusdevPrograms\ezsploit\versionew.txt");

        Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);

        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Guna.UI2.dll", @"c:\mikusdevPrograms\ezsploit\Guna.UI2.dll");
        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/FastColoredTextBox.dll", @"c:\mikusdevPrograms\ezsploit\FastColoredTextBox.dll");
        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/EasyExploits.dll", @"c:\mikusdevPrograms\ezsploit\EasyExploits.dll");
        webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/KrnlAPI.dll", @"c:\mikusdevPrograms\ezsploit\KrnlAPI.dll");

        Application.Run(new Form1());
	}
}
