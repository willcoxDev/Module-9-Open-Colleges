using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    class Categories
    {
        //Declare properties of a Customer

        public int CategoryID { get; set; }
        public string Category { get; set; }

        //Declaring Default Constructor
        public Categories() { }

        //Parameterised Constructor
        public Categories(int saleid, int categoryid, string category)
        {
            CategoryID = categoryid;
            Category = category;
        }
    }
}
