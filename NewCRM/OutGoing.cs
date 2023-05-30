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
    public partial class OutGoing : UserControl
    {
        public OutGoing()
        {
            InitializeComponent();
        }

       // private string _title;
        public string Tittle 
        { 
            get{ return lbltext.Text; }
            set{ lbltext.Text = value; AdjustHeight();}
        }


        void AdjustHeight()
        {
         
            lbltext.Height = Uilist.GetTextHeight(lbltext)+10;
            buc.Height = lbltext.Top+ buc.Top + lbltext.Height;
            this.Height = buc.Bottom + 10;
        }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
