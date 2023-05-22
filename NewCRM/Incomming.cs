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
    public partial class Incomming : UserControl
    {
        public Incomming()
        {
            InitializeComponent();
        }

        public string Tittle
        { 
            get
            {
                return lblmesaj.Text;
            }
            set
            {
                lblmesaj.Text = value;
                AddHeightText();
            }
        }

        private Image _icon;
        public Image Icon 
        { 
            get{ return _icon;}
            set { _icon = value; pbxProfil.Image = value; AddHeightText(); }
        }

        void AddHeightText()
        {
            pbxProfil.Location = new Point(4, 3);
            lblmesaj.Height = Uilist.GetTextHeight(lblmesaj)+10;
            buc.Height = lblmesaj.Top + buc.Top + lblmesaj.Height;
            this.Height = buc.Bottom + 10;
        }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AddHeightText();
        }

        private void Incomming_Load(object sender, EventArgs e)
        {
            AddHeightText();
        }
    }
}
