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

        private void EventForm_Load(object sender, EventArgs e)
        {
            //Başlangıçta kişinin dahil olduğu Projeleri listeler.

            string dateString = Takvim.static_month + "/" + UC_Days.static_day + "/" + Takvim.static_year;
            DateTime date;
            if (DateTime.TryParse(dateString, out date))
            {
                // Başarıyla ayrıştırılan tarih
                dtpTarih.Value = date;
            }

            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            SqlCommand listele = new SqlCommand("SELECT proje_adi FROM Musteri WHERE projeyi_yoneten=@y",baglan);
            listele.Parameters.AddWithValue("@y",Personel_Bilgileri.tc);
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

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
        }

        private void cbxProje_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            SqlCommand ekle = new SqlCommand("INSERT INTO TakvimTablosu(tarih,proje_adi,musteri_adi, icerik, kaydeden) VALUES (@tarih,@proje_adi,@musteri_adi, @not,@k)", baglan);
            ekle.Parameters.AddWithValue("@tarih",dtpTarih.Value);
            ekle.Parameters.AddWithValue("@proje_adi", cbxProje.Text);
            ekle.Parameters.AddWithValue("@musteri_adi", txtKisi.Text);
            ekle.Parameters.AddWithValue("@not", txtNot.Text);
            ekle.Parameters.AddWithValue("@k", Personel_Bilgileri.tc);
            baglan.Open();
            ekle.ExecuteNonQuery();
            baglan.Dispose();
            MessageBox.Show("Kaydedildi.");
            UC_Days uc = new UC_Days();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}