namespace NewCRM
{
    partial class UC_Notlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Notlar));
            this.pnlBack = new Bunifu.UI.WinForms.BunifuPanel();
            this.btnDuzenle = new System.Windows.Forms.PictureBox();
            this.pbxTarih = new System.Windows.Forms.PictureBox();
            this.pbxTel = new System.Windows.Forms.PictureBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblNot = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrjAdi = new System.Windows.Forms.Label();
            this.pbxPrjAd = new System.Windows.Forms.PictureBox();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackgroundColor = System.Drawing.Color.Transparent;
            this.pnlBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBack.BackgroundImage")));
            this.pnlBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBack.BorderColor = System.Drawing.Color.Transparent;
            this.pnlBack.BorderRadius = 15;
            this.pnlBack.BorderThickness = 1;
            this.pnlBack.Controls.Add(this.btnDuzenle);
            this.pnlBack.Controls.Add(this.pbxPrjAd);
            this.pnlBack.Controls.Add(this.pbxTarih);
            this.pnlBack.Controls.Add(this.pbxTel);
            this.pnlBack.Controls.Add(this.dtpTarih);
            this.pnlBack.Controls.Add(this.lblPrjAdi);
            this.pnlBack.Controls.Add(this.lblNot);
            this.pnlBack.Controls.Add(this.pictureBox1);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.ShowBorders = true;
            this.pnlBack.Size = new System.Drawing.Size(1084, 71);
            this.pnlBack.TabIndex = 0;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(1043, 17);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(41, 38);
            this.btnDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnDuzenle.TabIndex = 45;
            this.btnDuzenle.TabStop = false;
            // 
            // pbxTarih
            // 
            this.pbxTarih.Image = ((System.Drawing.Image)(resources.GetObject("pbxTarih.Image")));
            this.pbxTarih.Location = new System.Drawing.Point(808, 16);
            this.pbxTarih.Name = "pbxTarih";
            this.pbxTarih.Size = new System.Drawing.Size(41, 38);
            this.pbxTarih.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxTarih.TabIndex = 43;
            this.pbxTarih.TabStop = false;
            // 
            // pbxTel
            // 
            this.pbxTel.Image = ((System.Drawing.Image)(resources.GetObject("pbxTel.Image")));
            this.pbxTel.Location = new System.Drawing.Point(195, 16);
            this.pbxTel.Name = "pbxTel";
            this.pbxTel.Size = new System.Drawing.Size(41, 38);
            this.pbxTel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxTel.TabIndex = 42;
            this.pbxTel.TabStop = false;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Enabled = false;
            this.dtpTarih.Location = new System.Drawing.Point(852, 25);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(102, 20);
            this.dtpTarih.TabIndex = 41;
            // 
            // lblNot
            // 
            this.lblNot.AutoSize = true;
            this.lblNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNot.Location = new System.Drawing.Point(239, 28);
            this.lblNot.Name = "lblNot";
            this.lblNot.Size = new System.Drawing.Size(36, 15);
            this.lblNot.TabIndex = 38;
            this.lblNot.Text = "İçerik";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(996, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrjAdi
            // 
            this.lblPrjAdi.AutoSize = true;
            this.lblPrjAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPrjAdi.Location = new System.Drawing.Point(47, 28);
            this.lblPrjAdi.Name = "lblPrjAdi";
            this.lblPrjAdi.Size = new System.Drawing.Size(56, 15);
            this.lblPrjAdi.TabIndex = 39;
            this.lblPrjAdi.Text = "Proje Adı";
            // 
            // pbxPrjAd
            // 
            this.pbxPrjAd.Image = ((System.Drawing.Image)(resources.GetObject("pbxPrjAd.Image")));
            this.pbxPrjAd.Location = new System.Drawing.Point(3, 16);
            this.pbxPrjAd.Name = "pbxPrjAd";
            this.pbxPrjAd.Size = new System.Drawing.Size(41, 38);
            this.pbxPrjAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxPrjAd.TabIndex = 44;
            this.pbxPrjAd.TabStop = false;
            // 
            // UC_Notlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlBack);
            this.Name = "UC_Notlar";
            this.Size = new System.Drawing.Size(1084, 71);
            this.pnlBack.ResumeLayout(false);
            this.pnlBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnDuzenle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlBack;
        public System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.PictureBox btnDuzenle;
        public System.Windows.Forms.PictureBox pbxTarih;
        public System.Windows.Forms.PictureBox pbxTel;
        public System.Windows.Forms.DateTimePicker dtpTarih;
        public System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.PictureBox pbxPrjAd;
        public System.Windows.Forms.Label lblPrjAdi;
    }
}
