namespace Acme_Project.Categories
{
    partial class frmAddCategory
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
            this.grpAddCategory = new System.Windows.Forms.GroupBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.btnAddCategories = new System.Windows.Forms.Button();
            this.pnlAddCategory = new System.Windows.Forms.Panel();
            this.grpAddCategory.SuspendLayout();
            this.pnlAddCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpAddCategory
            // 
            this.grpAddCategory.Controls.Add(this.txtCategory);
            this.grpAddCategory.Controls.Add(this.txtCategoryID);
            this.grpAddCategory.Controls.Add(this.lblCategoryID);
            this.grpAddCategory.Controls.Add(this.lblCategory);
            this.grpAddCategory.Location = new System.Drawing.Point(104, 228);
            this.grpAddCategory.Name = "grpAddCategory";
            this.grpAddCategory.Size = new System.Drawing.Size(378, 126);
            this.grpAddCategory.TabIndex = 6;
            this.grpAddCategory.TabStop = false;
            this.grpAddCategory.Text = "Add Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(117, 73);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(167, 20);
            this.txtCategory.TabIndex = 1;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(117, 27);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.Size = new System.Drawing.Size(167, 20);
            this.txtCategoryID.TabIndex = 0;
            this.txtCategoryID.Visible = false;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(19, 30);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(66, 13);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID:";
            this.lblCategoryID.Visible = false;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(19, 76);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category:";
            // 
            // btnAddCategories
            // 
            this.btnAddCategories.Location = new System.Drawing.Point(104, 42);
            this.btnAddCategories.Name = "btnAddCategories";
            this.btnAddCategories.Size = new System.Drawing.Size(105, 23);
            this.btnAddCategories.TabIndex = 0;
            this.btnAddCategories.Text = "Add Category";
            this.btnAddCategories.UseVisualStyleBackColor = true;
            this.btnAddCategories.Click += new System.EventHandler(this.btnAddCategories_Click_1);
            // 
            // pnlAddCategory
            // 
            this.pnlAddCategory.Controls.Add(this.btnAddCategories);
            this.pnlAddCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddCategory.Location = new System.Drawing.Point(0, 511);
            this.pnlAddCategory.Name = "pnlAddCategory";
            this.pnlAddCategory.Size = new System.Drawing.Size(934, 100);
            this.pnlAddCategory.TabIndex = 12;
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlAddCategory);
            this.Controls.Add(this.grpAddCategory);
            this.Name = "frmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Category";
            this.grpAddCategory.ResumeLayout(false);
            this.grpAddCategory.PerformLayout();
            this.pnlAddCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnAddCategories;
        private System.Windows.Forms.Panel pnlAddCategory;
    }
}