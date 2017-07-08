using Acme_Project.Business_Logic_Layer;
using Acme_Project.Categories;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Presentatin_Layer.Products;
using Acme_Project.Presentatin_Layer.Sales;
using Acme_Project.Presentation_Layer.About;
using Acme_Project.Presentation_Layer.ProductTypes;
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

namespace Acme_Project.Presentation_Layer.ProductTypes
{
    public partial class frmAddProductTypes : Form
    {
        public frmAddProductTypes()
        {
            InitializeComponent();
        }

        private bool validateInput()
        {
            if (String.IsNullOrEmpty(txtProductType.Text))
            {
                MessageBox.Show("Please enter the Product Type.");
                return false;
            }
            return true;
        }

        private void btnAddProductTypes_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create the sale object using the Sale Class constructor
                var productType = new _ProductType();

                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_ProductTypes_CreateProductType", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter nptid = cmd.Parameters.Add("NewProductTypeID", SqlDbType.Int); nptid.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("ProductType", txtProductType.Text);

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                }
                if (MessageBox.Show("Would you like to add another Product Type into the database", "Add another?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtProductType.Clear();
                    txtProductTypeID.Clear();
                }
                else
                {
                    this.Close();
                }
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
