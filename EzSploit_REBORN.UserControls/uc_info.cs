using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using EzSploit_REBORN.Properties;

namespace EzSploit_REBORN.UserControls;

public class uc_info : UserControl
{
	private IContainer components = null;

	private Label label1;

	private Label label2;

	private Label label3;

	private Label label4;

	private Label label5;

	private Label label6;

	private Label label7;

	private Label label8;

	private LinkLabel linkLabel4;

	private LinkLabel linkLabel3;

	private LinkLabel linkLabel2;

	private LinkLabel linkLabel1;

	public uc_info()
	{
		InitializeComponent();
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "galaxy")
		{
			BackgroundImage = Resources.starsback;
		}
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "classic")
		{
			BackgroundImage = Resources._40_40_40;
		}
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "sus")
		{
			BackgroundImage = Resources.anime3;
		}
		if (File.ReadAllText("./Configs/selectedTheme.txt") == "nsfw")
		{
			BackgroundImage = Resources.hentai3;
		}
	}

	private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://krnl.place/predocs.html#krnlapi");
	}

	private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://easyexploits.com/");
	}

	private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://wearedevs.net/home");
	}

	private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
	{
		Process.Start("https://sites.google.com/view/mksdv/gry-i-pliki/ezsploit");
	}

	private void uc_info_Load(object sender, EventArgs e)
	{
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
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.label3 = new System.Windows.Forms.Label();
		this.label4 = new System.Windows.Forms.Label();
		this.label5 = new System.Windows.Forms.Label();
		this.label6 = new System.Windows.Forms.Label();
		this.label7 = new System.Windows.Forms.Label();
		this.label8 = new System.Windows.Forms.Label();
		this.linkLabel4 = new System.Windows.Forms.LinkLabel();
		this.linkLabel3 = new System.Windows.Forms.LinkLabel();
		this.linkLabel2 = new System.Windows.Forms.LinkLabel();
		this.linkLabel1 = new System.Windows.Forms.LinkLabel();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.Transparent;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
		this.label1.Location = new System.Drawing.Point(22, 36);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(126, 24);
		this.label1.TabIndex = 4;
		this.label1.Text = "How to use?";
		this.label2.AutoSize = true;
		this.label2.BackColor = System.Drawing.Color.Transparent;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
		this.label2.Location = new System.Drawing.Point(23, 75);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(178, 64);
		this.label2.TabIndex = 5;
		this.label2.Text = "When roblox launched, click\r\ninject and wait for exploit to\r\ninject. Then select script from\r\nlist and click Execute!\r\n";
		this.label3.AutoSize = true;
		this.label3.BackColor = System.Drawing.Color.Transparent;
		this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label3.ForeColor = System.Drawing.Color.RoyalBlue;
		this.label3.Location = new System.Drawing.Point(22, 190);
		this.label3.Name = "label3";
		this.label3.Size = new System.Drawing.Size(158, 24);
		this.label3.TabIndex = 6;
		this.label3.Text = "Add script to list";
		this.label4.AutoSize = true;
		this.label4.BackColor = System.Drawing.Color.Transparent;
		this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
		this.label4.Location = new System.Drawing.Point(27, 232);
		this.label4.Name = "label4";
		this.label4.Size = new System.Drawing.Size(153, 96);
		this.label4.TabIndex = 7;
		this.label4.Text = "You need a .txt or .lua file\r\nthat contains your script.\r\nYou just need to move\r\ntxt or lua file into \"scripts\"\r\nFolder and then Refresh\r\nscript list";
		this.label5.AutoSize = true;
		this.label5.BackColor = System.Drawing.Color.Transparent;
		this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label5.ForeColor = System.Drawing.Color.RoyalBlue;
		this.label5.Location = new System.Drawing.Point(509, 36);
		this.label5.Name = "label5";
		this.label5.Size = new System.Drawing.Size(183, 24);
		this.label5.TabIndex = 8;
		this.label5.Text = "Can't inject Exploit";
		this.label6.AutoSize = true;
		this.label6.BackColor = System.Drawing.Color.Transparent;
		this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
		this.label6.Location = new System.Drawing.Point(510, 75);
		this.label6.Name = "label6";
		this.label6.Size = new System.Drawing.Size(234, 96);
		this.label6.TabIndex = 9;
		this.label6.Text = "Try another API (change in settings)\r\nor update api's via websites linked\r\nbelow. Just download API and replace\r\nold file to new.\r\nAnd remember to Extract all Exploit\r\nfiles :D";
		this.label7.AutoSize = true;
		this.label7.BackColor = System.Drawing.Color.Transparent;
		this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label7.ForeColor = System.Drawing.Color.RoyalBlue;
		this.label7.Location = new System.Drawing.Point(509, 190);
		this.label7.Name = "label7";
		this.label7.Size = new System.Drawing.Size(86, 24);
		this.label7.TabIndex = 14;
		this.label7.Text = "Updates\r\n";
		this.label8.AutoSize = true;
		this.label8.BackColor = System.Drawing.Color.Transparent;
		this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
		this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
		this.label8.Location = new System.Drawing.Point(510, 232);
		this.label8.Name = "label8";
		this.label8.Size = new System.Drawing.Size(165, 48);
		this.label8.TabIndex = 15;
		this.label8.Text = "You can check for updates\r\non EzSploit website linked\r\nbelow";
		this.linkLabel4.AutoSize = true;
		this.linkLabel4.BackColor = System.Drawing.Color.Transparent;
		this.linkLabel4.Location = new System.Drawing.Point(3, 392);
		this.linkLabel4.Name = "linkLabel4";
		this.linkLabel4.Size = new System.Drawing.Size(122, 13);
		this.linkLabel4.TabIndex = 16;
		this.linkLabel4.TabStop = true;
		this.linkLabel4.Text = "Official EzSploit Website";
		this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel4_LinkClicked);
		this.linkLabel3.AutoSize = true;
		this.linkLabel3.BackColor = System.Drawing.Color.Transparent;
		this.linkLabel3.Location = new System.Drawing.Point(591, 392);
		this.linkLabel3.Name = "linkLabel3";
		this.linkLabel3.Size = new System.Drawing.Size(65, 13);
		this.linkLabel3.TabIndex = 17;
		this.linkLabel3.TabStop = true;
		this.linkLabel3.Text = "WeAreDevs";
		this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel3_LinkClicked);
		this.linkLabel2.AutoSize = true;
		this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
		this.linkLabel2.Location = new System.Drawing.Point(662, 392);
		this.linkLabel2.Name = "linkLabel2";
		this.linkLabel2.Size = new System.Drawing.Size(66, 13);
		this.linkLabel2.TabIndex = 18;
		this.linkLabel2.TabStop = true;
		this.linkLabel2.Text = "EasyExploits";
		this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel2_LinkClicked);
		this.linkLabel1.AutoSize = true;
		this.linkLabel1.BackColor = System.Drawing.Color.Transparent;
		this.linkLabel1.Location = new System.Drawing.Point(734, 392);
		this.linkLabel1.Name = "linkLabel1";
		this.linkLabel1.Size = new System.Drawing.Size(36, 13);
		this.linkLabel1.TabIndex = 19;
		this.linkLabel1.TabStop = true;
		this.linkLabel1.Text = "KRNL";
		this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(linkLabel1_LinkClicked);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
		base.Controls.Add(this.linkLabel1);
		base.Controls.Add(this.linkLabel2);
		base.Controls.Add(this.linkLabel3);
		base.Controls.Add(this.linkLabel4);
		base.Controls.Add(this.label8);
		base.Controls.Add(this.label7);
		base.Controls.Add(this.label6);
		base.Controls.Add(this.label5);
		base.Controls.Add(this.label4);
		base.Controls.Add(this.label3);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Name = "uc_info";
		base.Size = new System.Drawing.Size(773, 405);
		base.Load += new System.EventHandler(uc_info_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
