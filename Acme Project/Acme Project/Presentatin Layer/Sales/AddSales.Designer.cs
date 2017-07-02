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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.txtSaleID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtStartDate = new System.Windows.Forms.DateTimePicker();
            this.cbPayable = new System.Windows.Forms.ComboBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnAddSale = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtCustomerID);
            this.groupBox1.Controls.Add(this.cbPayable);
            this.groupBox1.Controls.Add(this.dtStartDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtProductID);
            this.groupBox1.Controls.Add(this.txtSaleID);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(120, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 241);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Sales";
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 119);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(167, 20);
            this.txtProductID.TabIndex = 5;
            // 
            // txtSaleID
            // 
            this.txtSaleID.Location = new System.Drawing.Point(117, 27);
            this.txtSaleID.Name = "txtSaleID";
            this.txtSaleID.Size = new System.Drawing.Size(167, 20);
            this.txtSaleID.TabIndex = 4;
            this.txtSaleID.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Payable:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sale ID:";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Product ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Start Date:";
            // 
            // dtStartDate
            // 
            this.dtStartDate.Location = new System.Drawing.Point(117, 200);
            this.dtStartDate.Name = "dtStartDate";
            this.dtStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtStartDate.TabIndex = 9;
            // 
            // cbPayable
            // 
            this.cbPayable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPayable.FormattingEnabled = true;
            this.cbPayable.Items.AddRange(new object[] {
            "F",
            "M",
            "Y"});
            this.cbPayable.Location = new System.Drawing.Point(117, 165);
            this.cbPayable.Name = "cbPayable";
            this.cbPayable.Size = new System.Drawing.Size(167, 21);
            this.cbPayable.TabIndex = 10;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(117, 73);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(167, 20);
            this.txtCustomerID.TabIndex = 11;
            // 
            // btnAddSale
            // 
            this.btnAddSale.Location = new System.Drawing.Point(593, 299);
            this.btnAddSale.Name = "btnAddSale";
            this.btnAddSale.Size = new System.Drawing.Size(89, 23);
            this.btnAddSale.TabIndex = 6;
            this.btnAddSale.Text = "Add Sale";
            this.btnAddSale.UseVisualStyleBackColor = true;
            this.btnAddSale.Click += new System.EventHandler(this.btnAddSale_Click);
            // 
            // frmAddSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.btnAddSale);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAddSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Sales";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.ComboBox cbPayable;
        private System.Windows.Forms.DateTimePicker dtStartDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.TextBox txtSaleID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddSale;
    }
}