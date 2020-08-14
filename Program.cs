using System;
using System.Data;
using System.Data.SqlClient;

namespace ConnectingToDb
{
    class Program
    {
        static void Main(string[] args)
        {
            string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Nebula;Integrated Security=True;
                                Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;
                                MultiSubnetFailover=False";
            

            //Create Connection and prepare sql query
            SqlConnection conn = new SqlConnection(connString);
            string sql = @"UPDATE Employee 
                            set email = CONCAT(LEFT(email,CHARINDEX('@',email)),'company.co.za') 
                             WHERE email IS NOT NULL";
            

            try
            {
                //open connection
                conn.Open();
                Console.WriteLine("Database connection state: {0}",conn.State);

                //prepare to query the database
                SqlCommand cmd = new SqlCommand(sql, conn);

                //execute the update command 
                cmd.ExecuteNonQuery();

                Console.WriteLine("Emails updated successfully!");

            }
            catch(SqlException e)
            {
                Console.WriteLine("There was an error while communicating with the database, Error: {0}", e.Message);
            }
            finally{
                
                //Close DB connection
                conn.Close();
                Console.WriteLine("Database connection state: {0}",conn.State);
            }
           
        }
    }
}
