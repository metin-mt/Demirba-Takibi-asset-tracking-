namespace DemirbasTakip
{
    partial class FormZimmet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxZimmetler = new System.Windows.Forms.GroupBox();
            this.textBoxFiltreDemirbasAdi = new System.Windows.Forms.TextBox();
            this.textBoxFiltreDemirbasKodu = new System.Windows.Forms.TextBox();
            this.dateTimePickerIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxDemirbas = new System.Windows.Forms.ComboBox();
            this.labelDemirbasAdi = new System.Windows.Forms.Label();
            this.textBoxFiltreAmbarAdi = new System.Windows.Forms.TextBox();
            this.textBoxFiltreSoyadi = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreAdi = new System.Windows.Forms.TextBox();
            this.labelBirimIslemTarihi = new System.Windows.Forms.Label();
            this.ID_Zimmet = new System.Windows.Forms.Label();
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.comboBoxAmbar = new System.Windows.Forms.ComboBox();
            this.labelMiktar = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.dataGridViewZimmetler = new System.Windows.Forms.DataGridView();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.labelAmbarAdi = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelPersonel = new System.Windows.Forms.Label();
            this.sorguZimmetDAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.sorguZimmetDAPTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SorguZimmetDAPTableAdapter();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisAmbarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasBirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxZimmetler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguZimmetDAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxZimmetler
            // 
            this.groupBoxZimmetler.Controls.Add(this.textBoxFiltreDemirbasAdi);
            this.groupBoxZimmetler.Controls.Add(this.textBoxFiltreDemirbasKodu);
            this.groupBoxZimmetler.Controls.Add(this.dateTimePickerIslemTarihi);
            this.groupBoxZimmetler.Controls.Add(this.comboBoxDemirbas);
            this.groupBoxZimmetler.Controls.Add(this.labelDemirbasAdi);
            this.groupBoxZimmetler.Controls.Add(this.textBoxFiltreAmbarAdi);
            this.groupBoxZimmetler.Controls.Add(this.textBoxFiltreSoyadi);
            this.groupBoxZimmetler.Controls.Add(this.labelFiltre);
            this.groupBoxZimmetler.Controls.Add(this.textBoxFiltreAdi);
            this.groupBoxZimmetler.Controls.Add(this.labelBirimIslemTarihi);
            this.groupBoxZimmetler.Controls.Add(this.ID_Zimmet);
            this.groupBoxZimmetler.Controls.Add(this.comboBoxPersonel);
            this.groupBoxZimmetler.Controls.Add(this.comboBoxAmbar);
            this.groupBoxZimmetler.Controls.Add(this.labelMiktar);
            this.groupBoxZimmetler.Controls.Add(this.textBoxMiktar);
            this.groupBoxZimmetler.Controls.Add(this.buttonSonKayit);
            this.groupBoxZimmetler.Controls.Add(this.buttonIlkKayit);
            this.groupBoxZimmetler.Controls.Add(this.dataGridViewZimmetler);
            this.groupBoxZimmetler.Controls.Add(this.buttonSil);
            this.groupBoxZimmetler.Controls.Add(this.buttonGuncelle);
            this.groupBoxZimmetler.Controls.Add(this.buttonGeri);
            this.groupBoxZimmetler.Controls.Add(this.labelAmbarAdi);
            this.groupBoxZimmetler.Controls.Add(this.buttonKaydet);
            this.groupBoxZimmetler.Controls.Add(this.buttonIleri);
            this.groupBoxZimmetler.Controls.Add(this.buttonYeniKayit);
            this.groupBoxZimmetler.Controls.Add(this.labelPersonel);
            this.groupBoxZimmetler.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxZimmetler.Location = new System.Drawing.Point(12, 12);
            this.groupBoxZimmetler.Name = "groupBoxZimmetler";
            this.groupBoxZimmetler.Size = new System.Drawing.Size(824, 658);
            this.groupBoxZimmetler.TabIndex = 25;
            this.groupBoxZimmetler.TabStop = false;
            this.groupBoxZimmetler.Text = "Zimmet Bilgileri";
            // 
            // textBoxFiltreDemirbasAdi
            // 
            this.textBoxFiltreDemirbasAdi.Location = new System.Drawing.Point(331, 249);
            this.textBoxFiltreDemirbasAdi.MaxLength = 40;
            this.textBoxFiltreDemirbasAdi.Name = "textBoxFiltreDemirbasAdi";
            this.textBoxFiltreDemirbasAdi.Size = new System.Drawing.Size(296, 21);
            this.textBoxFiltreDemirbasAdi.TabIndex = 16;
            this.textBoxFiltreDemirbasAdi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // textBoxFiltreDemirbasKodu
            // 
            this.textBoxFiltreDemirbasKodu.Location = new System.Drawing.Point(272, 249);
            this.textBoxFiltreDemirbasKodu.MaxLength = 40;
            this.textBoxFiltreDemirbasKodu.Name = "textBoxFiltreDemirbasKodu";
            this.textBoxFiltreDemirbasKodu.Size = new System.Drawing.Size(57, 21);
            this.textBoxFiltreDemirbasKodu.TabIndex = 15;
            this.textBoxFiltreDemirbasKodu.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // dateTimePickerIslemTarihi
            // 
            this.dateTimePickerIslemTarihi.Location = new System.Drawing.Point(120, 132);
            this.dateTimePickerIslemTarihi.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIslemTarihi.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIslemTarihi.Name = "dateTimePickerIslemTarihi";
            this.dateTimePickerIslemTarihi.Size = new System.Drawing.Size(182, 21);
            this.dateTimePickerIslemTarihi.TabIndex = 4;
            // 
            // comboBoxDemirbas
            // 
            this.comboBoxDemirbas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemirbas.FormattingEnabled = true;
            this.comboBoxDemirbas.Location = new System.Drawing.Point(120, 78);
            this.comboBoxDemirbas.Name = "comboBoxDemirbas";
            this.comboBoxDemirbas.Size = new System.Drawing.Size(299, 23);
            this.comboBoxDemirbas.TabIndex = 2;
            // 
            // labelDemirbasAdi
            // 
            this.labelDemirbasAdi.AutoSize = true;
            this.labelDemirbasAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDemirbasAdi.Location = new System.Drawing.Point(11, 83);
            this.labelDemirbasAdi.Name = "labelDemirbasAdi";
            this.labelDemirbasAdi.Size = new System.Drawing.Size(78, 15);
            this.labelDemirbasAdi.TabIndex = 49;
            this.labelDemirbasAdi.Text = "Demirbaş Adı";
            // 
            // textBoxFiltreAmbarAdi
            // 
            this.textBoxFiltreAmbarAdi.Location = new System.Drawing.Point(629, 249);
            this.textBoxFiltreAmbarAdi.MaxLength = 40;
            this.textBoxFiltreAmbarAdi.Name = "textBoxFiltreAmbarAdi";
            this.textBoxFiltreAmbarAdi.Size = new System.Drawing.Size(181, 21);
            this.textBoxFiltreAmbarAdi.TabIndex = 17;
            this.textBoxFiltreAmbarAdi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // textBoxFiltreSoyadi
            // 
            this.textBoxFiltreSoyadi.Location = new System.Drawing.Point(153, 249);
            this.textBoxFiltreSoyadi.MaxLength = 40;
            this.textBoxFiltreSoyadi.Name = "textBoxFiltreSoyadi";
            this.textBoxFiltreSoyadi.Size = new System.Drawing.Size(116, 21);
            this.textBoxFiltreSoyadi.TabIndex = 14;
            this.textBoxFiltreSoyadi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiltre.Location = new System.Drawing.Point(10, 252);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 48;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreAdi
            // 
            this.textBoxFiltreAdi.Location = new System.Drawing.Point(53, 249);
            this.textBoxFiltreAdi.MaxLength = 40;
            this.textBoxFiltreAdi.Name = "textBoxFiltreAdi";
            this.textBoxFiltreAdi.Size = new System.Drawing.Size(99, 21);
            this.textBoxFiltreAdi.TabIndex = 13;
            this.textBoxFiltreAdi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // labelBirimIslemTarihi
            // 
            this.labelBirimIslemTarihi.AutoSize = true;
            this.labelBirimIslemTarihi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBirimIslemTarihi.Location = new System.Drawing.Point(11, 135);
            this.labelBirimIslemTarihi.Name = "labelBirimIslemTarihi";
            this.labelBirimIslemTarihi.Size = new System.Drawing.Size(72, 15);
            this.labelBirimIslemTarihi.TabIndex = 44;
            this.labelBirimIslemTarihi.Text = "İşlem Tarihi";
            // 
            // ID_Zimmet
            // 
            this.ID_Zimmet.AutoSize = true;
            this.ID_Zimmet.BackColor = System.Drawing.SystemColors.Control;
            this.ID_Zimmet.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Zimmet.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Zimmet.Location = new System.Drawing.Point(101, 23);
            this.ID_Zimmet.Name = "ID_Zimmet";
            this.ID_Zimmet.Size = new System.Drawing.Size(13, 15);
            this.ID_Zimmet.TabIndex = 42;
            this.ID_Zimmet.Text = "0";
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(120, 20);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(299, 23);
            this.comboBoxPersonel.TabIndex = 0;
            // 
            // comboBoxAmbar
            // 
            this.comboBoxAmbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmbar.FormattingEnabled = true;
            this.comboBoxAmbar.Location = new System.Drawing.Point(120, 49);
            this.comboBoxAmbar.Name = "comboBoxAmbar";
            this.comboBoxAmbar.Size = new System.Drawing.Size(299, 23);
            this.comboBoxAmbar.TabIndex = 1;
            // 
            // labelMiktar
            // 
            this.labelMiktar.AutoSize = true;
            this.labelMiktar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMiktar.Location = new System.Drawing.Point(11, 108);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(44, 15);
            this.labelMiktar.TabIndex = 36;
            this.labelMiktar.Text = "Miktar";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(120, 105);
            this.textBoxMiktar.MaxLength = 5;
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMiktar.Size = new System.Drawing.Size(113, 21);
            this.textBoxMiktar.TabIndex = 3;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(420, 202);
            this.buttonSonKayit.Name = "buttonSonKayit";
            this.buttonSonKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonSonKayit.TabIndex = 12;
            this.buttonSonKayit.Text = "Son Kayıt";
            this.buttonSonKayit.UseVisualStyleBackColor = true;
            this.buttonSonKayit.Click += new System.EventHandler(this.buttonSonKayit_Click);
            // 
            // buttonIlkKayit
            // 
            this.buttonIlkKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIlkKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonIlkKayit.Location = new System.Drawing.Point(120, 202);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 9;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // dataGridViewZimmetler
            // 
            this.dataGridViewZimmetler.AutoGenerateColumns = false;
            this.dataGridViewZimmetler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewZimmetler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.demirbasIDDataGridViewTextBoxColumn,
            this.cikisAmbarIDDataGridViewTextBoxColumn,
            this.personelIDDataGridViewTextBoxColumn,
            this.ıslemTarihiDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.demirbasKoduDataGridViewTextBoxColumn,
            this.demirbasAdiDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.demirbasBirimiDataGridViewTextBoxColumn,
            this.ambarAdiDataGridViewTextBoxColumn});
            this.dataGridViewZimmetler.DataSource = this.sorguZimmetDAPBindingSource;
            this.dataGridViewZimmetler.Location = new System.Drawing.Point(8, 276);
            this.dataGridViewZimmetler.Name = "dataGridViewZimmetler";
            this.dataGridViewZimmetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZimmetler.Size = new System.Drawing.Size(803, 367);
            this.dataGridViewZimmetler.TabIndex = 18;
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(420, 167);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 28);
            this.buttonSil.TabIndex = 8;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(320, 167);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 28);
            this.buttonGuncelle.TabIndex = 7;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.ForeColor = System.Drawing.Color.Green;
            this.buttonGeri.Location = new System.Drawing.Point(220, 202);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(80, 22);
            this.buttonGeri.TabIndex = 10;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // labelAmbarAdi
            // 
            this.labelAmbarAdi.AutoSize = true;
            this.labelAmbarAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmbarAdi.Location = new System.Drawing.Point(11, 54);
            this.labelAmbarAdi.Name = "labelAmbarAdi";
            this.labelAmbarAdi.Size = new System.Drawing.Size(62, 15);
            this.labelAmbarAdi.TabIndex = 2;
            this.labelAmbarAdi.Text = "Ambar Adı";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonKaydet.Location = new System.Drawing.Point(220, 167);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(80, 28);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Visible = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonIleri
            // 
            this.buttonIleri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIleri.ForeColor = System.Drawing.Color.Green;
            this.buttonIleri.Location = new System.Drawing.Point(320, 202);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(80, 22);
            this.buttonIleri.TabIndex = 11;
            this.buttonIleri.Text = "İleri";
            this.buttonIleri.UseVisualStyleBackColor = true;
            this.buttonIleri.Click += new System.EventHandler(this.buttonIleri_Click);
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniKayit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonYeniKayit.Location = new System.Drawing.Point(120, 167);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(79, 28);
            this.buttonYeniKayit.TabIndex = 5;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelPersonel
            // 
            this.labelPersonel.AutoSize = true;
            this.labelPersonel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonel.Location = new System.Drawing.Point(11, 25);
            this.labelPersonel.Name = "labelPersonel";
            this.labelPersonel.Size = new System.Drawing.Size(73, 15);
            this.labelPersonel.TabIndex = 2;
            this.labelPersonel.Text = "Personel Adı";
            // 
            // sorguZimmetDAPBindingSource
            // 
            this.sorguZimmetDAPBindingSource.DataMember = "SorguZimmetDAP";
            this.sorguZimmetDAPBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorguZimmetDAPTableAdapter
            // 
            this.sorguZimmetDAPTableAdapter.ClearBeforeFill = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // demirbasIDDataGridViewTextBoxColumn
            // 
            this.demirbasIDDataGridViewTextBoxColumn.DataPropertyName = "DemirbasID";
            this.demirbasIDDataGridViewTextBoxColumn.HeaderText = "DemirbasID";
            this.demirbasIDDataGridViewTextBoxColumn.Name = "demirbasIDDataGridViewTextBoxColumn";
            this.demirbasIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cikisAmbarIDDataGridViewTextBoxColumn
            // 
            this.cikisAmbarIDDataGridViewTextBoxColumn.DataPropertyName = "CikisAmbarID";
            this.cikisAmbarIDDataGridViewTextBoxColumn.HeaderText = "CikisAmbarID";
            this.cikisAmbarIDDataGridViewTextBoxColumn.Name = "cikisAmbarIDDataGridViewTextBoxColumn";
            this.cikisAmbarIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // personelIDDataGridViewTextBoxColumn
            // 
            this.personelIDDataGridViewTextBoxColumn.DataPropertyName = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.HeaderText = "PersonelID";
            this.personelIDDataGridViewTextBoxColumn.Name = "personelIDDataGridViewTextBoxColumn";
            this.personelIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ıslemTarihiDataGridViewTextBoxColumn
            // 
            this.ıslemTarihiDataGridViewTextBoxColumn.DataPropertyName = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.HeaderText = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.Name = "ıslemTarihiDataGridViewTextBoxColumn";
            this.ıslemTarihiDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Width = 120;
            // 
            // demirbasKoduDataGridViewTextBoxColumn
            // 
            this.demirbasKoduDataGridViewTextBoxColumn.DataPropertyName = "DemirbasKodu";
            this.demirbasKoduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            this.demirbasKoduDataGridViewTextBoxColumn.Name = "demirbasKoduDataGridViewTextBoxColumn";
            this.demirbasKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasKoduDataGridViewTextBoxColumn.Width = 60;
            // 
            // demirbasAdiDataGridViewTextBoxColumn
            // 
            this.demirbasAdiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasAdi";
            this.demirbasAdiDataGridViewTextBoxColumn.HeaderText = "Demirbaş Adı";
            this.demirbasAdiDataGridViewTextBoxColumn.Name = "demirbasAdiDataGridViewTextBoxColumn";
            this.demirbasAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasAdiDataGridViewTextBoxColumn.Width = 200;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.miktarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktarı";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.miktarDataGridViewTextBoxColumn.Width = 50;
            // 
            // demirbasBirimiDataGridViewTextBoxColumn
            // 
            this.demirbasBirimiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasBirimi";
            this.demirbasBirimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.demirbasBirimiDataGridViewTextBoxColumn.Name = "demirbasBirimiDataGridViewTextBoxColumn";
            this.demirbasBirimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasBirimiDataGridViewTextBoxColumn.Width = 50;
            // 
            // ambarAdiDataGridViewTextBoxColumn
            // 
            this.ambarAdiDataGridViewTextBoxColumn.DataPropertyName = "AmbarAdi";
            this.ambarAdiDataGridViewTextBoxColumn.HeaderText = "Ambar Adı";
            this.ambarAdiDataGridViewTextBoxColumn.Name = "ambarAdiDataGridViewTextBoxColumn";
            this.ambarAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ambarAdiDataGridViewTextBoxColumn.Width = 180;
            // 
            // FormZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 678);
            this.Controls.Add(this.groupBoxZimmetler);
            this.Name = "FormZimmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Zimmet İşlemleri ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormZimmet_FormClosed);
            this.Load += new System.EventHandler(this.FormZimmet_Load);
            this.groupBoxZimmetler.ResumeLayout(false);
            this.groupBoxZimmetler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguZimmetDAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxZimmetler;
        private System.Windows.Forms.TextBox textBoxFiltreAmbarAdi;
        private System.Windows.Forms.TextBox textBoxFiltreSoyadi;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreAdi;
        private System.Windows.Forms.Label labelBirimIslemTarihi;
        private System.Windows.Forms.Label ID_Zimmet;
        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.ComboBox comboBoxAmbar;
        private System.Windows.Forms.Label labelMiktar;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.DataGridView dataGridViewZimmetler;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Label labelAmbarAdi;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelPersonel;
        private System.Windows.Forms.ComboBox comboBoxDemirbas;
        private System.Windows.Forms.Label labelDemirbasAdi;
        private System.Windows.Forms.DateTimePicker dateTimePickerIslemTarihi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sorguZimmetDAPBindingSource;
        private DemirbasTakipDataSetTableAdapters.SorguZimmetDAPTableAdapter sorguZimmetDAPTableAdapter;
        private System.Windows.Forms.TextBox textBoxFiltreDemirbasAdi;
        private System.Windows.Forms.TextBox textBoxFiltreDemirbasKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisAmbarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasBirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambarAdiDataGridViewTextBoxColumn;
    }
}