using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void KullanıcıGirişBTN_Click(object sender, EventArgs e)
        {
            string GelenAd = KullanıcıAdtxt.Text;
            string GelenŞifre = Şifretxt.Text;

            if (GelenAd == ("ADMIN") && GelenŞifre == ("123"))
            {
                MessageBox.Show("Giriş Başarılı");
            }
            else
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
        }
    }
}
