using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NewCRM
{
    public partial class MailGomderme : Form
    {
        public MailGomderme()
        {
            InitializeComponent();
        }
        string gondericiAd = "CRM Projesi";
        string gondericiMail = "CRM_Projesi@hotmail.com";
        string gondericiSifre = "CRMProjesi";
        string aliciMail;
        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void btnMusteriBilgileriDegisikleri_Click(object sender, EventArgs e)
        {
            SendMail sm = new SendMail();
            sm.Microsoft(gondericiAd, gondericiMail, gondericiSifre, aliciMail, txtBaslik.Text, txticerik.Text, lblEk.Text);
            MessageBox.Show("İşlem başarıyla gerçekleştirildi.");
        }

        private void pbxEk_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Gönderi İçin Ek Dosya Seçebilirsiniz.";
            ofd.ShowDialog();
            lblEk.Text = ofd.FileName;
        }

        private void MailGomderme_Load(object sender, EventArgs e)
        {
            lblEk.Text = "";
            string ad;
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            SqlCommand listele = new SqlCommand("SELECT ad,soyad,ep From Musteri WHERE m_id=@id", baglan);
            listele.Parameters.AddWithValue("@id",Personel_Bilgileri.m_id);
            baglan.Open();
            SqlDataReader oku = listele.ExecuteReader();
            while(oku.Read())
            {
                aliciMail = oku.GetString(oku.GetOrdinal("ep"));
               ad = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                txtAlici.Text = ad;
            }
            baglan.Close();
        }

        private void cbxAlici_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

    
}
