using ezsploitv.Properties;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Threading;

namespace ezsploitv
{
    public partial class keysystem : Form
    {
        public keysystem()
        {
            InitializeComponent();
        }
        Point lastPoint;
        [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Ansi)]
        [return: MarshalAs(UnmanagedType.I1)]
        public static extern bool Verify([MarshalAs(UnmanagedType.LPStr)] string key);

        [DllImport("bin/CometAuth.dll", CallingConvention = CallingConvention.Cdecl)]
        [return: MarshalAs(UnmanagedType.BStr)]
        public static extern string HWID();

        public static string HttpGet(string url)
        {
            using WebClient webClient = new WebClient();
            webClient.Headers.Add(HttpRequestHeader.UserAgent, "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; .NET CLR 1.0.3705;)");
            return webClient.DownloadString(url);
        }
        private DispatcherTimer KeySpam;
        private void keysystem_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("When you get the key, paste it in the box below.");
                Process.Start("https://cometrbx.xyz/ks/start.php?HWID=" + HWID());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Key System Error!");
                if (ex.ToString().Contains("An attempt was made to load a program with an incorrect") || ex.ToString().Contains("BadImageFormatException"))
                {
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x86.exe");
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x64.exe");
                    MessageBox.Show("Your system is missing the C/C++ redistributions.\nThe link to both of them were started.\nPlease download both of them.\nIf there is an option for repair, select that. If not, continue with a normal installation.\nOnce both are installed, restart your computer.", "Error");
                }
                else
                {
                    MessageBox.Show("Get key error!\n" + ex.ToString());
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Verify(textBox1.Text))
                {
                    MessageBox.Show("Valid key! (This Key will last a 24h)");
                    await Task.Delay(1000);
                    Process.Start("c:\\mikusdevPrograms\\ezsploit\\EzSploitV4.exe");
                    Close();
                }
                else
                {
                    MessageBox.Show("This key is invalid.");
                    MessageBox.Show("Invalid Key, didn't mean this to be? Please ask people in our discord server.");
                }
                
            }
            catch (Exception ex)
            {
                if (ex.ToString().Contains("An attempt was made to load a program with an incorrect") || ex.ToString().Contains("BadImageFormatException"))
                {
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x86.exe");
                    Process.Start("https://aka.ms/vs/16/release/vc_redist.x64.exe");
                    MessageBox.Show("Your system is missing the C/C++ redistributions.\nThe link to both of them were started.\nPlease download both of them.\nIf there is an option for repair, select that. If not, continue with a normal installation.\nOnce both are installed, restart your computer.", "Error");
                }
                else
                {
                    MessageBox.Show("Verify key error!\n" + ex.ToString());
                }
                
            }
            KeySpam.Start();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
    }
}
