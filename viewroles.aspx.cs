using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Configuration;

    public partial class viewroles : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataReader rdr;
    string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    protected void Page_Load(object sender, EventArgs e)
        {
        if(Session["username"]==null || Session["password"]==null)
        {
            Response.Redirect("dashboard.aspx");
        }
          
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand("select Name,Email,Mobile,Role from scrum_roles2", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();
            con.Close();
        }


    protected void CreateRole_Click(object sender, EventArgs e)
    {
        Response.Redirect("roles.aspx");
    }

    protected void back_Click(object sender, EventArgs e)
    {
        Response.Redirect("dashboard.aspx");
    }
}