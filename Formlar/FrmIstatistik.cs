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
    public partial class FrmIstatistik : Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }
        DbTeknikServisEntities db = new DbTeknikServisEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            //LINQ SORGULARI ILE ISTATISTIK CEKME
            labelControl2.Text = db.TBLURUN.Count().ToString();// Toplam Ürün Sayısı

            labelControl3.Text = db.TBLKATEGORI.Count().ToString();//Toplam Kategori Sayısı

            labelControl5.Text = db.TBLURUN.Sum(x => x.STOK).ToString(); //Tblurun içindeki değerleri topla x modda stok değerleri topla

            labelControl7.Text = "10"; //Kritik seviye

            labelControl11.Text = (from x in db.TBLURUN   
                                   orderby x.SATISFIYAT ascending // En düşük fiyatlı ürün
                                   select x.AD).FirstOrDefault();

            labelControl13.Text = (from X in db.TBLURUN  
                                   orderby X.SATISFIYAT descending // En yüksek fiyatlı ürün
                                   select X.AD).FirstOrDefault();

            labelControl15.Text = (from X in db.TBLURUN  
                                   orderby X.KATEGORI descending // En fazla ürün kategorisi
                                   select X.AD).FirstOrDefault();

            labelControl19.Text = (from X in db.TBLURUN 
                                   orderby X.STOK descending // En fazla stoklu ürün
                                   select X.AD).FirstOrDefault();

            labelControl17.Text = (from x in db.TBLURUN
                                   orderby x.STOK ascending // En az stoklu ürünü verir
                                   select x.AD).FirstOrDefault();

            labelControl25.Text = db.TBLURUN.Count(x => x.KATEGORI == 4).ToString();//tblurun 4 olan değeri say ve string olarak getir.

            labelControl23.Text = db.TBLURUN.Count(x => x.KATEGORI == 1).ToString();

            labelControl21.Text = db.TBLURUN.Count(x => x.KATEGORI == 3).ToString();

            labelControl39.Text = (from x in db.TBLURUN
                                   select x.MARKA).Distinct().Count().ToString();


        }

    }
}
