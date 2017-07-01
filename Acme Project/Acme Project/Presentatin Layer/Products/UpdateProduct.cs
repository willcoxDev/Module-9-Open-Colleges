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
            cbProductType.SelectedIndex = updateProduct.ProductTypeID - 1;
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {

            //Create an object of the Product class.
            var updateExistingProduct = new Product(int.Parse(txtProductID.Text),
                (cbProductType.SelectedIndex) + 1,
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
}
