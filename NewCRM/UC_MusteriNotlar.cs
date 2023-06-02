using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        }
    }
}
