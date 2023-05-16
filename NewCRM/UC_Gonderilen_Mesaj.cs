using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{
    public partial class UC_Gonderilen_Mesaj : UserControl
    {
        public UC_Gonderilen_Mesaj()
        {
            InitializeComponent();
        }

        private string title;
        public string Title
        { get { return title; } 
          set {  title = value; lblMetin.Text = value; AddHeighttext(); } 
        }

        
       void AddHeighttext()
        {
            UC_Gonderilen_Mesaj user = new UC_Gonderilen_Mesaj();
            user.BringToFront();
            lblMetin.Height = Uilist.GetTextHeight(lblMetin)+10;
            user.Height = lblMetin.Top + lblMetin.Height;
            this.Height = user.Bottom + 10;
        }

        private void UC_Gonderilen_Mesaj_Load(object sender, EventArgs e)
        {
            AddHeighttext();
        }
    }
}
