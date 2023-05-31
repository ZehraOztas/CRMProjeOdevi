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
           
        }

        private void lblid_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void rbtnSec_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pbxAd_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void pnlBack_Click(object sender, EventArgs e)
        {
            backcolor();
        }

        private void btnDuzenle_Click_1(object sender, EventArgs e)
        {
            backcolor();

            Personel_Bilgileri.takvimId = lblid.Text.ToString();

            BackModel backmodel = new BackModel();
            EventForm percikarcard = new EventForm();
            percikarcard.deger = "Güncelle";
            percikarcard.btnKaydet.Text = "Güncelle";

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
    }
}
