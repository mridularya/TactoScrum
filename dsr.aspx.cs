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
    public partial class dsr : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        SqlDataAdapter da2 = new SqlDataAdapter();
        DataTable dt3 = new DataTable();
        string s;
        string selection;
        protected void Page_Load(object sender, EventArgs e)
        {

            con = new SqlConnection(conn);
            if (!IsPostBack)
            {
                Dd2.Items.Insert(0, "select");
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Select * FROM scrum_roles2");
                SqlDataAdapter da1 = new SqlDataAdapter();
                SqlCommand cmd1 = new SqlCommand("Select * FROM sprints");

                //   SqlCommand cmd2 = new SqlCommand("Select * FROM master where [Backlog Name]='"+ s +"'");

                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();

                da.SelectCommand = cmd;
                da.SelectCommand.Connection = con;
                da.Fill(dt1);
                Dd1.DataSource = dt1;
                Dd1.DataTextField = "Name";
                Dd1.DataValueField = "Name";
                Dd1.DataBind();
                da1.SelectCommand = cmd1;
                da1.SelectCommand.Connection = con;
                da1.Fill(dt2);
                Dd2.DataSource = dt2;
                Dd2.DataTextField = "id";
                Dd2.DataValueField = "id";
                Dd2.DataBind();
                Dd2.Items.Insert(0, new ListItem("General", "General"));
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string insert = "insert into instructions(Person,Reguarding,instructions) values('" + Dd1.SelectedValue.ToString() + "','" + Dd2.SelectedValue.ToString() + "','" + Ta1.Text + "')";
            SqlCommand cmd3 = new SqlCommand(insert, con);
            SqlDataReader rdr3;
            rdr3 = cmd3.ExecuteReader();
            con.Close();
            Ta1.Text = string.Empty;

            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("masterboard.aspx");
        }
    }
}