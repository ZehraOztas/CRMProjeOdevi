using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{
    public partial class Chat_Icerik : Form
    {
        public Chat_Icerik()
        {
            InitializeComponent();
        }

        
        DataClassesMusteriBilgileriDataContext dcMb = new DataClassesMusteriBilgileriDataContext();

        public void MessageChat()
        {
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
            baglan.Open();
            SqlCommand kmt = new SqlCommand("SELECT * From ChatTablosu WHERE alici_tc=@a OR gonderen_tc=@g", baglan);
            kmt.Parameters.AddWithValue("@a", Personel_Bilgileri.tc);
            kmt.Parameters.AddWithValue("@g", Personel_Bilgileri.tc);
           SqlDataAdapter da = new SqlDataAdapter(kmt);
            DataTable table = new DataTable();
            da.Fill(table);

            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    OutGoing[] gonderilenMesaj = new OutGoing[table.Rows.Count];
                    Incomming[] gelenMesaj = new Incomming[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (Personel_Bilgileri.tc == row["alici_tc"].ToString() && Personel_Bilgileri.m_id == row["gonderen_tc"].ToString())
                            {
                                gelenMesaj[i] = new Incomming();
                                gelenMesaj[i].Dock = DockStyle.Bottom;
                                gelenMesaj[i].BringToFront();
                                gelenMesaj[i].Tittle = row["icerik"].ToString();
                                gelenMesaj[i].Icon = pbxProfil.Image;

                                pnlİcerik.Controls.Add(gelenMesaj[i]);
                                pnlİcerik.ScrollControlIntoView(gelenMesaj[i]);
                            }
                            else if (Personel_Bilgileri.tc == row["gonderen_tc"].ToString() && Personel_Bilgileri.m_id == row["alici_tc"].ToString())
                            {
                                gonderilenMesaj[i] = new OutGoing();
                                gonderilenMesaj[i].Dock = DockStyle.Bottom;
                                gonderilenMesaj[i].BringToFront();
                                gonderilenMesaj[i].Tittle = row["icerik"].ToString();

                                pnlİcerik.Controls.Add(gonderilenMesaj[i]);
                                pnlİcerik.ScrollControlIntoView(gonderilenMesaj[i]);//Kaydırma çubuğunu ayarlar.
                            }

                        }
                    }
                }
            }

            baglan.Close();
        }

        private void pbxGonder_Click(object sender, EventArgs e)
        {
            DateTime suankizaman = DateTime.Now;
            SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
           
            SqlCommand cmd = new SqlCommand("INSERT INTO ChatTablosu(gonderen_tc,alici_tc,gonderilen_tarih, gonderilen_yer, icerik)VALUES(@g_tc, @atc, @gdate, @gyer, @icerik)", baglan);
            cmd.Parameters.AddWithValue("@g_tc", Personel_Bilgileri.tc);
            cmd.Parameters.AddWithValue("@atc", Personel_Bilgileri.m_id);
            cmd.Parameters.AddWithValue("@gdate", suankizaman);
            cmd.Parameters.AddWithValue("@gyer", "Chat Uygulaması");
            cmd.Parameters.AddWithValue("@icerik", txtIcerik.Text);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();
            txtIcerik.Clear();
            MessageChat();
        }

        private void Chat_Icerik_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (10 * 10000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
            MessageChat();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MessageChat();
        }

    }
}