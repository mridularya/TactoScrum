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
    public partial class dashboard : System.Web.UI.Page
    {
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlConnection con;
        SqlDataAdapter dta;
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {

             con = new SqlConnection(conn);
            if (Session["status"] != null && Session["status"].ToString()=="sp")
            {
                Response.Write("Sprint Created Successfully");
            }
            con.Open();
            if (Session["username"] != null && Session["password"] != null)
            {
                string s = Session["username"].ToString();
                string p = Session["password"].ToString();
                dta = new SqlDataAdapter("select * from auth1 where username='" + s + "' and password='" + p + "'", con);
                dta.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    SqlDataAdapter dtcheck = new SqlDataAdapter("select * from scrum_master1 where Username = '"+s+"' and password='"+p+"'",con);
                    DataTable check = new DataTable();
                    dtcheck.Fill(check);
                    {
                        if(check.Rows.Count == 0)
                        {
                            masterdiv.Visible = false;
                        }
                    }
                    
                }

                else
                {
                    Response.Write("<script>alert('you must be logged in ')</script>");
                    Response.Redirect("login.aspx");
                }


            }
            else
            {
                Response.Write("<script>alert('you must be logged in ')</script>");
                Response.Redirect("login.aspx");
            }
        }

        protected void retrobtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("retrospective_view.aspx");

        }


        protected void userbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewroles.aspx");
        }

        protected void dailyrbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("view_review.aspx");
        }

        protected void taskbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("task_master.aspx");
        }

        protected void sprintbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("sprintv.aspx");
        }

        protected void pbbutton_Click(object sender, EventArgs e)
        {
            Response.Redirect("pb.aspx");
        }

        protected void notebtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewnotes.aspx");
        }

        protected void instructbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("dsr_view.aspx");
        }

        protected void masterbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("masterboard.aspx");
        }


    
    }
}