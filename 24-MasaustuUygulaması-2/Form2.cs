using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _24_MasaustuUygulaması_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTopla_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Topla());
        }

        string Topla()
        {
            int sayi1 = Convert.ToInt32(txtSayi1.Text);
            int sayi2 = Convert.ToInt32(txtSayi2.Text);

            int sonuc = sayi1 + sayi2;
            return sonuc.ToString();
        }

        private void btnCikart_Click(object sender, EventArgs e)
        {
            string sonuc = Fark();
            MessageBox.Show(sonuc);
        }
        string Fark()
        {
            int sonuc = Convert.ToInt32(txtSayi1.Text) - Convert.ToInt32(txtSayi2.Text);
            return sonuc.ToString();
        }

        private void btnCarp_Click(object sender, EventArgs e)
        {
            int sayi1 = int.Parse(txtSayi1.Text);
            int sayi2 = int.Parse(txtSayi2.Text);
            string sonuc = Carp(sayi1, sayi2);
            MessageBox.Show(sonuc);
        }
        string Carp(int s1, int s2)
        {
            int sonuc = s1 * s2;
            return sonuc.ToString();
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            Bol();
        }

        void Bol()
        {
            int s1 = int.Parse(txtSayi1.Text);
            int s2 = int.Parse(txtSayi2.Text);

            double sonuc = s1 / s2;
            MessageBox.Show(sonuc.ToString());
        }
    }
}
