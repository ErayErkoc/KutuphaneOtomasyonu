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
    public partial class Okuyucu_Sil : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        public Okuyucu_Sil()
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

        private void Okuyucu_Sil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult SilinsinMi = MessageBox.Show("Okuyucu Silinecek, Onaylıyor musun?","Okuyucu Sil",MessageBoxButtons.YesNo);

            if (SilinsinMi == DialogResult.Yes)
            {
                int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
                var okuyucu = db.Okuyucular.Where(x => x.OkuyucuId == SeçilenId).FirstOrDefault();
                db.Okuyucular.Remove(okuyucu);
                db.SaveChanges();
                Listele();
                MessageBox.Show("OKUYUCU SİLİNDİ");
            }
            else
            {
                MessageBox.Show("Silme İşlemi İptal Edildi");
            }

        }
    }
}
