using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class InvoiceDTO
    {
        private int Invoice_Id;
        private string Date, Salesman, CustomerName, Contact;
        public InvoiceDTO(string Salesman, string CustomerName, string Contact)
        {
          
            this.Salesman = Salesman;
            this.CustomerName = CustomerName;
            this.Contact = Contact;
        }
        public int INVOICE_ID
        {
            get { return Invoice_Id; }
            set { Invoice_Id = value; }
        }
        public string DATE
        {
            get { return Date; }
            set { Date = value; }
        }
        public string SALESMAN
        {
            get { return Salesman; }
            set { Salesman = value; }
        }
        public string CUSTOMERNAME
        {
            get { return CustomerName; }
            set { CustomerName = value; }
        }
        public string CONTACT
        {
            get { return Contact; }
            set { Contact = value; }
        }
    }
}
