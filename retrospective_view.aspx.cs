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
    public partial class retrospective_view : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [Developer],[sprint],[Start Date],[End Date],[status],[Remarks] FROM [retrospective]", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();
            
              

            con.Close();
        }

        protected void newRet_Click(object sender, EventArgs e)
        {
            Response.Redirect("retro.aspx");
            
        }


        protected void backbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}