using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
public partial class roles : System.Web.UI.Page
{
    SqlConnection con;
    string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

    int x;
    string u, p;
    protected void Page_Load(object sender, EventArgs e)
    {
        ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        con = new SqlConnection(conn);
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
            Response.Write("<script>alert('only scrum master create roles')</script>");
            Response.Redirect("dashboard.aspx");
            con.Close();


        }
    }



    protected void Button1_Click(object sender, EventArgs e)
    {
        string sel = dd2.SelectedValue.ToString();
        
     

        string insert = "insert into scrum_roles2(Name ,Email ,Mobile,Role) values ('" + tb1.Text + "','" + tb2.Text + "','" + tb3.Text + "','" + sel + "')";
        SqlCommand cmd = new SqlCommand(insert, con);
        SqlDataReader rdr1 = cmd.ExecuteReader();
        con.Close();
        tb1.Text = string.Empty;
        tb2.Text = string.Empty;
        tb3.Text = string.Empty;
    
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Redirect("dashboard.aspx");
    }
}