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
    public partial class UC_PersonelListesi : UserControl
    {
        public UC_PersonelListesi()
        {
            InitializeComponent();
        }
        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void backcolor()
        {
            if (rbtnSec.Checked == false)
            {
                rbtnSec.Checked = true;
                kart.BackColor = Color.AliceBlue;
                Personel_Bilgileri.calisanId = lblid.Text;
            }
            else
            {
                rbtnSec.Checked = false;
                kart.BackColor = Color.WhiteSmoke;
                Personel_Bilgileri.calisanId = null;
            }
        }

            private void btnMusteriBilgileriDegisikleri_Click(object sender, EventArgs e)
        {
            backcolor();
            Personel f = new Personel();
            Personel_Bilgileri.calisanId = lblid.Text;
            personelListesi pl = (personelListesi)Application.OpenForms["personelListesi"];
            pl.Close();
            Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            ans.formGetir(f);
        }

        private void bunifuCards1_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void btnMusteriBilgileriDegisikleri_Click_1(object sender, EventArgs e)
        {
            backcolor();
            Personel_Bilgileri.calisanId = lblid.Text;

            Personel_Detay f = new Personel_Detay();
            
            Personel_Bilgileri.calisanId = lblid.Text;
            personelListesi pl = (personelListesi)Application.OpenForms["personelListesi"];
            pl.Close();
            Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            ans.formGetir(f);
        }
    }
}