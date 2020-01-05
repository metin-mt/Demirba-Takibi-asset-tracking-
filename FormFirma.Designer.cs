namespace DemirbasTakip
{
    partial class FormFirma
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
            this.groupBoxFirmalar = new System.Windows.Forms.GroupBox();
            this.ID_Firma = new System.Windows.Forms.Label();
            this.textBoxFiltreFirmaSehir = new System.Windows.Forms.TextBox();
            this.comboBoxSehir = new System.Windows.Forms.ComboBox();
            this.labelEPosta = new System.Windows.Forms.Label();
            this.textBoxEPosta = new System.Windows.Forms.TextBox();
            this.labelFaks = new System.Windows.Forms.Label();
            this.textBoxFaks = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.textBoxFiltreFirmaAdres = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreFirmaAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelFirmaSehir = new System.Windows.Forms.Label();
            this.labelFirmaAdresi = new System.Windows.Forms.Label();
            this.textBoxFirmaAdresi = new System.Windows.Forms.TextBox();
            this.dataGridViewFirmalar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaSehirID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaTelefon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaFaks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirmaEPosta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SehirAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaAdresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaSehirIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaFaksDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firmaEPostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorguFirmaSehirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelFirmaAdi = new System.Windows.Forms.Label();
            this.textBoxFirmaAdi = new System.Windows.Forms.TextBox();
            this.sorguFirmaSehirTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SorguFirmaSehirTableAdapter();
            this.groupBoxFirmalar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirmalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguFirmaSehirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxFirmalar
            // 
            this.groupBoxFirmalar.Controls.Add(this.ID_Firma);
            this.groupBoxFirmalar.Controls.Add(this.textBoxFiltreFirmaSehir);
            this.groupBoxFirmalar.Controls.Add(this.comboBoxSehir);
            this.groupBoxFirmalar.Controls.Add(this.labelEPosta);
            this.groupBoxFirmalar.Controls.Add(this.textBoxEPosta);
            this.groupBoxFirmalar.Controls.Add(this.labelFaks);
            this.groupBoxFirmalar.Controls.Add(this.textBoxFaks);
            this.groupBoxFirmalar.Controls.Add(this.labelTelefon);
            this.groupBoxFirmalar.Controls.Add(this.textBoxTelefon);
            this.groupBoxFirmalar.Controls.Add(this.buttonSonKayit);
            this.groupBoxFirmalar.Controls.Add(this.buttonIlkKayit);
            this.groupBoxFirmalar.Controls.Add(this.textBoxFiltreFirmaAdres);
            this.groupBoxFirmalar.Controls.Add(this.labelFiltre);
            this.groupBoxFirmalar.Controls.Add(this.textBoxFiltreFirmaAdi);
            this.groupBoxFirmalar.Controls.Add(this.buttonSil);
            this.groupBoxFirmalar.Controls.Add(this.buttonGuncelle);
            this.groupBoxFirmalar.Controls.Add(this.buttonGeri);
            this.groupBoxFirmalar.Controls.Add(this.buttonKaydet);
            this.groupBoxFirmalar.Controls.Add(this.buttonIleri);
            this.groupBoxFirmalar.Controls.Add(this.buttonYeniKayit);
            this.groupBoxFirmalar.Controls.Add(this.labelFirmaSehir);
            this.groupBoxFirmalar.Controls.Add(this.labelFirmaAdresi);
            this.groupBoxFirmalar.Controls.Add(this.textBoxFirmaAdresi);
            this.groupBoxFirmalar.Controls.Add(this.dataGridViewFirmalar);
            this.groupBoxFirmalar.Controls.Add(this.labelFirmaAdi);
            this.groupBoxFirmalar.Controls.Add(this.textBoxFirmaAdi);
            this.groupBoxFirmalar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxFirmalar.Location = new System.Drawing.Point(12, 8);
            this.groupBoxFirmalar.Name = "groupBoxFirmalar";
            this.groupBoxFirmalar.Size = new System.Drawing.Size(791, 576);
            this.groupBoxFirmalar.TabIndex = 21;
            this.groupBoxFirmalar.TabStop = false;
            this.groupBoxFirmalar.Text = "Firma Bilgileri";
            // 
            // ID_Firma
            // 
            this.ID_Firma.AutoSize = true;
            this.ID_Firma.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Firma.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Firma.Location = new System.Drawing.Point(562, 30);
            this.ID_Firma.Name = "ID_Firma";
            this.ID_Firma.Size = new System.Drawing.Size(13, 15);
            this.ID_Firma.TabIndex = 43;
            this.ID_Firma.Text = "0";
            // 
            // textBoxFiltreFirmaSehir
            // 
            this.textBoxFiltreFirmaSehir.Location = new System.Drawing.Point(611, 264);
            this.textBoxFiltreFirmaSehir.MaxLength = 40;
            this.textBoxFiltreFirmaSehir.Name = "textBoxFiltreFirmaSehir";
            this.textBoxFiltreFirmaSehir.Size = new System.Drawing.Size(161, 21);
            this.textBoxFiltreFirmaSehir.TabIndex = 16;
            this.textBoxFiltreFirmaSehir.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // comboBoxSehir
            // 
            this.comboBoxSehir.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSehir.FormattingEnabled = true;
            this.comboBoxSehir.Location = new System.Drawing.Point(124, 77);
            this.comboBoxSehir.Name = "comboBoxSehir";
            this.comboBoxSehir.Size = new System.Drawing.Size(225, 23);
            this.comboBoxSehir.TabIndex = 2;
            // 
            // labelEPosta
            // 
            this.labelEPosta.AutoSize = true;
            this.labelEPosta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEPosta.Location = new System.Drawing.Point(15, 165);
            this.labelEPosta.Name = "labelEPosta";
            this.labelEPosta.Size = new System.Drawing.Size(81, 15);
            this.labelEPosta.TabIndex = 38;
            this.labelEPosta.Text = "E Posta Adresi";
            // 
            // textBoxEPosta
            // 
            this.textBoxEPosta.Location = new System.Drawing.Point(124, 162);
            this.textBoxEPosta.MaxLength = 100;
            this.textBoxEPosta.Name = "textBoxEPosta";
            this.textBoxEPosta.Size = new System.Drawing.Size(225, 21);
            this.textBoxEPosta.TabIndex = 5;
            // 
            // labelFaks
            // 
            this.labelFaks.AutoSize = true;
            this.labelFaks.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFaks.Location = new System.Drawing.Point(15, 138);
            this.labelFaks.Name = "labelFaks";
            this.labelFaks.Size = new System.Drawing.Size(32, 15);
            this.labelFaks.TabIndex = 36;
            this.labelFaks.Text = "Faks";
            // 
            // textBoxFaks
            // 
            this.textBoxFaks.Location = new System.Drawing.Point(124, 135);
            this.textBoxFaks.MaxLength = 15;
            this.textBoxFaks.Name = "textBoxFaks";
            this.textBoxFaks.Size = new System.Drawing.Size(115, 21);
            this.textBoxFaks.TabIndex = 4;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.Location = new System.Drawing.Point(15, 111);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(47, 15);
            this.labelTelefon.TabIndex = 34;
            this.labelTelefon.Text = "Telefon";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(124, 108);
            this.textBoxTelefon.MaxLength = 15;
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(115, 21);
            this.textBoxTelefon.TabIndex = 3;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(424, 228);
            this.buttonSonKayit.Name = "buttonSonKayit";
            this.buttonSonKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonSonKayit.TabIndex = 14;
            this.buttonSonKayit.Text = "Son Kayıt";
            this.buttonSonKayit.UseVisualStyleBackColor = true;
            this.buttonSonKayit.Click += new System.EventHandler(this.buttonSonKayit_Click);
            // 
            // buttonIlkKayit
            // 
            this.buttonIlkKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIlkKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonIlkKayit.Location = new System.Drawing.Point(124, 228);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 10;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // textBoxFiltreFirmaAdres
            // 
            this.textBoxFiltreFirmaAdres.Location = new System.Drawing.Point(332, 264);
            this.textBoxFiltreFirmaAdres.MaxLength = 40;
            this.textBoxFiltreFirmaAdres.Name = "textBoxFiltreFirmaAdres";
            this.textBoxFiltreFirmaAdres.Size = new System.Drawing.Size(276, 21);
            this.textBoxFiltreFirmaAdres.TabIndex = 15;
            this.textBoxFiltreFirmaAdres.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiltre.Location = new System.Drawing.Point(5, 267);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 29;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreFirmaAdi
            // 
            this.textBoxFiltreFirmaAdi.Location = new System.Drawing.Point(53, 264);
            this.textBoxFiltreFirmaAdi.MaxLength = 40;
            this.textBoxFiltreFirmaAdi.Name = "textBoxFiltreFirmaAdi";
            this.textBoxFiltreFirmaAdi.Size = new System.Drawing.Size(276, 21);
            this.textBoxFiltreFirmaAdi.TabIndex = 14;
            this.textBoxFiltreFirmaAdi.TextChanged += new System.EventHandler(this.textBoxFiltreFirmaAdi_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(424, 189);
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
            this.buttonGuncelle.Location = new System.Drawing.Point(324, 189);
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
            this.buttonGeri.Location = new System.Drawing.Point(224, 228);
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
            this.buttonKaydet.Location = new System.Drawing.Point(224, 189);
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
            this.buttonIleri.Location = new System.Drawing.Point(324, 228);
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
            this.buttonYeniKayit.Location = new System.Drawing.Point(124, 189);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 6;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelFirmaSehir
            // 
            this.labelFirmaSehir.AutoSize = true;
            this.labelFirmaSehir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFirmaSehir.Location = new System.Drawing.Point(15, 84);
            this.labelFirmaSehir.Name = "labelFirmaSehir";
            this.labelFirmaSehir.Size = new System.Drawing.Size(37, 15);
            this.labelFirmaSehir.TabIndex = 6;
            this.labelFirmaSehir.Text = "Şehir";
            // 
            // labelFirmaAdresi
            // 
            this.labelFirmaAdresi.AutoSize = true;
            this.labelFirmaAdresi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFirmaAdresi.Location = new System.Drawing.Point(15, 57);
            this.labelFirmaAdresi.Name = "labelFirmaAdresi";
            this.labelFirmaAdresi.Size = new System.Drawing.Size(41, 15);
            this.labelFirmaAdresi.TabIndex = 4;
            this.labelFirmaAdresi.Text = "Adresi";
            // 
            // textBoxFirmaAdresi
            // 
            this.textBoxFirmaAdresi.Location = new System.Drawing.Point(124, 54);
            this.textBoxFirmaAdresi.MaxLength = 100;
            this.textBoxFirmaAdresi.Name = "textBoxFirmaAdresi";
            this.textBoxFirmaAdresi.Size = new System.Drawing.Size(432, 21);
            this.textBoxFirmaAdresi.TabIndex = 1;
            // 
            // dataGridViewFirmalar
            // 
            this.dataGridViewFirmalar.AutoGenerateColumns = false;
            this.dataGridViewFirmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FirmaAdi,
            this.FirmaAdres,
            this.FirmaSehirID,
            this.FirmaTelefon,
            this.FirmaFaks,
            this.FirmaEPosta,
            this.SehirAdi,
            this.ıDDataGridViewTextBoxColumn,
            this.firmaAdiDataGridViewTextBoxColumn,
            this.firmaAdresDataGridViewTextBoxColumn,
            this.firmaSehirIDDataGridViewTextBoxColumn,
            this.firmaTelefonDataGridViewTextBoxColumn,
            this.firmaFaksDataGridViewTextBoxColumn,
            this.firmaEPostaDataGridViewTextBoxColumn,
            this.sehirAdiDataGridViewTextBoxColumn});
            this.dataGridViewFirmalar.DataSource = this.sorguFirmaSehirBindingSource;
            this.dataGridViewFirmalar.Location = new System.Drawing.Point(8, 293);
            this.dataGridViewFirmalar.Name = "dataGridViewFirmalar";
            this.dataGridViewFirmalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewFirmalar.Size = new System.Drawing.Size(765, 277);
            this.dataGridViewFirmalar.TabIndex = 17;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // FirmaAdi
            // 
            this.FirmaAdi.DataPropertyName = "FirmaAdi";
            this.FirmaAdi.HeaderText = "Firma Adı";
            this.FirmaAdi.Name = "FirmaAdi";
            this.FirmaAdi.ReadOnly = true;
            this.FirmaAdi.Width = 280;
            // 
            // FirmaAdres
            // 
            this.FirmaAdres.DataPropertyName = "FirmaAdres";
            this.FirmaAdres.HeaderText = "Adres";
            this.FirmaAdres.Name = "FirmaAdres";
            this.FirmaAdres.ReadOnly = true;
            this.FirmaAdres.Width = 280;
            // 
            // FirmaSehirID
            // 
            this.FirmaSehirID.DataPropertyName = "FirmaSehirID";
            this.FirmaSehirID.HeaderText = "FirmaSehirID";
            this.FirmaSehirID.Name = "FirmaSehirID";
            this.FirmaSehirID.ReadOnly = true;
            this.FirmaSehirID.Visible = false;
            // 
            // FirmaTelefon
            // 
            this.FirmaTelefon.DataPropertyName = "FirmaTelefon";
            this.FirmaTelefon.HeaderText = "FirmaTelefon";
            this.FirmaTelefon.Name = "FirmaTelefon";
            this.FirmaTelefon.ReadOnly = true;
            this.FirmaTelefon.Visible = false;
            // 
            // FirmaFaks
            // 
            this.FirmaFaks.DataPropertyName = "FirmaFaks";
            this.FirmaFaks.HeaderText = "FirmaFaks";
            this.FirmaFaks.Name = "FirmaFaks";
            this.FirmaFaks.ReadOnly = true;
            this.FirmaFaks.Visible = false;
            // 
            // FirmaEPosta
            // 
            this.FirmaEPosta.DataPropertyName = "FirmaEPosta";
            this.FirmaEPosta.HeaderText = "FirmaEPosta";
            this.FirmaEPosta.Name = "FirmaEPosta";
            this.FirmaEPosta.ReadOnly = true;
            this.FirmaEPosta.Visible = false;
            // 
            // SehirAdi
            // 
            this.SehirAdi.DataPropertyName = "SehirAdi";
            this.SehirAdi.HeaderText = "Şehir";
            this.SehirAdi.Name = "SehirAdi";
            this.SehirAdi.ReadOnly = true;
            this.SehirAdi.Width = 160;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            // 
            // firmaAdiDataGridViewTextBoxColumn
            // 
            this.firmaAdiDataGridViewTextBoxColumn.DataPropertyName = "FirmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.HeaderText = "FirmaAdi";
            this.firmaAdiDataGridViewTextBoxColumn.Name = "firmaAdiDataGridViewTextBoxColumn";
            // 
            // firmaAdresDataGridViewTextBoxColumn
            // 
            this.firmaAdresDataGridViewTextBoxColumn.DataPropertyName = "FirmaAdres";
            this.firmaAdresDataGridViewTextBoxColumn.HeaderText = "FirmaAdres";
            this.firmaAdresDataGridViewTextBoxColumn.Name = "firmaAdresDataGridViewTextBoxColumn";
            // 
            // firmaSehirIDDataGridViewTextBoxColumn
            // 
            this.firmaSehirIDDataGridViewTextBoxColumn.DataPropertyName = "FirmaSehirID";
            this.firmaSehirIDDataGridViewTextBoxColumn.HeaderText = "FirmaSehirID";
            this.firmaSehirIDDataGridViewTextBoxColumn.Name = "firmaSehirIDDataGridViewTextBoxColumn";
            // 
            // firmaTelefonDataGridViewTextBoxColumn
            // 
            this.firmaTelefonDataGridViewTextBoxColumn.DataPropertyName = "FirmaTelefon";
            this.firmaTelefonDataGridViewTextBoxColumn.HeaderText = "FirmaTelefon";
            this.firmaTelefonDataGridViewTextBoxColumn.Name = "firmaTelefonDataGridViewTextBoxColumn";
            // 
            // firmaFaksDataGridViewTextBoxColumn
            // 
            this.firmaFaksDataGridViewTextBoxColumn.DataPropertyName = "FirmaFaks";
            this.firmaFaksDataGridViewTextBoxColumn.HeaderText = "FirmaFaks";
            this.firmaFaksDataGridViewTextBoxColumn.Name = "firmaFaksDataGridViewTextBoxColumn";
            // 
            // firmaEPostaDataGridViewTextBoxColumn
            // 
            this.firmaEPostaDataGridViewTextBoxColumn.DataPropertyName = "FirmaEPosta";
            this.firmaEPostaDataGridViewTextBoxColumn.HeaderText = "FirmaEPosta";
            this.firmaEPostaDataGridViewTextBoxColumn.Name = "firmaEPostaDataGridViewTextBoxColumn";
            // 
            // sehirAdiDataGridViewTextBoxColumn
            // 
            this.sehirAdiDataGridViewTextBoxColumn.DataPropertyName = "SehirAdi";
            this.sehirAdiDataGridViewTextBoxColumn.HeaderText = "SehirAdi";
            this.sehirAdiDataGridViewTextBoxColumn.Name = "sehirAdiDataGridViewTextBoxColumn";
            // 
            // sorguFirmaSehirBindingSource
            // 
            this.sorguFirmaSehirBindingSource.DataMember = "SorguFirmaSehir";
            this.sorguFirmaSehirBindingSource.DataSource = this.demirbasTakipDataSet;
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
            this.labelFirmaAdi.Location = new System.Drawing.Point(15, 30);
            this.labelFirmaAdi.Name = "labelFirmaAdi";
            this.labelFirmaAdi.Size = new System.Drawing.Size(59, 15);
            this.labelFirmaAdi.TabIndex = 2;
            this.labelFirmaAdi.Text = "Firma Adı";
            // 
            // textBoxFirmaAdi
            // 
            this.textBoxFirmaAdi.Location = new System.Drawing.Point(124, 27);
            this.textBoxFirmaAdi.MaxLength = 100;
            this.textBoxFirmaAdi.Name = "textBoxFirmaAdi";
            this.textBoxFirmaAdi.Size = new System.Drawing.Size(432, 21);
            this.textBoxFirmaAdi.TabIndex = 0;
            // 
            // sorguFirmaSehirTableAdapter
            // 
            this.sorguFirmaSehirTableAdapter.ClearBeforeFill = true;
            // 
            // FormFirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 598);
            this.Controls.Add(this.groupBoxFirmalar);
            this.Name = "FormFirma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Firmalar ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFirma_FormClosed);
            this.Load += new System.EventHandler(this.FormFirma_Load);
            this.groupBoxFirmalar.ResumeLayout(false);
            this.groupBoxFirmalar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirmalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguFirmaSehirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxFirmalar;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.TextBox textBoxFiltreFirmaAdres;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreFirmaAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelFirmaSehir;
        private System.Windows.Forms.Label labelFirmaAdresi;
        private System.Windows.Forms.TextBox textBoxFirmaAdresi;
        private System.Windows.Forms.DataGridView dataGridViewFirmalar;
        private System.Windows.Forms.Label labelFirmaAdi;
        private System.Windows.Forms.TextBox textBoxFirmaAdi;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Label labelEPosta;
        private System.Windows.Forms.TextBox textBoxEPosta;
        private System.Windows.Forms.Label labelFaks;
        private System.Windows.Forms.TextBox textBoxFaks;
        private System.Windows.Forms.ComboBox comboBoxSehir;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sorguFirmaSehirBindingSource;
        private DemirbasTakipDataSetTableAdapters.SorguFirmaSehirTableAdapter sorguFirmaSehirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdi;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaSehirID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaTelefon;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaFaks;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirmaEPosta;
        private System.Windows.Forms.DataGridViewTextBoxColumn SehirAdi;
        private System.Windows.Forms.TextBox textBoxFiltreFirmaSehir;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaAdresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaSehirIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaFaksDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firmaEPostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Firma;
    }
}