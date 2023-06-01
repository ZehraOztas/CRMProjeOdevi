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
    public partial class PersonelinMusterisi : Form
    {
        public PersonelinMusterisi()
        {
            InitializeComponent();
        }

        private void PersonelinMusterisi_Load(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

            SqlCommand command = new SqlCommand("SELECT m_id,ad,soyad, calistigi_yer, pozisyonu, ilk_tarih, durum, proje_adi FROM Musteri WHERE projeyi_yoneten=@y", baglan);
            command.Parameters.AddWithValue("@y", Personel_Bilgileri.calisanId);
            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                UC_PersonelinMusterisi uc = new UC_PersonelinMusterisi();
                uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("m_id")).ToString();
                uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("ilk_tarih")).ToString();
                uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));

                uc.Dock = DockStyle.Top;
                uc.rbtnSec.Checked = false;
                uc.pnlBack.BackColor = Color.WhiteSmoke;
                pnlicerik.Controls.Add(uc);
            }
            oku.Close();
            baglan.Close();
        }

        private void pnlicerik_ControlAdded(object sender, ControlEventArgs e)
        {

        }
    }
}