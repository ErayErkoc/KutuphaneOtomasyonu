using KutuphaneOtomasyonu.Kitap;
using KutuphaneOtomasyonu.Kitap_İşlem;
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
            GeriAlbtn.Visible = false;
            Takipbtn.Visible = false;
            

        }

        Okuyucu_Liste OkuyucuListeForm;

        private void KullanicilarBtn_Click(object sender, EventArgs e)
        {
            if (KullaniciEkleBtn.Visible == false)
            {
                KullaniciEkleBtn.Visible = true;
                KullanıcıSilBtn.Visible = true;
                ProfilDüzenleBtn.Visible = true;
                OkuyucuListeForm = new Okuyucu_Liste();
                OkuyucuListeForm.Show();
            }
            else
            {
                KullaniciEkleBtn.Visible = false;
                KullanıcıSilBtn.Visible = false;
                ProfilDüzenleBtn.Visible = false;
                OkuyucuListeForm.Close();
            }

            OkuyucuListeForm.MdiParent = this;
            

        }

        Okuyucu_Ekle EkleForm;
        bool OkuyucuEkle = false;

        private void KullaniciEkleBtn_Click(object sender, EventArgs e)
        {
            if (OkuyucuEkle == false)
            {
               EkleForm = new Okuyucu_Ekle();
               EkleForm.MdiParent = this;
               EkleForm.Show();
               OkuyucuEkle = true;
            }
            else
            {
                EkleForm.Close();
                OkuyucuEkle = false;
            }

        }

        Okuyucu_Sil SilForm;
        bool OkuyucuSil = false;

        private void KullanıcıSilBtn_Click(object sender, EventArgs e)
        {
            if (OkuyucuSil == false)
            {
                SilForm = new Okuyucu_Sil();
                SilForm.MdiParent = this;
                SilForm.Show();
                OkuyucuSil = true;
            }
            else
            {
                SilForm.Close();
                OkuyucuSil = false;
            }
        }

        Okuyucu_Düzenle DüzenleForm;
        bool OkuyucuDüzenle = false;

        private void ProfilDüzenleBtn_Click(object sender, EventArgs e)
        {
            if (OkuyucuDüzenle == false)
            {
                DüzenleForm = new Okuyucu_Düzenle();
                DüzenleForm.MdiParent = this;
                DüzenleForm.Show();
                OkuyucuDüzenle = true;
            }
            else
            {
                DüzenleForm.Close();
                OkuyucuDüzenle = false;
            }
        }

        Kitap_Liste KitapListe;

        private void Kitaplarbtn_Click(object sender, EventArgs e)
        {
            if (KitapEklebtn.Visible == false)
            {
                KitapEklebtn.Visible = true;
                KitapDüzenlebn.Visible = true;
                KitapSilbtn.Visible = true;
                KitapListe = new Kitap_Liste();
                KitapListe.Show();
            }
            else
            {
                KitapEklebtn.Visible = false;
                KitapSilbtn.Visible = false;
                KitapDüzenlebn.Visible = false;
                KitapListe.Close();
            }

            
            KitapListe.MdiParent = this;
            
        }

        Kitap_Ekle KitapEkleForm;
        bool KitapEkle = false;

        private void KitapEklebtn_Click(object sender, EventArgs e)
        {
            if (KitapEkle == false)
            {
                KitapEkleForm = new Kitap_Ekle();
                KitapEkleForm.MdiParent = this;
                KitapEkleForm.Show();
                KitapEkle = true;
            }
            else
            {
                KitapEkleForm.Close();
                KitapEkle = false;
            }
        }

        Kitap_Sil KitapSilForm;
        bool KitapSil = false;
        private void KitapSilbtn_Click(object sender, EventArgs e)
        {
            if (KitapSil == false)
            {
                KitapSilForm = new Kitap_Sil();
                KitapSilForm.MdiParent = this;
                KitapSilForm.Show();
                KitapSil = true;
            }
            else
            {
                KitapSilForm.Close();
                KitapSil = false;
            }
        }

        Kitap_Düzenle KitapDüzenleForm;
        bool KitapDüzenle = false;

        private void KitapDüzenlebn_Click(object sender, EventArgs e)
        {
            if (KitapDüzenle == false)
            {
                KitapDüzenleForm = new Kitap_Düzenle();
                KitapDüzenleForm.MdiParent = this;
                KitapDüzenleForm.Show();
                KitapDüzenle = true;
            }
            else
            {
                KitapDüzenleForm.Close();
                KitapDüzenle = false;
            }
        }

        private void Kitapİşlembtn_Click(object sender, EventArgs e)
        {
            if (ÖdünçVerbtn.Visible==false)
            {
                ÖdünçVerbtn.Visible = true;
                GeriAlbtn.Visible = true;
                Takipbtn.Visible = true;
            }
            else
            {
                ÖdünçVerbtn.Visible = false;
                GeriAlbtn.Visible = false;
                Takipbtn.Visible = false;
            }
        }

        Ödünç_Ver ÖdünçVerForm;
        bool ÖdünçVer = false;

        private void ÖdünçVerbtn_Click(object sender, EventArgs e)
        {
            if (ÖdünçVer == false)
            {
                ÖdünçVerForm = new Ödünç_Ver();
                ÖdünçVerForm.MdiParent = this;
                ÖdünçVerForm.Show();
                ÖdünçVer = true;
            }
            else
            {
                ÖdünçVerForm.Close();
                ÖdünçVer = false;
            }
        }

        Geri_Al GeriAlForm;
        bool GeriAl = false;

        private void GeriAlbtn_Click(object sender, EventArgs e)
        {
            if (GeriAl == false)
            {
                GeriAlForm = new Geri_Al();
                GeriAlForm.MdiParent = this;
                GeriAlForm.Show();
                GeriAl = true;
            }
            else
            {
                GeriAlForm.Close();
                GeriAl = false;
            }
        }

        private void Takipbtn_Click(object sender, EventArgs e)
        {
            Takip TakipEt = new Takip();
            TakipEt.MdiParent = this;
            TakipEt.Show();
        }
    }
}
