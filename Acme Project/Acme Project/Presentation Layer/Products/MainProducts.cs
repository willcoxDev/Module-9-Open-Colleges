﻿using Acme_Project.Business_Logic_Layer;
using Acme_Project.Categories;
using Acme_Project.Data_Access_Layer;
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

        private void DisplaySearch()
        {
            List<Product> proList = new List<Product>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        if (rbShowAll.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Products";
                        }
                        if (rbSearchProductName.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Products WHERE ProductName = @productName";
                        }
                        if (rbSearchYearlyPremium.Checked && cbSearchOperator.SelectedIndex == 0)
                        {
                            cmd.CommandText = "SELECT * FROM Products WHERE YearlyPremium < @yearlyPremium";
                        }
                        if (rbSearchYearlyPremium.Checked && cbSearchOperator.SelectedIndex == 1)
                        {
                            cmd.CommandText = "SELECT * FROM Products WHERE YearlyPremium = @yearlyPremium";
                        }
                        if (rbSearchYearlyPremium.Checked && cbSearchOperator.SelectedIndex == 2)
                        {
                            cmd.CommandText = "SELECT * FROM Products WHERE YearlyPremium > @yearlyPremium";
                        }

                        cmd.Parameters.AddWithValue("productName", txtSearchFirstName.Text);
                        cmd.Parameters.AddWithValue("yearlyPremium", txtSearchYearlyPremium.Text);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
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

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Product?", "Product Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0]; //Selecting the row
                var deleteProduct = (Product)selectedRow.DataBoundItem; //setting deleteProduct to an instance of the Product Class of the selected row.

                //Test to see if the product can be deleted


                //Code to check if the product can be deleted using the stored procedure given
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = new SqlCommand("sp_Products_AllowDeleteProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ProductID", deleteProduct.ProductID);
                        cmd.Parameters.Add("RecordCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        int validDelete = Convert.ToInt32(cmd.Parameters["RecordCount"].Value);
                        if (validDelete == 1)
                        {
                            MessageBox.Show("Product can not be deleted.", "Error");
                            return;
                        }
                    }
                    //Code to delete the product
                    using (var cmd = new SqlCommand("sp_Products_DeleteProduct", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ProductID", deleteProduct.ProductID);
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        DisplayProducts(); //Refresh the table
                    }

                }
            }
        }

        private void btnUpdateProduct_Click(object sender, EventArgs e)
        {
            if (dgvProducts.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProducts.SelectedRows[0]; //Selecting the row
                var updateProduct = (Product)selectedRow.DataBoundItem; //setting deleteCustomer to an instance of the Customer Class of the selected row.

                frmUpdateProduct productsUpdate = new frmUpdateProduct(updateProduct);
                productsUpdate.ShowDialog();
                DisplayProducts();
            }
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            DisplaySearch();
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
            //frmMainProductTypes mainProductTypes = new frmMainProductTypes();
            //mainProductTypes.ShowDialog();
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
