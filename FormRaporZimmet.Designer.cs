namespace DemirbasTakip
{
    partial class FormRaporZimmet
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBoxRapor = new System.Windows.Forms.GroupBox();
            this.comboBoxPersonel = new System.Windows.Forms.ComboBox();
            this.dataGridViewZimmetler = new System.Windows.Forms.DataGridView();
            this.ıDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cikisAmbarIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.personelIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambarAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demirbasBirimiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ıslemTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sorguZimmetDAPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.demirbasTakipDataSet = new DemirbasTakip.DemirbasTakipDataSet();
            this.labelPersonel = new System.Windows.Forms.Label();
            this.sorguZimmetDAPTableAdapter = new DemirbasTakip.DemirbasTakipDataSetTableAdapters.SorguZimmetDAPTableAdapter();
            this.buttonPDF = new System.Windows.Forms.Button();
            this.groupBoxRapor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmetler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguZimmetDAPBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRapor
            // 
            this.groupBoxRapor.Controls.Add(this.buttonPDF);
            this.groupBoxRapor.Controls.Add(this.comboBoxPersonel);
            this.groupBoxRapor.Controls.Add(this.dataGridViewZimmetler);
            this.groupBoxRapor.Controls.Add(this.labelPersonel);
            this.groupBoxRapor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxRapor.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRapor.Name = "groupBoxRapor";
            this.groupBoxRapor.Size = new System.Drawing.Size(650, 674);
            this.groupBoxRapor.TabIndex = 26;
            this.groupBoxRapor.TabStop = false;
            this.groupBoxRapor.Text = "Zimmet Raporu";
            // 
            // comboBoxPersonel
            // 
            this.comboBoxPersonel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonel.FormattingEnabled = true;
            this.comboBoxPersonel.Location = new System.Drawing.Point(120, 31);
            this.comboBoxPersonel.Name = "comboBoxPersonel";
            this.comboBoxPersonel.Size = new System.Drawing.Size(341, 23);
            this.comboBoxPersonel.TabIndex = 0;
            this.comboBoxPersonel.SelectedIndexChanged += new System.EventHandler(this.comboBoxPersonel_SelectedIndexChanged);
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
            this.ambarAdiDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.demirbasKoduDataGridViewTextBoxColumn,
            this.demirbasAdiDataGridViewTextBoxColumn,
            this.miktarDataGridViewTextBoxColumn,
            this.demirbasBirimiDataGridViewTextBoxColumn,
            this.ıslemTarihiDataGridViewTextBoxColumn});
            this.dataGridViewZimmetler.DataSource = this.sorguZimmetDAPBindingSource;
            this.dataGridViewZimmetler.Location = new System.Drawing.Point(14, 86);
            this.dataGridViewZimmetler.Name = "dataGridViewZimmetler";
            this.dataGridViewZimmetler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewZimmetler.Size = new System.Drawing.Size(623, 576);
            this.dataGridViewZimmetler.TabIndex = 2;
            // 
            // ıDDataGridViewTextBoxColumn
            // 
            this.ıDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.ıDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.ıDDataGridViewTextBoxColumn.Name = "ıDDataGridViewTextBoxColumn";
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
            // ambarAdiDataGridViewTextBoxColumn
            // 
            this.ambarAdiDataGridViewTextBoxColumn.DataPropertyName = "AmbarAdi";
            this.ambarAdiDataGridViewTextBoxColumn.HeaderText = "AmbarAdi";
            this.ambarAdiDataGridViewTextBoxColumn.Name = "ambarAdiDataGridViewTextBoxColumn";
            this.ambarAdiDataGridViewTextBoxColumn.Visible = false;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Visible = false;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Visible = false;
            // 
            // demirbasKoduDataGridViewTextBoxColumn
            // 
            this.demirbasKoduDataGridViewTextBoxColumn.DataPropertyName = "DemirbasKodu";
            this.demirbasKoduDataGridViewTextBoxColumn.HeaderText = "D.Kodu";
            this.demirbasKoduDataGridViewTextBoxColumn.Name = "demirbasKoduDataGridViewTextBoxColumn";
            this.demirbasKoduDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasKoduDataGridViewTextBoxColumn.Width = 70;
            // 
            // demirbasAdiDataGridViewTextBoxColumn
            // 
            this.demirbasAdiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasAdi";
            this.demirbasAdiDataGridViewTextBoxColumn.HeaderText = "Demirbaş Adı";
            this.demirbasAdiDataGridViewTextBoxColumn.Name = "demirbasAdiDataGridViewTextBoxColumn";
            this.demirbasAdiDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasAdiDataGridViewTextBoxColumn.Width = 260;
            // 
            // miktarDataGridViewTextBoxColumn
            // 
            this.miktarDataGridViewTextBoxColumn.DataPropertyName = "Miktar";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N0";
            dataGridViewCellStyle2.NullValue = null;
            this.miktarDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.miktarDataGridViewTextBoxColumn.HeaderText = "Miktarı";
            this.miktarDataGridViewTextBoxColumn.Name = "miktarDataGridViewTextBoxColumn";
            this.miktarDataGridViewTextBoxColumn.ReadOnly = true;
            this.miktarDataGridViewTextBoxColumn.Width = 60;
            // 
            // demirbasBirimiDataGridViewTextBoxColumn
            // 
            this.demirbasBirimiDataGridViewTextBoxColumn.DataPropertyName = "DemirbasBirimi";
            this.demirbasBirimiDataGridViewTextBoxColumn.HeaderText = "Birimi";
            this.demirbasBirimiDataGridViewTextBoxColumn.Name = "demirbasBirimiDataGridViewTextBoxColumn";
            this.demirbasBirimiDataGridViewTextBoxColumn.ReadOnly = true;
            this.demirbasBirimiDataGridViewTextBoxColumn.Width = 70;
            // 
            // ıslemTarihiDataGridViewTextBoxColumn
            // 
            this.ıslemTarihiDataGridViewTextBoxColumn.DataPropertyName = "IslemTarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.HeaderText = "Veriliş Tarihi";
            this.ıslemTarihiDataGridViewTextBoxColumn.Name = "ıslemTarihiDataGridViewTextBoxColumn";
            this.ıslemTarihiDataGridViewTextBoxColumn.ReadOnly = true;
            this.ıslemTarihiDataGridViewTextBoxColumn.Width = 120;
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
            // labelPersonel
            // 
            this.labelPersonel.AutoSize = true;
            this.labelPersonel.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPersonel.Location = new System.Drawing.Point(11, 36);
            this.labelPersonel.Name = "labelPersonel";
            this.labelPersonel.Size = new System.Drawing.Size(73, 15);
            this.labelPersonel.TabIndex = 2;
            this.labelPersonel.Text = "Personel Adı";
            // 
            // sorguZimmetDAPTableAdapter
            // 
            this.sorguZimmetDAPTableAdapter.ClearBeforeFill = true;
            // 
            // buttonPDF
            // 
            this.buttonPDF.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonPDF.ForeColor = System.Drawing.Color.Green;
            this.buttonPDF.Location = new System.Drawing.Point(505, 29);
            this.buttonPDF.Name = "buttonPDF";
            this.buttonPDF.Size = new System.Drawing.Size(132, 28);
            this.buttonPDF.TabIndex = 1;
            this.buttonPDF.Text = "Rapor Al [ PDF ]";
            this.buttonPDF.UseVisualStyleBackColor = true;
            this.buttonPDF.Click += new System.EventHandler(this.buttonPDF_Click);
            // 
            // FormRaporZimmet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(670, 698);
            this.Controls.Add(this.groupBoxRapor);
            this.Name = "FormRaporZimmet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRaporZimmet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRaporZimmet_FormClosed);
            this.Load += new System.EventHandler(this.FormRaporZimmet_Load);
            this.groupBoxRapor.ResumeLayout(false);
            this.groupBoxRapor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewZimmetler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sorguZimmetDAPBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.demirbasTakipDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRapor;
        private System.Windows.Forms.ComboBox comboBoxPersonel;
        private System.Windows.Forms.DataGridView dataGridViewZimmetler;
        private System.Windows.Forms.Label labelPersonel;
        private DemirbasTakipDataSet demirbasTakipDataSet;
        private System.Windows.Forms.BindingSource sorguZimmetDAPBindingSource;
        private DemirbasTakipDataSetTableAdapters.SorguZimmetDAPTableAdapter sorguZimmetDAPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cikisAmbarIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn personelIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambarAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn demirbasBirimiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ıslemTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonPDF;
    }
}