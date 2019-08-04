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
    public partial class Search : Form
    {
        InvoiceDAO invoicedao = new InvoiceDAO();
        public int invoice_id;
        public Search()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            string Invoice_Id = Search_Invoice.Text;
            int invoice_id = Convert.ToInt32(Invoice_Id);
            DataSet dataset = new DataSet();
            dataset = invoicedao.Search_Invoice(invoice_id);

            dt = dataset.Tables[0];
            
            try
            {
                Search_Invoice.Text = "";
                DataRow dr = dt.Rows[0];
                Grid.DataSource = dataset.Tables[0];
            }
            catch
            {
                MessageBox.Show("Invoice not Found");
                Grid.DataSource = "";
            }
            
         


        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
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
    }
}
