using System;
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
                    (cbCategoryID.SelectedIndex) + 1,
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
                    cbCategoryID.SelectedIndex = -1;
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
    }
}


