namespace Practice
{
    partial class Home
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
            this.NewInvoice = new System.Windows.Forms.Button();
            this.Record = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewInvoice
            // 
            this.NewInvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewInvoice.Location = new System.Drawing.Point(327, 145);
            this.NewInvoice.Name = "NewInvoice";
            this.NewInvoice.Size = new System.Drawing.Size(135, 44);
            this.NewInvoice.TabIndex = 0;
            this.NewInvoice.Text = "New Invoice";
            this.NewInvoice.UseVisualStyleBackColor = true;
            this.NewInvoice.Click += new System.EventHandler(this.NewInvoice_Click);
            // 
            // Record
            // 
            this.Record.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Record.Location = new System.Drawing.Point(327, 229);
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(135, 37);
            this.Record.TabIndex = 1;
            this.Record.Text = "Record";
            this.Record.UseVisualStyleBackColor = true;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(327, 306);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(135, 36);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(789, 487);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Record);
            this.Controls.Add(this.NewInvoice);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Easy Invoice";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewInvoice;
        private System.Windows.Forms.Button Record;
        private System.Windows.Forms.Button Search;
    }
}