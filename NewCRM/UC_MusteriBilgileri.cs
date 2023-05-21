using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{

    public partial class UC_MusteriBilgileri : UserControl
    {
        public UC_MusteriBilgileri()
        {
            InitializeComponent();
        }

    
            private void backcolor()
        {
            if (rbtnSec.Checked == false)
            {
                rbtnSec.Checked = true;
                pnlBack.BackColor = Color.AliceBlue;
                Personel_Bilgileri.m_id = lblid.Text;
            }
            else
            {
                rbtnSec.Checked = false;
                pnlBack.BackColor = Color.WhiteSmoke;
            }
        }
       

        private void lblPrjAdi_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblDurum_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblPozisyon_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblCalistigiYer_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblEp_Click(object sender, EventArgs e)
        {
            backcolor();
        }


        private void lblTel_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void btnDüzenle_Click(object sender, EventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            backcolor();

            Personel_Bilgileri.m_id = lblid.Text.ToString();
            MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
            f.pnlMusteriBilgi.Enabled = true;
            f.deger = "Güncelle";
            f.btnMusteriBilgileriDegisikleri.Text = "Güncelle";
            MusteriBilgileri mbl = (MusteriBilgileri)Application.OpenForms["MusteriBilgileri"];
            mbl.Close();
            Ana_Sayfa asd = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            asd.formGetir(f);

        }

        private void rbtnSec_Click(object sender, EventArgs e)
        {
            backcolor();
        }
        private void pnlBack_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxAd_Click(object sender, EventArgs e)
        {
          backcolor();
        }
        

        private void lblAdSoyad_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxEp_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblEp_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxCyer_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblCalistigiYer_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxPozisyon_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblPozisyon_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxTarih_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void dtpSontarih_ValueChanged(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxPrjAd_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblPrjAdi_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxdurum_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblDurum_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblTel_Click_1(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxTel_Click(object sender, EventArgs e)
        {
            backcolor();
        }
    }
}
