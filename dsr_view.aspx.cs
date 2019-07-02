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
    public partial class dsr_view : System.Web.UI.Page
      {
        SqlConnection con;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
            SqlConnection con;
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT Person,Reguarding,Instructions FROM instructions", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();

            con.Close();
        }

        protected void CreateInstruction_Click(object sender, EventArgs e)
        {
            Response.Redirect("dsr.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}