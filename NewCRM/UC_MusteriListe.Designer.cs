namespace NewCRM
{
    partial class UC_MusteriListe
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MusteriListe));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.rbtnSec = new System.Windows.Forms.RadioButton();
            this.lblid = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblEp = new System.Windows.Forms.Label();
            this.lblPrjAdi = new System.Windows.Forms.Label();
            this.lbliletisim = new System.Windows.Forms.Label();
            this.lblPrjjDurum = new System.Windows.Forms.Label();
            this.lblYoneten = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcYer = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.kart = new Bunifu.Framework.UI.BunifuCards();
            this.btnMusteriBilgileriDegisikleri = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnlBack.SuspendLayout();
            this.kart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtnSec
            // 
            this.rbtnSec.AutoSize = true;
            this.rbtnSec.Location = new System.Drawing.Point(3, 7);
            this.rbtnSec.Name = "rbtnSec";
            this.rbtnSec.Size = new System.Drawing.Size(14, 13);
            this.rbtnSec.TabIndex = 139;
            this.rbtnSec.TabStop = true;
            this.rbtnSec.UseVisualStyleBackColor = true;
            this.rbtnSec.Visible = false;
            this.rbtnSec.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblid.ForeColor = System.Drawing.Color.Black;
            this.lblid.Location = new System.Drawing.Point(121, 14);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(33, 13);
            this.lblid.TabIndex = 138;
            this.lblid.Text = "m_id";
            this.lblid.Visible = false;
            this.lblid.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblTel
            // 
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.ForeColor = System.Drawing.Color.Black;
            this.lblTel.Location = new System.Drawing.Point(172, 300);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(81, 28);
            this.lblTel.TabIndex = 23;
            this.lblTel.Text = "telefon";
            this.lblTel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblTel.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblEp
            // 
            this.lblEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEp.ForeColor = System.Drawing.Color.Black;
            this.lblEp.Location = new System.Drawing.Point(37, 300);
            this.lblEp.Name = "lblEp";
            this.lblEp.Size = new System.Drawing.Size(85, 28);
            this.lblEp.TabIndex = 22;
            this.lblEp.Text = "eposta";
            this.lblEp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblEp.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblPrjAdi
            // 
            this.lblPrjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjAdi.ForeColor = System.Drawing.Color.Black;
            this.lblPrjAdi.Location = new System.Drawing.Point(131, 215);
            this.lblPrjAdi.Name = "lblPrjAdi";
            this.lblPrjAdi.Size = new System.Drawing.Size(119, 32);
            this.lblPrjAdi.TabIndex = 21;
            this.lblPrjAdi.Text = "Proje Adı";
            this.lblPrjAdi.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lbliletisim
            // 
            this.lbliletisim.AutoSize = true;
            this.lbliletisim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbliletisim.ForeColor = System.Drawing.Color.Black;
            this.lbliletisim.Location = new System.Drawing.Point(131, 144);
            this.lbliletisim.Name = "lbliletisim";
            this.lbliletisim.Size = new System.Drawing.Size(108, 15);
            this.lbliletisim.TabIndex = 20;
            this.lbliletisim.Text = "İşe başlama Tarihi";
            this.lbliletisim.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblPrjjDurum
            // 
            this.lblPrjjDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjjDurum.ForeColor = System.Drawing.Color.Black;
            this.lblPrjjDurum.Location = new System.Drawing.Point(131, 247);
            this.lblPrjjDurum.Name = "lblPrjjDurum";
            this.lblPrjjDurum.Size = new System.Drawing.Size(119, 38);
            this.lblPrjjDurum.TabIndex = 18;
            this.lblPrjjDurum.Text = "Proje Durumu";
            this.lblPrjjDurum.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblYoneten
            // 
            this.lblYoneten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneten.ForeColor = System.Drawing.Color.Black;
            this.lblYoneten.Location = new System.Drawing.Point(131, 183);
            this.lblYoneten.Name = "lblYoneten";
            this.lblYoneten.Size = new System.Drawing.Size(119, 32);
            this.lblYoneten.TabIndex = 11;
            this.lblYoneten.Text = "Yöneten";
            this.lblYoneten.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(11, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Proje Durumu:";
            this.label6.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(11, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Proje Adı:";
            this.label5.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(11, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Projeyi Yöneten";
            this.label4.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(11, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "İletişim Tarihi:";
            this.label3.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblcYer
            // 
            this.lblcYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcYer.ForeColor = System.Drawing.Color.Gray;
            this.lblcYer.Location = new System.Drawing.Point(135, 74);
            this.lblcYer.Name = "lblcYer";
            this.lblcYer.Size = new System.Drawing.Size(115, 34);
            this.lblcYer.TabIndex = 3;
            this.lblcYer.Text = "Çalıştığı Yer";
            this.lblcYer.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // lblAd
            // 
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(134, 34);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(116, 40);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "AD";
            this.lblAd.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.kart);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(305, 399);
            this.pnlBack.TabIndex = 1;
            // 
            // kart
            // 
            this.kart.BackColor = System.Drawing.Color.White;
            this.kart.BorderRadius = 5;
            this.kart.BottomSahddow = true;
            this.kart.color = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.kart.Controls.Add(this.rbtnSec);
            this.kart.Controls.Add(this.lblid);
            this.kart.Controls.Add(this.btnMusteriBilgileriDegisikleri);
            this.kart.Controls.Add(this.pictureBox2);
            this.kart.Controls.Add(this.pictureBox1);
            this.kart.Controls.Add(this.lblTel);
            this.kart.Controls.Add(this.lblEp);
            this.kart.Controls.Add(this.lblPrjAdi);
            this.kart.Controls.Add(this.lbliletisim);
            this.kart.Controls.Add(this.lblPrjjDurum);
            this.kart.Controls.Add(this.lblYoneten);
            this.kart.Controls.Add(this.label6);
            this.kart.Controls.Add(this.label5);
            this.kart.Controls.Add(this.label4);
            this.kart.Controls.Add(this.bunifuSeparator1);
            this.kart.Controls.Add(this.label3);
            this.kart.Controls.Add(this.lblcYer);
            this.kart.Controls.Add(this.lblAd);
            this.kart.Controls.Add(this.bunifuPictureBox1);
            this.kart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kart.ForeColor = System.Drawing.Color.Black;
            this.kart.LeftSahddow = false;
            this.kart.Location = new System.Drawing.Point(20, 3);
            this.kart.Name = "kart";
            this.kart.RightSahddow = true;
            this.kart.ShadowDepth = 20;
            this.kart.Size = new System.Drawing.Size(265, 392);
            this.kart.TabIndex = 1;
            this.kart.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // btnMusteriBilgileriDegisikleri
            // 
            this.btnMusteriBilgileriDegisikleri.AllowAnimations = true;
            this.btnMusteriBilgileriDegisikleri.AllowMouseEffects = true;
            this.btnMusteriBilgileriDegisikleri.AllowToggling = false;
            this.btnMusteriBilgileriDegisikleri.AnimationSpeed = 200;
            this.btnMusteriBilgileriDegisikleri.AutoGenerateColors = false;
            this.btnMusteriBilgileriDegisikleri.AutoRoundBorders = false;
            this.btnMusteriBilgileriDegisikleri.AutoSizeLeftIcon = true;
            this.btnMusteriBilgileriDegisikleri.AutoSizeRightIcon = true;
            this.btnMusteriBilgileriDegisikleri.BackColor = System.Drawing.Color.Transparent;
            this.btnMusteriBilgileriDegisikleri.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriBilgileriDegisikleri.BackgroundImage")));
            this.btnMusteriBilgileriDegisikleri.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMusteriBilgileriDegisikleri.ButtonText = "Detaylı Gör";
            this.btnMusteriBilgileriDegisikleri.ButtonTextMarginLeft = 0;
            this.btnMusteriBilgileriDegisikleri.ColorContrastOnClick = 45;
            this.btnMusteriBilgileriDegisikleri.ColorContrastOnHover = 45;
            this.btnMusteriBilgileriDegisikleri.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnMusteriBilgileriDegisikleri.CustomizableEdges = borderEdges2;
            this.btnMusteriBilgileriDegisikleri.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMusteriBilgileriDegisikleri.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.DisabledForecolor = System.Drawing.Color.White;
            this.btnMusteriBilgileriDegisikleri.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnMusteriBilgileriDegisikleri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriBilgileriDegisikleri.ForeColor = System.Drawing.Color.White;
            this.btnMusteriBilgileriDegisikleri.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMusteriBilgileriDegisikleri.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnMusteriBilgileriDegisikleri.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnMusteriBilgileriDegisikleri.IconMarginLeft = 11;
            this.btnMusteriBilgileriDegisikleri.IconPadding = 10;
            this.btnMusteriBilgileriDegisikleri.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMusteriBilgileriDegisikleri.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnMusteriBilgileriDegisikleri.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnMusteriBilgileriDegisikleri.IconSize = 25;
            this.btnMusteriBilgileriDegisikleri.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.IdleBorderRadius = 20;
            this.btnMusteriBilgileriDegisikleri.IdleBorderThickness = 1;
            this.btnMusteriBilgileriDegisikleri.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.IdleIconLeftImage = null;
            this.btnMusteriBilgileriDegisikleri.IdleIconRightImage = null;
            this.btnMusteriBilgileriDegisikleri.IndicateFocus = false;
            this.btnMusteriBilgileriDegisikleri.Location = new System.Drawing.Point(12, 347);
            this.btnMusteriBilgileriDegisikleri.Name = "btnMusteriBilgileriDegisikleri";
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.BorderRadius = 20;
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.BorderThickness = 1;
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.IconLeftImage = null;
            this.btnMusteriBilgileriDegisikleri.OnDisabledState.IconRightImage = null;
            this.btnMusteriBilgileriDegisikleri.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.onHoverState.BorderRadius = 20;
            this.btnMusteriBilgileriDegisikleri.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMusteriBilgileriDegisikleri.onHoverState.BorderThickness = 1;
            this.btnMusteriBilgileriDegisikleri.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnMusteriBilgileriDegisikleri.onHoverState.IconLeftImage = null;
            this.btnMusteriBilgileriDegisikleri.onHoverState.IconRightImage = null;
            this.btnMusteriBilgileriDegisikleri.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.OnIdleState.BorderRadius = 20;
            this.btnMusteriBilgileriDegisikleri.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMusteriBilgileriDegisikleri.OnIdleState.BorderThickness = 1;
            this.btnMusteriBilgileriDegisikleri.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnMusteriBilgileriDegisikleri.OnIdleState.IconLeftImage = null;
            this.btnMusteriBilgileriDegisikleri.OnIdleState.IconRightImage = null;
            this.btnMusteriBilgileriDegisikleri.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.OnPressedState.BorderRadius = 20;
            this.btnMusteriBilgileriDegisikleri.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnMusteriBilgileriDegisikleri.OnPressedState.BorderThickness = 1;
            this.btnMusteriBilgileriDegisikleri.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.btnMusteriBilgileriDegisikleri.OnPressedState.ForeColor = System.Drawing.SystemColors.Window;
            this.btnMusteriBilgileriDegisikleri.OnPressedState.IconLeftImage = null;
            this.btnMusteriBilgileriDegisikleri.OnPressedState.IconRightImage = null;
            this.btnMusteriBilgileriDegisikleri.Size = new System.Drawing.Size(241, 33);
            this.btnMusteriBilgileriDegisikleri.TabIndex = 137;
            this.btnMusteriBilgileriDegisikleri.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMusteriBilgileriDegisikleri.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnMusteriBilgileriDegisikleri.TextMarginLeft = 0;
            this.btnMusteriBilgileriDegisikleri.TextPadding = new System.Windows.Forms.Padding(0);
            this.btnMusteriBilgileriDegisikleri.UseDefaultRadiusAndThickness = true;
            this.btnMusteriBilgileriDegisikleri.Click += new System.EventHandler(this.btnMusteriBilgileriDegisikleri_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(137, 300);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(35, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(9, 167);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(244, 9);
            this.bunifuSeparator1.TabIndex = 5;
            this.bunifuSeparator1.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 47;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(19, 14);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(95, 95);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 1;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // UC_MusteriListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "UC_MusteriListe";
            this.Size = new System.Drawing.Size(305, 399);
            this.Load += new System.EventHandler(this.UC_MusteriListe_Load);
            this.pnlBack.ResumeLayout(false);
            this.kart.ResumeLayout(false);
            this.kart.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RadioButton rbtnSec;
        public System.Windows.Forms.Label lblid;
        public Bunifu.UI.WinForms.BunifuButton.BunifuButton btnMusteriBilgileriDegisikleri;
        public System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.Label lblEp;
        public System.Windows.Forms.Label lblPrjAdi;
        public System.Windows.Forms.Label lbliletisim;
        public System.Windows.Forms.Label lblPrjjDurum;
        public System.Windows.Forms.Label lblYoneten;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label4;
        public Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label lblcYer;
        public System.Windows.Forms.Label lblAd;
        public Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Panel pnlBack;
        public Bunifu.Framework.UI.BunifuCards kart;
    }
}
