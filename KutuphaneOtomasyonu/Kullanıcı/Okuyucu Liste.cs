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
            
        private void Okuyucu_Liste_Load(object sender, EventArgs e)
        {
            Listele();
        }
    }
}
