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
    public partial class frmMainProductTypes : Form
    {
        public frmMainProductTypes()
        {
            InitializeComponent();
        }

        private void DisplayProductTypes()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM ProductTypes";
            List<_ProductType> ptList = new List<_ProductType>();
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
                        var productType = new _ProductType(
                            int.Parse(rdr["ProductTypeID"].ToString()),
                            rdr["ProductType"].ToString());

                        ptList.Add(productType);
                    }
                    dgvProductType.DataSource = ptList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }

        }

        private void btnAddProductType_Click(object sender, EventArgs e)
        {
            frmAddProductTypes addProductTypes = new frmAddProductTypes();
            addProductTypes.ShowDialog();
            DisplayProductTypes();
        }

        private void btnUpdateProductType_Click(object sender, EventArgs e)
        {
            if (dgvProductType.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgvProductType.SelectedRows[0]; //Selecting the row
                var productType = (_ProductType)selectedRow.DataBoundItem; //setting Product Type to an instance of the Product Type Class of the selected row.

                frmUpdateProductTypes productTypeUpdate = new frmUpdateProductTypes(productType);
                productTypeUpdate.ShowDialog();
                DisplayProductTypes();
            }
        }

        private void btnSearchProductType_Click(object sender, EventArgs e)
        {
            List<_ProductType> ptList = new List<_ProductType>();
            try
            {
                // Automatically  open and close the connection
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = conn.CreateCommand())
                    {
                        if (rbShowAll.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM ProductTypes";
                        }
                        if (rbSearchProductTypeID.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM ProductTypes WHERE ProductTypeID = @producttypeid";
                        }
                        if (rbSearchProductType.Checked)
                        {
                            cmd.CommandText = "SELECT * FROM ProductTypes WHERE ProductType = @producttype";
                        }

                        cmd.Parameters.AddWithValue("producttypeid", txtSearchProductTypeID.Text);
                        cmd.Parameters.AddWithValue("producttype", txtSearchProductType.Text);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        using (var rdr = cmd.ExecuteReader())
                        {
                            while (rdr.Read())
                            {
                                //Define the list items
                                var producttype = new _ProductType(
                                int.Parse(rdr["ProductTypeID"].ToString()),
                                rdr["ProductType"].ToString());

                                ptList.Add(producttype);
                            }
                            dgvProductType.DataSource = ptList;
                        }
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }

        }

        private void frmMainProductTypes_Load(object sender, EventArgs e)
        {
            DisplayProductTypes();
        }

        private void btnDeleteProductType_Click(object sender, EventArgs e)
        {
            if (dgvProductType.SelectedRows.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to delete this Product Type?", "Product Type Delete", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }
                DataGridViewRow selectedRow = dgvProductType.SelectedRows[0]; //Selecting the row
                var deleteProductType = (_ProductType)selectedRow.DataBoundItem; //setting deleteProductType to an instance of the Product Type Class of the selected row.

                //Test to see if the Product Type can be deleted


                //Code to check if the Product Type can be deleted using the stored procedure given
                using (var conn = ConnectionManager.DatabaseConnection())
                {
                    using (var cmd = new SqlCommand("sp_ProductTypes_AllowDeleteProductType", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ProductTypeID", deleteProductType.ProductTypeID);
                        cmd.Parameters.Add("RecordCount", SqlDbType.Int).Direction = ParameterDirection.Output;
                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();
                        int validDelete = Convert.ToInt32(cmd.Parameters["RecordCount"].Value);
                        if (validDelete == 1)
                        {
                            MessageBox.Show("Product Type can not be deleted.", "Error");
                            return;
                        }
                    }
                    //Code to delete the Product Type
                    using (var cmd = new SqlCommand("sp_ProductTypes_DeleteProductType", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("ProductTypeID", deleteProductType.ProductTypeID);

                        cmd.Transaction = conn.BeginTransaction();
                        cmd.ExecuteNonQuery();
                        cmd.Transaction.Commit();

                        DisplayProductTypes(); //Refresh the table
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Product Type to delete from the table.", "Error");
            }
        }
    }
}
