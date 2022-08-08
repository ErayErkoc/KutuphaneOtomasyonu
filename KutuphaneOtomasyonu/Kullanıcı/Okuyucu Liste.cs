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
    public partial class Okuyucu_Liste : Form
    {
        public Okuyucu_Liste()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
            var Okuyucular = db.Okuyucular.ToList();
            dataGridView1.DataSource = Okuyucular.ToList();
        }
            
        private void Okuyucu_Liste_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
