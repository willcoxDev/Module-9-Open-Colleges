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
    public partial class frmMainProducts : Form
    {
        public frmMainProducts()
        {
            InitializeComponent();
        }
        private void DisplayProducts()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM Products";
            List<Product> proList = new List<Product>();
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
                        var product = new Product(
                            int.Parse(rdr["ProductID"].ToString()),
                            int.Parse(rdr["ProductTypeID"].ToString()),
                            rdr["ProductName"].ToString(),
                            decimal.Parse(rdr["YearlyPremium"].ToString()));

                        proList.Add(product);
                    }
                    dgvProducts.DataSource = proList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }


        }

        private void frmMainProducts_Load(object sender, EventArgs e)
        {
            cbSearchOperator.SelectedIndex = 1;
            DisplayProducts();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            addProduct.ShowDialog();
            DisplayProducts();
        }
    }
}
