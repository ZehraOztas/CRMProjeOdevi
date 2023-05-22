using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewCRM
{
    public partial class Chat : Form
    {
        public bool degis = false;
        public Chat()
        {
            InitializeComponent();
        }

        Resimleme Resimleme = new Resimleme();

        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        DataClassesMusteriBilgileriDataContext dcMb = new DataClassesMusteriBilgileriDataContext();
        public bool deger = false;
        List<Chat> TIL = new List<Chat>();

        /*       public void Yerlestir(Image resim, string isim, int id)
               {
                  Chat chat = new Chat();
                  chat.pbxProfil.Image = resim;
                  chat.lblAd.Text = isim;
                  chat.uC_Kisiler1.Tag = id;
                  TIL.Add(chat);
                  chat.Dock = DockStyle.Top;
                  pnlKisiListesi.Controls.Add(chat);
               }*/
        private void Chat_Load(object sender, EventArgs e)
        {
         
            foreach (var deg in dcMb.Musteri)
            {
                SqlCommand command = new SqlCommand("SELECT m_id,ad, soyad, foto FROM Musteri WHERE projeyi_yoneten=@y ", baglan);
                command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();

                while (oku.Read())
                {
                    UC_Kisiler uc = new UC_Kisiler();
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                    uc.lblid.Text = oku.GetInt32(oku.GetOrdinal("m_id")).ToString();
                    uc.lbltip.Text = "Müşteri";
                    uc.Dock = DockStyle.Top;
                    pnlKisiListesi.Controls.Add(uc);
                }

                oku.Close();
                baglan.Close();
            }

            foreach (var deg in dcMb.PersonelTablosu)
            {
                SqlCommand command = new SqlCommand("SELECT ad, soyad, foto ,tc FROM PersonelTablosu", baglan);
                command.Parameters.AddWithValue("@tc", Personel_Bilgileri.tc);
                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();

                while (oku.Read())
                {
                    UC_Kisiler uc = new UC_Kisiler();
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                    uc.lblid.Text = oku.GetString(oku.GetOrdinal("tc"));
                    uc.lbltip.Text = "Çalışan";
                    uc.Dock = DockStyle.Top;
                    pnlKisiListesi.Controls.Add(uc);
                }

                oku.Close();
                baglan.Close();
            }

        }

          
    /*    public void MessageChat()
        {
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
                            if (Personel_Bilgileri.tc == row["gonderen_tc"].ToString() && lblAd.Text == row["alici_tc"].ToString())

                            {
                                gonderilenMesaj[i] = new OutGoing();
                                gonderilenMesaj[i].Dock = DockStyle.Top;
                                gonderilenMesaj[i].BringToFront();
                                gonderilenMesaj[i].Tittle = row["icerik"].ToString();

                                pnlİcerik.Controls.Add(gonderilenMesaj[i]);
                                pnlİcerik.ScrollControlIntoView(gonderilenMesaj[i]);
                            }
                            else if (lblAd.Text == row["gonderen_tc"].ToString() && Personel_Bilgileri.tc == row["alici_tc"].ToString())
                            {
                                gelenMesaj[i] = new Incomming();
                                gelenMesaj[i].Dock = DockStyle.Bottom;
                                gelenMesaj[i].BringToFront();
                                gelenMesaj[i].Tittle = row["icerik"].ToString();
                                gelenMesaj[i].Icon = pbxProfil.Image;

                                pnlİcerik.Controls.Add(gelenMesaj[i]);
                                pnlİcerik.ScrollControlIntoView(gelenMesaj[i]);
                            }

                        }
                    }
                }
            }
            baglan.Close();
        }*/

        

        private void uC_Kisiler1_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //   MessageChat();
        }



        private void uC_Kisiler1_MouseClick(object sender, MouseEventArgs e)
        {
           /* if (pnlBilgi.Visible == false)
            {
                pnlBilgi.Visible = true;
            }

            UC_Kisiler control = (UC_Kisiler)sender;
            lblAd.Text = control.Title;
            pbxProfil.Image = control.Icon;
            MessageChat();*/
        }

    }
}