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
    public partial class sprintv : System.Web.UI.Page
    {
        SqlConnection con;
        SqlDataReader rdr;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;


        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            if (Session["username"] == null || Session["password"] == null)
            {
                Response.Redirect("dashboard.aspx");
            }
            con = new SqlConnection(@"Data Source = ARYA-PC\SQLEXPRESS; Initial Catalog = scrum; User ID = sa; Password = 123");
            con.Open();
            SqlCommand cmd = new SqlCommand(@"SELECT [Backlog],[Sprint],[Creation],[Deadline],[Priority] ,[Remarks] ,[Status] FROM sprints", con);
            rdr = cmd.ExecuteReader();
            gv1.DataSource = rdr;
            gv1.DataBind();
            if(gv1.Rows.Count==0)
            {
                Response.Redirect("dashboard.aspx");
            }

            con.Close();
        }

        protected void CreateSprint_Click(object sender, EventArgs e)
        {
            Response.Redirect("sprint1.aspx");
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}