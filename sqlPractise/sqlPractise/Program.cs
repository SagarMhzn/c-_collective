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
            
            try
            {
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    Console.WriteLine("database Connected");
                    //adding new table tbl_student

                    string tbl_query = "Create table tbl_student(id int not null primary key,name varchar(50),gender varchar(50), address varchar(50), faculty varchar(50))";
                    SqlCommand cmd= new SqlCommand(tbl_query, conn);
                    int res = cmd.ExecuteNonQuery();
                    if (res == -1)
                    {
                        Console.WriteLine("table created");
                    }
                }
                else
                {
                    Console.WriteLine("database connection failed");
                }
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
