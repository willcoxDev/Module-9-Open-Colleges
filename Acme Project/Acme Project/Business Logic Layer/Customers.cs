using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme_Project.Business_Logic_Layer
{
    class Customer
    {
        //Declare properties of a Customer
        private string firstName, lastName, gender, address,
                       suburb, state;
        private int customerID, categoryID, postCode;
        private DateTime birthDate;


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
            get { return categoryID; }
            set { categoryID = value; }
        }
        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

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
