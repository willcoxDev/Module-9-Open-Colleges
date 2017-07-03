namespace Acme_Project.Presentatin_Layer.Products
{
    partial class frmAddProduct
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
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblYearlyPremium = new System.Windows.Forms.Label();
            this.grpAddProduct = new System.Windows.Forms.GroupBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.txtYearlyPremium = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlAddProduct = new System.Windows.Forms.Panel();
            this.grpAddProduct.SuspendLayout();
            this.pnlAddProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Location = new System.Drawing.Point(19, 30);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            this.lblProductID.Visible = false;
            this.lblProductID.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(19, 76);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type:";
            this.lblProductType.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 122);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            this.lblProductName.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblYearlyPremium
            // 
            this.lblYearlyPremium.AutoSize = true;
            this.lblYearlyPremium.Location = new System.Drawing.Point(19, 168);
            this.lblYearlyPremium.Name = "lblYearlyPremium";
            this.lblYearlyPremium.Size = new System.Drawing.Size(82, 13);
            this.lblYearlyPremium.TabIndex = 3;
            this.lblYearlyPremium.Text = "Yearly Premium:";
            // 
            // grpAddProduct
            // 
            this.grpAddProduct.Controls.Add(this.cbProductType);
            this.grpAddProduct.Controls.Add(this.txtYearlyPremium);
            this.grpAddProduct.Controls.Add(this.txtProductName);
            this.grpAddProduct.Controls.Add(this.txtProductID);
            this.grpAddProduct.Controls.Add(this.lblYearlyPremium);
            this.grpAddProduct.Controls.Add(this.lblProductID);
            this.grpAddProduct.Controls.Add(this.lblProductName);
            this.grpAddProduct.Controls.Add(this.lblProductType);
            this.grpAddProduct.Location = new System.Drawing.Point(92, 193);
            this.grpAddProduct.Name = "grpAddProduct";
            this.grpAddProduct.Size = new System.Drawing.Size(378, 209);
            this.grpAddProduct.TabIndex = 4;
            this.grpAddProduct.TabStop = false;
            this.grpAddProduct.Text = "Add Product";
            // 
            // cbProductType
            // 
            this.cbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(117, 73);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(167, 21);
            this.cbProductType.TabIndex = 1;
            // 
            // txtYearlyPremium
            // 
            this.txtYearlyPremium.Location = new System.Drawing.Point(117, 165);
            this.txtYearlyPremium.Name = "txtYearlyPremium";
            this.txtYearlyPremium.Size = new System.Drawing.Size(167, 20);
            this.txtYearlyPremium.TabIndex = 3;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(117, 119);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(167, 20);
            this.txtProductName.TabIndex = 2;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(117, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(167, 20);
            this.txtProductID.TabIndex = 0;
            this.txtProductID.Visible = false;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(92, 41);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(91, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "&Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnlAddProduct
            // 
            this.pnlAddProduct.Controls.Add(this.btnAddProduct);
            this.pnlAddProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddProduct.Location = new System.Drawing.Point(0, 511);
            this.pnlAddProduct.Name = "pnlAddProduct";
            this.pnlAddProduct.Size = new System.Drawing.Size(934, 100);
            this.pnlAddProduct.TabIndex = 12;
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlAddProduct);
            this.Controls.Add(this.grpAddProduct);
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            this.grpAddProduct.ResumeLayout(false);
            this.grpAddProduct.PerformLayout();
            this.pnlAddProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblYearlyPremium;
        private System.Windows.Forms.GroupBox grpAddProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox txtYearlyPremium;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlAddProduct;
    }
}