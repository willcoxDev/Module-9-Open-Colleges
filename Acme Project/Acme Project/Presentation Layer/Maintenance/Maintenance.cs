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
using Acme_Project.Customers;
using Acme_Project.Categories;
using Acme_Project.Presentatin_Layer.Products;
using Acme_Project.Presentatin_Layer.Sales;
using Acme_Project.Presentation_Layer.ProductTypes;
using Acme_Project.Presentation_Layer.Tutorial;
using Acme_Project.Presentation_Layer.About;
using System.Data.SqlClient;

namespace Acme_Project.Presentatin_Layer
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void DisplayDashboard()
        {
            string numSalesQuery = "select Products.ProductName, ProductTypes.ProductType, count(SaleID) numSales " +
                "from Products join ProductTypes on (ProductTypes.ProductTypeID = Products.ProductTypeID)" +
                "join Sales on (Sales.ProductID = Products.ProductID)" +
                "group by Products.ProductName, ProductTypes.ProductType";

            List<_Dashboard> dashList = new List<_Dashboard>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand(numSalesQuery, conn))
                using (var rdr = cmd.ExecuteReader())
                {

                    while (rdr.Read())
                    {
                        //Define the list items
                        var dashboard = new _Dashboard(
                            rdr["ProductName"].ToString(),
                            rdr["ProductType"].ToString(),
                            int.Parse(rdr["numSales"].ToString()));
                        dashList.Add(dashboard);
                    }
                    dgvDashboard.DataSource = dashList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }

        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers mainCustomers = new frmCustomers();
            mainCustomers.ShowDialog();
            DisplayDashboard();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmMainProducts mainProducts = new frmMainProducts();
            mainProducts.ShowDialog();
            DisplayDashboard();
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
            frmMainSales mainSales = new frmMainSales();
            mainSales.ShowDialog();
            DisplayDashboard();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            frmMainCategories mainCategories = new frmMainCategories();
            mainCategories.ShowDialog();
            DisplayDashboard();
        }

        private void btnProductTypes_Click(object sender, EventArgs e)
        {
            frmMainProductTypes mainProductTypes = new frmMainProductTypes();
            mainProductTypes.ShowDialog();
            DisplayDashboard();
        }

        private void btnTutorial_Click(object sender, EventArgs e)
        {
            frmMainTutorial mainTutorial = new frmMainTutorial();
            mainTutorial.ShowDialog();
            DisplayDashboard();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmMainAbout mainAbout = new frmMainAbout();
            mainAbout.Show();
            DisplayDashboard();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomers mainCustomers = new frmCustomers();
            mainCustomers.ShowDialog();
            DisplayDashboard();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainProducts mainProducts = new frmMainProducts();
            mainProducts.ShowDialog();
            DisplayDashboard();
        }

        private void productTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainProductTypes mainProductTypes = new frmMainProductTypes();
            mainProductTypes.ShowDialog();
            DisplayDashboard();
        }

        private void salesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainSales mainSales = new frmMainSales();
            mainSales.ShowDialog();
            DisplayDashboard();
        }

        private void categoriesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainCategories mainCategories = new frmMainCategories();
            mainCategories.ShowDialog();
            DisplayDashboard();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainTutorial mainTutorial = new frmMainTutorial();
            mainTutorial.ShowDialog();
            DisplayDashboard();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMainAbout mainAbout = new frmMainAbout();
            mainAbout.Show();
            DisplayDashboard();
        }

        private void frmMaintenance_Load(object sender, EventArgs e)
        {
            DisplayDashboard();
        }
    }
}
