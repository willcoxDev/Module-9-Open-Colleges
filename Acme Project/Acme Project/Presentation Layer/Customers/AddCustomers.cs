﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Business_Logic_Layer;
using System.Data.SqlClient;
using Acme_Project.Presentatin_Layer.Products;
using Acme_Project.Presentatin_Layer.Sales;
using Acme_Project.Presentation_Layer.About;
using Acme_Project.Presentation_Layer.ProductTypes;
using Acme_Project.Categories;

namespace Acme_Project
{
    public partial class frmAddCustomers : Form
    {
        public frmAddCustomers()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                string gender = "M";
                if (rbFemale.Checked)
                {
                    gender = "F";
                }
                //Create an object of the customer class.
                var newCustomer = new Customer(0,
                    (int)cbCategoryID.SelectedValue,
                    txtFirstName.Text,
                    txtLastName.Text,
                    gender,
                    txtAddress.Text,
                    txtSuburb.Text,
                    cbState.Text,
                    int.Parse(txtPostcode.Text),
                    dtBirthDate.Value);

                

                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_Customers_CreateCustomer", conn) //Specify the Stored Procedure
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.AddWithValue("CategoryID", newCustomer.CategoryID);
                    cmd.Parameters.AddWithValue("FirstName", newCustomer.FirstName);
                    cmd.Parameters.AddWithValue("LastName", newCustomer.LastName);
                    cmd.Parameters.AddWithValue("Gender", newCustomer.Gender);
                    cmd.Parameters.AddWithValue("Address", newCustomer.Address);
                    cmd.Parameters.AddWithValue("Suburb", newCustomer.Suburb);
                    cmd.Parameters.AddWithValue("State", newCustomer.State);
                    cmd.Parameters.AddWithValue("Postcode", newCustomer.PostCode);
                    cmd.Parameters.AddWithValue("BirthDate", newCustomer.BirthDate);
                    SqlParameter ncid = cmd.Parameters.Add("NewCustomerID", SqlDbType.Int); ncid.Direction = ParameterDirection.Output;

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                }
                // Show msgbox to either go back to frmCustomers or clear this current form to add another customer.
                if(MessageBox.Show("Would you like to add another customer into the database", "Add another?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtFirstName.Clear();
                    txtLastName.Clear();
                    txtAddress.Clear();
                    txtSuburb.Clear();
                    txtCustomerID.Clear();
                    txtPostcode.Clear();
                    rbFemale.Checked = false;
                    rbMale.Checked = false;
                    cbCategoryID.SelectedValue = null;
                    cbState.SelectedIndex = -1;
                }
                else
                {
                    this.Close();
                }

             } 
        }
        //Validate all the input, Show Error message box with with the problem the user has.
        private bool validateInput()
        { 
            if(String.IsNullOrEmpty(txtFirstName.Text))
            {
                MessageBox.Show("Please enter the first name.");
                return false;
            }

            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("Please enter the Last name.");
                return false;
            }

            if (rbMale.Checked == false && rbFemale.Checked == false)
            {
                MessageBox.Show("Please select a Gender.");
                return false;
            }

            if (String.IsNullOrEmpty(cbCategoryID.Text))
            {
                MessageBox.Show("Please select a Category.");
                return false;
            }


            if (String.IsNullOrEmpty(txtAddress.Text))
            {
                MessageBox.Show("Please enter an Address.");
                return false;
            }

            if (String.IsNullOrEmpty(txtSuburb.Text))
            {
                MessageBox.Show("Please enter a Suburb.");
                return false;
            }

            if (String.IsNullOrEmpty(cbState.Text))
            {
                MessageBox.Show("Please select a State.");
                return false;
            }

            if (String.IsNullOrEmpty(txtPostcode.Text))
            {
                MessageBox.Show("Please enter a postcode.");
                return false;
            }

            int parsedPostcode;
            if (!int.TryParse(txtPostcode.Text, out parsedPostcode))
            {
                MessageBox.Show("Postcode must be an number.");
                return false;
            }
            /* Since it is the primary key no need to use
            int parsedCustomerID;
            if (!int.TryParse(txtCustomerID.Text, out parsedCustomerID))
            {
                MessageBox.Show("Customer ID must be an number.");
                return false;
            }
            */
            
            return true;
        }

        private void frmAddCustomers_Load_1(object sender, EventArgs e)
        {
            //Populating the combobox from the Category table.
            string populateCategory = "SELECT * FROM Categories";
            List<_Category> catList = new List<_Category>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(populateCategory, conn))
                using (var rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        //Define the list items
                        var category = new _Category(
                            int.Parse(rdr["CategoryID"].ToString()),
                            rdr["Category"].ToString());

                        catList.Add(category);

                    }

                }
                cbCategoryID.DataSource = catList;
                cbCategoryID.DisplayMember = "Category";
                cbCategoryID.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
            cbCategoryID.SelectedValue = 0; //set the Category Box to display nothing when the program starts.
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblCategory_Click(object sender, EventArgs e)
        {

        }

        private void lblBirthDate_Click(object sender, EventArgs e)
        {

        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void lblSuburb_Click(object sender, EventArgs e)
        {

        }

        private void lblState_Click(object sender, EventArgs e)
        {

        }

        //File
        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers mainCustomers = new frmCustomers();
            mainCustomers.ShowDialog();
            this.Close();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainProducts mainProducts = new frmMainProducts();
            mainProducts.ShowDialog();
            this.Close();
        }

        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainProductTypes mainProductTypes = new frmMainProductTypes();
            mainProductTypes.ShowDialog();
            this.Close();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainSales mainSales = new frmMainSales();
            mainSales.ShowDialog();
            this.Close();
        }

        //File close
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCategories mainCategories = new frmMainCategories();
            mainCategories.ShowDialog();
            this.Close();
        }
        //Help
        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainProductTypes mainProductTypes = new frmMainProductTypes();
            mainProductTypes.ShowDialog();
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainAbout mainAbout = new frmMainAbout();
            mainAbout.Show();
            this.Close();
        }
    }
}


