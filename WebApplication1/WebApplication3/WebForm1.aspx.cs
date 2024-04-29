using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 'Pavan-Dell1234';Database = Practice; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("insert into p1 values('" + TextBox1.Text + "','" + int.Parse(TextBox2.Text) + "')", con);
            con.Open();

            int rowsaffected = cmd.ExecuteNonQuery();

            if (rowsaffected > 0)
            {
                Response.Write("User successfull added");
            }
            else
            {
                Response.Write("Error");
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source = 'Pavan-Dell1234';Database = Practice; Integrated Security = true");
            SqlCommand cmd = new SqlCommand("update p1 set age = '" + int.Parse(TextBox4.Text) + "' where ename = '" + TextBox3.Text + "'", con);
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
            SqlCommand cmd = new SqlCommand("delete from p1 where ename = '" + TextBox5.Text + "'", con);
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