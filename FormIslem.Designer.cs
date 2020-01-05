namespace DemirbasTakip
{
    partial class FormIslem
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelBirimFiyat = new System.Windows.Forms.Label();
            this.textBoxBirimFiyat = new System.Windows.Forms.TextBox();
            this.ID_Islem = new System.Windows.Forms.Label();
            this.comboBoxDemirbas = new System.Windows.Forms.ComboBox();
            this.labelMiktar = new System.Windows.Forms.Label();
            this.textBoxMiktar = new System.Windows.Forms.TextBox();
            this.dataGridViewIslemler = new System.Windows.Forms.DataGridView();
            this.labelDemirbasşAdi = new System.Windows.Forms.Label();
            this.groupBoxFaturalar = new System.Windows.Forms.GroupBox();
            this.textBoxFiltreFaturaNo = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreFirmaAdi = new System.Windows.Forms.TextBox();
            this.comboBoxFatura = new System.Windows.Forms.ComboBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelFatura = new System.Windows.Forms.Label();
            this.sorguAmbarIslemDemirbasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.sorguAmbarIslemDemirbasTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SorguAmbarIslemDemirbasTableAdapter();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmbarFaturaID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.faturaTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FaturaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IslemTuru = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasKodu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Miktar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemirbasBirimi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxFiltreIslemTuru = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).BeginInit();
            this.groupBoxFaturalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sorguAmbarIslemDemirbasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // labelBirimFiyat
            // 
            this.labelBirimFiyat.AutoSize = true;
            this.labelBirimFiyat.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBirimFiyat.Location = new System.Drawing.Point(11, 108);
            this.labelBirimFiyat.Name = "labelBirimFiyat";
            this.labelBirimFiyat.Size = new System.Drawing.Size(68, 15);
            this.labelBirimFiyat.TabIndex = 44;
            this.labelBirimFiyat.Text = "Birim Fiyat";
            // 
            // textBoxBirimFiyat
            // 
            this.textBoxBirimFiyat.Location = new System.Drawing.Point(120, 105);
            this.textBoxBirimFiyat.MaxLength = 10;
            this.textBoxBirimFiyat.Name = "textBoxBirimFiyat";
            this.textBoxBirimFiyat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxBirimFiyat.Size = new System.Drawing.Size(113, 21);
            this.textBoxBirimFiyat.TabIndex = 20;
            // 
            // ID_Islem
            // 
            this.ID_Islem.AutoSize = true;
            this.ID_Islem.BackColor = System.Drawing.SystemColors.Control;
            this.ID_Islem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Islem.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Islem.Location = new System.Drawing.Point(101, 23);
            this.ID_Islem.Name = "ID_Islem";
            this.ID_Islem.Size = new System.Drawing.Size(13, 15);
            this.ID_Islem.TabIndex = 42;
            this.ID_Islem.Text = "0";
            // 
            // comboBoxDemirbas
            // 
            this.comboBoxDemirbas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDemirbas.FormattingEnabled = true;
            this.comboBoxDemirbas.Location = new System.Drawing.Point(120, 49);
            this.comboBoxDemirbas.Name = "comboBoxDemirbas";
            this.comboBoxDemirbas.Size = new System.Drawing.Size(515, 23);
            this.comboBoxDemirbas.TabIndex = 18;
            // 
            // labelMiktar
            // 
            this.labelMiktar.AutoSize = true;
            this.labelMiktar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelMiktar.Location = new System.Drawing.Point(11, 81);
            this.labelMiktar.Name = "labelMiktar";
            this.labelMiktar.Size = new System.Drawing.Size(44, 15);
            this.labelMiktar.TabIndex = 36;
            this.labelMiktar.Text = "Miktar";
            // 
            // textBoxMiktar
            // 
            this.textBoxMiktar.Location = new System.Drawing.Point(120, 78);
            this.textBoxMiktar.MaxLength = 5;
            this.textBoxMiktar.Name = "textBoxMiktar";
            this.textBoxMiktar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxMiktar.Size = new System.Drawing.Size(113, 21);
            this.textBoxMiktar.TabIndex = 19;
            // 
            // dataGridViewIslemler
            // 
            this.dataGridViewIslemler.AutoGenerateColumns = false;
            this.dataGridViewIslemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIslemler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.AmbarFaturaID,
            this.DemirbasID,
            this.firmaAdiDataGridViewTextBoxColumn,
            this.faturaTarihiDataGridViewTextBoxColumn,
            this.FaturaNo,
            this.IslemTuru,
            this.DemirbasKodu,
            this.DemirbasAdi,
            this.Miktar,
            this.DemirbasBirimi,
            this.BirimFiyat});
            this.dataGridViewIslemler.DataSource = this.sorguAmbarIslemDemirbasBindingSource;
            this.dataGridViewIslemler.Location = new System.Drawing.Point(8, 249);
            this.dataGridViewIslemler.Name = "dataGridViewIslemler";
            this.dataGridViewIslemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewIslemler.Size = new System.Drawing.Size(893, 367);
            this.dataGridViewIslemler.TabIndex = 17;
            // 
            // labelDemirbasşAdi
            // 
            this.labelDemirbasşAdi.AutoSize = true;
            this.labelDemirbasşAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDemirbasşAdi.Location = new System.Drawing.Point(11, 54);
            this.labelDemirbasşAdi.Name = "labelDemirbasşAdi";
            this.labelDemirbasşAdi.Size = new System.Drawing.Size(78, 15);
            this.labelDemirbasşAdi.TabIndex = 2;
            this.labelDemirbasşAdi.Text = "Demirbaş Adı";
            // 
            // groupBoxFaturalar
            // 
            this.groupBoxFaturalar.Controls.Add(this.textBoxFiltreIslemTuru);
            this.groupBoxFaturalar.Controls.Add(this.textBoxFiltreFaturaNo);
            this.groupBoxFaturalar.Controls.Add(this.labelFiltre);
            this.groupBoxFaturalar.Controls.Add(this.textBoxFiltreFirmaAdi);
            this.groupBoxFaturalar.Controls.Add(this.labelBirimFiyat);
            this.groupBoxFaturalar.Controls.Add(this.ID_Islem);
            this.groupBoxFaturalar.Controls.Add(this.textBoxBirimFiyat);
            this.groupBoxFaturalar.Controls.Add(this.comboBoxFatura);
            this.groupBoxFaturalar.Controls.Add(this.comboBoxDemirbas);
            this.groupBoxFaturalar.Controls.Add(this.labelMiktar);
            this.groupBoxFaturalar.Controls.Add(this.textBoxMiktar);
            this.groupBoxFaturalar.Controls.Add(this.buttonSonKayit);
            this.groupBoxFaturalar.Controls.Add(this.buttonIlkKayit);
            this.groupBoxFaturalar.Controls.Add(this.dataGridViewIslemler);
            this.groupBoxFaturalar.Controls.Add(this.buttonSil);
            this.groupBoxFaturalar.Controls.Add(this.buttonGuncelle);
            this.groupBoxFaturalar.Controls.Add(this.buttonGeri);
            this.groupBoxFaturalar.Controls.Add(this.labelDemirbasşAdi);
            this.groupBoxFaturalar.Controls.Add(this.buttonKaydet);
            this.groupBoxFaturalar.Controls.Add(this.buttonIleri);
            this.groupBoxFaturalar.Controls.Add(this.buttonYeniKayit);
            this.groupBoxFaturalar.Controls.Add(this.labelFatura);
            this.groupBoxFaturalar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFaturalar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxFaturalar.Name = "groupBoxFaturalar";
            this.groupBoxFaturalar.Size = new System.Drawing.Size(912, 626);
            this.groupBoxFaturalar.TabIndex = 24;
            this.groupBoxFaturalar.TabStop = false;
            this.groupBoxFaturalar.Text = "Fatura Bilgileri";
            // 
            // textBoxFiltreFaturaNo
            // 
            this.textBoxFiltreFaturaNo.Location = new System.Drawing.Point(291, 222);
            this.textBoxFiltreFaturaNo.MaxLength = 40;
            this.textBoxFiltreFaturaNo.Name = "textBoxFiltreFaturaNo";
            this.textBoxFiltreFaturaNo.Size = new System.Drawing.Size(47, 21);
            this.textBoxFiltreFaturaNo.TabIndex = 15;
            this.textBoxFiltreFaturaNo.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiltre.Location = new System.Drawing.Point(10, 225);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 48;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreFirmaAdi
            // 
            this.textBoxFiltreFirmaAdi.Location = new System.Drawing.Point(53, 222);
            this.textBoxFiltreFirmaAdi.MaxLength = 40;
            this.textBoxFiltreFirmaAdi.Name = "textBoxFiltreFirmaAdi";
            this.textBoxFiltreFirmaAdi.Size = new System.Drawing.Size(236, 21);
            this.textBoxFiltreFirmaAdi.TabIndex = 14;
            this.textBoxFiltreFirmaAdi.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // comboBoxFatura
            // 
            this.comboBoxFatura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFatura.FormattingEnabled = true;
            this.comboBoxFatura.Location = new System.Drawing.Point(120, 20);
            this.comboBoxFatura.Name = "comboBoxFatura";
            this.comboBoxFatura.Size = new System.Drawing.Size(515, 23);
            this.comboBoxFatura.TabIndex = 0;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(420, 175);
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
            this.buttonIlkKayit.Location = new System.Drawing.Point(120, 175);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 10;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(420, 140);
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
            this.buttonGuncelle.Location = new System.Drawing.Point(320, 140);
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
            this.buttonGeri.Location = new System.Drawing.Point(220, 175);
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
            this.buttonKaydet.Location = new System.Drawing.Point(220, 140);
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
            this.buttonIleri.Location = new System.Drawing.Point(320, 175);
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
            this.buttonYeniKayit.Location = new System.Drawing.Point(120, 140);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(79, 28);
            this.buttonYeniKayit.TabIndex = 6;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelFatura
            // 
            this.labelFatura.AutoSize = true;
            this.labelFatura.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFatura.Location = new System.Drawing.Point(11, 25);
            this.labelFatura.Name = "labelFatura";
            this.labelFatura.Size = new System.Drawing.Size(42, 15);
            this.labelFatura.TabIndex = 2;
            this.labelFatura.Text = "Fatura";
            // 
            // sorguAmbarIslemDemirbasBindingSource
            // 
            this.sorguAmbarIslemDemirbasBindingSource.DataMember = "SorguAmbarIslemDemirbas";
            this.sorguAmbarIslemDemirbasBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sorguAmbarIslemDemirbasTableAdapter
            // 
            this.sorguAmbarIslemDemirbasTableAdapter.ClearBeforeFill = true;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = false;
            // 
            // AmbarFaturaID
            // 
            this.AmbarFaturaID.DataPropertyName = "AmbarFaturaID";
            this.AmbarFaturaID.HeaderText = "AmbarFaturaID";
            this.AmbarFaturaID.Name = "AmbarFaturaID";
            this.AmbarFaturaID.Visible = false;
            // 
            // DemirbasID
            // 
            this.DemirbasID.DataPropertyName = "DemirbasID";
            this.DemirbasID.HeaderText = "DemirbasID";
            this.DemirbasID.Name = "DemirbasID";
            this.DemirbasID.Visible = false;
            // 
            // firmaAdiDataGridViewTextBoxColumn
            // 
            this.firmaAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.HeaderText = "Firma Adı";
            this.firmaAdiDataGridViewTextBoxColumn.Name = "firmaAdiDataGridViewTextBoxColumn";
            this.firmaAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.firmaAdiDataGridViewTextBoxColumn.Width = 160;
            // 
            // faturaTarihiDataGridViewTextBoxColumn
            // 
            this.faturaTarihiDataGridViewTextBoxColumn.DataPropertyName = "FaturaTarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.HeaderText = "Fatura Tarihi";
            this.faturaTarihiDataGridViewTextBoxColumn.Name = "faturaTarihiDataGridViewTextBoxColumn";
            this.faturaTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.faturaTarihiDataGridViewTextBoxColumn.Width = 80;
            // 
            // FaturaNo
            // 
            this.FaturaNo.DataPropertyName = "FaturaNo";
            this.FaturaNo.HeaderText = "Fatura No";
            this.FaturaNo.Name = "FaturaNo";
            this.FaturaNo.ReadOnly = true;
            this.FaturaNo.Width = 50;
            // 
            // IslemTuru
            // 
            this.IslemTuru.DataPropertyName = "IslemTuru";
            this.IslemTuru.HeaderText = "İşlem Türü";
            this.IslemTuru.Name = "IslemTuru";
            this.IslemTuru.ReadOnly = true;
            this.IslemTuru.Width = 80;
            // 
            // DemirbasKodu
            // 
            this.DemirbasKodu.DataPropertyName = "DemirbasKodu";
            this.DemirbasKodu.HeaderText = "Kodu";
            this.DemirbasKodu.Name = "DemirbasKodu";
            this.DemirbasKodu.ReadOnly = true;
            this.DemirbasKodu.Width = 60;
            // 
            // DemirbasAdi
            // 
            this.DemirbasAdi.DataPropertyName = "DemirbasAdi";
            this.DemirbasAdi.HeaderText = "Demirbaş Adı";
            this.DemirbasAdi.Name = "DemirbasAdi";
            this.DemirbasAdi.ReadOnly = true;
            this.DemirbasAdi.Width = 210;
            // 
            // Miktar
            // 
            this.Miktar.DataPropertyName = "Miktar";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle9.Format = "N0";
            dataGridViewCellStyle9.NullValue = null;
            this.Miktar.DefaultCellStyle = dataGridViewCellStyle9;
            this.Miktar.HeaderText = "Miktarı";
            this.Miktar.Name = "Miktar";
            this.Miktar.Width = 60;
            // 
            // DemirbasBirimi
            // 
            this.DemirbasBirimi.DataPropertyName = "DemirbasBirimi";
            this.DemirbasBirimi.HeaderText = "Birimi";
            this.DemirbasBirimi.Name = "DemirbasBirimi";
            this.DemirbasBirimi.ReadOnly = true;
            this.DemirbasBirimi.Width = 50;
            // 
            // BirimFiyat
            // 
            this.BirimFiyat.DataPropertyName = "BirimFiyat";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle10.Format = "C2";
            dataGridViewCellStyle10.NullValue = null;
            this.BirimFiyat.DefaultCellStyle = dataGridViewCellStyle10;
            this.BirimFiyat.HeaderText = "Birim Fiyatı";
            this.BirimFiyat.Name = "BirimFiyat";
            this.BirimFiyat.ReadOnly = true;
            // 
            // textBoxFiltreIslemTuru
            // 
            this.textBoxFiltreIslemTuru.Location = new System.Drawing.Point(341, 222);
            this.textBoxFiltreIslemTuru.MaxLength = 40;
            this.textBoxFiltreIslemTuru.Name = "textBoxFiltreIslemTuru";
            this.textBoxFiltreIslemTuru.Size = new System.Drawing.Size(78, 21);
            this.textBoxFiltreIslemTuru.TabIndex = 16;
            this.textBoxFiltreIslemTuru.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // FormIslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 650);
            this.Controls.Add(this.groupBoxFaturalar);
            this.Name = "FormIslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Fatura Ayrıntıları ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormIslem_FormClosed);
            this.Load += new System.EventHandler(this.FormIslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIslemler)).EndInit();
            this.groupBoxFaturalar.ResumeLayout(false);
            this.groupBoxFaturalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sorguAmbarIslemDemirbasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelBirimFiyat;
        private System.Windows.Forms.TextBox textBoxBirimFiyat;
        private System.Windows.Forms.Label ID_Islem;
        private System.Windows.Forms.ComboBox comboBoxDemirbas;
        private System.Windows.Forms.Label labelMiktar;
        private System.Windows.Forms.TextBox textBoxMiktar;
        private System.Windows.Forms.DataGridView dataGridViewIslemler;
        private System.Windows.Forms.Label labelDemirbasşAdi;
        private System.Windows.Forms.GroupBox groupBoxFaturalar;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelFatura;
        private System.Windows.Forms.ComboBox comboBoxFatura;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sorguAmbarIslemDemirbasBindingSource;
        private DemirbasTakipDataSetTableAdapters.SorguAmbarIslemDemirbasTableAdapter sorguAmbarIslemDemirbasTableAdapter;
        private System.Windows.Forms.TextBox textBoxFiltreFaturaNo;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreFirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmbarFaturaID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasID;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn faturaTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FaturaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IslemTuru;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasKodu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Miktar;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemirbasBirimi;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimFiyat;
        private System.Windows.Forms.TextBox textBoxFiltreIslemTuru;
    }
}