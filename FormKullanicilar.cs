using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemirbasTakip
{
    public partial class FormKullanicilar : Form
    {
        public FormKullanicilar()
        {
            InitializeComponent();
        }

        private void FormKullanicilar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'demirbasTakipDataSet.Kullanici' table. You can move, or remove it, as needed.
            this.kullaniciTableAdapter.Fill(this.demirbasTakipDataSet.Kullanici);
            buttonKaydet.Visible = false;

        }

        private void buttonYeniKayit_Click(object sender, EventArgs e)
        {
            textBoxAdiSoyadi.Clear();
            textBoxKullaniciAdi.Clear();
            textBoxKullaniciParola.Clear();
            buttonKaydet.Visible = true;
            buttonGuncelle.Visible = false;
            buttonSil.Visible = false;
        }

        
    }
}
