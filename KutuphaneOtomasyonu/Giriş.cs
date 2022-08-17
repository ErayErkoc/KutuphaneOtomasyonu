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
    public partial class Giriş : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
        public Giriş()
        {
            InitializeComponent();
            
        }

        private void KullanıcıGirişBTN_Click(object sender, EventArgs e)
        {
            string GelenAd = KullanıcıAdtxt.Text;
            string GelenŞifre = Şifretxt.Text;

            var kullanıcı = db.Kullanıcılar.Where(x => x.Ad.Equals(GelenAd)&&x.Şifre.Equals(GelenŞifre)).FirstOrDefault();
            
            if (kullanıcı==null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı");
                İşlem_Paneli panel= new İşlem_Paneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
