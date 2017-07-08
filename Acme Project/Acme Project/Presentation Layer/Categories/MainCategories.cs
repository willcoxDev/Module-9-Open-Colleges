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
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acme_Project.Categories
{
    public partial class frmMainCategories : Form
    {
        public frmMainCategories()
        {
            InitializeComponent();
        }

        private void DisplayCategories()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM Categories";
            List<_Category> catList = new List<_Category>();
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
                        var category = new _Category(
                            int.Parse(rdr["CategoryID"].ToString()),
                            rdr["Category"].ToString());

                        catList.Add(category);
                    }
                    dgvCategories.DataSource = catList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }

        }

        private void btnAddCategories_Click(object sender, EventArgs e)
        {
            frmAddCategory addCategories = new frmAddCategory();
            addCategories.ShowDialog();
            DisplayCategories();
        }

        private void frmMainCategories_Load(object sender, EventArgs e)
        {
            DisplayCategories();
        }

        private void btnDeleteCategories_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this category?", "Category Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvCategories.SelectedRows[0]; //Selecting the row
                var deleteCategory = (_Category)selectedRow.DataBoundItem; //setting deleteCategory to an instance of the Customer Class of the selected row.

                //Test to see if the category can be deleted


                //Code to check if the category can be deleted using the stored procedure given
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = new SqlCommand("sp_Categories_AllowDeleteCategory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("CategoryID", deleteCategory.CategoryID);
                        cmd.Parameters.Add("RecordCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        int validDelete = Convert.ToInt32(cmd.Parameters["RecordCount"].Value);
                        if (validDelete == 1)
                        {
                            MessageBox.Show("Category can not be deleted.", "Error");
                            return;
                        }
                    }
                    //Code to delete the Category
                    using (var cmd = new SqlCommand("sp_Categories_DeleteCategory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("CategoryID", deleteCategory.CategoryID);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        DisplayCategories(); //Refresh the table
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Category to delete from the table.", "Error");
            }
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (dgvCategories.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvCategories.SelectedRows[0]; //Selecting the row
                var updateCustomer = (_Category)selectedRow.DataBoundItem; //setting deleteCategory to an instance of the Category Class of the selected row.

                frmUpdateCategory categoryUpdate = new frmUpdateCategory(updateCustomer);
                categoryUpdate.ShowDialog();
                DisplayCategories();
            }
        }

        private void btnSearchCategories_Click(object sender, EventArgs e)
        {
            List<_Category> catList = new List<_Category>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        if (rbShowAll.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Categories";
                        }
                        if (rbSearchCategoryID.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Categories WHERE CategoryID = @categoryid";
                        }
                        if (rbSearchCategory.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM Categories WHERE Category = @category";
                        }

                        cmd.Parameters.AddWithValue("categoryid", txtSearchCategoryID.Text);
                        cmd.Parameters.AddWithValue("category", txtSearchCategory.Text);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                //Define the list items
                                var category = new _Category(
                                int.Parse(rdr["CategoryID"].ToString()),
                                rdr["Category"].ToString());

                                catList.Add(category);
                            }
                            dgvCategories.DataSource = catList;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
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
            //frmMainCategories mainCategories = new frmMainCategories();
            //mainCategories.ShowDialog();
            //this.Close();
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
        }
    }
}
