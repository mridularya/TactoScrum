using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace scrum
{
    public partial class pb : System.Web.UI.Page
    {

        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);

            if(Session["username"]==null || Session["password"] == null)
            {
                Response.Redirect("dashboard.aspx");
            }
            
            con.Open();
            SqlCommand cmd = new SqlCommand(@"Select [Backlog Name], Feature, Description, Acceptence,[Creation Date], Deadline, Priority from master", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();
            if(gv1.Rows.Count==0)
            {
                Response.Redirect("dashboard.aspx");
            }

            con.Close();
        }

        protected void pbCreateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("product backlog.aspx");
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}
        