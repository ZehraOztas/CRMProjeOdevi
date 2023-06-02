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
    public partial class UC_Notlar : UserControl
    {
        public UC_Notlar()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        private void pbxDuzenle_Click(object sender, EventArgs e) //Form Geçişi sağlanır.
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

        private void pbxSil_Click(object sender, EventArgs e)//Silme işlemi yapılır.
        {
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

                    MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
                    f.deger = "Güncelle";
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