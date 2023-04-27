using EzSploit.Properties;
using FastColoredTextBoxNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace EzSploit.usercontrols
{
    public partial class uc_info : UserControl
    {
        public uc_info()
        {
            InitializeComponent();
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
            {
                BackgroundImage = Resources._0_0_0;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skull_emoji")
            {
                BackgroundImage = Resources.nickinfo;
            }
        }

        private void uc_info_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
