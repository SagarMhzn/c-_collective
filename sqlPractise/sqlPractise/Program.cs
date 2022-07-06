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

                    //string tbl_query = "Create table tbl_student(id int not null primary key,name varchar(50),gender varchar(50), address varchar(50), faculty varchar(50))";
                    //inserting data using parameter
                    string ins_query = "insert into tbl_student (@id,@name,@gender,@address,@faculty)";

                    //SqlCommand cmd= new SqlCommand(tbl_query, conn);
                    SqlCommand cmd= new SqlCommand(ins_query, conn);

                    //taking input from the user

                    Console.WriteLine("enter your id");
                    String id = Console.ReadLine();

                    Console.WriteLine("enter your name");
                    String name = Console.ReadLine();

                    Console.WriteLine("enter your gender");
                    String gender = Console.ReadLine();

                    Console.WriteLine("enter your address");
                    String address = Console.ReadLine();

                    Console.WriteLine("enter your faculty");
                    String faculty = Console.ReadLine();

                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@address", address);
                    cmd.Parameters.AddWithValue("@faculty", faculty);
                    int res = cmd.ExecuteNonQuery();
                    //if (res == -1)
                    //{
                    //    Console.WriteLine("table created");
                    //}

                    if(res >= 1)
                    {
                        Console.WriteLine("data Inserted in the table");
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
