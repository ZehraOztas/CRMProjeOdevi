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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlKisiListesi = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlBilgi = new Bunifu.UI.WinForms.BunifuPanel();
            this.pnlChat.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.Transparent;
            this.pnlChat.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChat.BorderRadius = 15;
            this.pnlChat.BorderThickness = 1;
            this.pnlChat.Controls.Add(this.pnlBilgi);
            this.pnlChat.Controls.Add(this.pnlKisiListesi);
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlKisiListesi
            // 
            this.pnlKisiListesi.BackgroundColor = System.Drawing.Color.LightGray;
            this.pnlKisiListesi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlKisiListesi.BackgroundImage")));
            this.pnlKisiListesi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlKisiListesi.BorderColor = System.Drawing.Color.Transparent;
            this.pnlKisiListesi.BorderRadius = 30;
            this.pnlKisiListesi.BorderThickness = 1;
            this.pnlKisiListesi.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKisiListesi.Location = new System.Drawing.Point(0, 0);
            this.pnlKisiListesi.Name = "pnlKisiListesi";
            this.pnlKisiListesi.ShowBorders = true;
            this.pnlKisiListesi.Size = new System.Drawing.Size(212, 699);
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
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBilgi.Location = new System.Drawing.Point(212, 0);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.ShowBorders = true;
            this.pnlBilgi.Size = new System.Drawing.Size(1015, 699);
            this.pnlBilgi.TabIndex = 5;
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
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlChat;
        public Bunifu.UI.WinForms.BunifuPanel pnlKisiListesi;
        public System.Windows.Forms.Timer timer1;
        public Bunifu.UI.WinForms.BunifuPanel pnlBilgi;
    }
}