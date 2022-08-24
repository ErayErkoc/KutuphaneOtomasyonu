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
        }

        public void Listele()
        {
            var Kitaplar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = Kitaplar.ToList();

            // istenmeyen kolonları gizledim
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;

            // Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazarı";
            dataGridView1.Columns[3].HeaderText = "Türü";
            dataGridView1.Columns[4].HeaderText = "Yayınevi";
            dataGridView1.Columns[5].HeaderText = "Sayfa Sayısı";
        }
            private void Kitap_Ekle_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
