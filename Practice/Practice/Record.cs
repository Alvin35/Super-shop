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
    public partial class Record : Form
    {
        public int invoice_id;
        public Record()
        {
            DataSet dataset = new DataSet();
            InitializeComponent();
            InvoiceDAO invoicedao = new InvoiceDAO();
            dataset=invoicedao.InvoiceRecord();
            Grid.DataSource = dataset.Tables[0];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             var value = Grid.Rows[e.RowIndex].Cells[0].Value;
             invoice_id = Convert.ToInt32(value);
             InvoiceShow invshow = new InvoiceShow(this);
             invshow.Show();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Record_Load(object sender, EventArgs e)
        {

        }
    }
}
