namespace Acme_Project.Presentatin_Layer.Sales
{
    partial class frmAddSales
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
            this.grpAddSales = new System.Windows.Forms.GroupBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.cbPayable = new System.Windows.Forms.ComboBox();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.lblPayable = new System.Windows.Forms.Label();
            this.lblSaleID = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.pnlAddSales = new System.Windows.Forms.Panel();
            this.grpAddSales.SuspendLayout();
            this.pnlAddSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddSales
            // 
            this.grpAddSales.Controls.Add(this.txtCustomerID);
            this.grpAddSales.Controls.Add(this.cbPayable);
            this.grpAddSales.Controls.Add(this.dtStartDate);
            this.grpAddSales.Controls.Add(this.lblStartDate);
            this.grpAddSales.Controls.Add(this.txtProductID);
            this.grpAddSales.Controls.Add(this.txtSaleID);
            this.grpAddSales.Controls.Add(this.lblPayable);
            this.grpAddSales.Controls.Add(this.lblSaleID);
            this.grpAddSales.Controls.Add(this.lblProductID);
            this.grpAddSales.Controls.Add(this.lblCustomerID);
            this.grpAddSales.Location = new System.Drawing.Point(120, 188);
            this.grpAddSales.Name = "grpAddSales";
            this.grpAddSales.Size = new System.Drawing.Size(378, 241);
            this.grpAddSales.TabIndex = 0;
            this.grpAddSales.TabStop = false;
            this.grpAddSales.Text = "Add Sales";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(117, 71);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerID.TabIndex = 1;
            // 
            // cbPayable
            // 
            this.cbPayable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayable.FormattingEnabled = true;
            this.cbPayable.Items.AddRange(new object[] {
            "F",
            "M",
            "Y"});
            this.cbPayable.Location = new System.Drawing.Point(117, 159);
            this.cbPayable.Name = "cbPayable";
            this.cbPayable.Size = new System.Drawing.Size(167, 21);
            this.cbPayable.TabIndex = 3;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(117, 200);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 4;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(19, 206);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(58, 13);
            this.lblStartDate.TabIndex = 8;
            this.lblStartDate.Text = "Start Date:";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 115);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(167, 20);
            this.txtProductID.TabIndex = 2;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(117, 27);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(167, 20);
            this.txtSaleID.TabIndex = 0;
            this.txtSaleID.Visible = false;
            // 
            // lblPayable
            // 
            this.lblPayable.AutoSize = true;
            this.lblPayable.Location = new System.Drawing.Point(19, 162);
            this.lblPayable.Name = "lblPayable";
            this.lblPayable.Size = new System.Drawing.Size(48, 13);
            this.lblPayable.TabIndex = 3;
            this.lblPayable.Text = "Payable:";
            // 
            // lblSaleID
            // 
            this.lblSaleID.AutoSize = true;
            this.lblSaleID.Location = new System.Drawing.Point(19, 30);
            this.lblSaleID.Name = "lblSaleID";
            this.lblSaleID.Size = new System.Drawing.Size(45, 13);
            this.lblSaleID.TabIndex = 0;
            this.lblSaleID.Text = "Sale ID:";
            this.lblSaleID.Visible = false;
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(19, 118);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 2;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(19, 74);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 1;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(120, 43);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(89, 23);
            this.btnAddSale.TabIndex = 0;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // pnlAddSales
            // 
            this.pnlAddSales.Controls.Add(this.btnAddSale);
            this.pnlAddSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddSales.Location = new System.Drawing.Point(0, 511);
            this.pnlAddSales.Name = "pnlAddSales";
            this.pnlAddSales.Size = new System.Drawing.Size(934, 100);
            this.pnlAddSales.TabIndex = 12;
            // 
            // frmAddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlAddSales);
            this.Controls.Add(this.grpAddSales);
            this.Name = "frmAddSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Sales";
            this.grpAddSales.ResumeLayout(false);
            this.grpAddSales.PerformLayout();
            this.pnlAddSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddSales;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ComboBox cbPayable;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label lblPayable;
        private System.Windows.Forms.Label lblSaleID;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.Button btnAddSale;
        private System.Windows.Forms.Panel pnlAddSales;
    }
}