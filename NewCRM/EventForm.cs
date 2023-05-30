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
    public partial class EventForm : Form
    {
        public EventForm()
        {
            InitializeComponent();
        }

        public string deger;
        private void EventForm_Load(object sender, EventArgs e)
        { 
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            if (deger == "Güncelle")
            {
                SqlCommand yaz = new SqlCommand("SELECT * FROM TakvimTablosu WHERE id=@id", baglan);
                yaz.Parameters.AddWithValue("@id", Personel_Bilgileri.takvimId);
                baglan.Open();
                SqlDataReader okuma = yaz.ExecuteReader();
                while (okuma.Read())
                {
                    lblid.Text = Personel_Bilgileri.takvimId;
                    dtpTarih.Value = okuma.GetDateTime(okuma.GetOrdinal("tarih"));
                    cbxProje.Text = okuma.GetString(okuma.GetOrdinal("proje_adi"));
                    txtKisi.Text = okuma.GetString(okuma.GetOrdinal("musteri_adi"));
                    txtNot.Text = okuma.GetString(okuma.GetOrdinal("icerik"));
                    txtBaslaSaat.Text = okuma.GetString(okuma.GetOrdinal("baslangic_saat"));
                    txtBitSaat.Text = okuma.GetString(okuma.GetOrdinal("bitis_saat"));
                }
                okuma.Close();
                baglan.Close();
            }
            else if (deger == "Yeni Kayıt")
            {
                //Başlangıçta Personelin dahil olduğu Projeleri combobox'a ekler.

                SqlCommand listele = new SqlCommand("SELECT proje_adi FROM Musteri WHERE projeyi_yoneten=@y", baglan);
                listele.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                baglan.Open();
                SqlDataReader oku = listele.ExecuteReader();

                while (oku.Read())
                {
                    string projeAdi = oku["proje_adi"].ToString();
                    cbxProje.Items.Add(projeAdi);
                }
                oku.Close();
                baglan.Close();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void cbxProje_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Seçtiğimiz projeye göre projeyi yöneten kişiyi seçer.
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            SqlCommand listele = new SqlCommand("SELECT ad,soyad FROM Musteri WHERE proje_adi = @p", baglan);
            listele.Parameters.AddWithValue("@p", cbxProje.Text);
            baglan.Open();
            SqlDataReader oku = listele.ExecuteReader();

            while (oku.Read())
            {
                string projeAdi = oku["ad"].ToString()+" " + oku["soyad"].ToString();
                txtKisi.Text = projeAdi;
            }
            oku.Close();
            baglan.Close();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            if (deger == "Yeni Kayıt")
            {

                SqlCommand ekle = new SqlCommand("INSERT INTO TakvimTablosu(tarih,proje_adi,musteri_adi, icerik, kaydeden, baslangic_saat, bitis_saat) VALUES (@tarih,@proje_adi,@musteri_adi, @not,@k, @bas, @bit)", baglan);
                ekle.Parameters.AddWithValue("@tarih", dtpTarih.Value);
                ekle.Parameters.AddWithValue("@proje_adi", cbxProje.Text);
                ekle.Parameters.AddWithValue("@musteri_adi", txtKisi.Text);
                ekle.Parameters.AddWithValue("@not", txtNot.Text);
                ekle.Parameters.AddWithValue("@k", Personel_Bilgileri.tc);
                ekle.Parameters.AddWithValue("@bas", txtBaslaSaat.Text);
                ekle.Parameters.AddWithValue("@bit", txtBitSaat.Text);

                baglan.Open();
                ekle.ExecuteNonQuery();
                baglan.Dispose();
                MessageBox.Show("Kaydedildi.");
                UC_Days uc = new UC_Days();
            }

            else if (deger == "Güncelle")
            {
                SqlCommand ekle = new SqlCommand("UPDATE TakvimTablosu SET tarih=@tarih,proje_adi=@proje_adi,musteri_adi=@musteri_adi, icerik=@not, kaydeden=@k, baslangic_saat=@bas, bitis_saat=@bit WHERE id=@id", baglan);
                ekle.Parameters.AddWithValue("id", lblid.Text);
                ekle.Parameters.AddWithValue("@tarih", dtpTarih.Value);
                ekle.Parameters.AddWithValue("@proje_adi", cbxProje.Text);
                ekle.Parameters.AddWithValue("@musteri_adi", txtKisi.Text);
                ekle.Parameters.AddWithValue("@not", txtNot.Text);
                ekle.Parameters.AddWithValue("@k", Personel_Bilgileri.tc);
                ekle.Parameters.AddWithValue("@bas", txtBaslaSaat.Text);
                ekle.Parameters.AddWithValue("@bit", txtBitSaat.Text);

                baglan.Open();
                ekle.ExecuteNonQuery();
                baglan.Dispose();
                MessageBox.Show("Güncellendi.");
                UC_Days uc = new UC_Days();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Takvim f = new Takvim();
            this.Close();
            Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            asd.formGetir(f);
        }
    }
}