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
    public partial class Invoice_Final : Form
    {
        Invoice inv;
        public Invoice_Final(Invoice inv)
        {
            InitializeComponent();
            this.inv = inv;
            dataGridView1.DataSource = inv.table;
            CustomerName.Text = inv.CustomerName;
            Contact.Text = inv.CustomerContact;
            Salesman.Text = inv.Salesman;
            Invoice_No.Text = inv.Invoice_Id.ToString();
            Total.Text = inv.total.ToString();
            DateTime today = DateTime.Today;
            DateTime dateTime = DateTime.UtcNow.Date;
            Date.Text = dateTime.ToString("dd/MM/yyyy");
        }
        public void Receive(Invoice inv)
        {
            this.inv = inv;
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        Bitmap bitmap;

        private void button1_Click(object sender, EventArgs e)
        {
            bitmap = new Bitmap(panel1.Width, panel1.Height);
            panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
