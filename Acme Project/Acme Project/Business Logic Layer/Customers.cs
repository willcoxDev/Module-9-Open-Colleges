using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    class Customers
    {
        //Declare properties of a Customer
        private string firstName, lastName, gender, address,
                       suburb, state;
        private int customerID, categoryId, postCode;
        private date


        //Set-Get properties
        public int CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }

        public string State
        {
            get { return state; }
            set { state = value; }
        }

        public int PostCode
        {
            get { return postCode; }
            set { postCode = value; }
        }

        public int CategoryID
        {
            get { return categoryId; }
            set { categoryId = value; }
        }

        //Declaring Default Constructor
        public Customers() { }

        //Parameterised Constructor
        public Customers(int customerid, int categoryid, string firstname,
                         string lastname, string category,
                         string gender, string address, string suburb,
                         string state, int postcode)
        {
            CustomerID = customerid;
            CategoryID = categoryid;
            FirstName = firstname;
            LastName = lastname;
            Category = category;
            Gender = gender;
            Address = address;
            Suburb = suburb;
            State = state;
            PostCode = postcode;
        }
    }
}
