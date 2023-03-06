using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EasyExploits;
using EzSploit_REBORN.Properties;
using EzSploit_V3;
using FastColoredTextBoxNS;
using Guna.UI2.WinForms;
using KrnlAPI;
using WeAreDevs_API;

namespace EzSploit_REBORN.UserControls;

public class uc_home : UserControl
{
	private KrnlApi ezsploitkrnl = new KrnlApi();

	private Module ezsploitex = new Module();

	private ExploitAPI ezsploitwrd = new ExploitAPI();

	private IContainer components;

	private FastColoredTextBox fastColoredTextBox1;

	private Guna2Button guna2Button1;

	private ListBox listBox1;

	private Guna2Button guna2Button2;

	private Guna2Button guna2Button3;

	private Guna2Button guna2Button4;

	private Guna2Button guna2Button5;

	private Guna2TextBox savetextbox;

	private Guna2Button guna2Button7;
    private Guna2Button guna2Button8;
    private Guna2Button guna2Button6;

	public uc_home()
	{
		InitializeComponent();
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "galaxy")
		{
			BackgroundImage = Resources.starsback;
			fastColoredTextBox1.BackgroundImage = Resources.starsback;
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "classic")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources._20_20_20;
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "sus")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources.anime2;
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "nsfw")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources.anime31;
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt") == "skullemoji")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources.nicknamez1;
		}
		listBox1.Items.Clear();
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.lua");
		fastColoredTextBox1.Text = File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt");
	}

	public void wait(int milliseconds)
	{
		Timer timer1 = new Timer();
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
				Application.DoEvents();
			}
		}
	}

	private void uc_home_Load(object sender, EventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		fastColoredTextBox1.Text = File.ReadAllText($"c:/mikusdevPrograms/ezsploit/Scripts/{listBox1.SelectedItem}");
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
		ezsploitkrnl.Initialize();
		wait(1000);
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
		{
			ezsploitex.LaunchExploit();
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
		{
			ezsploitkrnl.Inject();
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
		{
			ezsploitwrd.LaunchExploit();
		}
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
		{
			ezsploitex.ExecuteScript(fastColoredTextBox1.Text);
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
		{
			ezsploitkrnl.Execute(fastColoredTextBox1.Text);
		}
		if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
		{
			string script = fastColoredTextBox1.Text;
			ezsploitwrd.SendLuaScript(script);
		}
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button3_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			openFileDialog.Title = "Open";
			fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
		}
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button4_Click(object sender, EventArgs e)
	{
		using (File.Create("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + savetextbox.Text + ".txt"))
		{
		}
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + savetextbox.Text + ".txt", fastColoredTextBox1.Text);
		listBox1.Items.Clear();
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
		fastColoredTextBox1.Clear();
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button5_Click(object sender, EventArgs e)
	{
		listBox1.Items.Clear();
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
            this.components = new System.ComponentModel.Container();
            this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.savetextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button8 = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // fastColoredTextBox1
            // 
            this.fastColoredTextBox1.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
            this.fastColoredTextBox1.BackBrush = null;
            this.fastColoredTextBox1.CharHeight = 14;
            this.fastColoredTextBox1.CharWidth = 8;
            this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fastColoredTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.fastColoredTextBox1.IsReplaceMode = false;
            this.fastColoredTextBox1.Location = new System.Drawing.Point(4, 4);
            this.fastColoredTextBox1.Name = "fastColoredTextBox1";
            this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
            this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fastColoredTextBox1.ServiceColors = null;
            this.fastColoredTextBox1.Size = new System.Drawing.Size(604, 351);
            this.fastColoredTextBox1.TabIndex = 0;
            this.fastColoredTextBox1.Zoom = 100;
            this.fastColoredTextBox1.TextChanged += new System.EventHandler<FastColoredTextBoxNS.TextChangedEventArgs>(this.fastColoredTextBox1_TextChanged);
            this.fastColoredTextBox1.Load += new System.EventHandler(this.fastColoredTextBox1_Load);
            this.fastColoredTextBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.fastColoredTextBox1_KeyUp);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(4, 364);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(107, 38);
            this.guna2Button1.TabIndex = 1;
            this.guna2Button1.Text = "Inject";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.Magenta;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(614, 30);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(156, 325);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // guna2Button2
            // 
            this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(117, 364);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(107, 38);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Execute";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Location = new System.Drawing.Point(230, 364);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(107, 38);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Open File";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Location = new System.Drawing.Point(343, 377);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(107, 25);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Save file";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Location = new System.Drawing.Point(663, 364);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(107, 38);
            this.guna2Button5.TabIndex = 6;
            this.guna2Button5.Text = "Refresh";
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Location = new System.Drawing.Point(456, 364);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(107, 38);
            this.guna2Button6.TabIndex = 7;
            this.guna2Button6.Text = "Clear";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click);
            // 
            // savetextbox
            // 
            this.savetextbox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.savetextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.savetextbox.DefaultText = "";
            this.savetextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.savetextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.savetextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.savetextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.savetextbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.savetextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.savetextbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.savetextbox.ForeColor = System.Drawing.Color.Lime;
            this.savetextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.savetextbox.Location = new System.Drawing.Point(344, 361);
            this.savetextbox.Name = "savetextbox";
            this.savetextbox.PasswordChar = '\0';
            this.savetextbox.PlaceholderText = "";
            this.savetextbox.SelectedText = "";
            this.savetextbox.Size = new System.Drawing.Size(106, 14);
            this.savetextbox.TabIndex = 8;
            // 
            // guna2Button7
            // 
            this.guna2Button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Location = new System.Drawing.Point(614, 4);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(156, 20);
            this.guna2Button7.TabIndex = 9;
            this.guna2Button7.Text = "Delete Script";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button8
            // 
            this.guna2Button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button8.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button8.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button8.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button8.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button8.ForeColor = System.Drawing.Color.White;
            this.guna2Button8.Location = new System.Drawing.Point(582, 364);
            this.guna2Button8.Name = "guna2Button8";
            this.guna2Button8.Size = new System.Drawing.Size(75, 38);
            this.guna2Button8.TabIndex = 10;
            this.guna2Button8.Text = "Check is injected";
            this.guna2Button8.Click += new System.EventHandler(this.guna2Button8_Click);
            // 
            // uc_home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Button8);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.savetextbox);
            this.Controls.Add(this.guna2Button6);
            this.Controls.Add(this.guna2Button5);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.fastColoredTextBox1);
            this.Name = "uc_home";
            this.Size = new System.Drawing.Size(773, 405);
            this.Load += new System.EventHandler(this.uc_home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fastColoredTextBox1)).EndInit();
            this.ResumeLayout(false);

	}

	public void fastColoredTextBox1_Load(object sender, EventArgs e)
	{
	}

	private void fastColoredTextBox1_TextChanged(object sender, TextChangedEventArgs e)
	{
	}

	private void fastColoredTextBox1_KeyUp(object sender, KeyEventArgs e)
	{
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button7_Click(object sender, EventArgs e)
	{
		File.Delete("c:\\mikusdevPrograms\\ezsploit\\Scripts\\" + listBox1.SelectedItem);
		listBox1.Items.Clear();
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", "*.txt");
		Functions.PopulateListBox(listBox1, "c:\\mikusdevPrograms\\ezsploit\\Scripts", " *.lua");
	}

    private void guna2Button8_Click(object sender, EventArgs e)
    {
        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "EasyExploits")
        {
            ezsploitex.ExecuteScript("wait(1.2)\r\ngame.StarterGui:SetCore(\"SendNotification\", {\r\nTitle    = \"EzSploit is injected\";\r\nText     = \"you can now execute scripts\";\r\nDuration = 10; \r\n})\r\n");
        }
        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "Krnl")
        {
            ezsploitkrnl.Execute("wait(1.2)\r\ngame.StarterGui:SetCore(\"SendNotification\", {\r\nTitle    = \"EzSploit is injected\";\r\nText     = \"you can now execute scripts\";\r\nDuration = 10; \r\n})\r\n");
        }
        if (File.ReadAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedAPI.txt") == "WRD")
        {
            string script = "wait(1.2)\r\ngame.StarterGui:SetCore(\"SendNotification\", {\r\nTitle    = \"EzSploit is injected\";\r\nText     = \"you can now execute scripts\";\r\nDuration = 10; \r\n})\r\n";
            ezsploitwrd.SendLuaScript(script);
        }
    }
}
