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
    public partial class FormAnaMenu : Form
    {
        public FormAnaMenu()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItemKullanicilar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKullanicilar formKullanicilar = new FormKullanicilar();
           formKullanicilar.ShowDialog();
        }

        private void CikisMenusuEvetCikiyorum_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void demirbaşBiglileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDemirbas formDemirbas = new FormDemirbas();
            formDemirbas.ShowDialog();
        }

        private void FormAnaMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void HakkindaMenusu_Click(object sender, EventArgs e)
        {
            FormHakkinda formHakkinda = new FormHakkinda();
            formHakkinda.ShowDialog();
        }

        private void KartlarMenusuAmbarBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormAmbar formAmbar = new FormAmbar();
            formAmbar.ShowDialog();
        }

        private void KartlarMenusuBirimBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBirim formBirim = new FormBirim();
            formBirim.ShowDialog();
        }

        private void KartlarMenusuUnvanBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormUnvan formUnvan = new FormUnvan();
            formUnvan.ShowDialog();
        }

        private void KartlarMenusuSehirBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSehir formSehir = new FormSehir();
            formSehir.ShowDialog();
        }

        private void KartlarMenusuFirmaBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFirma formFirma = new FormFirma();
            formFirma.ShowDialog();
        }

        private void KartlarMenusuPersonelBilgileri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormPersonel formPersonel = new FormPersonel();
            formPersonel.ShowDialog();
        }

        private void KartlarMenusuGenelBilgiler_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormKurum formKurum = new FormKurum();
            formKurum.ShowDialog();
        }

        private void HareketlerMenusuAmbarGirisCikisIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFatura formFatura = new FormFatura();
            formFatura.ShowDialog();
        }

        private void faturaİşlemVeAyrıntılarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormIslem formIslem = new FormIslem();
            formIslem.ShowDialog();

        }

        private void HareketlerMenusuZimmetIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormZimmet formZimmet = new FormZimmet();
            formZimmet.ShowDialog();
        }

        private void RaporlarMenusuZimmetRaporuIslemleri_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRaporZimmet formRaporZimmet = new FormRaporZimmet();
            formRaporZimmet.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
