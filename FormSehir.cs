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
    public partial class FormSehir : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormSehir()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM sehir WHERE sehiradi like '%" + textBoxFiltreSehirAdi.Text + "%'";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "sehir");
        }


        private void FormSehir_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirbasTakipDataSet.Sehir' table. You can move, or remove it, as needed.
            this.sehirTableAdapter.Fill(this.demirbasTakipDataSet.Sehir);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            verileri_cek();
            bs.DataSource = ds.Tables["sehir"];

            dataGridViewSehirler.DataSource = bs;
            ID_Sehir.DataBindings.Add("Text", bs, "ID");
            textBoxSehirAdi.DataBindings.Add("Text", bs, "sehiradi");
            buttonKaydet.Visible = false;
        }

        private void FormSehir_FormClosed(object sender, FormClosedEventArgs e)
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
            textBoxSehirAdi.Clear();
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            if (textBoxSehirAdi.Text.Trim() != "")
            {
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "INSERT INTO sehir (sehiradi) Values ('" + textBoxSehirAdi.Text + "')";
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
            if (textBoxSehirAdi.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE sehir SET sehiradi='" + textBoxSehirAdi.Text + "' WHERE ID=" + ID_Sehir.Text;
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
                komut.CommandText = "DELETE FROM sehir WHERE ID=" + ID_Sehir.Text;
                komut.ExecuteNonQuery();
                MessageBox.Show("Silme İşlemi Tamamlandı");
                verileri_cek();
            }
        }


        private void textBoxFiltreSehirAdi_TextChanged(object sender, EventArgs e)
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