using Kutuphane.BLL;
using Kutuphane.EntityLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kutuphane.PresentationLayer
{
    public partial class frmKITAP : Form
    {
        public frmKITAP()
        {
            InitializeComponent();
        }

        private void frmKITAP_Load(object sender, EventArgs e)
        {
            KitapListele();
            KategoriListele();// ekle-1
        }

        private void KategoriListele()// ekle-2
        {
            List<EKATEGORI> kategoriListesi = BLLKATEGORI.SelectList();// ekle-3
            //foreach (EKATEGORI item in kategoriListesi)// ekle-4
            //{
            //    txtKategori.Items.Add(item.ADI);// ekle-5
            //}

            txtKategori.DataSource = kategoriListesi;
            txtKategori.DisplayMember = "ADI";
            txtKategori.ValueMember = "ID";
        }

        private void KitapListele()
        {
            List<EKITAP> kitapListesi = BLLKITAP.SelectList();

            Liste.DataSource = kitapListesi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EKITAP kitapItem = new EKITAP();
            kitapItem.KATEGORIID = Convert.ToInt32(txtKategori.SelectedValue);
            kitapItem.SAYFASAYISI = short.Parse(txtSayfaSayisi.Text);
            kitapItem.ADI = txtKitapAdi.Text;
            kitapItem.YAZAR = txtYazar.Text;
            if (BLLKITAP.Insert(kitapItem)>0)
            {
                KitapListele();
                MessageBox.Show("Kitap ekleme işlemi başarılı");
            }
            else
            {
                MessageBox.Show("Kitap ekleme işlemi hatalı.HATA KODU:131564");
            }
        }
    }
}
