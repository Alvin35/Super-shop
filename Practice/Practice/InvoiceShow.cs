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
    public partial class InvoiceShow : Form
    {
        Record r;
        Search s;
        int Invoice_Id;
        InvoiceDAO invoicedao = new InvoiceDAO();
        public InvoiceShow(Record r)
        {
            InitializeComponent();
            this.r = r;
            //InvoiceNo.Text = r.invoice_id.ToString();
            Invoice_Id = r.invoice_id;
            Show_Invoice();
            Show_InvoiceItem();
        }
        public InvoiceShow(Search s)
        {
            InitializeComponent();
            this.s = s;
            //InvoiceNo.Text = r.invoice_id.ToString();
            Invoice_Id = s.invoice_id;
            Show_Invoice();
            Show_InvoiceItem();

        }
        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void InvoiceShow_Load(object sender, EventArgs e)
        {

        }
        private void Show_Invoice()
        {
            DataTable dt = new DataTable();
            DataSet dataset = new DataSet();
            dataset = invoicedao.Get_Invoice(Invoice_Id);
            dt = dataset.Tables[0];
            DataRow dr = dt.Rows[0];
            Date.Text = dr["Date"].ToString();
            CustomerName.Text= dr["CustomerName"].ToString();
            Contact.Text = dr["Contact"].ToString();
            Salesman.Text = dr["Salesman"].ToString();
            InvoiceNo.Text = Invoice_Id.ToString();

        }
        private void Show_InvoiceItem()
        {
            DataSet dataset = new DataSet();
            dataset = invoicedao.Get_All_Item(Invoice_Id);
            Grid.DataSource = dataset.Tables[0];
            int total = invoicedao.Get_Invoice_Total(Invoice_Id);
            Total.Text = total.ToString();
        }
    }
}
