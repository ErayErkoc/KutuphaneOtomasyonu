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
    public partial class Kitap_Liste : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
       
        public Kitap_Liste()
        {
            InitializeComponent();
        }

        private void Kitap_Liste_Load(object sender, EventArgs e)
        {
            var kitaplar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = kitaplar.ToList();
        }
    }
}
