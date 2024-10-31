using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis1
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }

        private void Temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEposta.Clear();
            tKullanici.Clear();
            tSifre.Clear();
            tSifreTekrar.Clear();
            chSatisEkrani.Checked = false;
            chRapor.Checked = false;
            chStok.Checked = false;
            chUrunGiris.Checked = false;
            chAyarlar.Checked = false;
            chFiyatGuncelle.Checked = false;
            chYedekle.Checked = false;
        }
        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullanici.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new Database1Entities())
                            {
                                if (!db.Kullanici.Any(x => x.KullaniciAd == tKullanici.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.EPosta = tEposta.Text;
                                    k.KullaniciAd = tKullanici.Text;
                                    k.Sifre = tSifre.Text;
                                    k.Satis = chSatisEkrani.Checked;
                                    k.Rapor = chRapor.Checked;
                                    k.Stok = chStok.Checked;
                                    k.UrunGiris = chUrunGiris.Checked;
                                    k.Ayarlar = chAyarlar.Checked;
                                    k.FiyatGuncelle = chFiyatGuncelle.Checked;
                                    k.Yedekleme = chYedekle.Checked;
                                    db.Kullanici.Add(k);
                                    db.SaveChanges();
                                    Doldur();
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu Kullanıcı Kayıtlı");

                                }
                            }
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("Beklenmedik Bir Hata Oluştu");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Farklı! Lütfen İki Şifreyi de Aynı Giriniz");
                    }

                }
                else
                {
                    MessageBox.Show("Lütfen Zorunlu Alanları Doldurun");
                }



            }
            else if (bKaydet.Text == "Düzenle/Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullanici.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lKullaniciId.Text);
                        using (var db = new Database1Entities())
                        {
                            var guncelle = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = tTelefon.Text;
                            guncelle.EPosta = tEposta.Text;
                            guncelle.KullaniciAd = tKullanici.Text;
                            guncelle.Sifre = tSifre.Text;
                            guncelle.Satis = chSatisEkrani.Checked;
                            guncelle.Rapor = chRapor.Checked;
                            guncelle.Stok = chStok.Checked;
                            guncelle.UrunGiris = chUrunGiris.Checked;
                            guncelle.Ayarlar = chAyarlar.Checked;
                            guncelle.FiyatGuncelle = chFiyatGuncelle.Checked;
                            guncelle.Yedekleme = chYedekle.Checked;
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapılmıştır");
                            bKaydet.Text = "Kaydet";
                            Temizle();
                            Doldur();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Şifreler Farklı");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen zorunlu alanları doldurunuz.");
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListeKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListeKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullaniciId.Text = id.ToString();
                using (var db = new Database1Entities())
                {
                    var getir = db.Kullanici.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEposta.Text = getir.EPosta;
                    tKullanici.Text = getir.KullaniciAd;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    chSatisEkrani.Checked = (bool)getir.Satis;
                    chRapor.Checked = (bool)getir.Rapor;
                    chStok.Checked = (bool)getir.Stok;
                    chUrunGiris.Checked = (bool)getir.UrunGiris;
                    chAyarlar.Checked = (bool)getir.Ayarlar;
                    chFiyatGuncelle.Checked = (bool)getir.FiyatGuncelle;
                    bKaydet.Text = "Düzenle/Kaydet";
                    Doldur();
                }

            }
            else
            {
                MessageBox.Show("Kullanıcı Seçiniz!");
            }
        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            
            Cursor.Current = Cursors.Default;

        }
        private void Doldur()
        {

            using (var db = new Database1Entities())
            {
                if (db.Kullanici.Any())
                {
                    gridListeKullanici.DataSource = db.Kullanici.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAd, x.Telefon }).ToList();
                   
                }
                Islemler.SabitVarsayilan();
                var yazici = db.Sabit.FirstOrDefault();
                chYazmaDurumu.Checked = Convert.ToBoolean(yazici.Yazici);    
                var sabitler=db.Sabit.FirstOrDefault();
                tKartKomisyon.Text = sabitler.KartKomisyon.ToString();

                var terazionek = db.Terazii.ToList();
                cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                cmbTeraziOnEk.ValueMember = "Id";
                cmbTeraziOnEk.DataSource=terazionek;

                tIsyeriAdSoyad.Text = sabitler.AdSoyad;
                tIsyeriUnvan.Text = sabitler.Unvan;
                tIsyeriAdres.Text=sabitler.Adres;
                tIsyeriTelefon.Text=sabitler.Telefon;
                tIsyeriEposta.Text = sabitler.Eposta;
            }
        }

        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new Database1Entities())
            {
                if (chYazmaDurumu.Checked)
                {

                    Islemler.SabitVarsayilan();
                    var ayarla = db.Sabit.FirstOrDefault();
                    ayarla.Yazici = true;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Aktif";


                }
                else
                {
                    Islemler.SabitVarsayilan();
                    var ayarlar = db.Sabit.FirstOrDefault();
                    ayarlar.Yazici = false;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Pasif";
                }
            }
        }

        private void bKartKomisyonAyarla_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text !="")
            {
                using (var db=new Database1Entities())
                {
                    var sabit =db.Sabit.FirstOrDefault();
                    sabit.KartKomisyon=Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges();
                    MessageBox.Show("Kart komisyon başarıyla ayarlandı");
                }
            }
            else
            {
                MessageBox.Show("Kart komisyon bilgisi giriniz");
            }
        }

        private void bTeraziOnEkKaydet_Click(object sender, EventArgs e)
        {
            if (tTeraziOnEk.Text!="")
            {
                int onek = Convert.ToInt16(tTeraziOnEk.Text);
                using (var db=new Database1Entities())
                {
                    if (db.Terazii.Any(x=>x.TeraziOnEk==onek))
                    {
                        MessageBox.Show(onek.ToString() + "Girdiğiniz önek kayıtlı");
                    }
                    else
                    {
                        Terazii t = new Terazii();                                        //Terazi önekini liste olarak doldur
                        t.TeraziOnEk = onek;
                        db.Terazii.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler başarıyla kaydedildi");
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazii.ToList();
                        tTeraziOnEk.Clear();
                    }
                }
            }
            MessageBox.Show("Terazi önek bilgisi giriniz");
        }

        private void bTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (cmbTeraziOnEk.Text!="")
            {
                int onekid = Convert.ToInt16(cmbTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbTeraziOnEk.Text + " Öneki silmek istediğinize emin misiniz?","Terazi Önek Silme İşlemi",MessageBoxButtons.YesNo);
                if(onay==DialogResult.Yes)
                {
                    using(var db=new Database1Entities())
                    {
                        var onek=db.Terazii.Find(onekid);
                        db.Terazii.Remove(onek);
                        db.SaveChanges();
                        cmbTeraziOnEk.DisplayMember = "TeraziOnEk";
                        cmbTeraziOnEk.ValueMember= "Id";
                        cmbTeraziOnEk.DataSource=db.Terazii.ToList();
                        MessageBox.Show("Önek başarıyla silinmiştir");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen önek seçiniz");
            }
        }

        private void bIsyeriKaydet_Click(object sender, EventArgs e)
        {
            if (tIsyeriAdSoyad.Text!="" && tIsyeriUnvan.Text!="" && tIsyeriAdres.Text!=""&& tIsyeriTelefon.Text!="")
            {
                using(var db=new Database1Entities())
                {
                    var isyeri = db.Sabit.FirstOrDefault();
                    isyeri.AdSoyad = tIsyeriAdSoyad.Text;
                    isyeri.Unvan = tIsyeriUnvan.Text;
                    isyeri.Adres = tIsyeriAdres.Text;
                    isyeri.Telefon = tIsyeriTelefon.Text;
                    isyeri.Eposta=tIsyeriEposta.Text;
                    db.SaveChanges();
                    MessageBox.Show("Bilgiler başarıyla kaydedilmiştir");
                    var yeni=db.Sabit.FirstOrDefault();
                    tIsyeriAdSoyad.Text=yeni.AdSoyad;
                    tIsyeriUnvan.Text = yeni.Unvan;
                    tIsyeriAdres.Text=yeni.Adres;
                    tIsyeriTelefon.Text = yeni.Telefon;
                    tIsyeriEposta.Text=yeni.Eposta;
                }
            }
        }

        private void bYedektenYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }

        private void chFiyatGuncelle_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
