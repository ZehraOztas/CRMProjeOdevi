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
    public partial class UC_Days : UserControl
    {
        public UC_Days()
        {
            InitializeComponent();
        }
        public static string static_day;
        public void days(int numday)
        {
            lblDays.Text = numday+"";
        }

        private void UC_Days_Click(object sender, EventArgs e)
        {
            static_day = lblDays.Text;
            EventForm eventForm = new EventForm();
            eventForm.Show();
        }
    }
}
