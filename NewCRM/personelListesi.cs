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
    public partial class personelListesi : Form
    {
        public personelListesi()
        {
            InitializeComponent();
        }

        private void personelListesi_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            pnlListe.Controls.Clear();

            SqlCommand command = new SqlCommand("SELECT tc,ad, soyad,pozisyonu,ise_giris_tarihi ,cinsiyet,dogum_tarihi,ep1,tel1, adres,il, ilce FROM PersonelTablosu ORDER BY ise_giris_tarihi asc", baglan);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                UC_PersonelListesi uc = new UC_PersonelListesi();
                uc.lblid.Text = oku.GetString(oku.GetOrdinal("tc")).ToString();
                uc.lblAd.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep1"));
                uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel1"));
                uc.lblPozisyonu.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                uc.lblDt.Text = oku.GetDateTime(oku.GetOrdinal("dogum_tarihi")).ToString();
                uc.lbliseBasTrh.Text = oku.GetDateTime(oku.GetOrdinal("ise_giris_tarihi")).ToString();
                uc.lblCinsiyet.Text = oku.GetString(oku.GetOrdinal("cinsiyet"));
                uc.lblAdres.Text = oku.GetString(oku.GetOrdinal("adres"));

                uc.Dock = DockStyle.Top;
              //  uc.rbtnSec.Checked = false;
              //  uc.pnlBack.BackColor = Color.WhiteSmoke;
                pnlListe.Controls.Add(uc);
            }
            oku.Close();
            baglan.Close();

            Personel_Bilgileri.m_id = null;
        }
    }
}
