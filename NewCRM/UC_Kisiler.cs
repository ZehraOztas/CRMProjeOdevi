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
    public partial class UC_Kisiler : UserControl
    {
        public UC_Kisiler()
        {
            InitializeComponent();
        }
        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; lblAdSoyad.Text = value; }
        }

        private Image icon;
        public Image Icon
        {
            get { return icon; }
            set { icon = value; pbxKisiFoto.Image = value; }
        }


        private void FormGetir()
        {
            Chat_Icerik f = new Chat_Icerik();
            Chat chat = (Chat)Application.OpenForms["Chat"];
            chat.pnlBilgi.Controls.Clear();
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            chat.pnlBilgi.Controls.Add(f);
            f.lblAd.Text = lblAdSoyad.Text;
            f.pbxProfil.Image = icon;
            Personel_Bilgileri.m_id = lblid.Text;
            Personel_Bilgileri.chatid = "";
            f.Show();
        }
        private void pnlKisiler_Click(object sender, EventArgs e)
        {
            FormGetir();
        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {
            FormGetir();
        }

        private void pbxKisiFoto_Click(object sender, EventArgs e)
        {
            FormGetir();
        }

        private void UC_Kisiler_Click_1(object sender, EventArgs e)
        {
            FormGetir();
        }
    }
}