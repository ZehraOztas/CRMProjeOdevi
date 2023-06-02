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
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;
using Image = System.Net.Mime.MediaTypeNames.Image;

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
        public String deger = "";

        public void NotGetir()
        {

            SqlCommand komut = new SqlCommand("SELECT n_id,icerik,eklenen_tarih,proje_adi FROM Notlar WHERE musteri_id=@id ORDER BY eklenen_tarih desc", baglan);
            komut.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);
            baglan.Open();
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                UC_Notlar uc = new UC_Notlar();

                uc.lblPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                uc.lblNot.Text = oku.GetString(oku.GetOrdinal("icerik"));
                uc.dtpTarih.Value = oku.GetDateTime(oku.GetOrdinal("eklenen_tarih"));
                uc.lblnid.Text = oku.GetInt32(oku.GetOrdinal("n_id")).ToString();

                uc.Dock = DockStyle.Top;
                pnlNotlar.Controls.Add(uc);
            }

            oku.Close();
            baglan.Close();

        }
        private void Listele() //Başlagıçta seçtiğimiz kişinin verilerini çekiyoruz.
        {
            Resimleme resim = new Resimleme();
            pnlNotlar.Controls.Clear();

            //İlk önce seçtiğimiz kişinin verisini çekiyoruz.
            
                SqlCommand command = new SqlCommand("SELECT * FROM Musteri WHERE m_id=@id ORDER BY son_tarih desc", baglan);
                command.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);
                baglan.Open();
                SqlDataReader oku = command.ExecuteReader();

            if (oku.Read())
            {
                txtADs.Text = oku.GetString(oku.GetOrdinal("ad"));
                txtSoyad.Text = oku.GetString(oku.GetOrdinal("soyad"));
                txtcalistigiYer.Text = oku.GetString(oku.GetOrdinal("calistigi_yer"));
                txtPrjAdi.Text = oku.GetString(oku.GetOrdinal("proje_adi"));
                txtPozisyonu.Text = oku.GetString(oku.GetOrdinal("pozisyonu"));
                txtTel.Text = oku.GetString(oku.GetOrdinal("tel"));
                txtEp.Text = oku.GetString(oku.GetOrdinal("ep"));
                dtpIlkİletisim.Value = oku.GetDateTime(oku.GetOrdinal("ilk_tarih"));
                dtpBirSonraki.Value = oku.GetDateTime(oku.GetOrdinal("son_tarih"));
                cbxDurum.Text = oku.GetString(oku.GetOrdinal("durum"));
                /*      byte[] goruntu = oku["foto"] as byte[]; // Resim sütununu byte dizisine dönüştür

                      if (goruntu != null)
                      {
                          pbxFooto.Image = resim.ResimGetirme(goruntu); // ResimGetirme yöntemine byte dizisini geçir
                      }
                      else
                      {
                          // Veritabanında resim yoksa, varsayılan bir resim veya boş bir resim gösterebilirsiniz
                          pbxFooto.Image = Properties.Resources.indir; // Varsayılan bir resim kullanabilirsiniz
                                                                       // veya
                                                                       //pbxFooto.Image = null; // Boş bir resim göstermek için PictureBox'ın Image özelliğini null yapabilirsiniz
                      }**/
                oku.Close();
                baglan.Close();

            }
        }
        private void MusteriBilgiDuzenleme_Load(object sender, EventArgs e)
        {
            //Eğer m_id değeri varsa textboxşara o müşterinin verileri yazılır. Eğer yoksa textboxlar boş gelir ve içerisine veriler girerek yeni müşteri kaydı oluştururuz.
            if (Personel_Bilgileri.m_id != null)
            {
                Listele();
                NotGetir();
            }
        }

        private void btnMusteriBilgileriDegisikleri_Click(object sender, EventArgs e)//Kayıt ekleme ve güncelleme işlemleri yapılıyor. Güncelleme için yeni form eklemeyip sadece üstüne kaydet için kullandığım formu çekip button textini değiştirdiğim için bir değişken oluşturdum ve ona göre yapılacak işlemleri belirttim.
        {
            DateTime now = DateTime.Now;

            Resimleme resim = new Resimleme();
            byte[] resimBytes = resim.ResimYukleme(pbxFooto.Image);

            if (deger == "Yeni Kayıt")
            {
                if (string.IsNullOrEmpty(txtADs.Text) || string.IsNullOrEmpty(txtcalistigiYer.Text) || string.IsNullOrEmpty(txtEp.Text) || string.IsNullOrEmpty(txtPozisyonu.Text) || string.IsNullOrEmpty(txtPrjAdi.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(cbxDurum.Text) || cbxDurum.Text == "Seçiniz")
                {
                    MessageBox.Show("Lütfen boş geçmeyiniz.");
                }
                else
                {
                    SqlCommand kaydet = new SqlCommand("INSERT INTO Musteri(ad,soyad,ep,tel,calistigi_yer,pozisyonu, ilk_tarih, son_tarih, durum, proje_adi,projeyi_yoneten,foto)VALUES(@ad,@sad,@ep,@tel,@cyer,@pozisyonu, @ilk_tarih, @son_tarih, @durum, @proje_adi,@projeyi_yoneten, @foto)", baglan);
                    kaydet.Parameters.AddWithValue("@ad", txtADs.Text);
                    kaydet.Parameters.AddWithValue("@sad", txtSoyad.Text);
                    kaydet.Parameters.AddWithValue("@ep", txtEp.Text);
                    kaydet.Parameters.AddWithValue("@tel", txtTel.Text);
                    kaydet.Parameters.AddWithValue("@cyer", txtcalistigiYer.Text);
                    kaydet.Parameters.AddWithValue("@pozisyonu", txtPozisyonu.Text);
                    kaydet.Parameters.AddWithValue("@ilk_tarih", now);
                    kaydet.Parameters.AddWithValue("@son_tarih", dtpBirSonraki.Value);
                    kaydet.Parameters.AddWithValue("@durum", cbxDurum.Text);
                    kaydet.Parameters.AddWithValue("@proje_adi", txtPrjAdi.Text);
                    kaydet.Parameters.AddWithValue("@projeyi_yoneten", Personel_Bilgileri.tc);
                    kaydet.Parameters.AddWithValue("@foto", resimBytes);
                    baglan.Open();
                    kaydet.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("İşleminiz gerçekleştirildi.");
                    Listele();
                }
            }

            else if (deger == "Güncelle")
            {
                if (string.IsNullOrEmpty(txtADs.Text) || string.IsNullOrEmpty(txtcalistigiYer.Text) || string.IsNullOrEmpty(txtEp.Text) || string.IsNullOrEmpty(txtPozisyonu.Text) || string.IsNullOrEmpty(txtPrjAdi.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTel.Text) || string.IsNullOrEmpty(cbxDurum.Text) || cbxDurum.Text == "Seçiniz")
                {
                    MessageBox.Show("Lütfen boş geçmeyiniz.");
                }
                else
                {
                    pnlMusteriBilgi.Enabled = true;
                    SqlCommand kaydet = new SqlCommand("UPDATE Musteri SET ad=@ad,soyad=@sad,ep=@ep,tel=@tel,calistigi_yer=@cyer,pozisyonu=@pozisyonu, son_tarih=@son_tarih, durum=@durum, proje_adi=@proje_adi WHERE m_id=@id", baglan);
                    kaydet.Parameters.AddWithValue("@id", Personel_Bilgileri.m_id);
                    kaydet.Parameters.AddWithValue("@ad", txtADs.Text);
                    kaydet.Parameters.AddWithValue("@sad", txtSoyad.Text);
                    kaydet.Parameters.AddWithValue("@ep", txtEp.Text);
                    kaydet.Parameters.AddWithValue("@tel", txtTel.Text);
                    kaydet.Parameters.AddWithValue("@cyer", txtcalistigiYer.Text);
                    kaydet.Parameters.AddWithValue("@pozisyonu", txtPozisyonu.Text);
                    kaydet.Parameters.AddWithValue("@son_tarih", dtpBirSonraki.Value);
                    kaydet.Parameters.AddWithValue("@durum", cbxDurum.Text);
                    kaydet.Parameters.AddWithValue("@proje_adi", txtPrjAdi.Text);
                    //  kaydet.Parameters.AddWithValue("@foto", resimgetir);
                    baglan.Open();
                    kaydet.ExecuteNonQuery();
                    baglan.Close();
                    MessageBox.Show("İşleminiz gerçekleştirildi.");
                    Listele();
                }

            }
            Personel_Bilgileri.m_id = null;
        }

        private void btnNotEkle_Click(object sender, EventArgs e) //Bu form kapatılıp yerine Notlar formu açılıyor.
        {
            BackModel backmodel = new BackModel();
            NotlarForm percikarcard = new NotlarForm();
            percikarcard.tip = "Yeni Kayıt";
            percikarcard.btnKaydet.Text = "Kaydet";
            percikarcard.StartPosition = FormStartPosition.CenterScreen;
            backmodel.FormBorderStyle = FormBorderStyle.None;
            backmodel.Opacity = .50d;
            backmodel.BackColor = Color.Black;
            backmodel.ShowInTaskbar = false;
            backmodel.Show();
            percikarcard.Owner = backmodel;
            percikarcard.ShowDialog();
            backmodel.Dispose();
        }

        private void btnFotoSec_Click(object sender, EventArgs e)//Fotoğraf seçilir.
        {
            OpenFileDialog dosya = new OpenFileDialog();
            dosya.FileName = "Resim Seç";
            dosya.Filter = "Resim Dosyası |*.jpg;*.jpeg;*.png |  Tüm Dosyalar |*.*\";";

            if (dosya.ShowDialog() == DialogResult.OK)
            {
                pbxFooto.ImageLocation = dosya.FileName;
            }

        }
    }
}