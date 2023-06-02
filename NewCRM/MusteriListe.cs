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

namespace NewCRM
{
    public partial class MusteriListe : Form
    {
        public MusteriListe()
        {
            InitializeComponent();
        }


        private void MusteriListe_Load(object sender, EventArgs e)
        {
            Personel_Bilgileri.m_id = null;
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            SqlCommand listele = new SqlCommand("SELECT m_id, ad, soyad, calistigi_yer, son_tarih, projeyi_yoneten, proje_adi, durum, ep,tel FROM Musteri", baglan);
            baglan.Open();
            SqlDataReader oku = listele.ExecuteReader();
            while (oku.Read())
            {
                UC_MusteriListe uc = new UC_MusteriListe();
                uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("m_id")).ToString();
                uc.lblAd.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                uc.lblcYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                uc.lbliletisim.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                Personel_Bilgileri.yoneten = oku.GetInt32(oku.GetOrdinal("projeyi_yoneten")).ToString();
                uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                uc.lblPrjjDurum.Text = oku.GetString(oku.GetOrdinal("durum"));

                uc.Dock = DockStyle.Top;
                pnlListe.Controls.Add(uc);
            }

            SqlCommand ad = new SqlCommand("SELECT ad, soyad FROM PersonelTablosu WHERE tc=@tc", baglan);
            ad.Parameters.AddWithValue("@tc", Personel_Bilgileri.yoneten);

            oku.Close();

            SqlDataReader okuma = ad.ExecuteReader();

            while (okuma.Read())
            {
                UC_MusteriListe ek = new UC_MusteriListe();
                Personel_Bilgileri.yoneten = okuma.GetString(okuma.GetOrdinal("ad")) + " " + okuma.GetString(okuma.GetOrdinal("soyad"));
                ek.lblYoneten.Text = Personel_Bilgileri.yoneten;
            }
            okuma.Close();
            baglan.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {

            Musteri_Detay f = new Musteri_Detay();
            f.btnMusteriBilgileriDegisikleri.Text = "Kaydet";
            MusteriListe pl = (MusteriListe)Application.OpenForms["MusteriListe"];
            pl.Close();
            Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            ans.formGetir(f);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (Personel_Bilgileri.m_id == null)
            {
                MessageBox.Show("işlemi gerçekleştirmek istediğiniz kaydı seçiniz.");
            }
            else
            {
                Musteri_Detay f = new Musteri_Detay();
                f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
                MusteriListe pl = (MusteriListe)Application.OpenForms["MusteriListe"];
                pl.Close();
                Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                ans.formGetir(f);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Personel_Bilgileri.m_id == null)
            {
                MessageBox.Show("işlemi gerçekleştirmek istediğiniz kaydı seçiniz.");
            }
            else
            {
                SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");                
                SqlCommand silme = new SqlCommand("DELETE FROM Musteri WHERE m_id=@id",baglan);
                silme.Parameters.AddWithValue("@id",Personel_Bilgileri.m_id);
                baglan.Open();
                silme.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Başarıyla silindi");
                this.Close();
                MusteriListe f = new MusteriListe();
                Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                ans.formGetir(f);
            }
        }
    }
}
