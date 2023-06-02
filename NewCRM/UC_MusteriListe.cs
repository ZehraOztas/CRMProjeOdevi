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
    public partial class UC_MusteriListe : UserControl
    {
        public UC_MusteriListe()
        {
            InitializeComponent();
        }
        private void backcolor()
        {
            if (rbtnSec.Checked == false)
            {
                rbtnSec.Checked = true;
                kart.BackColor = Color.AliceBlue;
                Personel_Bilgileri.m_id = lblid.Text;
            }
            else
            {
                rbtnSec.Checked = false;
                kart.BackColor = Color.WhiteSmoke;
                Personel_Bilgileri.m_id = null;
            }
        }

        private void rbtnSec_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void btnMusteriBilgileriDegisikleri_Click(object sender, EventArgs e)
        {
            backcolor();
            Personel_Bilgileri.m_id = lblid.Text;

            Musteri_Detay f = new Musteri_Detay();
            f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
            MusteriListe pl = (MusteriListe)Application.OpenForms["MusteriListe"];
            pl.Close();
            Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            ans.formGetir(f);
        }

        private void UC_MusteriListe_Load(object sender, EventArgs e)
        {
            
        }
    }
}
