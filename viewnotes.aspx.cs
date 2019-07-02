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
    public partial class viewnotes : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataReader rdr;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Person,Sprint,Date,Subject,Note FROM notes", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();

            con.Close();
        }

        protected void Createnotes_Click(object sender, EventArgs e)
        {
            Response.Redirect("createnotes.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}