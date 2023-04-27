using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzSploit
{
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
}
