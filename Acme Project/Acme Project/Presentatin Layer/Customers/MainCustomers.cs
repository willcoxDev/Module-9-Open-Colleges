using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Business_Logic_Layer;

namespace Acme_Project
{
    public partial class frmCustomers : Form
    {
        public frmCustomers()
        {
            InitializeComponent();
            
           
        }
        private void DisplayCustomers()
        {
            string selectQuery;
            selectQuery = "SELECT * FROM Customers";
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
                        var customer = new Customer(
                            int.Parse(rdr["CustomerID"].ToString()),
                            int.Parse(rdr["CategoryID"].ToString()),
                            rdr["FirstName"].ToString(),
                            rdr["LastName"].ToString(),
                            rdr["Gender"].ToString(),
                            rdr["Address"].ToString(),
                            rdr["Suburb"].ToString(),
                            rdr["State"].ToString(),
                            int.Parse(rdr["Postcode"].ToString()),
                            DateTime.Parse(rdr["BirthDate"].ToString()));

                        ListViewItem lvi = new ListViewItem(customer.CustomerID.ToString());
                        lvi.SubItems.Add(customer.CategoryID.ToString());
                        lvi.SubItems.Add(customer.FirstName);
                        lvi.SubItems.Add(customer.LastName);
                        lvi.SubItems.Add(customer.Address);
                        lvi.SubItems.Add(customer.Suburb);
                        lvi.SubItems.Add(customer.State);
                        lvi.SubItems.Add(customer.PostCode.ToString());
                        lvi.SubItems.Add(customer.Gender);
                        lvi.SubItems.Add(customer.BirthDate.ToString());
                        lvCustomers.Items.Add(lvi);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unsuccessful" + ex);
            }
            
           
        }

        private void frmCustomers_Load(object sender, EventArgs e)
        {
            DisplayCustomers();
        }

        private void btnAddCustomers_Click(object sender, EventArgs e)
        {
            frmAddCustomers customersAdd = new frmAddCustomers();
            customersAdd.Show();
            this.Hide();
        }
    }      
}

