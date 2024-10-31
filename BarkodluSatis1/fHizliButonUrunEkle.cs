using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis1
{
    public partial class fHizliButonUrunEkle : Form
    {
        public fHizliButonUrunEkle()
        {
            InitializeComponent();
        }

        Database1Entities db=new Database1Entities();

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            if(tUrunAra.Text != "")
            {
                string urunad=tUrunAra.Text;
                var urunler=db.Urun.Where(a=> a.UrunAd.Contains(urunad)).ToList();
                gridUrunler.DataSource = urunler;
                Islemler.GridDuzenle(gridUrunler);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gridUrunler_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(gridUrunler.Rows.Count>0)                                                                       //grid ürünlerin satır sayısı sıfırdan farklı ise
            {
                string barkod = gridUrunler.CurrentRow.Cells["Barkod"].Value.ToString();
                string urunad = gridUrunler.CurrentRow.Cells["UrunAd"].Value.ToString();
                double fiyat =Convert.ToDouble(gridUrunler.CurrentRow.Cells["SatisFiyat"].Value.ToString());

                int id=Convert.ToInt16(lButonId.Text);                                                            //Hızlı butona eklenen ürünler hızlıbuton tablosuna ekleme
                var guncellenecek = db.HizliUrun.Find(id);
                guncellenecek.Barkod = barkod;
                guncellenecek.UrunAd = urunad;
                guncellenecek.Fiyat = fiyat;
                db.SaveChanges();
                MessageBox.Show("Buton Başarıyla Güncellendi");
                fSatis f = (fSatis)Application.OpenForms["fSatis"];
                if(f != null)
                {
                    Button b = f.Controls.Find("bH" + id, true).FirstOrDefault() as Button;                       //Butona tanımlanan yeni ürün olduğunda butonun text ini değiştirir
                    b.Text = urunad + "\n" + fiyat.ToString("C2");
                }
            }
        }

        private void chTumu_CheckedChanged(object sender, EventArgs e)
        {
            if (chTumu.Checked)
            {
                gridUrunler.DataSource = db.Urun.ToList();
                gridUrunler.Columns["AlisFiyat"].Visible = false;
                gridUrunler.Columns["SatisFiyat"].Visible = false;
                gridUrunler.Columns["KdvOrani"].Visible = false;
                gridUrunler.Columns["KdvTutari"].Visible = false;
                gridUrunler.Columns["Miktar"].Visible = false;

                Islemler.GridDuzenle(gridUrunler);
            }
            else
            {
                gridUrunler.DataSource = null;
            }

        }

        private void fHizliButonUrunEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
