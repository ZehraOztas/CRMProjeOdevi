using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace NewCRM
{
    public partial class Login : Form
    {
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public Login()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        private void btnGir_Click(object sender, EventArgs e)
        {
            SqlCommand giris = new SqlCommand("SELECT * FROM PersonelTablosu Where tc=@tc and sifre=@s", baglanti);
            giris.Parameters.AddWithValue("@tc",txtKad.Text);
            giris.Parameters.AddWithValue("@s", txtSifre.Text);
            baglanti.Open();
            SqlDataReader oku = giris.ExecuteReader();

            if (oku.Read())
            {
                Personel_Bilgileri.tc = oku.GetString(oku.GetOrdinal("tc"));
                Personel_Bilgileri.ad = oku.GetString(oku.GetOrdinal("ad"));
                Personel_Bilgileri.sad = oku.GetString(oku.GetOrdinal("soyad"));
                Personel_Bilgileri.cinsiyet = oku.GetString(oku.GetOrdinal("cinsiyet"));
                Personel_Bilgileri.dt = oku.GetDateTime(oku.GetOrdinal("dogum_tarihi"));
                Personel_Bilgileri.pozisyon = oku.GetString(oku.GetOrdinal("pozisyonu"));
                Personel_Bilgileri.tel1 = oku.GetString(oku.GetOrdinal("tel1"));
                Personel_Bilgileri.tel2 = oku.GetString(oku.GetOrdinal("tel2"));
                Personel_Bilgileri.ep1 = oku.GetString(oku.GetOrdinal("ep1"));
                Personel_Bilgileri.ep2 = oku.GetString(oku.GetOrdinal("ep2"));
                Personel_Bilgileri.adres = oku.GetString(oku.GetOrdinal("adres"));
                Personel_Bilgileri.il = oku.GetString(oku.GetOrdinal("il"));
                Personel_Bilgileri.ilce = oku.GetString(oku.GetOrdinal("ilce"));
                Personel_Bilgileri.postaKodu = oku.GetString(oku.GetOrdinal("posta_kodu"));
                Personel_Bilgileri.yetki = oku.GetInt32(oku.GetOrdinal("yetki"));
                Personel_Bilgileri.sifre = oku.GetString(oku.GetOrdinal("sifre"));
          //      Personel_Bilgileri.foto = oku.GetString(oku.GetOrdinal("foto"));

                Ana_Sayfa f = new Ana_Sayfa();
                f.Show();
                this.Hide();

            }
            else
            {
                this.Alert("Lütfen bilgilerinizi kontrol ediniz.", Form_Alert.enmType.Error);
                txtKad.Clear();
                txtSifre.Clear();
                txtKad.Focus();
            }
            oku.Close();
            baglanti.Close();
        }

        private void bunifuGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
