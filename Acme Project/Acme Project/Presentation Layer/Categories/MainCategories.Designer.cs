namespace Acme_Project.Categories
{
    partial class frmMainCategories
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
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.btnDeleteCategories = new System.Windows.Forms.Button();
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.CategoryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.txtSearchCategory = new System.Windows.Forms.TextBox();
            this.txtSearchCategoryID = new System.Windows.Forms.TextBox();
            this.rbSearchCategoryID = new System.Windows.Forms.RadioButton();
            this.rbShowAll = new System.Windows.Forms.RadioButton();
            this.rbSearchCategory = new System.Windows.Forms.RadioButton();
            this.btnSearchCategories = new System.Windows.Forms.Button();
            this.pnlCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCategories
            // 
            this.pnlCategories.Controls.Add(this.grpSearch);
            this.pnlCategories.Controls.Add(this.btnSearchCategories);
            this.pnlCategories.Controls.Add(this.btnAddCategories);
            this.pnlCategories.Controls.Add(this.btnDeleteCategories);
            this.pnlCategories.Controls.Add(this.btnUpdateCategories);
            this.pnlCategories.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlCategories.Location = new System.Drawing.Point(0, 499);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(934, 112);
            this.pnlCategories.TabIndex = 9;
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.Location = new System.Drawing.Point(34, 46);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(105, 23);
            this.btnAddCategories.TabIndex = 0;
            this.btnAddCategories.Text = "Add Category";
            this.btnAddCategories.UseVisualStyleBackColor = true;
            this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click);
            // 
            // btnDeleteCategories
            // 
            this.btnDeleteCategories.Location = new System.Drawing.Point(145, 46);
            this.btnDeleteCategories.Name = "btnDeleteCategories";
            this.btnDeleteCategories.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteCategories.TabIndex = 5;
            this.btnDeleteCategories.Text = "Delete Category";
            this.btnDeleteCategories.UseVisualStyleBackColor = true;
            this.btnDeleteCategories.Click += new System.EventHandler(this.btnDeleteCategories_Click);
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.Location = new System.Drawing.Point(256, 46);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateCategories.TabIndex = 4;
            this.btnUpdateCategories.Text = "Update Category";
            this.btnUpdateCategories.UseVisualStyleBackColor = true;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CategoryID,
            this.Category});
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 0);
            this.dgvCategories.MultiSelect = false;
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategories.Size = new System.Drawing.Size(934, 499);
            this.dgvCategories.TabIndex = 10;
            // 
            // CategoryID
            // 
            this.CategoryID.DataPropertyName = "CategoryID";
            this.CategoryID.HeaderText = "Category ID";
            this.CategoryID.Name = "CategoryID";
            this.CategoryID.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.DataPropertyName = "Category";
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.txtSearchCategory);
            this.grpSearch.Controls.Add(this.txtSearchCategoryID);
            this.grpSearch.Controls.Add(this.rbSearchCategoryID);
            this.grpSearch.Controls.Add(this.rbShowAll);
            this.grpSearch.Controls.Add(this.rbSearchCategory);
            this.grpSearch.Location = new System.Drawing.Point(478, 3);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(219, 106);
            this.grpSearch.TabIndex = 13;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search Parameters";
            // 
            // txtSearchCategory
            // 
            this.txtSearchCategory.Location = new System.Drawing.Point(109, 78);
            this.txtSearchCategory.Name = "txtSearchCategory";
            this.txtSearchCategory.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCategory.TabIndex = 10;
            // 
            // txtSearchCategoryID
            // 
            this.txtSearchCategoryID.Location = new System.Drawing.Point(109, 46);
            this.txtSearchCategoryID.Name = "txtSearchCategoryID";
            this.txtSearchCategoryID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchCategoryID.TabIndex = 9;
            // 
            // rbSearchCategoryID
            // 
            this.rbSearchCategoryID.AutoSize = true;
            this.rbSearchCategoryID.Location = new System.Drawing.Point(8, 47);
            this.rbSearchCategoryID.Name = "rbSearchCategoryID";
            this.rbSearchCategoryID.Size = new System.Drawing.Size(84, 17);
            this.rbSearchCategoryID.TabIndex = 6;
            this.rbSearchCategoryID.Text = "Category ID:";
            this.rbSearchCategoryID.UseVisualStyleBackColor = true;
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
            // rbSearchCategory
            // 
            this.rbSearchCategory.AutoSize = true;
            this.rbSearchCategory.Location = new System.Drawing.Point(8, 79);
            this.rbSearchCategory.Name = "rbSearchCategory";
            this.rbSearchCategory.Size = new System.Drawing.Size(84, 17);
            this.rbSearchCategory.TabIndex = 8;
            this.rbSearchCategory.Text = "Category ID:";
            this.rbSearchCategory.UseVisualStyleBackColor = true;
            // 
            // btnSearchCategories
            // 
            this.btnSearchCategories.Location = new System.Drawing.Point(367, 46);
            this.btnSearchCategories.Name = "btnSearchCategories";
            this.btnSearchCategories.Size = new System.Drawing.Size(105, 23);
            this.btnSearchCategories.TabIndex = 12;
            this.btnSearchCategories.Text = "&Search Sales";
            this.btnSearchCategories.UseVisualStyleBackColor = true;
            this.btnSearchCategories.Click += new System.EventHandler(this.btnSearchCategories_Click);
            // 
            // frmMainCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgvCategories);
            this.Controls.Add(this.pnlCategories);
            this.Name = "frmMainCategories";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.frmMainCategories_Load);
            this.pnlCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Button btnDeleteCategories;
        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchCategory;
        private System.Windows.Forms.TextBox txtSearchCategoryID;
        private System.Windows.Forms.RadioButton rbSearchCategoryID;
        private System.Windows.Forms.RadioButton rbShowAll;
        private System.Windows.Forms.RadioButton rbSearchCategory;
        private System.Windows.Forms.Button btnSearchCategories;
    }
}