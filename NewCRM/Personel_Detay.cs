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
    public partial class Personel_Detay : Form
    {
        public Personel_Detay()
        {
            InitializeComponent();
        }

        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void Personel_Detay_Load(object sender, EventArgs e)//Burada eğer btnKaydet'in texti Güncelle ise seçili personelin verilerini lister ancak seçili değilse formun içindeki nesneler boş olarak görüntülenir.
        {
            if (btnKaydet.Text == "Güncelle")
            {
                SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
                SqlCommand listele = new SqlCommand("SELECT * FROM PersonelTablosu WHERE tc=@tc", baglan);
                listele.Parameters.AddWithValue("@tc", Personel_Bilgileri.calisanId);
                baglan.Open();
                SqlDataReader oku = listele.ExecuteReader();
                while (oku.Read())
                {
                    txtTc.Text = oku.GetString(oku.GetOrdinal("tc"));
                    txtAd.Text = oku.GetString(oku.GetOrdinal("ad"));
                    txtsad.Text = oku.GetString(oku.GetOrdinal("soyad"));
                    if (oku.GetString(oku.GetOrdinal("cinsiyet"))== "Erkek")
                    {
                        rbtnErkek.Checked = true;
                        rbtnKadin.Checked = false;
                    }
                    else if (oku.GetString(oku.GetOrdinal("cinsiyet")) == "Kadın")
                    {
                        rbtnErkek.Checked = false;
                        rbtnKadin.Checked = true;
                    }
                    dt.Value = oku.GetDateTime(oku.GetOrdinal("dogum_tarihi"));
                    txtPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                    txtTel1.Text = oku.GetString(oku.GetOrdinal("tel1"));
                    txtTel2.Text = oku.GetString(oku.GetOrdinal("tel2"));
                    txtEp1.Text = oku.GetString(oku.GetOrdinal("ep1"));
                    txtEp2.Text = oku.GetString(oku.GetOrdinal("ep2"));
                    txtAdres.Text = oku.GetString(oku.GetOrdinal("adres"));
                    cbxIl.Text = oku.GetString(oku.GetOrdinal("il"));
                    cbxIlce.Text = oku.GetString(oku.GetOrdinal("ilce"));
                    if (oku.GetInt32(oku.GetOrdinal("yetki")) == 1)
                    {
                        cbxYetki.Text = "Yönetici";

                    }
                    else if (oku.GetInt32(oku.GetOrdinal("yetki")) == 0)
                    {
                        cbxYetki.Text = "Personel";
                    }
                    txtPosta.Text = oku.GetString(oku.GetOrdinal("posta_kodu"));
                    dtpIseGirisTarihi.Value = oku.GetDateTime(oku.GetOrdinal("ise_giris_tarihi"));
                }

                PersonelinMusterisi f = new PersonelinMusterisi();
                f.TopLevel = false; // Üst düzey form olmadığını belirtmek için
                f.FormBorderStyle = FormBorderStyle.None; // Kenarlığını gizlemek için
                f.Dock = DockStyle.Fill;
                pnlMusteriListe.Controls.Add(f);
                f.Show();
            }

            else if(btnKaydet.Text == "Kaydet")
            {
                pnlKisiselBilgi.Enabled = true;
            }

        }

        private void pnlBack_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)//Buttonun textine göre güncelleme ya da kaydetme işlemi yapar. Müşteri kaydettikten sonra buttonun textini de Güncelle olarak değiştireceği için aynı kaydı tekrar kaydetmez.
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            if (btnKaydet.Text == "Güncelle")
            {
                SqlCommand guncelle = new SqlCommand("UPDATE PersonelTablosu SET ad=@ad, soyad=@sad, cinsiyet=@c, dogum_tarihi=@dt, pozisyonu=@p, tel1=@t1, tel2=@t2, ep1=@e1,ep2=@e2, adres=@adres, il=@il, ilce=@ilce, yetki=@y, posta_kodu=@p_kod, ise_giris_tarihi=@igt WHERE tc=@tc", baglan);
                guncelle.Parameters.AddWithValue("tc",Personel_Bilgileri.calisanId);
                guncelle.Parameters.AddWithValue("@ad",txtAd.Text);
                guncelle.Parameters.AddWithValue("@sad", txtsad.Text);
                if (rbtnErkek.Checked == true && rbtnKadin.Checked == false)
                {
                    guncelle.Parameters.AddWithValue("@c", "Erkek");
                }
                else if (rbtnKadin.Checked == true && rbtnErkek.Checked == false)
                {
                    guncelle.Parameters.AddWithValue("@c", "Kadın");
                }
                guncelle.Parameters.AddWithValue("@dt", dt.Value);
                guncelle.Parameters.AddWithValue("@p", txtPozisyon.Text);
                guncelle.Parameters.AddWithValue("@t1", txtTel1.Text);
                guncelle.Parameters.AddWithValue("@t2", txtTel2.Text);
                guncelle.Parameters.AddWithValue("@e1", txtEp1.Text);
                guncelle.Parameters.AddWithValue("@e2", txtEp2.Text);
                guncelle.Parameters.AddWithValue("@adres", txtAdres.Text);
                guncelle.Parameters.AddWithValue("@il", cbxIl.Text);
                guncelle.Parameters.AddWithValue("@ilce", cbxIlce.Text);
                if (cbxYetki.Text == "Yönetici")
                {
                    guncelle.Parameters.AddWithValue("@y", 1);

                }
                else if (cbxYetki.Text == "Personel")
                {
                    guncelle.Parameters.AddWithValue("@y", 0);

                }
                guncelle.Parameters.AddWithValue("@p_kod", txtPosta.Text);
                guncelle.Parameters.AddWithValue("@igt", dtpIseGirisTarihi.Value);
                baglan.Open();
                guncelle.ExecuteNonQuery();
                baglan.Close();
                this.Alert("İşleminiz başarıyla gerçekleştirildi.", Form_Alert.enmType.Success);
            }

            else if (btnKaydet.Text =="Kaydet")
            {
                SqlCommand ekle = new SqlCommand("INSERT INTO PersonelTablosu (tc,ad,soyad,cinsiyet, dogum_tarihi, pozisyonu, tel1, tel2, ep1,ep2, adres, il, ilce, yetki, posta_kodu, ise_giris_tarihi) values (@tc, @ad, @sad, @c, @dt, @p, @t1, @t2, @e1,@e2, @adres, @il,@ilce,@y,@p_kod, @igt)", baglan);
                ekle.Parameters.AddWithValue("tc", txtTc.Text);
                ekle.Parameters.AddWithValue("@ad", txtAd.Text);
                ekle.Parameters.AddWithValue("@sad", txtsad.Text);
                if (rbtnErkek.Checked == true && rbtnKadin.Checked == false)
                {
                    ekle.Parameters.AddWithValue("@c", "Erkek");
                }
                else if (rbtnKadin.Checked == true && rbtnErkek.Checked == false)
                {
                    ekle.Parameters.AddWithValue("@c", "Kadın");
                }
                ekle.Parameters.AddWithValue("@dt", dt.Value);
                ekle.Parameters.AddWithValue("@p", txtPozisyon.Text);
                ekle.Parameters.AddWithValue("@t1", txtTel1.Text);
                ekle.Parameters.AddWithValue("@t2", txtTel2.Text);
                ekle.Parameters.AddWithValue("@e1", txtEp1.Text);
                ekle.Parameters.AddWithValue("@e2", txtEp2.Text);
                ekle.Parameters.AddWithValue("@adres", txtAdres.Text);
                ekle.Parameters.AddWithValue("@il", cbxIl.Text);
                ekle.Parameters.AddWithValue("@ilce", cbxIlce.Text);
                
                if (cbxYetki.Text == "Yönetici")
                {
                    ekle.Parameters.AddWithValue("@y", 1);

                }
                else if (cbxYetki.Text == "Personel")
                {
                    ekle.Parameters.AddWithValue("@y", 0);

                }

                ekle.Parameters.AddWithValue("@p_kod", txtPosta.Text);
                ekle.Parameters.AddWithValue("@igt", dtpIseGirisTarihi.Value);
                baglan.Open();
                ekle.ExecuteReader();
                baglan.Close();
                btnKaydet.Text = "Güncelle";
                this.Alert("İşleminiz başarıyla gerçekleştirildi.", Form_Alert.enmType.Success);
            }
        }
    }
}
