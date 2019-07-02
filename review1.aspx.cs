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
    public partial class review1 : System.Web.UI.Page
    {

        string se;
        SqlDataAdapter dta;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataReader rdr;
        DataTable dt;
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable dt3 = new DataTable();
        SqlDataAdapter da2 = new SqlDataAdapter();

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);

            if (!IsPostBack)
            {

                if(Session["username"]==null || Session["password"]==null)
                {
                    Response.Redirect("dashboard.aspx");
                }
               
                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Select * FROM scrum_roles2 where Role='Developer'");
                SqlDataAdapter da1 = new SqlDataAdapter();
                SqlCommand cmd1 = new SqlCommand("Select * FROM product_backlog ");
                SqlDataAdapter da2 = new SqlDataAdapter();
                //   SqlCommand cmd2 = new SqlCommand("Select * FROM master where [Backlog Name]='"+ s +"'");

                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                //da.SelectCommand = cmd;
                //da.SelectCommand.Connection = con;
                //da.Fill(dt1);
                //Dd1.DataSource = dt1;
                //Dd1.DataTextField = "Name";
                //Dd1.DataValueField = "Name";
                //Dd1.DataBind();
                da1.SelectCommand = cmd1;
                da1.SelectCommand.Connection = con;
                da1.Fill(dt2);
                Dd2.DataSource = dt2;  
                Dd2.DataTextField = "Name";
                Dd2.DataValueField = "Name";
             
                Dd2.DataBind();
                Dd2.Items.Insert(0, new ListItem("select", ""));
                              
                //Dd2_SelectedIndexChanged(null, null);

                // s = Dd2.SelectedValue.ToString();
                //SqlCommand cmd2 = new SqlCommand("Select * FROM master");
                //da2.SelectCommand = cmd2;
                //da2.SelectCommand.Connection = con;
                //da2.Fill(dt3);

                //Dd3.DataSource = dt3;
                //Dd3.DataTextField = "feature";
                //Dd3.DataValueField = "feature";
                //Dd3.DataBind();
                //con.Close();
            }
        }




        protected void Button1_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("select Name from auth1 where username='" + Session["username"].ToString() + "'",con);
            DataTable dt4 = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter();
            dta.SelectCommand = cmd;
            dta.SelectCommand.Connection = con;
            dta.Fill(dt4);
            if(dt4.Rows.Count > 0)
            {
                se = dt4.Rows[0][0].ToString();
            }


            string s1 = date1.Text;
           // string s2 = Dd1.SelectedValue.ToString();
            string s3 = Dd2.SelectedValue.ToString();
            string s4 = Dd3.SelectedValue.ToString();
            string s5 = Ta2.Text;
            string s6 = Ta3.Text;
            string s7 = Dd4.SelectedValue.ToString();
            con.Open();
            string check = "select * from daily_review where developer = '" + se + "' and feature = '" + s4 + "' and date = '" + s1 + "'";
            SqlCommand cmd1 = new SqlCommand(check, con);
            rdr = cmd1.ExecuteReader();
            if (rdr.HasRows)
            {
                Response.Write("<script>alert('Your review for today has been submitted')</script>");
                con.Close();
                rdr.Close();
            }
            else
            {
                rdr.Close();
                string insert = @"insert into daily_review(date,developer,backlog,feature,[work description],difficulties,status) values ('" + s1 + "','" + se + "','" + s3 + "','" + s4 + "','" + s5 + "','" + s6 + "' ,'" + s7 + "')";
                SqlCommand cmd2 = new SqlCommand(insert, con);
                SqlDataReader rdr1 = cmd2.ExecuteReader();
                con.Close();
                rdr1.Close();
            }
            date1.Text = string.Empty;
            Ta2.Text = string.Empty;
            Ta3.Text = string.Empty;

        }

        protected void Dd2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = Dd2.SelectedValue.ToString();

            SqlCommand cmd3 = new SqlCommand("select * from master where [Backlog Name] = '" + s + "'", con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd3);
                DataTable dtx = new DataTable();
                sda.Fill(dtx);
                Dd3.DataTextField = "feature";
                Dd3.DataValueField = "feature";

                Dd3.DataSource = dtx;
                Dd3.DataBind();
            
        }
    }
}
