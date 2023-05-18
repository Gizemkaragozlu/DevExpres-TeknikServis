using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeknikServis.Formlar
{
    public partial class FrmYeniUrun : Form
    {
        public FrmYeniUrun()
        {
            InitializeComponent();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void FrmYeniUrun_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnVazgec_Click(object sender, EventArgs e)
        {
            //FrmYeniUrun fr = new FrmYeniUrun();
            //fr.Close(); // Vazgeç butonuna basınca ekranımı gösterme
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            DbTeknikServisEntities db = new DbTeknikServisEntities();
            TBLURUN t = new TBLURUN();
            t.AD = TxtUrunAd.Text;
            t.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            t.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            t.STOK = short.Parse(TxtStok.Text);
            t.KATEGORI = byte.Parse(TxtKategotri.Text);
            t.MARKA = TxtMarka.Text;
            db.TBLURUN.Add(t);
            db.SaveChanges();
            MessageBox.Show("Ürünler Başarıyla Kaydedildi");
        }
    }
}
