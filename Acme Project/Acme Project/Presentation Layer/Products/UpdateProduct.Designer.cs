namespace Acme_Project.Presentatin_Layer.Products
{
    partial class frmUpdateProduct
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
            this.grpUpdateProduct = new System.Windows.Forms.GroupBox();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.txtYearlyPremium = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lblYearlyPremium = new System.Windows.Forms.Label();
            this.lblProductID = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.pnlUpdateProduct = new System.Windows.Forms.Panel();
            this.grpUpdateProduct.SuspendLayout();
            this.pnlUpdateProduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpUpdateProduct
            // 
            this.grpUpdateProduct.Controls.Add(this.cbProductType);
            this.grpUpdateProduct.Controls.Add(this.txtYearlyPremium);
            this.grpUpdateProduct.Controls.Add(this.txtProductName);
            this.grpUpdateProduct.Controls.Add(this.txtProductID);
            this.grpUpdateProduct.Controls.Add(this.lblYearlyPremium);
            this.grpUpdateProduct.Controls.Add(this.lblProductID);
            this.grpUpdateProduct.Controls.Add(this.lblProductName);
            this.grpUpdateProduct.Controls.Add(this.lblProductType);
            this.grpUpdateProduct.Location = new System.Drawing.Point(130, 188);
            this.grpUpdateProduct.Name = "grpUpdateProduct";
            this.grpUpdateProduct.Size = new System.Drawing.Size(378, 209);
            this.grpUpdateProduct.TabIndex = 5;
            this.grpUpdateProduct.TabStop = false;
            this.grpUpdateProduct.Text = "Add Product";
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
            this.txtProductID.Enabled = false;
            this.txtProductID.Location = new System.Drawing.Point(117, 27);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(167, 20);
            this.txtProductID.TabIndex = 0;
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
            // lblProductID
            // 
            this.lblProductID.AutoSize = true;
            this.lblProductID.Enabled = false;
            this.lblProductID.Location = new System.Drawing.Point(19, 30);
            this.lblProductID.Name = "lblProductID";
            this.lblProductID.Size = new System.Drawing.Size(61, 13);
            this.lblProductID.TabIndex = 0;
            this.lblProductID.Text = "Product ID:";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(19, 122);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(78, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product Name:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(19, 76);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(74, 13);
            this.lblProductType.TabIndex = 1;
            this.lblProductType.Text = "Product Type:";
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(130, 37);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateProduct.TabIndex = 0;
            this.btnUpdateProduct.Text = "Update Product";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // pnlUpdateProduct
            // 
            this.pnlUpdateProduct.Controls.Add(this.btnUpdateProduct);
            this.pnlUpdateProduct.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateProduct.Location = new System.Drawing.Point(0, 511);
            this.pnlUpdateProduct.Name = "pnlUpdateProduct";
            this.pnlUpdateProduct.Size = new System.Drawing.Size(934, 100);
            this.pnlUpdateProduct.TabIndex = 25;
            // 
            // frmUpdateProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlUpdateProduct);
            this.Controls.Add(this.grpUpdateProduct);
            this.Name = "frmUpdateProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Product";
            this.Load += new System.EventHandler(this.frmUpdateProduct_Load);
            this.grpUpdateProduct.ResumeLayout(false);
            this.grpUpdateProduct.PerformLayout();
            this.pnlUpdateProduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpUpdateProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.TextBox txtYearlyPremium;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lblYearlyPremium;
        private System.Windows.Forms.Label lblProductID;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Panel pnlUpdateProduct;
    }
}