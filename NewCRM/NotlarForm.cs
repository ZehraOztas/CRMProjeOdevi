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
        DataClassesMusteriBilgileriDataContext dc = new DataClassesMusteriBilgileriDataContext();
        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");


        public string tip = "";
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
        private void Notlar_Load(object sender, EventArgs e)//Form güncelleme işlemi için açılırsa yapılacak işlemler
        {
            lblnid.Text = Personel_Bilgileri.m_id;
            list();

            if (tip == "Guncelle")
            {
                SqlCommand guncelle = new SqlCommand("SELECT n.n_id,n.eklenen_tarih, n.icerik, m.proje_adi FROM Notlar n JOIN Musteri m ON n.musteri_id = m.m_id WHERE n.n_id=@nid", baglan);
                guncelle.Parameters.AddWithValue("@nid", lblnid.Text);
                SqlDataReader oku = guncelle.ExecuteReader();
                baglan.Open();
                if (oku.Read())
                {
                    txticerik.Text = oku.GetString(oku.GetOrdinal("icerik"));
                    cbxListe.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    dtpTarih.Value = oku.GetDateTime(oku.GetOrdinal("eklenen_tarih"));
                    lblnid.Text = oku.GetString(oku.GetOrdinal("n_id"));

                }
                oku.Close();
                baglan.Close();
            }
            else
            {
                lblnid.Text = "Yeni kayıt";
            }
        }

        private void pbxSil_Click(object sender, EventArgs e)//Silme işlemi yapıyor ve ardından farklı form açıyor.
        {
            DialogResult cevap = MessageBox.Show("Bu notu silmek istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (cevap == DialogResult.OK)
            {
                SqlCommand sil = new SqlCommand("DELETE FROM Notlar WHERE n_id=@id", baglan);
                sil.Parameters.AddWithValue("@id", lblnid.Text);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();

                MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
                f.deger = "Guncelle";
                NotlarForm mbl = (NotlarForm)Application.OpenForms["Notlar"];
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

        private void btnKaydet_Click(object sender, EventArgs e)//Yapmak istenilen işlem türünü gerçekleştiriyor.
        {
            DateTime now = DateTime.Now;
          
            if (tip == "Yeni Kayıt")
            {
                SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
                SqlCommand ekle = new SqlCommand("INSERT INTO Notlar (ekleyen_tc,icerik,musteri_id,eklenen_tarih,proje_adi)VALUES(@ekleyen_tc,@icerik,@musteri_id,@eklenen_tarih,@proje_adi)", baglanti);
                baglanti.Open();
                ekle.Parameters.AddWithValue("@ekleyen_tc", Personel_Bilgileri.tc);
                ekle.Parameters.AddWithValue("@icerik", txticerik.Text);
                ekle.Parameters.AddWithValue("@musteri_id", Personel_Bilgileri.m_id);
                ekle.Parameters.AddWithValue("@eklenen_tarih", now);
                ekle.Parameters.AddWithValue("@proje_adi", cbxListe.Text);
               
                ekle.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kaydedildi");
            }
            else if (tip == "Güncelle")
            {
                SqlCommand guncelle = new SqlCommand("UPDATE MUSTERI SET icerik=@icerik,eklenen_tarih=@eklenen_tarih WHERE n_id=@id", baglan);
                guncelle.Parameters.AddWithValue("@id",lblnid.Text);
                guncelle.Parameters.AddWithValue("@icerik", txticerik.Text);
                guncelle.Parameters.AddWithValue("@eklenen_tarih", now);
                baglan.Open();
                guncelle.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt güncellendi");
            }
        }
    }
}