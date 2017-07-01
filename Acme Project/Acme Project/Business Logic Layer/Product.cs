using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    public class Product
    {
        
        //Declare properties of a Customer
        
        public int ProductID { get; set; }
        public int ProductTypeID { get; set; }
        public string ProductName { get; set; }
        public decimal YearlyPremium { get; set; }

        //Declaring Default Constructor
        public Product() { }

        //Parameterised Constructor
        public Product(int productid, int producttypeid, string productname, decimal yearlypremium)
        {
            ProductID = productid;
            ProductTypeID = producttypeid;
            ProductName = productname;
            YearlyPremium = yearlypremium;          
        }
        
    }
}

   