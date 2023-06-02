using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace NewCRM
{
    public partial class Musteri_Detay : Form
    {
        public Musteri_Detay()
        {
            InitializeComponent();
        }
        private void pnlBack_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void Musteri_Detay_Load(object sender, EventArgs e)
        {
            if (btnMusteriBilgileriDegisikleri.Text == "Güncelle")
            {
                SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

                SqlCommand listele = new SqlCommand("SELECT * FROM Musteri WHERE m_id=@id", baglan);
                listele.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);
                baglan.Open();

                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    txtADs.Text = oku.GetString(oku.GetOrdinal("ad"));
                    txtSoyad.Text = oku.GetString(oku.GetOrdinal("soyad"));
                    txtcalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                    txtPozisyonu.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                    cbxProjeAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    cbxDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                    txtPrjYoneten.Text = Personel_Bilgileri.yoneten;
                }
                oku.Close();

                //SqlDataReader okuma = ad.ExecuteReader();

                //while (okuma.Read())
                //{
                //    txtPrjYoneten.Text = okuma.GetString(okuma.GetOrdinal("ad")) + " " + okuma.GetString(okuma.GetOrdinal("soyad"));
                //}
                //  okuma.Close();

                baglan.Close();

                SqlCommand komut = new SqlCommand("SELECT n_id,icerik,eklenen_tarih,proje_adi FROM Notlar WHERE musteri_id=@id ORDER BY eklenen_tarih desc", baglan);
                komut.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);
                baglan.Open();
                SqlDataReader okuma = komut.ExecuteReader();

                while (okuma.Read())
                {
                    UC_MusteriNotlar uc = new UC_MusteriNotlar();

                    uc.lblPrjAdi.Text = okuma.GetString(okuma.GetOrdinal("proje_adi"));
                    uc.lblNot.Text = okuma.GetString(okuma.GetOrdinal("icerik"));
                    uc.dtpTarih.Value = okuma.GetDateTime(okuma.GetOrdinal("eklenen_tarih"));
                    uc.lblYoneten.Text = Personel_Bilgileri.yoneten;
                    uc.lblnid.Text = okuma.GetInt32(okuma.GetOrdinal("n_id")).ToString();

                    uc.Dock = DockStyle.Top;
                    pnlNotlar.Controls.Add(uc);
                }

                okuma.Close();
                baglan.Close();
            }
            

        }

        private void btnMusteriBilgileriDegisikleri_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            if (btnMusteriBilgileriDegisikleri.Text == "Güncelle")
            {
                SqlCommand guncelle = new SqlCommand("UPDATE MUSTERİ SET ad=@ad, soyad=@sad, ep=@ep, tel=@tel,calistigi_yer=@cyer, pozisyonu=@1p, ilk_tarih=@it, son_tarih=@st, durum=@d, proje_adi=@pad  WHERE m_id=@id", baglan);
                guncelle.Parameters.AddWithValue("@id",Personel_Bilgileri.m_id);
                guncelle.Parameters.AddWithValue("@ad", txtADs.Text);
                guncelle.Parameters.AddWithValue("@sad", txtSoyad.Text);
                guncelle.Parameters.AddWithValue("@ep", txtEp.Text);
                guncelle.Parameters.AddWithValue("@tel", txtTel.Text);
                guncelle.Parameters.AddWithValue("@cyer", txtcalistigiYer.Text);
                guncelle.Parameters.AddWithValue("@p", txtPozisyonu.Text);
                guncelle.Parameters.AddWithValue("@it", dtpIlkİletisim.Value);
                guncelle.Parameters.AddWithValue("@st", dtpBirSonraki.Value);
                guncelle.Parameters.AddWithValue("@pad", cbxProjeAdi.Text);
                guncelle.Parameters.AddWithValue("@d", cbxDurum.Text);
                baglan.Open();
                guncelle.ExecuteReader();
                baglan.Close();
                MessageBox.Show("Kayıt güncellendi.");
            }
            else if (btnMusteriBilgileriDegisikleri.Text == "Kaydet")
            {
                SqlCommand guncelle = new SqlCommand("INSERT INTO MUSTERİ(ad, soyad, ep, tel,calistigi_yer, pozisyonu, ilk_tarih, son_tarih, durum, proje_adi, projeyi_yoneten)values(@ad,@sad, @ep, @tel,@cyer, @p,@it,@st,@d,@pad, @yoneten)", baglan);
                guncelle.Parameters.AddWithValue("@ad", txtADs.Text);
                guncelle.Parameters.AddWithValue("@sad", txtSoyad.Text);
                guncelle.Parameters.AddWithValue("@ep", txtEp.Text);
                guncelle.Parameters.AddWithValue("@tel", txtTel.Text);
                guncelle.Parameters.AddWithValue("@cyer", txtcalistigiYer.Text);
                guncelle.Parameters.AddWithValue("@p", txtPozisyonu.Text);
                guncelle.Parameters.AddWithValue("@it", dtpIlkİletisim.Value);
                guncelle.Parameters.AddWithValue("@st", dtpBirSonraki.Value);
                guncelle.Parameters.AddWithValue("@pad", cbxProjeAdi.Text);
                guncelle.Parameters.AddWithValue("@d", cbxDurum.Text);
                guncelle.Parameters.AddWithValue("@yoneten", txtPrjYoneten.Text);
                baglan.Open();
                guncelle.ExecuteReader();
                baglan.Close();
                MessageBox.Show("İşleminiz başarıyla kaydedildi.");

            }
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            BackModel backmodel = new BackModel();
            NotlarForm percikarcard = new NotlarForm();
            percikarcard.tip = "Yeni Kayıt";
            percikarcard.btnKaydet.Text = "Kaydet";
            percikarcard.StartPosition = FormStartPosition.CenterScreen;
            backmodel.FormBorderStyle = FormBorderStyle.None;
            backmodel.Opacity = .50d;
            backmodel.BackColor = Color.Black;
            backmodel.ShowInTaskbar = false;
            backmodel.Show();
            percikarcard.Owner = backmodel;
            percikarcard.ShowDialog();
            backmodel.Dispose();
        }
    }
}
