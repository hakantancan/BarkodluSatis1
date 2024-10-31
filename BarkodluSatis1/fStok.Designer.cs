namespace BarkodluSatis1
{
    partial class fStok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStok));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.bRaporAl = new BarkodluSatis1.bStandart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbIslemTuru = new System.Windows.Forms.ComboBox();
            this.lStandart1 = new BarkodluSatis1.lStandart();
            this.bAra = new BarkodluSatis1.bStandart();
            this.panelTarihler = new System.Windows.Forms.Panel();
            this.dateBitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.lStandart5 = new BarkodluSatis1.lStandart();
            this.dateBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lStandart4 = new BarkodluSatis1.lStandart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lStandart3 = new BarkodluSatis1.lStandart();
            this.cmbUrunGrubu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdUrunGrubunaGore = new System.Windows.Forms.RadioButton();
            this.rdTumu = new System.Windows.Forms.RadioButton();
            this.lStandart2 = new BarkodluSatis1.lStandart();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.lKullanici = new BarkodluSatis1.lStandart();
            this.tUrunAraaa = new BarkodluSatis1.tStandart();
            this.lStandart6 = new BarkodluSatis1.lStandart();
            this.gridListe = new BarkodluSatis1.gridOzel();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelTarihler.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer1.Panel1.Controls.Add(this.bRaporAl);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Controls.Add(this.bAra);
            this.splitContainer1.Panel1.Controls.Add(this.panelTarihler);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(799, 642);
            this.splitContainer1.SplitterDistance = 310;
            this.splitContainer1.TabIndex = 0;
            // 
            // bRaporAl
            // 
            this.bRaporAl.BackColor = System.Drawing.Color.SteelBlue;
            this.bRaporAl.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bRaporAl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRaporAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bRaporAl.ForeColor = System.Drawing.Color.White;
            this.bRaporAl.Image = ((System.Drawing.Image)(resources.GetObject("bRaporAl.Image")));
            this.bRaporAl.Location = new System.Drawing.Point(171, 502);
            this.bRaporAl.Margin = new System.Windows.Forms.Padding(1);
            this.bRaporAl.Name = "bRaporAl";
            this.bRaporAl.Size = new System.Drawing.Size(133, 90);
            this.bRaporAl.TabIndex = 15;
            this.bRaporAl.Text = "Rapor";
            this.bRaporAl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.bRaporAl.UseVisualStyleBackColor = false;
            this.bRaporAl.Click += new System.EventHandler(this.bRaporAl_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbIslemTuru);
            this.panel4.Controls.Add(this.lStandart1);
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(308, 95);
            this.panel4.TabIndex = 6;
            // 
            // cmbIslemTuru
            // 
            this.cmbIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIslemTuru.FormattingEnabled = true;
            this.cmbIslemTuru.Items.AddRange(new object[] {
            "Stok Durumu",
            "Stok Giriş İzleme"});
            this.cmbIslemTuru.Location = new System.Drawing.Point(14, 51);
            this.cmbIslemTuru.Name = "cmbIslemTuru";
            this.cmbIslemTuru.Size = new System.Drawing.Size(204, 24);
            this.cmbIslemTuru.TabIndex = 1;
            // 
            // lStandart1
            // 
            this.lStandart1.AutoSize = true;
            this.lStandart1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lStandart1.Location = new System.Drawing.Point(12, 11);
            this.lStandart1.Name = "lStandart1";
            this.lStandart1.Size = new System.Drawing.Size(104, 25);
            this.lStandart1.TabIndex = 0;
            this.lStandart1.Text = "İşlem Türü";
            // 
            // bAra
            // 
            this.bAra.BackColor = System.Drawing.Color.Chocolate;
            this.bAra.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.bAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bAra.ForeColor = System.Drawing.Color.White;
            this.bAra.Image = ((System.Drawing.Image)(resources.GetObject("bAra.Image")));
            this.bAra.Location = new System.Drawing.Point(17, 502);
            this.bAra.Margin = new System.Windows.Forms.Padding(1);
            this.bAra.Name = "bAra";
            this.bAra.Size = new System.Drawing.Size(137, 90);
            this.bAra.TabIndex = 1;
            this.bAra.Text = "Ara";
            this.bAra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bAra.UseVisualStyleBackColor = false;
            this.bAra.Click += new System.EventHandler(this.bStandart1_Click);
            // 
            // panelTarihler
            // 
            this.panelTarihler.Controls.Add(this.dateBitisTarihi);
            this.panelTarihler.Controls.Add(this.lStandart5);
            this.panelTarihler.Controls.Add(this.dateBaslangic);
            this.panelTarihler.Controls.Add(this.lStandart4);
            this.panelTarihler.Location = new System.Drawing.Point(3, 311);
            this.panelTarihler.Name = "panelTarihler";
            this.panelTarihler.Size = new System.Drawing.Size(304, 160);
            this.panelTarihler.TabIndex = 5;
            // 
            // dateBitisTarihi
            // 
            this.dateBitisTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBitisTarihi.Location = new System.Drawing.Point(14, 127);
            this.dateBitisTarihi.Name = "dateBitisTarihi";
            this.dateBitisTarihi.Size = new System.Drawing.Size(287, 30);
            this.dateBitisTarihi.TabIndex = 3;
            // 
            // lStandart5
            // 
            this.lStandart5.AutoSize = true;
            this.lStandart5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lStandart5.Location = new System.Drawing.Point(11, 95);
            this.lStandart5.Name = "lStandart5";
            this.lStandart5.Size = new System.Drawing.Size(102, 25);
            this.lStandart5.TabIndex = 2;
            this.lStandart5.Text = "Bitiş Tarihi";
            // 
            // dateBaslangic
            // 
            this.dateBaslangic.CalendarTrailingForeColor = System.Drawing.Color.Chocolate;
            this.dateBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateBaslangic.Location = new System.Drawing.Point(14, 49);
            this.dateBaslangic.Name = "dateBaslangic";
            this.dateBaslangic.Size = new System.Drawing.Size(287, 30);
            this.dateBaslangic.TabIndex = 1;
            // 
            // lStandart4
            // 
            this.lStandart4.AutoSize = true;
            this.lStandart4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lStandart4.Location = new System.Drawing.Point(9, 9);
            this.lStandart4.Name = "lStandart4";
            this.lStandart4.Size = new System.Drawing.Size(151, 25);
            this.lStandart4.TabIndex = 0;
            this.lStandart4.Text = "Başlangıç Tarihi";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lStandart3);
            this.panel2.Controls.Add(this.cmbUrunGrubu);
            this.panel2.Location = new System.Drawing.Point(3, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 78);
            this.panel2.TabIndex = 4;
            // 
            // lStandart3
            // 
            this.lStandart3.AutoSize = true;
            this.lStandart3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lStandart3.Location = new System.Drawing.Point(9, 11);
            this.lStandart3.Name = "lStandart3";
            this.lStandart3.Size = new System.Drawing.Size(113, 25);
            this.lStandart3.TabIndex = 1;
            this.lStandart3.Text = "Ürün Grubu";
            // 
            // cmbUrunGrubu
            // 
            this.cmbUrunGrubu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUrunGrubu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbUrunGrubu.FormattingEnabled = true;
            this.cmbUrunGrubu.Location = new System.Drawing.Point(14, 39);
            this.cmbUrunGrubu.Name = "cmbUrunGrubu";
            this.cmbUrunGrubu.Size = new System.Drawing.Size(200, 33);
            this.cmbUrunGrubu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdUrunGrubunaGore);
            this.panel1.Controls.Add(this.rdTumu);
            this.panel1.Controls.Add(this.lStandart2);
            this.panel1.Location = new System.Drawing.Point(3, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 120);
            this.panel1.TabIndex = 3;
            // 
            // rdUrunGrubunaGore
            // 
            this.rdUrunGrubunaGore.AutoSize = true;
            this.rdUrunGrubunaGore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdUrunGrubunaGore.ForeColor = System.Drawing.Color.Chocolate;
            this.rdUrunGrubunaGore.Location = new System.Drawing.Point(14, 77);
            this.rdUrunGrubunaGore.Name = "rdUrunGrubunaGore";
            this.rdUrunGrubunaGore.Size = new System.Drawing.Size(204, 29);
            this.rdUrunGrubunaGore.TabIndex = 4;
            this.rdUrunGrubunaGore.TabStop = true;
            this.rdUrunGrubunaGore.Text = "Ürün Grubuna Göre";
            this.rdUrunGrubunaGore.UseVisualStyleBackColor = true;
            // 
            // rdTumu
            // 
            this.rdTumu.AutoSize = true;
            this.rdTumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdTumu.ForeColor = System.Drawing.Color.Chocolate;
            this.rdTumu.Location = new System.Drawing.Point(14, 42);
            this.rdTumu.Name = "rdTumu";
            this.rdTumu.Size = new System.Drawing.Size(84, 29);
            this.rdTumu.TabIndex = 3;
            this.rdTumu.TabStop = true;
            this.rdTumu.Text = "Tümü";
            this.rdTumu.UseVisualStyleBackColor = true;
            // 
            // lStandart2
            // 
            this.lStandart2.AutoSize = true;
            this.lStandart2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lStandart2.Location = new System.Drawing.Point(9, 10);
            this.lStandart2.Name = "lStandart2";
            this.lStandart2.Size = new System.Drawing.Size(142, 25);
            this.lStandart2.TabIndex = 2;
            this.lStandart2.Text = "Filtreleme Türü";
            this.lStandart2.Click += new System.EventHandler(this.lStandart2_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.splitContainer2.Panel1.Controls.Add(this.lKullanici);
            this.splitContainer2.Panel1.Controls.Add(this.tUrunAraaa);
            this.splitContainer2.Panel1.Controls.Add(this.lStandart6);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.gridListe);
            this.splitContainer2.Size = new System.Drawing.Size(485, 642);
            this.splitContainer2.SplitterDistance = 86;
            this.splitContainer2.TabIndex = 0;
            // 
            // lKullanici
            // 
            this.lKullanici.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lKullanici.AutoSize = true;
            this.lKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lKullanici.ForeColor = System.Drawing.Color.DarkCyan;
            this.lKullanici.Location = new System.Drawing.Point(373, 45);
            this.lKullanici.Name = "lKullanici";
            this.lKullanici.Size = new System.Drawing.Size(101, 25);
            this.lKullanici.TabIndex = 3;
            this.lKullanici.Text = "lStandart7";
            // 
            // tUrunAraaa
            // 
            this.tUrunAraaa.BackColor = System.Drawing.Color.White;
            this.tUrunAraaa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tUrunAraaa.Location = new System.Drawing.Point(20, 45);
            this.tUrunAraaa.Name = "tUrunAraaa";
            this.tUrunAraaa.Size = new System.Drawing.Size(250, 30);
            this.tUrunAraaa.TabIndex = 2;
            this.tUrunAraaa.TextChanged += new System.EventHandler(this.tUrunAraaa_TextChanged);
            // 
            // lStandart6
            // 
            this.lStandart6.AutoSize = true;
            this.lStandart6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lStandart6.ForeColor = System.Drawing.Color.DarkCyan;
            this.lStandart6.Location = new System.Drawing.Point(15, 11);
            this.lStandart6.Name = "lStandart6";
            this.lStandart6.Size = new System.Drawing.Size(90, 25);
            this.lStandart6.TabIndex = 0;
            this.lStandart6.Text = "Ürün Ara";
            // 
            // gridListe
            // 
            this.gridListe.AllowUserToAddRows = false;
            this.gridListe.AllowUserToDeleteRows = false;
            this.gridListe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridListe.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.gridListe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridListe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GrayText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListe.DefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridListe.EnableHeadersVisualStyles = false;
            this.gridListe.Location = new System.Drawing.Point(0, 0);
            this.gridListe.Name = "gridListe";
            this.gridListe.ReadOnly = true;
            this.gridListe.RowHeadersVisible = false;
            this.gridListe.RowHeadersWidth = 51;
            this.gridListe.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gridListe.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(2);
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridListe.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gridListe.RowTemplate.Height = 30;
            this.gridListe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridListe.Size = new System.Drawing.Size(485, 552);
            this.gridListe.TabIndex = 1;
            // 
            // fStok
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(799, 642);
            this.Controls.Add(this.splitContainer1);
            this.Name = "fStok";
            this.Text = "Stok İşlemleri";
            this.Load += new System.EventHandler(this.fStok_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelTarihler.ResumeLayout(false);
            this.panelTarihler.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridListe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private lStandart lStandart2;
        private System.Windows.Forms.ComboBox cmbIslemTuru;
        private lStandart lStandart1;
        private System.Windows.Forms.RadioButton rdUrunGrubunaGore;
        private System.Windows.Forms.RadioButton rdTumu;
        private System.Windows.Forms.Panel panel2;
        private lStandart lStandart3;
        private System.Windows.Forms.ComboBox cmbUrunGrubu;
        private System.Windows.Forms.Panel panelTarihler;
        private lStandart lStandart4;
        private System.Windows.Forms.DateTimePicker dateBitisTarihi;
        private lStandart lStandart5;
        private System.Windows.Forms.DateTimePicker dateBaslangic;
        private bStandart bAra;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private lStandart lStandart6;
        private gridOzel gridListe;
        private tStandart tUrunAraaa;
        private bStandart bRaporAl;
        internal lStandart lKullanici;
    }
}