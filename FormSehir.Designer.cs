namespace DemirbasTakip
{
    partial class FormSehir
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
            this.groupBoxSehir = new System.Windows.Forms.GroupBox();
            this.ID_Sehir = new System.Windows.Forms.Label();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreSehirAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.dataGridViewSehirler = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sehirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelSehirAdi = new System.Windows.Forms.Label();
            this.textBoxSehirAdi = new System.Windows.Forms.TextBox();
            this.sehirTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SehirTableAdapter();
            this.groupBoxSehir.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSehirler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxSehir
            // 
            this.groupBoxSehir.Controls.Add(this.ID_Sehir);
            this.groupBoxSehir.Controls.Add(this.buttonSonKayit);
            this.groupBoxSehir.Controls.Add(this.buttonIlkKayit);
            this.groupBoxSehir.Controls.Add(this.labelFiltre);
            this.groupBoxSehir.Controls.Add(this.textBoxFiltreSehirAdi);
            this.groupBoxSehir.Controls.Add(this.buttonSil);
            this.groupBoxSehir.Controls.Add(this.buttonGuncelle);
            this.groupBoxSehir.Controls.Add(this.buttonGeri);
            this.groupBoxSehir.Controls.Add(this.buttonKaydet);
            this.groupBoxSehir.Controls.Add(this.buttonIleri);
            this.groupBoxSehir.Controls.Add(this.buttonYeniKayit);
            this.groupBoxSehir.Controls.Add(this.dataGridViewSehirler);
            this.groupBoxSehir.Controls.Add(this.labelSehirAdi);
            this.groupBoxSehir.Controls.Add(this.textBoxSehirAdi);
            this.groupBoxSehir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxSehir.Location = new System.Drawing.Point(12, 12);
            this.groupBoxSehir.Name = "groupBoxSehir";
            this.groupBoxSehir.Size = new System.Drawing.Size(422, 399);
            this.groupBoxSehir.TabIndex = 24;
            this.groupBoxSehir.TabStop = false;
            this.groupBoxSehir.Text = "Şehir Bilgileri";
            // 
            // ID_Sehir
            // 
            this.ID_Sehir.AutoSize = true;
            this.ID_Sehir.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Sehir.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Sehir.Location = new System.Drawing.Point(309, 30);
            this.ID_Sehir.Name = "ID_Sehir";
            this.ID_Sehir.Size = new System.Drawing.Size(13, 15);
            this.ID_Sehir.TabIndex = 43;
            this.ID_Sehir.Text = "0";
            // 
            // buttonSonKayit
            // 
            this.buttonSonKayit.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSonKayit.ForeColor = System.Drawing.Color.Green;
            this.buttonSonKayit.Location = new System.Drawing.Point(286, 99);
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
            this.buttonIlkKayit.Location = new System.Drawing.Point(18, 99);
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
            // textBoxFiltreSehirAdi
            // 
            this.textBoxFiltreSehirAdi.Location = new System.Drawing.Point(54, 134);
            this.textBoxFiltreSehirAdi.MaxLength = 40;
            this.textBoxFiltreSehirAdi.Name = "textBoxFiltreSehirAdi";
            this.textBoxFiltreSehirAdi.Size = new System.Drawing.Size(220, 21);
            this.textBoxFiltreSehirAdi.TabIndex = 9;
            this.textBoxFiltreSehirAdi.TextChanged += new System.EventHandler(this.textBoxFiltreSehirAdi_TextChanged);
            // 
            // buttonSil
            // 
            this.buttonSil.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonSil.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonSil.Location = new System.Drawing.Point(286, 60);
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
            this.buttonGuncelle.Location = new System.Drawing.Point(196, 60);
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
            this.buttonGeri.Location = new System.Drawing.Point(106, 99);
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
            this.buttonKaydet.Location = new System.Drawing.Point(106, 60);
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
            this.buttonIleri.Location = new System.Drawing.Point(196, 99);
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
            this.buttonYeniKayit.Location = new System.Drawing.Point(18, 60);
            this.buttonYeniKayit.Name = "buttonYeniKayit";
            this.buttonYeniKayit.Size = new System.Drawing.Size(80, 28);
            this.buttonYeniKayit.TabIndex = 1;
            this.buttonYeniKayit.Text = "Yeni Kayıt";
            this.buttonYeniKayit.UseVisualStyleBackColor = true;
            this.buttonYeniKayit.Click += new System.EventHandler(this.buttonYeniKayit_Click);
            // 
            // dataGridViewSehirler
            // 
            this.dataGridViewSehirler.AutoGenerateColumns = false;
            this.dataGridViewSehirler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSehirler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.sehirAdiDataGridViewTextBoxColumn});
            this.dataGridViewSehirler.DataSource = this.sehirBindingSource;
            this.dataGridViewSehirler.Location = new System.Drawing.Point(9, 161);
            this.dataGridViewSehirler.Name = "dataGridViewSehirler";
            this.dataGridViewSehirler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSehirler.Size = new System.Drawing.Size(284, 223);
            this.dataGridViewSehirler.TabIndex = 10;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ıDDataGridViewTextBoxColumn.Visible = false;
            this.ıDDataGridViewTextBoxColumn.Width = 2;
            // 
            // sehirAdiDataGridViewTextBoxColumn
            // 
            this.sehirAdiDataGridViewTextBoxColumn.DataPropertyName = "SehirAdi";
            this.sehirAdiDataGridViewTextBoxColumn.HeaderText = "Şehir Adı";
            this.sehirAdiDataGridViewTextBoxColumn.Name = "sehirAdiDataGridViewTextBoxColumn";
            this.sehirAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.sehirAdiDataGridViewTextBoxColumn.Width = 220;
            // 
            // sehirBindingSource
            // 
            this.sehirBindingSource.DataMember = "Sehir";
            this.sehirBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelSehirAdi
            // 
            this.labelSehirAdi.AutoSize = true;
            this.labelSehirAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSehirAdi.Location = new System.Drawing.Point(15, 30);
            this.labelSehirAdi.Name = "labelSehirAdi";
            this.labelSehirAdi.Size = new System.Drawing.Size(57, 15);
            this.labelSehirAdi.TabIndex = 2;
            this.labelSehirAdi.Text = "Şehir Adı";
            // 
            // textBoxSehirAdi
            // 
            this.textBoxSehirAdi.Location = new System.Drawing.Point(83, 27);
            this.textBoxSehirAdi.MaxLength = 50;
            this.textBoxSehirAdi.Name = "textBoxSehirAdi";
            this.textBoxSehirAdi.Size = new System.Drawing.Size(220, 21);
            this.textBoxSehirAdi.TabIndex = 0;
            // 
            // sehirTableAdapter
            // 
            this.sehirTableAdapter.ClearBeforeFill = true;
            // 
            // FormSehir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 419);
            this.Controls.Add(this.groupBoxSehir);
            this.Name = "FormSehir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Şehir ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSehir_FormClosed);
            this.Load += new System.EventHandler(this.FormSehir_Load);
            this.groupBoxSehir.ResumeLayout(false);
            this.groupBoxSehir.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSehirler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sehirBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSehir;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreSehirAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.DataGridView dataGridViewSehirler;
        private System.Windows.Forms.Label labelSehirAdi;
        private System.Windows.Forms.TextBox textBoxSehirAdi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sehirBindingSource;
        private DemirbasTakipDataSetTableAdapters.SehirTableAdapter sehirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sehirAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Sehir;
    }
}