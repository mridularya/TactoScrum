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
    public partial class sprint_view : System.Web.UI.Page
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
            adapt = new SqlDataAdapter(@"SELECT [Backlog],[Sprint],[Creation],[Deadline],[Priority],[Remarks],[Status],[id] FROM [sprints]", con);
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


            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
            con.Close();
        }

        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            //Finding the controls from Gridview for the row which is going to update  
            Label idd = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
            Label bklog = GridView1.Rows[e.RowIndex].FindControl("bknm") as Label;
            TextBox sprintt = GridView1.Rows[e.RowIndex].FindControl("e_sprint") as TextBox;
            Label cd = GridView1.Rows[e.RowIndex].FindControl("cd") as Label;
            TextBox e_dd = GridView1.Rows[e.RowIndex].FindControl("e_deadline") as TextBox;
            TextBox pr = GridView1.Rows[e.RowIndex].FindControl("e_pr") as TextBox;
            TextBox remarks = GridView1.Rows[e.RowIndex].FindControl("e_remarks") as TextBox;
            TextBox status = GridView1.Rows[e.RowIndex].FindControl("e_status") as TextBox;
            SqlCommand cmd = new SqlCommand(@"Update sprints set [backlog]='" + bklog.Text + "',[sprint]='" + sprintt.Text + "' ,creation='" + cd.Text + "' ,deadline='" + e_dd.Text + "',remarks='" + remarks.Text + "',priority='" + Convert.ToInt32(pr.Text) +"' , status ='" + status.Text + "'  where id='" + Convert.ToInt32(idd.Text) + "'", con);
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

                Label idd1 = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
                SqlCommand cmd4 = new SqlCommand(@"delete from sprints where id = '" + Convert.ToInt32(idd1.Text) + "'", con);
                cmd4.ExecuteNonQuery();
                con.Close();
                ShowData();
        }



        protected void back_Click(object sender, EventArgs e)
        {
            Response.Redirect("masterboard.aspx");
        }
    }
}
