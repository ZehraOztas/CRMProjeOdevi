﻿namespace NewCRM
{
    partial class UC_Kisiler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Kisiler));
            this.pnlKisiler = new System.Windows.Forms.Panel();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.pbxKisiFoto = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.pnlKisiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKisiFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlKisiler
            // 
            this.pnlKisiler.Controls.Add(this.lblAdSoyad);
            this.pnlKisiler.Controls.Add(this.pbxKisiFoto);
            this.pnlKisiler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlKisiler.Location = new System.Drawing.Point(0, 0);
            this.pnlKisiler.Name = "pnlKisiler";
            this.pnlKisiler.Size = new System.Drawing.Size(210, 77);
            this.pnlKisiler.TabIndex = 0;
            this.pnlKisiler.Click += new System.EventHandler(this.pnlKisiler_Click);
            this.pnlKisiler.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlKisiler_Paint);
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Location = new System.Drawing.Point(79, 27);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(41, 15);
            this.lblAdSoyad.TabIndex = 3;
            this.lblAdSoyad.Text = "label1";
            // 
            // pbxKisiFoto
            // 
            this.pbxKisiFoto.AllowFocused = false;
            this.pbxKisiFoto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxKisiFoto.AutoSizeHeight = true;
            this.pbxKisiFoto.BorderRadius = 30;
            this.pbxKisiFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxKisiFoto.Image")));
            this.pbxKisiFoto.IsCircle = true;
            this.pbxKisiFoto.Location = new System.Drawing.Point(3, 5);
            this.pbxKisiFoto.Name = "pbxKisiFoto";
            this.pbxKisiFoto.Size = new System.Drawing.Size(61, 61);
            this.pbxKisiFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxKisiFoto.TabIndex = 2;
            this.pbxKisiFoto.TabStop = false;
            this.pbxKisiFoto.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // UC_Kisiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlKisiler);
            this.Name = "UC_Kisiler";
            this.Size = new System.Drawing.Size(210, 77);
            this.pnlKisiler.ResumeLayout(false);
            this.pnlKisiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxKisiFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlKisiler;
        public System.Windows.Forms.Label lblAdSoyad;
        public Bunifu.UI.WinForms.BunifuPictureBox pbxKisiFoto;
    }
}
