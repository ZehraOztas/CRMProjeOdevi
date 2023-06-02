namespace NewCRM
{
    partial class UC_MusteriNotlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_MusteriNotlar));
            this.pnlBack = new System.Windows.Forms.Panel();
            this.rbtnSec = new System.Windows.Forms.RadioButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNot = new System.Windows.Forms.Label();
            this.lblnid = new System.Windows.Forms.Label();
            this.pbxSil = new System.Windows.Forms.PictureBox();
            this.pbxPrjAd = new System.Windows.Forms.PictureBox();
            this.pbxTarih = new System.Windows.Forms.PictureBox();
            this.pbxIcerik = new System.Windows.Forms.PictureBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblPrjAdi = new System.Windows.Forms.Label();
            this.lblYoneten = new System.Windows.Forms.Label();
            this.pbxDuzenle = new System.Windows.Forms.PictureBox();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcerik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDuzenle)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.Controls.Add(this.rbtnSec);
            this.pnlBack.Controls.Add(this.pictureBox1);
            this.pnlBack.Controls.Add(this.lblNot);
            this.pnlBack.Controls.Add(this.lblnid);
            this.pnlBack.Controls.Add(this.pbxSil);
            this.pnlBack.Controls.Add(this.pbxPrjAd);
            this.pnlBack.Controls.Add(this.pbxTarih);
            this.pnlBack.Controls.Add(this.pbxIcerik);
            this.pnlBack.Controls.Add(this.dtpTarih);
            this.pnlBack.Controls.Add(this.lblPrjAdi);
            this.pnlBack.Controls.Add(this.lblYoneten);
            this.pnlBack.Controls.Add(this.pbxDuzenle);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.Size = new System.Drawing.Size(1089, 73);
            this.pnlBack.TabIndex = 0;
            // 
            // rbtnSec
            // 
            this.rbtnSec.AutoSize = true;
            this.rbtnSec.Location = new System.Drawing.Point(1006, 50);
            this.rbtnSec.Name = "rbtnSec";
            this.rbtnSec.Size = new System.Drawing.Size(14, 13);
            this.rbtnSec.TabIndex = 74;
            this.rbtnSec.TabStop = true;
            this.rbtnSec.UseVisualStyleBackColor = true;
            this.rbtnSec.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(373, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 73;
            this.pictureBox1.TabStop = false;
            // 
            // lblNot
            // 
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(417, 10);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(386, 37);
            this.lblNot.TabIndex = 72;
            this.lblNot.Text = "İçerik";
            this.lblNot.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblnid
            // 
            this.lblnid.AutoSize = true;
            this.lblnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnid.Location = new System.Drawing.Point(48, 45);
            this.lblnid.Name = "lblnid";
            this.lblnid.Size = new System.Drawing.Size(31, 15);
            this.lblnid.TabIndex = 71;
            this.lblnid.Text = "n_id";
            // 
            // pbxSil
            // 
            this.pbxSil.Image = ((System.Drawing.Image)(resources.GetObject("pbxSil.Image")));
            this.pbxSil.Location = new System.Drawing.Point(1044, 10);
            this.pbxSil.Name = "pbxSil";
            this.pbxSil.Size = new System.Drawing.Size(41, 38);
            this.pbxSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSil.TabIndex = 69;
            this.pbxSil.TabStop = false;
            this.pbxSil.Click += new System.EventHandler(this.pbxSil_Click);
            // 
            // pbxPrjAd
            // 
            this.pbxPrjAd.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrjAd.Image")));
            this.pbxPrjAd.Location = new System.Drawing.Point(4, 9);
            this.pbxPrjAd.Name = "pbxPrjAd";
            this.pbxPrjAd.Size = new System.Drawing.Size(41, 38);
            this.pbxPrjAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPrjAd.TabIndex = 68;
            this.pbxPrjAd.TabStop = false;
            // 
            // pbxTarih
            // 
            this.pbxTarih.Image = ((System.Drawing.Image)(resources.GetObject("pbxTarih.Image")));
            this.pbxTarih.Location = new System.Drawing.Point(809, 9);
            this.pbxTarih.Name = "pbxTarih";
            this.pbxTarih.Size = new System.Drawing.Size(41, 38);
            this.pbxTarih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxTarih.TabIndex = 67;
            this.pbxTarih.TabStop = false;
            // 
            // pbxIcerik
            // 
            this.pbxIcerik.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcerik.Image")));
            this.pbxIcerik.Location = new System.Drawing.Point(196, 9);
            this.pbxIcerik.Name = "pbxIcerik";
            this.pbxIcerik.Size = new System.Drawing.Size(41, 38);
            this.pbxIcerik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcerik.TabIndex = 66;
            this.pbxIcerik.TabStop = false;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Enabled = false;
            this.dtpTarih.Location = new System.Drawing.Point(853, 18);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(102, 20);
            this.dtpTarih.TabIndex = 65;
            // 
            // lblPrjAdi
            // 
            this.lblPrjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjAdi.Location = new System.Drawing.Point(48, 9);
            this.lblPrjAdi.Name = "lblPrjAdi";
            this.lblPrjAdi.Size = new System.Drawing.Size(142, 39);
            this.lblPrjAdi.TabIndex = 64;
            this.lblPrjAdi.Text = "Proje Adı";
            this.lblPrjAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblYoneten
            // 
            this.lblYoneten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblYoneten.Location = new System.Drawing.Point(240, 10);
            this.lblYoneten.Name = "lblYoneten";
            this.lblYoneten.Size = new System.Drawing.Size(127, 38);
            this.lblYoneten.TabIndex = 63;
            this.lblYoneten.Text = "Personel Adı";
            this.lblYoneten.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pbxDuzenle
            // 
            this.pbxDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("pbxDuzenle.Image")));
            this.pbxDuzenle.Location = new System.Drawing.Point(997, 10);
            this.pbxDuzenle.Name = "pbxDuzenle";
            this.pbxDuzenle.Size = new System.Drawing.Size(41, 38);
            this.pbxDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxDuzenle.TabIndex = 70;
            this.pbxDuzenle.TabStop = false;
            this.pbxDuzenle.Click += new System.EventHandler(this.pbxDuzenle_Click_1);
            // 
            // UC_MusteriNotlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "UC_MusteriNotlar";
            this.Size = new System.Drawing.Size(1089, 73);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcerik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDuzenle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBack;
        public System.Windows.Forms.RadioButton rbtnSec;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.Label lblnid;
        public System.Windows.Forms.PictureBox pbxSil;
        public System.Windows.Forms.PictureBox pbxPrjAd;
        public System.Windows.Forms.PictureBox pbxTarih;
        public System.Windows.Forms.PictureBox pbxIcerik;
        public System.Windows.Forms.DateTimePicker dtpTarih;
        public System.Windows.Forms.Label lblPrjAdi;
        public System.Windows.Forms.Label lblYoneten;
        public System.Windows.Forms.PictureBox pbxDuzenle;
    }
}
