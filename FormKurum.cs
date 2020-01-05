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
    public partial class FormKurum : Form
    {
        DataSet ds = new DataSet();
        DataSet dsPersonel = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");

        public FormKurum()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM kurum WHERE ID=1";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "kurum");
        }

        private void FormKurum_Load(object sender, EventArgs e)
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutupersonel = "SELECT * FROM SorguPersonelIDAdSoyad";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutupersonel, baglan);
            dsPersonel.Clear();
            da.Fill(dsPersonel, "SorguPersonelIDAdSoyad");

            comboBoxAmbarMemuru.ValueMember = "ID";
            comboBoxAmbarMemuru.DisplayMember = "AdiSoyadi";
            comboBoxAmbarMemuru.DataSource = dsPersonel.Tables["SorguPersonelIDAdSoyad"];

            verileri_cek();
            bs.DataSource = ds.Tables["kurum"];
            textBoxKurumAdi.DataBindings.Add("Text", bs, "KurumAdi");
            comboBoxAmbarMemuru.DataBindings.Add("SelectedValue", bs, "AmbarMemuruID");
        }

        private void FormKurum_FormClosed(object sender, FormClosedEventArgs e)
        {
            baglan.Close();
            this.Close();
            FormAnaMenu formAnaMenu = new FormAnaMenu();
            formAnaMenu.Show();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (textBoxKurumAdi.Text.Trim() != "" && comboBoxAmbarMemuru.Text.Trim() != "")
            {
                int pozisyontut = bs.Position;
                OleDbCommand komut = new OleDbCommand();
                komut.Connection = baglan;
                komut.CommandText = "UPDATE kurum SET kurumadi='" + textBoxKurumAdi.Text + "', ambarmemuruID='" + comboBoxAmbarMemuru.SelectedValue + "' WHERE ID=1";
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
    }
}