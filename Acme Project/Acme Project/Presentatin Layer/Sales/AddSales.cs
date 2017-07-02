using Acme_Project.Business_Logic_Layer;
using Acme_Project.Data_Access_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acme_Project.Presentatin_Layer.Sales
{
    public partial class frmAddSales : Form
    {
        public frmAddSales()
        {
            InitializeComponent();
        }

        private void btnAddSale_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create the sale object using the Sale Class constructor
                var sale = new Sale(0,int.Parse(txtCustomerID.Text),
                    int.Parse(txtProductID.Text), cbPayable.Text, DateTime.Parse(dtStartDate.Text));

                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_Sales_CreateSale", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter nsid = cmd.Parameters.Add("NewSaleID", SqlDbType.Int); nsid.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("CustomerID", sale.CustomerID);
                    cmd.Parameters.AddWithValue("ProductID", sale.ProductID);
                    cmd.Parameters.AddWithValue("Payable", sale.Payable);
                    cmd.Parameters.AddWithValue("StartDate", sale.StartDate);

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                }
                if (MessageBox.Show("Would you like to add another customer into the database", "Add another?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtCustomerID.Clear();
                    txtProductID.Clear();
                    cbPayable.SelectedIndex = -1;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool validateInput()
        {
            if (customerExists() && productExists() && cbPayable.SelectedIndex != -1)
            {
                return true;
            }
            return false;
        }

        private bool customerExists()
        {
            int? customerExists;
            try
            {
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "SELECT CustomerID FROM Customers WHERE CustomerID = @customerid";
                        cmd.Parameters.AddWithValue("customerid", int.Parse(txtCustomerID.Text));

                        cmd.Transaction = conn.BeginTransaction();
                        customerExists = (int?)cmd.ExecuteScalar();
                        cmd.Transaction.Commit();
                    }
                }
                if (customerExists !=  null)
                {
                    return true;
                }
                MessageBox.Show("Please make sure the Customer ID exists");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure the Customer ID exists");
                return false;
            }
        }

        private bool productExists()
        {
            int? productExists;
            try
            {
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = conn.CreateCommand()) 
                    {
                        cmd.CommandText = "SELECT ProductID FROM Products WHERE ProductID = @productid";
                        cmd.Parameters.AddWithValue("productid", int.Parse(txtProductID.Text));

                        cmd.Transaction = conn.BeginTransaction();
                        productExists = (int?)cmd.ExecuteScalar();
                        cmd.Transaction.Commit();
                    }
                }
                if (productExists != null)
                {
                    return true;
                }
                MessageBox.Show("Please make sure the Product ID exists");
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure the Product ID exists");
                return false;
            }
        }
    }
}


/*
 * using (var cmd = conn.CreateCommand()) //Specify the Stored Procedure
                    {
                        cmd.CommandText = "SELECT ProductID FROM Products WHERE ProductID = @productid";
                        cmd.Parameters.AddWithValue("productid", int.Parse(txtProductID.Text));
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                    }
*/