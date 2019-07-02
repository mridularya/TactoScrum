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
    public partial class createnotes : System.Web.UI.Page
    {
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["username"]==null || Session["password"]==null)
            {
                Response.Redirect("dashboard.aspx");
            }

            con = new SqlConnection(conn);
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("Select * FROM scrum_roles2");
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand("Select * FROM sprints");
            SqlDataAdapter da2 = new SqlDataAdapter();
            //   SqlCommand cmd2 = new SqlCommand("Select * FROM master where [Backlog Name]='"+ s +"'");

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            da.Fill(dt1);
            Developer.DataSource = dt1;
            Developer.DataTextField = "Name";
            Developer.DataValueField = "Name";
            Developer.DataBind();
            da1.SelectCommand = cmd1;
            da1.SelectCommand.Connection = con;
            da1.Fill(dt2);
            sprint.DataSource = dt2;
            sprint.DataTextField = "id";
            sprint.DataValueField = "id";
            sprint.DataBind();
            sprint.Items.Insert(0, new ListItem("General Tasks", "General Tasks"));
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert = @"insert into notes(Person,Sprint,Date,Subject,Note) values ('" +Developer.SelectedValue.ToString()+ "','" + sprint.SelectedValue.ToString() + "','" + dated.Text + "','" + SUBLINE.Text + "','" + notes.Text + "')";
            SqlCommand cmd2 = new SqlCommand(insert, con);
            SqlDataReader rdr1 = cmd2.ExecuteReader();
            con.Close();
            rdr1.Close();
        }

        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}