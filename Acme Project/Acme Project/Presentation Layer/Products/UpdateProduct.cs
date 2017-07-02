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

namespace Acme_Project.Presentatin_Layer.Products
{
    public partial class frmUpdateProduct : Form
    {
        Product updateProduct;
        public frmUpdateProduct(Product up)
        {
            InitializeComponent();
            updateProduct = up;
            txtProductID.Text = updateProduct.ProductID.ToString();
            txtProductName.Text = updateProduct.ProductName;
            txtYearlyPremium.Text = updateProduct.YearlyPremium.ToString();
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create an object of the Product class.
                var updateExistingProduct = new Product(int.Parse(txtProductID.Text),
                    (int)cbProductType.SelectedValue,
                    txtProductName.Text,
                    decimal.Parse(txtYearlyPremium.Text));

                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    //Specify the Stored Procedure
                    using (var cmd = new SqlCommand("sp_Products_UpdateProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ProductID", updateExistingProduct.ProductID);
                        cmd.Parameters.AddWithValue("ProductTypeID", updateExistingProduct.ProductTypeID);
                        cmd.Parameters.AddWithValue("ProductName", updateExistingProduct.ProductName);
                        cmd.Parameters.AddWithValue("YearlyPremium", updateExistingProduct.YearlyPremium);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                    }
                    //Updating Yearly Premium because no one proof read the course material
                    using (var cmd = conn.CreateCommand())
                    {
                        cmd.CommandText = "UPDATE Products SET YearlyPremium = @yearlyPremium WHERE ProductID = @productID";
                        cmd.Parameters.AddWithValue("yearlyPremium", updateExistingProduct.YearlyPremium);
                        cmd.Parameters.AddWithValue("productID", updateExistingProduct.ProductID);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                    }
                }
                this.Close();
            }
            

            
        }
        private bool validateInput()
        {
            if (String.IsNullOrEmpty(txtProductName.Text))
            {
                MessageBox.Show("Please enter a Product Name.");
                return false;
            }
            if (cbProductType.SelectedItem == null)
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
            if (!int.TryParse(txtProductID.Text, out parsedProductID))
            {
                MessageBox.Show("ProductS ID must be an number.");
                return false;
            }
            */

            return true;
        }

        private void frmUpdateProduct_Load(object sender, EventArgs e)
        {
            //Populate the combobox with the values from the ProductTypes table
            string populateProductType = "SELECT * FROM ProductTypes";
            List<_ProductType> proTypeList = new List<_ProductType>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(populateProductType, conn))
                using (var rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        //Define the list items
                        var productType = new _ProductType(
                            int.Parse(rdr["ProductTypeID"].ToString()),
                            rdr["ProductType"].ToString());

                        proTypeList.Add(productType);
                    }
                    
                }
                cbProductType.DataSource = proTypeList;
                cbProductType.DisplayMember = "ProductType";
                cbProductType.ValueMember = "ProductTypeID";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
            cbProductType.SelectedValue = updateProduct.ProductTypeID;
        }
    }
}
