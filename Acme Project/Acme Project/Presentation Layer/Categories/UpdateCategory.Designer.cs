namespace Acme_Project.Categories
{
    partial class frmUpdateCategory
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
            this.btnUpdateCategories = new System.Windows.Forms.Button();
            this.grpUpdateCategory = new System.Windows.Forms.GroupBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtCategoryID = new System.Windows.Forms.TextBox();
            this.lblCategoryID = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlUpdateCategory = new System.Windows.Forms.Panel();
            this.grpUpdateCategory.SuspendLayout();
            this.pnlUpdateCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCategories
            // 
            this.btnUpdateCategories.Location = new System.Drawing.Point(144, 42);
            this.btnUpdateCategories.Name = "btnUpdateCategories";
            this.btnUpdateCategories.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateCategories.TabIndex = 0;
            this.btnUpdateCategories.Text = "Update Category";
            this.btnUpdateCategories.UseVisualStyleBackColor = true;
            this.btnUpdateCategories.Click += new System.EventHandler(this.btnUpdateCategories_Click);
            // 
            // grpUpdateCategory
            // 
            this.grpUpdateCategory.Controls.Add(this.txtCategory);
            this.grpUpdateCategory.Controls.Add(this.txtCategoryID);
            this.grpUpdateCategory.Controls.Add(this.lblCategoryID);
            this.grpUpdateCategory.Controls.Add(this.lblCategory);
            this.grpUpdateCategory.Location = new System.Drawing.Point(144, 228);
            this.grpUpdateCategory.Name = "grpUpdateCategory";
            this.grpUpdateCategory.Size = new System.Drawing.Size(378, 126);
            this.grpUpdateCategory.TabIndex = 8;
            this.grpUpdateCategory.TabStop = false;
            this.grpUpdateCategory.Text = "Update Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(117, 73);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(167, 20);
            this.txtCategory.TabIndex = 0;
            // 
            // txtCategoryID
            // 
            this.txtCategoryID.Location = new System.Drawing.Point(117, 27);
            this.txtCategoryID.Name = "txtCategoryID";
            this.txtCategoryID.ReadOnly = true;
            this.txtCategoryID.Size = new System.Drawing.Size(167, 20);
            this.txtCategoryID.TabIndex = 1;
            this.txtCategoryID.TabStop = false;
            // 
            // lblCategoryID
            // 
            this.lblCategoryID.AutoSize = true;
            this.lblCategoryID.Location = new System.Drawing.Point(19, 30);
            this.lblCategoryID.Name = "lblCategoryID";
            this.lblCategoryID.Size = new System.Drawing.Size(66, 13);
            this.lblCategoryID.TabIndex = 0;
            this.lblCategoryID.Text = "Category ID:";
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
            // pnlUpdateCategory
            // 
            this.pnlUpdateCategory.Controls.Add(this.btnUpdateCategories);
            this.pnlUpdateCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateCategory.Location = new System.Drawing.Point(0, 511);
            this.pnlUpdateCategory.Name = "pnlUpdateCategory";
            this.pnlUpdateCategory.Size = new System.Drawing.Size(934, 100);
            this.pnlUpdateCategory.TabIndex = 12;
            // 
            // frmUpdateCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlUpdateCategory);
            this.Controls.Add(this.grpUpdateCategory);
            this.Name = "frmUpdateCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Category";
            this.grpUpdateCategory.ResumeLayout(false);
            this.grpUpdateCategory.PerformLayout();
            this.pnlUpdateCategory.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCategories;
        private System.Windows.Forms.GroupBox grpUpdateCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtCategoryID;
        private System.Windows.Forms.Label lblCategoryID;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Panel pnlUpdateCategory;
    }
}