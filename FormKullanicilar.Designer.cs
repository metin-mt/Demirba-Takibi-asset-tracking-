namespace DemirbasTakip
{
    partial class FormKullanicilar
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
            this.groupBoxPersonel = new System.Windows.Forms.GroupBox();
            this.ID_Personel = new System.Windows.Forms.Label();
            this.textBoxFiltreKullaniciParola = new System.Windows.Forms.TextBox();
            this.labelEPosta = new System.Windows.Forms.Label();
            this.textBoxKullaniciParola = new System.Windows.Forms.TextBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.textBoxFiltreKullaniciAdi = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreAdiSoyadi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciParolasiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullaniciBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelAdi = new System.Windows.Forms.Label();
            this.textBoxAdiSoyadi = new System.Windows.Forms.TextBox();
            this.kullaniciTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.KullaniciTableAdapter();
            this.groupBoxPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersonel
            // 
            this.groupBoxPersonel.Controls.Add(this.ID_Personel);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreKullaniciParola);
            this.groupBoxPersonel.Controls.Add(this.labelEPosta);
            this.groupBoxPersonel.Controls.Add(this.textBoxKullaniciParola);
            this.groupBoxPersonel.Controls.Add(this.buttonSonKayit);
            this.groupBoxPersonel.Controls.Add(this.buttonIlkKayit);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreKullaniciAdi);
            this.groupBoxPersonel.Controls.Add(this.labelFiltre);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreAdiSoyadi);
            this.groupBoxPersonel.Controls.Add(this.buttonSil);
            this.groupBoxPersonel.Controls.Add(this.buttonGuncelle);
            this.groupBoxPersonel.Controls.Add(this.buttonGeri);
            this.groupBoxPersonel.Controls.Add(this.buttonKaydet);
            this.groupBoxPersonel.Controls.Add(this.buttonIleri);
            this.groupBoxPersonel.Controls.Add(this.buttonYeniKayit);
            this.groupBoxPersonel.Controls.Add(this.labelSoyadi);
            this.groupBoxPersonel.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBoxPersonel.Controls.Add(this.dataGridViewPersonel);
            this.groupBoxPersonel.Controls.Add(this.labelAdi);
            this.groupBoxPersonel.Controls.Add(this.textBoxAdiSoyadi);
            this.groupBoxPersonel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPersonel.Location = new System.Drawing.Point(50, 12);
            this.groupBoxPersonel.Name = "groupBoxPersonel";
            this.groupBoxPersonel.Size = new System.Drawing.Size(725, 411);
            this.groupBoxPersonel.TabIndex = 23;
            this.groupBoxPersonel.TabStop = false;
            this.groupBoxPersonel.Text = "Kullanıcı Bilgileri";
            // 
            // ID_Personel
            // 
            this.ID_Personel.AutoSize = true;
            this.ID_Personel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Personel.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Personel.Location = new System.Drawing.Point(401, 29);
            this.ID_Personel.Name = "ID_Personel";
            this.ID_Personel.Size = new System.Drawing.Size(13, 15);
            this.ID_Personel.TabIndex = 47;
            this.ID_Personel.Text = "0";
            // 
            // textBoxFiltreKullaniciParola
            // 
            this.textBoxFiltreKullaniciParola.Location = new System.Drawing.Point(502, 205);
            this.textBoxFiltreKullaniciParola.MaxLength = 40;
            this.textBoxFiltreKullaniciParola.Name = "textBoxFiltreKullaniciParola";
            this.textBoxFiltreKullaniciParola.Size = new System.Drawing.Size(195, 21);
            this.textBoxFiltreKullaniciParola.TabIndex = 19;
            // 
            // labelEPosta
            // 
            this.labelEPosta.AutoSize = true;
            this.labelEPosta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEPosta.Location = new System.Drawing.Point(15, 84);
            this.labelEPosta.Name = "labelEPosta";
            this.labelEPosta.Size = new System.Drawing.Size(94, 15);
            this.labelEPosta.TabIndex = 38;
            this.labelEPosta.Text = "Kullanıcı Parola";
            // 
            // textBoxKullaniciParola
            // 
            this.textBoxKullaniciParola.Location = new System.Drawing.Point(124, 81);
            this.textBoxKullaniciParola.MaxLength = 100;
            this.textBoxKullaniciParola.Name = "textBoxKullaniciParola";
            this.textBoxKullaniciParola.Size = new System.Drawing.Size(271, 21);
            this.textBoxKullaniciParola.TabIndex = 4;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(423, 163);
            this.buttonSonKayit.Name = "buttonSonKayit";
            this.buttonSonKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonSonKayit.TabIndex = 16;
            this.buttonSonKayit.Text = "Son Kayıt";
            this.buttonSonKayit.UseVisualStyleBackColor = true;
            // 
            // buttonIlkKayit
            // 
            this.buttonIlkKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIlkKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonIlkKayit.Location = new System.Drawing.Point(123, 163);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 13;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            // 
            // textBoxFiltreKullaniciAdi
            // 
            this.textBoxFiltreKullaniciAdi.Location = new System.Drawing.Point(301, 205);
            this.textBoxFiltreKullaniciAdi.MaxLength = 40;
            this.textBoxFiltreKullaniciAdi.Name = "textBoxFiltreKullaniciAdi";
            this.textBoxFiltreKullaniciAdi.Size = new System.Drawing.Size(195, 21);
            this.textBoxFiltreKullaniciAdi.TabIndex = 18;
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiltre.Location = new System.Drawing.Point(57, 208);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 29;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreAdiSoyadi
            // 
            this.textBoxFiltreAdiSoyadi.Location = new System.Drawing.Point(100, 205);
            this.textBoxFiltreAdiSoyadi.MaxLength = 40;
            this.textBoxFiltreAdiSoyadi.Name = "textBoxFiltreAdiSoyadi";
            this.textBoxFiltreAdiSoyadi.Size = new System.Drawing.Size(195, 21);
            this.textBoxFiltreAdiSoyadi.TabIndex = 17;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(423, 129);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 28);
            this.buttonSil.TabIndex = 12;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(323, 129);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 28);
            this.buttonGuncelle.TabIndex = 11;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.ForeColor = System.Drawing.Color.Green;
            this.buttonGeri.Location = new System.Drawing.Point(223, 163);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(80, 22);
            this.buttonGeri.TabIndex = 14;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonKaydet.Location = new System.Drawing.Point(223, 129);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(80, 28);
            this.buttonKaydet.TabIndex = 10;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Visible = false;
            // 
            // buttonIleri
            // 
            this.buttonIleri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIleri.ForeColor = System.Drawing.Color.Green;
            this.buttonIleri.Location = new System.Drawing.Point(323, 163);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(80, 22);
            this.buttonIleri.TabIndex = 15;
            this.buttonIleri.Text = "İleri";
            this.buttonIleri.UseVisualStyleBackColor = true;
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniKayit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonYeniKayit.Location = new System.Drawing.Point(123, 129);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 9;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadi.Location = new System.Drawing.Point(15, 57);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(80, 15);
            this.labelSoyadi.TabIndex = 4;
            this.labelSoyadi.Text = "Kullanıcı  Adı";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(124, 54);
            this.textBoxKullaniciAdi.MaxLength = 30;
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(271, 21);
            this.textBoxKullaniciAdi.TabIndex = 1;
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoGenerateColumns = false;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adSoyadDataGridViewTextBoxColumn,
            this.kullaniciAdiDataGridViewTextBoxColumn,
            this.kullaniciParolasiDataGridViewTextBoxColumn});
            this.dataGridViewPersonel.DataSource = this.kullaniciBindingSource;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(6, 229);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(691, 200);
            this.dataGridViewPersonel.TabIndex = 21;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Width = 50;
            // 
            // adSoyadDataGridViewTextBoxColumn
            // 
            this.adSoyadDataGridViewTextBoxColumn.DataPropertyName = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.HeaderText = "AdSoyad";
            this.adSoyadDataGridViewTextBoxColumn.Name = "adSoyadDataGridViewTextBoxColumn";
            this.adSoyadDataGridViewTextBoxColumn.Width = 200;
            // 
            // kullaniciAdiDataGridViewTextBoxColumn
            // 
            this.kullaniciAdiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.HeaderText = "KullaniciAdi";
            this.kullaniciAdiDataGridViewTextBoxColumn.Name = "kullaniciAdiDataGridViewTextBoxColumn";
            this.kullaniciAdiDataGridViewTextBoxColumn.Width = 200;
            // 
            // kullaniciParolasiDataGridViewTextBoxColumn
            // 
            this.kullaniciParolasiDataGridViewTextBoxColumn.DataPropertyName = "KullaniciParolasi";
            this.kullaniciParolasiDataGridViewTextBoxColumn.HeaderText = "KullaniciParolasi";
            this.kullaniciParolasiDataGridViewTextBoxColumn.Name = "kullaniciParolasiDataGridViewTextBoxColumn";
            this.kullaniciParolasiDataGridViewTextBoxColumn.Width = 200;
            // 
            // kullaniciBindingSource
            // 
            this.kullaniciBindingSource.DataMember = "Kullanici";
            this.kullaniciBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAdi
            // 
            this.labelAdi.AutoSize = true;
            this.labelAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAdi.Location = new System.Drawing.Point(15, 30);
            this.labelAdi.Name = "labelAdi";
            this.labelAdi.Size = new System.Drawing.Size(64, 15);
            this.labelAdi.TabIndex = 2;
            this.labelAdi.Text = "Adı Soyadı";
            // 
            // textBoxAdiSoyadi
            // 
            this.textBoxAdiSoyadi.Location = new System.Drawing.Point(124, 27);
            this.textBoxAdiSoyadi.MaxLength = 30;
            this.textBoxAdiSoyadi.Name = "textBoxAdiSoyadi";
            this.textBoxAdiSoyadi.Size = new System.Drawing.Size(271, 21);
            this.textBoxAdiSoyadi.TabIndex = 0;
            // 
            // kullaniciTableAdapter
            // 
            this.kullaniciTableAdapter.ClearBeforeFill = true;
            // 
            // FormKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 453);
            this.Controls.Add(this.groupBoxPersonel);
            this.Name = "FormKullanicilar";
            this.Text = "FormKullanicilar";
            this.Load += new System.EventHandler(this.FormKullanicilar_Load);
            this.groupBoxPersonel.ResumeLayout(false);
            this.groupBoxPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kullaniciBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonel;
        private System.Windows.Forms.Label ID_Personel;
        private System.Windows.Forms.TextBox textBoxFiltreKullaniciParola;
        private System.Windows.Forms.Label labelEPosta;
        private System.Windows.Forms.TextBox textBoxKullaniciParola;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.TextBox textBoxFiltreKullaniciAdi;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreAdiSoyadi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.TextBox textBoxAdiSoyadi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource kullaniciBindingSource;
        private DemirbasTakipDataSetTableAdapters.KullaniciTableAdapter kullaniciTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adSoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullaniciParolasiDataGridViewTextBoxColumn;

    }
}