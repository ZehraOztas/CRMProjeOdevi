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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.pnlChat = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.pnlMesaj = new Bunifu.UI.WinForms.BunifuPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtIcerik = new Bunifu.UI.WinForms.BunifuTextBox();
            this.pbxGonder = new System.Windows.Forms.PictureBox();
            this.pnlTittle = new Bunifu.UI.WinForms.BunifuPanel();
            this.lblAd = new System.Windows.Forms.Label();
            this.pbxProfil = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnlİcerik = new Bunifu.UI.WinForms.BunifuPanel();
            this.uC_Gonderilen_Mesaj1 = new NewCRM.UC_Gonderilen_Mesaj();
            this.uC_Gelen_Mesaj1 = new NewCRM.UC_Gelen_Mesaj();
            this.pnlKisiListesi = new Bunifu.UI.WinForms.BunifuPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlChat.SuspendLayout();
            this.pnlMesaj.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGonder)).BeginInit();
            this.pnlTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).BeginInit();
            this.pnlİcerik.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChat
            // 
            this.pnlChat.BackColor = System.Drawing.Color.Transparent;
            this.pnlChat.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlChat.BorderRadius = 15;
            this.pnlChat.BorderThickness = 1;
            this.pnlChat.Controls.Add(this.pnlMesaj);
            this.pnlChat.Controls.Add(this.pnlTittle);
            this.pnlChat.Controls.Add(this.pnlİcerik);
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
        //    this.pnlChat.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.pnlChat_ControlAdded);
            // 
            // pnlMesaj
            // 
            this.pnlMesaj.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlMesaj.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlMesaj.BackgroundImage")));
            this.pnlMesaj.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMesaj.BorderColor = System.Drawing.Color.Transparent;
            this.pnlMesaj.BorderRadius = 25;
            this.pnlMesaj.BorderThickness = 1;
            this.pnlMesaj.Controls.Add(this.pictureBox1);
            this.pnlMesaj.Controls.Add(this.txtIcerik);
            this.pnlMesaj.Controls.Add(this.pbxGonder);
            this.pnlMesaj.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMesaj.Location = new System.Drawing.Point(212, 609);
            this.pnlMesaj.Name = "pnlMesaj";
            this.pnlMesaj.ShowBorders = true;
            this.pnlMesaj.Size = new System.Drawing.Size(1015, 90);
            this.pnlMesaj.TabIndex = 7;
            this.pnlMesaj.Visible = false;
           // this.pnlMesaj.Click += new System.EventHandler(this.pnlMesaj_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(902, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(23, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // txtIcerik
            // 
            this.txtIcerik.AcceptsReturn = false;
            this.txtIcerik.AcceptsTab = false;
            this.txtIcerik.AnimationSpeed = 200;
            this.txtIcerik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtIcerik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtIcerik.BackColor = System.Drawing.Color.Transparent;
            this.txtIcerik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("txtIcerik.BackgroundImage")));
            this.txtIcerik.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.txtIcerik.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtIcerik.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.txtIcerik.BorderColorIdle = System.Drawing.Color.Silver;
            this.txtIcerik.BorderRadius = 20;
            this.txtIcerik.BorderThickness = 1;
            this.txtIcerik.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtIcerik.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIcerik.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.txtIcerik.DefaultText = "";
            this.txtIcerik.FillColor = System.Drawing.Color.White;
            this.txtIcerik.HideSelection = true;
            this.txtIcerik.IconLeft = null;
            this.txtIcerik.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIcerik.IconPadding = 10;
            this.txtIcerik.IconRight = null;
            this.txtIcerik.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIcerik.Lines = new string[0];
            this.txtIcerik.Location = new System.Drawing.Point(5, 8);
            this.txtIcerik.MaxLength = 32767;
            this.txtIcerik.MinimumSize = new System.Drawing.Size(1, 1);
            this.txtIcerik.Modified = false;
            this.txtIcerik.Multiline = true;
            this.txtIcerik.Name = "txtIcerik";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIcerik.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtIcerik.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIcerik.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.txtIcerik.OnIdleState = stateProperties4;
            this.txtIcerik.Padding = new System.Windows.Forms.Padding(3);
            this.txtIcerik.PasswordChar = '\0';
            this.txtIcerik.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.txtIcerik.PlaceholderText = "Enter text";
            this.txtIcerik.ReadOnly = false;
            this.txtIcerik.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtIcerik.SelectedText = "";
            this.txtIcerik.SelectionLength = 0;
            this.txtIcerik.SelectionStart = 0;
            this.txtIcerik.ShortcutsEnabled = true;
            this.txtIcerik.Size = new System.Drawing.Size(921, 77);
            this.txtIcerik.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.txtIcerik.TabIndex = 0;
            this.txtIcerik.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIcerik.TextMarginBottom = 0;
            this.txtIcerik.TextMarginLeft = 3;
            this.txtIcerik.TextMarginTop = 0;
            this.txtIcerik.TextPlaceholder = "Enter text";
            this.txtIcerik.UseSystemPasswordChar = false;
            this.txtIcerik.WordWrap = true;
        //    this.txtIcerik.TextChanged += new System.EventHandler(this.txtIcerik_TextChanged);
            // 
            // pbxGonder
            // 
            this.pbxGonder.Image = ((System.Drawing.Image)(resources.GetObject("pbxGonder.Image")));
            this.pbxGonder.Location = new System.Drawing.Point(932, 22);
            this.pbxGonder.Name = "pbxGonder";
            this.pbxGonder.Size = new System.Drawing.Size(45, 56);
            this.pbxGonder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxGonder.TabIndex = 1;
            this.pbxGonder.TabStop = false;
            this.pbxGonder.Click += new System.EventHandler(this.pbxGonder_Click);
            // 
            // pnlTittle
            // 
            this.pnlTittle.BackgroundColor = System.Drawing.Color.LightGray;
            this.pnlTittle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTittle.BackgroundImage")));
            this.pnlTittle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlTittle.BorderColor = System.Drawing.Color.Transparent;
            this.pnlTittle.BorderRadius = 25;
            this.pnlTittle.BorderThickness = 1;
            this.pnlTittle.Controls.Add(this.lblAd);
            this.pnlTittle.Controls.Add(this.pbxProfil);
            this.pnlTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTittle.Location = new System.Drawing.Point(212, 0);
            this.pnlTittle.Name = "pnlTittle";
            this.pnlTittle.ShowBorders = true;
            this.pnlTittle.Size = new System.Drawing.Size(1015, 80);
            this.pnlTittle.TabIndex = 5;
            this.pnlTittle.Visible = false;
         //   this.pnlTittle.Click += new System.EventHandler(this.pnlTittle_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(97, 33);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(67, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad Soyad";
        //    this.lblAd.Click += new System.EventHandler(this.lblAd_Click);
            // 
            // pbxProfil
            // 
            this.pbxProfil.AllowFocused = false;
            this.pbxProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxProfil.AutoSizeHeight = true;
            this.pbxProfil.BorderRadius = 31;
            this.pbxProfil.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfil.Image")));
            this.pbxProfil.IsCircle = true;
            this.pbxProfil.Location = new System.Drawing.Point(17, 7);
            this.pbxProfil.Name = "pbxProfil";
            this.pbxProfil.Size = new System.Drawing.Size(62, 62);
            this.pbxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxProfil.TabIndex = 2;
            this.pbxProfil.TabStop = false;
            this.pbxProfil.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
        //    this.pbxProfil.Click += new System.EventHandler(this.pbxProfil_Click);
            // 
            // pnlİcerik
            // 
            this.pnlİcerik.AutoScroll = true;
            this.pnlİcerik.AutoSize = true;
            this.pnlİcerik.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlİcerik.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlİcerik.BackgroundImage")));
            this.pnlİcerik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlİcerik.BorderColor = System.Drawing.Color.Transparent;
            this.pnlİcerik.BorderRadius = 25;
            this.pnlİcerik.BorderThickness = 1;
            this.pnlİcerik.Controls.Add(this.uC_Gonderilen_Mesaj1);
            this.pnlİcerik.Controls.Add(this.uC_Gelen_Mesaj1);
            this.pnlİcerik.Location = new System.Drawing.Point(216, 75);
            this.pnlİcerik.Name = "pnlİcerik";
            this.pnlİcerik.ShowBorders = true;
            this.pnlİcerik.Size = new System.Drawing.Size(1008, 529);
            this.pnlİcerik.TabIndex = 6;
            this.pnlİcerik.Visible = false;
       //     this.pnlİcerik.Click += new System.EventHandler(this.pnlİcerik_Click);
            // 
            // uC_Gonderilen_Mesaj1
            // 
            this.uC_Gonderilen_Mesaj1.Location = new System.Drawing.Point(445, 13);
            this.uC_Gonderilen_Mesaj1.Name = "uC_Gonderilen_Mesaj1";
            this.uC_Gonderilen_Mesaj1.Size = new System.Drawing.Size(528, 37);
            this.uC_Gonderilen_Mesaj1.TabIndex = 2;
            this.uC_Gonderilen_Mesaj1.Title = null;
       //     this.uC_Gonderilen_Mesaj1.Load += new System.EventHandler(this.uC_Gonderilen_Mesaj1_Load);
            // 
            // uC_Gelen_Mesaj1
            // 
            this.uC_Gelen_Mesaj1.Icon = null;
            this.uC_Gelen_Mesaj1.Location = new System.Drawing.Point(29, 56);
            this.uC_Gelen_Mesaj1.Name = "uC_Gelen_Mesaj1";
            this.uC_Gelen_Mesaj1.Size = new System.Drawing.Size(592, 35);
            this.uC_Gelen_Mesaj1.TabIndex = 1;
            this.uC_Gelen_Mesaj1.Title = null;
         //   this.uC_Gelen_Mesaj1.Load += new System.EventHandler(this.uC_Gelen_Mesaj1_Load);
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
       //     this.pnlKisiListesi.Click += new System.EventHandler(this.pnlKisiListesi_Click);
            // 
            // timer1
            // 
       //     this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            this.pnlChat.PerformLayout();
            this.pnlMesaj.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGonder)).EndInit();
            this.pnlTittle.ResumeLayout(false);
            this.pnlTittle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).EndInit();
            this.pnlİcerik.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public Bunifu.UI.WinForms.BunifuPanel pnlİcerik;
        public Bunifu.UI.WinForms.BunifuPanel pnlTittle;
        public System.Windows.Forms.Label lblAd;
        public Bunifu.UI.WinForms.BunifuPictureBox pbxProfil;
        public Bunifu.UI.WinForms.BunifuShadowPanel pnlChat;
        public System.Windows.Forms.PictureBox pbxGonder;
        public Bunifu.UI.WinForms.BunifuTextBox txtIcerik;
        public Bunifu.UI.WinForms.BunifuPanel pnlMesaj;
        public Bunifu.UI.WinForms.BunifuPanel pnlKisiListesi;
        public UC_Gonderilen_Mesaj uC_Gonderilen_Mesaj1;
        public UC_Gelen_Mesaj uC_Gelen_Mesaj1;
        public System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}