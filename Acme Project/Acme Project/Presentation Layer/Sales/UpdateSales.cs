using Acme_Project.Business_Logic_Layer;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Presentatin_Layer.Products;
using Acme_Project.Presentatin_Layer.Sales;
using Acme_Project.Presentation_Layer.About;
using Acme_Project.Presentation_Layer.ProductTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Acme_Project.Categories;

namespace Acme_Project.Presentatin_Layer.Sales
{
    public partial class frmUpdateSales : Form
    {
        
        public frmUpdateSales(Sale updateSale)
        {
            InitializeComponent();
            //Fill in the form to the Selected Sale details.
            txtCustomerID.Text = updateSale.CustomerID.ToString();
            txtProductID.Text = updateSale.ProductID.ToString();
            txtSaleID.Text = updateSale.SaleID.ToString();
            cbPayable.Text = updateSale.Payable.ToString();
            dtStartDate.Value = updateSale.StartDate;
        }

        private void btnUpdateSale_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create an object of the Sale class.
                var updateExistingSale = new Sale(int.Parse(txtSaleID.Text),
                    int.Parse(txtCustomerID.Text),
                    int.Parse(txtProductID.Text),
                    cbPayable.Text,
                    dtStartDate.Value);

                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    //Specify the Stored Procedure
                    using (var cmd = new SqlCommand("sp_Sales_UpdateSale", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("SaleID", updateExistingSale.SaleID);
                        cmd.Parameters.AddWithValue("CustomerID", updateExistingSale.CustomerID);
                        cmd.Parameters.AddWithValue("ProductID", updateExistingSale.ProductID);
                        cmd.Parameters.AddWithValue("Payable", updateExistingSale.Payable);
                        cmd.Parameters.AddWithValue("StartDate", updateExistingSale.StartDate);

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
                if (customerExists != null)
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
            //this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainAbout mainAbout = new frmMainAbout();
            mainAbout.Show();
            this.Close();
        }
    }
}
