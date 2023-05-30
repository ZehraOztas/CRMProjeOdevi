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

        public void Baslangic()
        {
            
            TakvimListe f = new TakvimListe();
            Takvim t = (Takvim)Application.OpenForms["Takvim"];
            t.pnlBilgi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            t.pnlBilgi.Controls.Add(f);
            f.Show();
        }

        private void UC_Days_Click(object sender, EventArgs e)
        {
            Personel_Bilgileri.ay = Takvim.static_month;
            Personel_Bilgileri.yil = Takvim.static_year;
            Personel_Bilgileri.gun = Convert.ToInt32(lblDays.Text);
            Baslangic();
        }

        private void UC_Days_Load(object sender, EventArgs e)
        {

        }

        private void lblDays_Click(object sender, EventArgs e)
        {
            Baslangic();
        }
    }
}