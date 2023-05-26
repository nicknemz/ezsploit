using EzSploit.Properties;
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
using EzSploit.usercontrols.gamespages;
using DiscordRPC;

namespace EzSploit.usercontrols
{
    public partial class games : UserControl
    {
        public games()
        {
            InitializeComponent();
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
            {
                BackgroundImage = Resources._0_0_0;
            }
            else if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skull_emoji")
            {
                BackgroundImage = Resources.nicknamez4;
            }
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            UC_GAMESWINDOW.Controls.Clear();
            UC_GAMESWINDOW.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void games_Load(object sender, EventArgs e)
        {
            page1 userControl = new page1();
            addUserControl(userControl);
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            page1 userControl = new page1();
            addUserControl(userControl);
        }

        private void UC_GAMESWINDOW_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
