namespace NewCRM
{
    partial class UC_MusteriBilgileri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MusteriBilgileri));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.lblid = new System.Windows.Forms.Label();
            this.rbtnSec = new System.Windows.Forms.RadioButton();
            this.btnDuzenle = new System.Windows.Forms.PictureBox();
            this.pbxdurum = new System.Windows.Forms.PictureBox();
            this.pbxPrjAd = new System.Windows.Forms.PictureBox();
            this.pbxTarih = new System.Windows.Forms.PictureBox();
            this.pbxPozisyon = new System.Windows.Forms.PictureBox();
            this.pbxCyer = new System.Windows.Forms.PictureBox();
            this.pbxEp = new System.Windows.Forms.PictureBox();
            this.pbxTel = new System.Windows.Forms.PictureBox();
            this.dtpSontarih = new System.Windows.Forms.DateTimePicker();
            this.pbxAd = new System.Windows.Forms.PictureBox();
            this.lblPrjAdi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblPozisyon = new System.Windows.Forms.Label();
            this.lblCalistigiYer = new System.Windows.Forms.Label();
            this.lblEp = new System.Windows.Forms.Label();
            this.lblTel = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdurum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPozisyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBack.Controls.Add(this.lblid);
            this.pnlBack.Controls.Add(this.rbtnSec);
            this.pnlBack.Controls.Add(this.btnDuzenle);
            this.pnlBack.Controls.Add(this.pbxdurum);
            this.pnlBack.Controls.Add(this.pbxPrjAd);
            this.pnlBack.Controls.Add(this.pbxTarih);
            this.pnlBack.Controls.Add(this.pbxPozisyon);
            this.pnlBack.Controls.Add(this.pbxCyer);
            this.pnlBack.Controls.Add(this.pbxEp);
            this.pnlBack.Controls.Add(this.pbxTel);
            this.pnlBack.Controls.Add(this.dtpSontarih);
            this.pnlBack.Controls.Add(this.pbxAd);
            this.pnlBack.Controls.Add(this.lblPrjAdi);
            this.pnlBack.Controls.Add(this.lblDurum);
            this.pnlBack.Controls.Add(this.lblPozisyon);
            this.pnlBack.Controls.Add(this.lblCalistigiYer);
            this.pnlBack.Controls.Add(this.lblEp);
            this.pnlBack.Controls.Add(this.lblTel);
            this.pnlBack.Controls.Add(this.lblAdSoyad);
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1227, 80);
            this.pnlBack.TabIndex = 0;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(3, 62);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 37;
            this.lblid.Text = "label1";
            this.lblid.Visible = false;
            // 
            // rbtnSec
            // 
            this.rbtnSec.AutoSize = true;
            this.rbtnSec.Location = new System.Drawing.Point(1162, 21);
            this.rbtnSec.Name = "rbtnSec";
            this.rbtnSec.Size = new System.Drawing.Size(14, 13);
            this.rbtnSec.TabIndex = 36;
            this.rbtnSec.TabStop = true;
            this.rbtnSec.UseVisualStyleBackColor = true;
            this.rbtnSec.Visible = false;
            this.rbtnSec.Click += new System.EventHandler(this.rbtnSec_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(1182, 21);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(41, 38);
            this.btnDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDuzenle.TabIndex = 35;
            this.btnDuzenle.TabStop = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // pbxdurum
            // 
            this.pbxdurum.Image = ((System.Drawing.Image)(resources.GetObject("pbxdurum.Image")));
            this.pbxdurum.Location = new System.Drawing.Point(1028, 21);
            this.pbxdurum.Name = "pbxdurum";
            this.pbxdurum.Size = new System.Drawing.Size(41, 38);
            this.pbxdurum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxdurum.TabIndex = 34;
            this.pbxdurum.TabStop = false;
            this.pbxdurum.Click += new System.EventHandler(this.pbxdurum_Click);
            // 
            // pbxPrjAd
            // 
            this.pbxPrjAd.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrjAd.Image")));
            this.pbxPrjAd.Location = new System.Drawing.Point(894, 21);
            this.pbxPrjAd.Name = "pbxPrjAd";
            this.pbxPrjAd.Size = new System.Drawing.Size(41, 38);
            this.pbxPrjAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPrjAd.TabIndex = 33;
            this.pbxPrjAd.TabStop = false;
            this.pbxPrjAd.Click += new System.EventHandler(this.pbxPrjAd_Click);
            // 
            // pbxTarih
            // 
            this.pbxTarih.Image = ((System.Drawing.Image)(resources.GetObject("pbxTarih.Image")));
            this.pbxTarih.Location = new System.Drawing.Point(715, 21);
            this.pbxTarih.Name = "pbxTarih";
            this.pbxTarih.Size = new System.Drawing.Size(41, 38);
            this.pbxTarih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxTarih.TabIndex = 32;
            this.pbxTarih.TabStop = false;
            this.pbxTarih.Click += new System.EventHandler(this.pbxTarih_Click);
            // 
            // pbxPozisyon
            // 
            this.pbxPozisyon.Image = ((System.Drawing.Image)(resources.GetObject("pbxPozisyon.Image")));
            this.pbxPozisyon.Location = new System.Drawing.Point(572, 21);
            this.pbxPozisyon.Name = "pbxPozisyon";
            this.pbxPozisyon.Size = new System.Drawing.Size(41, 38);
            this.pbxPozisyon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPozisyon.TabIndex = 31;
            this.pbxPozisyon.TabStop = false;
            this.pbxPozisyon.Click += new System.EventHandler(this.pbxPozisyon_Click);
            // 
            // pbxCyer
            // 
            this.pbxCyer.Image = ((System.Drawing.Image)(resources.GetObject("pbxCyer.Image")));
            this.pbxCyer.Location = new System.Drawing.Point(419, 21);
            this.pbxCyer.Name = "pbxCyer";
            this.pbxCyer.Size = new System.Drawing.Size(41, 38);
            this.pbxCyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCyer.TabIndex = 30;
            this.pbxCyer.TabStop = false;
            this.pbxCyer.Click += new System.EventHandler(this.pbxCyer_Click);
            // 
            // pbxEp
            // 
            this.pbxEp.Image = ((System.Drawing.Image)(resources.GetObject("pbxEp.Image")));
            this.pbxEp.Location = new System.Drawing.Point(279, 21);
            this.pbxEp.Name = "pbxEp";
            this.pbxEp.Size = new System.Drawing.Size(41, 38);
            this.pbxEp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxEp.TabIndex = 29;
            this.pbxEp.TabStop = false;
            this.pbxEp.Click += new System.EventHandler(this.pbxEp_Click);
            // 
            // pbxTel
            // 
            this.pbxTel.Image = ((System.Drawing.Image)(resources.GetObject("pbxTel.Image")));
            this.pbxTel.Location = new System.Drawing.Point(137, 21);
            this.pbxTel.Name = "pbxTel";
            this.pbxTel.Size = new System.Drawing.Size(41, 38);
            this.pbxTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxTel.TabIndex = 28;
            this.pbxTel.TabStop = false;
            this.pbxTel.Click += new System.EventHandler(this.pbxTel_Click);
            // 
            // dtpSontarih
            // 
            this.dtpSontarih.Enabled = false;
            this.dtpSontarih.Location = new System.Drawing.Point(759, 30);
            this.dtpSontarih.Name = "dtpSontarih";
            this.dtpSontarih.Size = new System.Drawing.Size(102, 20);
            this.dtpSontarih.TabIndex = 27;
            this.dtpSontarih.ValueChanged += new System.EventHandler(this.dtpSontarih_ValueChanged);
            // 
            // pbxAd
            // 
            this.pbxAd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAd.Image")));
            this.pbxAd.Location = new System.Drawing.Point(3, 21);
            this.pbxAd.Name = "pbxAd";
            this.pbxAd.Size = new System.Drawing.Size(41, 38);
            this.pbxAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxAd.TabIndex = 26;
            this.pbxAd.TabStop = false;
            this.pbxAd.Click += new System.EventHandler(this.pbxAd_Click);
            // 
            // lblPrjAdi
            // 
            this.lblPrjAdi.AutoSize = true;
            this.lblPrjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjAdi.Location = new System.Drawing.Point(938, 33);
            this.lblPrjAdi.Name = "lblPrjAdi";
            this.lblPrjAdi.Size = new System.Drawing.Size(56, 15);
            this.lblPrjAdi.TabIndex = 25;
            this.lblPrjAdi.Text = "Proje Adı";
            this.lblPrjAdi.Click += new System.EventHandler(this.lblPrjAdi_Click_1);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(1072, 33);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(45, 15);
            this.lblDurum.TabIndex = 24;
            this.lblDurum.Text = "Durum";
            this.lblDurum.Click += new System.EventHandler(this.lblDurum_Click_1);
            // 
            // lblPozisyon
            // 
            this.lblPozisyon.AutoSize = true;
            this.lblPozisyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPozisyon.Location = new System.Drawing.Point(616, 33);
            this.lblPozisyon.Name = "lblPozisyon";
            this.lblPozisyon.Size = new System.Drawing.Size(56, 15);
            this.lblPozisyon.TabIndex = 23;
            this.lblPozisyon.Text = "Pozisyon";
            this.lblPozisyon.Click += new System.EventHandler(this.lblPozisyon_Click_1);
            // 
            // lblCalistigiYer
            // 
            this.lblCalistigiYer.AutoSize = true;
            this.lblCalistigiYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCalistigiYer.Location = new System.Drawing.Point(463, 33);
            this.lblCalistigiYer.Name = "lblCalistigiYer";
            this.lblCalistigiYer.Size = new System.Drawing.Size(67, 15);
            this.lblCalistigiYer.TabIndex = 22;
            this.lblCalistigiYer.Text = "çalıştığı yer";
            this.lblCalistigiYer.Click += new System.EventHandler(this.lblCalistigiYer_Click_1);
            // 
            // lblEp
            // 
            this.lblEp.AutoSize = true;
            this.lblEp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEp.Location = new System.Drawing.Point(323, 33);
            this.lblEp.Name = "lblEp";
            this.lblEp.Size = new System.Drawing.Size(21, 15);
            this.lblEp.TabIndex = 21;
            this.lblEp.Text = "ep";
            this.lblEp.Click += new System.EventHandler(this.lblEp_Click_1);
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTel.Location = new System.Drawing.Point(181, 33);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(20, 15);
            this.lblTel.TabIndex = 20;
            this.lblTel.Text = "tel";
            this.lblTel.Click += new System.EventHandler(this.lblTel_Click_1);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(47, 33);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(21, 15);
            this.lblAdSoyad.TabIndex = 19;
            this.lblAdSoyad.Text = "ad";
            this.lblAdSoyad.Click += new System.EventHandler(this.lblAdSoyad_Click_1);
            // 
            // UC_MusteriBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pnlBack);
            this.Name = "UC_MusteriBilgileri";
            this.Size = new System.Drawing.Size(1227, 80);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxdurum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPozisyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.RadioButton rbtnSec;
        public System.Windows.Forms.PictureBox btnDuzenle;
        public System.Windows.Forms.PictureBox pbxdurum;
        public System.Windows.Forms.PictureBox pbxPrjAd;
        public System.Windows.Forms.PictureBox pbxTarih;
        public System.Windows.Forms.PictureBox pbxPozisyon;
        public System.Windows.Forms.PictureBox pbxCyer;
        public System.Windows.Forms.PictureBox pbxEp;
        public System.Windows.Forms.PictureBox pbxTel;
        public System.Windows.Forms.DateTimePicker dtpSontarih;
        public System.Windows.Forms.PictureBox pbxAd;
        public System.Windows.Forms.Label lblPrjAdi;
        public System.Windows.Forms.Label lblDurum;
        public System.Windows.Forms.Label lblPozisyon;
        public System.Windows.Forms.Label lblCalistigiYer;
        public System.Windows.Forms.Label lblEp;
        public System.Windows.Forms.Label lblTel;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Panel pnlBack;
        public System.Windows.Forms.Label lblid;
    }
}
