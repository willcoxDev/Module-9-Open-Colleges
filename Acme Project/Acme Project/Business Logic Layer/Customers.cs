using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    public class Customer
    {
        //Set-Get properties
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Gender { get; set; }

        public string Address { get; set; }

        public string Suburb { get; set; }

        public string State { get; set; }

        public int PostCode { get; set; }

        public int CategoryID { get; set; }

        public DateTime BirthDate { get; set; }


        //Declaring Default Constructor
        public Customer() { }

        //Parameterised Constructor
        public Customer(int customerid, int categoryid, string firstname,
                         string lastname,
                         string gender, string address, string suburb,
                         string state, int postcode, DateTime birthdate)
        {
            CustomerID = customerid;
            CategoryID = categoryid;
            FirstName = firstname;
            LastName = lastname;
            Gender = gender;
            Address = address;
            Suburb = suburb;
            State = state;
            PostCode = postcode;
            BirthDate = birthdate;
        }
    }
}
