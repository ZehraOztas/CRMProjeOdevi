namespace NewCRM
{
    partial class UC_Gelen_Mesaj
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Gelen_Mesaj));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbxFoto = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.uC_Gonderilen_Mesaj1 = new NewCRM.UC_Gonderilen_Mesaj();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Gonderilen_Mesaj1);
            this.panel1.Controls.Add(this.pbxFoto);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 46);
            this.panel1.TabIndex = 0;
            // 
            // pbxFoto
            // 
            this.pbxFoto.AllowFocused = false;
            this.pbxFoto.AutoSizeHeight = true;
            this.pbxFoto.BorderRadius = 21;
            this.pbxFoto.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.IsCircle = true;
            this.pbxFoto.Location = new System.Drawing.Point(0, 0);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(43, 43);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 5;
            this.pbxFoto.TabStop = false;
            this.pbxFoto.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // uC_Gonderilen_Mesaj1
            // 
            this.uC_Gonderilen_Mesaj1.Dock = System.Windows.Forms.DockStyle.Right;
            this.uC_Gonderilen_Mesaj1.Location = new System.Drawing.Point(49, 0);
            this.uC_Gonderilen_Mesaj1.Name = "uC_Gonderilen_Mesaj1";
            this.uC_Gonderilen_Mesaj1.Size = new System.Drawing.Size(458, 46);
            this.uC_Gonderilen_Mesaj1.TabIndex = 6;
            this.uC_Gonderilen_Mesaj1.Title = null;
            // 
            // UC_Gelen_Mesaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UC_Gelen_Mesaj";
            this.Size = new System.Drawing.Size(510, 46);
            this.Load += new System.EventHandler(this.UC_Gelen_Mesaj_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuPictureBox pbxFoto;
        private UC_Gonderilen_Mesaj uC_Gonderilen_Mesaj1;
    }
}
