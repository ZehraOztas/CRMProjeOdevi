using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public static int static_month, static_year;
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
            }

        }

        private void Takvim_Load(object sender, EventArgs e)
        {
            displaDays();
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
            }
        }

        private void lblDate_Click(object sender, EventArgs e)
        {

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
    }
}
