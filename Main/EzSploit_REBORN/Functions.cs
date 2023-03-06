using System.IO;
using System.Windows.Forms;

namespace EzSploit_REBORN;

internal class Functions
{
	public static void PopulateListBox(ListBox lsb, string Folder, string FileType)
	{
		FileInfo[] files = new DirectoryInfo(Folder).GetFiles(FileType);
		foreach (FileInfo fileInfo in files)
		{
			lsb.Items.Add(fileInfo.Name);
		}
	}
}
