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
    public partial class personelListesi : Form
    {
        public personelListesi()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        private void personelListesi_Load(object sender, EventArgs e)//Form açıldığında UC_PersonelListesi adlı usercontrol çekerek o usercontrol'a değerler verilir.
        {
            Personel_Bilgileri.calisanId = null;
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            pnlListe.Controls.Clear();

            SqlCommand command = new SqlCommand("SELECT tc,ad, soyad,pozisyonu,ise_giris_tarihi ,cinsiyet,dogum_tarihi,ep1,tel1, adres,il, ilce FROM PersonelTablosu ORDER BY ise_giris_tarihi asc", baglan);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                UC_PersonelListesi uc = new UC_PersonelListesi();
                uc.lblid.Text = oku.GetString(oku.GetOrdinal("tc")).ToString();
                uc.lblAd.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep1"));
                uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel1"));
                uc.lblPozisyonu.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                uc.lblDt.Text = oku.GetDateTime(oku.GetOrdinal("dogum_tarihi")).ToString();
                uc.lbliseBasTrh.Text = oku.GetDateTime(oku.GetOrdinal("ise_giris_tarihi")).ToString();
                uc.lblCinsiyet.Text = oku.GetString(oku.GetOrdinal("cinsiyet"));
                uc.lblAdres.Text = oku.GetString(oku.GetOrdinal("adres"));

                uc.Dock = DockStyle.Top;
              //  uc.rbtnSec.Checked = false;
              //  uc.pnlBack.BackColor = Color.WhiteSmoke;
                pnlListe.Controls.Add(uc);
            }
            oku.Close();
            baglan.Close();

            Personel_Bilgileri.m_id = null;
        }

        private void btnEkle_Click(object sender, EventArgs e)//Başka form açarak ekleme işlemi yapılır.
        {
            Personel_Bilgileri.calisanId = null;
            Personel_Detay f = new Personel_Detay();
            f.btnKaydet.Text = "Kaydet";
            f.txtTc.Enabled = true;
            this.Show();
            Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            ans.formGetir(f);
            f.Show();

        }

        private void btnDuzenle_Click(object sender, EventArgs e)//Personel ait tc bilgileri elimizde ise işlem için farlı form açılır. Değilse hata mesajı verilir.
        {
            if (Personel_Bilgileri.calisanId == null)
            {
                this.Alert("İşlem yapmak istediğiniz kaydı seçiniz.", Form_Alert.enmType.Warning);
            }
            else
            {
                Personel_Detay f = new Personel_Detay();
                f.btnKaydet.Text = "Güncelle";
                this.Show();
                Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                ans.formGetir(f);
                f.Show();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)//Personele ait tc verisi elimizde kayıt silinir değilse hata mesajı verilir.
        {
            if (Personel_Bilgileri.calisanId == null)
            {                
                this.Alert("İşlem yapmak istediğiniz kaydı seçiniz.", Form_Alert.enmType.Warning);
            }
            else
            {
                SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
                SqlCommand sil = new SqlCommand("DELETE FROM PersonelTablosu WHERE tc=@tc",baglan);
                sil.Parameters.AddWithValue("@tc",Personel_Bilgileri.calisanId);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();
                this.Alert("İşleminiz başarıyla gerçekleştirildi.", Form_Alert.enmType.Success);
                this.Close();
                personelListesi f = new personelListesi();
                Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                ans.formGetir(f);
                f.Show();
            }
        }
    }
}
