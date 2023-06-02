using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewCRM
{
    public partial class MusteriBilgileri : Form
    {
        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        DataClassesMusteriBilgileriDataContext dcMb = new DataClassesMusteriBilgileriDataContext();
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void filtre(string durum) //Burada filtreleme işlemi yapıyoruz. Combobox'in index numarasına göre aldığımız duruma göre listeleme işlemi yapıyoruz.
        {
            pnlMusteriBilgileri.Controls.Clear();

            SqlCommand command = new SqlCommand("SELECT ad,soyad,ep,tel,calistigi_yer, pozisyonu, son_tarih, durum, proje_adi FROM Musteri WHERE durum = @d AND projeyi_yoneten=@y ORDER BY son_tarih desc", baglan);
            command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
            command.Parameters.AddWithValue("@d", durum);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                UC_MusteriBilgileri uc = new UC_MusteriBilgileri(); // kontrol nesnesi oluşturulur
                uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                uc.Dock = DockStyle.Top;
                uc.rbtnSec.Checked = false;
                uc.pnlBack.BackColor = Color.WhiteSmoke;
                pnlMusteriBilgileri.Controls.Add(uc);
            }
            oku.Close();
            baglan.Close();
        }

        private void listele() //Form açıldığı zaman yapılacak listeleme
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            pnlMusteriBilgileri.Controls.Clear();

            SqlCommand command = new SqlCommand("SELECT m_id,ad,soyad,ep,tel,calistigi_yer, pozisyonu, son_tarih, durum, proje_adi FROM Musteri WHERE projeyi_yoneten=@y ORDER BY son_tarih desc", baglan);
            command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                UC_MusteriBilgileri uc = new UC_MusteriBilgileri();
                uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("m_id")).ToString();
                uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));

                uc.Dock = DockStyle.Top;
                uc.rbtnSec.Checked = false;
                uc.pnlBack.BackColor = Color.WhiteSmoke;
                pnlMusteriBilgileri.Controls.Add(uc);
            }
            oku.Close();
            baglan.Close();

            Personel_Bilgileri.m_id = null;
        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            listele();
        }


        private void txtAra_TextChanged(object sender, EventArgs e)//Textbox'a yazdıklarımıza göre arama yapması için 
        {

            pnlMusteriBilgileri.Controls.Clear();
            if (txtAra.Text == " " || txtAra.Text == "")
            {
                listele();
            }
            else
            {
                SqlCommand ara = new SqlCommand("SELECT ad,soyad,ep,tel,calistigi_yer, pozisyonu, ilk_tarih, son_tarih, durum, proje_adi FROM Musteri WHERE (ad LIKE @ad+'%' or soyad LIKE @sad+'%' or calistigi_yer LIKE '%'+@cyer+'%')and(projeyi_yoneten=@y)", baglan);
                ara.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                ara.Parameters.AddWithValue("@ad", txtAra.Text);
                ara.Parameters.AddWithValue("@sad", txtAra.Text);
                ara.Parameters.AddWithValue("@cyer", txtAra.Text);
                baglan.Open();
                SqlDataReader oku = ara.ExecuteReader();
                while (oku.Read())
                {
                    UC_MusteriBilgileri uc = new UC_MusteriBilgileri();
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                    uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                    uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                    uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                    uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                    uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                    uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                    uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    uc.rbtnSec.Checked = false;
                    uc.pnlBack.BackColor = Color.WhiteSmoke;
                    pnlMusteriBilgileri.Controls.Add(uc);
                }
                baglan.Close();
            }
        }

        private void cbxFiltre_SelectedIndexChanged(object sender, EventArgs e)//Burada combobox'ın index numarasıdaki yazıyı alıp filtre adındaki fonksiyona gönderiyor ve durum tipine göre listeleme işlemi yapılıyor.
        {
            string durum;
            

            switch (cbxFiltre.SelectedIndex)
            {
                case 0:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 1:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 2:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 3:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 4:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 5:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 6:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 7:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;

                case 8:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;

                case 9:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
            }
        }


        private void btnEkle_Click(object sender, EventArgs e)//Yeni bir kayıt için formu açar
        {
            Personel_Bilgileri.m_id = null;
            MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
            f.btnMusteriBilgileriDegisikleri.Text = "Kaydet";
            f.pnlMusteriBilgi.Enabled = true;
            f.deger = "Yeni Kayıt";
            MusteriBilgileri mbl = (MusteriBilgileri)Application.OpenForms["MusteriBilgileri"];
            mbl.Close();
            Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            asd.formGetir(f);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)//Kayıt güncelleme işlemi yapmakiçin yeni bir form açar.
        {
            if (Personel_Bilgileri.m_id == null)
            {
                this.Alert("Bilgilerini değiştirmek istediğiniz kişiyi seçiniz.", Form_Alert.enmType.Warning);
            }
            else
            {
                MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
                f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
                f.deger = "Güncelle";
                MusteriBilgileri mbl = (MusteriBilgileri)Application.OpenForms["MusteriBilgileri"];
                mbl.Close();
                Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                asd.formGetir(f);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)//Silme işlemi gerçekleştirilir.
        {
            if (Personel_Bilgileri.m_id == null)
            {
                this.Alert("Bilgilerini değiştirmek istediğiniz kişiyi seçiniz.", Form_Alert.enmType.Warning);
            }
            else
            {
                SqlCommand sil = new SqlCommand("DELETE From Musteri Where m_id=@id", baglan);
                sil.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();
            }
        }
    }
}

