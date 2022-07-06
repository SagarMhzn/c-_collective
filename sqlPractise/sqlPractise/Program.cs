using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sqlPractise
{
    class Program
    {
        static void Main(string[] args)
        {
            Program.dbConnection();
          
        }

        static void dbConnection()
        {
            string cs = "Data Source=NCCS-151\\SQLEXPRESS;Initial Catalog=dbnccs1;integrated security=true";
            SqlConnection conn = new SqlConnection(cs);
            conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                Console.WriteLine("database Connected");
                

            }
        }
    }
}
