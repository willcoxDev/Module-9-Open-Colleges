using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    public class _Dashboard
    {
        //Declare properties of a Customer

        public String ProductName { get; set; }
        public string ProductType { get; set; }
        public int NumSales { get; set; }

        //Declaring Default Constructor
        public _Dashboard() { }

        //Parameterised Constructor
        public _Dashboard(string productname, string productype, int numsales)
        {
            ProductName = productname;
            ProductType = productype;
            NumSales = NumSales;
        }
    }
}
