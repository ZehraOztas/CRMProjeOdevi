using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{
    public partial class Ana_Sayfa : Form
    {
        public Ana_Sayfa()
        {
            InitializeComponent();
        }
       
        public void formGetir(Form f)
        {
            pnlGecis.Controls.Clear();          
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnlGecis.Controls.Add(f); // panel içinde açılmasını sağlıyor.
            f.Show();
        }
        public void cikisYap()
        {
            DialogResult cevap = MessageBox.Show("Oturumuzu sonlandırmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                this.Close();
                Login frm = new Login();
                frm.ShowDialog();
            }

            Personel_Bilgileri.tc = "";
            Personel_Bilgileri.ad = "";
            Personel_Bilgileri.sad = "";
            Personel_Bilgileri.cinsiyet = "";
            Personel_Bilgileri.ep1 = "";
            Personel_Bilgileri.ep2 = "";
         //   Personel_Bilgileri.dt = DateTime.MinValue;
            Personel_Bilgileri.tel1 = "";
            Personel_Bilgileri.tel2 = "";
            Personel_Bilgileri.adres = "";
            Personel_Bilgileri.il= "";
            Personel_Bilgileri.ilce = "";
            Personel_Bilgileri.sifre = "";
            Personel_Bilgileri.yetki = -1;
            Personel_Bilgileri.foto = "";
            Personel_Bilgileri.pozisyon = "";

        }

        private void btnProfil_Click(object sender, EventArgs e)
        {
            Personel f = new Personel();
            formGetir(f);
        }

        private void btnIslemler_Click(object sender, EventArgs e)
        {

        }

        private void btnForum_Click(object sender, EventArgs e)
        {
          //  btnForum.BackColor = Color.FromArgb(142; 148; 242);
        }

        private void Ana_Sayfa_Load(object sender, EventArgs e)
        {
            lblAd.Text = Personel_Bilgileri.ad + " " + Personel_Bilgileri.sad;
            if (Personel_Bilgileri.yetki == 1)
            {
                btnPersonelBilgileri.Visible = true;
                btnProjeler.Visible = true;
            }
            else
            {
                btnPersonelBilgileri.Visible = false;
                btnProjeler.Visible = false;
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            MusteriBilgileri f = new MusteriBilgileri();
            formGetir(f);
        }

        private void pbxCikis_Click(object sender, EventArgs e)
        {
            cikisYap();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Uygulamadan çıkmak istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            cikisYap();
        }

        private void btnPBilgileri_Click(object sender, EventArgs e)
        {
            Personel f = new Personel();
            formGetir(f);
            pnlKapa.Visible = false;
        }

        private void pbxKfoto_Click(object sender, EventArgs e)
        {
            if (pnlKapa.Visible == false)
            {
                pnlKapa.Visible = true;
            }
            else
            {
                pnlKapa.Visible = false;
            }
        }

        private void btnSifre_Click(object sender, EventArgs e)
        {
            pnlKapa.Visible = false;
        }

        private void btnMesajlar_Click(object sender, EventArgs e)
        {
            Chat f = new Chat();
            formGetir(f);
        }

        private void pbxTakvim_Click(object sender, EventArgs e)
        {
            Takvim f = new Takvim();
            formGetir(f);
        }

        private void btnForum_Click_1(object sender, EventArgs e)
        {
            Takvim f = new Takvim();
            formGetir(f);
        }

        private void btnPersonelBilgileri_Click(object sender, EventArgs e)
        {
            personelListesi f = new personelListesi();
            formGetir(f);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProjeler_Click(object sender, EventArgs e)
        {
            MusteriListe f = new MusteriListe();
            formGetir(f);
        }

    }

}
