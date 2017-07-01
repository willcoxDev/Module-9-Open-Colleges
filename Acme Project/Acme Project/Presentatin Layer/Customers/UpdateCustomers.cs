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



namespace Acme_Project.Customers
{
    public partial class frmUpdateCustomers : Form
    {
        Customer updateCustomer;

        public frmUpdateCustomers(Customer uc)
        {
            InitializeComponent();
            updateCustomer = uc;

            //Fill in the form to the Selected customers details.
            txtFirstName.Text = updateCustomer.FirstName;
            txtLastName.Text = updateCustomer.LastName;
            txtCustomerID.Text = updateCustomer.CustomerID.ToString();
            txtAddress.Text = updateCustomer.Address;
            txtSuburb.Text = updateCustomer.Suburb;
            txtPostcode.Text = updateCustomer.PostCode.ToString();
            cbCategoryID.SelectedIndex = updateCustomer.CategoryID - 1;
            cbState.Text = updateCustomer.State;
            dtBirthDate.Value = updateCustomer.BirthDate;
            rbFemale.Checked = !(rbMale.Checked = updateCustomer.Gender == "M");

        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            string gender = "M";
            if (rbFemale.Checked)
            {
                gender = "F";
            }
            //Create an object of the customer class.
            var updateExistingCustomer = new Customer(int.Parse(txtCustomerID.Text),
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
            using (var cmd = new SqlCommand("sp_Customers_UpdateCustomer", conn) //Specify the Stored Procedure
            {
                CommandType = CommandType.StoredProcedure
            })
            {
                cmd.Parameters.AddWithValue("CategoryID", updateExistingCustomer.CategoryID);
                cmd.Parameters.AddWithValue("FirstName", updateExistingCustomer.FirstName);
                cmd.Parameters.AddWithValue("LastName", updateExistingCustomer.LastName);
                cmd.Parameters.AddWithValue("Gender", updateExistingCustomer.Gender);
                cmd.Parameters.AddWithValue("Address", updateExistingCustomer.Address);
                cmd.Parameters.AddWithValue("Suburb", updateExistingCustomer.Suburb);
                cmd.Parameters.AddWithValue("State", updateExistingCustomer.State);
                cmd.Parameters.AddWithValue("Postcode", updateExistingCustomer.PostCode);
                cmd.Parameters.AddWithValue("BirthDate", updateExistingCustomer.BirthDate);
                cmd.Parameters.AddWithValue("CustomerID", updateExistingCustomer.CustomerID);

                cmd.Transaction = conn.BeginTransaction();
                cmd.ExecuteNonQuery();
                cmd.Transaction.Commit();

            }

            this.Close();
        }
    }
}
