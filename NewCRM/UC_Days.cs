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
    public partial class UC_Days : UserControl
    {
        public UC_Days()
        {
            InitializeComponent();
        }

        public static string static_day;
        DataClassesMusteriBilgileriDataContext dcMb = new DataClassesMusteriBilgileriDataContext();

        public void days(int numday)
        {
            lblDays.Text = numday + "";
        }

        private void UC_Days_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;

            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            Takvim takvim = new Takvim();
            takvim.pnlBilgi.Controls.Clear();
            foreach (var deg in dcMb.Musteri)
            {
                SqlCommand command = new SqlCommand("SELECT id,proje_adi,musteri_adi,icerik, baslangic_saat, bitis_saat,icerik FROM TakvimTablosu WHERE kaydeden=@y and tarih=@t ORDER BY son_tarih desc", baglan);
                command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                command.Parameters.AddWithValue("@t", Takvim.static_year+"-"+Takvim.static_month+"-"+static_day);

                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();
                while (oku.Read())
                {
                    UC_MusteriBilgileri uc = new UC_MusteriBilgileri();
                    uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("id")).ToString();
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("musteri_adi"));
                    uc.lblEp.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    uc.lblTel.Text = oku.GetString(oku.GetOrdinal("icerik"));
                    uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("baslangic_saat"));
                    uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("bitis_saat"));

                    uc.Dock = DockStyle.Top;
                    uc.rbtnSec.Checked = false;
                    uc.pnlBack.BackColor = Color.WhiteSmoke;
                    takvim.pnlBilgi.Controls.Add(uc);
                }
                oku.Close();
                baglan.Close();
            }
        }

       public void displayEvent()
        {
            DateTime dt = Convert.ToDateTime(Takvim.static_year + "-" + Takvim.static_month + "-" + Takvim.static_day);
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            baglan.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TakvimTablosu WHERE tarih=@tarih and kaydeden=@k", baglan);
            cmd.Parameters.AddWithValue("@tarih",dt);
            cmd.Parameters.AddWithValue("@k", Personel_Bilgileri.tc);
            SqlDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
            //    lblevent.Text = "\n" + oku["proje_adi"].ToString();
            }
            oku.Close();
            baglan.Close();

        }


        private void timer1_Tick(object sender, EventArgs e)
        {
     //       displayEvent();
        }

        private void UC_Days_Load(object sender, EventArgs e)
        {
     //       displayEvent();
        }

        private void lblevent_Click(object sender, EventArgs e)
        {
           
        }
    }
}