namespace Acme_Project.Presentatin_Layer.Sales
{
    partial class frmMainSales
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchSaleID = new System.Windows.Forms.TextBox();
            this.rbSearchSaleID = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbSearchProductID = new System.Windows.Forms.RadioButton();
            this.btnAddSales = new System.Windows.Forms.Button();
            this.btnDeleteSales = new System.Windows.Forms.Button();
            this.btnSearchSales = new System.Windows.Forms.Button();
            this.btnUpdateSales = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchProductID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grpSearch);
            this.panel1.Controls.Add(this.btnAddSales);
            this.panel1.Controls.Add(this.btnDeleteSales);
            this.panel1.Controls.Add(this.btnSearchSales);
            this.panel1.Controls.Add(this.btnUpdateSales);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 112);
            this.panel1.TabIndex = 8;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearchProductID);
            this.grpSearch.Controls.Add(this.txtSearchSaleID);
            this.grpSearch.Controls.Add(this.rbSearchSaleID);
            this.grpSearch.Controls.Add(this.rbShowAll);
            this.grpSearch.Controls.Add(this.rbSearchProductID);
            this.grpSearch.Location = new System.Drawing.Point(478, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(219, 106);
            this.grpSearch.TabIndex = 11;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Parameters";
            // 
            // txtSearchSaleID
            // 
            this.txtSearchSaleID.Location = new System.Drawing.Point(109, 46);
            this.txtSearchSaleID.Name = "txtSearchSaleID";
            this.txtSearchSaleID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchSaleID.TabIndex = 9;
            // 
            // rbSearchSaleID
            // 
            this.rbSearchSaleID.AutoSize = true;
            this.rbSearchSaleID.Location = new System.Drawing.Point(8, 47);
            this.rbSearchSaleID.Name = "rbSearchSaleID";
            this.rbSearchSaleID.Size = new System.Drawing.Size(63, 17);
            this.rbSearchSaleID.TabIndex = 6;
            this.rbSearchSaleID.Text = "Sale ID:";
            this.rbSearchSaleID.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(8, 15);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(94, 17);
            this.rbShowAll.TabIndex = 7;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show all Sales";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // rbSearchProductID
            // 
            this.rbSearchProductID.AutoSize = true;
            this.rbSearchProductID.Location = new System.Drawing.Point(8, 79);
            this.rbSearchProductID.Name = "rbSearchProductID";
            this.rbSearchProductID.Size = new System.Drawing.Size(79, 17);
            this.rbSearchProductID.TabIndex = 8;
            this.rbSearchProductID.Text = "Product ID:";
            this.rbSearchProductID.UseVisualStyleBackColor = true;
            // 
            // btnAddSales
            // 
            this.btnAddSales.Location = new System.Drawing.Point(34, 46);
            this.btnAddSales.Name = "btnAddSales";
            this.btnAddSales.Size = new System.Drawing.Size(105, 23);
            this.btnAddSales.TabIndex = 0;
            this.btnAddSales.Text = "&Add Sales";
            this.btnAddSales.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSales
            // 
            this.btnDeleteSales.Location = new System.Drawing.Point(145, 46);
            this.btnDeleteSales.Name = "btnDeleteSales";
            this.btnDeleteSales.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteSales.TabIndex = 5;
            this.btnDeleteSales.Text = "&Delete Sales";
            this.btnDeleteSales.UseVisualStyleBackColor = true;
            this.btnDeleteSales.Click += new System.EventHandler(this.btnDeleteSales_Click);
            // 
            // btnSearchSales
            // 
            this.btnSearchSales.Location = new System.Drawing.Point(367, 46);
            this.btnSearchSales.Name = "btnSearchSales";
            this.btnSearchSales.Size = new System.Drawing.Size(105, 23);
            this.btnSearchSales.TabIndex = 3;
            this.btnSearchSales.Text = "&Search Sales";
            this.btnSearchSales.UseVisualStyleBackColor = true;
            this.btnSearchSales.Click += new System.EventHandler(this.btnSearchSales_Click);
            // 
            // btnUpdateSales
            // 
            this.btnUpdateSales.Location = new System.Drawing.Point(256, 46);
            this.btnUpdateSales.Name = "btnUpdateSales";
            this.btnUpdateSales.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateSales.TabIndex = 4;
            this.btnUpdateSales.Text = "&Update Sales";
            this.btnUpdateSales.UseVisualStyleBackColor = true;
            // 
            // dgvSales
            // 
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(934, 499);
            this.dgvSales.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "SaleID";
            this.Column1.HeaderText = "Sale ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "Customer ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductID";
            this.Column3.HeaderText = "Product ID";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Payable";
            this.Column4.HeaderText = "Payable";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "StartDate";
            this.Column5.HeaderText = "Start Date";
            this.Column5.Name = "Column5";
            // 
            // txtSearchProductID
            // 
            this.txtSearchProductID.Location = new System.Drawing.Point(109, 78);
            this.txtSearchProductID.Name = "txtSearchProductID";
            this.txtSearchProductID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchProductID.TabIndex = 10;
            // 
            // frmMainSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.panel1);
            this.Name = "frmMainSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Sales";
            this.Load += new System.EventHandler(this.frmMainSales_Load);
            this.panel1.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchSaleID;
        private System.Windows.Forms.RadioButton rbSearchSaleID;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbSearchProductID;
        private System.Windows.Forms.Button btnAddSales;
        private System.Windows.Forms.Button btnDeleteSales;
        private System.Windows.Forms.Button btnSearchSales;
        private System.Windows.Forms.Button btnUpdateSales;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.TextBox txtSearchProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}