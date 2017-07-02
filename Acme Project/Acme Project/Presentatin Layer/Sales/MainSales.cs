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
    }
}
