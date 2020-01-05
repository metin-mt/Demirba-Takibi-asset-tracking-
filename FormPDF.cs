using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DemirbasTakip
{
    public partial class FormPDF : Form
    {
        public FormPDF()
        {
            InitializeComponent();
        }

        private void FormPDF_Load(object sender, EventArgs e)
        {
            this.SorguZimmetDAPTableAdapter.Fill(this.DemirbasTakipDataSet.SorguZimmetDAP);
            this.reportViewer1.RefreshReport();
        }

        private void FormPDF_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
            FormRaporZimmet formRaporZimmet = new FormRaporZimmet();
            formRaporZimmet.ShowDialog();
        }
    }
}

/*
 
       

 
 */