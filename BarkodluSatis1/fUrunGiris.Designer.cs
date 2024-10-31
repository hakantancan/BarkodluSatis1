namespace BarkodluSatis1
{
    partial class fUrunGiris
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fUrunGiris));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.chUrunTipi = new System.Windows.Forms.CheckBox();
            this.tAlisFiyati = new System.Windows.Forms.TextBox();
            this.tSatisFiyati = new System.Windows.Forms.TextBox();
            this.lKullanici = new BarkodluSatis1.lStandart();
            this.tUrunSayisi = new BarkodluSatis1.tNumeric();
            this.lStandart10 = new BarkodluSatis1.lStandart();
            this.tUrunAra = new BarkodluSatis1.tStandart();
            this.lStandart9 = new BarkodluSatis1.lStandart();
            this.bRaporAl = new BarkodluSatis1.bStandart();
            this.bKaydet = new BarkodluSatis1.bStandart();
            this.bIptal = new BarkodluSatis1.bStandart();
            this.bBarkodOluştur = new BarkodluSatis1.bStandart();
            this.bUrunGrubuEkle = new BarkodluSatis1.bStandart();
            this.tKDVOrani = new BarkodluSatis1.tNumeric();
            this.tMiktar = new BarkodluSatis1.tNumeric();
            this.lStandart8 = new BarkodluSatis1.lStandart();
            this.lStandart7 = new BarkodluSatis1.lStandart();
            this.lStandart6 = new BarkodluSatis1.lStandart();
            this.lStandart5 = new BarkodluSatis1.lStandart();
            this.tAciklama = new BarkodluSatis1.tStandart();
            this.tUrunAdi = new BarkodluSatis1.tStandart();
            this.tBarkod = new BarkodluSatis1.tStandart();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.lStandart4 = new BarkodluSatis1.lStandart();
            this.lStandart3 = new BarkodluSatis1.lStandart();
            this.lStandart2 = new BarkodluSatis1.lStandart();
            this.lStandart1 = new BarkodluSatis1.lStandart();
            this.gridUrunler = new BarkodluSatis1.gridOzel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.silToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.düzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.chUrunTipi);
            this.splitContainer1.Panel1.Controls.Add(this.tAlisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.tSatisFiyati);
            this.splitContainer1.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunSayisi);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart10);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAra);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart9);
            this.splitContainer1.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.bKaydet);
            this.splitContainer1.Panel1.Controls.Add(this.bIptal);
            this.splitContainer1.Panel1.Controls.Add(this.bBarkodOluştur);
            this.splitContainer1.Panel1.Controls.Add(this.bUrunGrubuEkle);
            this.splitContainer1.Panel1.Controls.Add(this.tKDVOrani);
            this.splitContainer1.Panel1.Controls.Add(this.tMiktar);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart8);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart7);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart6);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart5);
            this.splitContainer1.Panel1.Controls.Add(this.tAciklama);
            this.splitContainer1.Panel1.Controls.Add(this.tUrunAdi);
            this.splitContainer1.Panel1.Controls.Add(this.tBarkod);
            this.splitContainer1.Panel1.Controls.Add(this.cmbUrunGrubu);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart4);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart3);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart2);
            this.splitContainer1.Panel1.Controls.Add(this.lStandart1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridUrunler);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(971, 521);
            this.splitContainer1.SplitterDistance = 345;
            this.splitContainer1.TabIndex = 0;
            // 
            // chUrunTipi
            // 
            this.chUrunTipi.Appearance = System.Windows.Forms.Appearance.Button;
            this.chUrunTipi.AutoSize = true;
            this.chUrunTipi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chUrunTipi.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.chUrunTipi.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chUrunTipi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chUrunTipi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chUrunTipi.ForeColor = System.Drawing.Color.White;
            this.chUrunTipi.Location = new System.Drawing.Point(206, 15);
            this.chUrunTipi.Name = "chUrunTipi";
            this.chUrunTipi.Size = new System.Drawing.Size(175, 28);
            this.chUrunTipi.TabIndex = 21;
            this.chUrunTipi.Text = "Barkodlu Ürün İşlemi";
            this.chUrunTipi.UseVisualStyleBackColor = false;
            this.chUrunTipi.CheckedChanged += new System.EventHandler(this.chUrunTipi_CheckedChanged);
            // 
            // tAlisFiyati
            // 
            this.tAlisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tAlisFiyati.Location = new System.Drawing.Point(646, 15);
            this.tAlisFiyati.Name = "tAlisFiyati";
            this.tAlisFiyati.Size = new System.Drawing.Size(119, 30);
            this.tAlisFiyati.TabIndex = 4;
            this.tAlisFiyati.Text = "0";
            this.tAlisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tAlisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // tSatisFiyati
            // 
            this.tSatisFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tSatisFiyati.Location = new System.Drawing.Point(646, 54);
            this.tSatisFiyati.Name = "tSatisFiyati";
            this.tSatisFiyati.Size = new System.Drawing.Size(119, 30);
            this.tSatisFiyati.TabIndex = 5;
            this.tSatisFiyati.Text = "0";
            this.tSatisFiyati.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tSatisFiyati.TextChanged += new System.EventHandler(this.tSatisFiyati_TextChanged);
            this.tSatisFiyati.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tSatisFiyati_KeyPress);
            // 
            // lKullanici
            // 
            this.lKullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(798, 9);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(112, 25);
            this.lKullanici.TabIndex = 20;
            this.lKullanici.Text = "lStandart11";
            // 
            // tUrunSayisi
            // 
            this.tUrunSayisi.BackColor = System.Drawing.Color.White;
            this.tUrunSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunSayisi.Location = new System.Drawing.Point(645, 268);
            this.tUrunSayisi.Name = "tUrunSayisi";
            this.tUrunSayisi.ReadOnly = true;
            this.tUrunSayisi.Size = new System.Drawing.Size(119, 30);
            this.tUrunSayisi.TabIndex = 8;
            this.tUrunSayisi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lStandart10
            // 
            this.lStandart10.AutoSize = true;
            this.lStandart10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart10.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart10.Location = new System.Drawing.Point(505, 273);
            this.lStandart10.Name = "lStandart10";
            this.lStandart10.Size = new System.Drawing.Size(112, 25);
            this.lStandart10.TabIndex = 18;
            this.lStandart10.Text = "Ürün Sayısı";
            // 
            // tUrunAra
            // 
            this.tUrunAra.BackColor = System.Drawing.Color.White;
            this.tUrunAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAra.Location = new System.Drawing.Point(163, 302);
            this.tUrunAra.Name = "tUrunAra";
            this.tUrunAra.Size = new System.Drawing.Size(250, 30);
            this.tUrunAra.TabIndex = 14;
            this.tUrunAra.TextChanged += new System.EventHandler(this.tUrunAra_TextChanged);
            // 
            // lStandart9
            // 
            this.lStandart9.AutoSize = true;
            this.lStandart9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart9.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart9.Location = new System.Drawing.Point(47, 308);
            this.lStandart9.Name = "lStandart9";
            this.lStandart9.Size = new System.Drawing.Size(90, 25);
            this.lStandart9.TabIndex = 16;
            this.lStandart9.Text = "Ürün Ara";
            // 
            // bRaporAl
            // 
            this.bRaporAl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.bRaporAl.BackColor = System.Drawing.Color.SteelBlue;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRaporAl.ForeColor = System.Drawing.Color.White;
            this.bRaporAl.Image = ((System.Drawing.Image)(resources.GetObject("bRaporAl.Image")));
            this.bRaporAl.Location = new System.Drawing.Point(803, 49);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(154, 190);
            this.bRaporAl.TabIndex = 13;
            this.bRaporAl.Text = "Rapor";
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            // 
            // bKaydet
            // 
            this.bKaydet.BackColor = System.Drawing.Color.SteelBlue;
            this.bKaydet.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bKaydet.ForeColor = System.Drawing.Color.White;
            this.bKaydet.Image = ((System.Drawing.Image)(resources.GetObject("bKaydet.Image")));
            this.bKaydet.Location = new System.Drawing.Point(645, 181);
            this.bKaydet.Margin = new System.Windows.Forms.Padding(1);
            this.bKaydet.Name = "bKaydet";
            this.bKaydet.Size = new System.Drawing.Size(124, 83);
            this.bKaydet.TabIndex = 10;
            this.bKaydet.Text = "Kaydet";
            this.bKaydet.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bKaydet.UseVisualStyleBackColor = false;
            this.bKaydet.Click += new System.EventHandler(this.bKaydet_Click);
            // 
            // bIptal
            // 
            this.bIptal.BackColor = System.Drawing.Color.SteelBlue;
            this.bIptal.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bIptal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bIptal.ForeColor = System.Drawing.Color.White;
            this.bIptal.Image = ((System.Drawing.Image)(resources.GetObject("bIptal.Image")));
            this.bIptal.Location = new System.Drawing.Point(515, 181);
            this.bIptal.Margin = new System.Windows.Forms.Padding(1);
            this.bIptal.Name = "bIptal";
            this.bIptal.Size = new System.Drawing.Size(124, 83);
            this.bIptal.TabIndex = 9;
            this.bIptal.Text = "İptal";
            this.bIptal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bIptal.UseVisualStyleBackColor = false;
            this.bIptal.Click += new System.EventHandler(this.bIptal_Click);
            // 
            // bBarkodOluştur
            // 
            this.bBarkodOluştur.BackColor = System.Drawing.Color.SteelBlue;
            this.bBarkodOluştur.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bBarkodOluştur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBarkodOluştur.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bBarkodOluştur.ForeColor = System.Drawing.Color.White;
            this.bBarkodOluştur.Image = ((System.Drawing.Image)(resources.GetObject("bBarkodOluştur.Image")));
            this.bBarkodOluştur.Location = new System.Drawing.Point(288, 215);
            this.bBarkodOluştur.Margin = new System.Windows.Forms.Padding(1);
            this.bBarkodOluştur.Name = "bBarkodOluştur";
            this.bBarkodOluştur.Size = new System.Drawing.Size(125, 83);
            this.bBarkodOluştur.TabIndex = 11;
            this.bBarkodOluştur.Text = "Barkod Oluştur";
            this.bBarkodOluştur.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bBarkodOluştur.UseVisualStyleBackColor = false;
            this.bBarkodOluştur.Click += new System.EventHandler(this.bBarkodOluştur_Click);
            // 
            // bUrunGrubuEkle
            // 
            this.bUrunGrubuEkle.BackColor = System.Drawing.Color.SteelBlue;
            this.bUrunGrubuEkle.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bUrunGrubuEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUrunGrubuEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bUrunGrubuEkle.ForeColor = System.Drawing.Color.White;
            this.bUrunGrubuEkle.Image = ((System.Drawing.Image)(resources.GetObject("bUrunGrubuEkle.Image")));
            this.bUrunGrubuEkle.Location = new System.Drawing.Point(163, 215);
            this.bUrunGrubuEkle.Margin = new System.Windows.Forms.Padding(1);
            this.bUrunGrubuEkle.Name = "bUrunGrubuEkle";
            this.bUrunGrubuEkle.Size = new System.Drawing.Size(123, 83);
            this.bUrunGrubuEkle.TabIndex = 12;
            this.bUrunGrubuEkle.Text = "Ürün Grubu Ekle";
            this.bUrunGrubuEkle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bUrunGrubuEkle.UseVisualStyleBackColor = false;
            this.bUrunGrubuEkle.Click += new System.EventHandler(this.bUrunGrubuEkle_Click);
            // 
            // tKDVOrani
            // 
            this.tKDVOrani.BackColor = System.Drawing.Color.White;
            this.tKDVOrani.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tKDVOrani.Location = new System.Drawing.Point(645, 132);
            this.tKDVOrani.Name = "tKDVOrani";
            this.tKDVOrani.Size = new System.Drawing.Size(119, 30);
            this.tKDVOrani.TabIndex = 7;
            this.tKDVOrani.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tMiktar
            // 
            this.tMiktar.BackColor = System.Drawing.Color.White;
            this.tMiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tMiktar.Location = new System.Drawing.Point(645, 93);
            this.tMiktar.Name = "tMiktar";
            this.tMiktar.Size = new System.Drawing.Size(119, 30);
            this.tMiktar.TabIndex = 6;
            this.tMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tMiktar.TextChanged += new System.EventHandler(this.tMiktar_TextChanged);
            // 
            // lStandart8
            // 
            this.lStandart8.AutoSize = true;
            this.lStandart8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart8.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart8.Location = new System.Drawing.Point(510, 135);
            this.lStandart8.Name = "lStandart8";
            this.lStandart8.Size = new System.Drawing.Size(107, 25);
            this.lStandart8.TabIndex = 11;
            this.lStandart8.Text = "KDV Oranı";
            // 
            // lStandart7
            // 
            this.lStandart7.AutoSize = true;
            this.lStandart7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart7.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart7.Location = new System.Drawing.Point(552, 96);
            this.lStandart7.Name = "lStandart7";
            this.lStandart7.Size = new System.Drawing.Size(65, 25);
            this.lStandart7.TabIndex = 10;
            this.lStandart7.Text = "Miktar";
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(510, 59);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(107, 25);
            this.lStandart6.TabIndex = 9;
            this.lStandart6.Text = "Satış Fiyatı";
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart5.Location = new System.Drawing.Point(522, 18);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(95, 25);
            this.lStandart5.TabIndex = 8;
            this.lStandart5.Text = "Alış Fiyatı";
            // 
            // tAciklama
            // 
            this.tAciklama.BackColor = System.Drawing.Color.White;
            this.tAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tAciklama.Location = new System.Drawing.Point(163, 125);
            this.tAciklama.Name = "tAciklama";
            this.tAciklama.Size = new System.Drawing.Size(250, 30);
            this.tAciklama.TabIndex = 2;
            // 
            // tUrunAdi
            // 
            this.tUrunAdi.BackColor = System.Drawing.Color.White;
            this.tUrunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAdi.Location = new System.Drawing.Point(163, 88);
            this.tUrunAdi.Name = "tUrunAdi";
            this.tUrunAdi.Size = new System.Drawing.Size(250, 30);
            this.tUrunAdi.TabIndex = 1;
            // 
            // tBarkod
            // 
            this.tBarkod.BackColor = System.Drawing.Color.White;
            this.tBarkod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tBarkod.Location = new System.Drawing.Point(163, 52);
            this.tBarkod.Name = "tBarkod";
            this.tBarkod.Size = new System.Drawing.Size(250, 30);
            this.tBarkod.TabIndex = 0;
            this.tBarkod.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tBarkod_KeyDown);
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(163, 161);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(250, 33);
            this.cmbUrunGrubu.TabIndex = 3;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart4.Location = new System.Drawing.Point(26, 169);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(113, 25);
            this.lStandart4.TabIndex = 3;
            this.lStandart4.Text = "Ürün Grubu";
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart3.Location = new System.Drawing.Point(47, 130);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(92, 25);
            this.lStandart3.TabIndex = 2;
            this.lStandart3.Text = "Açıklama";
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart2.Location = new System.Drawing.Point(51, 93);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(88, 25);
            this.lStandart2.TabIndex = 1;
            this.lStandart2.Text = "Ürün Adı";
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart1.Location = new System.Drawing.Point(65, 57);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(74, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "Barkod";
            // 
            // gridUrunler
            // 
            this.gridUrunler.AllowUserToAddRows = false;
            this.gridUrunler.AllowUserToDeleteRows = false;
            this.gridUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUrunler.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridUrunler.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridUrunler.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridUrunler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUrunler.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUrunler.EnableHeadersVisualStyles = false;
            this.gridUrunler.Location = new System.Drawing.Point(0, 0);
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.ReadOnly = true;
            this.gridUrunler.RowHeadersVisible = false;
            this.gridUrunler.RowHeadersWidth = 51;
            this.gridUrunler.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridUrunler.RowTemplate.ContextMenuStrip = this.contextMenuStrip1;
            this.gridUrunler.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridUrunler.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridUrunler.RowTemplate.Height = 30;
            this.gridUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUrunler.Size = new System.Drawing.Size(971, 172);
            this.gridUrunler.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.silToolStripMenuItem,
            this.düzenleToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(133, 52);
            // 
            // silToolStripMenuItem
            // 
            this.silToolStripMenuItem.Name = "silToolStripMenuItem";
            this.silToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.silToolStripMenuItem.Text = "Sil";
            this.silToolStripMenuItem.Click += new System.EventHandler(this.silToolStripMenuItem_Click);
            // 
            // düzenleToolStripMenuItem
            // 
            this.düzenleToolStripMenuItem.Name = "düzenleToolStripMenuItem";
            this.düzenleToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.düzenleToolStripMenuItem.Text = "Düzenle";
            this.düzenleToolStripMenuItem.Click += new System.EventHandler(this.düzenleToolStripMenuItem_Click);
            // 
            // fUrunGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(971, 521);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fUrunGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Giriş";
            this.Load += new System.EventHandler(this.fUrunGiris_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private tStandart tAciklama;
        private tStandart tUrunAdi;
        private lStandart lStandart4;
        private lStandart lStandart3;
        private lStandart lStandart2;
        private lStandart lStandart1;
        private tNumeric tKDVOrani;
        private tNumeric tMiktar;
        private lStandart lStandart8;
        private lStandart lStandart7;
        private lStandart lStandart6;
        private lStandart lStandart5;
        private bStandart bRaporAl;
        private bStandart bKaydet;
        private bStandart bIptal;
        private bStandart bBarkodOluştur;
        private bStandart bUrunGrubuEkle;
        private tNumeric tUrunSayisi;
        private lStandart lStandart10;
        private tStandart tUrunAra;
        private lStandart lStandart9;
        private gridOzel gridUrunler;
        internal tStandart tBarkod;
        internal lStandart lKullanici;
        public System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.TextBox tSatisFiyati;
        private System.Windows.Forms.TextBox tAlisFiyati;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem silToolStripMenuItem;
        private System.Windows.Forms.CheckBox chUrunTipi;
        private System.Windows.Forms.ToolStripMenuItem düzenleToolStripMenuItem;
    }
}