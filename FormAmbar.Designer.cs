namespace DemirbasTakip
{
    partial class FormAmbar
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
            this.groupBoxAmbarlar = new System.Windows.Forms.GroupBox();
            this.buttonSonKayit = new System.Windows.Forms.Button();
            this.buttonIlkKayit = new System.Windows.Forms.Button();
            this.labelFiltre = new System.Windows.Forms.Label();
            this.textBoxFiltreAmbarAdi = new System.Windows.Forms.TextBox();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonGeri = new System.Windows.Forms.Button();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIleri = new System.Windows.Forms.Button();
            this.buttonYeniKayit = new System.Windows.Forms.Button();
            this.dataGridViewAmbarlar = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSetAmbar = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelAmbarAdi = new System.Windows.Forms.Label();
            this.textBoxAmbarAdi = new System.Windows.Forms.TextBox();
            this.ambarTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.AmbarTableAdapter();
            this.ID_Ambar = new System.Windows.Forms.Label();
            this.groupBoxAmbarlar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmbarlar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSetAmbar)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxAmbarlar
            // 
            this.groupBoxAmbarlar.Controls.Add(this.ID_Ambar);
            this.groupBoxAmbarlar.Controls.Add(this.buttonSonKayit);
            this.groupBoxAmbarlar.Controls.Add(this.buttonIlkKayit);
            this.groupBoxAmbarlar.Controls.Add(this.labelFiltre);
            this.groupBoxAmbarlar.Controls.Add(this.textBoxFiltreAmbarAdi);
            this.groupBoxAmbarlar.Controls.Add(this.buttonSil);
            this.groupBoxAmbarlar.Controls.Add(this.buttonGuncelle);
            this.groupBoxAmbarlar.Controls.Add(this.buttonGeri);
            this.groupBoxAmbarlar.Controls.Add(this.buttonKaydet);
            this.groupBoxAmbarlar.Controls.Add(this.buttonIleri);
            this.groupBoxAmbarlar.Controls.Add(this.buttonYeniKayit);
            this.groupBoxAmbarlar.Controls.Add(this.dataGridViewAmbarlar);
            this.groupBoxAmbarlar.Controls.Add(this.labelAmbarAdi);
            this.groupBoxAmbarlar.Controls.Add(this.textBoxAmbarAdi);
            this.groupBoxAmbarlar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxAmbarlar.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAmbarlar.Name = "groupBoxAmbarlar";
            this.groupBoxAmbarlar.Size = new System.Drawing.Size(469, 399);
            this.groupBoxAmbarlar.TabIndex = 21;
            this.groupBoxAmbarlar.TabStop = false;
            this.groupBoxAmbarlar.Text = "Ambar Bilgileri";
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
            // textBoxFiltreAmbarAdi
            // 
            this.textBoxFiltreAmbarAdi.Location = new System.Drawing.Point(53, 134);
            this.textBoxFiltreAmbarAdi.MaxLength = 40;
            this.textBoxFiltreAmbarAdi.Name = "textBoxFiltreAmbarAdi";
            this.textBoxFiltreAmbarAdi.Size = new System.Drawing.Size(350, 21);
            this.textBoxFiltreAmbarAdi.TabIndex = 9;
            this.textBoxFiltreAmbarAdi.TextChanged += new System.EventHandler(this.textBoxFiltreAmbarAdi_TextChanged);
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
            // dataGridViewAmbarlar
            // 
            this.dataGridViewAmbarlar.AutoGenerateColumns = false;
            this.dataGridViewAmbarlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAmbarlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ıDDataGridViewTextBoxColumn,
            this.ambarAdiDataGridViewTextBoxColumn});
            this.dataGridViewAmbarlar.DataSource = this.ambarBindingSource;
            this.dataGridViewAmbarlar.Location = new System.Drawing.Point(9, 161);
            this.dataGridViewAmbarlar.Name = "dataGridViewAmbarlar";
            this.dataGridViewAmbarlar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAmbarlar.Size = new System.Drawing.Size(396, 223);
            this.dataGridViewAmbarlar.TabIndex = 10;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.MinimumWidth = 2;
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
            this.ıDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ıDDataGridViewTextBoxColumn.Width = 2;
            // 
            // ambarAdiDataGridViewTextBoxColumn
            // 
            this.ambarAdiDataGridViewTextBoxColumn.DataPropertyName = "AmbarAdi";
            this.ambarAdiDataGridViewTextBoxColumn.HeaderText = "Ambar Adı";
            this.ambarAdiDataGridViewTextBoxColumn.Name = "ambarAdiDataGridViewTextBoxColumn";
            this.ambarAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ambarAdiDataGridViewTextBoxColumn.Width = 350;
            // 
            // ambarBindingSource
            // 
            this.ambarBindingSource.DataMember = "Ambar";
            this.ambarBindingSource.DataSource = this.demirbasTakipDataSetAmbar;
            // 
            // demirbasTakipDataSetAmbar
            // 
            this.demirbasTakipDataSetAmbar.DataSetName = "DemirbasTakipDataSet";
            this.demirbasTakipDataSetAmbar.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelAmbarAdi
            // 
            this.labelAmbarAdi.AutoSize = true;
            this.labelAmbarAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmbarAdi.Location = new System.Drawing.Point(15, 30);
            this.labelAmbarAdi.Name = "labelAmbarAdi";
            this.labelAmbarAdi.Size = new System.Drawing.Size(62, 15);
            this.labelAmbarAdi.TabIndex = 2;
            this.labelAmbarAdi.Text = "Ambar Adı";
            // 
            // textBoxAmbarAdi
            // 
            this.textBoxAmbarAdi.Location = new System.Drawing.Point(83, 27);
            this.textBoxAmbarAdi.MaxLength = 40;
            this.textBoxAmbarAdi.Name = "textBoxAmbarAdi";
            this.textBoxAmbarAdi.Size = new System.Drawing.Size(324, 21);
            this.textBoxAmbarAdi.TabIndex = 0;
            // 
            // ambarTableAdapter
            // 
            this.ambarTableAdapter.ClearBeforeFill = true;
            // 
            // ID_Ambar
            // 
            this.ID_Ambar.AutoSize = true;
            this.ID_Ambar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ID_Ambar.ForeColor = System.Drawing.SystemColors.Control;
            this.ID_Ambar.Location = new System.Drawing.Point(413, 30);
            this.ID_Ambar.Name = "ID_Ambar";
            this.ID_Ambar.Size = new System.Drawing.Size(13, 15);
            this.ID_Ambar.TabIndex = 43;
            this.ID_Ambar.Text = "0";
            // 
            // FormAmbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 421);
            this.Controls.Add(this.groupBoxAmbarlar);
            this.Name = "FormAmbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Ambar ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAmbar_FormClosed);
            this.Load += new System.EventHandler(this.FormAmbar_Load);
            this.groupBoxAmbarlar.ResumeLayout(false);
            this.groupBoxAmbarlar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAmbarlar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ambarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSetAmbar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAmbarlar;
        private System.Windows.Forms.Button buttonSonKayit;
        private System.Windows.Forms.Button buttonIlkKayit;
        private System.Windows.Forms.Label labelFiltre;
        private System.Windows.Forms.TextBox textBoxFiltreAmbarAdi;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonGeri;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIleri;
        private System.Windows.Forms.Button buttonYeniKayit;
        private System.Windows.Forms.DataGridView dataGridViewAmbarlar;
        private System.Windows.Forms.Label labelAmbarAdi;
        private System.Windows.Forms.TextBox textBoxAmbarAdi;
        private DemirbasTakipDataSet demirbasTakipDataSetAmbar;
        private System.Windows.Forms.BindingSource ambarBindingSource;
        private DemirbasTakipDataSetTableAdapters.AmbarTableAdapter ambarTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label ID_Ambar;
    }
}