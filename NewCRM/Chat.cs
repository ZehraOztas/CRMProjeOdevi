using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{
    public partial class Chat : Form
    {
        public bool degis = false;
        public Chat()
        {
            InitializeComponent();
        }



        DataClassesMusteriBilgileriDataContext dcMb = new DataClassesMusteriBilgileriDataContext();
        public bool deger = false;
        //   List<Chat> TIL = new List<Chat>();

        private void PersonelKisi() // Personel tablosundaki kişeri alıp pnlKisiListesi adlı panele ekler.
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            SqlCommand command = new SqlCommand("SELECT ad, soyad, foto ,tc FROM PersonelTablosu", baglan);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();

            while (oku.Read())
            {
                UC_Kisiler uc = new UC_Kisiler();
                uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblid.Text = oku.GetString(oku.GetOrdinal("tc"));
                uc.lbltip.Text = "Çalışan";
                uc.Dock = DockStyle.Top;
                if (uc.lblAdSoyad.Text == Personel_Bilgileri.ad + " " + Personel_Bilgileri.sad)
                {
                    pnlKisiListesi.Controls.Remove(uc);
                }
                else
                {
                    pnlKisiListesi.Controls.Add(uc);
                }
            }

            oku.Close();
            baglan.Close();

        }
    

        private void MusteriKisi()
        {
        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

        SqlCommand command = new SqlCommand("SELECT m_id, ad, soyad, foto FROM Musteri WHERE projeyi_yoneten = @y", baglan);
            command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();

            while (oku.Read())
            {
                UC_Kisiler uc = new UC_Kisiler();
                uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("m_id")).ToString();
                uc.lbltip.Text = "Müşteri";
                uc.Dock = DockStyle.Top;
                if (uc.lblAdSoyad.Text == Personel_Bilgileri.ad+" "+Personel_Bilgileri.sad)
                {
                    pnlKisiListesi.Controls.Remove(uc);
                }
                else
                {
                    pnlKisiListesi.Controls.Add(uc);
                }
            }

            oku.Close();
            baglan.Close();

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //   MessageChat();
        }

        private void Chat_Load(object sender, EventArgs e)
        {
            MusteriKisi();
            PersonelKisi();
        }
    }
}