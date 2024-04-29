using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Data.SqlClient;
using System.Data;
using first_mvc.Models;

namespace first_mvc.Repository
{
    public class EmpRepository
    {
        private SqlConnection con;
        private void connection()
        {
            string constr = ConfigurationManager.ConnectionStrings["getconn"].ToString();
            con = new SqlConnection(constr);
        }
        public bool AddEmployee(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("AddNewEmpDetails",con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name",obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("@Address1", obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if (i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<EmpModel>GetAllEmployees()
        {
            connection();
            List<EmpModel> EmpList = new List<EmpModel> ();

            SqlCommand com = new SqlCommand("GetEmployees", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();

            con.Open ();
            da.Fill (dt);
            con.Close();

            foreach(DataRow dr in dt.Rows)
            {
                EmpList.Add(
                    new EmpModel
                    {
                        Empid = Convert.ToInt32(dr["Id"]),
                        Name = Convert.ToString(dr["Name"]),
                        City = Convert.ToString(dr["City"]),
                        Address = Convert.ToString(dr["Address"])
                    }
                    );
            }
            return EmpList;
        }
        public bool UpdateEmployee(EmpModel obj)
        {
            connection();
            SqlCommand com = new SqlCommand("UpdateEmpDetails", con);

            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@id",obj.Empid);
            com.Parameters.AddWithValue("@name", obj.Name);
            com.Parameters.AddWithValue("@City", obj.City);
            com.Parameters.AddWithValue("Address1",obj.Address);

            con.Open();
            int i = com.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool DeleteEmployee(int Id)
        {
            connection();
            SqlCommand com = new SqlCommand("DeleteEmpId", con);

            com.CommandType= CommandType.StoredProcedure;
            com.Parameters.AddWithValue("EmpId",Id);

            con.Open() ;
            int i = com.ExecuteNonQuery();
            con.Close();
            if(i >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}