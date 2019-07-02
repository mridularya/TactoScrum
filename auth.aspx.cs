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
    public partial class WebForm6 : System.Web.UI.Page
    {
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        TextBox t = new TextBox();
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            if (!IsPostBack)
            {

                if (Session["username"] == null || Session["password"] == null)
                {
                    Response.Redirect("login.aspx");
                }

                SqlDataAdapter da = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand("Select * FROM scrum_roles2");
                DataTable dt1 = new DataTable();
                da.SelectCommand = cmd;
                da.SelectCommand.Connection = con;
                da.Fill(dt1);
                Dd1.DataSource = dt1;
                Dd1.DataTextField = "Name";
                Dd1.DataValueField = "Name";
                Dd1.DataBind();
                Dd1.Items.Insert(0, "select");

                DataTable var = new DataTable();
                SqlDataAdapter vAR = new SqlDataAdapter("select * from scrum_master1 where Username = '" + Session["username"].ToString() + "' and password = '" + Session["password"].ToString() + "' ", con);
                vAR.Fill(var);
                if (var.Rows.Count == 0)
                {
                    Response.Redirect("dashboard.aspx");
                    con.Close();
                }

            }
           
           
            
           

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            //s1 = dd2.SelectedItem.ToString();
            if (dd2.SelectedValue.ToString() == "Scrum Master")
            {
                con.Open();
                string insert1 = "insert into scrum_master1(Username,password,Name) values('" + tb1.Text + "','" + tb2.Text + "','"+Dd1.SelectedItem.ToString()+"')";
                SqlCommand cmd1 = new SqlCommand(insert1, con);
                SqlDataReader rdr;
                rdr = cmd1.ExecuteReader();
                rdr.Close();
                string insert2 = "insert into auth1(username,password,Name) values('" + tb1.Text + "','" + tb2.Text + "','"+Dd1.SelectedItem.ToString()+"')";
                SqlCommand cmd3 = new SqlCommand(insert2, con);
                rdr = cmd3.ExecuteReader();
                rdr.Close();
                con.Close();
            }

            else
            {
                con.Open();
                string insert = "insert into auth1(username,password,Name) values('" + tb1.Text + "','" + tb2.Text + "' , '"+Dd1.SelectedValue.ToString()+"')";
                SqlCommand cmd2 = new SqlCommand(insert, con);
                SqlDataReader rdr1;
                rdr1 = cmd2.ExecuteReader();
                con.Close();
                
            }
            tb2.Text = string.Empty;
        }

        protected void Dd1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int id = int.Parse(Dd1.SelectedValue.ToString());

        }
    }
}