using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace DemirbasTakip
{
    public partial class FormFirma : Form
    {
        DataSet ds = new DataSet();
        DataSet dsSehir = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormFirma()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM SorguFirmaSehir WHERE firmaadi like '%" + textBoxFiltreFirmaAdi.Text + "%' AND firmaadres like '%" + textBoxFiltreFirmaAdres.Text + "%' AND sehiradi like '%" + textBoxFiltreFirmaSehir.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "SorguFirmaSehir");

        }

        private void FormFirma_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirbasTakipDataSet.SorguFirmaSehir' table. You can move, or remove it, as needed.
            this.sorguFirmaSehirTableAdapter.Fill(this.demirbasTakipDataSet.SorguFirmaSehir);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutusehir = "SELECT * FROM sehir";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutusehir, baglan);
            dsSehir.Clear();
            da.Fill(dsSehir, "sehir");

            comboBoxSehir.ValueMember = "ID";
            comboBoxSehir.DisplayMember = "SehirAdi";
            comboBoxSehir.DataSource = dsSehir.Tables["sehir"];

            verileri_cek();
            bs.DataSource = ds.Tables["SorguFirmaSehir"];
            dataGridViewFirmalar.DataSource = bs;
            ID_Firma.DataBindings.Add("Text", bs, "ID");
            textBoxFirmaAdi.DataBindings.Add("Text", bs, "FirmaAdi");
            textBoxFirmaAdresi.DataBindings.Add("Text", bs, "FirmaAdres");
            textBoxTelefon.DataBindings.Add("Text", bs, "FirmaTelefon");
            textBoxFaks.DataBindings.Add("Text", bs, "FirmaFaks");
            textBoxEPosta.DataBindings.Add("Text", bs, "FirmaEPosta");
            comboBoxSehir.DataBindings.Add("SelectedValue", bs, "FirmaSehirID");

            buttonKaydet.Visible = false;
        }

        private void FormFirma_FormClosed(object sender, FormClosedEventArgs e)
        {
            baglan.Close();
            this.Close();
            FormAnaMenu formAnaMenu = new FormAnaMenu();
            formAnaMenu.Show();
        }

        private void buttonYeniKayit_Click(object sender, EventArgs e)
        {
            buttonKaydet.Visible = true;
            buttonGuncelle.Visible = false;
            buttonSil.Visible = false;
            textBoxFirmaAdi.Clear();
            textBoxFirmaAdresi.Clear();
            textBoxTelefon.Clear();
            textBoxFaks.Clear();
            textBoxEPosta.Clear();
            comboBoxSehir.Text = "KASTAMONU";
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxFirmaAdi.Text.Trim() != "" && textBoxFirmaAdresi.Text.Trim() != "" && textBoxTelefon.Text.Trim() != "" && textBoxFaks.Text.Trim() != "" && textBoxEPosta.Text.Trim() != "" && comboBoxSehir.Text.Trim() != "")
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO firma (firmaadi,firmaadres,firmasehirID,firmatelefon,firmafaks,firmaeposta) Values ('" + textBoxFirmaAdi.Text + "','" + textBoxFirmaAdresi.Text + "','" + comboBoxSehir.SelectedValue + "','" + textBoxTelefon.Text + "','" + textBoxFaks.Text + "','" + textBoxEPosta.Text + "')";
                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt İşlemi Tamamlandı");
                verileri_cek();
                buttonKaydet.Visible = false;
                buttonGuncelle.Visible = true;
                buttonSil.Visible = true;
                bs.Position = bs.Count;
            }
            else
            {
                MessageBox.Show("İşlem Geçersiz. Kayıt için gerekli alanları boş bırakamazsınız");
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxFirmaAdi.Text.Trim() != "" && textBoxFirmaAdresi.Text.Trim() != "" && textBoxTelefon.Text.Trim() != "" && textBoxFaks.Text.Trim() != "" && textBoxEPosta.Text.Trim() != "" && comboBoxSehir.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE firma SET firmaadi='" + textBoxFirmaAdi.Text + "', firmaadres='" + textBoxFirmaAdresi.Text + "', firmasehirID='" + comboBoxSehir.SelectedValue + "', firmatelefon='" + textBoxTelefon.Text + "', firmafaks='" + textBoxFaks.Text + "', firmaeposta='" + textBoxEPosta.Text + "' WHERE ID=" + ID_Firma.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Güncelleme İşlemi Tamamlandı");
                verileri_cek();
                bs.Position = pozisyontut;
            }
            else
            {
                MessageBox.Show("İşlem Geçersiz. Güncelleme için gerekli alanları boş bırakamazsınız");
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Silmek İstediğinizden Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (cevap == DialogResult.Yes)
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "DELETE FROM firma WHERE ID=" + ID_Firma.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı");
                verileri_cek();
            }
        }

        private void textBoxFiltreFirmaAdi_TextChanged(object sender, EventArgs e)
        {
            verileri_cek();
        }

        private void buttonIlkKayit_Click(object sender, EventArgs e)
        {
            bs.Position = 0;
        }

        private void buttonGeri_Click(object sender, EventArgs e)
        {
            if (--bs.Position < 0) bs.Position = bs.Count;

        }

        private void buttonIleri_Click(object sender, EventArgs e)
        {
            if (++bs.Position >= bs.Count) bs.Position = 0;

        }

        private void buttonSonKayit_Click(object sender, EventArgs e)
        {
            bs.Position = bs.Count;
        }
    }
}