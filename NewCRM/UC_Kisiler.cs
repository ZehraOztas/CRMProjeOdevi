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

        private void pnlKisiler_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.pnlMesaj.Visible = true;
            chat.pnlİcerik.Visible = true;
            chat.pnlTittle.Visible = true;
        }

        private void pnlKisiler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_Kisiler_Click(object sender, EventArgs e)
        {
            Chat chat = new Chat();
            chat.pnlMesaj.Visible = true;
            chat.pnlİcerik.Visible = true;
            chat.pnlTittle.Visible = true;
        }
    }
}
