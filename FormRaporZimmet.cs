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
    public partial class FormRaporZimmet : Form
    {
        DataSet ds = new DataSet();
        DataSet dsPersonel = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormRaporZimmet()
        {
            InitializeComponent();
        }

        void verileri_cek()
        {
            string sqlkomutu = "SELECT * FROM SorguZimmetDAP WHERE personelID = " + comboBoxPersonel.SelectedValue;
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutu, baglan);
            ds.Clear();
            da.Fill(ds, "SorguZimmetDAP");
        }

        private void FormRaporZimmet_Load(object sender, EventArgs e)
        {
            this.sorguZimmetDAPTableAdapter.Fill(this.demirbasTakipDataSet.SorguZimmetDAP);
            if (baglan.State == ConnectionState.Closed) baglan.Open();

            string sqlkomutupersonel = "SELECT * FROM SorguPersonelIDAdSoyad";
            OleDbDataAdapter da = new OleDbDataAdapter(sqlkomutupersonel, baglan);
            dsPersonel.Clear();
            da.Fill(dsPersonel, "SorguPersonelIDAdSoyad");

            comboBoxPersonel.ValueMember = "ID";
            comboBoxPersonel.DisplayMember = "AdiSoyadi";
            comboBoxPersonel.DataSource = dsPersonel.Tables["SorguPersonelIDAdSoyad"];

            verileri_cek();
            bs.DataSource = ds.Tables["SorguZimmetDAP"];
            dataGridViewZimmetler.DataSource = bs;
        }

        private void FormRaporZimmet_FormClosed(object sender, FormClosedEventArgs e)
        {
            baglan.Close();
            this.Close();
            FormAnaMenu formAnaMenu = new FormAnaMenu();
            formAnaMenu.Show();
        }

        private void comboBoxPersonel_SelectedIndexChanged(object sender, EventArgs e)
        {
            verileri_cek();
        }

        private void buttonPDF_Click(object sender, EventArgs e)
        {
            this.Close();
            FormPDF formPDF = new FormPDF();
            formPDF.ShowDialog();
        }
    }
}