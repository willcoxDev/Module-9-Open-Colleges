namespace Acme_Project.Presentatin_Layer.Products
{
    partial class frmMainProducts
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
            this.pnlProducts = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.rbSearchFirstName = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbSearchState = new System.Windows.Forms.RadioButton();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.pnlProducts.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlProducts
            // 
            this.pnlProducts.Controls.Add(this.grpSearch);
            this.pnlProducts.Controls.Add(this.btnAddProduct);
            this.pnlProducts.Controls.Add(this.btnDeleteProduct);
            this.pnlProducts.Controls.Add(this.btnSearchProduct);
            this.pnlProducts.Controls.Add(this.btnUpdateProduct);
            this.pnlProducts.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlProducts.Location = new System.Drawing.Point(0, 499);
            this.pnlProducts.Name = "pnlProducts";
            this.pnlProducts.Size = new System.Drawing.Size(934, 112);
            this.pnlProducts.TabIndex = 8;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.cbState);
            this.grpSearch.Controls.Add(this.txtSearchFirstName);
            this.grpSearch.Controls.Add(this.rbSearchFirstName);
            this.grpSearch.Controls.Add(this.rbShowAll);
            this.grpSearch.Controls.Add(this.rbSearchState);
            this.grpSearch.Location = new System.Drawing.Point(478, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(219, 106);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Parameters";
            // 
            // cbState
            // 
            this.cbState.FormattingEnabled = true;
            this.cbState.Items.AddRange(new object[] {
            "SA",
            "VIC",
            "NSW",
            "QLD",
            "NT",
            "WA",
            "TAS"});
            this.cbState.Location = new System.Drawing.Point(109, 76);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(100, 21);
            this.cbState.TabIndex = 19;
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(109, 45);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFirstName.TabIndex = 9;
            // 
            // rbSearchFirstName
            // 
            this.rbSearchFirstName.AutoSize = true;
            this.rbSearchFirstName.Location = new System.Drawing.Point(8, 47);
            this.rbSearchFirstName.Name = "rbSearchFirstName";
            this.rbSearchFirstName.Size = new System.Drawing.Size(75, 17);
            this.rbSearchFirstName.TabIndex = 6;
            this.rbSearchFirstName.Text = "First Name";
            this.rbSearchFirstName.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(8, 15);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(117, 17);
            this.rbShowAll.TabIndex = 7;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show all Customers";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // rbSearchState
            // 
            this.rbSearchState.AutoSize = true;
            this.rbSearchState.Location = new System.Drawing.Point(8, 79);
            this.rbSearchState.Name = "rbSearchState";
            this.rbSearchState.Size = new System.Drawing.Size(50, 17);
            this.rbSearchState.TabIndex = 8;
            this.rbSearchState.Text = "State";
            this.rbSearchState.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(34, 46);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "&Add Products";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(145, 46);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "&Delete Products";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(367, 46);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(105, 23);
            this.btnSearchProduct.TabIndex = 3;
            this.btnSearchProduct.Text = "&Search Products";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(256, 46);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Text = "&Update Products";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            // 
            // frmMainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlProducts);
            this.Name = "frmMainProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.pnlProducts.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.RadioButton rbSearchFirstName;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbSearchState;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
    }
}