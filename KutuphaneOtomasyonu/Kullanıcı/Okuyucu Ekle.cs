using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kullanıcı
{
    public partial class Okuyucu_Ekle : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
        public Okuyucu_Ekle()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            var Okuyucular = db.Okuyucular.ToList();
            dataGridView1.DataSource = Okuyucular.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Listele();
        }

        private void OkuyucuKaydetbtn_Click(object sender, EventArgs e)
        {
            Okuyucular okuyucu = new Okuyucular();
            okuyucu.OkuyucuAd = EkleAdtxt.Text;
            okuyucu.OkuyucuSoyad = EkleSoyadtxt.Text;
            okuyucu.OkuyucuTC = EkleTCtxt.Text;
            okuyucu.OkuyucuMail = EkleMailtxt.Text;
            okuyucu.OkuyucuTelefon = EkleTelefontxt.Text;
            if (radioErkek.Checked == true)
            {
                okuyucu.OkuyucuCinsiyet = "ERKEK";
            }
            else if (radioKadın.Checked == true)
            {
                okuyucu.OkuyucuCinsiyet = "KADIN";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyetinizi Belirtiniz");
            }

            db.Okuyucular.Add(okuyucu);
            db.SaveChanges();
            Listele();
        }
    }
}
