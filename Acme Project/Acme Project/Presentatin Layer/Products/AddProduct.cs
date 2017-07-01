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

namespace Acme_Project.Presentatin_Layer.Products
{
    public partial class frmAddProduct : Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                var newProduct = new Product(0, (cbProductType.SelectedIndex + 1),
                    txtProductName.Text, decimal.Parse(txtYearlyPremium.Text));
                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_Products_CreateProduct", conn) //Specify the Stored Procedure
                {
                    CommandType = CommandType.StoredProcedure
                })
                {
                    cmd.Parameters.AddWithValue("ProductName", newProduct.ProductName);
                    cmd.Parameters.AddWithValue("ProductTypeID", newProduct.ProductTypeID);
                    cmd.Parameters.AddWithValue("YearlyPremium", newProduct.YearlyPremium);
                    SqlParameter npi = cmd.Parameters.Add("NewProductID", SqlDbType.Int); npi.Direction = ParameterDirection.Output;

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                }
                // Show msgbox to either go back to frmCustomers or clear this current form to add another customer.
                if (MessageBox.Show("Would you like to add another Product into the database", "Add another?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtProductName.Clear();
                    txtYearlyPremium.Clear();
                    cbProductType.SelectedIndex = -1;
                }
                else
                {
                    this.Close();
                }
            }
        }

        private bool validateInput()
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a Product Name.");
                return false;
            }
            if(cbProductType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a Product Type");
            }
            decimal parsedPremium;
            if (!decimal.TryParse(txtYearlyPremium.Text, out parsedPremium))
            {
                MessageBox.Show("Yearly Premium must be an number.");
                return false;
            }
            /* Since it is the primary key no need to use
            int parsedProductID;
            if (!int.TryParse(txtCustomerID.Text, out parsedProductID))
            {
                MessageBox.Show("ProductS ID must be an number.");
                return false;
            }
            */

            return true;
        }
    }
}
