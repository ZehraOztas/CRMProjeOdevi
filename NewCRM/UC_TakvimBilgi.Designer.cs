namespace NewCRM
{
    partial class UC_TakvimBilgi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TakvimBilgi));
            this.lblid = new System.Windows.Forms.Label();
            this.lblPrjAdi = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblbasla = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pnlBack = new System.Windows.Forms.Panel();
            this.rbtnSec = new System.Windows.Forms.RadioButton();
            this.btnDuzenle = new System.Windows.Forms.PictureBox();
            this.pbxPrjAd = new System.Windows.Forms.PictureBox();
            this.pbxPozisyon = new System.Windows.Forms.PictureBox();
            this.pbxCyer = new System.Windows.Forms.PictureBox();
            this.pbxEp = new System.Windows.Forms.PictureBox();
            this.pbxAd = new System.Windows.Forms.PictureBox();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPozisyon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCyer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(11, 7);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(35, 13);
            this.lblid.TabIndex = 37;
            this.lblid.Text = "label1";
            this.lblid.Visible = false;
            this.lblid.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblPrjAdi
            // 
            this.lblPrjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjAdi.Location = new System.Drawing.Point(172, 21);
            this.lblPrjAdi.Name = "lblPrjAdi";
            this.lblPrjAdi.Size = new System.Drawing.Size(83, 42);
            this.lblPrjAdi.TabIndex = 25;
            this.lblPrjAdi.Text = "Proje Adı";
            this.lblPrjAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPrjAdi.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblNot
            // 
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(534, 21);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(169, 42);
            this.lblNot.TabIndex = 23;
            this.lblNot.Text = "Not";
            this.lblNot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblNot.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblBitis
            // 
            this.lblBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBitis.Location = new System.Drawing.Point(416, 23);
            this.lblBitis.Name = "lblBitis";
            this.lblBitis.Size = new System.Drawing.Size(68, 38);
            this.lblBitis.TabIndex = 22;
            this.lblBitis.Text = "Bitiş Saat";
            this.lblBitis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblBitis.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblbasla
            // 
            this.lblbasla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblbasla.Location = new System.Drawing.Point(307, 21);
            this.lblbasla.Name = "lblbasla";
            this.lblbasla.Size = new System.Drawing.Size(60, 42);
            this.lblbasla.TabIndex = 21;
            this.lblbasla.Text = "Başlangıç Saat";
            this.lblbasla.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblbasla.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(45, 21);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(77, 42);
            this.lblAdSoyad.TabIndex = 19;
            this.lblAdSoyad.Text = "Müşteri Ad";
            this.lblAdSoyad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblAdSoyad.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBack.Controls.Add(this.rbtnSec);
            this.pnlBack.Controls.Add(this.lblid);
            this.pnlBack.Controls.Add(this.btnDuzenle);
            this.pnlBack.Controls.Add(this.pbxPrjAd);
            this.pnlBack.Controls.Add(this.pbxPozisyon);
            this.pnlBack.Controls.Add(this.pbxCyer);
            this.pnlBack.Controls.Add(this.pbxEp);
            this.pnlBack.Controls.Add(this.pbxAd);
            this.pnlBack.Controls.Add(this.lblPrjAdi);
            this.pnlBack.Controls.Add(this.lblNot);
            this.pnlBack.Controls.Add(this.lblBitis);
            this.pnlBack.Controls.Add(this.lblbasla);
            this.pnlBack.Controls.Add(this.lblAdSoyad);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(742, 75);
            this.pnlBack.TabIndex = 1;
            this.pnlBack.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // rbtnSec
            // 
            this.rbtnSec.AutoSize = true;
            this.rbtnSec.Location = new System.Drawing.Point(55, 7);
            this.rbtnSec.Name = "rbtnSec";
            this.rbtnSec.Size = new System.Drawing.Size(14, 13);
            this.rbtnSec.TabIndex = 38;
            this.rbtnSec.TabStop = true;
            this.rbtnSec.Visible = false;
            this.rbtnSec.CheckedChanged += new System.EventHandler(this.rbtnSec_CheckedChanged);
            this.rbtnSec.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(708, 25);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(31, 34);
            this.btnDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDuzenle.TabIndex = 35;
            this.btnDuzenle.TabStop = false;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click_1);
            // 
            // pbxPrjAd
            // 
            this.pbxPrjAd.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrjAd.Image")));
            this.pbxPrjAd.Location = new System.Drawing.Point(128, 23);
            this.pbxPrjAd.Name = "pbxPrjAd";
            this.pbxPrjAd.Size = new System.Drawing.Size(41, 38);
            this.pbxPrjAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPrjAd.TabIndex = 33;
            this.pbxPrjAd.TabStop = false;
            this.pbxPrjAd.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // pbxPozisyon
            // 
            this.pbxPozisyon.Image = ((System.Drawing.Image)(resources.GetObject("pbxPozisyon.Image")));
            this.pbxPozisyon.Location = new System.Drawing.Point(490, 23);
            this.pbxPozisyon.Name = "pbxPozisyon";
            this.pbxPozisyon.Size = new System.Drawing.Size(41, 38);
            this.pbxPozisyon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPozisyon.TabIndex = 31;
            this.pbxPozisyon.TabStop = false;
            this.pbxPozisyon.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // pbxCyer
            // 
            this.pbxCyer.Image = ((System.Drawing.Image)(resources.GetObject("pbxCyer.Image")));
            this.pbxCyer.Location = new System.Drawing.Point(373, 23);
            this.pbxCyer.Name = "pbxCyer";
            this.pbxCyer.Size = new System.Drawing.Size(41, 38);
            this.pbxCyer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCyer.TabIndex = 30;
            this.pbxCyer.TabStop = false;
            this.pbxCyer.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // pbxEp
            // 
            this.pbxEp.Image = ((System.Drawing.Image)(resources.GetObject("pbxEp.Image")));
            this.pbxEp.Location = new System.Drawing.Point(261, 23);
            this.pbxEp.Name = "pbxEp";
            this.pbxEp.Size = new System.Drawing.Size(41, 38);
            this.pbxEp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxEp.TabIndex = 29;
            this.pbxEp.TabStop = false;
            this.pbxEp.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // pbxAd
            // 
            this.pbxAd.Image = ((System.Drawing.Image)(resources.GetObject("pbxAd.Image")));
            this.pbxAd.Location = new System.Drawing.Point(5, 23);
            this.pbxAd.Name = "pbxAd";
            this.pbxAd.Size = new System.Drawing.Size(41, 38);
            this.pbxAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxAd.TabIndex = 26;
            this.pbxAd.TabStop = false;
            this.pbxAd.Click += new System.EventHandler(this.pnlBack_Click);
            // 
            // UC_TakvimBilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "UC_TakvimBilgi";
            this.Size = new System.Drawing.Size(742, 75);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPozisyon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCyer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxEp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblid;
        public System.Windows.Forms.PictureBox btnDuzenle;
        public System.Windows.Forms.PictureBox pbxPrjAd;
        public System.Windows.Forms.PictureBox pbxPozisyon;
        public System.Windows.Forms.PictureBox pbxCyer;
        public System.Windows.Forms.PictureBox pbxEp;
        public System.Windows.Forms.PictureBox pbxAd;
        public System.Windows.Forms.Label lblPrjAdi;
        public System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.Label lblBitis;
        public System.Windows.Forms.Label lblbasla;
        public System.Windows.Forms.Label lblAdSoyad;
        public System.Windows.Forms.Panel pnlBack;
        private System.Windows.Forms.RadioButton rbtnSec;
    }
}
