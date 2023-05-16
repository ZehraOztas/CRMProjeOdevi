using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NewCRM
{
    public partial class MusteriBilgileri : Form
    {
        public MusteriBilgileri()
        {
            InitializeComponent();
        }

        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        DataClassesMusteriBilgileriDataContext dcMb = new DataClassesMusteriBilgileriDataContext();

        
        private void notekrar()  // Eleman Sayısını kontrol eder ve o kadar listelememizi sağlar.
        {
            int personelSayisi = dcMb.Musteri.Count();  // Mevcut personel sayısını alın
            int nesneSayisi = pnlMusteriBilgileri.Controls.OfType<UC_MusteriBilgileri>().Count();  // Panele eklenen nesne sayısını alın

            while (pnlMusteriBilgileri.Controls.OfType<UC_MusteriBilgileri>().Count() > personelSayisi)
            {
                pnlMusteriBilgileri.Controls.RemoveAt(pnlMusteriBilgileri.Controls.Count - 1);
            }
        }
        private void filtre(string durum) //Burada filtreleme işlemi yapıyoruz. Combobox'in index numarasına göre aldığımız duruma göre listeleme işlemi yapıyoruz.
        {
            pnlMusteriBilgileri.Controls.Clear();
            foreach (var deg in dcMb.Musteri)
            {
                SqlCommand command = new SqlCommand("SELECT ad,soyad,ep,tel,calistigi_yer, pozisyonu, son_tarih, durum, proje_adi FROM Musteri WHERE durum = @d AND projeyi_yoneten=@y ORDER BY son_tarih desc", baglan);
                command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                command.Parameters.AddWithValue("@d", durum);
                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();
                
                while (oku.Read())
                {
                    UC_MusteriBilgileri uc = new UC_MusteriBilgileri(); // kontrol nesnesi oluşturulur
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                    uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                    uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                    uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                    uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                    uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                    uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                    uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    uc.Dock = DockStyle.Top;
                    uc.rbtnSec.Checked = false;
                    uc.pnlBack.BackColor = Color.WhiteSmoke;
                    pnlMusteriBilgileri.Controls.Add(uc);
                }
                oku.Close();
                baglan.Close();
            }
         //   notekrar();
        }


        private void listele() //Form açıldığı zaman yapılacak listeleme
        {
            pnlMusteriBilgileri.Controls.Clear();
            foreach (var deg in dcMb.Musteri)
            {
                SqlCommand command = new SqlCommand("SELECT ad,soyad,ep,tel,calistigi_yer, pozisyonu, son_tarih, durum, proje_adi FROM Musteri WHERE projeyi_yoneten=@y ORDER BY son_tarih desc", baglan);
                command.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();
               
                while (oku.Read())
                {
                    UC_MusteriBilgileri uc = new UC_MusteriBilgileri(); // kontrol nesnesi oluşturulur
                    uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                    uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                    uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                    uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                    uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                    uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                    uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                    uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                    uc.Dock = DockStyle.Top;
                    uc.rbtnSec.Checked = false;
                    uc.pnlBack.BackColor = Color.WhiteSmoke;
                    pnlMusteriBilgileri.Controls.Add(uc);
                }

                oku.Close();
                baglan.Close();
            }
        }
        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void MusteriBilgileri_Load(object sender, EventArgs e)
        {
            listele();
            notekrar();
        }


        private void txtAra_TextChanged(object sender, EventArgs e)
        {
            //Textbox'a yazdıklarımıza göre arama yapması için 
            pnlMusteriBilgileri.Controls.Clear();
            if (txtAra.Text == " " || txtAra.Text == "")
            {
                listele();
                notekrar();
            }
            else
            {

                foreach (var deg in dcMb.Musteri)
                {
                    SqlCommand ara = new SqlCommand("SELECT ad,soyad,ep,tel,calistigi_yer, pozisyonu, ilk_tarih, son_tarih, durum, proje_adi FROM Musteri WHERE (ad LIKE @ad+'%' or soyad LIKE @sad+'%' or calistigi_yer LIKE '%'+@cyer+'%')and(projeyi_yoneten=@y)", baglan);
                    ara.Parameters.AddWithValue("@y", Personel_Bilgileri.tc);
                    ara.Parameters.AddWithValue("@ad", txtAra.Text);
                    ara.Parameters.AddWithValue("@sad", txtAra.Text);
                    ara.Parameters.AddWithValue("@cyer", txtAra.Text);
                    baglan.Open();
                    SqlDataReader oku = ara.ExecuteReader();
                    while (oku.Read())
                    {
                        UC_MusteriBilgileri uc = new UC_MusteriBilgileri();
                        uc.lblAdSoyad.Text = oku.GetString(oku.GetOrdinal("ad")) + " " + oku.GetString(oku.GetOrdinal("soyad"));
                        uc.lblEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                        uc.lblTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                        uc.lblCalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                        uc.lblPozisyon.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                        uc.dtpSontarih.Text = oku.GetDateTime(oku.GetOrdinal("son_tarih")).ToString();
                        uc.lblDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                        uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                        uc.rbtnSec.Checked = false;
                        uc.pnlBack.BackColor = Color.WhiteSmoke;
                        pnlMusteriBilgileri.Controls.Add(uc);
                    }
                    baglan.Close();
                } 
                notekrar();
            }

           
        }

        private void bunifuShadowPanel2_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPrjAdi_Click(object sender, EventArgs e)
        {

        }

        private void lblDurum_Click(object sender, EventArgs e)
        {

        }

        private void lblPozisyon_Click(object sender, EventArgs e)
        {

        }

        private void lblCalistigiYer_Click(object sender, EventArgs e)
        {

        }

        private void lblEp_Click(object sender, EventArgs e)
        {

        }

        private void lblTel_Click(object sender, EventArgs e)
        {

        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void cbxFiltre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string durum;
            //Burada combobox'ın index numarasıdaki yazıyı alıp filtre adındaki fonksiyona gönderiyor ve durum tipine göre listeleme işlemi yapılıyor.

            switch (cbxFiltre.SelectedIndex)
            {
                case 0:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 1:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 2:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 3:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 4:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 5:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 6:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
                case 7:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;

                case 8:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;

                case 9:
                    durum = cbxFiltre.Text;
                    filtre(durum);
                    break;
            }
        }

        private void pnlMusteriBilgileri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
           
        }


        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            this.Close();
            MessageBox.Show("Sayfa kapatıldı");
            Ana_Sayfa ana_Sayfa = new Ana_Sayfa();
            MusteriBilgiDuzenleme f = new MusteriBilgiDuzenleme();
            ana_Sayfa.formGetir(f);


        }
    }
}

