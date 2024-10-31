using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis1
{
    public partial class fStok : Form
    {
        public fStok()
        {
            InitializeComponent();
        }

        private void lStandart2_Click(object sender, EventArgs e)
        {

        }

        private void bStandart1_Click(object sender, EventArgs e)                         //Butona basıldığında ürünleri listeleme
        {
            gridListe.DataSource = null;
            using (var db=new Database1Entities())
            {
                if (cmbIslemTuru.Text != "")
                {
                    string urungrubu=cmbUrunGrubu.Text;
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        if (rdTumu.Checked)
                        {
                            db.Urun.OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();
                        }
                        else if(rdUrunGrubunaGore.Checked)
                        {
                            db.Urun.Where(x => x.UrunGrup == urungrubu).OrderBy(x => x.Miktar).Load();
                            gridListe.DataSource = db.Urun.Local.ToBindingList();

                        }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz");
                        }
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                        {
                            DateTime baslangic = DateTime.Parse(dateBaslangic.Value.ToShortDateString());
                            DateTime bitis = DateTime.Parse(dateBitisTarihi.Value.ToShortDateString());
                            bitis = bitis.AddDays(1);
                            if (rdTumu.Checked)
                            {
                                db.StokHareket.OrderByDescending(x=>x.Tarih).Where(x=>x.Tarih>=baslangic&&x.Tarih<=bitis).Load();
                                gridListe.DataSource=db.StokHareket.Local.ToBindingList();
                            }
                            else if(rdUrunGrubunaGore.Checked)
                            {
                                db.StokHareket.OrderByDescending(x => x.Tarih).Where(x => x.Tarih >= baslangic && x.Tarih <= bitis && x.UrunGrup.Contains(urungrubu)).Load();
                                gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                            }
                        else
                        {
                            MessageBox.Show("Lütfen Filtreleme Türünü Seçiniz");
                        }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Lütfen İşlem Türünü Seçiniz.");
                    }
                }
            Islemler.GridDuzenle(gridListe);
            }
        

        Database1Entities dbx=new Database1Entities();
        private void fStok_Load(object sender, EventArgs e)            // Ürün grubunu çekme
        {
            cmbUrunGrubu.DisplayMember="UrunGrupAd";
            cmbUrunGrubu.ValueMember = "Id";
            cmbUrunGrubu.DataSource = dbx.UrunGrup.ToList();
        }

        private void tUrunAra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tUrunAraa_TextChanged(object sender, EventArgs e)
        {

        }

        private void tUrunAraaa_TextChanged(object sender, EventArgs e)
        {
            if (tUrunAraaa.Text.Length >= 3)
            {
                string urunad = tUrunAraaa.Text;
                using (var db = new Database1Entities())
                {
                    if (cmbIslemTuru.SelectedIndex == 0)
                    {
                        db.Urun.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.Urun.Local.ToBindingList();
                    }
                    else if (cmbIslemTuru.SelectedIndex == 1)
                    {
                        db.StokHareket.Where(x => x.UrunAd.Contains(urunad)).Load();
                        gridListe.DataSource = db.StokHareket.Local.ToBindingList();
                    }
                }
                Islemler.GridDuzenle(gridListe);
            }
        }

        private void bRaporAl_Click(object sender, EventArgs e)
        {

            if (cmbIslemTuru.SelectedIndex==0)
            { 
            Raporlar.Baslik = cmbIslemTuru.Text + "RAPORU";
            Raporlar.TarihBaslangic=dateBaslangic.Value.ToShortDateString();
            Raporlar.TarihBitis=dateBitisTarihi.Value.ToShortDateString();
            Raporlar.StokIzlemeRaporu(gridListe);

            }
            else if (cmbIslemTuru.SelectedIndex==1)
            {
                Raporlar.Baslik = cmbIslemTuru.Text + "RAPORU";
                Raporlar.TarihBaslangic = dateBaslangic.Value.ToShortDateString();
                Raporlar.TarihBitis = dateBitisTarihi.Value.ToShortDateString();
                Raporlar.StokIzlemeRaporu(gridListe);

            }

        }
    }
}
