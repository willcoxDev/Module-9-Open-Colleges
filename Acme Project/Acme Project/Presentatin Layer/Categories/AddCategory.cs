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
    public partial class frmAddCategory : Form
    {
        public frmAddCategory()
        {
            InitializeComponent();
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

        private void btnAddCategories_Click_1(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create the sale object using the Sale Class constructor
                var category = new _Category();

                using (var conn = ConnectionManager.DatabaseConnection())
                using (var cmd = new SqlCommand("sp_Categories_CreateCategory", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ncid = cmd.Parameters.Add("NewCategoryID", SqlDbType.Int); ncid.Direction = ParameterDirection.Output;
                    cmd.Parameters.AddWithValue("Category", txtCategory.Text);

                    cmd.Transaction = conn.BeginTransaction();
                    cmd.ExecuteNonQuery();
                    cmd.Transaction.Commit();

                }
                if (MessageBox.Show("Would you like to add another Category into the database", "Add another?",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    txtCategory.Clear();
                    txtCategoryID.Clear();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
