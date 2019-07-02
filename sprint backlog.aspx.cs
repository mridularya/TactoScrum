using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace scrum
{
    public partial class sprint_backlog : System.Web.UI.Page
    {
        string se;
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
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
                if(Session["username"]==null || Session["password"] == null)
                {
                    Response.Redirect("dashboard.aspx");
                }

                SqlCommand cmd1 = new SqlCommand("Select * FROM sprints");

                //   SqlCommand cmd2 = new SqlCommand("Select * FROM master where [Backlog Name]='"+ s +"'");

                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();





                SqlDataAdapter da1 = new SqlDataAdapter();
                da1.SelectCommand = cmd1;
                da1.SelectCommand.Connection = con;
                da1.Fill(dt2);
                Dd2.DataSource = dt2;
                Dd2.DataTextField = "id";
                Dd2.DataValueField = "id";
                Dd2.DataBind();
                Dd2.Items.Insert(0, new ListItem("select", ""));
               
                Dd2_SelectedIndexChanged(null, null);




            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("select Name from auth1 where username='" + Session["username"].ToString() + "'", con);
            DataTable dt4 = new DataTable();
            SqlDataAdapter dta = new SqlDataAdapter();
            dta.SelectCommand = cmd;
            dta.SelectCommand.Connection = con;
            dta.Fill(dt4);
            if (dt4.Rows.Count > 0)
            {
                se = dt4.Rows[0][0].ToString();
            }




            string taskheader = TbHeader.Text;
            string s2 = Dd2.SelectedValue.ToString();

            string s3 = Dd3.SelectedValue.ToString();
            string s4 = Dd4.SelectedValue.ToString();
            string s5 = Dd5.SelectedValue.ToString();
            string s6 = "_";
            string x = s2 + s6 + s3;
            x = x.Replace(" ", string.Empty);

            if (Dd2.SelectedItem.ToString() == "select")
            {
                Response.Write("<script>alert('cannot creat task for empty sprint')</script>");
            }
            else
            {
                con.Open();
                // SqlDataAdapter da3 = new SqlDataAdapter();

                SqlCommand cmd3 = new SqlCommand("insert into Sprint_backlog([sprint number],Developer,feature,[start date],deadline,priority,status,remarks,[task Header]) values ('" + Dd2.SelectedValue.ToString() + "','" + se + "','" + s3 + "','" + date1.Text + "','" + date2.Text + "','" + s4 + "' ,'" + s5 + "' ,'" + Ta1.Text + "' , '"+TbHeader.Text+"')", con);
                rdr = cmd3.ExecuteReader();
                con.Close();
                rdr.Close();
                con.Open();

                SqlCommand cmd4 = new SqlCommand("insert into sprintname([sprint name],backlog) values ('" + x + "','" + s2 + "')", con);
                rdr = cmd4.ExecuteReader();
                date1.Text = string.Empty;
                date2.Text = string.Empty;
                Ta1.Text = string.Empty;
            }
        }

        protected void Dd2_SelectedIndexChanged(object sender, EventArgs e)
        {

            s = Dd2.SelectedValue.ToString();
            SqlCommand cmd2 = new SqlCommand("Select backlog FROM sprints where id = '" + Dd2.SelectedItem.Value + "'");
            da2.SelectCommand = cmd2;
            da2.SelectCommand.Connection = con;
            da2.Fill(dt3);
            if (dt3.Rows.Count > 0)
            {
                selection = dt3.Rows[0]["backlog"].ToString();
            }
            DataTable dt4 = new DataTable();
            SqlCommand cmd4 = new SqlCommand("select * from master where [Backlog Name] = '" + selection + "'", con);
            da2.SelectCommand = cmd4;
            da2.SelectCommand.Connection = con;
            da2.Fill(dt4);

            Dd3.DataSource = dt4;
            Dd3.DataTextField = "feature";
            Dd3.DataValueField = "feature";
            Dd3.Items.Insert(0, new ListItem("select", ""));
            Dd3.DataBind();
            con.Close();

        }
    }
}
