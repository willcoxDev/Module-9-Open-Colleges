using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    class Sales
    {
        //Declare properties of a Customer

        public int SaleID { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string Payable { get; set; }
        public DateTime StartDate { get; set; }


        //Declaring Default Constructor
        public Sales() { }

        //Parameterised Constructor
        public Sales(int saleid, int customerid, int productid, string payable, DateTime startdate)
        {
            SaleID = saleid;
            CustomerID = customerid;
            ProductID = productid;
            Payable = payable;
            StartDate = startdate;
        }
    }
}
