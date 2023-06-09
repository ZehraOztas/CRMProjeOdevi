﻿using System;
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
    public partial class UC_PersonelinMusterisi : UserControl
    {
        public UC_PersonelinMusterisi()
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
                Personel_Bilgileri.m_id = null;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            backcolor();
            Personel_Bilgileri.m_id = lblid.Text;
            Musteri_Detay f = new Musteri_Detay();
            PersonelinMusterisi pm = (PersonelinMusterisi)Application.OpenForms["PersonelinMusterisi"];
            pm.Close();
            Ana_Sayfa ans = (Ana_Sayfa)Application.OpenForms["Ana_Sayfa"];
            ans.formGetir(f);
        }
    }
}