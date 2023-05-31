using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{
    public partial class Takvim : Form
    {
        int month, year;
       
        public Takvim()
        {
            InitializeComponent();
        }
        
        public static int static_month, static_year, static_day;
        private void displaDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname+" "+year;
            static_month = month;
            static_year = year;
            //Ayın ilk gününü alma
            DateTime startofthemonth = new DateTime(year, month, 1);
            //Ayın gün sayısını alma
            int days = DateTime.DaysInMonth(year, month);
            //startofthemonth int'te çevirme
           int daysofteweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d"))+1;

           for (int i = 1; i < daysofteweek; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UC_Days ucdays = new UC_Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
                //ucdays.displayEvent();
            }

        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            //lear container
            daycontainer.Controls.Clear();
            //sonraki aya gitmek için ayı artırın
            month++;
            static_month = month;
            static_year = year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //Ayın gün sayısını alma
            int days = DateTime.DaysInMonth(year, month);
            //startofthemonth int'te çevirme
            int daysofteweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            for (int i = 0; i < daysofteweek; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UC_Days ucdays = new UC_Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EventForm f = new EventForm();
            this.Close();
            f.deger = "Yeni Kayıt";
            Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            asd.formGetir(f);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Personel_Bilgileri.takvimId == null)
            {
                MessageBox.Show("İlk önce değiştirmek istediğiniz kaydı seçiniz.");
            }
            else
            {
                SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
                SqlCommand sil = new SqlCommand("DELETE FROM TakvimTablosu WHERE id=@id",baglan);
                sil.Parameters.AddWithValue("@id",Personel_Bilgileri.takvimId);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("silindi");
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BackModel backmodel = new BackModel();
            EventForm percikarcard = new EventForm();
            percikarcard.StartPosition = FormStartPosition.CenterScreen;
            backmodel.FormBorderStyle = FormBorderStyle.None;         
            backmodel.Opacity = .50d;
            backmodel.BackColor = Color.Black;
            backmodel.ShowInTaskbar = false;
            backmodel.Show();
            percikarcard.Owner = backmodel;
            percikarcard.ShowDialog();
            backmodel.Dispose();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Personel_Bilgileri.takvimId == null)
            {
                MessageBox.Show("Silmek istediğiniz kişiyi seçiniz.");
            }
            else
            {
                SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
                SqlCommand sil = new SqlCommand("DELETE FROM TakvimTablosu WHERE id=@id", baglan);
                sil.Parameters.AddWithValue("@id", Personel_Bilgileri.takvimId);
                baglan.Open();
                sil.ExecuteNonQuery();
                baglan.Close();
                MessageBox.Show("Kayıt silindi.");
            }
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            //lear container
            daycontainer.Controls.Clear();
            //önceki aya gitmek için ayı azaltalım
            month--;
            static_month = month;
            static_year = year;

            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lblDate.Text = monthname + " " + year;

            DateTime startofthemonth = new DateTime(year, month, 1);
            //Ayın gün sayısını alma
            int days = DateTime.DaysInMonth(year, month);

            //startofthemonth int'te çevirme
            int daysofteweek = Convert.ToInt32(startofthemonth.DayOfWeek.ToString("d")) + 1;


            for (int i = 1; i < daysofteweek; i++)
            {
                UC_Blank ucBlank = new UC_Blank();
                daycontainer.Controls.Add(ucBlank);
            }

            for (int i = 1; i <= days; i++)
            {
                UC_Days ucdays = new UC_Days();
                ucdays.days(i);
                daycontainer.Controls.Add(ucdays);
            }
        }

       
        private void Takvim_Load(object sender, EventArgs e)
        {
            displaDays();
            Personel_Bilgileri.takvimId = null;

            DateTime dt = DateTime.Now;

            Personel_Bilgileri.ay = dt.Month ;
            Personel_Bilgileri.yil = dt.Year;
            Personel_Bilgileri.gun = dt.Day;

            TakvimListe f = new TakvimListe();
            pnlBilgi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            pnlBilgi.Controls.Add(f);
            f.Show();
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

    }
}
