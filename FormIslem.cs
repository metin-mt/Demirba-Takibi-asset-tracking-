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
    public partial class FormIslem : Form
    {
        DataSet ds = new DataSet();
        DataSet dsFaturaBilgisi = new DataSet();
        DataSet dsDemirbas = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormIslem()
        {
            InitializeComponent();
        }
        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM SorguAmbarIslemDemirbas WHERE firmaadi like '%" + textBoxFiltreFirmaAdi.Text + "%' AND faturano like '%" + textBoxFiltreFaturaNo.Text + "%' AND IslemTuru like '%" + textBoxFiltreIslemTuru.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "SorguAmbarIslemDemirbas");
        }

        private void FormIslem_Load(object sender, EventArgs e)
        {
            this.sorguAmbarIslemDemirbasTableAdapter.Fill(this.demirbasTakipDataSet.SorguAmbarIslemDemirbas);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutufatura = "SELECT * FROM SorguFaturaBilgisi";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutufatura, baglan);
            dsFaturaBilgisi.Clear();
            da.Fill(dsFaturaBilgisi, "SorguFaturaBilgisi");

            comboBoxFatura.ValueMember = "ID";
            comboBoxFatura.DisplayMember = "FaturaBilgisi";
            comboBoxFatura.DataSource = dsFaturaBilgisi.Tables["SorguFaturaBilgisi"];

            string sqlkomutudemirbas = "SELECT * FROM demirbas";
            da = new OleDbDataAdapter(sqlkomutudemirbas, baglan);
            dsDemirbas.Clear();
            da.Fill(dsDemirbas, "demirbas");

            comboBoxDemirbas.ValueMember = "ID";
            comboBoxDemirbas.DisplayMember = "DemirbasAdi";
            comboBoxDemirbas.DataSource = dsDemirbas.Tables["demirbas"];

            verileri_cek();
            bs.DataSource = ds.Tables["SorguAmbarIslemDemirbas"];
            dataGridViewIslemler.DataSource = bs;
            ID_Islem.DataBindings.Add("Text", bs, "ID");
            textBoxMiktar.DataBindings.Add("Text", bs, "Miktar");
            textBoxBirimFiyat.DataBindings.Add("Text", bs, "BirimFiyat");
            comboBoxFatura.DataBindings.Add("SelectedValue", bs, "AmbarFaturaID");
            comboBoxDemirbas.DataBindings.Add("SelectedValue", bs, "DemirbasID");
            buttonKaydet.Visible = false;
        }

        private void FormIslem_FormClosed(object sender, FormClosedEventArgs e)
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
            textBoxMiktar.Clear();
            textBoxBirimFiyat.Clear();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxFatura.Text.Trim() != "" & comboBoxDemirbas.Text.Trim() != "" && textBoxMiktar.Text.Trim() != "" && textBoxBirimFiyat.Text.Trim() != "")
            {   OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO AmbarIslem (AmbarFaturaID,DemirbasID,Miktar,BirimFiyat) Values ('" + comboBoxFatura.SelectedValue + "','" + comboBoxDemirbas.SelectedValue + "','" + textBoxMiktar.Text + "','" + textBoxBirimFiyat.Text + "')";
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
            if (comboBoxFatura.Text.Trim() != "" & comboBoxDemirbas.Text.Trim() != "" && textBoxMiktar.Text.Trim() != "" && textBoxBirimFiyat.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE AmbarIslem SET AmbarFaturaID='" + comboBoxFatura.SelectedValue + "', DemirbasID='" + comboBoxDemirbas.SelectedValue + "', Miktar='" + textBoxMiktar.Text + "', BirimFiyat='" + textBoxBirimFiyat.Text + "' WHERE ID=" + ID_Islem.Text;
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
                komut.CommandText = "DELETE FROM AmbarIslem WHERE ID=" + ID_Islem.Text;
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
    }
}