using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace scrum
{
    public partial class view_review : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataReader rdr;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [Date],[Developer],[Backlog],[Feature],[Work Description],[Difficulties],[Status] FROM daily_review", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();
                if(gv1.Rows.Count == 0)
            {
                Response.Redirect("dashboard.aspx");
            }

            con.Close();
        }

        protected void Mkreview_Click(object sender, EventArgs e)
        {
            Response.Redirect("review1.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}