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

namespace Acme_Project.Presentation_Layer.ProductTypes
{
    public partial class frmUpdateProductTypes : Form
    {
        public frmUpdateProductTypes(_ProductType productType)
        {
            InitializeComponent();
            //Fill in the form
            txtProductTypeID.Text = productType.ProductTypeID.ToString();
            txtProductType.Text = productType.ProductType;
        }

        private void btnUpdateProductTypes_Click(object sender, EventArgs e)
        {
            if (validateInput())
            {
                //Create an object of the ProductType class.
                var updateExistingProductType = new _ProductType(int.Parse(txtProductTypeID.Text),
                    txtProductType.Text);

                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    //Specify the Stored Procedure
                    using (var cmd = new SqlCommand("sp_ProductTypes_UpdateProductType", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ProductTypeID", updateExistingProductType.ProductTypeID);
                        cmd.Parameters.AddWithValue("ProductType", updateExistingProductType.ProductType);

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
            if (String.IsNullOrEmpty(txtProductType.Text))
            {
                MessageBox.Show("Please enter the Product Type.");
                return false;
            }
            return true;
        }
    }
}
