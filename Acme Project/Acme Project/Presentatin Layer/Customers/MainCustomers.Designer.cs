namespace Acme_Project
{
    partial class frmCustomers
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
            this.btnAddCustomers = new System.Windows.Forms.Button();
            this.btnSearchCustomers = new System.Windows.Forms.Button();
            this.btnUpdateCustomers = new System.Windows.Forms.Button();
            this.btnDeleteCustomers = new System.Windows.Forms.Button();
            this.lvCustomers = new System.Windows.Forms.ListView();
            this.customerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoryID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.suburb = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.state = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.postcode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(53, 543);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnAddCustomers.TabIndex = 0;
            this.btnAddCustomers.Text = "&Add Customers";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Location = new System.Drawing.Point(491, 543);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnSearchCustomers.TabIndex = 3;
            this.btnSearchCustomers.Text = "&Search Customers";
            this.btnSearchCustomers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomers
            // 
            this.btnUpdateCustomers.Location = new System.Drawing.Point(345, 543);
            this.btnUpdateCustomers.Name = "btnUpdateCustomers";
            this.btnUpdateCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateCustomers.TabIndex = 4;
            this.btnUpdateCustomers.Text = "&Update Customers";
            this.btnUpdateCustomers.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Location = new System.Drawing.Point(199, 543);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteCustomers.TabIndex = 5;
            this.btnDeleteCustomers.Text = "&Delete Customers";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            // 
            // lvCustomers
            // 
            this.lvCustomers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerID,
            this.categoryID,
            this.firstName,
            this.lastName,
            this.address,
            this.suburb,
            this.state,
            this.postcode,
            this.gender,
            this.birthDate});
            this.lvCustomers.FullRowSelect = true;
            this.lvCustomers.GridLines = true;
            this.lvCustomers.Location = new System.Drawing.Point(53, 66);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(802, 413);
            this.lvCustomers.TabIndex = 6;
            this.lvCustomers.UseCompatibleStateImageBehavior = false;
            this.lvCustomers.View = System.Windows.Forms.View.Details;
            // 
            // customerID
            // 
            this.customerID.Text = "Customer ID";
            this.customerID.Width = 80;
            // 
            // categoryID
            // 
            this.categoryID.Text = "Category ID";
            this.categoryID.Width = 80;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 80;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 80;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 80;
            // 
            // suburb
            // 
            this.suburb.Text = "Suburb";
            this.suburb.Width = 80;
            // 
            // state
            // 
            this.state.Text = "State";
            this.state.Width = 80;
            // 
            // postcode
            // 
            this.postcode.Text = "Postcode";
            this.postcode.Width = 80;
            // 
            // gender
            // 
            this.gender.Text = "Gender";
            this.gender.Width = 80;
            // 
            // birthDate
            // 
            this.birthDate.Text = "Birth Date";
            this.birthDate.Width = 80;
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.lvCustomers);
            this.Controls.Add(this.btnDeleteCustomers);
            this.Controls.Add(this.btnUpdateCustomers);
            this.Controls.Add(this.btnSearchCustomers);
            this.Controls.Add(this.btnAddCustomers);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddCustomers;
        private System.Windows.Forms.Button btnSearchCustomers;
        private System.Windows.Forms.Button btnUpdateCustomers;
        private System.Windows.Forms.Button btnDeleteCustomers;
        private System.Windows.Forms.ListView lvCustomers;
        private System.Windows.Forms.ColumnHeader customerID;
        private System.Windows.Forms.ColumnHeader categoryID;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader suburb;
        private System.Windows.Forms.ColumnHeader state;
        private System.Windows.Forms.ColumnHeader postcode;
        private System.Windows.Forms.ColumnHeader gender;
        private System.Windows.Forms.ColumnHeader birthDate;
    }
}

