﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NewCRM;

namespace NewCRM
{
    internal class Resimleme
    {
      /*  public byte[] ResimYukleme(System.Drawing.Image Resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }*/
        public byte[] ResimYukleme(System.Drawing.Image Resim)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                Resim.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.GetBuffer();
            }
        }


   /*     public Image ResimGetirme(byte[] GelenByteArray)
        {
            using (MemoryStream ms = new MemoryStream(GelenByteArray))
            {
                Image Resim = Image.FromStream(ms);
                return Resim;
            }
        }*/
    }
}
