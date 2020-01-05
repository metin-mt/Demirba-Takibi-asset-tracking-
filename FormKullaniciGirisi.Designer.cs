namespace DemirbasTakip
{
    partial class FormKullaniciGirisi
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
            this.groupBoxKullaniciGirisi = new System.Windows.Forms.GroupBox();
            this.buttonGirisYap = new System.Windows.Forms.Button();
            this.labelKullaniciParolasi = new System.Windows.Forms.Label();
            this.textBoxKullaniciParolasi = new System.Windows.Forms.TextBox();
            this.labelKullaniciAdi = new System.Windows.Forms.Label();
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.groupBoxKullaniciGirisi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxKullaniciGirisi
            // 
            this.groupBoxKullaniciGirisi.Controls.Add(this.buttonGirisYap);
            this.groupBoxKullaniciGirisi.Controls.Add(this.labelKullaniciParolasi);
            this.groupBoxKullaniciGirisi.Controls.Add(this.textBoxKullaniciParolasi);
            this.groupBoxKullaniciGirisi.Controls.Add(this.labelKullaniciAdi);
            this.groupBoxKullaniciGirisi.Controls.Add(this.textBoxKullaniciAdi);
            this.groupBoxKullaniciGirisi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBoxKullaniciGirisi.Location = new System.Drawing.Point(17, 14);
            this.groupBoxKullaniciGirisi.Name = "groupBoxKullaniciGirisi";
            this.groupBoxKullaniciGirisi.Size = new System.Drawing.Size(360, 162);
            this.groupBoxKullaniciGirisi.TabIndex = 21;
            this.groupBoxKullaniciGirisi.TabStop = false;
            // 
            // buttonGirisYap
            // 
            this.buttonGirisYap.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonGirisYap.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonGirisYap.ForeColor = System.Drawing.Color.DodgerBlue;
            this.buttonGirisYap.Location = new System.Drawing.Point(124, 102);
            this.buttonGirisYap.Name = "buttonGirisYap";
            this.buttonGirisYap.Size = new System.Drawing.Size(171, 30);
            this.buttonGirisYap.TabIndex = 5;
            this.buttonGirisYap.Text = "Giriş Yap";
            this.buttonGirisYap.UseVisualStyleBackColor = true;
            this.buttonGirisYap.Click += new System.EventHandler(this.buttonGirisYap_Click);
            // 
            // labelKullaniciParolasi
            // 
            this.labelKullaniciParolasi.AutoSize = true;
            this.labelKullaniciParolasi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciParolasi.Location = new System.Drawing.Point(15, 62);
            this.labelKullaniciParolasi.Name = "labelKullaniciParolasi";
            this.labelKullaniciParolasi.Size = new System.Drawing.Size(103, 15);
            this.labelKullaniciParolasi.TabIndex = 6;
            this.labelKullaniciParolasi.Text = "Kullanıcı Parolası";
            // 
            // textBoxKullaniciParolasi
            // 
            this.textBoxKullaniciParolasi.Location = new System.Drawing.Point(124, 59);
            this.textBoxKullaniciParolasi.MaxLength = 40;
            this.textBoxKullaniciParolasi.Name = "textBoxKullaniciParolasi";
            this.textBoxKullaniciParolasi.Size = new System.Drawing.Size(171, 21);
            this.textBoxKullaniciParolasi.TabIndex = 2;
            this.textBoxKullaniciParolasi.UseSystemPasswordChar = true;
            // 
            // labelKullaniciAdi
            // 
            this.labelKullaniciAdi.AutoSize = true;
            this.labelKullaniciAdi.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelKullaniciAdi.Location = new System.Drawing.Point(15, 31);
            this.labelKullaniciAdi.Name = "labelKullaniciAdi";
            this.labelKullaniciAdi.Size = new System.Drawing.Size(77, 15);
            this.labelKullaniciAdi.TabIndex = 4;
            this.labelKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(124, 28);
            this.textBoxKullaniciAdi.MaxLength = 40;
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(171, 21);
            this.textBoxKullaniciAdi.TabIndex = 1;
            // 
            // FormKullaniciGirisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 196);
            this.Controls.Add(this.groupBoxKullaniciGirisi);
            this.Name = "FormKullaniciGirisi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Demirbaş Takip Programı [ Kullanıcı Girişi ]";
            this.groupBoxKullaniciGirisi.ResumeLayout(false);
            this.groupBoxKullaniciGirisi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxKullaniciGirisi;
        private System.Windows.Forms.Button buttonGirisYap;
        private System.Windows.Forms.Label labelKullaniciParolasi;
        private System.Windows.Forms.TextBox textBoxKullaniciParolasi;
        private System.Windows.Forms.Label labelKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
    }
}