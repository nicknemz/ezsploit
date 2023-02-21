using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using AxonSimpleUI;
using EasyExploits;
using EzSploit_REBORN.Properties;
using EzSploit_V3;
using FastColoredTextBoxNS;
using Guna.UI2.WinForms;
using KrnlAPI;

namespace EzSploit_REBORN.UserControls;

public class uc_home : UserControl
{
	private KrnlApi ezsploitkrnl = new KrnlApi();

	private Module ezsploitex = new Module();

	private IContainer components = null;

	private FastColoredTextBox fastColoredTextBox1;

	private Guna2Button guna2Button1;

	private ListBox listBox1;

	private Guna2Button guna2Button2;

	private Guna2Button guna2Button3;

	private Guna2Button guna2Button4;

	private Guna2Button guna2Button5;

	private Guna2Button guna2Button6;

	public uc_home()
	{
		InitializeComponent();
        if (File.ReadAllText("./Configs/selectedTheme.txt") == "galaxy")
		{
			BackgroundImage = Resources.starsback;
			fastColoredTextBox1.BackgroundImage = Resources.starsback;
		}
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "classic")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources._20_20_20;
		}
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "sus")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources.anime2;
		}
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "nsfw")
		{
			BackgroundImage = Resources._40_40_40;
			fastColoredTextBox1.BackgroundImage = Resources.anime31;
		}
		listBox1.Items.Clear();
		Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
		Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
		if (File.ReadAllText("./Configs/textboxreset.txt") == "doreset")
		{
			fastColoredTextBox1.Text = "-- Welcome to EzSploit--\r\n--V4--\r\n\r\n--Created by mikusweb(or MikusseQ, Mikq, mikusDEV, mikusgszyp)--\r\n\r\n--Version 4.0--\r\n\r\n--Help in \"Info\" tab--\r\n\r\n--You can select theme in options--\r\n\r\n--API supported:EasyExploits, KRNL --\r\n\r\n--You can request more APIs in comments--\r\n--on EzSploit Website (linked in \"Info\")--";
			File.WriteAllText("./Configs/textboxreset.txt", "dontreset");
			File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
		}
		if (File.ReadAllText("./Configs/textboxreset.txt") == "dontreset")
		{
			fastColoredTextBox1.Text = File.ReadAllText("./Configs/textboxconf.txt");
			File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
		}
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

    private void uc_home_Load(object sender, EventArgs e)
	{
	}

	private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
	{
		fastColoredTextBox1.Text = File.ReadAllText($"./Scripts/{listBox1.SelectedItem}");
		File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
		ezsploitkrnl.Initialize();
		wait(1000);
        if (File.ReadAllText("./Configs/selectedAPI.txt") == "EasyExploits")
		{
			ezsploitex.LaunchExploit();
		}
		if (File.ReadAllText("./Configs/selectedAPI.txt") == "Krnl")
		{
            krnlfix_ krnlfix = new krnlfix_();
            DialogResult dialogResult = krnlfix.ShowDialog();
		}
        if (File.ReadAllText("./Configs/selectedAPI.txt") == "mdev")
        {
            Functions.Inject();
        }
        File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
		if (File.ReadAllText("./Configs/selectedAPI.txt") == "EasyExploits")
		{
			ezsploitex.ExecuteScript(fastColoredTextBox1.Text);
		}
		if (File.ReadAllText("./Configs/selectedAPI.txt") == "Krnl")
		{
			ezsploitkrnl.Execute(fastColoredTextBox1.Text);
		}
        if (File.ReadAllText("./Configs/selectedAPI.txt") == "mdev")
        {
            //ZROB TO ZJEBIE
            if (NamedPipes.NamedPipeExist(NamedPipes.luapipename))//check if the pipe exist
            {
                NamedPipes.LuaPipe(fastColoredTextBox1.Text);//lua pipe function to send the script
            }
            else
            {
                MessageBox.Show($"Inject {Functions.exploitdllname} before Using this!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//if the pipe can't be found a messagebox will appear
                return;
            }
        }
        File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button3_Click(object sender, EventArgs e)
	{
		OpenFileDialog openFileDialog = new OpenFileDialog();
		if (openFileDialog.ShowDialog() == DialogResult.OK)
		{
			openFileDialog.Title = "Open";
			fastColoredTextBox1.Text = File.ReadAllText(openFileDialog.FileName);
		}
		File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button4_Click(object sender, EventArgs e)
	{
        SaveWindow_ saveWindow_ = new SaveWindow_();
        DialogResult dialogResult = saveWindow_.ShowDialog(); 
		
		
		SaveFileDialog saveFileDialog = new SaveFileDialog();
		if (saveFileDialog.ShowDialog() != DialogResult.OK)
		{
			return;
		}
		using Stream stream = File.Open(saveFileDialog.FileName, FileMode.CreateNew);
		using StreamWriter streamWriter = new StreamWriter(stream);
		streamWriter.Write(fastColoredTextBox1.Text);
		File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
		fastColoredTextBox1.Clear();
		File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
	}

	private void guna2Button5_Click(object sender, EventArgs e)
	{
		listBox1.Items.Clear();
		Functions.PopulateListBox(listBox1, "./Scripts", "*.txt");
		Functions.PopulateListBox(listBox1, "./Scripts", "*.lua");
		File.WriteAllText("./Configs/textboxconf.txt", fastColoredTextBox1.Text);
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
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EzSploit_REBORN.UserControls.uc_home));
		this.fastColoredTextBox1 = new FastColoredTextBoxNS.FastColoredTextBox();
		this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
		this.listBox1 = new System.Windows.Forms.ListBox();
		this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
		((System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).BeginInit();
		base.SuspendLayout();
		this.fastColoredTextBox1.AutoCompleteBracketsList = new char[10] { '(', ')', '{', '}', '[', ']', '"', '"', '\'', '\'' };
		this.fastColoredTextBox1.AutoScrollMinSize = new System.Drawing.Size(27, 14);
		this.fastColoredTextBox1.BackBrush = null;
		this.fastColoredTextBox1.CharHeight = 14;
		this.fastColoredTextBox1.CharWidth = 8;
		this.fastColoredTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
		this.fastColoredTextBox1.DisabledColor = System.Drawing.Color.FromArgb(100, 180, 180, 180);
		this.fastColoredTextBox1.Font = new System.Drawing.Font("Courier New", 9.75f);
		this.fastColoredTextBox1.ForeColor = System.Drawing.Color.Lime;
		this.fastColoredTextBox1.IndentBackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.fastColoredTextBox1.IsReplaceMode = false;
		this.fastColoredTextBox1.Location = new System.Drawing.Point(4, 4);
		this.fastColoredTextBox1.Name = "fastColoredTextBox1";
		this.fastColoredTextBox1.Paddings = new System.Windows.Forms.Padding(0);
		this.fastColoredTextBox1.SelectionColor = System.Drawing.Color.FromArgb(60, 0, 0, 255);
		this.fastColoredTextBox1.ServiceColors = (FastColoredTextBoxNS.ServiceColors)resources.GetObject("fastColoredTextBox1.ServiceColors");
		this.fastColoredTextBox1.Size = new System.Drawing.Size(604, 351);
		this.fastColoredTextBox1.TabIndex = 0;
		this.fastColoredTextBox1.Zoom = 100;
		this.fastColoredTextBox1.Load += new System.EventHandler(fastColoredTextBox1_Load);
		this.guna2Button1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button1.ForeColor = System.Drawing.Color.White;
		this.guna2Button1.Location = new System.Drawing.Point(4, 364);
		this.guna2Button1.Name = "guna2Button1";
		this.guna2Button1.Size = new System.Drawing.Size(107, 38);
		this.guna2Button1.TabIndex = 1;
		this.guna2Button1.Text = "Inject";
		this.guna2Button1.Click += new System.EventHandler(guna2Button1_Click);
		this.listBox1.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.listBox1.ForeColor = System.Drawing.Color.Magenta;
		this.listBox1.FormattingEnabled = true;
		this.listBox1.Location = new System.Drawing.Point(614, 4);
		this.listBox1.Name = "listBox1";
		this.listBox1.Size = new System.Drawing.Size(156, 351);
		this.listBox1.TabIndex = 2;
		this.listBox1.SelectedIndexChanged += new System.EventHandler(listBox1_SelectedIndexChanged);
		this.guna2Button2.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button2.ForeColor = System.Drawing.Color.White;
		this.guna2Button2.Location = new System.Drawing.Point(117, 364);
		this.guna2Button2.Name = "guna2Button2";
		this.guna2Button2.Size = new System.Drawing.Size(107, 38);
		this.guna2Button2.TabIndex = 3;
		this.guna2Button2.Text = "Execute";
		this.guna2Button2.Click += new System.EventHandler(guna2Button2_Click);
		this.guna2Button3.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button3.ForeColor = System.Drawing.Color.White;
		this.guna2Button3.Location = new System.Drawing.Point(230, 364);
		this.guna2Button3.Name = "guna2Button3";
		this.guna2Button3.Size = new System.Drawing.Size(107, 38);
		this.guna2Button3.TabIndex = 4;
		this.guna2Button3.Text = "Open File";
		this.guna2Button3.Click += new System.EventHandler(guna2Button3_Click);
		this.guna2Button4.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button4.ForeColor = System.Drawing.Color.White;
		this.guna2Button4.Location = new System.Drawing.Point(343, 364);
		this.guna2Button4.Name = "guna2Button4";
		this.guna2Button4.Size = new System.Drawing.Size(107, 38);
		this.guna2Button4.TabIndex = 5;
		this.guna2Button4.Text = "Save file";
		this.guna2Button4.Click += new System.EventHandler(guna2Button4_Click);
		this.guna2Button5.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button5.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button5.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button5.ForeColor = System.Drawing.Color.White;
		this.guna2Button5.Location = new System.Drawing.Point(663, 364);
		this.guna2Button5.Name = "guna2Button5";
		this.guna2Button5.Size = new System.Drawing.Size(107, 38);
		this.guna2Button5.TabIndex = 6;
		this.guna2Button5.Text = "Refresh";
		this.guna2Button5.Click += new System.EventHandler(guna2Button5_Click);
		this.guna2Button6.BackColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button6.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button6.ForeColor = System.Drawing.Color.White;
		this.guna2Button6.Location = new System.Drawing.Point(501, 364);
		this.guna2Button6.Name = "guna2Button6";
		this.guna2Button6.Size = new System.Drawing.Size(107, 38);
		this.guna2Button6.TabIndex = 7;
		this.guna2Button6.Text = "Clear";
		this.guna2Button6.Click += new System.EventHandler(guna2Button6_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		base.Controls.Add(this.guna2Button6);
		base.Controls.Add(this.guna2Button5);
		base.Controls.Add(this.guna2Button4);
		base.Controls.Add(this.guna2Button3);
		base.Controls.Add(this.guna2Button2);
		base.Controls.Add(this.listBox1);
		base.Controls.Add(this.guna2Button1);
		base.Controls.Add(this.fastColoredTextBox1);
		base.Name = "uc_home";
		base.Size = new System.Drawing.Size(773, 405);
		base.Load += new System.EventHandler(uc_home_Load);
		((System.ComponentModel.ISupportInitialize)this.fastColoredTextBox1).EndInit();
		base.ResumeLayout(false);
	}

	public void fastColoredTextBox1_Load(object sender, EventArgs e)
	{
	}
}
