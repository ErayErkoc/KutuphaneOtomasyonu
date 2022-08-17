using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kitap
{
    public partial class Kitap_Ekle : Form
    {
        public Kitap_Ekle()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void KitapEklebtn_Click(object sender, EventArgs e)
        {
            Kaynaklar kitap = new Kaynaklar();
            kitap.KitapAd = KitapAdtxt.Text;
            kitap.KitapYazar = Yazartxt.Text;
            kitap.KitapTür = KitapTürütxt.Text;
            kitap.KitapYayınevi = Yayınevitxt.Text;
            kitap.KitapSayfaSayısı = Convert.ToInt32(numericUpDown1.Value);

            db.Kaynaklar.Add(kitap);
            db.SaveChanges();

            var kitaplar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();

        }
    
    }
}
