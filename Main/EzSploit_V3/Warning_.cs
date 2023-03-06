using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace EzSploit_V3;

public class Warning_ : Form
{
	private IContainer components;

	private Panel panel1;

	private Label label1;

	private Guna2DragControl guna2DragControl1;

	private Label label2;

	private Guna2Button guna2Button1;

	private Guna2Button guna2Button2;

	public Warning_()
	{
		InitializeComponent();
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
		Close();
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
		File.WriteAllText("c:\\mikusdevPrograms\\ezsploit\\Configs\\selectedTheme.txt", "nsfw");
		Close();
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
		this.panel1 = new System.Windows.Forms.Panel();
		this.label1 = new System.Windows.Forms.Label();
		this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
		this.label2 = new System.Windows.Forms.Label();
		this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
		this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
		this.panel1.SuspendLayout();
		base.SuspendLayout();
		this.panel1.BackColor = System.Drawing.Color.FromArgb(30, 30, 30);
		this.panel1.Controls.Add(this.label1);
		this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
		this.panel1.Location = new System.Drawing.Point(0, 0);
		this.panel1.Name = "panel1";
		this.panel1.Size = new System.Drawing.Size(465, 49);
		this.panel1.TabIndex = 0;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label1.ForeColor = System.Drawing.Color.Red;
		this.label1.Location = new System.Drawing.Point(180, 9);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(107, 24);
		this.label1.TabIndex = 0;
		this.label1.Text = "WARNING";
		this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6;
		this.guna2DragControl1.TargetControl = this.panel1;
		this.guna2DragControl1.UseTransparentDrag = true;
		this.label2.AutoSize = true;
		this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.Control;
		this.label2.Location = new System.Drawing.Point(93, 71);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(286, 40);
		this.label2.TabIndex = 1;
		this.label2.Text = "This theme contains adult content,\r\n do you want to continue?";
		this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button1.ForeColor = System.Drawing.Color.White;
		this.guna2Button1.Location = new System.Drawing.Point(97, 173);
		this.guna2Button1.Name = "guna2Button1";
		this.guna2Button1.Size = new System.Drawing.Size(133, 36);
		this.guna2Button1.TabIndex = 2;
		this.guna2Button1.Text = "Yes";
		this.guna2Button1.Click += new System.EventHandler(guna2Button1_Click);
		this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
		this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(169, 169, 169);
		this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(141, 141, 141);
		this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(20, 20, 20);
		this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9f);
		this.guna2Button2.ForeColor = System.Drawing.Color.White;
		this.guna2Button2.Location = new System.Drawing.Point(246, 173);
		this.guna2Button2.Name = "guna2Button2";
		this.guna2Button2.Size = new System.Drawing.Size(133, 36);
		this.guna2Button2.TabIndex = 3;
		this.guna2Button2.Text = "No";
		this.guna2Button2.Click += new System.EventHandler(guna2Button2_Click);
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.BackColor = System.Drawing.Color.FromArgb(40, 40, 40);
		base.ClientSize = new System.Drawing.Size(465, 240);
		base.Controls.Add(this.guna2Button2);
		base.Controls.Add(this.guna2Button1);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.panel1);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Name = "Warning_";
		this.Text = "Warning!";
		this.panel1.ResumeLayout(false);
		this.panel1.PerformLayout();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
