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
    public partial class Kitap_Düzenle : Form
    {
        public Kitap_Düzenle()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void Kitap_Düzenle_Load(object sender, EventArgs e)
        {
            var kitaplar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
            Listele();
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            KitapAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Yazartxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            KitapTürütxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Yayınevitxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            numericUpDown1.Value = Convert.ToDecimal( dataGridView1.CurrentRow.Cells[5].Value);
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

        private void KitapGüncellebtn_Click(object sender, EventArgs e)
        {
            int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kitap = db.Kaynaklar.Where(x => x.KitapId == SeçilenId).FirstOrDefault();

            kitap.KitapAd = KitapAdtxt.Text;
            kitap.KitapYazar = Yazartxt.Text;
            kitap.KitapTür = KitapTürütxt.Text;
            kitap.KitapYayınevi = Yayınevitxt.Text;
            kitap.KitapSayfaSayısı = Convert.ToInt32(numericUpDown1.Value);
            db.SaveChanges();
        }
    }
}
