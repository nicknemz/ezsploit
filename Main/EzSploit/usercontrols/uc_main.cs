using EzSploit.Properties;
using KrnlAPI;
using Microsoft.Web.WebView2.Core;
using Microsoft.Web.WebView2.WinForms;
using Microsoft.Web.WebView2.Wpf;
using Microsoft.Win32;
using System;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using WeAreDevs_API;
using static Guna.UI2.Native.WinApi;
using static System.Net.Mime.MediaTypeNames;

namespace EzSploit.usercontrols
{
    public partial class uc_main : UserControl
    {

        WebClient webClient = new WebClient();

        KrnlApi ezsploitkrnl = new KrnlApi();

        EasyExploits.Module ezsploitex = new EasyExploits.Module();

        ExploitAPI ezsploitwrd = new ExploitAPI();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int inject_dll();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int run_script(string script);

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int set_obs(bool setting);

        public uc_main()
        {
            InitializeComponent();
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
            
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
            {
                BackgroundImage = Resources._0_0_0;
                panel1.BackgroundImage = Resources._25_25_25;
            } else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skull_emoji")
            {
                BackgroundImage = Resources.textbox;
                panel1.BackgroundImage = Resources._25_25_25;
            }

        }

        public void savetext()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script1text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", GetText());
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", GetText());
            }
        }

        public void readtext()
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "1")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script1text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "2")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script2text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "3")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script3text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "4")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script4text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "5")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script5text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "6")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script6text.txt"));
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt") == "7")
            {
                SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script7text.txt"));
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine("Trying Execute...");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                ezsploitex.ExecuteScript(GetText());
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                ezsploitkrnl.Execute(GetText());
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                ezsploitwrd.SendLuaScript(GetText());
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                run_script(GetText());
            }
            savetext();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFileDialog = new System.Windows.Forms.OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SetText(File.ReadAllText(openFileDialog.FileName));

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: Could not read file from disk. Original error: {ex.Message}");//display if got error
                }
            }
            savetext();
        }
        public void SetText(string text)
        {
            ((Microsoft.Web.WebView2.WinForms.WebView2)MonacoEditor).CoreWebView2.ExecuteScriptAsync("SetText(\"" + HttpUtility.JavaScriptStringEncode(text) + "\")");
        }

        
        public string GetText()
        {
            ((Microsoft.Web.WebView2.WinForms.WebView2)MonacoEditor).CoreWebView2.WebMessageReceived += delegate (object __, CoreWebView2WebMessageReceivedEventArgs args)
            {
                _lrt = args.TryGetWebMessageAsString();
            };
            return _lrt;
        }

        private string _lrt = "";
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            SetText("");
            savetext();
        }

        public void wait(int milliseconds)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            if (milliseconds != 0 && milliseconds >= 0)
            {
                timer1.Interval = milliseconds;
                timer1.Enabled = true;
                timer1.Start();
                timer1.Tick += delegate
                {
                    timer1.Enabled = false;
                    timer1.Stop();
                };
                while (timer1.Enabled)
                {
                    System.Windows.Forms.Application.DoEvents();
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Saving file...");
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + guna2TextBox1.Text + ".txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + guna2TextBox1.Text + ".txt", GetText());
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
            savetext();
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
            File.Delete("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + listBox1.SelectedItem);
            listBox1.Items.Clear();
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
            Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Scripts/{listBox1.SelectedItem}"));
            savetext();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void uc_main_Load(object sender, EventArgs e, int sek24)
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                selectedapitext.Text = "EasyExploits";
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                selectedapitext.Text = "Krnl";
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                selectedapitext.Text = "WeAreDevs";
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                selectedapitext.Text = "Oxygen";
            }
            bool sek2 = true;
            int ser = 0;
            while (sek2)
            {
                ser = ser + 1;
                if (ser == 50)
                {
                    script1.Visible = true;
                    readtext();
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
                    {
                        script2.Visible = true;
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                        {
                            script3.Visible = true;
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                            {
                                script4.Visible = true;
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                                {
                                    script5.Visible = true;
                                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                                    {
                                        script6.Visible = true;
                                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
                                        {
                                            script7.Visible = true;

                                        }
                                        else
                                        {
                                            script7.Visible = false;
                                        }
                                    }
                                    else
                                    {
                                        script6.Visible = false;
                                        script7.Visible = false;
                                    }
                                }
                                else
                                {
                                    script5.Visible = false;
                                    script6.Visible = false;
                                    script7.Visible = false;
                                }
                            }
                            else
                            {
                                script4.Visible = false;
                                script5.Visible = false;
                                script6.Visible = false;
                                script7.Visible = false;
                            }
                        }
                        else
                        {
                            script3.Visible = false;
                            script4.Visible = false;
                            script5.Visible = false;
                            script6.Visible = false;
                            script7.Visible = false;
                        }
                    }
                    else
                    {
                        script2.Visible = false;
                        script3.Visible = false;
                        script4.Visible = false;
                        script5.Visible = false;
                        script6.Visible = false;
                        script7.Visible = false;
                    }
                }
            }
            
            
        }
        
        

        private void MonacoEditor_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            

        }

        private void script1_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "1");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script1text.txt"));
        }

        private void script2_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script2text.txt"));
        }

        private void script3_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script3text.txt"));
        }

        private void script4_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script4text.txt"));
        }

        private void script5_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script5text.txt"));
        }

        private void script6_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script6text.txt"));
        }

        private void script7_Click(object sender, EventArgs e)
        {
            savetext();

            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "7");
            SetText(File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Configs/script7text.txt"));
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            savetext();


            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "off")
            {
                script2.Visible = true;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "2");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "on");
                SetText("");
            }
            else
            {
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "off")
                {
                    script3.Visible = true;
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "3");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "on");
                    SetText("");
                }
                else
                {
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "off")
                    {
                        script4.Visible = true;
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "4");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "on");
                        SetText("");
                    }
                    else
                    {
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "off")
                        {
                            script5.Visible = true;
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "5");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "on");
                            SetText("");
                        }
                        else
                        {
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "off")
                            {
                                script6.Visible = true;
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "6");
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "on");
                                SetText("");
                            }
                            else
                            {
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "off")
                                {
                                    script7.Visible = true;
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", "7");
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "on");
                                    SetText("");
                                }
                                else
                                {
                                    MessageBox.Show("max amount of script tabs is 7");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
            {
                script7.Visible = false;
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt", "off");
                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7text.txt", "");
                
            }
            else
            {
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                {
                    script6.Visible = false;
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt", "off");
                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6text.txt", "");
                }
                else
                {
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                    {
                        script5.Visible = false;
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt", "off");
                        File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5text.txt", "");
                    }
                    else
                    {
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                        {
                            script4.Visible = false;
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt", "off");
                            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4text.txt", "");
                        }
                        else
                        {
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                            {
                                script3.Visible = false;
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt", "off");
                                File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3text.txt", "");
                            }
                            else
                            {
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
                                {
                                    script2.Visible = false;
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt", "off");
                                    File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2text.txt", "");
                                }
                                else
                                {
                                    MessageBox.Show("You can't delete script1");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MonacoEditor_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            

            
        }

        private void MonacoEditor_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            savetext();
        }

        private void MonacoEditor_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            savetext();
        }

        private void MonacoEditor_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            
        }

        private void MonacoEditor_Click(object sender, EventArgs e)
        {

        }

        private void MonacoEditor_KeyDown(object sender, KeyEventArgs e)
        {
            savetext();
        }

        private void MonacoEditor_KeyPress(object sender, KeyPressEventArgs e)
        {
            savetext();
        }

        private void MonacoEditor_KeyUp(object sender, KeyEventArgs e)
        {
            savetext();
        }

        private void MonacoEditor_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            
        }

        private void uc_main_Load(object sender, EventArgs e)
        {
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                selectedapitext.Text = "EasyExploits";
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                selectedapitext.Text = "Krnl";
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                selectedapitext.Text = "WeAreDevs";
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                selectedapitext.Text = "Oxygen";
            }
            wait(500);
            script1.Visible = true;
            readtext();
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script2.txt") == "on")
            {
                script2.Visible = true;
                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script3.txt") == "on")
                {
                    script3.Visible = true;
                    if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script4.txt") == "on")
                    {
                        script4.Visible = true;
                        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script5.txt") == "on")
                        {
                            script5.Visible = true;
                            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script6.txt") == "on")
                            {
                                script6.Visible = true;
                                if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\script7.txt") == "on")
                                {
                                    script7.Visible = true;

                                }
                                else
                                {
                                    script7.Visible = false;
                                }
                            }
                            else
                            {
                                script6.Visible = false;
                                script7.Visible = false;
                            }
                        }
                        else
                        {
                            script5.Visible = false;
                            script6.Visible = false;
                            script7.Visible = false;
                        }
                    }
                    else
                    {
                        script4.Visible = false;
                        script5.Visible = false;
                        script6.Visible = false;
                        script7.Visible = false;
                    }
                }
                else
                {
                    script3.Visible = false;
                    script4.Visible = false;
                    script5.Visible = false;
                    script6.Visible = false;
                    script7.Visible = false;
                }
            }
            else
            {
                script2.Visible = false;
                script3.Visible = false;
                script4.Visible = false;
                script5.Visible = false;
                script6.Visible = false;
                script7.Visible = false;
            }
            while(true)
            {
                savetext();
                wait(2000);
            }
        }

        private void MonacoEditor_ContentLoading(object sender, CoreWebView2ContentLoadingEventArgs e)
        {
            
        }
    }
    
}
