namespace Acme_Project.Presentation_Layer.ProductTypes
{
    partial class frmAddProductTypes
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
            this.btnAddProductTypes = new System.Windows.Forms.Button();
            this.grpAddProductType = new System.Windows.Forms.GroupBox();
            this.txtProductType = new System.Windows.Forms.TextBox();
            this.txtProductTypeID = new System.Windows.Forms.TextBox();
            this.lblProductTypeID = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.pnlAddProductTypes = new System.Windows.Forms.Panel();
            this.grpAddProductType.SuspendLayout();
            this.pnlAddProductTypes.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddProductTypes
            // 
            this.btnAddProductTypes.Location = new System.Drawing.Point(107, 38);
            this.btnAddProductTypes.Name = "btnAddProductTypes";
            this.btnAddProductTypes.Size = new System.Drawing.Size(105, 32);
            this.btnAddProductTypes.TabIndex = 0;
            this.btnAddProductTypes.Text = "Add Product Type";
            this.btnAddProductTypes.UseVisualStyleBackColor = true;
            this.btnAddProductTypes.Click += new System.EventHandler(this.btnAddProductTypes_Click);
            // 
            // grpAddProductType
            // 
            this.grpAddProductType.Controls.Add(this.txtProductType);
            this.grpAddProductType.Controls.Add(this.txtProductTypeID);
            this.grpAddProductType.Controls.Add(this.lblProductTypeID);
            this.grpAddProductType.Controls.Add(this.lblProductType);
            this.grpAddProductType.Location = new System.Drawing.Point(107, 228);
            this.grpAddProductType.Name = "grpAddProductType";
            this.grpAddProductType.Size = new System.Drawing.Size(378, 135);
            this.grpAddProductType.TabIndex = 8;
            this.grpAddProductType.TabStop = false;
            this.grpAddProductType.Text = "Add Product Type";
            // 
            // txtProductType
            // 
            this.txtProductType.Location = new System.Drawing.Point(117, 73);
            this.txtProductType.Name = "txtProductType";
            this.txtProductType.Size = new System.Drawing.Size(167, 20);
            this.txtProductType.TabIndex = 1;
            // 
            // txtProductTypeID
            // 
            this.txtProductTypeID.Location = new System.Drawing.Point(117, 27);
            this.txtProductTypeID.Name = "txtProductTypeID";
            this.txtProductTypeID.Size = new System.Drawing.Size(167, 20);
            this.txtProductTypeID.TabIndex = 0;
            this.txtProductTypeID.Visible = false;
            // 
            // lblProductTypeID
            // 
            this.lblProductTypeID.AutoSize = true;
            this.lblProductTypeID.Location = new System.Drawing.Point(19, 30);
            this.lblProductTypeID.Name = "lblProductTypeID";
            this.lblProductTypeID.Size = new System.Drawing.Size(88, 13);
            this.lblProductTypeID.TabIndex = 0;
            this.lblProductTypeID.Text = "Product Type ID:";
            this.lblProductTypeID.Visible = false;
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
            // pnlAddProductTypes
            // 
            this.pnlAddProductTypes.Controls.Add(this.btnAddProductTypes);
            this.pnlAddProductTypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlAddProductTypes.Location = new System.Drawing.Point(0, 511);
            this.pnlAddProductTypes.Name = "pnlAddProductTypes";
            this.pnlAddProductTypes.Size = new System.Drawing.Size(934, 100);
            this.pnlAddProductTypes.TabIndex = 12;
            // 
            // frmAddProductTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.pnlAddProductTypes);
            this.Controls.Add(this.grpAddProductType);
            this.Name = "frmAddProductTypes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product Types";
            this.grpAddProductType.ResumeLayout(false);
            this.grpAddProductType.PerformLayout();
            this.pnlAddProductTypes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddProductTypes;
        private System.Windows.Forms.GroupBox grpAddProductType;
        private System.Windows.Forms.TextBox txtProductType;
        private System.Windows.Forms.TextBox txtProductTypeID;
        private System.Windows.Forms.Label lblProductTypeID;
        private System.Windows.Forms.Label lblProductType;
        private System.Windows.Forms.Panel pnlAddProductTypes;
    }
}