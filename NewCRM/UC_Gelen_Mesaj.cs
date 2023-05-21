using System;
using System.CodeDom;
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
    public partial class UC_Gelen_Mesaj : UserControl
    {
        public UC_Gelen_Mesaj()
        {
            InitializeComponent();
        }

        private string title;
        public string Title
        {
            get { return title; }
            set { title = value; //lblMesaj.Text = value;
                                 }
        }

        private Image icon;
        public Image Icon
        {
            get { return icon; }
            set { icon = value; pbxFoto.Image = value; AddHeighttext(); }
        }

        void AddHeighttext()
        {
            UC_Gelen_Mesaj user = new UC_Gelen_Mesaj();
            user.BringToFront();
         //   lblMesaj.Height = Uilist.GetTextHeight(lblMesaj) + 10;
       //     user.Height = lblMesaj.Top + lblMesaj.Height;
            this.Height = user.Bottom + 10;
        }

        private void UC_Gelen_Mesaj_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
