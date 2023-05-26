namespace EzSploit
{
    partial class oxygenkeysystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.keytextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(199, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "Get Key";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(231, 49);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(199, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "Check key";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // keytextbox
            // 
            this.keytextbox.Location = new System.Drawing.Point(12, 12);
            this.keytextbox.Name = "keytextbox";
            this.keytextbox.Size = new System.Drawing.Size(418, 20);
            this.keytextbox.TabIndex = 2;
            // 
            // oxygenkeysystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 150);
            this.Controls.Add(this.keytextbox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "oxygenkeysystem";
            this.Text = "oxygenkeysystem";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox keytextbox;
    }
}