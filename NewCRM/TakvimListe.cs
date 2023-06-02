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
    public partial class TakvimListe : Form
    {
        public TakvimListe()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.enmType type)
        {
            Form_Alert frm = new Form_Alert();
            frm.showAlert(msg, type);
        }
        private void TakvimListe_Load(object sender, EventArgs e)
        {

            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            DateTime dt = Convert.ToDateTime(Personel_Bilgileri.yil + "-"+ Personel_Bilgileri.ay +"-"+ Personel_Bilgileri.gun);

            SqlCommand command = new SqlCommand("SELECT id,proje_adi,musteri_adi,icerik, baslangic_saat, bitis_saat,icerik FROM TakvimTablosu WHERE kaydeden=@y AND tarih=@t ORDER BY baslangic_saat", baglan);
            command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
            command.Parameters.AddWithValue("@t", dt);

            baglan.Open();
            SqlDataReader oku = command.ExecuteReader();
            while (oku.Read())
            {
                UC_TakvimBilgi uc = new UC_TakvimBilgi();
                uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("id")).ToString();
                uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("musteri_adi"));
                uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                uc.lblNot.Text = oku.GetString(oku.GetOrdinal("icerik"));
                uc.lblbasla.Text = oku.GetString(oku.GetOrdinal("baslangic_saat"));
                uc.lblBitis.Text = oku.GetString(oku.GetOrdinal("bitis_saat"));

                uc.Dock = DockStyle.Top;
                panel1.Controls.Add(uc);
            }
            oku.Close();
            baglan.Close();
        }
    }
}