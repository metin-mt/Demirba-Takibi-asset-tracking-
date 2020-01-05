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
    public partial class FormZimmet : Form
    {
        DataSet ds = new DataSet();
        DataSet dsPersonel = new DataSet();
        DataSet dsAmbar = new DataSet();
        DataSet dsDemirbas = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");

        public FormZimmet()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM SorguZimmetDAP WHERE ad like '%" + textBoxFiltreAdi.Text + "%' AND soyad like '%" + textBoxFiltreSoyadi.Text + "%' AND ambaradi like '%" + textBoxFiltreAmbarAdi.Text + "%' AND demirbaskodu like '%" + textBoxFiltreDemirbasKodu.Text + "%' AND demirbasadi like '%" + textBoxFiltreDemirbasAdi.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "SorguZimmetDAP");
        }


        private void FormZimmet_Load(object sender, EventArgs e)
        {
            this.sorguZimmetDAPTableAdapter.Fill(this.demirbasTakipDataSet.SorguZimmetDAP);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutuambar = "SELECT * FROM ambar";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutuambar, baglan);
            dsAmbar.Clear();
            da.Fill(dsAmbar, "ambar");

            comboBoxAmbar.ValueMember = "ID";
            comboBoxAmbar.DisplayMember = "AmbarAdi";
            comboBoxAmbar.DataSource = dsAmbar.Tables["ambar"];

            string sqlkomutudemirbas = "SELECT * FROM demirbas";
            da = new OleDbDataAdapter(sqlkomutudemirbas, baglan);
            dsDemirbas.Clear();
            da.Fill(dsDemirbas, "demirbas");

            comboBoxDemirbas.ValueMember = "ID";
            comboBoxDemirbas.DisplayMember = "DemirbasAdi";
            comboBoxDemirbas.DataSource = dsDemirbas.Tables["demirbas"];

            string sqlkomutupersonel = "SELECT * FROM SorguPersonelIDAdSoyad";
            da = new OleDbDataAdapter(sqlkomutupersonel, baglan);
            dsPersonel.Clear();
            da.Fill(dsPersonel, "SorguPersonelIDAdSoyad");

            comboBoxPersonel.ValueMember = "ID";
            comboBoxPersonel.DisplayMember = "AdiSoyadi";
            comboBoxPersonel.DataSource = dsPersonel.Tables["SorguPersonelIDAdSoyad"];

            verileri_cek();
            bs.DataSource = ds.Tables["SorguZimmetDAP"];
            dataGridViewZimmetler.DataSource = bs;
            ID_Zimmet.DataBindings.Add("Text", bs, "ID");
            textBoxMiktar.DataBindings.Add("Text", bs, "Miktar");
            dateTimePickerIslemTarihi.DataBindings.Add("Text", bs, "IslemTarihi");
            buttonKaydet.Visible = false;
        }

        private void FormZimmet_FormClosed(object sender, FormClosedEventArgs e)
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
            comboBoxAmbar.Text = "";
            comboBoxDemirbas.Text = "";
            comboBoxPersonel.Text = "";
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (comboBoxPersonel.Text.Trim() != "" && comboBoxAmbar.Text.Trim() != "" && comboBoxDemirbas.Text.Trim() != "" && textBoxMiktar.Text.Trim() != "")
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO zimmet (demirbasID,cikisambarID,personelID,miktar,IslemTarihi) Values ('" + comboBoxDemirbas.SelectedValue + "','" + comboBoxAmbar.SelectedValue + "','" + comboBoxPersonel.SelectedValue + "','" + textBoxMiktar.Text + "','" + Convert.ToDateTime(dateTimePickerIslemTarihi.Text) + "')";
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

            if (comboBoxPersonel.Text.Trim() != "" && comboBoxAmbar.Text.Trim() != "" && comboBoxDemirbas.Text.Trim() != "" && textBoxMiktar.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE zimmet SET demirbasID='" + comboBoxDemirbas.SelectedValue + "', cikisambarID='" + comboBoxAmbar.SelectedValue + "', personelID='" + comboBoxPersonel.SelectedValue + "', miktar='" + textBoxMiktar.Text + "', IslemTarihi='" + Convert.ToDateTime(dateTimePickerIslemTarihi.Text) + "' WHERE ID=" + ID_Zimmet.Text;
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
                komut.CommandText = "DELETE FROM zimmet WHERE ID=" + ID_Zimmet.Text;
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
    }
}