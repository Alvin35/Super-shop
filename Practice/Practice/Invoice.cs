using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Practice
{
    public partial class Invoice : Form
    {
        

        public DataTable table = new DataTable();
       
        List<int> l = new List<int>();
        public string CustomerName;
        public string CustomerContact;
        public string Salesman;
        public int total;
        public int Invoice_Id;
        InvoiceDAO invoicedao = new InvoiceDAO();
        bool flag = true;
        string index;
        


        public Invoice()
        {

            
            table.Columns.Add("Product Name:", typeof(string));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("UnitPrice", typeof(int));
            table.Columns.Add("LineTotal", typeof(int));
            InitializeComponent();
 
            Grid.DataSource = table;
            
            Invoice_Id = invoicedao.Get_Last_Invoice_Id()+1;
            InvoiceNo.Text = (invoicedao.Get_Last_Invoice_Id()+1).ToString();
            DateTime today = DateTime.Today;
            DateTime dateTime = DateTime.UtcNow.Date;
            Date.Text = dateTime.ToString("dd/MM/yyyy");
            
        }
     
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {



            
            string des = Description.Text;
            int quantity = Convert.ToInt32(Quantity.Text);
            int unitprice = Convert.ToInt32(UnitPrice.Text);
            int LineTotal = quantity * unitprice;
            l.Add(LineTotal);
           
            table.Rows.Add( des, quantity, unitprice, LineTotal);
            if(flag==true)
            {
                 CustomerName = Customer_Name.Text;
                 CustomerContact = Contact.Text;
                 Salesman = Sales_man.Text;
                 invoicedao.Create_Invoice(new InvoiceDTO(Salesman,CustomerName,CustomerContact));
                 flag = false;

                
            }
            invoicedao.Add_Item(new InvoiceItemDTO(Invoice_Id,des,quantity,unitprice,LineTotal));
           
            Grid.DataSource = table;

            Description.Text = "";
            Quantity.Text = "";
            UnitPrice.Text = "";
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = l.Sum();
            this.total = total;
            Sum.Text = total.ToString();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CustomerName = Customer_Name.Text;
            CustomerContact = Contact.Text;
            Salesman = Sales_man.Text;
            Invoice_Final inf = new Invoice_Final(this);
            inf.Receive(this);
            inf.Show();
            this.Hide();
        }

        private void Grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var value1 = Grid.Rows[e.RowIndex].Cells[0].Value;
            var value2 = Grid.Rows[e.RowIndex].Cells[1].Value;
            var value3 = Grid.Rows[e.RowIndex].Cells[2].Value;
            
            index = Grid.Rows[e.RowIndex].ToString();
            
            
          
            //MessageBox.Show(value.ToString());
            Description.Text = value1.ToString();
            Quantity.Text = value2.ToString();
            UnitPrice.Text = value3.ToString();
            
        }

        private void InvoiceNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            table.Rows.RemoveAt(Grid.SelectedRows[0].Index);
            int line_total = (Convert.ToInt32(Quantity.Text)) * (Convert.ToInt32(UnitPrice.Text));
            
            l.Remove(line_total);
            invoicedao.Delete_Item(Invoice_Id, Description.Text);
            Description.Text = "";
            Quantity.Text = "";
            UnitPrice.Text = "";

        }
       
    }
}
