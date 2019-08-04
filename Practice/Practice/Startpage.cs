using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace Practice
{
    public partial class Startpage : Form
    {
        public Startpage()
        {
            InitializeComponent();
          
            
            
        }

        private void Startpage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminDAO admindao=new AdminDAO();
            string username = UserName.Text;
            string password = Password.Text;
            bool status = admindao.LogIn(username,password);
            if (status == true)
            {
                Home h = new Home();
                h.Show();
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Wrong UserName Password Combination");
                Password.Text = "";
                UserName.Text = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
       

    }
}
