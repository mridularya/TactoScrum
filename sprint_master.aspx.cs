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
    public partial class sprint_master : System.Web.UI.Page
    {
        string p = "";
        string u = "";

        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlDataAdapter adapt;
        DataTable dt;
        DataTable var;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            if (!IsPostBack)
            {

               
                if (Session["username"] == null && Session["password"] == null)
                {
                    Response.Write("<script>alert('not logged in')</script>");
                    Response.Redirect("login.aspx");
                }
                con.Open();


                ShowData();
            }
        }
        //ShowData method for Displaying Data in Gridview  
        protected void ShowData()
        {
            dt = new DataTable();
            adapt = new SqlDataAdapter("Select backlog,sprint,creation,deadline,priority,remarks,id from sprints", con);
            adapt.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
                con.Close();
            }
            else
            {
                Response.Redirect("dashboard.aspx");
            }
        }

        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {
            if (Session["username"] != null && Session["password"] != null)
            {
                u = Session["username"].ToString();
                p = Session["password"].ToString();
            }
            var = new DataTable();
            SqlDataAdapter vAR = new SqlDataAdapter("select * from scrum_master1 where Username = '" + u + "' and Password = '" + p + "' ", con);
            vAR.Fill(var);
            if (var.Rows.Count == 0)
            {
                Response.Write("<script>alert('You are not allowed to edit')</script>");
                con.Close();
            }


            else
            {


                GridView1.EditIndex = e.NewEditIndex;
                ShowData();
                con.Close();
            }
            con.Close();

        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label idd = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
            
            Label bkname = GridView1.Rows[e.RowIndex].FindControl("bk_name") as Label;
            TextBox sprintt = GridView1.Rows[e.RowIndex].FindControl("e_sprint") as TextBox;
            TextBox deadline = GridView1.Rows[e.RowIndex].FindControl("e_desc") as TextBox;
            Label creation = GridView1.Rows[e.RowIndex].FindControl("cd") as Label;
            TextBox priority = GridView1.Rows[e.RowIndex].FindControl("e_pr") as TextBox;
            TextBox remarks = GridView1.Rows[e.RowIndex].FindControl("e_r") as TextBox;

            //updating the record  
            SqlCommand cmd = new SqlCommand(@"Update sprints set backlog='" + bkname.Text + "',sprintt='" + sprintt.Text + "' ,creation='" + creation.Text + "' ,deadline='" + deadline.Text + "', priority='" + Convert.ToInt32(priority.Text) + "', remarks ='" + remarks.Text + "' where ID=" + Convert.ToInt32(idd.Text), con);
            cmd.ExecuteNonQuery();
          
            con.Close();
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            //Call ShowData method for displaying updated data  
            ShowData();
        }
        protected void GridView1_RowCancelingEdit(object sender, System.Web.UI.WebControls.GridViewCancelEditEventArgs e)
        {
            //Setting the EditIndex property to -1 to cancel the Edit mode in Gridview  
            GridView1.EditIndex = -1;
            ShowData();
        }

        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            string u = Session["username"].ToString();
            string p = Session["password"].ToString();
            var = new DataTable();
            SqlDataAdapter vAR = new SqlDataAdapter("select Name from scrum_master1  where Username = '" + u + "' and Password = '" + p + "' ", con);
            vAR.Fill(var);
            if (var.Rows.Count == 0)
            {
                Response.Write("<script>alert('You are not allowed to delete')</script>");
                con.Close();
            }

            else
            {
                con.Open();
                Label idd1 = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
                SqlCommand cmd4 = new SqlCommand(@"delete from sprints where id = '" + Convert.ToInt32(idd1.Text) + "'", con);
                cmd4.ExecuteNonQuery();
              
                con.Close();
                ShowData();
            }
        }



        protected void btnback_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }

}
