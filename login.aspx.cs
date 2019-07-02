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
    public partial class WebForm8 : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            SqlCommand cmd = new SqlCommand("select * from auth1 where username=@name and password=@password", con);
            cmd.Parameters.AddWithValue("@name",tb1.Text);
            cmd.Parameters.AddWithValue("@password",tb2.Text);
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (dt.Rows.Count > 0)
            {
                Session["username"] = tb1.Text;
                Session["password"] = tb2.Text;
               
                Response.Redirect("dashboard.aspx");
            }
            else
            {
                Response.Write("<script>alert('Id or Password Does not Match')</script>");

            }
        }
    }
}