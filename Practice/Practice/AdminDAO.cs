using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace Practice
{
    class AdminDAO
    {
        
        String connectionString = "Data Source=.;Initial Catalog=Invoice1;Integrated Security=True";
        private SqlConnection sqlConnection;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private DataSet dataset;
        public AdminDAO()
        {
            sqlConnection = new SqlConnection(connectionString);
        }
        public bool LogIn(string username, string password)
        {
           
            DataTable dt = new DataTable();
            
            
              sqlConnection.Open();

   
            
            string sqlQuery = "SELECT * from Admin_Info where Name='"+username+"'";
            sqlCommand = new SqlCommand(sqlQuery, sqlConnection);

            sqlAdapter = new SqlDataAdapter(sqlCommand);
            dataset = new DataSet();

            sqlAdapter.Fill(dataset);
            sqlConnection.Close();
            dt = dataset.Tables[0];
            string passwd="";
            try
            {
                DataRow dr = dt.Rows[0];
                passwd = dr["Password"].ToString();
                if (passwd == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                return false;
            }
            
        }
    }
}
