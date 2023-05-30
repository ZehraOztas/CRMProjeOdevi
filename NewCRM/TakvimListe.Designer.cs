namespace NewCRM
{
    partial class TakvimListe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlBack = new Bunifu.UI.WinForms.BunifuShadowPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBack
            // 
            this.pnlBack.BackColor = System.Drawing.Color.Transparent;
            this.pnlBack.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBack.BorderRadius = 10;
            this.pnlBack.BorderThickness = 1;
            this.pnlBack.Controls.Add(this.panel1);
            this.pnlBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBack.FillStyle = Bunifu.UI.WinForms.BunifuShadowPanel.FillStyles.Solid;
            this.pnlBack.GradientMode = Bunifu.UI.WinForms.BunifuShadowPanel.GradientModes.Vertical;
            this.pnlBack.Location = new System.Drawing.Point(0, 0);
            this.pnlBack.Name = "pnlBack";
            this.pnlBack.PanelColor = System.Drawing.Color.WhiteSmoke;
            this.pnlBack.PanelColor2 = System.Drawing.Color.WhiteSmoke;
            this.pnlBack.ShadowColor = System.Drawing.Color.DarkGray;
            this.pnlBack.ShadowDept = 2;
            this.pnlBack.ShadowDepth = 3;
            this.pnlBack.ShadowStyle = Bunifu.UI.WinForms.BunifuShadowPanel.ShadowStyles.Surrounded;
            this.pnlBack.ShadowTopLeftVisible = false;
            this.pnlBack.Size = new System.Drawing.Size(741, 612);
            this.pnlBack.Style = Bunifu.UI.WinForms.BunifuShadowPanel.BevelStyles.Flat;
            this.pnlBack.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(735, 588);
            this.panel1.TabIndex = 0;
            // 
            // TakvimListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 612);
            this.Controls.Add(this.pnlBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TakvimListe";
            this.Text = "TakvimListe";
            this.Load += new System.EventHandler(this.TakvimListe_Load);
            this.pnlBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuShadowPanel pnlBack;
        private System.Windows.Forms.Panel panel1;
    }
}