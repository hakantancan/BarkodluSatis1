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
    public partial class fUrunGrubuEkle : Form
    {
        public fUrunGrubuEkle()
        {
            InitializeComponent();
        }
        Database1Entities db=new Database1Entities();
        private void fUrunGrubuEkle_Load(object sender, EventArgs e)     //Ürün Grup Ekle Formu
        {
            GrupDoldur();

        }

        private void bEkle_Click(object sender, EventArgs e)              //ekle butonuna basıldığında yapılacak işlemler
        {
            if (tUrunGrupAd.Text!="")
            {
                UrunGrup ug = new UrunGrup();
                ug.UrunGrupAd=tUrunGrupAd.Text;
                db.UrunGrup.Add(ug);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Clear();
                MessageBox.Show("Eklenmiştir");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                if (f != null)
                {
                    f.GrupDoldur();
                }
                

            }
            else
            {
                MessageBox.Show("Eklenmemiştir");
            }
        }
        private void GrupDoldur()                         //Ürün adı ve ıd ekleme
        {
            listUrunGrup.DisplayMember = "UrunGrupAd";
            listUrunGrup.ValueMember = "Id";
            listUrunGrup.DataSource = db.UrunGrup.OrderBy(a => a.UrunGrupAd).ToList();
        }

        private void bSil_Click(object sender, EventArgs e)
        {
            int grupid = Convert.ToInt32(listUrunGrup.SelectedValue.ToString());
            string grupad = listUrunGrup.Text;
            DialogResult onay = MessageBox.Show(grupad + "Silmek istiyormusunuz?", "Silme işlemi", MessageBoxButtons.YesNo);
            if(onay == DialogResult.Yes)
            {
                var grup = db.UrunGrup.FirstOrDefault(x => x.Id == grupid);
                db.UrunGrup.Remove(grup);
                db.SaveChanges();
                GrupDoldur();
                tUrunGrupAd.Focus();
                MessageBox.Show(grupad + "Ürün grubu başarıyla silindi!");
                fUrunGiris f = (fUrunGiris)Application.OpenForms["fUrunGiris"];
                f.GrupDoldur();

            }
      }
    }
}
