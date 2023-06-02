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
    public partial class UC_MusteriNotlar : UserControl
    {
        public UC_MusteriNotlar()
        {
            InitializeComponent();
        }
        private void backcolor()
        {
            if (rbtnSec.Checked == false)
            {
                rbtnSec.Checked = true;
                pnlBack.BackColor = Color.AliceBlue;
                Personel_Bilgileri.nid = lblnid.Text;
            }
            else
            {
                rbtnSec.Checked = false;
                pnlBack.BackColor = Color.WhiteSmoke;
                Personel_Bilgileri.nid = null;
            }
        }

        private void pbxDuzenle_Click(object sender, EventArgs e)
        {

        }

        private void pbxDuzenle_Click_1(object sender, EventArgs e)
        {
            BackModel backmodel = new BackModel();
            NotlarForm percikarcard = new NotlarForm();
            percikarcard.tip = "Güncelle";
            percikarcard.btnKaydet.Text = "Güncelle";
            Personel_Bilgileri.nid = lblnid.Text;
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

        private void pbxSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            try
            {
                DialogResult cevap = MessageBox.Show("Bu notu silmek istiyor musunuz?", "Çıkış Yap", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (cevap == DialogResult.OK)
                {
                    SqlCommand sil = new SqlCommand("DELETE FROM Notlar WHERE n_id=@id", baglan);
                    sil.Parameters.AddWithValue("@id", lblnid.Text);
                    baglan.Open();
                    sil.ExecuteNonQuery();
                    baglan.Close();

                    Musteri_Detay f = new Musteri_Detay();
                    f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
                    Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
                    asd.formGetir(f);
                }
            }
            catch
            {
                MessageBox.Show("Daha sonra tekrar deneyiniz.");
            }
        }
    }
}
