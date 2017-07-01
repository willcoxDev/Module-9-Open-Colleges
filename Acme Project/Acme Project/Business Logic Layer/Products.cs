using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    public class Products
    {
        
        //Declare properties of a Customer
        
        public int ProductID { get; set; }
        public int ProductTypeID { get; set; }
        public string ProductName { get; set; }
        public string YearlyPremium { get; set; }

        //Declaring Default Constructor
        public Products() { }

        //Parameterised Constructor
        public Products(int productid, int producttypeid, string productname, string yearlypremium)
        {
            ProductID = productid;
            ProductTypeID = producttypeid;
            ProductName = productname;
            YearlyPremium = yearlypremium;          
        }
        
    }
}

   