using System;
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
		Directory.CreateDirectory("c:\\mikusdevPrograms\\ezsploit");
		WebClient webClient = new WebClient();
		using (File.Create("c:\\mikusdevPrograms\\ezsploit\\version.txt"))
		{
			Thread.Sleep(100);
		}
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\version.txt", "4.8.4");
		webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/versionew.txt", "c:\\mikusdevPrograms\\ezsploit\\versionew.txt");
		Application.EnableVisualStyles();
		Application.SetCompatibleTextRenderingDefault(defaultValue: false);
		webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Guna.UI2.dll", "c:\\mikusdevPrograms\\ezsploit\\Guna.UI2.dll");
		webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/FastColoredTextBox.dll", "c:\\mikusdevPrograms\\ezsploit\\FastColoredTextBox.dll");
		webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/DiscordRPC.dll", "c:\\mikusdevPrograms\\ezsploit\\DiscordRPC.dll");
		webClient.DownloadFile("https://raw.githubusercontent.com/mikusgszyp/ezsploitfiledownloader/main/Newtonsoft.Json.dll", "c:\\mikusdevPrograms\\ezsploit\\Newtonsoft.Json.dll");
		Application.Run(new Form1());
	}
}
