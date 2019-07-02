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
    public partial class retro : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        string se;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand("select * from sprints", con);
            da.SelectCommand = cmd1;
            da.SelectCommand.Connection = con;
            da.Fill(dt1);
            sprint.Items.Insert(0, new ListItem("select", ""));
            if (dt1.Rows.Count > 0)
            {

                sprint.DataSource = dt1;
                sprint.DataTextField = "id";
                sprint.DataValueField = "id";
                sprint.DataBind();
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            if(Session["username"]==null || Session["password"]==null)
            {
                Response.Redirect("dashboard.aspx");
            }

            con.Open();
            SqlCommand cmd = new SqlCommand("select Name from auth1 where username='" + Session["username"].ToString() + "'", con);
            DataTable dt4 = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter();
            dta.SelectCommand = cmd;
            dta.SelectCommand.Connection = con;
            dta.Fill(dt4);
            if (dt4.Rows.Count > 0)
            {
                se = dt4.Rows[0][0].ToString();
            }
            SqlDataReader rdr3;
            string insert = @"insert into retrospective(Developer,sprint,[Start Date],[End Date],status,Remarks) values ('" +se+ "' , '" + sprint.Text + "', '" + startdate.Text + "' , '" + enddate.Text + "' , '" + status.SelectedValue.ToString() + "' , '" + Remarks.Text + "') ";
            SqlCommand cmd3 = new SqlCommand(insert, con);
            rdr3 = cmd3.ExecuteReader();
            con.Close();
            Response.Redirect("retrospective_view.aspx");

        }
    }
}