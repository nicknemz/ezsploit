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
using KrnlAPI;

namespace EzSploit_V3
{
    public partial class krnlfix_ : Form
    {

        KrnlApi ezsploitkrnl = new KrnlApi();
        public krnlfix_()
        {
            InitializeComponent();
            ezsploitkrnl.Initialize();
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

        private void button1_Click(object sender, EventArgs e)
        {
            wait(1000);
            ezsploitkrnl.Inject();
            wait(5000);
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Process.Start("extinj.exe");
            wait(5000);
            Close();
        }
    }
}
