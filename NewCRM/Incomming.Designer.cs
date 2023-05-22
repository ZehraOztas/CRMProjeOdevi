namespace NewCRM
{
    partial class Incomming
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Incomming));
            this.buc = new Bunifu.UI.WinForms.BunifuUserControl();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.pbxProfil = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // buc
            // 
            this.buc.AllowAnimations = false;
            this.buc.AllowBorderColorChanges = false;
            this.buc.AllowMouseEffects = false;
            this.buc.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buc.AnimationSpeed = 200;
            this.buc.BackColor = System.Drawing.Color.Transparent;
            this.buc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.buc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.buc.BorderRadius = 30;
            this.buc.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.buc.BorderThickness = 1;
            this.buc.ColorContrastOnClick = 30;
            this.buc.ColorContrastOnHover = 30;
            this.buc.Cursor = System.Windows.Forms.Cursors.Default;
            this.buc.Image = null;
            this.buc.ImageMargin = new System.Windows.Forms.Padding(0);
            this.buc.Location = new System.Drawing.Point(57, 3);
            this.buc.Name = "buc";
            this.buc.ShowBorders = true;
            this.buc.Size = new System.Drawing.Size(457, 143);
            this.buc.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.buc.TabIndex = 0;
            // 
            // lblmesaj
            // 
            this.lblmesaj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(151)))), ((int)(((byte)(249)))));
            this.lblmesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblmesaj.Location = new System.Drawing.Point(67, 16);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(438, 120);
            this.lblmesaj.TabIndex = 2;
            this.lblmesaj.Text = "Zehraaaa";
            // 
            // pbxProfil
            // 
            this.pbxProfil.AllowFocused = false;
            this.pbxProfil.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbxProfil.AutoSizeHeight = true;
            this.pbxProfil.BorderRadius = 24;
            this.pbxProfil.Image = ((System.Drawing.Image)(resources.GetObject("pbxProfil.Image")));
            this.pbxProfil.IsCircle = true;
            this.pbxProfil.Location = new System.Drawing.Point(3, 3);
            this.pbxProfil.Name = "pbxProfil";
            this.pbxProfil.Size = new System.Drawing.Size(48, 48);
            this.pbxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxProfil.TabIndex = 1;
            this.pbxProfil.TabStop = false;
            this.pbxProfil.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Incomming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.pbxProfil);
            this.Controls.Add(this.buc);
            this.Name = "Incomming";
            this.Size = new System.Drawing.Size(547, 149);
            this.Load += new System.EventHandler(this.Incomming_Load);
            this.Resize += new System.EventHandler(this.Incomming_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pbxProfil)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuUserControl buc;
        private Bunifu.UI.WinForms.BunifuPictureBox pbxProfil;
        private System.Windows.Forms.Label lblmesaj;
    }
}
