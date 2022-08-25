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
    public partial class Kitap_Sil : Form
    {
        public Kitap_Sil()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void Kitap_Sil_Load(object sender, EventArgs e)
        {
            var Kitaplar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = Kitaplar.ToList();
            Listele();
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

        private void KitapSilbtn_Click(object sender, EventArgs e)
        {
            DialogResult SilinsinMi = MessageBox.Show("Kitap Silinecek, Onaylıyor musun?", "Kitap Sil", MessageBoxButtons.YesNo);
            while (SilinsinMi == DialogResult.Yes)
            {
                int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var kitap = db.Kaynaklar.Where(x => x.KitapId == SeçilenId).FirstOrDefault();
                db.Kaynaklar.Remove(kitap);
                db.SaveChanges();
                MessageBox.Show("KİTAP SİLİNDİ");
            }
        }
    }
}
