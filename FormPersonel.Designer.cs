namespace DemirbasTakip
{
    partial class FormPersonel
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
            this.textBoxFiltreBirimi = new System.Windows.Forms.TextBox();
            this.comboBoxCalistigiBirim = new System.Windows.Forms.ComboBox();
            this.labelCalistigiBirim = new System.Windows.Forms.Label();
            this.labelKurumSicilNo = new System.Windows.Forms.Label();
            this.textBoxKurumSicilNo = new System.Windows.Forms.TextBox();
            this.labelTCKimlikNo = new System.Windows.Forms.Label();
            this.textBoxTCKimlikNo = new System.Windows.Forms.TextBox();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.labelCinsiyeti = new System.Windows.Forms.Label();
            this.textBoxFiltreUnvani = new System.Windows.Forms.TextBox();
            this.comboBoxUnvan = new System.Windows.Forms.ComboBox();
            this.labelEPosta = new System.Windows.Forms.Label();
            this.textBoxEPosta = new System.Windows.Forms.TextBox();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.textBoxTelefon = new System.Windows.Forms.TextBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.textBoxFiltreSoyadi = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelUnvan = new System.Windows.Forms.Label();
            this.labelSoyadi = new System.Windows.Forms.Label();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.dataGridViewPersonel = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tCKimlikNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kurumSicilNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calistigiBirimIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ePostaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorguPersonelUnvanBirimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelAdi = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.sorguPersonelUnvanBirimTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SorguPersonelUnvanBirimTableAdapter();
            this.groupBoxPersonel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguPersonelUnvanBirimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPersonel
            // 
            this.groupBoxPersonel.Controls.Add(this.ID_Personel);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreBirimi);
            this.groupBoxPersonel.Controls.Add(this.comboBoxCalistigiBirim);
            this.groupBoxPersonel.Controls.Add(this.labelCalistigiBirim);
            this.groupBoxPersonel.Controls.Add(this.labelKurumSicilNo);
            this.groupBoxPersonel.Controls.Add(this.textBoxKurumSicilNo);
            this.groupBoxPersonel.Controls.Add(this.labelTCKimlikNo);
            this.groupBoxPersonel.Controls.Add(this.textBoxTCKimlikNo);
            this.groupBoxPersonel.Controls.Add(this.comboBoxCinsiyet);
            this.groupBoxPersonel.Controls.Add(this.labelCinsiyeti);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreUnvani);
            this.groupBoxPersonel.Controls.Add(this.comboBoxUnvan);
            this.groupBoxPersonel.Controls.Add(this.labelEPosta);
            this.groupBoxPersonel.Controls.Add(this.textBoxEPosta);
            this.groupBoxPersonel.Controls.Add(this.labelTelefon);
            this.groupBoxPersonel.Controls.Add(this.textBoxTelefon);
            this.groupBoxPersonel.Controls.Add(this.buttonSonKayit);
            this.groupBoxPersonel.Controls.Add(this.buttonIlkKayit);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreSoyadi);
            this.groupBoxPersonel.Controls.Add(this.labelFiltre);
            this.groupBoxPersonel.Controls.Add(this.textBoxFiltreAdi);
            this.groupBoxPersonel.Controls.Add(this.buttonSil);
            this.groupBoxPersonel.Controls.Add(this.buttonGuncelle);
            this.groupBoxPersonel.Controls.Add(this.buttonGeri);
            this.groupBoxPersonel.Controls.Add(this.buttonKaydet);
            this.groupBoxPersonel.Controls.Add(this.buttonIleri);
            this.groupBoxPersonel.Controls.Add(this.buttonYeniKayit);
            this.groupBoxPersonel.Controls.Add(this.labelUnvan);
            this.groupBoxPersonel.Controls.Add(this.labelSoyadi);
            this.groupBoxPersonel.Controls.Add(this.textBoxSoyadi);
            this.groupBoxPersonel.Controls.Add(this.dataGridViewPersonel);
            this.groupBoxPersonel.Controls.Add(this.labelAdi);
            this.groupBoxPersonel.Controls.Add(this.textBoxAdi);
            this.groupBoxPersonel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxPersonel.Location = new System.Drawing.Point(12, 12);
            this.groupBoxPersonel.Name = "groupBoxPersonel";
            this.groupBoxPersonel.Size = new System.Drawing.Size(771, 607);
            this.groupBoxPersonel.TabIndex = 22;
            this.groupBoxPersonel.TabStop = false;
            this.groupBoxPersonel.Text = "Personel Bilgileri";
            this.groupBoxPersonel.Enter += new System.EventHandler(this.groupBoxPersonel_Enter);
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
            // textBoxFiltreBirimi
            // 
            this.textBoxFiltreBirimi.Location = new System.Drawing.Point(609, 264);
            this.textBoxFiltreBirimi.MaxLength = 40;
            this.textBoxFiltreBirimi.Name = "textBoxFiltreBirimi";
            this.textBoxFiltreBirimi.Size = new System.Drawing.Size(150, 21);
            this.textBoxFiltreBirimi.TabIndex = 20;
            this.textBoxFiltreBirimi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // comboBoxCalistigiBirim
            // 
            this.comboBoxCalistigiBirim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCalistigiBirim.FormattingEnabled = true;
            this.comboBoxCalistigiBirim.Location = new System.Drawing.Point(124, 106);
            this.comboBoxCalistigiBirim.Name = "comboBoxCalistigiBirim";
            this.comboBoxCalistigiBirim.Size = new System.Drawing.Size(271, 23);
            this.comboBoxCalistigiBirim.TabIndex = 3;
            // 
            // labelCalistigiBirim
            // 
            this.labelCalistigiBirim.AutoSize = true;
            this.labelCalistigiBirim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCalistigiBirim.Location = new System.Drawing.Point(15, 113);
            this.labelCalistigiBirim.Name = "labelCalistigiBirim";
            this.labelCalistigiBirim.Size = new System.Drawing.Size(87, 15);
            this.labelCalistigiBirim.TabIndex = 46;
            this.labelCalistigiBirim.Text = "Çalıştığı Birim";
            // 
            // labelKurumSicilNo
            // 
            this.labelKurumSicilNo.AutoSize = true;
            this.labelKurumSicilNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKurumSicilNo.Location = new System.Drawing.Point(472, 83);
            this.labelKurumSicilNo.Name = "labelKurumSicilNo";
            this.labelKurumSicilNo.Size = new System.Drawing.Size(91, 15);
            this.labelKurumSicilNo.TabIndex = 44;
            this.labelKurumSicilNo.Text = "Kurum Sicil No";
            // 
            // textBoxKurumSicilNo
            // 
            this.textBoxKurumSicilNo.Location = new System.Drawing.Point(581, 80);
            this.textBoxKurumSicilNo.MaxLength = 10;
            this.textBoxKurumSicilNo.Name = "textBoxKurumSicilNo";
            this.textBoxKurumSicilNo.Size = new System.Drawing.Size(122, 21);
            this.textBoxKurumSicilNo.TabIndex = 7;
            // 
            // labelTCKimlikNo
            // 
            this.labelTCKimlikNo.AutoSize = true;
            this.labelTCKimlikNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTCKimlikNo.Location = new System.Drawing.Point(472, 59);
            this.labelTCKimlikNo.Name = "labelTCKimlikNo";
            this.labelTCKimlikNo.Size = new System.Drawing.Size(83, 15);
            this.labelTCKimlikNo.TabIndex = 42;
            this.labelTCKimlikNo.Text = "TC Kimlik No";
            // 
            // textBoxTCKimlikNo
            // 
            this.textBoxTCKimlikNo.Location = new System.Drawing.Point(581, 56);
            this.textBoxTCKimlikNo.MaxLength = 11;
            this.textBoxTCKimlikNo.Name = "textBoxTCKimlikNo";
            this.textBoxTCKimlikNo.Size = new System.Drawing.Size(122, 21);
            this.textBoxTCKimlikNo.TabIndex = 6;
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(581, 26);
            this.comboBoxCinsiyet.MaxLength = 5;
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(122, 23);
            this.comboBoxCinsiyet.TabIndex = 5;
            // 
            // labelCinsiyeti
            // 
            this.labelCinsiyeti.AutoSize = true;
            this.labelCinsiyeti.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCinsiyeti.Location = new System.Drawing.Point(472, 33);
            this.labelCinsiyeti.Name = "labelCinsiyeti";
            this.labelCinsiyeti.Size = new System.Drawing.Size(56, 15);
            this.labelCinsiyeti.TabIndex = 40;
            this.labelCinsiyeti.Text = "Cinsiyeti";
            // 
            // textBoxFiltreUnvani
            // 
            this.textBoxFiltreUnvani.Location = new System.Drawing.Point(456, 264);
            this.textBoxFiltreUnvani.MaxLength = 40;
            this.textBoxFiltreUnvani.Name = "textBoxFiltreUnvani";
            this.textBoxFiltreUnvani.Size = new System.Drawing.Size(150, 21);
            this.textBoxFiltreUnvani.TabIndex = 19;
            this.textBoxFiltreUnvani.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // comboBoxUnvan
            // 
            this.comboBoxUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxUnvan.FormattingEnabled = true;
            this.comboBoxUnvan.Location = new System.Drawing.Point(124, 77);
            this.comboBoxUnvan.Name = "comboBoxUnvan";
            this.comboBoxUnvan.Size = new System.Drawing.Size(271, 23);
            this.comboBoxUnvan.TabIndex = 2;
            this.comboBoxUnvan.SelectedIndexChanged += new System.EventHandler(this.comboBoxUnvan_SelectedIndexChanged);
            // 
            // labelEPosta
            // 
            this.labelEPosta.AutoSize = true;
            this.labelEPosta.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelEPosta.Location = new System.Drawing.Point(15, 137);
            this.labelEPosta.Name = "labelEPosta";
            this.labelEPosta.Size = new System.Drawing.Size(81, 15);
            this.labelEPosta.TabIndex = 38;
            this.labelEPosta.Text = "E Posta Adresi";
            // 
            // textBoxEPosta
            // 
            this.textBoxEPosta.Location = new System.Drawing.Point(124, 135);
            this.textBoxEPosta.MaxLength = 100;
            this.textBoxEPosta.Name = "textBoxEPosta";
            this.textBoxEPosta.Size = new System.Drawing.Size(271, 21);
            this.textBoxEPosta.TabIndex = 4;
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelTelefon.Location = new System.Drawing.Point(472, 110);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(47, 15);
            this.labelTelefon.TabIndex = 34;
            this.labelTelefon.Text = "Telefon";
            // 
            // textBoxTelefon
            // 
            this.textBoxTelefon.Location = new System.Drawing.Point(581, 107);
            this.textBoxTelefon.MaxLength = 15;
            this.textBoxTelefon.Name = "textBoxTelefon";
            this.textBoxTelefon.Size = new System.Drawing.Size(122, 21);
            this.textBoxTelefon.TabIndex = 8;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(423, 217);
            this.buttonSonKayit.Name = "buttonSonKayit";
            this.buttonSonKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonSonKayit.TabIndex = 16;
            this.buttonSonKayit.Text = "Son Kayıt";
            this.buttonSonKayit.UseVisualStyleBackColor = true;
            this.buttonSonKayit.Click += new System.EventHandler(this.buttonSonKayit_Click);
            // 
            // buttonIlkKayit
            // 
            this.buttonIlkKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIlkKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonIlkKayit.Location = new System.Drawing.Point(123, 217);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 13;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // textBoxFiltreSoyadi
            // 
            this.textBoxFiltreSoyadi.Location = new System.Drawing.Point(254, 264);
            this.textBoxFiltreSoyadi.MaxLength = 40;
            this.textBoxFiltreSoyadi.Name = "textBoxFiltreSoyadi";
            this.textBoxFiltreSoyadi.Size = new System.Drawing.Size(200, 21);
            this.textBoxFiltreSoyadi.TabIndex = 18;
            this.textBoxFiltreSoyadi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
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
            // textBoxFiltreAdi
            // 
            this.textBoxFiltreAdi.Location = new System.Drawing.Point(53, 264);
            this.textBoxFiltreAdi.MaxLength = 40;
            this.textBoxFiltreAdi.Name = "textBoxFiltreAdi";
            this.textBoxFiltreAdi.Size = new System.Drawing.Size(200, 21);
            this.textBoxFiltreAdi.TabIndex = 17;
            this.textBoxFiltreAdi.TextChanged += new System.EventHandler(this.textBoxFiltreAdi_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(423, 178);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 28);
            this.buttonSil.TabIndex = 12;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(323, 178);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 28);
            this.buttonGuncelle.TabIndex = 11;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.ForeColor = System.Drawing.Color.Green;
            this.buttonGeri.Location = new System.Drawing.Point(223, 217);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(80, 22);
            this.buttonGeri.TabIndex = 14;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonKaydet.Location = new System.Drawing.Point(223, 178);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(80, 28);
            this.buttonKaydet.TabIndex = 10;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Visible = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonIleri
            // 
            this.buttonIleri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIleri.ForeColor = System.Drawing.Color.Green;
            this.buttonIleri.Location = new System.Drawing.Point(323, 217);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(80, 22);
            this.buttonIleri.TabIndex = 15;
            this.buttonIleri.Text = "İleri";
            this.buttonIleri.UseVisualStyleBackColor = true;
            this.buttonIleri.Click += new System.EventHandler(this.buttonIleri_Click);
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniKayit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonYeniKayit.Location = new System.Drawing.Point(123, 178);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 9;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelUnvan
            // 
            this.labelUnvan.AutoSize = true;
            this.labelUnvan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUnvan.Location = new System.Drawing.Point(15, 84);
            this.labelUnvan.Name = "labelUnvan";
            this.labelUnvan.Size = new System.Drawing.Size(44, 15);
            this.labelUnvan.TabIndex = 6;
            this.labelUnvan.Text = "Unvanı";
            // 
            // labelSoyadi
            // 
            this.labelSoyadi.AutoSize = true;
            this.labelSoyadi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoyadi.Location = new System.Drawing.Point(15, 57);
            this.labelSoyadi.Name = "labelSoyadi";
            this.labelSoyadi.Size = new System.Drawing.Size(43, 15);
            this.labelSoyadi.TabIndex = 4;
            this.labelSoyadi.Text = "Soyadı";
            this.labelSoyadi.Click += new System.EventHandler(this.labelSoyadi_Click);
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(124, 54);
            this.textBoxSoyadi.MaxLength = 30;
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(271, 21);
            this.textBoxSoyadi.TabIndex = 1;
            this.textBoxSoyadi.TextChanged += new System.EventHandler(this.textBoxSoyadi_TextChanged);
            // 
            // dataGridViewPersonel
            // 
            this.dataGridViewPersonel.AutoGenerateColumns = false;
            this.dataGridViewPersonel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersonel.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.unvanIDDataGridViewTextBoxColumn,
            this.cinsiyetDataGridViewTextBoxColumn,
            this.tCKimlikNoDataGridViewTextBoxColumn,
            this.kurumSicilNoDataGridViewTextBoxColumn,
            this.calistigiBirimIDDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.ePostaDataGridViewTextBoxColumn,
            this.unvanAdiDataGridViewTextBoxColumn,
            this.birimAdiDataGridViewTextBoxColumn});
            this.dataGridViewPersonel.DataSource = this.sorguPersonelUnvanBirimBindingSource;
            this.dataGridViewPersonel.Location = new System.Drawing.Point(8, 293);
            this.dataGridViewPersonel.Name = "dataGridViewPersonel";
            this.dataGridViewPersonel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPersonel.Size = new System.Drawing.Size(751, 304);
            this.dataGridViewPersonel.TabIndex = 21;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Adı";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.ReadOnly = true;
            this.adDataGridViewTextBoxColumn.Width = 202;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyadı";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.ReadOnly = true;
            this.soyadDataGridViewTextBoxColumn.Width = 202;
            // 
            // unvanIDDataGridViewTextBoxColumn
            // 
            this.unvanIDDataGridViewTextBoxColumn.DataPropertyName = "UnvanID";
            this.unvanIDDataGridViewTextBoxColumn.HeaderText = "UnvanID";
            this.unvanIDDataGridViewTextBoxColumn.Name = "unvanIDDataGridViewTextBoxColumn";
            this.unvanIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.unvanIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // cinsiyetDataGridViewTextBoxColumn
            // 
            this.cinsiyetDataGridViewTextBoxColumn.DataPropertyName = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.HeaderText = "Cinsiyet";
            this.cinsiyetDataGridViewTextBoxColumn.Name = "cinsiyetDataGridViewTextBoxColumn";
            this.cinsiyetDataGridViewTextBoxColumn.ReadOnly = true;
            this.cinsiyetDataGridViewTextBoxColumn.Visible = false;
            // 
            // tCKimlikNoDataGridViewTextBoxColumn
            // 
            this.tCKimlikNoDataGridViewTextBoxColumn.DataPropertyName = "TCKimlikNo";
            this.tCKimlikNoDataGridViewTextBoxColumn.HeaderText = "TCKimlikNo";
            this.tCKimlikNoDataGridViewTextBoxColumn.Name = "tCKimlikNoDataGridViewTextBoxColumn";
            this.tCKimlikNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tCKimlikNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // kurumSicilNoDataGridViewTextBoxColumn
            // 
            this.kurumSicilNoDataGridViewTextBoxColumn.DataPropertyName = "KurumSicilNo";
            this.kurumSicilNoDataGridViewTextBoxColumn.HeaderText = "KurumSicilNo";
            this.kurumSicilNoDataGridViewTextBoxColumn.Name = "kurumSicilNoDataGridViewTextBoxColumn";
            this.kurumSicilNoDataGridViewTextBoxColumn.ReadOnly = true;
            this.kurumSicilNoDataGridViewTextBoxColumn.Visible = false;
            // 
            // calistigiBirimIDDataGridViewTextBoxColumn
            // 
            this.calistigiBirimIDDataGridViewTextBoxColumn.DataPropertyName = "CalistigiBirimID";
            this.calistigiBirimIDDataGridViewTextBoxColumn.HeaderText = "CalistigiBirimID";
            this.calistigiBirimIDDataGridViewTextBoxColumn.Name = "calistigiBirimIDDataGridViewTextBoxColumn";
            this.calistigiBirimIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.calistigiBirimIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefonDataGridViewTextBoxColumn.Visible = false;
            // 
            // ePostaDataGridViewTextBoxColumn
            // 
            this.ePostaDataGridViewTextBoxColumn.DataPropertyName = "EPosta";
            this.ePostaDataGridViewTextBoxColumn.HeaderText = "EPosta";
            this.ePostaDataGridViewTextBoxColumn.Name = "ePostaDataGridViewTextBoxColumn";
            this.ePostaDataGridViewTextBoxColumn.ReadOnly = true;
            this.ePostaDataGridViewTextBoxColumn.Visible = false;
            // 
            // unvanAdiDataGridViewTextBoxColumn
            // 
            this.unvanAdiDataGridViewTextBoxColumn.DataPropertyName = "UnvanAdi";
            this.unvanAdiDataGridViewTextBoxColumn.HeaderText = "Unvanı";
            this.unvanAdiDataGridViewTextBoxColumn.Name = "unvanAdiDataGridViewTextBoxColumn";
            this.unvanAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.unvanAdiDataGridViewTextBoxColumn.Width = 152;
            // 
            // birimAdiDataGridViewTextBoxColumn
            // 
            this.birimAdiDataGridViewTextBoxColumn.DataPropertyName = "BirimAdi";
            this.birimAdiDataGridViewTextBoxColumn.HeaderText = "Çalıştığı Birim";
            this.birimAdiDataGridViewTextBoxColumn.Name = "birimAdiDataGridViewTextBoxColumn";
            this.birimAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.birimAdiDataGridViewTextBoxColumn.Width = 152;
            // 
            // sorguPersonelUnvanBirimBindingSource
            // 
            this.sorguPersonelUnvanBirimBindingSource.DataMember = "SorguPersonelUnvanBirim";
            this.sorguPersonelUnvanBirimBindingSource.DataSource = this.demirbasTakipDataSet;
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
            this.labelAdi.Size = new System.Drawing.Size(25, 15);
            this.labelAdi.TabIndex = 2;
            this.labelAdi.Text = "Adı";
            this.labelAdi.Click += new System.EventHandler(this.labelAdi_Click);
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(124, 27);
            this.textBoxAdi.MaxLength = 30;
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(271, 21);
            this.textBoxAdi.TabIndex = 0;
            this.textBoxAdi.TextChanged += new System.EventHandler(this.textBoxAdi_TextChanged);
            // 
            // sorguPersonelUnvanBirimTableAdapter
            // 
            this.sorguPersonelUnvanBirimTableAdapter.ClearBeforeFill = true;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 626);
            this.Controls.Add(this.groupBoxPersonel);
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Personel ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPersonel_FormClosed);
            this.Load += new System.EventHandler(this.FormPersonel_Load);
            this.groupBoxPersonel.ResumeLayout(false);
            this.groupBoxPersonel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguPersonelUnvanBirimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonel;
        private System.Windows.Forms.Label labelKurumSicilNo;
        private System.Windows.Forms.TextBox textBoxKurumSicilNo;
        private System.Windows.Forms.Label labelTCKimlikNo;
        private System.Windows.Forms.TextBox textBoxTCKimlikNo;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.Label labelCinsiyeti;
        private System.Windows.Forms.TextBox textBoxFiltreUnvani;
        private System.Windows.Forms.ComboBox comboBoxUnvan;
        private System.Windows.Forms.Label labelEPosta;
        private System.Windows.Forms.TextBox textBoxEPosta;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.TextBox textBoxTelefon;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.TextBox textBoxFiltreSoyadi;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelUnvan;
        private System.Windows.Forms.Label labelSoyadi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.DataGridView dataGridViewPersonel;
        private System.Windows.Forms.Label labelAdi;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.ComboBox comboBoxCalistigiBirim;
        private System.Windows.Forms.Label labelCalistigiBirim;
        private System.Windows.Forms.TextBox textBoxFiltreBirimi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sorguPersonelUnvanBirimBindingSource;
        private DemirbasTakipDataSetTableAdapters.SorguPersonelUnvanBirimTableAdapter sorguPersonelUnvanBirimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tCKimlikNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kurumSicilNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn calistigiBirimIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ePostaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Personel;
    }
}