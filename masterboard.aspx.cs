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
       
    public partial class masterboard : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            con.Open();
            if (Session["username"] == null || Session["password"] == null)
            {
                Response.Redirect("dashboard.aspx");
            }
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select * from scrum_master1 where Username = '" + Session["username"].ToString() + "' and password = '" + Session["password"] + "'", con);
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            da.Fill(dt);
            if(dt.Rows.Count == 0 )
            {
                Response.Redirect("dashboard.aspx");
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table notes", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table retrospective", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
           
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("dsr.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("authedit.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("product_master.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("sprint_view.aspx");



        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table retrospective",con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table scrum_roles2", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table daily_review", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table Sprint_backlog", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table sprints", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table product_backlog", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Button2_Click1(object sender, EventArgs e)
        {
            SqlDataReader rdr;
            SqlCommand cmd = new SqlCommand("truncate table instructions", con);
            rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("authedit.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("auth.aspx");
        }
    }
}