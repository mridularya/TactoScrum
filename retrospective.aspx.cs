using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace scrum
{
    public partial class WebForm5 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source = ARYA-PC\SQLEXPRESS; Initial Catalog = scrum; User ID = sa; Password = 123");
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter();
            SqlCommand cmd = new SqlCommand("select * from scrum_roles2",con);
            da.SelectCommand = cmd;
            da.SelectCommand.Connection = con;
            da.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                Dd1.DataSource = dt;
                Dd1.DataTextField = "Name";
                Dd1.DataValueField = "Name";
                Dd1.DataBind();
            }

            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter();
            SqlCommand cmd1 = new SqlCommand("select * from sprints", con);
            da.SelectCommand = cmd1;
            da.SelectCommand.Connection = con;
            da.Fill(dt1);
            Dd2.Items.Insert(0, new ListItem("select", ""));
            if (dt1.Rows.Count > 0)
            {
               
                Dd2.DataSource = dt1;
                Dd2.DataTextField = "id";
                Dd2.DataValueField = "id";
                Dd2.DataBind();
            }

        }
    }
}