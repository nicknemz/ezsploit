using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using IWshRuntimeLibrary;

namespace Comet_3.Classes.DLL;

internal class RuyiAPI
{
	public enum Result : uint
	{
		Success,
		DLLNotFound,
		OpenProcFail,
		AllocFail,
		LoadLibFail,
		AlreadyInjected,
		ProcNotOpen,
		Unknown
	}

	public static string dll_path;

	private static IntPtr phandle;

	private static int pid = 0;

	private static readonly IntPtr NULL = (IntPtr)0;

	private static HandleSettings Settings = new HandleSettings();

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr OpenProcess(uint access, bool inhert_handle, int pid);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, IntPtr dwSize, uint flAllocationType, uint flProtect);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern int WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, IntPtr nSize, int lpNumberOfBytesWritten);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetProcAddress(IntPtr hModule, string lpProcName);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr GetModuleHandle(string lpModuleName);

	[DllImport("kernel32.dll", SetLastError = true)]
	private static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttribute, IntPtr dwStackSize, IntPtr lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);

	[DllImport("Ruyi.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern bool run_script(IntPtr proc, int pid, string path, [MarshalAs(UnmanagedType.LPWStr)] string script);

	[DllImport("Ruyi.dll", CallingConvention = CallingConvention.StdCall)]
	public static extern bool is_injected(IntPtr proc, int pid, string path);

	private static Result r_inject(string dll_path)
	{
		FileInfo fileInfo = new FileInfo(dll_path);
		FileSecurity accessControl = fileInfo.GetAccessControl();
		SecurityIdentifier identity = new SecurityIdentifier("S-1-15-2-1");
		accessControl.AddAccessRule(new FileSystemAccessRule(identity, FileSystemRights.FullControl, InheritanceFlags.None, PropagationFlags.NoPropagateInherit, AccessControlType.Allow));
		fileInfo.SetAccessControl(accessControl);
		Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
		if (processesByName.Length == 0)
		{
			return Result.ProcNotOpen;
		}
		for (uint num = 0u; num < processesByName.Length; num++)
		{
			Process process = processesByName[num];
			if (pid != process.Id)
			{
				IntPtr intPtr = OpenProcess(1082u, inhert_handle: false, process.Id);
				if (intPtr == NULL)
				{
					return Result.OpenProcFail;
				}
				IntPtr intPtr2 = VirtualAllocEx(intPtr, NULL, (IntPtr)((dll_path.Length + 1) * Marshal.SizeOf(typeof(char))), 12288u, 64u);
				if (intPtr2 == NULL)
				{
					return Result.AllocFail;
				}
				byte[] bytes = Encoding.Default.GetBytes(dll_path);
				int num2 = WriteProcessMemory(intPtr, intPtr2, bytes, (IntPtr)((dll_path.Length + 1) * Marshal.SizeOf(typeof(char))), 0);
				if (num2 == 0 || (long)num2 == 6)
				{
					return Result.Unknown;
				}
				if (CreateRemoteThread(intPtr, NULL, NULL, GetProcAddress(GetModuleHandle("kernel32.dll"), "LoadLibraryA"), intPtr2, 0u, NULL) == NULL)
				{
					return Result.LoadLibFail;
				}
				pid = process.Id;
				phandle = intPtr;
				return Result.Success;
			}
			if (pid == process.Id)
			{
				return Result.AlreadyInjected;
			}
		}
		return Result.Unknown;
	}

	public static Result inject_custom()
	{
		dll_path = "c:\\mikusdevPrograms\\ezsploit\\COMETleaked.dll";

        try
		{
			if (!File.Exists(dll_path))
			{
				return Result.DLLNotFound;
			}
			return r_inject(dll_path);
		}
		catch
		{
			return Result.Unknown;
		}
	}

	public static void inject()
	{
		if (GetCorrectDLL())
		{
			switch (inject_custom())
			{
			case Result.DLLNotFound:
				System.Windows.Forms.MessageBox.Show("Try to hit ReDownload button from options(close roblox before this), if this doesnt work you need to download Comet executor and get key\n", "EzSploit Injector");
				break;
			case Result.OpenProcFail:
				System.Windows.Forms.MessageBox.Show("Injection Failed - OpenProcFail failed!\n", "Injection");
				break;
			case Result.AllocFail:
				System.Windows.Forms.MessageBox.Show("Injection Failed - AllocFail failed!\n", "Injection");
				break;
			case Result.LoadLibFail:
				System.Windows.Forms.MessageBox.Show("Injection Failed - LoadLibFail failed!\n", "Injection");
				break;
			case Result.ProcNotOpen:
				System.Windows.Forms.MessageBox.Show("Failure to find UWP game!\n\nPlease make sure you are using the game from the Microsoft Store and not the browser!", "Injection");
				break;
			case Result.Unknown:
				System.Windows.Forms.MessageBox.Show("Injection Failed - Unknown!\n", "Injection");
				break;
			case Result.AlreadyInjected:
				break;
			}
		}
	}

	public static bool is_injected()
	{
		return is_injected(phandle, pid, dll_path);
	}

	public static bool run_script(string script)
	{
		if (script == string.Empty)
		{
			return is_injected();
		}
		return run_script(phandle, pid, dll_path, script);
	}

	public static void create_files(string dll_path_)
	{
		dll_path = dll_path_;
		string text = "";
		string[] directories = Directory.GetDirectories(Environment.GetEnvironmentVariable("LocalAppData") + "\\Packages");
		foreach (string text2 in directories)
		{
			if (text2.Contains("OBLOXCORPORATION") && Directory.GetDirectories(text2 + "\\AC").Any((string dir) => dir.Contains("Temp")))
			{
				text = text2 + "\\AC";
			}
		}
		if (text == "")
		{
			return;
		}
		try
		{
			if (Directory.Exists("workspace"))
			{
				Directory.Move("workspace", "old_workspace");
			}
			if (Directory.Exists("autoexec"))
			{
				Directory.Move("autoexec", "old_autoexec");
			}
		}
		catch
		{
		}
		string text3 = Path.Combine(text, "workspace");
		string text4 = Path.Combine(text, "autoexec");
		if (!Directory.Exists(text3))
		{
			Directory.CreateDirectory(text3);
		}
		if (!Directory.Exists(text4))
		{
			Directory.CreateDirectory(text4);
		}
		if (!File.Exists("workspace.lnk"))
		{
			WshShell wshShell = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			IWshShortcut obj2 = (IWshShortcut)(dynamic)wshShell.CreateShortcut("workspace.lnk");
			obj2.TargetPath = text3;
			obj2.Save();
		}
		if (!File.Exists("autoexec.lnk"))
		{
			WshShell wshShell2 = (WshShell)Activator.CreateInstance(Marshal.GetTypeFromCLSID(new Guid("72C24DD5-D70A-438B-8A42-98424B88AFB8")));
			IWshShortcut obj3 = (IWshShortcut)(dynamic)wshShell2.CreateShortcut("autoexec.lnk");
			obj3.TargetPath = text4;
			obj3.Save();
		}
	}

	private static string get_file_sha384(string path)
	{
		using FileStream inputStream = File.OpenRead(path);
		return BitConverter.ToString(new SHA384Managed().ComputeHash(inputStream)).Replace("-", string.Empty).ToLower();
	}

	private static bool GetCorrectDLL()
	{
		Process[] processesByName = Process.GetProcessesByName("Windows10Universal");
		if (processesByName.Length == 0)
		{
			System.Windows.MessageBox.Show("The game was not found!\nDue to the release of Byfron, Comet currently only supports the Windows Store version of the game!\nPlease install and join using the Windows Store version and inject again!", "Comet");
			return false;
		}
		if (processesByName.Length != 0)
		{
			
			return true;
			
		}
		return true;
	}
}
