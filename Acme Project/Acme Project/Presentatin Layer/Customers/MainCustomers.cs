﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Business_Logic_Layer;

namespace Acme_Project
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();

        }
        private void DisplayCustomers()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM Customers";
            List<Customer> cusList = new List<Customer>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(selectQuery, conn))
                using (var rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        //Define the list items
                        var customer = new Customer(
                            int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["CategoryID"].ToString()),
                            rdr["FirstName"].ToString(),
                            rdr["LastName"].ToString(),
                            rdr["Gender"].ToString(),
                            rdr["Address"].ToString(),
                            rdr["Suburb"].ToString(),
                            rdr["State"].ToString(),
                            int.Parse(rdr["Postcode"].ToString()),
                            DateTime.Parse(rdr["BirthDate"].ToString()));

                        cusList.Add(customer);
                    }
                    dgvCustomers.DataSource = cusList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }


        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            frmAddCustomers customersAdd = new frmAddCustomers();
            customersAdd.Show();
            this.Hide();
        }

        private void btnUpdateCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteCustomers_Click(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this customer?", "Customer Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvCustomers.SelectedRows[0]; //Selecting the row
                var deleteCustomer = (Customer)selectedRow.DataBoundItem; //setting deleteCustomer to an instance of the Customer Class of the selected row.

                //Test to see if the customer can be deleted


                //Code to delete the Customer
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = new SqlCommand("sp_Customers_AllowDeleteCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("CustomerID", deleteCustomer.CustomerID);
                        cmd.Parameters.Add("RecordCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        int validDelete = Convert.ToInt32(cmd.Parameters["RecordCount"].Value);
                        if (validDelete == 1)
                        {
                            MessageBox.Show("Customer can not be deleted.", "Error");
                            return;
                        }
                    }
                    using (var cmd = new SqlCommand("sp_Customers_DeleteCustomer", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("CustomerID", deleteCustomer.CustomerID);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        DisplayCustomers(); //Refresh the table
                    }

                }


            }
            else
            {
                MessageBox.Show("Please select a Customer to delete from the table.", "Error");
            }



        }
    }
}
