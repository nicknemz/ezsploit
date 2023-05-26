using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;

namespace EzSploit
{

    public partial class oxygenkeysystem : Form
    {
        [DllImport("oxygen_auth.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int start_auth();

        [DllImport("oxygen_auth.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern bool verify_auth(string key);
        public oxygenkeysystem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start_auth();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Thread((ThreadStart)delegate
            {
                try
                {
                    button2.Enabled = false;
                    if (verify_auth(keytextbox.Text))
                    {
                    }
                    button2.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("There has been an unexpected error while attempting to verify your key for Oxygen U. Please make sure that you have added Oxygen U to your exclusion or have Real Time Protection off. Alternatively, make sure your connection to https://www.oxygenu.xyz is okay.");
                }
            }).Start();
        }
    }
}
