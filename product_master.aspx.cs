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
    public partial class product_master : System.Web.UI.Page
    {
        string p = "";
        string u = "";
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        SqlConnection con; 
        SqlDataAdapter adapt;
        DataTable dt;
        DataTable var;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            con.Open();
          
            if (!IsPostBack)
            {
                ShowData();
            }
        }
        //ShowData method for Displaying Data in Gridview  
        protected void ShowData()
        {
            dt = new DataTable();
            adapt = new SqlDataAdapter("Select [Product Master Name],[Backlog Name],Feature,Description,Acceptence,[Creation Date],Deadline,Priority,id from master", con);
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
        { if (Session["username"] == null && Session["password"] == null)
            {
                Response.Redirect("dashboard.aspx");
            }
                GridView1.EditIndex = e.NewEditIndex;
                ShowData();
                con.Close();
            
        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label idd = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
            Label master = GridView1.Rows[e.RowIndex].FindControl("pm_name") as Label;
            Label bkname = GridView1.Rows[e.RowIndex].FindControl("bk_name") as Label;
            TextBox fe_name = GridView1.Rows[e.RowIndex].FindControl("fe_name") as TextBox;
            TextBox e_desc = GridView1.Rows[e.RowIndex].FindControl("e_desc") as TextBox;
            TextBox e_ac = GridView1.Rows[e.RowIndex].FindControl("e_ac") as TextBox;
            Label cd = GridView1.Rows[e.RowIndex].FindControl("cd") as Label;
            TextBox e_dd = GridView1.Rows[e.RowIndex].FindControl("e_dd") as TextBox;
            TextBox e_pr = GridView1.Rows[e.RowIndex].FindControl("e_pr") as TextBox;

            //updating the record  
            SqlCommand cmd = new SqlCommand(@"Update master set [Product Master Name]='" + master.Text + "',[Backlog Name]='" + bkname.Text + "' ,Feature='" + fe_name.Text + "' ,Description='" + e_desc.Text + "',Acceptence='" + e_ac.Text + "',[Creation Date]='" + cd.Text + "', Deadline ='" + e_dd.Text + "' , Priority='" + Convert.ToInt32(e_pr.Text) + "'where ID='"+ Convert.ToInt32(idd.Text) + "'", con);
            cmd.ExecuteNonQuery();
            SqlCommand cmd1 = new SqlCommand(@"Update features set Feature='" + fe_name.Text + "' ,Description='" + e_desc.Text + "',Acceptence='" + e_ac.Text + "' where ID=" + Convert.ToInt32(idd.Text), con);
            cmd1.ExecuteNonQuery();
            SqlCommand cmd2 = new SqlCommand(@"Update product_backlog set [Product Master Name]='" + master.Text + "',Name='" + bkname.Text + "' ,[Creation Date]='" + cd.Text + "', Deadline ='" + e_dd.Text + "' , Priority='" + Convert.ToInt32(e_pr.Text) + "'where ID=" + Convert.ToInt32(idd.Text), con);
            cmd2.ExecuteNonQuery();
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
        {    if(Session["username"]==null && Session["password"] == null)
            {
                Response.Redirect("dashboard.aspx");
            }

            string u = Session["username"].ToString();
            string p = Session["password"].ToString();
            var = new DataTable();
            SqlDataAdapter vAR = new SqlDataAdapter("select * from scrum_master1 where Username = '" + u + "' and Password = '" + p + "' ", con);
            vAR.Fill(var);
            if (var.Rows.Count == 0)
            {
                Response.Write("<script>alert('You are not allowed to delete')</script>");
                con.Close();
            }

            else
            {

                Label idd1 = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
                SqlCommand cmd4 = new SqlCommand(@"delete from master where id = '" + Convert.ToInt32(idd1.Text) + "'", con);
                cmd4.ExecuteNonQuery();
                cmd4 = new SqlCommand(@"delete from product_backlog where id = '" + Convert.ToInt32(idd1.Text) + "'", con);
                cmd4.ExecuteNonQuery();
                cmd4 = new SqlCommand(@"delete from features where id = '" + Convert.ToInt32(idd1.Text) + "'", con);
                cmd4.ExecuteNonQuery();
                con.Close();
                ShowData();
            }
        }



        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("masterboard.aspx");
        }
    }

}
