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
                var newCustomer = new Customer(int.Parse(txtCustomerID.Text),
                    (cbCategoryID.SelectedIndex) + 1,
                    txtFirstName.Text,
                    txtLastName.Text,
                    gender,
                    txtAddress.Text,
                    txtSuburb.Text,
                    cbState.Text,
                    int.Parse(txtPostcode.Text),
                    dtBirthDate.Value);

                //Making it so SQL injection is not possible
                string addQuery = "INSERT INTO Customers(categoryID, firstName, lastName" +
                    ", gender, address, suburb, state, postcode, birthDate)VALUES" +
                    "(@CategoryID, @FirstName, @LastName, @Gender, @Address, @Suburb, @State" +
                    ", @Postcode, @BirthDate)";

                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(addQuery, conn))
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

                    cmd.ExecuteNonQuery(); 
                    
                }

             } 
        }

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
            int parsedCustomerID;
            if (!int.TryParse(txtPostcode.Text, out parsedCustomerID))
            {
                MessageBox.Show("Customer ID must be an number.");
                return false;
            }

            
            return true;
        }
    }
}


