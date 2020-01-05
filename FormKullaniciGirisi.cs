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
    public partial class FormKullaniciGirisi : Form
    {
        DataSet ds = new DataSet();
        BindingSource bs = new BindingSource();
        OleDbConnection baglan = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DemirbasTakip.accdb");
        public FormKullaniciGirisi()
        {
            InitializeComponent();
        }

        void girisKontrol()
        {
            if (baglan.State == ConnectionState.Closed) baglan.Open();
            string sqlkomutu = "SELECT * FROM kullanici WHERE kullaniciadi='" + textBoxKullaniciAdi.Text + "' AND kullaniciparolasi='" + textBoxKullaniciParolasi.Text + "'";
            OleDbCommand komut = new OleDbCommand(sqlkomutu, baglan);
            OleDbDataReader okuyucu = komut.ExecuteReader();
            if (okuyucu.Read())
            {
                this.Hide();
                FormAnaMenu formAnaMenu = new FormAnaMenu();
                formAnaMenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Hatal, girdin İBO Abi");
                Application.Exit();
            }
            baglan.Close();
            baglan.Dispose();
        }

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            girisKontrol();
        }
    }
}
