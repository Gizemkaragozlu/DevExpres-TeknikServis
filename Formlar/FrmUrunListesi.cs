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
    public partial class FrmUrunListesi : Form
    {
        public FrmUrunListesi()
        {
            InitializeComponent();
        }
        // veri tabanımızı bağladık db nesnesine atadık
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmUrunListesi_Load(object sender, EventArgs e)
        {
            loadDataGrid();

            var degerler = db.TBLURUN.ToList();
            LueKategori.Properties.DataSource = db.TBLKATEGORI.ToList();
            LueKategori.Properties.DataSource = db.TBLKATEGORI.ToList();
            LueKategori.Properties.DisplayMember = "AD";
            LueKategori.Properties.ValueMember = "ID";
            LueKategori.EditValue = 0;
           
        }

        void loadDataGrid()
        {
            //Ürün listeleme
            var degerler = db.TBLURUN.ToList(); //TblUrun datamı degerlere atayıp listelettik.
            gridControl1.DataSource = degerler; // degerleri yanı urunleri gridcontrole atadık.
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (TxtUrunAd.Text == "" || TxtMarka.Text == "" || TxtAlisFiyat.Text == "" || TxtSatisFiyat.Text == "" || TxtStok.Text == "" ) 
            {
                return;
            }
            TBLURUN tblKategori = new TBLURUN();
            tblKategori.AD = TxtUrunAd.Text;
            tblKategori.MARKA = TxtMarka.Text;
            tblKategori.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            tblKategori.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            tblKategori.STOK = short.Parse(TxtStok.Text);
            tblKategori.DURUM = false;
            tblKategori.KATEGORI = byte.Parse(LueKategori.EditValue.ToString());
            db.TBLURUN.Add(tblKategori); 
            db.SaveChanges(); //Değişikilikleri kaydet veri tabanıma yansıt
            MessageBox.Show("Ürün Başarıyla Kaydedildi", //Mesajın içeriği
                "Bilgi", // Başlık
                MessageBoxButtons.OK, //Buton
                MessageBoxIcon.Information); //İcon

            loadDataGrid();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
             loadDataGrid();
        }

        private void TxtUrunAd_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            //GridView'e otomatik gelmesini istediğimiz alanlar.
            TxtId.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtUrunAd.Text = gridView1.GetFocusedRowCellValue("AD").ToString();
            TxtMarka.Text = gridView1.GetFocusedRowCellValue("MARKA").ToString();
            TxtAlisFiyat.Text = gridView1.GetFocusedRowCellValue("ALISFIYAT").ToString();
            TxtSatisFiyat.Text = gridView1.GetFocusedRowCellValue("SATISFIYAT").ToString();
            TxtStok.Text = gridView1.GetFocusedRowCellValue("STOK").ToString();
            LueKategori.EditValue = gridView1.GetFocusedRowCellValue("KATEGORI");
            
            
        }

        private void simpleSil_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text); //id hafızaya al.
            var deger = db.TBLURUN.Find(id); // tblurun içerisinde id bul.
            db.TBLURUN.Remove(deger); //tblurun tablomdan degerleri(id) kaldır.
            db.SaveChanges(); //değişiklikleri kaydet.
            MessageBox.Show("Ürün başarıyla silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TxtId.Text);
            var deger = db.TBLURUN.Find(id);
            deger.AD = TxtUrunAd.Text; // id ye göre değil TxtUrunAd.Text e göre deger al.
            deger.STOK = short.Parse(TxtStok.Text);
            deger.MARKA = TxtMarka.Text;
            deger.ALISFIYAT = decimal.Parse(TxtAlisFiyat.Text);
            deger.SATISFIYAT = decimal.Parse(TxtSatisFiyat.Text);
            deger.KATEGORI = byte.Parse(LueKategori.EditValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void TxtId_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
