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
            this.pbxSil = new System.Windows.Forms.PictureBox();
            this.pbxPrjAd = new System.Windows.Forms.PictureBox();
            this.pbxTarih = new System.Windows.Forms.PictureBox();
            this.pbxIcerik = new System.Windows.Forms.PictureBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.lblPrjAdi = new System.Windows.Forms.Label();
            this.lblNot = new System.Windows.Forms.Label();
            this.pbxDuzenle = new System.Windows.Forms.PictureBox();
            this.lblnid = new System.Windows.Forms.Label();
            this.pnlBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxSil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcerik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDuzenle)).BeginInit();
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
            this.pnlBack.Controls.Add(this.lblnid);
            this.pnlBack.Controls.Add(this.pbxSil);
            this.pnlBack.Controls.Add(this.pbxPrjAd);
            this.pnlBack.Controls.Add(this.pbxTarih);
            this.pnlBack.Controls.Add(this.pbxIcerik);
            this.pnlBack.Controls.Add(this.dtpTarih);
            this.pnlBack.Controls.Add(this.lblPrjAdi);
            this.pnlBack.Controls.Add(this.lblNot);
            this.pnlBack.Controls.Add(this.pbxDuzenle);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.ShowBorders = true;
            this.pnlBack.Size = new System.Drawing.Size(1084, 71);
            this.pnlBack.TabIndex = 0;
            // 
            // pbxSil
            // 
            this.pbxSil.Image = ((System.Drawing.Image)(resources.GetObject("pbxSil.Image")));
            this.pbxSil.Location = new System.Drawing.Point(1043, 17);
            this.pbxSil.Name = "pbxSil";
            this.pbxSil.Size = new System.Drawing.Size(41, 38);
            this.pbxSil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxSil.TabIndex = 45;
            this.pbxSil.TabStop = false;
            this.pbxSil.Click += new System.EventHandler(this.pbxSil_Click);
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
            // pbxIcerik
            // 
            this.pbxIcerik.Image = ((System.Drawing.Image)(resources.GetObject("pbxIcerik.Image")));
            this.pbxIcerik.Location = new System.Drawing.Point(195, 16);
            this.pbxIcerik.Name = "pbxIcerik";
            this.pbxIcerik.Size = new System.Drawing.Size(41, 38);
            this.pbxIcerik.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxIcerik.TabIndex = 42;
            this.pbxIcerik.TabStop = false;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Enabled = false;
            this.dtpTarih.Location = new System.Drawing.Point(852, 25);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(102, 20);
            this.dtpTarih.TabIndex = 41;
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
            // pbxDuzenle
            // 
            this.pbxDuzenle.Image = ((System.Drawing.Image)(resources.GetObject("pbxDuzenle.Image")));
            this.pbxDuzenle.Location = new System.Drawing.Point(996, 17);
            this.pbxDuzenle.Name = "pbxDuzenle";
            this.pbxDuzenle.Size = new System.Drawing.Size(41, 38);
            this.pbxDuzenle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxDuzenle.TabIndex = 46;
            this.pbxDuzenle.TabStop = false;
            this.pbxDuzenle.Click += new System.EventHandler(this.pbxDuzenle_Click);
            // 
            // lblnid
            // 
            this.lblnid.AutoSize = true;
            this.lblnid.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblnid.Location = new System.Drawing.Point(47, 52);
            this.lblnid.Name = "lblnid";
            this.lblnid.Size = new System.Drawing.Size(31, 15);
            this.lblnid.TabIndex = 47;
            this.lblnid.Text = "n_id";
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
            ((System.ComponentModel.ISupportInitialize)(this.pbxSil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxPrjAd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTarih)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxIcerik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDuzenle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel pnlBack;
        public System.Windows.Forms.PictureBox pbxDuzenle;
        public System.Windows.Forms.PictureBox pbxSil;
        public System.Windows.Forms.PictureBox pbxTarih;
        public System.Windows.Forms.PictureBox pbxIcerik;
        public System.Windows.Forms.DateTimePicker dtpTarih;
        public System.Windows.Forms.Label lblNot;
        public System.Windows.Forms.PictureBox pbxPrjAd;
        public System.Windows.Forms.Label lblPrjAdi;
        public System.Windows.Forms.Label lblnid;
    }
}
