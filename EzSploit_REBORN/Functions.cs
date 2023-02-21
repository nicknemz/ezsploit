using AxonSimpleUI;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace EzSploit_REBORN;

internal class Functions
{
	public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
	{
		FileInfo[] files = new DirectoryInfo(Folder).GetFiles(FileType);
		FileInfo[] array = files;
		foreach (FileInfo fileInfo in array)
		{
			lsb.Items.Add(fileInfo.Name);
		}
	}

    //here starts my API

    public static string exploitdllname = "MdevAPI.dll";//Axon.dll this is the name of your dll
    public static void Inject()
    {
        if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe exist
        {
            MessageBox.Show("Already injected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);//if the pipe exist that's mean that we don't need to inject
            return;
        }
        else if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe don't exist
        {
            switch (Injector.DllInjector.GetInstance.Inject("RobloxPlayerBeta", AppDomain.CurrentDomain.BaseDirectory + exploitdllname))//Process name and dll directory
            {
                case Injector.DllInjectionResult.DllNotFound://if can't find the dll
                    MessageBox.Show($"Couldn't find {exploitdllname}", "Dll was not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);//display messagebox to tell that dll was not found
                    return;
                case Injector.DllInjectionResult.GameProcessNotFound://if can't find the process
                    MessageBox.Show("Couldn't find RobloxPlayerBeta.exe!", "Target process was not found!", MessageBoxButtons.OK, MessageBoxIcon.Error);//display messagebox to tell that proccess was not found
                    return;
                case Injector.DllInjectionResult.InjectionFailed://if injection fails(this don't work or only on special cases)
                    MessageBox.Show("Injection Failed!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);//display messagebox to tell that injection failed
                    return;
            }
            Thread.Sleep(1000);//pause the ui for 3 seconds
            if (!NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe dont exist
            {
                MessageBox.Show("Injection Failed!\nMaybe you are Missing something\nor took more time to check if was ready\nor other stuff", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);//display that the pipe was not found so the injection was unsuccessful
            }
        }
    }
}
