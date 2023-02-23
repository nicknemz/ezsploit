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

    
    
}
