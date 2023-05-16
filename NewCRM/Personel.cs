﻿using System;
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
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ZEHRA\\SQLEXPRESS;Initial Catalog=CRM1;Integrated Security=True");

        private void SayfaAc()
        {
            txtTc.Text = Personel_Bilgileri.tc;
            txtAd.Text = Personel_Bilgileri.ad;
            txtsad.Text = Personel_Bilgileri.sad;
            dt.Value = Personel_Bilgileri.dt.Date;
            txtPozisyon.Text = Personel_Bilgileri.pozisyon;
            txtTel1.Text = Personel_Bilgileri.tel1;
            txtTel2.Text = Personel_Bilgileri.tel2;
            txtEp1.Text = Personel_Bilgileri.ep1;
            txtEp2.Text = Personel_Bilgileri.ep2;
            txtAdres.Text = Personel_Bilgileri.adres;
            cbxIl.Text = Personel_Bilgileri.il;
            cbxIlce.Text = Personel_Bilgileri.ilce;
            txtPosta.Text = Personel_Bilgileri.postaKodu;

            if (Personel_Bilgileri.cinsiyet == "Kadın")
            {
                rbtnKadin.Checked = true;
            }
            else
            {
                rbtnErkek.Checked = true;
            }
        }
        private void bunifuShadowPanel1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand guncelle = new SqlCommand("UPDATE Personel SET tel1=@tel1, tel2=@tel2, ep1=@ep1 , ep2=@ep2, adres=@adres, il=@il, ilce=@ilce, posta_kodu=@pkod, foto=@foto WHERE tc=@tc",baglanti);
            baglanti.Open();
            guncelle.Parameters.AddWithValue("@tel1",txtTel1.Text);
            guncelle.Parameters.AddWithValue("@tel2", txtTel2.Text);
            guncelle.Parameters.AddWithValue("@ep1", txtEp1.Text);
            guncelle.Parameters.AddWithValue("@ep2", txtEp2.Text);
            guncelle.Parameters.AddWithValue("@adres", txtAdres.Text);
            guncelle.Parameters.AddWithValue("@il", cbxIl.Text);
            guncelle.Parameters.AddWithValue("@ilce", cbxIlce.Text);
            guncelle.Parameters.AddWithValue("@pkod", txtPosta.Text);
            guncelle.Parameters.AddWithValue("@foto", lblYer.Text);
            guncelle.Parameters.AddWithValue("@tc", txtTc.Text);
            guncelle.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Yaptığınız Değişiklikler Kaydedildi");

            Personel_Bilgileri.ep1 = txtEp1.Text;
            Personel_Bilgileri.ep2 = txtEp2.Text;
            Personel_Bilgileri.tel1 = txtTel1.Text;
            Personel_Bilgileri.tel2 = txtTel2.Text;
            Personel_Bilgileri.adres = txtAdres.Text;
            Personel_Bilgileri.il = cbxIl.Text;
            Personel_Bilgileri.ilce = cbxIlce.Text;

            SayfaAc();
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            txtEp1.Text = Personel_Bilgileri.ep1;
            txtEp2.Text = Personel_Bilgileri.ep2;
            txtTel1.Text = Personel_Bilgileri.tel1;
            txtTel2.Text = Personel_Bilgileri.tel2;
            txtAdres.Text = Personel_Bilgileri.adres;
            cbxIl.Text = Personel_Bilgileri.il;
            txtIlce.Text = Personel_Bilgileri.ilce;
            txtPosta.Text = Personel_Bilgileri.postaKodu;
        }

        private void bunifuShadowPanel1_ControlAdded_1(object sender, ControlEventArgs e)
        {

        }

        private void Personel_Load(object sender, EventArgs e)
        {
            SayfaAc();  
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
         //   try
           // {
                OpenFileDialog dosya = new OpenFileDialog();
                dosya.FileName = "Resim Seç";
                dosya.Filter = "Resim Dosyası |*.jpg;*.jpeg;*.png |  Tüm Dosyalar |*.*\";";
               
                if (dosya.ShowDialog() == DialogResult.OK)
                {
                    pbxProfil.ImageLocation = dosya.FileName;

                    string currentFilePath = pbxProfil.ImageLocation;
                    string newFileName = Personel_Bilgileri.ad + Personel_Bilgileri.sad + "Profil";
                    string currentFileExtension = Path.GetExtension(currentFilePath); //Resim yolunu alır.
                    string debugFolderPath = Path.Combine(Application.StartupPath, "personelFoto" + currentFileExtension);//Klosöre kaydeder
                    string newFilePath = Path.Combine(debugFolderPath, newFileName);//yeni yolu alır.

                if (File.Exists(newFilePath))
                {
                    File.Delete(newFilePath);
                    System.IO.File.Copy(currentFilePath, newFilePath, true);
                }

                //else
                //{
                //    File.Copy(currentFilePath, newFilePath);
                //}

                    // System.IO.File.Copy(currentFilePath, newFilePath, true);

                    lblYer.Text = newFilePath;
                }
                else
                {
                    //pbxProfil.ImageLocation = Image.FromFile(Personel_Bilgileri.foto);
                }

          /*  }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }*/
                       
        }
    }
}