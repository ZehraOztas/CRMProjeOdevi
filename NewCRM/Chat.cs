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

        List<Chat> TIL = new List<Chat>();

        private void UserItem()
        {
            pnlKisiListesi.Controls.Clear();
            SqlCommand command = new SqlCommand("SELECT ad, soyad, foto FROM Musteri WHERE projeyi_yoneten=@y UNION ALL SELECT ad, soyad, foto FROM PersonelTablosu Where tc!= @tc", baglan);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
            command.Parameters.AddWithValue("@tc", Personel_Bilgileri.tc);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    UC_Kisiler[] userControls = new UC_Kisiler[dt.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            userControls[i] = new UC_Kisiler();
                         //   MemoryStream stream = new MemoryStream((byte[])row["foto"]);
                         //   userControls[i].Icon = new Bitmap(stream);
                            userControls[i].Title = row["ad"].ToString()+" "+ row["soyad"];

                            if (userControls[i].Title == Personel_Bilgileri.ad+" "+Personel_Bilgileri.sad)
                            {
                                pnlKisiListesi.Controls.Remove(userControls[i]);
                            }
                            else
                            {
                                pnlKisiListesi.Controls.Add(userControls[i]);
                                userControls[i].Dock = DockStyle.Top;
                            }
                         userControls[i].Click += new System.EventHandler(this.uC_Kisiler1_Click);
                        }
                    }
                }
            }
        }
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
            pnlİcerik.Visible = false;
            pnlTittle.Visible = false;
            pnlMesaj.Visible = false;
            /* foreach (var deg in dcMb.Musteri)
             {
                         Yerlestir(Resimleme.ResimGetirme(deg.foto.ToArray()), deg.ad + " " + deg.soyad, deg.m_id);
             }*/
            UserItem();
            Timer timer = new Timer();
            timer.Interval = 10 * 1000;
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();

            /*  pnlKisiListesi.Controls.Clear();
            foreach (var deg in dcMb.Musteri)
            {
                SqlCommand command = new SqlCommand("SELECT ad, soyad, foto FROM Musteri WHERE projeyi_yoneten=@y UNION ALL SELECT ad, soyad, foto FROM PersonelTablosu Where tc!= @tc", baglan);
                command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                command.Parameters.AddWithValue("@tc", Personel_Bilgileri.tc);
                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();

                while (oku.Read())
                {
                    UC_Kisiler uc = new UC_Kisiler();
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));

                   
                    }
                    uc.Dock = DockStyle.Top;
                    pnlKisiListesi.Controls.Add(uc);
                }

                oku.Close();
                baglan.Close();
            }*/
        }

        private void pbxGonder_Click(object sender, EventArgs e)
        {
            DateTime suankizaman = DateTime.Now;
            pnlChat.Controls.Clear();

            SqlCommand cmd = new SqlCommand("INSERT INTO ChatTablosu(gonderen_tc,alici_tc,gonderilen_tarih, gonderilen_yer, icerik)VALUES(@g_tc, @atc, @gdate, @gyer, @icerik)", baglan);
            cmd.Parameters.AddWithValue("@g_tc",Personel_Bilgileri.tc);
            cmd.Parameters.AddWithValue("@atc", lblAd.Text);
            cmd.Parameters.AddWithValue("@gdate", suankizaman);
            cmd.Parameters.AddWithValue("@gyer", "Chat Uygulaması");
            cmd.Parameters.AddWithValue("@icerik", txtIcerik.Text);
            baglan.Open();
            cmd.ExecuteNonQuery();
            baglan.Close();

            MessageChat();
            txtIcerik.Clear();
        }

        public void MessageChat()
        {
            baglan.Open();
            SqlCommand kmt = new SqlCommand("SELECT * From ChatTablosu WHERE alici_tc=@a OR gonderen_tc=@g", baglan);
            kmt.Parameters.AddWithValue("@a",Personel_Bilgileri.tc);
            kmt.Parameters.AddWithValue("@g", Personel_Bilgileri.tc);
            SqlDataAdapter da = new SqlDataAdapter(kmt);            
            DataTable table = new DataTable();
            da.Fill(table);

            if (table != null)
            {
                if (table.Rows.Count > 0)
                {
                    UC_Gonderilen_Mesaj[] gonderilenMesaj = new UC_Gonderilen_Mesaj[table.Rows.Count];
                    UC_Gelen_Mesaj[] gelenMesaj = new UC_Gelen_Mesaj[table.Rows.Count];
                    for (int i = 0; i < 1; i++)
                    {
                        foreach (DataRow row in table.Rows)
                        {
                            if (Personel_Bilgileri.tc == row["gonderen_tc"].ToString() && lblAd.Text == row["alici_tc"].ToString())

                            {
                                gonderilenMesaj[i] = new UC_Gonderilen_Mesaj();
                                gonderilenMesaj[i].Dock = DockStyle.Bottom;
                                gonderilenMesaj[i].BringToFront();
                                gonderilenMesaj[i].Title = row["icerik"].ToString();

                                pnlChat.Controls.Add(gonderilenMesaj[i]);
                                pnlChat.ScrollControlIntoView(gonderilenMesaj[i]);
                            }
                            else if (lblAd.Text == row["gonderen_tc"].ToString() && Personel_Bilgileri.tc == row["alici_tc"].ToString())
                            {
                                gelenMesaj[i] = new UC_Gelen_Mesaj();
                                gelenMesaj[i].Dock = DockStyle.Bottom;
                                gelenMesaj[i].BringToFront();
                                gelenMesaj[i].Title = row["icerik"].ToString();
                                gelenMesaj[i].Icon = pbxProfil.Image;
                                pnlChat.Controls.Add(gelenMesaj[i]);
                                pnlChat.ScrollControlIntoView(gelenMesaj[i]);
                            }

                        }
                    }
                }
            }
        }

        private void uC_Kisiler1_Load(object sender, EventArgs e)
        {
           /* if (pnlİcerik.Visible == false && pnlTittle.Visible == false && pnlMesaj.Visible == false)
            {
                pnlİcerik.Visible = true;
                pnlTittle.Visible = true;
                pnlMesaj.Visible = true;
            }

            UC_Kisiler control = (UC_Kisiler)sender;
            lblAd.Text = control.Title;
          //  pbxProfil.Image = control.Icon;
            MessageChat();*/
        }

        private void uC_Kisiler1_Click(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         //   MessageChat();
        }

        private void uC_Kisiler1_Load_1(object sender, EventArgs e)
        {

        }

        private void pnlKisiListesi_Click(object sender, EventArgs e)
        {

        }

        private void pnlChat_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void pnlMesaj_Click(object sender, EventArgs e)
        {

        }

        private void pbxDosya_Click(object sender, EventArgs e)
        {

        }

        private void txtIcerik_TextChanged(object sender, EventArgs e)
        {

        }

        private void pnlİcerik_Click(object sender, EventArgs e)
        {

        }

        private void lblAd_Click(object sender, EventArgs e)
        {

        }

        private void pnlTittle_Click(object sender, EventArgs e)
        {

        }

        private void pbxProfil_Click(object sender, EventArgs e)
        {

        }

        private void uC_Gonderilen_Mesaj1_Load(object sender, EventArgs e)
        {

        }

        private void uC_Gelen_Mesaj1_Load(object sender, EventArgs e)
        {

        }
    }
}