namespace CyberSmith
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption3;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1898, 1024);
            this.axWindowsMediaPlayer1.TabIndex = 1;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // panelMenu
            // 
            // panelMenu
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Top |
                                    System.Windows.Forms.AnchorStyles.Bottom |
                                    System.Windows.Forms.AnchorStyles.Left |
                                    System.Windows.Forms.AnchorStyles.Right;
            this.panelMenu.BackgroundImage = global::CyberSmith.Properties.Resources.background;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.btnOption1);
            this.panelMenu.Controls.Add(this.btnOption2);
            this.panelMenu.Controls.Add(this.btnOption3);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1898, 1024);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Visible = false;
            // 
            // btnOption1
            // 
            this.btnOption1.BackColor = System.Drawing.Color.Transparent;
            this.btnOption1.BackgroundImage = global::CyberSmith.Properties.Resources.blue_button;
            this.btnOption1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption1.FlatAppearance.BorderSize = 0;
            this.btnOption1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption1.Location = new System.Drawing.Point(303, 724);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(318, 115);
            this.btnOption1.TabIndex = 1;
            this.btnOption1.UseVisualStyleBackColor = false;
            this.btnOption1.Click += new System.EventHandler(this.btnOption1_Click);
            // 
            // btnOption2
            // 
            this.btnOption2.BackColor = System.Drawing.Color.Transparent;
            this.btnOption2.BackgroundImage = global::CyberSmith.Properties.Resources.red_button;
            this.btnOption2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption2.FlatAppearance.BorderSize = 0;
            this.btnOption2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption2.Location = new System.Drawing.Point(807, 724);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(318, 115);
            this.btnOption2.TabIndex = 2;
            this.btnOption2.UseVisualStyleBackColor = false;
            this.btnOption2.Click += new System.EventHandler(this.btnOption2_Click);
            // 
            // btnOption3
            // 
            this.btnOption3.BackColor = System.Drawing.Color.Transparent;
            this.btnOption3.BackgroundImage = global::CyberSmith.Properties.Resources.green_button;
            this.btnOption3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOption3.FlatAppearance.BorderSize = 0;
            this.btnOption3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOption3.Location = new System.Drawing.Point(1296, 724);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(318, 115);
            this.btnOption3.TabIndex = 3;
            this.btnOption3.UseVisualStyleBackColor = false;
            this.btnOption3.Click += new System.EventHandler(this.btnOption3_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cyber Smith";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}