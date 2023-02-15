using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EzSploit_V3
{
    public partial class pythonwarn : Form
    {
        public pythonwarn()
        {
            InitializeComponent();
        }

        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/mikusgszyp/VIEaimFortnite/blob/main/LauncherTuto.md");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Process.Start("aifn.bat");
            wait(1000);
            Close();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            Process.Start("aifnsetup.bat");
            wait(1000);
            Close();
        }
    }
}
