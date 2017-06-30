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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddCustomers
            // 
            this.btnAddCustomers.Location = new System.Drawing.Point(34, 46);
            this.btnAddCustomers.Name = "btnAddCustomers";
            this.btnAddCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnAddCustomers.TabIndex = 0;
            this.btnAddCustomers.Text = "&Add Customers";
            this.btnAddCustomers.UseVisualStyleBackColor = true;
            this.btnAddCustomers.Click += new System.EventHandler(this.btnAddCustomers_Click);
            // 
            // btnSearchCustomers
            // 
            this.btnSearchCustomers.Location = new System.Drawing.Point(384, 46);
            this.btnSearchCustomers.Name = "btnSearchCustomers";
            this.btnSearchCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnSearchCustomers.TabIndex = 3;
            this.btnSearchCustomers.Text = "&Search Customers";
            this.btnSearchCustomers.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCustomers
            // 
            this.btnUpdateCustomers.Location = new System.Drawing.Point(273, 46);
            this.btnUpdateCustomers.Name = "btnUpdateCustomers";
            this.btnUpdateCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnUpdateCustomers.TabIndex = 4;
            this.btnUpdateCustomers.Text = "&Update Customers";
            this.btnUpdateCustomers.UseVisualStyleBackColor = true;
            this.btnUpdateCustomers.Click += new System.EventHandler(this.btnUpdateCustomers_Click);
            // 
            // btnDeleteCustomers
            // 
            this.btnDeleteCustomers.Location = new System.Drawing.Point(145, 46);
            this.btnDeleteCustomers.Name = "btnDeleteCustomers";
            this.btnDeleteCustomers.Size = new System.Drawing.Size(105, 23);
            this.btnDeleteCustomers.TabIndex = 5;
            this.btnDeleteCustomers.Text = "&Delete Customers";
            this.btnDeleteCustomers.UseVisualStyleBackColor = true;
            this.btnDeleteCustomers.Click += new System.EventHandler(this.btnDeleteCustomers_Click);
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
            this.lvCustomers.HideSelection = false;
            this.lvCustomers.Location = new System.Drawing.Point(53, 66);
            this.lvCustomers.Name = "lvCustomers";
            this.lvCustomers.Size = new System.Drawing.Size(805, 73);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddCustomers);
            this.panel1.Controls.Add(this.btnDeleteCustomers);
            this.panel1.Controls.Add(this.btnSearchCustomers);
            this.panel1.Controls.Add(this.btnUpdateCustomers);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 499);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 112);
            this.panel1.TabIndex = 7;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowTemplate.ReadOnly = true;
            this.dgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCustomers.Size = new System.Drawing.Size(934, 499);
            this.dgvCustomers.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CustomerID";
            this.Column1.HeaderText = "Customer ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CategoryID";
            this.Column2.HeaderText = "Category ID";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "FirstName";
            this.Column3.HeaderText = "First Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "LastName";
            this.Column4.HeaderText = "Last Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Address";
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Suburb";
            this.Column6.HeaderText = "Suburb";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "State";
            this.Column7.HeaderText = "State";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Postcode";
            this.Column8.HeaderText = "Postcode";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Gender";
            this.Column9.HeaderText = "Gender";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "BirthDate";
            this.Column10.HeaderText = "Birth Date";
            this.Column10.Name = "Column10";
            // 
            // frmCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.dgvCustomers);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lvCustomers);
            this.Name = "frmCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customers";
            this.Load += new System.EventHandler(this.frmCustomers_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}

