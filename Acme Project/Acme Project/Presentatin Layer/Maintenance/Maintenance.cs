using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acme_Project.Data_Access_Layer;
using Acme_Project.Business_Logic_Layer;
using Acme_Project.Customers;
using Acme_Project.Categories;
using Acme_Project.Presentatin_Layer.Products;

namespace Acme_Project.Presentatin_Layer
{
    public partial class frmMaintenance : Form
    {
        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmCustomers mainCustomers = new frmCustomers();
            mainCustomers.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            frmMainProducts mainProducts = new frmMainProducts();
            mainProducts.ShowDialog();
        }
    }
}
