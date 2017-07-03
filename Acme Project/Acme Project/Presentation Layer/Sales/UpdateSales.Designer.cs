namespace Acme_Project.Presentatin_Layer.Sales
{
    partial class frmUpdateSales
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
            this.grpUpdateSales = new System.Windows.Forms.GroupBox();
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
            this.btnUpdateSale = new System.Windows.Forms.Button();
            this.pnlUpdateSales = new System.Windows.Forms.Panel();
            this.grpUpdateSales.SuspendLayout();
            this.pnlUpdateSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateSales
            // 
            this.grpUpdateSales.Controls.Add(this.txtCustomerID);
            this.grpUpdateSales.Controls.Add(this.cbPayable);
            this.grpUpdateSales.Controls.Add(this.dtStartDate);
            this.grpUpdateSales.Controls.Add(this.lblStartDate);
            this.grpUpdateSales.Controls.Add(this.txtProductID);
            this.grpUpdateSales.Controls.Add(this.txtSaleID);
            this.grpUpdateSales.Controls.Add(this.lblPayable);
            this.grpUpdateSales.Controls.Add(this.lblSaleID);
            this.grpUpdateSales.Controls.Add(this.lblProductID);
            this.grpUpdateSales.Controls.Add(this.lblCustomerID);
            this.grpUpdateSales.Location = new System.Drawing.Point(124, 185);
            this.grpUpdateSales.Name = "grpUpdateSales";
            this.grpUpdateSales.Size = new System.Drawing.Size(378, 241);
            this.grpUpdateSales.TabIndex = 6;
            this.grpUpdateSales.TabStop = false;
            this.grpUpdateSales.Text = "Update Sales";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(117, 71);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.ReadOnly = true;
            this.txtCustomerID.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerID.TabIndex = 11;
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
            this.cbPayable.TabIndex = 0;
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(117, 200);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 1;
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
            this.txtProductID.ReadOnly = true;
            this.txtProductID.Size = new System.Drawing.Size(167, 20);
            this.txtProductID.TabIndex = 5;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(117, 27);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.ReadOnly = true;
            this.txtSaleID.Size = new System.Drawing.Size(167, 20);
            this.txtSaleID.TabIndex = 4;
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
            // btnUpdateSale
            // 
            this.btnUpdateSale.Location = new System.Drawing.Point(124, 38);
            this.btnUpdateSale.Name = "btnUpdateSale";
            this.btnUpdateSale.Size = new System.Drawing.Size(89, 23);
            this.btnUpdateSale.TabIndex = 0;
            this.btnUpdateSale.Text = "Update Sale";
            this.btnUpdateSale.UseVisualStyleBackColor = true;
            this.btnUpdateSale.Click += new System.EventHandler(this.btnUpdateSale_Click);
            // 
            // pnlUpdateSales
            // 
            this.pnlUpdateSales.Controls.Add(this.btnUpdateSale);
            this.pnlUpdateSales.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateSales.Location = new System.Drawing.Point(0, 511);
            this.pnlUpdateSales.Name = "pnlUpdateSales";
            this.pnlUpdateSales.Size = new System.Drawing.Size(934, 100);
            this.pnlUpdateSales.TabIndex = 12;
            // 
            // frmUpdateSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlUpdateSales);
            this.Controls.Add(this.grpUpdateSales);
            this.Name = "frmUpdateSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Sales";
            this.grpUpdateSales.ResumeLayout(false);
            this.grpUpdateSales.PerformLayout();
            this.pnlUpdateSales.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateSales;
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
        private System.Windows.Forms.Button btnUpdateSale;
        private System.Windows.Forms.Panel pnlUpdateSales;
    }
}