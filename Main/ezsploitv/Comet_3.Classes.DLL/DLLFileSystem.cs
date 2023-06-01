using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Comet_3.Classes.DLL;

internal class DLLFileSystem
{
    public static string DLLFolder = "C:\\mikusdevPrograms\\ezsploit\\";

    public static string DLLPath = DLLFolder + "COMETleaked.dll";


    public static bool DiscordRPCEnabled = false;

	[DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
	[return: MarshalAs(UnmanagedType.I1)]
	public static extern bool Verify([MarshalAs(UnmanagedType.LPStr)] string key);

    public static extern string HWID();

    public static void CreateDLLFolder()
    {
        if (!Directory.Exists(DLLFolder))
        {
            Directory.CreateDirectory(DLLFolder);
        }
    }
}
