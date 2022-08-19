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
    public partial class Geri_Al : Form
    {
        public Geri_Al()
        {
            InitializeComponent();
        }

        Kütüphane_OtomasyonuEntities db = new Kütüphane_OtomasyonuEntities();

        private void Geri_Al_Load(object sender, EventArgs e)
        {
            var ÖdünçKitap = db.ÖdünçKitaplar.Where(x => x.GeriVerildiMi == false).ToList();
            dataGridView1.DataSource = ÖdünçKitap.ToList(); 
        }

        private void İadeEtbtn_Click(object sender, EventArgs e)
        {
            int SeçilenKitapId = Convert.ToInt32( dataGridView1.CurrentRow.Cells[0].Value);
            var Kitap = db.ÖdünçKitaplar.Where(x => x.ÖdünçId == SeçilenKitapId).FirstOrDefault();
            Kitap.GeriVerildiMi = true;
            db.SaveChanges();
            var ÖdünçKitap = db.ÖdünçKitaplar.Where(x => x.GeriVerildiMi == false).ToList();
            dataGridView1.DataSource = ÖdünçKitap.ToList();
            

        }
    }
}
