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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace NewCRM
{
    public partial class NotlarForm : Form
    {

        public NotlarForm()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }

        public string tip;

        private void list()//Seçtiğimiz kişinin id numarasını alarak o kişi ile yaptığımız Projeleri combobox'ın içerisine ekliyor.
        {
            using (baglan)
            {
                baglan.Open();

                using (SqlCommand command = new SqlCommand("SELECT proje_adi FROM Musteri WHERE m_id = @id", baglan))
                {
                    command.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbxListe.Items.Add(reader["proje_adi"].ToString());
                        }
                    }
                }
            }
            baglan.Close();

        }

        DataClassesMusteriBilgileriDataContext dc = new DataClassesMusteriBilgileriDataContext();
        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        private void Notlar_Load(object sender, EventArgs e)//Form güncelleme işlemi için açılırsa yapılacak işlemler
        {
            lblnid.Text = Personel_Bilgileri.nid;
            list();

            SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            if (btnKaydet.Text == "Güncelle")
            {
                SqlCommand guncelle = new SqlCommand("SELECT n_id,eklenen_tarih, icerik, proje_adi FROM Notlar WHERE n_id=@nid", baglanti);
                guncelle.Parameters.AddWithValue("@nid",Personel_Bilgileri.nid);
                baglanti.Open();
                SqlDataReader oku = guncelle.ExecuteReader();

                if (oku.Read())
                {
                    txticerik.Text = oku.GetString(oku.GetOrdinal("icerik"));
                    cbxListe.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    dtpTarih.Value = oku.GetDateTime(oku.GetOrdinal("eklenen_tarih"));
                    lblnid.Text = oku.GetInt32(oku.GetOrdinal("n_id")).ToString() ;
                }
                oku.Close();
                baglanti.Close();
            }       
            
        }

        private void pbxSil_Click(object sender, EventArgs e)//Silme işlemi yapıyor ve ardından farklı form açıyor.
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            DialogResult cevap = MessageBox.Show("Bu notu silmek istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                SqlCommand sil = new SqlCommand("DELETE FROM Notlar WHERE n_id=@id", baglan);
                sil.Parameters.AddWithValue("@id", Convert.ToInt32(Personel_Bilgileri.nid).ToString());
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();

                MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
                f.deger = "Guncelle";
                f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
                NotlarForm mbl = (NotlarForm)Application.OpenForms["NotlarForm"];
                mbl.Close();
                Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                asd.formGetir(f);
            }
        }
        private void pbxCikis_Click(object sender, EventArgs e)//Sayfayı kapatıp farklı sekme açıyor
        {
            MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
            f.deger = "Guncelle";
            f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
            NotlarForm mbl = (NotlarForm)Application.OpenForms["NotlarForm"];
            mbl.Close();
            Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            asd.formGetir(f);
        }

        private void btnKaydet_Click(object sender, EventArgs e)//Kaydetme veya güncelleme işleminden yapmak istenilen işlem türünü gerçekleştiriyor.
        {
            DateTime now = DateTime.Now;
            SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            if (tip == "Yeni Kayıt")
            {
                
                SqlCommand ekle = new SqlCommand("INSERT INTO Notlar (ekleyen_tc,icerik,musteri_id,eklenen_tarih,proje_adi)VALUES(@ekleyen_tc,@icerik,@musteri_id,@eklenen_tarih,@proje_adi)", baglanti);
                baglanti.Open();
                ekle.Parameters.AddWithValue("@ekleyen_tc", Personel_Bilgileri.tc);
                ekle.Parameters.AddWithValue("@icerik", txticerik.Text);
                ekle.Parameters.AddWithValue("@musteri_id", Personel_Bilgileri.m_id);
                ekle.Parameters.AddWithValue("@eklenen_tarih", now);
                ekle.Parameters.AddWithValue("@proje_adi", cbxListe.Text);

                ekle.ExecuteNonQuery();
                baglanti.Close(); 
                this.Alert("İşleminiz başarıyla gerçekleştirildi.", Form_Alert.enmType.Success);
            }
            else if (tip == "Güncelle")
            {
                SqlCommand guncelle = new SqlCommand("UPDATE Notlar SET icerik=@icerik,eklenen_tarih=@eklenen_tarih WHERE n_id=@id", baglanti);
                guncelle.Parameters.AddWithValue("@id", lblnid.Text);
                guncelle.Parameters.AddWithValue("@icerik", txticerik.Text);
                guncelle.Parameters.AddWithValue("@eklenen_tarih", now);
                baglanti.Open();
                guncelle.ExecuteNonQuery();
                baglanti.Close();
                this.Alert("İşleminiz başarıyla gerçekleştirildi.", Form_Alert.enmType.Success);

            }
        }
    }
}