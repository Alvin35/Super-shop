using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Practice
{
    class InvoiceDAO
    {
        private String connectionString = "Data Source=.;Initial Catalog=Invoice1;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataset;
        public DataTable table = new DataTable();

        public InvoiceDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }

        public void Create_Invoice(InvoiceDTO invoicedto)
        {
            sqlConnection.Open();
            string sqlQuery = "insert into Invoice values(getdate(),'" + invoicedto.SALESMAN + "','" + invoicedto.CUSTOMERNAME + "','" + invoicedto.CONTACT + "')";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataSet Get_Invoice(int invoice_id)
        {

            sqlConnection.Open();
            string sqlQuery = "SELECT * FROM Invoice where Invoice_Id='"+invoice_id+"'";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();

            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            return dataset;

           
        }
        public DataSet Get_All_Item(int invoice_id)
        {
            sqlConnection.Open();
            string sqlQuery = "SELECT Description,Quantity,Unit_Price,Line_Total from Invoice_Item where Invoice_Id='" + invoice_id + "'";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();

            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            return dataset;
        }
        public int Get_Last_Invoice_Id()
        {
            DataTable dt = new DataTable();
            sqlConnection.Open();
            string sqlQuery = "SELECT TOP 1  Invoice_ID FROM Invoice ORDER BY Invoice_Id DESC";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();
            
            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            dt = dataset.Tables[0];
            DataRow dr = dt.Rows[0];
            string Invoice_Id = dr["Invoice_Id"].ToString();
            int InvoiceId = Convert.ToInt32(Invoice_Id);
            return InvoiceId;
        }
        public void Add_Item(InvoiceItemDTO invoiceitemdto)
        {
            sqlConnection.Open();
            string sqlQuery = "insert into Invoice_Item values('" + invoiceitemdto.INVOICE_ID + "','" + invoiceitemdto.DESCRIPTION + "','" + invoiceitemdto.QUANTITY + "','" + invoiceitemdto.UNITPRICE + "','"+invoiceitemdto.LINETOTAL+"')";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void Delete_Item(int invoice_id, string Description)
        {
            sqlConnection.Open();
            string sqlQuery = "delete from Invoice_Item where Invoice_Id='"+invoice_id+"' and Description='"+Description+"' ";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataSet InvoiceRecord()
        {
            sqlConnection.Open();
            string sqlQuery = "select Invoice_Id,Date from Invoice order by Invoice_Id DESC";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();

            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            return dataset;
        }
        public int Get_Invoice_Total(int invoice_id)
        {
            DataTable dt = new DataTable();
            sqlConnection.Open();
            string sqlQuery = "SELECT SUM(Line_Total) from Invoice_Item where Invoice_Id='"+invoice_id+"' ";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();

            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            dt = dataset.Tables[0];
            DataRow dr = dt.Rows[0];
            string total = dr[0].ToString();
            int Total = Convert.ToInt32(total);
            return Total;

        }
        public DataSet Search_Invoice(int invoice_id)
        {
            sqlConnection.Open();
            string sqlQuery = "select Invoice_Id,Date from Invoice where Invoice_Id='"+invoice_id+"'";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();

            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            return dataset;
        }
        
    }
    
}
