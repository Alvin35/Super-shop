namespace Practice
{
    partial class InvoiceShow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.InvoiceNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Contact = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Salesman = new System.Windows.Forms.TextBox();
            this.Grid = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.Total = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice No :";
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.Location = new System.Drawing.Point(142, 33);
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.Size = new System.Drawing.Size(139, 24);
            this.InvoiceNo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(545, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // Date
            // 
            this.Date.Location = new System.Drawing.Point(613, 36);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(85, 24);
            this.Date.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Customer Name:";
            // 
            // CustomerName
            // 
            this.CustomerName.Location = new System.Drawing.Point(143, 86);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(187, 24);
            this.CustomerName.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact:";
            // 
            // Contact
            // 
            this.Contact.Location = new System.Drawing.Point(143, 130);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(194, 24);
            this.Contact.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Salesman:";
            // 
            // Salesman
            // 
            this.Salesman.Location = new System.Drawing.Point(142, 181);
            this.Salesman.Name = "Salesman";
            this.Salesman.Size = new System.Drawing.Size(195, 24);
            this.Salesman.TabIndex = 9;
            // 
            // Grid
            // 
            this.Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid.Location = new System.Drawing.Point(41, 226);
            this.Grid.Name = "Grid";
            this.Grid.Size = new System.Drawing.Size(833, 419);
            this.Grid.TabIndex = 10;
            this.Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(629, 660);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total:";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(708, 660);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(166, 24);
            this.Total.TabIndex = 12;
            // 
            // InvoiceShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 741);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Grid);
            this.Controls.Add(this.Salesman);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.InvoiceNo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "InvoiceShow";
            this.Text = "InvoiceShow";
            this.Load += new System.EventHandler(this.InvoiceShow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InvoiceNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CustomerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Contact;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Salesman;
        private System.Windows.Forms.DataGridView Grid;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Total;
    }
}