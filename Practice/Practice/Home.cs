using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Practice
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void NewInvoice_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice();
            invoice.Show();
            this.Hide();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            Record r = new Record();
            r.Show();
            this.Hide();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }
    }
}
