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
    public partial class Ödünç_Ver : Form
    {
        public Ödünç_Ver()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void Ödünç_Ver_Load(object sender, EventArgs e)
        {
            var ÖdünçKitaplar = db.ÖdünçKitaplar.ToList();
            dataGridView1.DataSource = ÖdünçKitaplar.ToList();
            var Kaynaklar = db.Kaynaklar.ToList();
            dataGridView2.DataSource = Kaynaklar.ToList();
            //istenmeyen kolonları gizledim
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[7].Visible = false;
            dataGridView1.Columns[8].Visible = false;
            dataGridView1.Columns[9].Visible = false;

            // Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "Kitap Adı";
            dataGridView1.Columns[4].HeaderText = "Alış Tarihi";
            dataGridView1.Columns[5].HeaderText = "Veriş Tarihi";
            dataGridView1.Columns[6].HeaderText = "Geri Verildi Mi?";

            // istenmeyen kolonları gizledim
            dataGridView2.Columns[0].Visible = false;
            dataGridView2.Columns[6].Visible = false;

            // Veritabanından gelen kolon isimlerini değiştirdim
            dataGridView2.Columns[1].HeaderText = "Kitap Adı";
            dataGridView2.Columns[2].HeaderText = "Yazarı";
            dataGridView2.Columns[3].HeaderText = "Türü";
            dataGridView2.Columns[4].HeaderText = "Yayınevi";
            dataGridView2.Columns[5].HeaderText = "Sayfa Sayısı";


        }

        private void Arabtn_Click(object sender, EventArgs e)
        {
            string ArananKod = KodBultxt.Text;
            var OkuyucuVarmı = db.Okuyucular.Where(x => x.OkuyucuKod == ArananKod).FirstOrDefault();
            if (OkuyucuVarmı != null)
            {
                label2.Text = OkuyucuVarmı.OkuyucuAd + " " + OkuyucuVarmı.OkuyucuSoyad;
            }
            else
                label2.Text = (" KULLANICI BULUNAMADI !");

        }

        private void KitapAratxt_TextChanged(object sender, EventArgs e)
        {
            string ArananKitap = KitapAratxt.Text;
            var BulunanKitap = db.Kaynaklar.Where(x => x.KitapAd.Contains(ArananKitap)).ToList();
            dataGridView2.DataSource = BulunanKitap;
        }

        private void VerenArabtn_Click(object sender, EventArgs e)
        {
            string ArananKod = VerenKodBultxt.Text;
            var OkuyucuVarmı = db.Okuyucular.Where(x => x.OkuyucuKod == ArananKod).FirstOrDefault();
            if (OkuyucuVarmı != null)
            {
                label3.Text = OkuyucuVarmı.OkuyucuAd + " " + OkuyucuVarmı.OkuyucuSoyad;
            }
            else
                label3.Text = (" KULLANICI BULUNAMADI !");
        }

        private void ÖdünçVerbtn_Click(object sender, EventArgs e)
        {
            // Veritabanından alan ve veren kişileri seçtim
            string AlanKişiKod = KodBultxt.Text;
            var AlanKişi = db.Okuyucular.Where(x => x.OkuyucuKod.Equals(AlanKişiKod)).FirstOrDefault();

            string VerenKişiKod = VerenKodBultxt.Text;
            var VerenKişi = db.Okuyucular.Where(x => x.OkuyucuKod.Equals(VerenKişiKod)).FirstOrDefault();

            // Veritabanından Kitabı seçtim

            int SeçilenKitapId = Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value);
            var SeçilenKitap = db.Kaynaklar.Where(x => x.KitapId == SeçilenKitapId).FirstOrDefault();

            ÖdünçKitaplar Ödünç = new ÖdünçKitaplar();
            Ödünç.KitapId = SeçilenKitap.KitapId;
            Ödünç.AlanOkuyucuId = AlanKişi.OkuyucuId;
            Ödünç.VerenOkuyucuId = VerenKişi.OkuyucuId;
            Ödünç.AlışTarihi = DateTime.Today;
            Ödünç.VerişTarihi = DateTime.Today.AddDays(30);
            Ödünç.GeriVerildiMi = false;
            db.ÖdünçKitaplar.Add(Ödünç);
            db.SaveChanges();
            var ÖdünçKitaplar = db.ÖdünçKitaplar.ToList();
            dataGridView1.DataSource = ÖdünçKitaplar.ToList();


        }

        
    }
}
