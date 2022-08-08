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
        }

        private void Okuyucu_Sil_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var okuyucu = db.Okuyucular.Where(x => x.OkuyucuId == SeçilenId).FirstOrDefault();
            db.Okuyucular.Remove(okuyucu);
            db.SaveChanges();
            Listele();
        }
    }
}
