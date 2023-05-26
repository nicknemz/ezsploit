namespace EzSploit.usercontrols
{
    partial class uc_main
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Button15 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button11 = new Guna.UI2.WinForms.Guna2Button();
            this.script7 = new Guna.UI2.WinForms.Guna2Button();
            this.script6 = new Guna.UI2.WinForms.Guna2Button();
            this.script5 = new Guna.UI2.WinForms.Guna2Button();
            this.script4 = new Guna.UI2.WinForms.Guna2Button();
            this.script3 = new Guna.UI2.WinForms.Guna2Button();
            this.script2 = new Guna.UI2.WinForms.Guna2Button();
            this.script1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.selectedapitext = new System.Windows.Forms.Label();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Button7 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.MonacoEditor = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonacoEditor)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(572, 29);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(165, 312);
            this.listBox1.TabIndex = 1;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.guna2Button15);
            this.panel1.Controls.Add(this.guna2Button11);
            this.panel1.Controls.Add(this.script7);
            this.panel1.Controls.Add(this.script6);
            this.panel1.Controls.Add(this.script5);
            this.panel1.Controls.Add(this.script4);
            this.panel1.Controls.Add(this.script3);
            this.panel1.Controls.Add(this.script2);
            this.panel1.Controls.Add(this.script1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 25);
            this.panel1.TabIndex = 11;
            // 
            // guna2Button15
            // 
            this.guna2Button15.Animated = true;
            this.guna2Button15.BorderRadius = 5;
            this.guna2Button15.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button15.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button15.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button15.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button15.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button15.ForeColor = System.Drawing.Color.White;
            this.guna2Button15.Image = global::EzSploit.Properties.Resources.minus;
            this.guna2Button15.Location = new System.Drawing.Point(691, 5);
            this.guna2Button15.Name = "guna2Button15";
            this.guna2Button15.Size = new System.Drawing.Size(20, 20);
            this.guna2Button15.TabIndex = 20;
            this.guna2Button15.Click += new System.EventHandler(this.guna2Button15_Click);
            // 
            // guna2Button11
            // 
            this.guna2Button11.Animated = true;
            this.guna2Button11.BackgroundImage = global::EzSploit.Properties.Resources.plus;
            this.guna2Button11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.guna2Button11.BorderRadius = 5;
            this.guna2Button11.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button11.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button11.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button11.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button11.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button11.ForeColor = System.Drawing.Color.White;
            this.guna2Button11.Location = new System.Drawing.Point(717, 5);
            this.guna2Button11.Name = "guna2Button11";
            this.guna2Button11.Size = new System.Drawing.Size(20, 20);
            this.guna2Button11.TabIndex = 19;
            this.guna2Button11.Text = "Script1";
            this.guna2Button11.Click += new System.EventHandler(this.guna2Button11_Click);
            // 
            // script7
            // 
            this.script7.Animated = true;
            this.script7.BorderRadius = 5;
            this.script7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script7.ForeColor = System.Drawing.Color.White;
            this.script7.Location = new System.Drawing.Point(477, 6);
            this.script7.Name = "script7";
            this.script7.Size = new System.Drawing.Size(73, 19);
            this.script7.TabIndex = 18;
            this.script7.Text = "Script7";
            this.script7.Click += new System.EventHandler(this.script7_Click);
            // 
            // script6
            // 
            this.script6.Animated = true;
            this.script6.BorderRadius = 5;
            this.script6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script6.ForeColor = System.Drawing.Color.White;
            this.script6.Location = new System.Drawing.Point(398, 6);
            this.script6.Name = "script6";
            this.script6.Size = new System.Drawing.Size(73, 19);
            this.script6.TabIndex = 17;
            this.script6.Text = "Script6";
            this.script6.Click += new System.EventHandler(this.script6_Click);
            // 
            // script5
            // 
            this.script5.Animated = true;
            this.script5.BorderRadius = 5;
            this.script5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script5.ForeColor = System.Drawing.Color.White;
            this.script5.Location = new System.Drawing.Point(319, 6);
            this.script5.Name = "script5";
            this.script5.Size = new System.Drawing.Size(73, 19);
            this.script5.TabIndex = 16;
            this.script5.Text = "Script5";
            this.script5.Click += new System.EventHandler(this.script5_Click);
            // 
            // script4
            // 
            this.script4.Animated = true;
            this.script4.BorderRadius = 5;
            this.script4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script4.ForeColor = System.Drawing.Color.White;
            this.script4.Location = new System.Drawing.Point(240, 6);
            this.script4.Name = "script4";
            this.script4.Size = new System.Drawing.Size(73, 19);
            this.script4.TabIndex = 15;
            this.script4.Text = "Script4";
            this.script4.Click += new System.EventHandler(this.script4_Click);
            // 
            // script3
            // 
            this.script3.Animated = true;
            this.script3.BorderRadius = 5;
            this.script3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script3.ForeColor = System.Drawing.Color.White;
            this.script3.Location = new System.Drawing.Point(161, 6);
            this.script3.Name = "script3";
            this.script3.Size = new System.Drawing.Size(73, 19);
            this.script3.TabIndex = 14;
            this.script3.Text = "Script3";
            this.script3.Click += new System.EventHandler(this.script3_Click);
            // 
            // script2
            // 
            this.script2.Animated = true;
            this.script2.BorderRadius = 5;
            this.script2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script2.ForeColor = System.Drawing.Color.White;
            this.script2.Location = new System.Drawing.Point(82, 6);
            this.script2.Name = "script2";
            this.script2.Size = new System.Drawing.Size(73, 19);
            this.script2.TabIndex = 13;
            this.script2.Text = "Script2";
            this.script2.Click += new System.EventHandler(this.script2_Click);
            // 
            // script1
            // 
            this.script1.Animated = true;
            this.script1.BorderRadius = 5;
            this.script1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.script1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.script1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.script1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.script1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.script1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.script1.ForeColor = System.Drawing.Color.White;
            this.script1.Location = new System.Drawing.Point(3, 6);
            this.script1.Name = "script1";
            this.script1.Size = new System.Drawing.Size(73, 19);
            this.script1.TabIndex = 12;
            this.script1.Text = "Script1";
            this.script1.Click += new System.EventHandler(this.script1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(375, 403);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Selected API: ";
            // 
            // selectedapitext
            // 
            this.selectedapitext.AutoSize = true;
            this.selectedapitext.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.selectedapitext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.selectedapitext.Location = new System.Drawing.Point(454, 403);
            this.selectedapitext.Name = "selectedapitext";
            this.selectedapitext.Size = new System.Drawing.Size(26, 15);
            this.selectedapitext.TabIndex = 13;
            this.selectedapitext.Text = "API";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.ForeColor = System.Drawing.Color.Orange;
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(572, 346);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(165, 19);
            this.guna2TextBox1.TabIndex = 9;
            // 
            // guna2Button7
            // 
            this.guna2Button7.Animated = true;
            this.guna2Button7.BorderRadius = 5;
            this.guna2Button7.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button7.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button7.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button7.ForeColor = System.Drawing.Color.White;
            this.guna2Button7.Image = global::EzSploit.Properties.Resources._1345874;
            this.guna2Button7.Location = new System.Drawing.Point(572, 386);
            this.guna2Button7.Name = "guna2Button7";
            this.guna2Button7.Size = new System.Drawing.Size(165, 40);
            this.guna2Button7.TabIndex = 8;
            this.guna2Button7.Text = "Delete selected";
            this.guna2Button7.Click += new System.EventHandler(this.guna2Button7_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.Animated = true;
            this.guna2Button4.BorderRadius = 5;
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::EzSploit.Properties.Resources._77705;
            this.guna2Button4.Location = new System.Drawing.Point(251, 386);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(118, 40);
            this.guna2Button4.TabIndex = 5;
            this.guna2Button4.Text = "Clear";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.Animated = true;
            this.guna2Button3.BorderRadius = 5;
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = global::EzSploit.Properties.Resources._25398;
            this.guna2Button3.ImageSize = new System.Drawing.Size(18, 18);
            this.guna2Button3.Location = new System.Drawing.Point(571, 367);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(166, 19);
            this.guna2Button3.TabIndex = 4;
            this.guna2Button3.Text = "Save to Scripts";
            this.guna2Button3.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.Animated = true;
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::EzSploit.Properties.Resources.file_open_2;
            this.guna2Button2.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2Button2.Location = new System.Drawing.Point(127, 386);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(118, 40);
            this.guna2Button2.TabIndex = 3;
            this.guna2Button2.Text = "Open File";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.Animated = true;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::EzSploit.Properties.Resources.Octicons_cloud_upload_svg;
            this.guna2Button1.Location = new System.Drawing.Point(3, 386);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(118, 40);
            this.guna2Button1.TabIndex = 2;
            this.guna2Button1.Text = "Execute";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Location = new System.Drawing.Point(158, 181);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(75, 23);
            this.webView21.TabIndex = 14;
            this.webView21.ZoomFactor = 1D;
            // 
            // MonacoEditor
            // 
            this.MonacoEditor.AllowExternalDrop = true;
            this.MonacoEditor.CreationProperties = null;
            this.MonacoEditor.DefaultBackgroundColor = System.Drawing.Color.White;
            this.MonacoEditor.Location = new System.Drawing.Point(3, 29);
            this.MonacoEditor.Name = "MonacoEditor";
            this.MonacoEditor.Size = new System.Drawing.Size(562, 351);
            this.MonacoEditor.Source = new System.Uri("file:///C:/mikusdevPrograms/ezsploit/monaco-editor/index.html", System.UriKind.Absolute);
            this.MonacoEditor.TabIndex = 15;
            this.MonacoEditor.ZoomFactor = 1D;
            this.MonacoEditor.CoreWebView2InitializationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs>(this.MonacoEditor_CoreWebView2InitializationCompleted);
            this.MonacoEditor.ContentLoading += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2ContentLoadingEventArgs>(this.MonacoEditor_ContentLoading);
            this.MonacoEditor.Click += new System.EventHandler(this.MonacoEditor_Click);
            this.MonacoEditor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MonacoEditor_KeyDown);
            this.MonacoEditor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MonacoEditor_KeyPress);
            this.MonacoEditor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MonacoEditor_KeyUp);
            // 
            // uc_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.MonacoEditor);
            this.Controls.Add(this.webView21);
            this.Controls.Add(this.selectedapitext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.guna2Button7);
            this.Controls.Add(this.guna2Button4);
            this.Controls.Add(this.guna2Button3);
            this.Controls.Add(this.guna2Button2);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.listBox1);
            this.Name = "uc_main";
            this.Size = new System.Drawing.Size(740, 429);
            this.Load += new System.EventHandler(this.uc_main_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MonacoEditor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button guna2Button7;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button15;
        private Guna.UI2.WinForms.Guna2Button guna2Button11;
        private Guna.UI2.WinForms.Guna2Button script7;
        private Guna.UI2.WinForms.Guna2Button script6;
        private Guna.UI2.WinForms.Guna2Button script5;
        private Guna.UI2.WinForms.Guna2Button script4;
        private Guna.UI2.WinForms.Guna2Button script3;
        private Guna.UI2.WinForms.Guna2Button script2;
        private Guna.UI2.WinForms.Guna2Button script1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label selectedapitext;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Microsoft.Web.WebView2.WinForms.WebView2 MonacoEditor;
    }
}
