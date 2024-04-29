using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Visibility(object sender, EventArgs e)
        {
            GridView1.Visible = !GridView1.Visible;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Visible = true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            GridView1.Visible = true;
            Visible = true;
        }

        protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {

        }
    }
}