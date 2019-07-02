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
    public partial class sprint1 : System.Web.UI.Page
    {
        SqlConnection con;
        string s1;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            if (!IsPostBack)
            {
                con.Open();
                if (Session["username"] == null && Session["password"] == null)
                {
                    Response.Redirect("dashboard.aspx");
                }
                DataTable var = new DataTable();
                SqlDataAdapter vAR = new SqlDataAdapter("select * from scrum_master1 where Username = '" + Session["username"] + "' and Password = '" + Session["password"] + "' ", con);
                vAR.Fill(var);
                if (var.Rows.Count == 0)
                {
                    Response.Write("<script>alert('only scrum master create sprints')</script>");
                    Response.Redirect("dashboard.aspx");
                    

                }
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Select * FROM product_backlog");
                DataTable dt1 = new DataTable();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = con;
                da.Fill(dt1);
                Dd2.DataSource = dt1;
                Dd2.DataTextField = "Name";
                Dd2.DataValueField = "Name";
                Dd2.DataBind();
              //  s1 = Dd2.SelectedValue.ToString();
                Dd2_SelectedIndexChanged(null, null);
            }


          


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string s1 = Dd2.SelectedValue.ToString();
            string s2 = Tbx.Text;
            string s3 = date1.Text;
            string s4 = date2.Text;
            string s5 = Dd4.SelectedValue.ToString();
            string s6 = Ta1.Text;
            string s7 = "Running";
            //string insert = "insert into sprint(backlog,sprint,start_date,deadline,priority,remarks) values('" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "','" + s5 + "','" + s6 + "')";
            SqlCommand cmd = new SqlCommand(@"insert into sprints(Backlog,Sprint,Creation,Deadline,Priority,Remarks,status) values('" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "','" + s5 + "','" + s6 + "', '"+s7+"')", con);
            SqlDataReader rdr = cmd.ExecuteReader();
            rdr.Close();
            con.Close();
            Response.Redirect("dashboard.aspx");
            Session["status"] = "sp";
        }

        protected void Dd2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}