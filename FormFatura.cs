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
    public partial class FormFatura : Form
    {
        DataSet ds = new DataSet();
        DataSet dsFirma = new DataSet();
        DataSet dsAmbar = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormFatura()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM SorguAmbarFaturaAmbarFirma WHERE firmaadi like '%" + textBoxFiltreFirmaAdi.Text + "%' AND ambaradi like '%" + textBoxFiltreAmbarAdi.Text + "%' AND Islemturu like '%" + textBoxFiltreIslemTuru.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "SorguAmbarFaturaAmbarFirma");
        }

        private void FormAmbarGirisCikisIslemleri_Load(object sender, EventArgs e)
        {
            this.sorguAmbarFaturaAmbarFirmaTableAdapter.Fill(this.demirbasTakipDataSet.SorguAmbarFaturaAmbarFirma);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutuambar = "SELECT * FROM ambar";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutuambar, baglan);
            dsAmbar.Clear();
            da.Fill(dsAmbar, "ambar");

            comboBoxAmbar.ValueMember = "ID";
            comboBoxAmbar.DisplayMember = "AmbarAdi";
            comboBoxAmbar.DataSource = dsAmbar.Tables["ambar"];

            string sqlkomutufirma = "SELECT * FROM firma";
            da = new OleDbDataAdapter(sqlkomutufirma, baglan);
            dsFirma.Clear();
            da.Fill(dsFirma, "firma");

            comboBoxFirma.ValueMember = "ID";
            comboBoxFirma.DisplayMember = "FirmaAdi";
            comboBoxFirma.DataSource = dsFirma.Tables["firma"];

            verileri_cek();
            bs.DataSource = ds.Tables["SorguAmbarFaturaAmbarFirma"];
            dataGridViewFaturalar.DataSource = bs;
            ID_Fatura.DataBindings.Add("Text", bs, "ID");
            textBoxFaturaNo.DataBindings.Add("Text", bs, "FaturaNo");
            dateTimePickerFaturaTarihi.DataBindings.Add("Text", bs, "FaturaTarihi");
            dateTimePickerIslemTarihi.DataBindings.Add("Text", bs, "IslemTarihi");
            comboBoxFirma.DataBindings.Add("SelectedValue", bs, "FirmaID");
            comboBoxAmbar.DataBindings.Add("SelectedValue", bs, "AmbarID");
            comboBoxIslemTuru.DataBindings.Add("SelectedItem", bs, "IslemTuru");
            buttonKaydet.Visible = false;
        }

        private void FormAmbarGirisCikisIslemleri_FormClosed(object sender, FormClosedEventArgs e)
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
            textBoxFaturaNo.Clear();
            comboBoxAmbar.Text = "";
            comboBoxFirma.Text = "";
            comboBoxIslemTuru.SelectedIndex = 0;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxFaturaNo.Text.Trim() != "" && comboBoxAmbar.Text.Trim() != "" && comboBoxFirma.Text.Trim() != "" && comboBoxIslemTuru.Text.Trim() != "")
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO ambarfatura (ambarID,firmaID,IslemTarihi,IslemTuru,FaturaTarihi,FaturaNo) Values ('" + comboBoxAmbar.SelectedValue + "','" + comboBoxFirma.SelectedValue + "','" + Convert.ToDateTime(dateTimePickerIslemTarihi.Text) + "','" + comboBoxIslemTuru.SelectedItem + "','" + Convert.ToDateTime(dateTimePickerFaturaTarihi.Text) + "','" + textBoxFaturaNo.Text + "')";
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
            if (textBoxFaturaNo.Text.Trim() != "" && comboBoxAmbar.Text.Trim() != "" && comboBoxFirma.Text.Trim() != "" && comboBoxIslemTuru.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE ambarfatura SET ambarID='" + comboBoxAmbar.SelectedValue + "', firmaID='" + comboBoxFirma.SelectedValue + "', IslemTarihi='" + Convert.ToDateTime(dateTimePickerIslemTarihi.Text) + "', IslemTuru='" + comboBoxIslemTuru.SelectedItem + "', FaturaTarihi='" + Convert.ToDateTime(dateTimePickerFaturaTarihi.Text) + "', FaturaNo='" + textBoxFaturaNo.Text + "' WHERE ID=" + ID_Fatura.Text;
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
                komut.CommandText = "DELETE FROM ambarfatura WHERE ID=" + ID_Fatura.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı");
                verileri_cek();
            }
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

        private void textBoxFiltreFirmaAdi_TextChanged(object sender, EventArgs e)
        {
            verileri_cek();
        }

        private void dataGridViewFaturalar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}