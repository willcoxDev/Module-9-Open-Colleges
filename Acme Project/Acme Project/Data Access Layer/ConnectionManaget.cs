using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acme_Project.Data_Access_Layer
{
    class ConnectionManaget
    {
        /* Establishing connection between the application and database
                * Instantiating SqlConnection object */
        public static SqlConnection DatabaseConnection()
        {
            string connection = "Data Source=DESKTOP-L13P49H\\SQLEXPRESS;Initial Catalog=Customers;User ID=sa;Password=sqlexpress";
            SqlConnection conn = new SqlConnection(connection);
            return conn;
        }
    }
}
