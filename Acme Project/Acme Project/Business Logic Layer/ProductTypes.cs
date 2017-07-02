using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    public class _ProductType
    {
        //Declare properties of a Customer

        public int ProductTypeID { get; set; }
        public string ProductType{ get; set; }


        //Declaring Default Constructor
        public _ProductType() { }

        //Parameterised Constructor
        public _ProductType(int producttypeid, string producttype)
        {
            ProductTypeID = producttypeid;
            ProductType = producttype;
        }
    }
}

