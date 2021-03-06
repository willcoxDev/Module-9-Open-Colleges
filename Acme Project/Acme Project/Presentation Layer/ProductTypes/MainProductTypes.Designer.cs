﻿namespace Acme_Project.Presentation_Layer.ProductTypes
{
    partial class frmMainProductTypes
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
            this.dgvProductType = new System.Windows.Forms.DataGridView();
            this.ProductTypeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchProductType = new System.Windows.Forms.TextBox();
            this.txtSearchProductTypeID = new System.Windows.Forms.TextBox();
            this.rbSearchProductTypeID = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbSearchProductType = new System.Windows.Forms.RadioButton();
            this.btnSearchProductType = new System.Windows.Forms.Button();
            this.btnAddProductType = new System.Windows.Forms.Button();
            this.btnDeleteProductType = new System.Windows.Forms.Button();
            this.btnUpdateProductType = new System.Windows.Forms.Button();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productTypesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).BeginInit();
            this.pnlCategories.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvProductType
            // 
            this.dgvProductType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductTypeID,
            this.ProductType});
            this.dgvProductType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProductType.Location = new System.Drawing.Point(0, 24);
            this.dgvProductType.MultiSelect = false;
            this.dgvProductType.Name = "dgvProductType";
            this.dgvProductType.ReadOnly = true;
            this.dgvProductType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductType.Size = new System.Drawing.Size(934, 475);
            this.dgvProductType.TabIndex = 12;
            this.dgvProductType.TabStop = false;
            // 
            // ProductTypeID
            // 
            this.ProductTypeID.DataPropertyName = "ProductTypeID";
            this.ProductTypeID.HeaderText = "Product Type ID";
            this.ProductTypeID.Name = "ProductTypeID";
            this.ProductTypeID.ReadOnly = true;
            // 
            // ProductType
            // 
            this.ProductType.DataPropertyName = "ProductType";
            this.ProductType.HeaderText = "Product Type";
            this.ProductType.Name = "ProductType";
            this.ProductType.ReadOnly = true;
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.grpSearch);
            this.pnlCategories.Controls.Add(this.btnSearchProductType);
            this.pnlCategories.Controls.Add(this.btnAddProductType);
            this.pnlCategories.Controls.Add(this.btnDeleteProductType);
            this.pnlCategories.Controls.Add(this.btnUpdateProductType);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCategories.Location = new System.Drawing.Point(0, 499);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(934, 112);
            this.pnlCategories.TabIndex = 11;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearchProductType);
            this.grpSearch.Controls.Add(this.txtSearchProductTypeID);
            this.grpSearch.Controls.Add(this.rbSearchProductTypeID);
            this.grpSearch.Controls.Add(this.rbShowAll);
            this.grpSearch.Controls.Add(this.rbSearchProductType);
            this.grpSearch.Location = new System.Drawing.Point(478, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(219, 106);
            this.grpSearch.TabIndex = 13;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Parameters";
            // 
            // txtSearchProductType
            // 
            this.txtSearchProductType.Location = new System.Drawing.Point(109, 78);
            this.txtSearchProductType.Name = "txtSearchProductType";
            this.txtSearchProductType.Size = new System.Drawing.Size(100, 20);
            this.txtSearchProductType.TabIndex = 1;
            // 
            // txtSearchProductTypeID
            // 
            this.txtSearchProductTypeID.Location = new System.Drawing.Point(109, 46);
            this.txtSearchProductTypeID.Name = "txtSearchProductTypeID";
            this.txtSearchProductTypeID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchProductTypeID.TabIndex = 0;
            // 
            // rbSearchProductTypeID
            // 
            this.rbSearchProductTypeID.AutoSize = true;
            this.rbSearchProductTypeID.Location = new System.Drawing.Point(8, 47);
            this.rbSearchProductTypeID.Name = "rbSearchProductTypeID";
            this.rbSearchProductTypeID.Size = new System.Drawing.Size(106, 17);
            this.rbSearchProductTypeID.TabIndex = 6;
            this.rbSearchProductTypeID.Text = "Product Type ID:";
            this.rbSearchProductTypeID.UseVisualStyleBackColor = true;
            // 
            // rbShowAll
            // 
            this.rbShowAll.AutoSize = true;
            this.rbShowAll.Checked = true;
            this.rbShowAll.Location = new System.Drawing.Point(8, 15);
            this.rbShowAll.Name = "rbShowAll";
            this.rbShowAll.Size = new System.Drawing.Size(140, 17);
            this.rbShowAll.TabIndex = 7;
            this.rbShowAll.TabStop = true;
            this.rbShowAll.Text = "Show all Product Types:";
            this.rbShowAll.UseVisualStyleBackColor = true;
            // 
            // rbSearchProductType
            // 
            this.rbSearchProductType.AutoSize = true;
            this.rbSearchProductType.Location = new System.Drawing.Point(8, 79);
            this.rbSearchProductType.Name = "rbSearchProductType";
            this.rbSearchProductType.Size = new System.Drawing.Size(92, 17);
            this.rbSearchProductType.TabIndex = 8;
            this.rbSearchProductType.Text = "Product Type:";
            this.rbSearchProductType.UseVisualStyleBackColor = true;
            // 
            // btnSearchProductType
            // 
            this.btnSearchProductType.Location = new System.Drawing.Point(367, 46);
            this.btnSearchProductType.Name = "btnSearchProductType";
            this.btnSearchProductType.Size = new System.Drawing.Size(105, 36);
            this.btnSearchProductType.TabIndex = 3;
            this.btnSearchProductType.Text = "&Search Product Type";
            this.btnSearchProductType.UseVisualStyleBackColor = true;
            this.btnSearchProductType.Click += new System.EventHandler(this.btnSearchProductType_Click);
            // 
            // btnAddProductType
            // 
            this.btnAddProductType.Location = new System.Drawing.Point(34, 46);
            this.btnAddProductType.Name = "btnAddProductType";
            this.btnAddProductType.Size = new System.Drawing.Size(105, 36);
            this.btnAddProductType.TabIndex = 0;
            this.btnAddProductType.Text = "Add Product Type";
            this.btnAddProductType.UseVisualStyleBackColor = true;
            this.btnAddProductType.Click += new System.EventHandler(this.btnAddProductType_Click);
            // 
            // btnDeleteProductType
            // 
            this.btnDeleteProductType.Location = new System.Drawing.Point(145, 46);
            this.btnDeleteProductType.Name = "btnDeleteProductType";
            this.btnDeleteProductType.Size = new System.Drawing.Size(105, 36);
            this.btnDeleteProductType.TabIndex = 1;
            this.btnDeleteProductType.Text = "Delete Product Type";
            this.btnDeleteProductType.UseVisualStyleBackColor = true;
            this.btnDeleteProductType.Click += new System.EventHandler(this.btnDeleteProductType_Click);
            // 
            // btnUpdateProductType
            // 
            this.btnUpdateProductType.Location = new System.Drawing.Point(256, 46);
            this.btnUpdateProductType.Name = "btnUpdateProductType";
            this.btnUpdateProductType.Size = new System.Drawing.Size(105, 36);
            this.btnUpdateProductType.TabIndex = 2;
            this.btnUpdateProductType.Text = "Update Product Type";
            this.btnUpdateProductType.UseVisualStyleBackColor = true;
            this.btnUpdateProductType.Click += new System.EventHandler(this.btnUpdateProductType_Click);
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(934, 24);
            this.menuBar.TabIndex = 13;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.productTypesToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.categoriesToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // productTypesToolStripMenuItem
            // 
            this.productTypesToolStripMenuItem.Name = "productTypesToolStripMenuItem";
            this.productTypesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.productTypesToolStripMenuItem.Text = "Product Types";
            this.productTypesToolStripMenuItem.Click += new System.EventHandler(this.productTypesToolStripMenuItem_Click);
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.salesToolStripMenuItem.Text = "Sales";
            this.salesToolStripMenuItem.Click += new System.EventHandler(this.salesToolStripMenuItem_Click);
            // 
            // categoriesToolStripMenuItem
            // 
            this.categoriesToolStripMenuItem.Name = "categoriesToolStripMenuItem";
            this.categoriesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.categoriesToolStripMenuItem.Text = "Categories";
            this.categoriesToolStripMenuItem.Click += new System.EventHandler(this.categoriesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitToolStripMenuItem.Text = "Exit Application";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorialToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // tutorialToolStripMenuItem
            // 
            this.tutorialToolStripMenuItem.Name = "tutorialToolStripMenuItem";
            this.tutorialToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.tutorialToolStripMenuItem.Text = "Tutorial";
            this.tutorialToolStripMenuItem.Click += new System.EventHandler(this.tutorialToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // frmMainProductTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgvProductType);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.pnlCategories);
            this.Name = "frmMainProductTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Product Types";
            this.Load += new System.EventHandler(this.frmMainProductTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductType)).EndInit();
            this.pnlCategories.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTypeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductType;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchProductType;
        private System.Windows.Forms.TextBox txtSearchProductTypeID;
        private System.Windows.Forms.RadioButton rbSearchProductTypeID;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbSearchProductType;
        private System.Windows.Forms.Button btnSearchProductType;
        private System.Windows.Forms.Button btnAddProductType;
        private System.Windows.Forms.Button btnDeleteProductType;
        private System.Windows.Forms.Button btnUpdateProductType;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productTypesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}