namespace DemirbasTakip
{
    partial class FormFatura
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
            this.groupBoxFaturalar = new System.Windows.Forms.GroupBox();
            this.ID_Fatura = new System.Windows.Forms.Label();
            this.comboBoxIslemTuru = new System.Windows.Forms.ComboBox();
            this.dateTimePickerFaturaTarihi = new System.Windows.Forms.DateTimePicker();
            this.labelFaturaTarihi = new System.Windows.Forms.Label();
            this.dateTimePickerIslemTarihi = new System.Windows.Forms.DateTimePicker();
            this.comboBoxFirma = new System.Windows.Forms.ComboBox();
            this.textBoxFiltreIslemTuru = new System.Windows.Forms.TextBox();
            this.comboBoxAmbar = new System.Windows.Forms.ComboBox();
            this.labelIslemTuru = new System.Windows.Forms.Label();
            this.labelFaturaNo = new System.Windows.Forms.Label();
            this.textBoxFaturaNo = new System.Windows.Forms.TextBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.textBoxFiltreAmbarAdi = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreFirmaAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelIslemTarihi = new System.Windows.Forms.Label();
            this.labelAmbarAdi = new System.Windows.Forms.Label();
            this.dataGridViewFaturalar = new System.Windows.Forms.DataGridView();
            this.firmaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTuruDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorguAmbarFaturaAmbarFirmaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelFirmaAdi = new System.Windows.Forms.Label();
            this.sorguAmbarFaturaAmbarFirmaTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SorguAmbarFaturaAmbarFirmaTableAdapter();
            this.groupBoxFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaturalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguAmbarFaturaAmbarFirmaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFaturalar
            // 
            this.groupBoxFaturalar.Controls.Add(this.ID_Fatura);
            this.groupBoxFaturalar.Controls.Add(this.comboBoxIslemTuru);
            this.groupBoxFaturalar.Controls.Add(this.dateTimePickerFaturaTarihi);
            this.groupBoxFaturalar.Controls.Add(this.labelFaturaTarihi);
            this.groupBoxFaturalar.Controls.Add(this.dateTimePickerIslemTarihi);
            this.groupBoxFaturalar.Controls.Add(this.comboBoxFirma);
            this.groupBoxFaturalar.Controls.Add(this.textBoxFiltreIslemTuru);
            this.groupBoxFaturalar.Controls.Add(this.comboBoxAmbar);
            this.groupBoxFaturalar.Controls.Add(this.labelIslemTuru);
            this.groupBoxFaturalar.Controls.Add(this.labelFaturaNo);
            this.groupBoxFaturalar.Controls.Add(this.textBoxFaturaNo);
            this.groupBoxFaturalar.Controls.Add(this.buttonSonKayit);
            this.groupBoxFaturalar.Controls.Add(this.buttonIlkKayit);
            this.groupBoxFaturalar.Controls.Add(this.textBoxFiltreAmbarAdi);
            this.groupBoxFaturalar.Controls.Add(this.labelFiltre);
            this.groupBoxFaturalar.Controls.Add(this.textBoxFiltreFirmaAdi);
            this.groupBoxFaturalar.Controls.Add(this.buttonSil);
            this.groupBoxFaturalar.Controls.Add(this.buttonGuncelle);
            this.groupBoxFaturalar.Controls.Add(this.buttonGeri);
            this.groupBoxFaturalar.Controls.Add(this.buttonKaydet);
            this.groupBoxFaturalar.Controls.Add(this.buttonIleri);
            this.groupBoxFaturalar.Controls.Add(this.buttonYeniKayit);
            this.groupBoxFaturalar.Controls.Add(this.labelIslemTarihi);
            this.groupBoxFaturalar.Controls.Add(this.labelAmbarAdi);
            this.groupBoxFaturalar.Controls.Add(this.dataGridViewFaturalar);
            this.groupBoxFaturalar.Controls.Add(this.labelFirmaAdi);
            this.groupBoxFaturalar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFaturalar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFaturalar.Name = "groupBoxFaturalar";
            this.groupBoxFaturalar.Size = new System.Drawing.Size(769, 575);
            this.groupBoxFaturalar.TabIndex = 22;
            this.groupBoxFaturalar.TabStop = false;
            this.groupBoxFaturalar.Text = "Fatura Bilgileri";
            // 
            // ID_Fatura
            // 
            this.ID_Fatura.AutoSize = true;
            this.ID_Fatura.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Fatura.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Fatura.Location = new System.Drawing.Point(103, 28);
            this.ID_Fatura.Name = "ID_Fatura";
            this.ID_Fatura.Size = new System.Drawing.Size(13, 15);
            this.ID_Fatura.TabIndex = 42;
            this.ID_Fatura.Text = "0";
            // 
            // comboBoxIslemTuru
            // 
            this.comboBoxIslemTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIslemTuru.FormattingEnabled = true;
            this.comboBoxIslemTuru.Items.AddRange(new object[] {
            "Satın Alma",
            "Hibe",
            "İmalat",
            "Düşüm"});
            this.comboBoxIslemTuru.Location = new System.Drawing.Point(122, 133);
            this.comboBoxIslemTuru.MaxLength = 5;
            this.comboBoxIslemTuru.Name = "comboBoxIslemTuru";
            this.comboBoxIslemTuru.Size = new System.Drawing.Size(182, 23);
            this.comboBoxIslemTuru.TabIndex = 4;
            // 
            // dateTimePickerFaturaTarihi
            // 
            this.dateTimePickerFaturaTarihi.Location = new System.Drawing.Point(122, 106);
            this.dateTimePickerFaturaTarihi.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerFaturaTarihi.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFaturaTarihi.Name = "dateTimePickerFaturaTarihi";
            this.dateTimePickerFaturaTarihi.Size = new System.Drawing.Size(182, 21);
            this.dateTimePickerFaturaTarihi.TabIndex = 3;
            // 
            // labelFaturaTarihi
            // 
            this.labelFaturaTarihi.AutoSize = true;
            this.labelFaturaTarihi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFaturaTarihi.Location = new System.Drawing.Point(13, 109);
            this.labelFaturaTarihi.Name = "labelFaturaTarihi";
            this.labelFaturaTarihi.Size = new System.Drawing.Size(78, 15);
            this.labelFaturaTarihi.TabIndex = 41;
            this.labelFaturaTarihi.Text = "Fatura Tarihi";
            // 
            // dateTimePickerIslemTarihi
            // 
            this.dateTimePickerIslemTarihi.Location = new System.Drawing.Point(122, 162);
            this.dateTimePickerIslemTarihi.MaxDate = new System.DateTime(2020, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerIslemTarihi.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerIslemTarihi.Name = "dateTimePickerIslemTarihi";
            this.dateTimePickerIslemTarihi.Size = new System.Drawing.Size(182, 21);
            this.dateTimePickerIslemTarihi.TabIndex = 5;
            // 
            // comboBoxFirma
            // 
            this.comboBoxFirma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFirma.FormattingEnabled = true;
            this.comboBoxFirma.Location = new System.Drawing.Point(122, 23);
            this.comboBoxFirma.Name = "comboBoxFirma";
            this.comboBoxFirma.Size = new System.Drawing.Size(294, 23);
            this.comboBoxFirma.TabIndex = 0;
            // 
            // textBoxFiltreIslemTuru
            // 
            this.textBoxFiltreIslemTuru.Location = new System.Drawing.Point(557, 260);
            this.textBoxFiltreIslemTuru.MaxLength = 40;
            this.textBoxFiltreIslemTuru.Name = "textBoxFiltreIslemTuru";
            this.textBoxFiltreIslemTuru.Size = new System.Drawing.Size(199, 21);
            this.textBoxFiltreIslemTuru.TabIndex = 16;
            this.textBoxFiltreIslemTuru.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // comboBoxAmbar
            // 
            this.comboBoxAmbar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmbar.FormattingEnabled = true;
            this.comboBoxAmbar.Location = new System.Drawing.Point(122, 52);
            this.comboBoxAmbar.Name = "comboBoxAmbar";
            this.comboBoxAmbar.Size = new System.Drawing.Size(294, 23);
            this.comboBoxAmbar.TabIndex = 1;
            // 
            // labelIslemTuru
            // 
            this.labelIslemTuru.AutoSize = true;
            this.labelIslemTuru.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIslemTuru.Location = new System.Drawing.Point(13, 136);
            this.labelIslemTuru.Name = "labelIslemTuru";
            this.labelIslemTuru.Size = new System.Drawing.Size(66, 15);
            this.labelIslemTuru.TabIndex = 38;
            this.labelIslemTuru.Text = "İşlem Türü";
            // 
            // labelFaturaNo
            // 
            this.labelFaturaNo.AutoSize = true;
            this.labelFaturaNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFaturaNo.Location = new System.Drawing.Point(13, 84);
            this.labelFaturaNo.Name = "labelFaturaNo";
            this.labelFaturaNo.Size = new System.Drawing.Size(60, 15);
            this.labelFaturaNo.TabIndex = 36;
            this.labelFaturaNo.Text = "Fatura No";
            // 
            // textBoxFaturaNo
            // 
            this.textBoxFaturaNo.Location = new System.Drawing.Point(122, 81);
            this.textBoxFaturaNo.MaxLength = 15;
            this.textBoxFaturaNo.Name = "textBoxFaturaNo";
            this.textBoxFaturaNo.Size = new System.Drawing.Size(182, 21);
            this.textBoxFaturaNo.TabIndex = 2;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(422, 227);
            this.buttonSonKayit.Name = "buttonSonKayit";
            this.buttonSonKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonSonKayit.TabIndex = 13;
            this.buttonSonKayit.Text = "Son Kayıt";
            this.buttonSonKayit.UseVisualStyleBackColor = true;
            this.buttonSonKayit.Click += new System.EventHandler(this.buttonSonKayit_Click);
            // 
            // buttonIlkKayit
            // 
            this.buttonIlkKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIlkKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonIlkKayit.Location = new System.Drawing.Point(122, 227);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 10;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // textBoxFiltreAmbarAdi
            // 
            this.textBoxFiltreAmbarAdi.Location = new System.Drawing.Point(306, 260);
            this.textBoxFiltreAmbarAdi.MaxLength = 40;
            this.textBoxFiltreAmbarAdi.Name = "textBoxFiltreAmbarAdi";
            this.textBoxFiltreAmbarAdi.Size = new System.Drawing.Size(250, 21);
            this.textBoxFiltreAmbarAdi.TabIndex = 15;
            this.textBoxFiltreAmbarAdi.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiltre.Location = new System.Drawing.Point(12, 263);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 29;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreFirmaAdi
            // 
            this.textBoxFiltreFirmaAdi.Location = new System.Drawing.Point(55, 260);
            this.textBoxFiltreFirmaAdi.MaxLength = 40;
            this.textBoxFiltreFirmaAdi.Name = "textBoxFiltreFirmaAdi";
            this.textBoxFiltreFirmaAdi.Size = new System.Drawing.Size(250, 21);
            this.textBoxFiltreFirmaAdi.TabIndex = 14;
            this.textBoxFiltreFirmaAdi.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(422, 193);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 28);
            this.buttonSil.TabIndex = 9;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(322, 193);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 28);
            this.buttonGuncelle.TabIndex = 8;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.ForeColor = System.Drawing.Color.Green;
            this.buttonGeri.Location = new System.Drawing.Point(222, 227);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(80, 22);
            this.buttonGeri.TabIndex = 11;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonKaydet.Location = new System.Drawing.Point(222, 193);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(80, 28);
            this.buttonKaydet.TabIndex = 7;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Visible = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonIleri
            // 
            this.buttonIleri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIleri.ForeColor = System.Drawing.Color.Green;
            this.buttonIleri.Location = new System.Drawing.Point(322, 227);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(80, 22);
            this.buttonIleri.TabIndex = 12;
            this.buttonIleri.Text = "İleri";
            this.buttonIleri.UseVisualStyleBackColor = true;
            this.buttonIleri.Click += new System.EventHandler(this.buttonIleri_Click);
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniKayit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonYeniKayit.Location = new System.Drawing.Point(122, 193);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 6;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelIslemTarihi
            // 
            this.labelIslemTarihi.AutoSize = true;
            this.labelIslemTarihi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelIslemTarihi.Location = new System.Drawing.Point(13, 165);
            this.labelIslemTarihi.Name = "labelIslemTarihi";
            this.labelIslemTarihi.Size = new System.Drawing.Size(72, 15);
            this.labelIslemTarihi.TabIndex = 6;
            this.labelIslemTarihi.Text = "İşlem Tarihi";
            // 
            // labelAmbarAdi
            // 
            this.labelAmbarAdi.AutoSize = true;
            this.labelAmbarAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmbarAdi.Location = new System.Drawing.Point(13, 55);
            this.labelAmbarAdi.Name = "labelAmbarAdi";
            this.labelAmbarAdi.Size = new System.Drawing.Size(62, 15);
            this.labelAmbarAdi.TabIndex = 4;
            this.labelAmbarAdi.Text = "Ambar Adı";
            // 
            // dataGridViewFaturalar
            // 
            this.dataGridViewFaturalar.AutoGenerateColumns = false;
            this.dataGridViewFaturalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFaturalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firmaAdiDataGridViewTextBoxColumn,
            this.ambarAdiDataGridViewTextBoxColumn,
            this.ıslemTuruDataGridViewTextBoxColumn,
            this.ıslemTarihiDataGridViewTextBoxColumn,
            this.ıDDataGridViewTextBoxColumn,
            this.ambarIDDataGridViewTextBoxColumn,
            this.firmaIDDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn,
            this.faturaNoDataGridViewTextBoxColumn});
            this.dataGridViewFaturalar.DataSource = this.sorguAmbarFaturaAmbarFirmaBindingSource;
            this.dataGridViewFaturalar.Location = new System.Drawing.Point(10, 287);
            this.dataGridViewFaturalar.Name = "dataGridViewFaturalar";
            this.dataGridViewFaturalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFaturalar.Size = new System.Drawing.Size(747, 264);
            this.dataGridViewFaturalar.TabIndex = 17;
            this.dataGridViewFaturalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFaturalar_CellContentClick);
            // 
            // firmaAdiDataGridViewTextBoxColumn
            // 
            this.firmaAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.HeaderText = "Firma Adı";
            this.firmaAdiDataGridViewTextBoxColumn.Name = "firmaAdiDataGridViewTextBoxColumn";
            this.firmaAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmaAdiDataGridViewTextBoxColumn.Width = 252;
            // 
            // ambarAdiDataGridViewTextBoxColumn
            // 
            this.ambarAdiDataGridViewTextBoxColumn.DataPropertyName = "AmbarAdi";
            this.ambarAdiDataGridViewTextBoxColumn.HeaderText = "Ambar Adı";
            this.ambarAdiDataGridViewTextBoxColumn.Name = "ambarAdiDataGridViewTextBoxColumn";
            this.ambarAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ambarAdiDataGridViewTextBoxColumn.Width = 252;
            // 
            // ıslemTuruDataGridViewTextBoxColumn
            // 
            this.ıslemTuruDataGridViewTextBoxColumn.DataPropertyName = "IslemTuru";
            this.ıslemTuruDataGridViewTextBoxColumn.HeaderText = "İşlem Türü";
            this.ıslemTuruDataGridViewTextBoxColumn.Name = "ıslemTuruDataGridViewTextBoxColumn";
            this.ıslemTuruDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıslemTarihiDataGridViewTextBoxColumn
            // 
            this.ıslemTarihiDataGridViewTextBoxColumn.DataPropertyName = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.HeaderText = "İşlem Tarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.Name = "ıslemTarihiDataGridViewTextBoxColumn";
            this.ıslemTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // ambarIDDataGridViewTextBoxColumn
            // 
            this.ambarIDDataGridViewTextBoxColumn.DataPropertyName = "AmbarID";
            this.ambarIDDataGridViewTextBoxColumn.HeaderText = "AmbarID";
            this.ambarIDDataGridViewTextBoxColumn.Name = "ambarIDDataGridViewTextBoxColumn";
            this.ambarIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // firmaIDDataGridViewTextBoxColumn
            // 
            this.firmaIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.HeaderText = "FirmaID";
            this.firmaIDDataGridViewTextBoxColumn.Name = "firmaIDDataGridViewTextBoxColumn";
            this.firmaIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            this.faturaTarihiDataGridViewTextBoxColumn.Visible = false;
            // 
            // faturaNoDataGridViewTextBoxColumn
            // 
            this.faturaNoDataGridViewTextBoxColumn.DataPropertyName = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.HeaderText = "FaturaNo";
            this.faturaNoDataGridViewTextBoxColumn.Name = "faturaNoDataGridViewTextBoxColumn";
            this.faturaNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // sorguAmbarFaturaAmbarFirmaBindingSource
            // 
            this.sorguAmbarFaturaAmbarFirmaBindingSource.DataMember = "SorguAmbarFaturaAmbarFirma";
            this.sorguAmbarFaturaAmbarFirmaBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelFirmaAdi
            // 
            this.labelFirmaAdi.AutoSize = true;
            this.labelFirmaAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFirmaAdi.Location = new System.Drawing.Point(13, 28);
            this.labelFirmaAdi.Name = "labelFirmaAdi";
            this.labelFirmaAdi.Size = new System.Drawing.Size(59, 15);
            this.labelFirmaAdi.TabIndex = 2;
            this.labelFirmaAdi.Text = "Firma Adı";
            // 
            // sorguAmbarFaturaAmbarFirmaTableAdapter
            // 
            this.sorguAmbarFaturaAmbarFirmaTableAdapter.ClearBeforeFill = true;
            // 
            // FormFatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 597);
            this.Controls.Add(this.groupBoxFaturalar);
            this.Name = "FormFatura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Fatura Bilgileri ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAmbarGirisCikisIslemleri_FormClosed);
            this.Load += new System.EventHandler(this.FormAmbarGirisCikisIslemleri_Load);
            this.groupBoxFaturalar.ResumeLayout(false);
            this.groupBoxFaturalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFaturalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguAmbarFaturaAmbarFirmaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFaturalar;
        private System.Windows.Forms.TextBox textBoxFiltreIslemTuru;
        private System.Windows.Forms.ComboBox comboBoxAmbar;
        private System.Windows.Forms.Label labelIslemTuru;
        private System.Windows.Forms.Label labelFaturaNo;
        private System.Windows.Forms.TextBox textBoxFaturaNo;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.TextBox textBoxFiltreAmbarAdi;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreFirmaAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelIslemTarihi;
        private System.Windows.Forms.Label labelAmbarAdi;
        private System.Windows.Forms.DataGridView dataGridViewFaturalar;
        private System.Windows.Forms.Label labelFirmaAdi;
        private System.Windows.Forms.ComboBox comboBoxFirma;
        private System.Windows.Forms.DateTimePicker dateTimePickerIslemTarihi;
        private System.Windows.Forms.DateTimePicker dateTimePickerFaturaTarihi;
        private System.Windows.Forms.Label labelFaturaTarihi;
        private System.Windows.Forms.ComboBox comboBoxIslemTuru;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sorguAmbarFaturaAmbarFirmaBindingSource;
        private DemirbasTakipDataSetTableAdapters.SorguAmbarFaturaAmbarFirmaTableAdapter sorguAmbarFaturaAmbarFirmaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTuruDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Fatura;
    }
}