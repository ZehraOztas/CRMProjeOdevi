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
    public partial class UC_TakvimBilgi : UserControl
    {
        public UC_TakvimBilgi()
        {
            InitializeComponent();
        }
        private void backcolor()
        {
            if (rbtnSec.Checked == false)
            {
                rbtnSec.Checked = true;
                pnlBack.BackColor = Color.AliceBlue;
                Personel_Bilgileri.takvimId = lblid.Text;
            }
            else
            {
                rbtnSec.Checked = false;
                pnlBack.BackColor = Color.WhiteSmoke;
            }
        }

        private void rbtnSec_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Personel_Bilgileri.takvimId = lblid.Text.ToString();
            EventForm f = new EventForm();
            f.deger = "Güncelle";
            f.btnKaydet.Text = "Güncelle";
            Takvim mbl = (Takvim)Application.OpenForms["Takvim"];
            mbl.Close();
            Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            asd.formGetir(f);
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            backcolor();
        }
    }
}
