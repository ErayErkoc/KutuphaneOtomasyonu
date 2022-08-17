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
        }

        public void Listele()
        {
            var Okuyucular = db.Okuyucular.ToList();
            dataGridView1.DataSource = Okuyucular.ToList();
        }

        private void KitapSilbtn_Click(object sender, EventArgs e)
        {
            int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var kitap = db.Kaynaklar.Where(x => x.KitapId == SeçilenId).FirstOrDefault();
            db.Kaynaklar.Remove(kitap);
            db.SaveChanges();
            Listele();
        }
    }
}
