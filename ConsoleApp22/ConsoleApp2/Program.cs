using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = new SqlConnection("Data Source = 'Pavan-Dell1234'; Integrated Security = true");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insert into temp values ('"Text
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Console.WriteLine("Employeename : ", reader["empname"]);
            Console.ReadKey();
        }
    }
}
