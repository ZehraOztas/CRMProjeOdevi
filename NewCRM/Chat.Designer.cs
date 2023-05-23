namespace NewCRM
{
    partial class Chat
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.pnlChat = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblkisiSec = new System.Windows.Forms.Label();
            this.pnlKisiListesi = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlBilgi = new Bunifu.UI.WinForms.BunifuPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlChat.SuspendLayout();
            this.bunifuPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.Transparent;
            this.pnlChat.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChat.BorderRadius = 15;
            this.pnlChat.BorderThickness = 1;
            this.pnlChat.Controls.Add(this.bunifuPanel1);
            this.pnlChat.Controls.Add(this.pnlKisiListesi);
            this.pnlChat.Controls.Add(this.pnlBilgi);
            this.pnlChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChat.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlChat.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlChat.Location = new System.Drawing.Point(0, 0);
            this.pnlChat.Name = "pnlChat";
            this.pnlChat.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChat.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlChat.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlChat.ShadowDept = 2;
            this.pnlChat.ShadowDepth = 5;
            this.pnlChat.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnlChat.ShadowTopLeftVisible = false;
            this.pnlChat.Size = new System.Drawing.Size(1227, 699);
            this.pnlChat.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlChat.TabIndex = 0;
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.LightGray;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 30;
            this.bunifuPanel1.BorderThickness = 1;
            this.bunifuPanel1.Controls.Add(this.lblkisiSec);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(212, 80);
            this.bunifuPanel1.TabIndex = 5;
            // 
            // lblkisiSec
            // 
            this.lblkisiSec.AutoSize = true;
            this.lblkisiSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkisiSec.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblkisiSec.Location = new System.Drawing.Point(37, 25);
            this.lblkisiSec.Name = "lblkisiSec";
            this.lblkisiSec.Size = new System.Drawing.Size(110, 29);
            this.lblkisiSec.TabIndex = 0;
            this.lblkisiSec.Text = "Personel";
            this.lblkisiSec.Visible = false;
            // 
            // pnlKisiListesi
            // 
            this.pnlKisiListesi.BackgroundColor = System.Drawing.Color.LightGray;
            this.pnlKisiListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlKisiListesi.BackgroundImage")));
            this.pnlKisiListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlKisiListesi.BorderColor = System.Drawing.Color.Transparent;
            this.pnlKisiListesi.BorderRadius = 30;
            this.pnlKisiListesi.BorderThickness = 1;
            this.pnlKisiListesi.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlKisiListesi.Location = new System.Drawing.Point(0, 76);
            this.pnlKisiListesi.Name = "pnlKisiListesi";
            this.pnlKisiListesi.ShowBorders = true;
            this.pnlKisiListesi.Size = new System.Drawing.Size(212, 623);
            this.pnlKisiListesi.TabIndex = 4;
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlBilgi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBilgi.BackgroundImage")));
            this.pnlBilgi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBilgi.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBilgi.BorderRadius = 3;
            this.pnlBilgi.BorderThickness = 1;
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBilgi.Location = new System.Drawing.Point(212, 0);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.ShowBorders = true;
            this.pnlBilgi.Size = new System.Drawing.Size(1015, 699);
            this.pnlBilgi.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 699);
            this.Controls.Add(this.pnlChat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chat";
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            this.pnlChat.ResumeLayout(false);
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlChat;
        public System.Windows.Forms.Timer timer1;
        public Bunifu.UI.WinForms.BunifuPanel pnlBilgi;
        public Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        public Bunifu.UI.WinForms.BunifuPanel pnlKisiListesi;
        private System.Windows.Forms.Label lblkisiSec;
    }
}