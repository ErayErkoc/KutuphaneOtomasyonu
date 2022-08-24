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

            // istenmeyen kolonları gizledim
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            // Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Kod";
            dataGridView1.Columns[4].HeaderText = "Email";
            dataGridView1.Columns[5].HeaderText = "Telefon";
            dataGridView1.Columns[6].HeaderText = "Cinsiyet";
        }

        private void OkuyucuKaydetbtn_Click(object sender, EventArgs e)
        {
            Okuyucular okuyucu = new Okuyucular();
            okuyucu.OkuyucuAd = EkleAdtxt.Text;
            okuyucu.OkuyucuSoyad = EkleSoyadtxt.Text;
            okuyucu.OkuyucuKod = EkleTCtxt.Text;
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
            
        }

        private void Okuyucu_Ekle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
