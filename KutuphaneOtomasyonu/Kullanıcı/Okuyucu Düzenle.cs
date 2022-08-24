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
    public partial class Okuyucu_Düzenle : Form
    {
        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();
        public Okuyucu_Düzenle()
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

        private void Okuyucu_Düzenle_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            EkleAdtxt.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            EkleSoyadtxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            EkleTCtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            EkleMailtxt.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            EkleTelefontxt.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            if (dataGridView1.CurrentRow.Cells[6].Value.ToString() == ("ERKEK"))
            {
                radioErkek.Checked = true;
            }
            else
            {
                radioKadın.Checked = true;
            }
          
        }

        private void OkuyucuDüzenlebtn_Click(object sender, EventArgs e)
        {
            int SeçilenId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var okuyucu = db.Okuyucular.Where(x => x.OkuyucuId == SeçilenId).FirstOrDefault();
            
            okuyucu.OkuyucuAd = EkleAdtxt.Text;
            okuyucu.OkuyucuSoyad = EkleSoyadtxt.Text;
            okuyucu.OkuyucuKod = EkleTCtxt.Text;
            okuyucu.OkuyucuMail = EkleMailtxt.Text;
            okuyucu.OkuyucuTelefon = EkleTelefontxt.Text;
            if (radioErkek.Checked == true)
            {
                okuyucu.OkuyucuCinsiyet = "ERKEK";
            }
            else if (radioKadın.Checked == true)
            {
                okuyucu.OkuyucuCinsiyet = "KADIN";
            }
            else
            {
                MessageBox.Show("Lütfen Cinsiyetinizi Belirtiniz");
            }
            db.SaveChanges();
            Listele();
        }
    }
}
