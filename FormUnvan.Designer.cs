namespace DemirbasTakip
{
    partial class FormUnvan
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
            this.groupBoxUnvan = new System.Windows.Forms.GroupBox();
            this.ID_Unvan = new System.Windows.Forms.Label();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreUnvanAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.dataGridViewUnvanlar = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unvanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelUnvanAdi = new System.Windows.Forms.Label();
            this.textBoxUnvanAdi = new System.Windows.Forms.TextBox();
            this.unvanTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.UnvanTableAdapter();
            this.groupBoxUnvan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnvanlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxUnvan
            // 
            this.groupBoxUnvan.Controls.Add(this.ID_Unvan);
            this.groupBoxUnvan.Controls.Add(this.buttonSonKayit);
            this.groupBoxUnvan.Controls.Add(this.buttonIlkKayit);
            this.groupBoxUnvan.Controls.Add(this.labelFiltre);
            this.groupBoxUnvan.Controls.Add(this.textBoxFiltreUnvanAdi);
            this.groupBoxUnvan.Controls.Add(this.buttonSil);
            this.groupBoxUnvan.Controls.Add(this.buttonGuncelle);
            this.groupBoxUnvan.Controls.Add(this.buttonGeri);
            this.groupBoxUnvan.Controls.Add(this.buttonKaydet);
            this.groupBoxUnvan.Controls.Add(this.buttonIleri);
            this.groupBoxUnvan.Controls.Add(this.buttonYeniKayit);
            this.groupBoxUnvan.Controls.Add(this.dataGridViewUnvanlar);
            this.groupBoxUnvan.Controls.Add(this.labelUnvanAdi);
            this.groupBoxUnvan.Controls.Add(this.textBoxUnvanAdi);
            this.groupBoxUnvan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxUnvan.Location = new System.Drawing.Point(8, 8);
            this.groupBoxUnvan.Name = "groupBoxUnvan";
            this.groupBoxUnvan.Size = new System.Drawing.Size(422, 399);
            this.groupBoxUnvan.TabIndex = 23;
            this.groupBoxUnvan.TabStop = false;
            this.groupBoxUnvan.Text = "Unvan Bilgileri";
            // 
            // ID_Unvan
            // 
            this.ID_Unvan.AutoSize = true;
            this.ID_Unvan.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Unvan.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Unvan.Location = new System.Drawing.Point(309, 30);
            this.ID_Unvan.Name = "ID_Unvan";
            this.ID_Unvan.Size = new System.Drawing.Size(13, 15);
            this.ID_Unvan.TabIndex = 43;
            this.ID_Unvan.Text = "0";
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
            this.labelFiltre.Location = new System.Drawing.Point(17, 137);
            this.labelFiltre.Name = "labelFiltre";
            this.labelFiltre.Size = new System.Drawing.Size(37, 15);
            this.labelFiltre.TabIndex = 29;
            this.labelFiltre.Text = "Filtre";
            // 
            // textBoxFiltreUnvanAdi
            // 
            this.textBoxFiltreUnvanAdi.Location = new System.Drawing.Point(63, 134);
            this.textBoxFiltreUnvanAdi.MaxLength = 40;
            this.textBoxFiltreUnvanAdi.Name = "textBoxFiltreUnvanAdi";
            this.textBoxFiltreUnvanAdi.Size = new System.Drawing.Size(220, 21);
            this.textBoxFiltreUnvanAdi.TabIndex = 9;
            this.textBoxFiltreUnvanAdi.TextChanged += new System.EventHandler(this.textBoxFiltreUnvanAdi_TextChanged);
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
            // dataGridViewUnvanlar
            // 
            this.dataGridViewUnvanlar.AutoGenerateColumns = false;
            this.dataGridViewUnvanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUnvanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.unvanAdiDataGridViewTextBoxColumn});
            this.dataGridViewUnvanlar.DataSource = this.unvanBindingSource;
            this.dataGridViewUnvanlar.Location = new System.Drawing.Point(18, 161);
            this.dataGridViewUnvanlar.Name = "dataGridViewUnvanlar";
            this.dataGridViewUnvanlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUnvanlar.Size = new System.Drawing.Size(285, 223);
            this.dataGridViewUnvanlar.TabIndex = 10;
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
            // unvanAdiDataGridViewTextBoxColumn
            // 
            this.unvanAdiDataGridViewTextBoxColumn.DataPropertyName = "UnvanAdi";
            this.unvanAdiDataGridViewTextBoxColumn.HeaderText = "UnvanAdi";
            this.unvanAdiDataGridViewTextBoxColumn.Name = "unvanAdiDataGridViewTextBoxColumn";
            this.unvanAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.unvanAdiDataGridViewTextBoxColumn.Width = 220;
            // 
            // unvanBindingSource
            // 
            this.unvanBindingSource.DataMember = "Unvan";
            this.unvanBindingSource.DataSource = this.demirbasTakipDataSet;
            // 
            // demirbasTakipDataSet
            // 
            this.demirbasTakipDataSet.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelUnvanAdi
            // 
            this.labelUnvanAdi.AutoSize = true;
            this.labelUnvanAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelUnvanAdi.Location = new System.Drawing.Point(15, 30);
            this.labelUnvanAdi.Name = "labelUnvanAdi";
            this.labelUnvanAdi.Size = new System.Drawing.Size(60, 15);
            this.labelUnvanAdi.TabIndex = 2;
            this.labelUnvanAdi.Text = "Unvan Adı";
            // 
            // textBoxUnvanAdi
            // 
            this.textBoxUnvanAdi.Location = new System.Drawing.Point(83, 27);
            this.textBoxUnvanAdi.MaxLength = 40;
            this.textBoxUnvanAdi.Name = "textBoxUnvanAdi";
            this.textBoxUnvanAdi.Size = new System.Drawing.Size(220, 21);
            this.textBoxUnvanAdi.TabIndex = 0;
            // 
            // unvanTableAdapter
            // 
            this.unvanTableAdapter.ClearBeforeFill = true;
            // 
            // FormUnvan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 421);
            this.Controls.Add(this.groupBoxUnvan);
            this.Name = "FormUnvan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Unvan ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUnvan_FormClosed);
            this.Load += new System.EventHandler(this.FormUnvan_Load);
            this.groupBoxUnvan.ResumeLayout(false);
            this.groupBoxUnvan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUnvanlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unvanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUnvan;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreUnvanAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.DataGridView dataGridViewUnvanlar;
        private System.Windows.Forms.Label labelUnvanAdi;
        private System.Windows.Forms.TextBox textBoxUnvanAdi;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource unvanBindingSource;
        private DemirbasTakipDataSetTableAdapters.UnvanTableAdapter unvanTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unvanAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Unvan;
    }
}