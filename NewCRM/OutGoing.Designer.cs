namespace NewCRM
{
    partial class OutGoing
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
            this.buc = new Bunifu.UI.WinForms.BunifuUserControl();
            this.lbltext = new System.Windows.Forms.Label();
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
            this.buc.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.buc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.buc.BorderRadius = 30;
            this.buc.BorderStyle = Bunifu.UI.WinForms.BunifuUserControl.BorderStyles.Solid;
            this.buc.BorderThickness = 1;
            this.buc.ColorContrastOnClick = 30;
            this.buc.ColorContrastOnHover = 30;
            this.buc.Cursor = System.Windows.Forms.Cursors.Default;
            this.buc.Image = null;
            this.buc.ImageMargin = new System.Windows.Forms.Padding(0);
            this.buc.Location = new System.Drawing.Point(59, 0);
            this.buc.Name = "buc";
            this.buc.ShowBorders = true;
            this.buc.Size = new System.Drawing.Size(453, 143);
            this.buc.Style = Bunifu.UI.WinForms.BunifuUserControl.UserControlStyles.Flat;
            this.buc.TabIndex = 0;
            // 
            // lbltext
            // 
            this.lbltext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbltext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(247)))), ((int)(((byte)(255)))));
            this.lbltext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltext.Location = new System.Drawing.Point(69, 13);
            this.lbltext.Name = "lbltext";
            this.lbltext.Size = new System.Drawing.Size(434, 120);
            this.lbltext.TabIndex = 2;
            this.lbltext.Text = "Zehraaaa";
            // 
            // OutGoing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.lbltext);
            this.Controls.Add(this.buc);
            this.Name = "OutGoing";
            this.Size = new System.Drawing.Size(547, 149);
            this.Resize += new System.EventHandler(this.Incomming_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuUserControl buc;
        private System.Windows.Forms.Label lbltext;
    }
}
