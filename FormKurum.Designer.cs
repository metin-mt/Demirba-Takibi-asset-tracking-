namespace DemirbasTakip
{
    partial class FormKurum
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
            this.groupBoxKurum = new System.Windows.Forms.GroupBox();
            this.comboBoxAmbarMemuru = new System.Windows.Forms.ComboBox();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.labelAmbarMemuru = new System.Windows.Forms.Label();
            this.labelKurumAdi = new System.Windows.Forms.Label();
            this.textBoxKurumAdi = new System.Windows.Forms.TextBox();
            this.groupBoxKurum.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKurum
            // 
            this.groupBoxKurum.Controls.Add(this.comboBoxAmbarMemuru);
            this.groupBoxKurum.Controls.Add(this.buttonGuncelle);
            this.groupBoxKurum.Controls.Add(this.labelAmbarMemuru);
            this.groupBoxKurum.Controls.Add(this.labelKurumAdi);
            this.groupBoxKurum.Controls.Add(this.textBoxKurumAdi);
            this.groupBoxKurum.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKurum.Location = new System.Drawing.Point(15, 13);
            this.groupBoxKurum.Name = "groupBoxKurum";
            this.groupBoxKurum.Size = new System.Drawing.Size(501, 154);
            this.groupBoxKurum.TabIndex = 22;
            this.groupBoxKurum.TabStop = false;
            this.groupBoxKurum.Text = "Kurumsal Bilgiler";
            // 
            // comboBoxAmbarMemuru
            // 
            this.comboBoxAmbarMemuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmbarMemuru.FormattingEnabled = true;
            this.comboBoxAmbarMemuru.Location = new System.Drawing.Point(116, 61);
            this.comboBoxAmbarMemuru.Name = "comboBoxAmbarMemuru";
            this.comboBoxAmbarMemuru.Size = new System.Drawing.Size(367, 23);
            this.comboBoxAmbarMemuru.TabIndex = 1;
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGuncelle.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGuncelle.Location = new System.Drawing.Point(205, 99);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(88, 46);
            this.buttonGuncelle.TabIndex = 2;
            this.buttonGuncelle.Text = "Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // labelAmbarMemuru
            // 
            this.labelAmbarMemuru.AutoSize = true;
            this.labelAmbarMemuru.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAmbarMemuru.Location = new System.Drawing.Point(15, 64);
            this.labelAmbarMemuru.Name = "labelAmbarMemuru";
            this.labelAmbarMemuru.Size = new System.Drawing.Size(91, 15);
            this.labelAmbarMemuru.TabIndex = 6;
            this.labelAmbarMemuru.Text = "Ambar Memuru";
            // 
            // labelKurumAdi
            // 
            this.labelKurumAdi.AutoSize = true;
            this.labelKurumAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKurumAdi.Location = new System.Drawing.Point(15, 30);
            this.labelKurumAdi.Name = "labelKurumAdi";
            this.labelKurumAdi.Size = new System.Drawing.Size(65, 15);
            this.labelKurumAdi.TabIndex = 2;
            this.labelKurumAdi.Text = "Kurum Adı";
            // 
            // textBoxKurumAdi
            // 
            this.textBoxKurumAdi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxKurumAdi.Location = new System.Drawing.Point(116, 27);
            this.textBoxKurumAdi.MaxLength = 100;
            this.textBoxKurumAdi.Name = "textBoxKurumAdi";
            this.textBoxKurumAdi.Size = new System.Drawing.Size(367, 26);
            this.textBoxKurumAdi.TabIndex = 0;
            // 
            // FormKurum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 180);
            this.Controls.Add(this.groupBoxKurum);
            this.Name = "FormKurum";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Kurumsal Bilgiler ]";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormKurum_FormClosed);
            this.Load += new System.EventHandler(this.FormKurum_Load);
            this.groupBoxKurum.ResumeLayout(false);
            this.groupBoxKurum.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKurum;
        private System.Windows.Forms.ComboBox comboBoxAmbarMemuru;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Label labelAmbarMemuru;
        private System.Windows.Forms.Label labelKurumAdi;
        private System.Windows.Forms.TextBox textBoxKurumAdi;
    }
}