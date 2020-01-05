namespace DemirbasTakip
{
    partial class FormDemirbas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxDemirbaslar = new System.Windows.Forms.GroupBox();
            this.ID_Demirbas = new System.Windows.Forms.Label();
            this.labelBirimi = new System.Windows.Forms.Label();
            this.textBoxDemirbasBirimi = new System.Windows.Forms.TextBox();
            this.textBoxFiltreDemirbasBirimi = new System.Windows.Forms.TextBox();
            this.labelKalanMiktar = new System.Windows.Forms.Label();
            this.textBoxKalanMiktar = new System.Windows.Forms.TextBox();
            this.labelCikanMiktar = new System.Windows.Forms.Label();
            this.textBoxCikanMiktar = new System.Windows.Forms.TextBox();
            this.labelGirenMiktar = new System.Windows.Forms.Label();
            this.textBoxGirenMiktar = new System.Windows.Forms.TextBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.textBoxFiltreDemirbasAdi = new System.Windows.Forms.TextBox();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreDemirbasKodu = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.labelDemirbasAdi = new System.Windows.Forms.Label();
            this.textBoxDemirbasAdi = new System.Windows.Forms.TextBox();
            this.dataGridViewDemirbaslar = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasBirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.girenMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikanMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelDemirbasKodu = new System.Windows.Forms.Label();
            this.textBoxDemirbasKodu = new System.Windows.Forms.TextBox();
            this.demirbasTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.DemirbasTableAdapter();
            this.groupBoxDemirbaslar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemirbaslar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxDemirbaslar
            // 
            this.groupBoxDemirbaslar.Controls.Add(this.ID_Demirbas);
            this.groupBoxDemirbaslar.Controls.Add(this.labelBirimi);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxDemirbasBirimi);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxFiltreDemirbasBirimi);
            this.groupBoxDemirbaslar.Controls.Add(this.labelKalanMiktar);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxKalanMiktar);
            this.groupBoxDemirbaslar.Controls.Add(this.labelCikanMiktar);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxCikanMiktar);
            this.groupBoxDemirbaslar.Controls.Add(this.labelGirenMiktar);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxGirenMiktar);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonSonKayit);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonIlkKayit);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxFiltreDemirbasAdi);
            this.groupBoxDemirbaslar.Controls.Add(this.labelFiltre);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxFiltreDemirbasKodu);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonSil);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonGuncelle);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonGeri);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonKaydet);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonIleri);
            this.groupBoxDemirbaslar.Controls.Add(this.buttonYeniKayit);
            this.groupBoxDemirbaslar.Controls.Add(this.labelDemirbasAdi);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxDemirbasAdi);
            this.groupBoxDemirbaslar.Controls.Add(this.dataGridViewDemirbaslar);
            this.groupBoxDemirbaslar.Controls.Add(this.labelDemirbasKodu);
            this.groupBoxDemirbaslar.Controls.Add(this.textBoxDemirbasKodu);
            this.groupBoxDemirbaslar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxDemirbaslar.Location = new System.Drawing.Point(8, 1);
            this.groupBoxDemirbaslar.Name = "groupBoxDemirbaslar";
            this.groupBoxDemirbaslar.Size = new System.Drawing.Size(765, 576);
            this.groupBoxDemirbaslar.TabIndex = 22;
            this.groupBoxDemirbaslar.TabStop = false;
            this.groupBoxDemirbaslar.Text = "Demirbaş Bilgileri";
            this.groupBoxDemirbaslar.Enter += new System.EventHandler(this.groupBoxDemirbaslar_Enter);
            // 
            // ID_Demirbas
            // 
            this.ID_Demirbas.AutoSize = true;
            this.ID_Demirbas.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Demirbas.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Demirbas.Location = new System.Drawing.Point(212, 30);
            this.ID_Demirbas.Name = "ID_Demirbas";
            this.ID_Demirbas.Size = new System.Drawing.Size(13, 15);
            this.ID_Demirbas.TabIndex = 43;
            this.ID_Demirbas.Text = "0";
            // 
            // labelBirimi
            // 
            this.labelBirimi.AutoSize = true;
            this.labelBirimi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBirimi.Location = new System.Drawing.Point(15, 84);
            this.labelBirimi.Name = "labelBirimi";
            this.labelBirimi.Size = new System.Drawing.Size(42, 15);
            this.labelBirimi.TabIndex = 40;
            this.labelBirimi.Text = "Birimi";
            // 
            // textBoxDemirbasBirimi
            // 
            this.textBoxDemirbasBirimi.Location = new System.Drawing.Point(124, 81);
            this.textBoxDemirbasBirimi.MaxLength = 10;
            this.textBoxDemirbasBirimi.Name = "textBoxDemirbasBirimi";
            this.textBoxDemirbasBirimi.Size = new System.Drawing.Size(82, 21);
            this.textBoxDemirbasBirimi.TabIndex = 2;
            // 
            // textBoxFiltreDemirbasBirimi
            // 
            this.textBoxFiltreDemirbasBirimi.Location = new System.Drawing.Point(465, 264);
            this.textBoxFiltreDemirbasBirimi.MaxLength = 40;
            this.textBoxFiltreDemirbasBirimi.Name = "textBoxFiltreDemirbasBirimi";
            this.textBoxFiltreDemirbasBirimi.Size = new System.Drawing.Size(82, 21);
            this.textBoxFiltreDemirbasBirimi.TabIndex = 16;
            this.textBoxFiltreDemirbasBirimi.TextChanged += new System.EventHandler(this.textBoxFiltreDemirbasKodu_TextChanged);
            // 
            // labelKalanMiktar
            // 
            this.labelKalanMiktar.AutoSize = true;
            this.labelKalanMiktar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKalanMiktar.Location = new System.Drawing.Point(15, 165);
            this.labelKalanMiktar.Name = "labelKalanMiktar";
            this.labelKalanMiktar.Size = new System.Drawing.Size(79, 15);
            this.labelKalanMiktar.TabIndex = 38;
            this.labelKalanMiktar.Text = "Kalan Miktar";
            // 
            // textBoxKalanMiktar
            // 
            this.textBoxKalanMiktar.Enabled = false;
            this.textBoxKalanMiktar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKalanMiktar.ForeColor = System.Drawing.Color.Green;
            this.textBoxKalanMiktar.Location = new System.Drawing.Point(124, 162);
            this.textBoxKalanMiktar.MaxLength = 100;
            this.textBoxKalanMiktar.Name = "textBoxKalanMiktar";
            this.textBoxKalanMiktar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxKalanMiktar.Size = new System.Drawing.Size(82, 22);
            this.textBoxKalanMiktar.TabIndex = 5;
            // 
            // labelCikanMiktar
            // 
            this.labelCikanMiktar.AutoSize = true;
            this.labelCikanMiktar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelCikanMiktar.Location = new System.Drawing.Point(15, 138);
            this.labelCikanMiktar.Name = "labelCikanMiktar";
            this.labelCikanMiktar.Size = new System.Drawing.Size(80, 15);
            this.labelCikanMiktar.TabIndex = 36;
            this.labelCikanMiktar.Text = "Çıkan Miktar";
            // 
            // textBoxCikanMiktar
            // 
            this.textBoxCikanMiktar.Enabled = false;
            this.textBoxCikanMiktar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxCikanMiktar.ForeColor = System.Drawing.Color.Red;
            this.textBoxCikanMiktar.Location = new System.Drawing.Point(124, 135);
            this.textBoxCikanMiktar.MaxLength = 10;
            this.textBoxCikanMiktar.Name = "textBoxCikanMiktar";
            this.textBoxCikanMiktar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxCikanMiktar.Size = new System.Drawing.Size(82, 22);
            this.textBoxCikanMiktar.TabIndex = 4;
            // 
            // labelGirenMiktar
            // 
            this.labelGirenMiktar.AutoSize = true;
            this.labelGirenMiktar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelGirenMiktar.Location = new System.Drawing.Point(15, 111);
            this.labelGirenMiktar.Name = "labelGirenMiktar";
            this.labelGirenMiktar.Size = new System.Drawing.Size(78, 15);
            this.labelGirenMiktar.TabIndex = 34;
            this.labelGirenMiktar.Text = "Giren Miktar";
            // 
            // textBoxGirenMiktar
            // 
            this.textBoxGirenMiktar.Enabled = false;
            this.textBoxGirenMiktar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxGirenMiktar.ForeColor = System.Drawing.Color.Green;
            this.textBoxGirenMiktar.Location = new System.Drawing.Point(124, 108);
            this.textBoxGirenMiktar.MaxLength = 10;
            this.textBoxGirenMiktar.Name = "textBoxGirenMiktar";
            this.textBoxGirenMiktar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBoxGirenMiktar.Size = new System.Drawing.Size(82, 22);
            this.textBoxGirenMiktar.TabIndex = 3;
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(423, 230);
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
            this.buttonIlkKayit.Location = new System.Drawing.Point(123, 230);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 10;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // textBoxFiltreDemirbasAdi
            // 
            this.textBoxFiltreDemirbasAdi.Location = new System.Drawing.Point(134, 264);
            this.textBoxFiltreDemirbasAdi.MaxLength = 40;
            this.textBoxFiltreDemirbasAdi.Name = "textBoxFiltreDemirbasAdi";
            this.textBoxFiltreDemirbasAdi.Size = new System.Drawing.Size(328, 21);
            this.textBoxFiltreDemirbasAdi.TabIndex = 15;
            this.textBoxFiltreDemirbasAdi.TextChanged += new System.EventHandler(this.textBoxFiltreDemirbasKodu_TextChanged);
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
            // textBoxFiltreDemirbasKodu
            // 
            this.textBoxFiltreDemirbasKodu.Location = new System.Drawing.Point(51, 264);
            this.textBoxFiltreDemirbasKodu.MaxLength = 40;
            this.textBoxFiltreDemirbasKodu.Name = "textBoxFiltreDemirbasKodu";
            this.textBoxFiltreDemirbasKodu.Size = new System.Drawing.Size(82, 21);
            this.textBoxFiltreDemirbasKodu.TabIndex = 14;
            this.textBoxFiltreDemirbasKodu.TextChanged += new System.EventHandler(this.textBoxFiltreDemirbasKodu_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(423, 191);
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
            this.buttonGuncelle.Location = new System.Drawing.Point(323, 191);
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
            this.buttonGeri.Location = new System.Drawing.Point(223, 230);
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
            this.buttonKaydet.Location = new System.Drawing.Point(223, 191);
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
            this.buttonIleri.Location = new System.Drawing.Point(323, 230);
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
            this.buttonYeniKayit.Location = new System.Drawing.Point(123, 191);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 6;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // labelDemirbasAdi
            // 
            this.labelDemirbasAdi.AutoSize = true;
            this.labelDemirbasAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDemirbasAdi.Location = new System.Drawing.Point(15, 57);
            this.labelDemirbasAdi.Name = "labelDemirbasAdi";
            this.labelDemirbasAdi.Size = new System.Drawing.Size(78, 15);
            this.labelDemirbasAdi.TabIndex = 4;
            this.labelDemirbasAdi.Text = "Demirbaş Adı";
            // 
            // textBoxDemirbasAdi
            // 
            this.textBoxDemirbasAdi.Location = new System.Drawing.Point(124, 54);
            this.textBoxDemirbasAdi.MaxLength = 100;
            this.textBoxDemirbasAdi.Name = "textBoxDemirbasAdi";
            this.textBoxDemirbasAdi.Size = new System.Drawing.Size(432, 21);
            this.textBoxDemirbasAdi.TabIndex = 1;
            // 
            // dataGridViewDemirbaslar
            // 
            this.dataGridViewDemirbaslar.AutoGenerateColumns = false;
            this.dataGridViewDemirbaslar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDemirbaslar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.demirbasKoduDataGridViewTextBoxColumn,
            this.demirbasAdiDataGridViewTextBoxColumn,
            this.demirbasBirimiDataGridViewTextBoxColumn,
            this.girenMiktarDataGridViewTextBoxColumn,
            this.cikanMiktarDataGridViewTextBoxColumn,
            this.kalanMiktarDataGridViewTextBoxColumn});
            this.dataGridViewDemirbaslar.DataSource = this.demirbasBindingSource;
            this.dataGridViewDemirbaslar.Location = new System.Drawing.Point(8, 293);
            this.dataGridViewDemirbaslar.Name = "dataGridViewDemirbaslar";
            this.dataGridViewDemirbaslar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDemirbaslar.Size = new System.Drawing.Size(747, 277);
            this.dataGridViewDemirbaslar.TabIndex = 17;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            // 
            // demirbasKoduDataGridViewTextBoxColumn
            // 
            this.demirbasKoduDataGridViewTextBoxColumn.DataPropertyName = "DemirbasKodu";
            this.demirbasKoduDataGridViewTextBoxColumn.HeaderText = "Kodu";
            this.demirbasKoduDataGridViewTextBoxColumn.Name = "demirbasKoduDataGridViewTextBoxColumn";
            this.demirbasKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasKoduDataGridViewTextBoxColumn.Width = 82;
            // 
            // demirbasAdiDataGridViewTextBoxColumn
            // 
            this.demirbasAdiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasAdi";
            this.demirbasAdiDataGridViewTextBoxColumn.HeaderText = "Demirbaş Adı";
            this.demirbasAdiDataGridViewTextBoxColumn.Name = "demirbasAdiDataGridViewTextBoxColumn";
            this.demirbasAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasAdiDataGridViewTextBoxColumn.Width = 330;
            // 
            // demirbasBirimiDataGridViewTextBoxColumn
            // 
            this.demirbasBirimiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasBirimi";
            this.demirbasBirimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.demirbasBirimiDataGridViewTextBoxColumn.Name = "demirbasBirimiDataGridViewTextBoxColumn";
            this.demirbasBirimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasBirimiDataGridViewTextBoxColumn.Width = 82;
            // 
            // girenMiktarDataGridViewTextBoxColumn
            // 
            this.girenMiktarDataGridViewTextBoxColumn.DataPropertyName = "GirenMiktar";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle1.Format = "N0";
            this.girenMiktarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.girenMiktarDataGridViewTextBoxColumn.HeaderText = "Giren";
            this.girenMiktarDataGridViewTextBoxColumn.Name = "girenMiktarDataGridViewTextBoxColumn";
            this.girenMiktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.girenMiktarDataGridViewTextBoxColumn.Width = 70;
            // 
            // cikanMiktarDataGridViewTextBoxColumn
            // 
            this.cikanMiktarDataGridViewTextBoxColumn.DataPropertyName = "CikanMiktar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.cikanMiktarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.cikanMiktarDataGridViewTextBoxColumn.HeaderText = "Çıkan";
            this.cikanMiktarDataGridViewTextBoxColumn.Name = "cikanMiktarDataGridViewTextBoxColumn";
            this.cikanMiktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.cikanMiktarDataGridViewTextBoxColumn.Width = 70;
            // 
            // kalanMiktarDataGridViewTextBoxColumn
            // 
            this.kalanMiktarDataGridViewTextBoxColumn.DataPropertyName = "KalanMiktar";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Green;
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.kalanMiktarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.kalanMiktarDataGridViewTextBoxColumn.HeaderText = "Kalan";
            this.kalanMiktarDataGridViewTextBoxColumn.Name = "kalanMiktarDataGridViewTextBoxColumn";
            this.kalanMiktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.kalanMiktarDataGridViewTextBoxColumn.Width = 70;
            // 
            // demirbasBindingSource
            // 
            this.demirbasBindingSource.DataMember = "Demirbas";
            this.demirbasBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelDemirbasKodu
            // 
            this.labelDemirbasKodu.AutoSize = true;
            this.labelDemirbasKodu.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelDemirbasKodu.Location = new System.Drawing.Point(15, 30);
            this.labelDemirbasKodu.Name = "labelDemirbasKodu";
            this.labelDemirbasKodu.Size = new System.Drawing.Size(89, 15);
            this.labelDemirbasKodu.TabIndex = 2;
            this.labelDemirbasKodu.Text = "Demirbaş Kodu";
            // 
            // textBoxDemirbasKodu
            // 
            this.textBoxDemirbasKodu.Location = new System.Drawing.Point(124, 27);
            this.textBoxDemirbasKodu.MaxLength = 10;
            this.textBoxDemirbasKodu.Name = "textBoxDemirbasKodu";
            this.textBoxDemirbasKodu.Size = new System.Drawing.Size(82, 21);
            this.textBoxDemirbasKodu.TabIndex = 0;
            // 
            // demirbasTableAdapter
            // 
            this.demirbasTableAdapter.ClearBeforeFill = true;
            // 
            // FormDemirbas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 586);
            this.Controls.Add(this.groupBoxDemirbaslar);
            this.Name = "FormDemirbas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Demirbaşlar ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDemirbas_FormClosed);
            this.Load += new System.EventHandler(this.FormDemirbas_Load);
            this.groupBoxDemirbaslar.ResumeLayout(false);
            this.groupBoxDemirbaslar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDemirbaslar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDemirbaslar;
        private System.Windows.Forms.TextBox textBoxFiltreDemirbasBirimi;
        private System.Windows.Forms.Label labelKalanMiktar;
        private System.Windows.Forms.TextBox textBoxKalanMiktar;
        private System.Windows.Forms.Label labelCikanMiktar;
        private System.Windows.Forms.TextBox textBoxCikanMiktar;
        private System.Windows.Forms.Label labelGirenMiktar;
        private System.Windows.Forms.TextBox textBoxGirenMiktar;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.TextBox textBoxFiltreDemirbasAdi;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreDemirbasKodu;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.Label labelDemirbasAdi;
        private System.Windows.Forms.TextBox textBoxDemirbasAdi;
        private System.Windows.Forms.DataGridView dataGridViewDemirbaslar;
        private System.Windows.Forms.Label labelDemirbasKodu;
        private System.Windows.Forms.TextBox textBoxDemirbasKodu;
        private System.Windows.Forms.Label labelBirimi;
        private System.Windows.Forms.TextBox textBoxDemirbasBirimi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource demirbasBindingSource;
        private DemirbasTakipDataSetTableAdapters.DemirbasTableAdapter demirbasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasBirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn girenMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikanMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Demirbas;
    }
}