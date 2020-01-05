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
    public partial class FormPersonel : Form
    {
        DataSet ds = new DataSet();
        DataSet dsUnvan = new DataSet();
        DataSet dsBirim = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormPersonel()
        {
            InitializeComponent();
        }
        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM SorguPersonelUnvanBirim WHERE ad like '%" + textBoxFiltreAdi.Text + "%' AND soyad like '%" + textBoxFiltreSoyadi.Text + "%' AND unvanadi like '%" + textBoxFiltreUnvani.Text + "%' AND birimadi like '%" + textBoxFiltreBirimi.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "SorguPersonelUnvanBirim");
        }

        private void FormPersonel_Load(object sender, EventArgs e)
        {
            this.sorguPersonelUnvanBirimTableAdapter.Fill(this.demirbasTakipDataSet.SorguPersonelUnvanBirim);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutuunvan = "SELECT * FROM unvan";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutuunvan, baglan);
            dsUnvan.Clear();
            da.Fill(dsUnvan, "unvan");

            comboBoxUnvan.ValueMember = "ID";
            comboBoxUnvan.DisplayMember = "UnvanAdi";
            comboBoxUnvan.DataSource = dsUnvan.Tables["unvan"];

            string sqlkomutubirim = "SELECT * FROM birim";
            da = new OleDbDataAdapter(sqlkomutubirim, baglan);
            dsBirim.Clear();
            da.Fill(dsBirim, "birim");

            comboBoxCalistigiBirim.ValueMember = "ID";
            comboBoxCalistigiBirim.DisplayMember = "BirimAdi";
            comboBoxCalistigiBirim.DataSource = dsBirim.Tables["birim"];

            verileri_cek();
            bs.DataSource = ds.Tables["SorguPersonelUnvanBirim"];
            dataGridViewPersonel.DataSource = bs;
            ID_Personel.DataBindings.Add("Text", bs, "ID");
            textBoxAdi.DataBindings.Add("Text", bs, "Ad");
            textBoxSoyadi.DataBindings.Add("Text", bs, "Soyad");
            textBoxTCKimlikNo.DataBindings.Add("Text", bs, "TCKimlikNo");
            textBoxKurumSicilNo.DataBindings.Add("Text", bs, "KurumSicilNo");
            textBoxTelefon.DataBindings.Add("Text", bs, "Telefon");
            textBoxEPosta.DataBindings.Add("Text", bs, "EPosta");
            comboBoxUnvan.DataBindings.Add("SelectedValue", bs, "UnvanID");
            comboBoxCalistigiBirim.DataBindings.Add("SelectedValue", bs, "CalistigiBirimID");
            comboBoxCinsiyet.DataBindings.Add("SelectedItem", bs, "cinsiyet");
            buttonKaydet.Visible = false;
        }

        private void FormPersonel_FormClosed(object sender, FormClosedEventArgs e)
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
            textBoxAdi.Clear();
            textBoxSoyadi.Clear();
            textBoxKurumSicilNo.Clear();
            textBoxTCKimlikNo.Clear();
            textBoxTelefon.Clear();
            textBoxEPosta.Clear();
            comboBoxUnvan.Text = "";
            comboBoxCalistigiBirim.Text = "";
            comboBoxCinsiyet.SelectedIndex = 0;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxAdi.Text.Trim() != "" && textBoxSoyadi.Text.Trim() != "" && textBoxTCKimlikNo.Text.Trim() != "" && textBoxKurumSicilNo.Text.Trim() != "" && comboBoxUnvan.Text.Trim() != "" && comboBoxCalistigiBirim.Text.Trim() != "" && comboBoxCinsiyet.Text.Trim() != "")
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO personel (ad,soyad,unvanID,cinsiyet,tckimlikno,kurumsicilno,calistigibirimID,telefon,eposta) Values ('" + textBoxAdi.Text + "','" + textBoxSoyadi.Text + "','" + comboBoxUnvan.SelectedValue + "','" + comboBoxCinsiyet.SelectedItem + "','" + textBoxTCKimlikNo.Text + "','" + textBoxKurumSicilNo.Text + "','" + comboBoxCalistigiBirim.SelectedValue + "','" + textBoxTelefon.Text + "','" + textBoxEPosta.Text + "')";
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
            if (textBoxAdi.Text.Trim() != "" && textBoxSoyadi.Text.Trim() != "" && textBoxTCKimlikNo.Text.Trim() != "" && textBoxKurumSicilNo.Text.Trim() != "" && comboBoxUnvan.Text.Trim() != "" && comboBoxCalistigiBirim.Text.Trim() != "" && comboBoxCinsiyet.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE personel SET ad='" + textBoxAdi.Text + "', soyad='" + textBoxSoyadi.Text + "', unvanID='" + comboBoxUnvan.SelectedValue + "', cinsiyet='" + comboBoxCinsiyet.SelectedItem + "', tckimlikno='" + textBoxTCKimlikNo.Text + "', kurumsicilno='" + textBoxKurumSicilNo.Text + "', calistigibirimID='" + comboBoxCalistigiBirim.SelectedValue + "', telefon='" + textBoxTelefon.Text + "', eposta='" + textBoxEPosta.Text + "' WHERE ID=" + ID_Personel.Text;
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
                komut.CommandText = "DELETE FROM personel WHERE ID=" + ID_Personel.Text;
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

        private void textBoxFiltreAdi_TextChanged(object sender, EventArgs e)
        {
            verileri_cek();
        }

        private void comboBoxUnvan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelAdi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelSoyadi_Click(object sender, EventArgs e)
        {

        }

        private void textBoxSoyadi_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBoxPersonel_Enter(object sender, EventArgs e)
        {

        }
    }
}