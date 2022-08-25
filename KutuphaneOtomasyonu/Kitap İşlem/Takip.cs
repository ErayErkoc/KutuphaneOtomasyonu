using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kitap_İşlem
{
    public partial class Takip : Form
    {
        public Takip()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        

        private void KitapAratxt_TextChanged(object sender, EventArgs e)
        {
            string ArananKitap = KitapAratxt.Text;
            var BulunanKitap = db.Kaynaklar.Where(x => x.KitapAd.Contains(ArananKitap)).ToList();
            dataGridView1.DataSource = BulunanKitap;
        }

        private void Takip_Load(object sender, EventArgs e)
        {
            var Kitaplar = db.Kaynaklar.ToList();
            dataGridView1.DataSource = Kitaplar.ToList();

        

            var Ödünç = db.ÖdünçKitaplar.ToList();
            dataGridView2.DataSource = Ödünç.ToList();
            dataGridView2.Visible = false;

            //istenmeyen kolonları gizledim
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[6].Visible = false;


            //Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView1.Columns[1].HeaderText = "Kitap Adı";
            dataGridView1.Columns[2].HeaderText = "Yazarı";
            dataGridView1.Columns[3].HeaderText = "Türü";
            dataGridView1.Columns[4].HeaderText = "Yayınevi";
            dataGridView1.Columns[5].HeaderText = "Sayfa Sayısı";
        }

        private void OkuyucuBulbtn_Click(object sender, EventArgs e)
        {
            int SeçilenKitapId = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
            var SeçilenKitap = db.Kaynaklar.Where(x => x.KitapId == SeçilenKitapId).FirstOrDefault();
            var OkuyucuVarmı = db.ÖdünçKitaplar.Where(x => x.KitapId == SeçilenKitapId).FirstOrDefault();
            if (OkuyucuVarmı != null)
            {
                label1.Text = ("Kitabı Alan Okuyucu : " + OkuyucuVarmı.Okuyucular.OkuyucuAd+" "+OkuyucuVarmı.Okuyucular.OkuyucuSoyad); 
            }
            else
                label1.Text = (" KULLANICI BULUNAMADI !");
        }
    }
}
