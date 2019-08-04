using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Practice
{
    class InvoiceItemDTO
    {
        private int Invoice_Id,Quantity,Unit_Price,Line_Total;
        string Description;
        public InvoiceItemDTO(int Invoice_Id,string Description, int Qunatity, int Unit_Price, int Line_Total)
        {
            this.Invoice_Id=Invoice_Id;
            this.Description = Description;
            this.Quantity=Qunatity;
            this.Unit_Price=Unit_Price;
            this.Line_Total=Line_Total;
            

        }
        public int INVOICE_ID
        {
            get { return Invoice_Id; }
            set { Invoice_Id = value; }
        }
        public string DESCRIPTION
        {
            get { return Description; }
            set { Description = value; }
        }
        public int QUANTITY
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public int UNITPRICE
        {
            get { return Unit_Price; }
            set { Unit_Price = value; }
        }
        public int LINETOTAL
        {
            get { return Line_Total; }
            set { Line_Total = value; }
        }
    }
}
