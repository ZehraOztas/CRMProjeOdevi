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
            ChatIcerik f = (ChatIcerik)Application.OpenForms["ChatIcerik"];
            Chat form = (Chat)Application.OpenForms["Chat"];
            form.pnlBilgi.Controls.Clear();
            form.pnlBilgi.Controls.Add(f);
           
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            
        }


        private void pnlKisiler_Click(object sender, EventArgs e)
        {
            FormGetir();
}
        private  void pnlKisiler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Kisiler_Click(object sender, EventArgs e)
        {
             
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
            MessageBox.Show("Sayfa açıldı");
        }
    }
}
