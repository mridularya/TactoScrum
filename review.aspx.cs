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
    public partial class review : System.Web.UI.Page
    {


        SqlDataAdapter dta;
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
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
                con.Open();
                if (Session["username"] == null && Session["password"] == null)
                {
                    Response.Redirect("login.aspx");

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
                Dd2.DataTextField = "Name";
                Dd2.DataValueField = "Name";
                Dd2.DataBind();
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

            else
            {
                Response.Redirect("login.aspx");
            }
        }

        protected void Dd2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            int CountryID = Convert.ToInt32(Dd2.SelectedValue);
            SqlCommand cmd2 = new SqlCommand("Select * FROM master where id='"+CountryID+"'");
            da2.SelectCommand = cmd2;
            da2.SelectCommand.Connection = con;
            da2.Fill(dt3);

            Dd3.DataSource = dt3;
            Dd3.DataTextField = "feature";
            Dd3.DataValueField = "feature";
            Dd3.DataBind();
            con.Close();
        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            string s1 = date1.Text;
            string s2 = Dd1.SelectedValue.ToString();
            string s3 = Dd2.SelectedValue.ToString();
            string s4 = Dd3.SelectedValue.ToString();
            string s5 = Ta2.Text;
            string s6 = Ta3.Text;
            string s7 = Dd4.SelectedValue.ToString();
            con.Open();
            string check = "select * from daily_review where developer = '" + s2 + "' and feature = '" + s4 + "' and date = '"+ s1+"'";
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
                string insert = @"insert into daily_review(date,developer,backlog,feature,[work description],difficulties,status) values ('" + s1 + "','" + s2 + "','" + s3 + "','" + s4 + "','" + s5 + "','" + s6 + "' ,'" + s7 + "')";
                SqlCommand cmd2 = new SqlCommand(insert, con);
                SqlDataReader rdr1 = cmd2.ExecuteReader();
                con.Close();
                rdr1.Close();
            }
            date1.Text = string.Empty;
            Ta2.Text = string.Empty;
            Ta3.Text = string.Empty;

        }
    }
    }
