using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Acme_Project.Data_Access_Layer
{
    class ConnectionManager
    {
        /* Establishing connection between the application and database
                * Instantiating SqlConnection object */
        public static SqlConnection DatabaseConnection()
        {

            string connection = "Data Source=DESKTOP-L13P49H\\SQLEXPRESS;Initial Catalog=Acme;User ID=sa;Password=sqlexpress";
            try
            {
                SqlConnection conn = new SqlConnection(connection); 
                conn.Open();
                return conn;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                throw;
            }
            
        }

        
    }
}
