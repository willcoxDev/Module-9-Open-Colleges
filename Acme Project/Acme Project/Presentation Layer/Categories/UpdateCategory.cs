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

namespace Acme_Project.Categories
{
    public partial class frmUpdateCategory : Form
    {
        public frmUpdateCategory(_Category updateCategory)
        {
            InitializeComponent();
            //Fill in the form
            txtCategoryID.Text = updateCategory.CategoryID.ToString();
            txtCategory.Text = updateCategory.Category;
        }

        private void btnUpdateCategories_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create an object of the Category class.
                var updateExistingCategory = new _Category(int.Parse(txtCategoryID.Text),
                    txtCategory.Text);

                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    //Specify the Stored Procedure
                    using (var cmd = new SqlCommand("sp_Categories_UpdateCategory", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("CategoryID", updateExistingCategory.CategoryID);
                        cmd.Parameters.AddWithValue("Category", updateExistingCategory.Category);

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
            if (String.IsNullOrEmpty(txtCategory.Text))
            {
                MessageBox.Show("Please enter the Category Name.");
                return false;
            }
            return true;
        }
    }
}
