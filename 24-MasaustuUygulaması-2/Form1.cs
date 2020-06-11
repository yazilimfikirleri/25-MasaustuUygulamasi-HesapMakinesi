using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_MasaustuUygulaması_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMesajVer_Click(object sender, EventArgs e)
        {
            //Ne zaman yapılacak?
            //btnMesajVer tıklandığında...
            //Ne Yapılacak?
            //Mesaj kutusunda "Merhaba" yazısı görüntülenecek.

            MessageBox.Show("Merhaba");
        }

        private void btnKarsila_Click(object sender, EventArgs e)
        {
            //Ne zaman yapılacak?
            //btnKarsila tıklandığında...
            //Ne yapılacak?
            //txtAd içerisinde değer mesaj kutusunda gösterilecek.

            string ad = txtAd.Text;
            MessageBox.Show(ad);

        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int sonuc = sayi1 + sayi2;

            MessageBox.Show(sonuc.ToString());
        }
    }
}
