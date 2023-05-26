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
using KrnlAPI;
using WeAreDevs_API;
using Guna.UI2.WinForms;
using System.Runtime.InteropServices;

namespace EzSploit.usercontrols.gamespages
{
    public partial class page1 : UserControl
    {
        KrnlApi ezsploitkrnl = new KrnlApi();

        EasyExploits.Module ezsploitex = new EasyExploits.Module();

        ExploitAPI ezsploitwrd = new ExploitAPI();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int inject_dll();

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int run_script(string script);

        [DllImport("oxygen_injector.dll", CallingConvention = CallingConvention.StdCall)]
        private static extern int set_obs(bool setting);

        string script;
        public page1()
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

        public void executescript()
        {
            Console.WriteLine("Trying Execute...");
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
            {
                ezsploitex.ExecuteScript(script);
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
            {
                ezsploitkrnl.Execute(script);
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
            {
                ezsploitwrd.SendLuaScript(script);
            }
            if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Oxygen")
            {
                run_script(script);
            }
        }
        private void page1_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/vwSaraa/LunarHub/main/mm2\", true))()";
            executescript();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/7GrandDadPGN/VapeV4ForRoblox/main/NewMainScript.lua\", true))()";
            executescript();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet((\"https://raw.githubusercontent.com/mstudio45/MSDOORS/main/MSDOORS.lua\"),true))()";
            executescript();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/vwSaraa/LunarHub/main/mm2\", true))()";
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\MM2 lunar.txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\MM2 lunar.txt", script);
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet(\"https://raw.githubusercontent.com/7GrandDadPGN/VapeV4ForRoblox/main/NewMainScript.lua\", true))()";
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\Bed Wars VAPE V4.txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\Bed Wars VAPE V4.txt", script);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet((\"https://raw.githubusercontent.com/mstudio45/MSDOORS/main/MSDOORS.lua\"),true))()";
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\MS Doors.txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\MS Doors.txt", script);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt\"))()";
            executescript();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            script = "loadstring(game:HttpGet(\"https://cdn.wearedevs.net/scripts/Dex%20Explorer.txt\"))()";
            using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\Dex Explorer.txt"))
            {
            }
            File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\Dex Explorer.txt", script);
        }
    }
}
