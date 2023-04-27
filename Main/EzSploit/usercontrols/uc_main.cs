using KrnlAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreDevs_API;
using EasyExploits;
using Oxygen;
using EzSploit.Properties;
using Microsoft.Win32;
using FastColoredTextBoxNS;

namespace EzSploit.usercontrols
{
    public partial class uc_main : UserControl
    {

        WebClient webClient = new WebClient();

        KrnlApi ezsploitkrnl = new KrnlApi();

        Module ezsploitex = new Module();

        ExploitAPI ezsploitwrd = new ExploitAPI();
        public uc_main()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
            {
                BackgroundImage = Resources._0_0_0;
            } else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skull_emoji")
            {
                BackgroundImage = Resources.textbox;
            }
            MonacoEditor.Url = new Uri(string.Format("file:///{0}/monaco-editor/index.html", Directory.GetCurrentDirectory()));
            
        }

        
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Trying execute...");

            Console.WriteLine(" ");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                ezsploitex.ExecuteScript(MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                ezsploitkrnl.Execute(MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                ezsploitwrd.SendLuaScript(MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                Execution.Execute(MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    MonacoEditor.Document.InvokeScript("SetMonacoEditorText", new object[]
                    {
                        File.ReadAllText(openFileDialog.FileName)
                    });//load all the text in the MonacoEditor

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not read file from disk. Original error: {ex.Message}");//display if got error
                }
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MonacoEditor.Document.InvokeScript("SetMonacoEditorText", new object[] { "" });
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saving file...");

            Console.WriteLine(" ");
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + guna2TextBox1.Text + ".txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + guna2TextBox1.Text + ".txt", MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
            

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Deleting file...");
            Console.WriteLine(" ");
            File.Delete("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + listBox1.SelectedItem);
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonacoEditor.Document.InvokeScript("SetMonacoEditorText", new object[] { File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Scripts/{listBox1.SelectedItem}") }) ;

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", MonacoEditor.Document.InvokeScript("GetMonacoEditorText").ToString());
        }





        
        


        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void uc_main_Load(object sender, EventArgs e)
        {
            MonacoEditor.Document.BackColor = System.Drawing.SystemColors.ControlDark;
            
        }

        private void MonacoEditor_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            MonacoEditor.Document.InvokeScript("SetMonacoEditorText", new object[] { File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/textboxconf.txt") });
        }
    }
    
}
