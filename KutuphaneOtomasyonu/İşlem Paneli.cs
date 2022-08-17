using KutuphaneOtomasyonu.Kitap;
using KutuphaneOtomasyonu.Kullanıcı;
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
    public partial class İşlem_Paneli : Form
    {
        public İşlem_Paneli()
        {
            InitializeComponent();
        }

        private void İşlem_Paneli_Load(object sender, EventArgs e)
        {
            KullaniciEkleBtn.Visible = false;
            KullanıcıSilBtn.Visible = false;
            ProfilDüzenleBtn.Visible = false;
            KitapEklebtn.Visible = false;
            KitapDüzenlebn.Visible = false;
            KitapSilbtn.Visible = false;
            ÖdünçVerbtn.Visible = false;

        }

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            if (KullaniciEkleBtn.Visible == false)
            {
                KullaniciEkleBtn.Visible = true;
                KullanıcıSilBtn.Visible = true;
                ProfilDüzenleBtn.Visible = true;
            }
            else
            {
                KullaniciEkleBtn.Visible = false;
                KullanıcıSilBtn.Visible = false;
                ProfilDüzenleBtn.Visible = false;
            }

            Okuyucu_Liste OkuyucuListeForm = new Okuyucu_Liste();
            OkuyucuListeForm.MdiParent = this;
            OkuyucuListeForm.Show();

        }

        private void KullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            Okuyucu_Ekle EkleForm = new Okuyucu_Ekle();
            EkleForm.MdiParent = this;
            EkleForm.Show();
        }

        private void KullanıcıSilBtn_Click(object sender, EventArgs e)
        {
            Okuyucu_Sil SilForm = new Okuyucu_Sil();
            SilForm.MdiParent = this;
            SilForm.Show();
        }

        private void ProfilDüzenleBtn_Click(object sender, EventArgs e)
        {
            Okuyucu_Düzenle DüzenleForm = new Okuyucu_Düzenle();
            DüzenleForm.MdiParent = this;
            DüzenleForm.Show();
        }

        private void Kitaplarbtn_Click(object sender, EventArgs e)
        {
            if (KitapEklebtn.Visible == false)
            {
                KitapEklebtn.Visible = true;
                KitapDüzenlebn.Visible = true;
                KitapSilbtn.Visible = true;
            }
            else
            {
                KitapEklebtn.Visible = false;
                KitapSilbtn.Visible = false;
                KitapDüzenlebn.Visible = false;
            }

            Kitap_Liste KitapListe = new Kitap_Liste();
            KitapListe.MdiParent = this;
            KitapListe.Show();
        }

        private void KitapEklebtn_Click(object sender, EventArgs e)
        {
            Kitap_Ekle KitapEkle = new Kitap_Ekle();
            KitapEkle.MdiParent = this;
            KitapEkle.Show();
        }

        private void KitapSilbtn_Click(object sender, EventArgs e)
        {
            Kitap_Sil KitapSil = new Kitap_Sil();
            KitapSil.MdiParent = this;
            KitapSil.Show();
        }

        private void KitapDüzenlebn_Click(object sender, EventArgs e)
        {
            Kitap_Düzenle KitapDüzenle = new Kitap_Düzenle();
            KitapDüzenle.MdiParent = this;
            KitapDüzenle.Show();
        }

        private void Kitapİşlembtn_Click(object sender, EventArgs e)
        {
            if (ÖdünçVerbtn.Visible==false)
            {
                ÖdünçVerbtn.Visible = true;
            }
            else
            {
                ÖdünçVerbtn.Visible = false;
            }
        }
    }
}
