﻿using Acme_Project.Business_Logic_Layer;
using Acme_Project.Categories;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Presentatin_Layer.Products;
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

namespace Acme_Project.Presentatin_Layer.Sales
{
    public partial class frmMainSales : Form
    {
        public frmMainSales()
        {
            InitializeComponent();
        }

        private void DisplaySales()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM Sales";
            List<Sale> saleList = new List<Sale>();
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
                        var sale = new Sale(
                            int.Parse(rdr["SaleID"].ToString()),
                            int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["ProductID"].ToString()),
                            rdr["Payable"].ToString(),
                            DateTime.Parse(rdr["StartDAte"].ToString()));

                        saleList.Add(sale);
                    }
                    dgvSales.DataSource = saleList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
        }

        private void DisplaySearch()
        {

            List<Sale> saleList = new List<Sale>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        if (rbShowAll.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Sales";
                        }
                        if (rbSearchSaleID.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Sales WHERE SaleID = @saleID";
                        }
                        if (rbSearchProductID.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Sales WHERE ProductID = @productID";
                        }

                        cmd.Parameters.AddWithValue("saleID", txtSearchSaleID.Text);
                        cmd.Parameters.AddWithValue("productID", txtSearchProductID.Text);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                //Define the list items
                                var sale = new Sale(
                                int.Parse(rdr["SaleID"].ToString()),
                                int.Parse(rdr["CustomerID"].ToString()),
                                int.Parse(rdr["ProductID"].ToString()),
                                rdr["Payable"].ToString(),
                                DateTime.Parse(rdr["StartDAte"].ToString()));

                                saleList.Add(sale);
                            }
                            dgvSales.DataSource = saleList;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }


        }

        private void frmMainSales_Load(object sender, EventArgs e)
        {
            DisplaySales();
        }

        private void btnSearchSales_Click(object sender, EventArgs e)
        {
            DisplaySearch();
        }

        private void btnDeleteSales_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Sale?", "Sale Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvSales.SelectedRows[0]; //Selecting the row
                var deleteSale = (Sale)selectedRow.DataBoundItem; //setting deleteSales to an instance of the Sale Class of the selected row.

                //Test to see if the sale can be deleted


                //Code to check if the sale can be deleted using the stored procedure given
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    //Code to delete the Sale
                    using (var cmd = new SqlCommand("sp_Sales_DeleteSale", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("SaleID", deleteSale.SaleID);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        DisplaySales(); //Refresh the table
                    }

                }

            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            frmAddSales addSales = new frmAddSales();
            addSales.ShowDialog();
            DisplaySales();
        }

        private void btnUpdateSales_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvSales.SelectedRows[0]; //Selecting the row
                var updateSale = (Sale)selectedRow.DataBoundItem; //setting deleteSale to an instance of the Customer Class of the selected row.

                frmUpdateSales salesUpdate = new frmUpdateSales(updateSale);
                salesUpdate.ShowDialog();
                DisplaySales();
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
            //frmMainSales mainSales = new frmMainSales();
            //mainSales.ShowDialog();
            //this.Close();
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
