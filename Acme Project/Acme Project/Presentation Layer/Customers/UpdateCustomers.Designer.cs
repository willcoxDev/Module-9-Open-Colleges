namespace Acme_Project.Customers
{
    partial class frmUpdateCustomers
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
            this.btnUpdateCustomer = new System.Windows.Forms.Button();
            this.grpUpdateCustomerOfficeUseOnly = new System.Windows.Forms.GroupBox();
            this.lblCustomerID = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.grpUpdateCustomerAddress = new System.Windows.Forms.GroupBox();
            this.cbState = new System.Windows.Forms.ComboBox();
            this.txtPostcode = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSuburb = new System.Windows.Forms.Label();
            this.txtSuburb = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPostcode = new System.Windows.Forms.Label();
            this.grpUpdateCustomerDetails = new System.Windows.Forms.GroupBox();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbCategoryID = new System.Windows.Forms.ComboBox();
            this.dtBirthDate = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblBirthDate = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlUpdateCustomer = new System.Windows.Forms.Panel();
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
            this.grpUpdateCustomerOfficeUseOnly.SuspendLayout();
            this.grpUpdateCustomerAddress.SuspendLayout();
            this.grpUpdateCustomerDetails.SuspendLayout();
            this.pnlUpdateCustomer.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateCustomer
            // 
            this.btnUpdateCustomer.Location = new System.Drawing.Point(79, 43);
            this.btnUpdateCustomer.Name = "btnUpdateCustomer";
            this.btnUpdateCustomer.Size = new System.Drawing.Size(127, 23);
            this.btnUpdateCustomer.TabIndex = 0;
            this.btnUpdateCustomer.Text = "Update Customer";
            this.btnUpdateCustomer.UseVisualStyleBackColor = true;
            this.btnUpdateCustomer.Click += new System.EventHandler(this.btnUpdateCustomer_Click);
            // 
            // grpUpdateCustomerOfficeUseOnly
            // 
            this.grpUpdateCustomerOfficeUseOnly.Controls.Add(this.lblCustomerID);
            this.grpUpdateCustomerOfficeUseOnly.Controls.Add(this.txtCustomerID);
            this.grpUpdateCustomerOfficeUseOnly.Location = new System.Drawing.Point(496, 118);
            this.grpUpdateCustomerOfficeUseOnly.Name = "grpUpdateCustomerOfficeUseOnly";
            this.grpUpdateCustomerOfficeUseOnly.Size = new System.Drawing.Size(360, 66);
            this.grpUpdateCustomerOfficeUseOnly.TabIndex = 22;
            this.grpUpdateCustomerOfficeUseOnly.TabStop = false;
            this.grpUpdateCustomerOfficeUseOnly.Text = "Office Use Only";
            // 
            // lblCustomerID
            // 
            this.lblCustomerID.AutoSize = true;
            this.lblCustomerID.Location = new System.Drawing.Point(28, 27);
            this.lblCustomerID.Name = "lblCustomerID";
            this.lblCustomerID.Size = new System.Drawing.Size(68, 13);
            this.lblCustomerID.TabIndex = 10;
            this.lblCustomerID.Text = "Customer ID:";
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Location = new System.Drawing.Point(118, 24);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txtCustomerID.TabIndex = 0;
            // 
            // grpUpdateCustomerAddress
            // 
            this.grpUpdateCustomerAddress.Controls.Add(this.cbState);
            this.grpUpdateCustomerAddress.Controls.Add(this.txtPostcode);
            this.grpUpdateCustomerAddress.Controls.Add(this.lblAddress);
            this.grpUpdateCustomerAddress.Controls.Add(this.lblSuburb);
            this.grpUpdateCustomerAddress.Controls.Add(this.txtSuburb);
            this.grpUpdateCustomerAddress.Controls.Add(this.lblState);
            this.grpUpdateCustomerAddress.Controls.Add(this.txtAddress);
            this.grpUpdateCustomerAddress.Controls.Add(this.lblPostcode);
            this.grpUpdateCustomerAddress.Location = new System.Drawing.Point(79, 361);
            this.grpUpdateCustomerAddress.Name = "grpUpdateCustomerAddress";
            this.grpUpdateCustomerAddress.Size = new System.Drawing.Size(370, 132);
            this.grpUpdateCustomerAddress.TabIndex = 21;
            this.grpUpdateCustomerAddress.TabStop = false;
            this.grpUpdateCustomerAddress.Text = "Customer Address";
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
            this.cbState.Location = new System.Drawing.Point(120, 76);
            this.cbState.Name = "cbState";
            this.cbState.Size = new System.Drawing.Size(100, 21);
            this.cbState.TabIndex = 2;
            // 
            // txtPostcode
            // 
            this.txtPostcode.Location = new System.Drawing.Point(120, 102);
            this.txtPostcode.Name = "txtPostcode";
            this.txtPostcode.Size = new System.Drawing.Size(100, 20);
            this.txtPostcode.TabIndex = 3;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(28, 27);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 10;
            this.lblAddress.Text = "Address:";
            // 
            // lblSuburb
            // 
            this.lblSuburb.AutoSize = true;
            this.lblSuburb.Location = new System.Drawing.Point(28, 53);
            this.lblSuburb.Name = "lblSuburb";
            this.lblSuburb.Size = new System.Drawing.Size(47, 13);
            this.lblSuburb.TabIndex = 11;
            this.lblSuburb.Text = "Surburb:";
            // 
            // txtSuburb
            // 
            this.txtSuburb.Location = new System.Drawing.Point(120, 50);
            this.txtSuburb.Name = "txtSuburb";
            this.txtSuburb.Size = new System.Drawing.Size(100, 20);
            this.txtSuburb.TabIndex = 1;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Location = new System.Drawing.Point(29, 79);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(35, 13);
            this.lblState.TabIndex = 12;
            this.lblState.Text = "State:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(120, 24);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 20);
            this.txtAddress.TabIndex = 0;
            // 
            // lblPostcode
            // 
            this.lblPostcode.AutoSize = true;
            this.lblPostcode.Location = new System.Drawing.Point(28, 105);
            this.lblPostcode.Name = "lblPostcode";
            this.lblPostcode.Size = new System.Drawing.Size(55, 13);
            this.lblPostcode.TabIndex = 13;
            this.lblPostcode.Text = "Postcode:";
            // 
            // grpUpdateCustomerDetails
            // 
            this.grpUpdateCustomerDetails.Controls.Add(this.rbFemale);
            this.grpUpdateCustomerDetails.Controls.Add(this.rbMale);
            this.grpUpdateCustomerDetails.Controls.Add(this.cbCategoryID);
            this.grpUpdateCustomerDetails.Controls.Add(this.dtBirthDate);
            this.grpUpdateCustomerDetails.Controls.Add(this.txtLastName);
            this.grpUpdateCustomerDetails.Controls.Add(this.txtFirstName);
            this.grpUpdateCustomerDetails.Controls.Add(this.lblBirthDate);
            this.grpUpdateCustomerDetails.Controls.Add(this.lblCategory);
            this.grpUpdateCustomerDetails.Controls.Add(this.lblGender);
            this.grpUpdateCustomerDetails.Controls.Add(this.lblLastName);
            this.grpUpdateCustomerDetails.Controls.Add(this.lblFirstName);
            this.grpUpdateCustomerDetails.Location = new System.Drawing.Point(79, 118);
            this.grpUpdateCustomerDetails.Name = "grpUpdateCustomerDetails";
            this.grpUpdateCustomerDetails.Size = new System.Drawing.Size(370, 166);
            this.grpUpdateCustomerDetails.TabIndex = 20;
            this.grpUpdateCustomerDetails.TabStop = false;
            this.grpUpdateCustomerDetails.Text = "Customer Details";
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(163, 77);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(109, 77);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbCategoryID
            // 
            this.cbCategoryID.FormattingEnabled = true;
            this.cbCategoryID.Location = new System.Drawing.Point(109, 102);
            this.cbCategoryID.Name = "cbCategoryID";
            this.cbCategoryID.Size = new System.Drawing.Size(121, 21);
            this.cbCategoryID.TabIndex = 4;
            // 
            // dtBirthDate
            // 
            this.dtBirthDate.Location = new System.Drawing.Point(109, 128);
            this.dtBirthDate.Name = "dtBirthDate";
            this.dtBirthDate.Size = new System.Drawing.Size(200, 20);
            this.dtBirthDate.TabIndex = 5;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(109, 50);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(109, 24);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 0;
            // 
            // lblBirthDate
            // 
            this.lblBirthDate.AutoSize = true;
            this.lblBirthDate.Location = new System.Drawing.Point(17, 131);
            this.lblBirthDate.Name = "lblBirthDate";
            this.lblBirthDate.Size = new System.Drawing.Size(57, 13);
            this.lblBirthDate.TabIndex = 4;
            this.lblBirthDate.Text = "Birth Date:";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(17, 105);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 13);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Category :";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(17, 79);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "Gender:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(17, 53);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(17, 27);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // pnlUpdateCustomer
            // 
            this.pnlUpdateCustomer.Controls.Add(this.btnUpdateCustomer);
            this.pnlUpdateCustomer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlUpdateCustomer.Location = new System.Drawing.Point(0, 511);
            this.pnlUpdateCustomer.Name = "pnlUpdateCustomer";
            this.pnlUpdateCustomer.Size = new System.Drawing.Size(934, 100);
            this.pnlUpdateCustomer.TabIndex = 24;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(934, 24);
            this.menuBar.TabIndex = 25;
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
            // frmUpdateCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 611);
            this.Controls.Add(this.menuBar);
            this.Controls.Add(this.pnlUpdateCustomer);
            this.Controls.Add(this.grpUpdateCustomerOfficeUseOnly);
            this.Controls.Add(this.grpUpdateCustomerAddress);
            this.Controls.Add(this.grpUpdateCustomerDetails);
            this.Name = "frmUpdateCustomers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Customers";
            this.Load += new System.EventHandler(this.frmUpdateCustomers_Load);
            this.grpUpdateCustomerOfficeUseOnly.ResumeLayout(false);
            this.grpUpdateCustomerOfficeUseOnly.PerformLayout();
            this.grpUpdateCustomerAddress.ResumeLayout(false);
            this.grpUpdateCustomerAddress.PerformLayout();
            this.grpUpdateCustomerDetails.ResumeLayout(false);
            this.grpUpdateCustomerDetails.PerformLayout();
            this.pnlUpdateCustomer.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateCustomer;
        private System.Windows.Forms.GroupBox grpUpdateCustomerOfficeUseOnly;
        private System.Windows.Forms.Label lblCustomerID;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.GroupBox grpUpdateCustomerAddress;
        private System.Windows.Forms.ComboBox cbState;
        private System.Windows.Forms.TextBox txtPostcode;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSuburb;
        private System.Windows.Forms.TextBox txtSuburb;
        private System.Windows.Forms.Label lblState;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPostcode;
        private System.Windows.Forms.GroupBox grpUpdateCustomerDetails;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbCategoryID;
        private System.Windows.Forms.DateTimePicker dtBirthDate;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblBirthDate;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlUpdateCustomer;
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