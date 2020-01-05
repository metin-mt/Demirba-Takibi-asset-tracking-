namespace DemirbasTakip
{
    partial class FormBirim
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
            this.groupBoxBirimler = new System.Windows.Forms.GroupBox();
            this.ID_Birim = new System.Windows.Forms.Label();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreBirimAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.dataGridViewBirimler = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirimAdi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelBirimAdi = new System.Windows.Forms.Label();
            this.textBoxBirimAdi = new System.Windows.Forms.TextBox();
            this.demirbasTakipDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.birimTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.BirimTableAdapter();
            this.groupBoxBirimler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirimler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxBirimler
            // 
            this.groupBoxBirimler.Controls.Add(this.ID_Birim);
            this.groupBoxBirimler.Controls.Add(this.buttonSonKayit);
            this.groupBoxBirimler.Controls.Add(this.buttonIlkKayit);
            this.groupBoxBirimler.Controls.Add(this.labelFiltre);
            this.groupBoxBirimler.Controls.Add(this.textBoxFiltreBirimAdi);
            this.groupBoxBirimler.Controls.Add(this.buttonSil);
            this.groupBoxBirimler.Controls.Add(this.buttonGuncelle);
            this.groupBoxBirimler.Controls.Add(this.buttonGeri);
            this.groupBoxBirimler.Controls.Add(this.buttonKaydet);
            this.groupBoxBirimler.Controls.Add(this.buttonIleri);
            this.groupBoxBirimler.Controls.Add(this.buttonYeniKayit);
            this.groupBoxBirimler.Controls.Add(this.dataGridViewBirimler);
            this.groupBoxBirimler.Controls.Add(this.labelBirimAdi);
            this.groupBoxBirimler.Controls.Add(this.textBoxBirimAdi);
            this.groupBoxBirimler.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxBirimler.Location = new System.Drawing.Point(12, 12);
            this.groupBoxBirimler.Name = "groupBoxBirimler";
            this.groupBoxBirimler.Size = new System.Drawing.Size(469, 399);
            this.groupBoxBirimler.TabIndex = 22;
            this.groupBoxBirimler.TabStop = false;
            this.groupBoxBirimler.Text = "Birim Bilgileri";
            // 
            // ID_Birim
            // 
            this.ID_Birim.AutoSize = true;
            this.ID_Birim.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Birim.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Birim.Location = new System.Drawing.Point(413, 30);
            this.ID_Birim.Name = "ID_Birim";
            this.ID_Birim.Size = new System.Drawing.Size(13, 15);
            this.ID_Birim.TabIndex = 43;
            this.ID_Birim.Text = "0";
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(327, 99);
            this.buttonSonKayit.Name = "buttonSonKayit";
            this.buttonSonKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonSonKayit.TabIndex = 8;
            this.buttonSonKayit.Text = "Son Kayıt";
            this.buttonSonKayit.UseVisualStyleBackColor = true;
            this.buttonSonKayit.Click += new System.EventHandler(this.buttonSonKayit_Click);
            // 
            // buttonIlkKayit
            // 
            this.buttonIlkKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIlkKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonIlkKayit.Location = new System.Drawing.Point(27, 99);
            this.buttonIlkKayit.Name = "buttonIlkKayit";
            this.buttonIlkKayit.Size = new System.Drawing.Size(80, 22);
            this.buttonIlkKayit.TabIndex = 5;
            this.buttonIlkKayit.Text = "İlk Kayıt";
            this.buttonIlkKayit.UseVisualStyleBackColor = true;
            this.buttonIlkKayit.Click += new System.EventHandler(this.buttonIlkKayit_Click);
            // 
            // labelFiltre
            // 
            this.labelFiltre.AutoSize = true;
            this.labelFiltre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelFiltre.Location = new System.Drawing.Point(8, 137);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 29;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreBirimAdi
            // 
            this.textBoxFiltreBirimAdi.Location = new System.Drawing.Point(53, 134);
            this.textBoxFiltreBirimAdi.MaxLength = 40;
            this.textBoxFiltreBirimAdi.Name = "textBoxFiltreBirimAdi";
            this.textBoxFiltreBirimAdi.Size = new System.Drawing.Size(350, 21);
            this.textBoxFiltreBirimAdi.TabIndex = 9;
            this.textBoxFiltreBirimAdi.TextChanged += new System.EventHandler(this.textBoxFiltreBirimAdi_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(327, 60);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(80, 28);
            this.buttonSil.TabIndex = 4;
            this.buttonSil.Text = "Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(227, 60);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(80, 28);
            this.buttonGuncelle.TabIndex = 3;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonGeri
            // 
            this.buttonGeri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGeri.ForeColor = System.Drawing.Color.Green;
            this.buttonGeri.Location = new System.Drawing.Point(127, 99);
            this.buttonGeri.Name = "buttonGeri";
            this.buttonGeri.Size = new System.Drawing.Size(80, 22);
            this.buttonGeri.TabIndex = 6;
            this.buttonGeri.Text = "Geri";
            this.buttonGeri.UseVisualStyleBackColor = true;
            this.buttonGeri.Click += new System.EventHandler(this.buttonGeri_Click);
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonKaydet.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonKaydet.Location = new System.Drawing.Point(127, 60);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(80, 28);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Visible = false;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonIleri
            // 
            this.buttonIleri.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonIleri.ForeColor = System.Drawing.Color.Green;
            this.buttonIleri.Location = new System.Drawing.Point(227, 99);
            this.buttonIleri.Name = "buttonIleri";
            this.buttonIleri.Size = new System.Drawing.Size(80, 22);
            this.buttonIleri.TabIndex = 7;
            this.buttonIleri.Text = "İleri";
            this.buttonIleri.UseVisualStyleBackColor = true;
            this.buttonIleri.Click += new System.EventHandler(this.buttonIleri_Click);
            // 
            // buttonYeniKayit
            // 
            this.buttonYeniKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonYeniKayit.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonYeniKayit.Location = new System.Drawing.Point(27, 60);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 1;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // dataGridViewBirimler
            // 
            this.dataGridViewBirimler.AutoGenerateColumns = false;
            this.dataGridViewBirimler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBirimler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.BirimAdi});
            this.dataGridViewBirimler.DataSource = this.birimBindingSource;
            this.dataGridViewBirimler.Location = new System.Drawing.Point(9, 161);
            this.dataGridViewBirimler.Name = "dataGridViewBirimler";
            this.dataGridViewBirimler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewBirimler.Size = new System.Drawing.Size(396, 223);
            this.dataGridViewBirimler.TabIndex = 11;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Width = 2;
            // 
            // BirimAdi
            // 
            this.BirimAdi.DataPropertyName = "BirimAdi";
            this.BirimAdi.HeaderText = "Birim Adı";
            this.BirimAdi.Name = "BirimAdi";
            this.BirimAdi.ReadOnly = true;
            this.BirimAdi.Width = 350;
            // 
            // birimBindingSource
            // 
            this.birimBindingSource.DataMember = "Birim";
            this.birimBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelBirimAdi
            // 
            this.labelBirimAdi.AutoSize = true;
            this.labelBirimAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelBirimAdi.Location = new System.Drawing.Point(15, 30);
            this.labelBirimAdi.Name = "labelBirimAdi";
            this.labelBirimAdi.Size = new System.Drawing.Size(58, 15);
            this.labelBirimAdi.TabIndex = 2;
            this.labelBirimAdi.Text = "Birim Adı";
            // 
            // textBoxBirimAdi
            // 
            this.textBoxBirimAdi.Location = new System.Drawing.Point(83, 27);
            this.textBoxBirimAdi.MaxLength = 40;
            this.textBoxBirimAdi.Name = "textBoxBirimAdi";
            this.textBoxBirimAdi.Size = new System.Drawing.Size(324, 21);
            this.textBoxBirimAdi.TabIndex = 0;
            // 
            // demirbasTakipDataSetBindingSource
            // 
            this.demirbasTakipDataSetBindingSource.DataSource = this.demirbasTakipDataSet;
            this.demirbasTakipDataSetBindingSource.Position = 0;
            // 
            // birimTableAdapter
            // 
            this.birimTableAdapter.ClearBeforeFill = true;
            // 
            // FormBirim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 422);
            this.Controls.Add(this.groupBoxBirimler);
            this.Name = "FormBirim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBirim_FormClosed);
            this.Load += new System.EventHandler(this.FormBirim_Load);
            this.groupBoxBirimler.ResumeLayout(false);
            this.groupBoxBirimler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBirimler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.birimBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxBirimler;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreBirimAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.DataGridView dataGridViewBirimler;
        private System.Windows.Forms.Label labelBirimAdi;
        private System.Windows.Forms.TextBox textBoxBirimAdi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource demirbasTakipDataSetBindingSource;
        private System.Windows.Forms.BindingSource birimBindingSource;
        private DemirbasTakipDataSetTableAdapters.BirimTableAdapter birimTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirimAdi;
        private System.Windows.Forms.Label ID_Birim;
    }
}