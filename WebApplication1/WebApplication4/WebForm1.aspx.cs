using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 'Pavan-Dell1234';Database = Practice; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("spp2",con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "insert");
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@mobile",TextBox3.Text);
            con.Open();

            int rowsaffected = cmd.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                Response.Write("User insert successfull");
            }
            else
            {
                Response.Write("Error");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 'Pavan-Dell1234';Database = Practice; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("spp2", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "update");
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@mobile", TextBox3.Text);
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            con.Open();

            int rowsaffected = cmd.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                Response.Write("User update successfull");
            }
            else
            {
                Response.Write("Error");
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 'Pavan-Dell1234';Database = Practice; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("spp2", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@action", "delete");
            cmd.Parameters.AddWithValue("@email", (TextBox2.Text));
            cmd.Parameters.AddWithValue("@mobile",(TextBox3.Text));
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            con.Open();

            int rowsaffected = cmd.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                Response.Write("User delete successfull");
            }
            else
            {
                Response.Write("Error");
            }
        }
    }
}