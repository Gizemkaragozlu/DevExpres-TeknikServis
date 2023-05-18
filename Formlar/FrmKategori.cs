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
    public partial class FrmKategori : Form
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmKategori_Load(object sender, EventArgs e)
        {
            // var degerler = db.TBLKATEGORI.ToList();
            var degerler = from k in db.TBLKATEGORI  // FrmKategori gridControl1 de tblkategori tablomdan sadece ID ve AD listele
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            TBLKATEGORI t = new TBLKATEGORI();
            t.AD = TxtAd.Text;
            db.TBLKATEGORI.Add(t);
            db.SaveChanges();
            MessageBox.Show("Kategori Başarıyla Kaydedildi");

        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            var degerler = from k in db.TBLKATEGORI  // FrmKategori gridControl1 de tblkategori tablomdan sadece ID ve AD listele
                           select new
                           {
                               k.ID,
                               k.AD
                           };
            gridControl1.DataSource = degerler.ToList();
        }

        private void simpleSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text); //id hafızaya al.
            var deger = db.TBLKATEGORI.Find(id); // TBLKATEGORI içerisinde id bul.
            db.TBLKATEGORI.Remove(deger); //TBLKATEGORI tablomdan degerleri(id) kaldır.
            db.SaveChanges(); //değişiklikleri kaydet.
            MessageBox.Show("Kategori başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void TxtId_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e) //Kategori listesine tıkladığımda griddeki alanıma yansıt.
        {
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
        }

        private void groupControl4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLKATEGORI.Find(id);
            deger.AD = TxtAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
