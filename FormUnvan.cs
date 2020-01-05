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
    public partial class FormUnvan : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");

        public FormUnvan()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM unvan WHERE unvanadi like '%" + textBoxFiltreUnvanAdi.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "unvan");
        }
        private void FormUnvan_Load(object sender, EventArgs e)
        {
            this.unvanTableAdapter.Fill(this.demirbasTakipDataSet.Unvan);
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            verileri_cek();
            bs.DataSource = ds.Tables["unvan"];

            dataGridViewUnvanlar.DataSource = bs;
            ID_Unvan.DataBindings.Add("Text", bs, "ID");
            textBoxUnvanAdi.DataBindings.Add("Text", bs, "unvanadi");
            buttonKaydet.Visible = false;
        }

        private void FormUnvan_FormClosed(object sender, FormClosedEventArgs e)
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
            textBoxUnvanAdi.Clear();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxUnvanAdi.Text.Trim() != "")
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO unvan (unvanadi) Values ('" + textBoxUnvanAdi.Text + "')";
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
            if (textBoxUnvanAdi.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE unvan SET unvanadi='" + textBoxUnvanAdi.Text + "' WHERE ID=" + ID_Unvan.Text;
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
                komut.CommandText = "DELETE FROM unvan WHERE ID=" + ID_Unvan.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı");
                verileri_cek();
            }
        }

        private void textBoxFiltreUnvanAdi_TextChanged(object sender, EventArgs e)
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