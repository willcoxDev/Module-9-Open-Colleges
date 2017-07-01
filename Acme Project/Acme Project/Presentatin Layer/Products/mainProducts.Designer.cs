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
            this.txtSearchYearlyPremium = new System.Windows.Forms.TextBox();
            this.cbSearchOperator = new System.Windows.Forms.ComboBox();
            this.txtSearchFirstName = new System.Windows.Forms.TextBox();
            this.rbSearchProductName = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbSearchYearlyPremium = new System.Windows.Forms.RadioButton();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyPremium = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlProducts.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
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
            this.grpSearch.Controls.Add(this.txtSearchYearlyPremium);
            this.grpSearch.Controls.Add(this.cbSearchOperator);
            this.grpSearch.Controls.Add(this.txtSearchFirstName);
            this.grpSearch.Controls.Add(this.rbSearchProductName);
            this.grpSearch.Controls.Add(this.rbShowAll);
            this.grpSearch.Controls.Add(this.rbSearchYearlyPremium);
            this.grpSearch.Location = new System.Drawing.Point(478, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(330, 106);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Parameters";
            // 
            // txtSearchYearlyPremium
            // 
            this.txtSearchYearlyPremium.Location = new System.Drawing.Point(156, 77);
            this.txtSearchYearlyPremium.Name = "txtSearchYearlyPremium";
            this.txtSearchYearlyPremium.Size = new System.Drawing.Size(100, 20);
            this.txtSearchYearlyPremium.TabIndex = 21;
            // 
            // cbSearchOperator
            // 
            this.cbSearchOperator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSearchOperator.FormattingEnabled = true;
            this.cbSearchOperator.Items.AddRange(new object[] {
            "<",
            "=",
            ">"});
            this.cbSearchOperator.Location = new System.Drawing.Point(111, 76);
            this.cbSearchOperator.Name = "cbSearchOperator";
            this.cbSearchOperator.Size = new System.Drawing.Size(39, 21);
            this.cbSearchOperator.TabIndex = 20;
            this.cbSearchOperator.UseWaitCursor = true;
            // 
            // txtSearchFirstName
            // 
            this.txtSearchFirstName.Location = new System.Drawing.Point(156, 46);
            this.txtSearchFirstName.Name = "txtSearchFirstName";
            this.txtSearchFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtSearchFirstName.TabIndex = 9;
            // 
            // rbSearchProductName
            // 
            this.rbSearchProductName.AutoSize = true;
            this.rbSearchProductName.Location = new System.Drawing.Point(8, 47);
            this.rbSearchProductName.Name = "rbSearchProductName";
            this.rbSearchProductName.Size = new System.Drawing.Size(93, 17);
            this.rbSearchProductName.TabIndex = 6;
            this.rbSearchProductName.Text = "Product Name";
            this.rbSearchProductName.UseVisualStyleBackColor = true;
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
            // rbSearchYearlyPremium
            // 
            this.rbSearchYearlyPremium.AutoSize = true;
            this.rbSearchYearlyPremium.Location = new System.Drawing.Point(8, 79);
            this.rbSearchYearlyPremium.Name = "rbSearchYearlyPremium";
            this.rbSearchYearlyPremium.Size = new System.Drawing.Size(97, 17);
            this.rbSearchYearlyPremium.TabIndex = 8;
            this.rbSearchYearlyPremium.Text = "Yearly Premium";
            this.rbSearchYearlyPremium.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(34, 46);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(105, 23);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "&Add Products";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(145, 46);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteProduct.TabIndex = 5;
            this.btnDeleteProduct.Text = "&Delete Products";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
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
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductType,
            this.ProductName,
            this.YearlyPremium});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(934, 499);
            this.dgvProducts.TabIndex = 9;
            // 
            // ProductID
            // 
            this.ProductID.DataPropertyName = "ProductID";
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "ProductTypeID";
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.Name = "ProductType";
            // 
            // ProductName
            // 
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            // 
            // YearlyPremium
            // 
            this.YearlyPremium.DataPropertyName = "YearlyPremium";
            this.YearlyPremium.HeaderText = "Yearly Premium";
            this.YearlyPremium.Name = "YearlyPremium";
            // 
            // frmMainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.pnlProducts);
            this.Name = "frmMainProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Products";
            this.Load += new System.EventHandler(this.frmMainProducts_Load);
            this.pnlProducts.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlProducts;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchFirstName;
        private System.Windows.Forms.RadioButton rbSearchProductName;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbSearchYearlyPremium;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSearchProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.ComboBox cbSearchOperator;
        private System.Windows.Forms.TextBox txtSearchYearlyPremium;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearlyPremium;
    }
}