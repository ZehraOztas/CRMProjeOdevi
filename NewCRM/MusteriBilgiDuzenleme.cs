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
    public partial class MusteriBilgiDuzenleme : Form
    {
        public MusteriBilgiDuzenleme()
        {
            InitializeComponent();
        }
        DataClassesMusteriBilgileriDataContext dc = new DataClassesMusteriBilgileriDataContext();
        SqlConnection baglan = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");
        public bool deger = false;
        private void NotGetir(string ad, string prjAd, string icerik, DateTime tarih)
        {
            UC_Notlar notlar = new UC_Notlar();
            notlar.lblAdSoyad.Text = ad;
            notlar.lblPrjAdi.Text = prjAd;
            notlar.lblNot.Text = icerik;
            notlar.dtpTarih.Value = tarih;
        }

        private void MusteriBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            foreach (var deg in dc.Musteri)
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

                    if (!oku.IsDBNull(oku.GetOrdinal("foto")))
                    {
                        uc.pbxKisiFoto.Text = oku.GetString(oku.GetOrdinal("foto"));
                    }
                    else
                    {
                        // Null değer olduğunda yapılacak işlem
                        string imagePath = "C:\\Users\\oztas\\OneDrive\\Masaüstü\\NewCRM - 12.05.2023\\indir.jpeg"; // Açmak istediğiniz fotoğrafın dosya yolunu belirtin

                        // Picturebox'a fotoğrafı yükleme
                        uc.pbxKisiFoto.Image = Image.FromFile(imagePath);
                    }
                    uc.Dock = DockStyle.Top;
                    pnlNotlar.Controls.Add(uc);
                }

                oku.Close();
                baglan.Close();
            }
        }
    }
}
