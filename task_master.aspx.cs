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

    public partial class task_master : System.Web.UI.Page
    {
        Label idd;
        Label developer;
        string p = "";
        string u = "";

        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        SqlDataAdapter adapt;
        DataTable dt, dt1, dt2, dt3;
        DataTable var;
        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);
            if (!IsPostBack)
            {
               
                con.Open();
                SqlCommand cmdd = new SqlCommand("select * from Sprint_backlog", con);
                SqlDataAdapter verifyempty = new SqlDataAdapter();
                verifyempty.SelectCommand = cmdd;
                verifyempty.SelectCommand.Connection = con;
                DataTable emptytest = new DataTable();
                verifyempty.Fill(emptytest);
                if(emptytest.Rows.Count < 0)
                {
                    Response.Write("<script>alert('no tasks currently')</script>");
                }



                if (Session["username"] == null || Session["password"] == null)
                {
                    Response.Redirect("dashboard.aspx");
                }


                ShowData();
                con.Close();
            }
        }
        //ShowData method for Displaying Data in Gridview  
        protected void ShowData()



        {
           
            
                SqlDataAdapter db = new SqlDataAdapter();
                SqlCommand cmd1 = new SqlCommand("Select * from scrum_master1 where Username = '" + Session["username"].ToString() + "'", con);
                dt2 = new DataTable();
                db.SelectCommand = cmd1;
                db.SelectCommand.Connection = con;
                db.Fill(dt2);
                {
                    if (dt2.Rows.Count != 0)
                    {
                        DataTable dt4 = new DataTable();
                        adapt = new SqlDataAdapter(@"SELECT [sprint number],[Developer],[task Header],[feature],[start date],[deadline],[priority],[status] ,[remarks],id from Sprint_backlog", con);
                        adapt.Fill(dt4);
                        if (dt4.Rows.Count > 0)
                        {
                            GridView1.DataSource = dt4;
                            GridView1.DataBind();
                            con.Close();
                        }
                    else
                    {
                        Response.Redirect("dashboard.aspx");
                    }

                    }

                    else
                    {


                        SqlDataAdapter da = new SqlDataAdapter();

                        SqlCommand cmd3= new SqlCommand("Select Name from auth1 where username = '" + Session["username"].ToString() + "'", con);
                        dt1 = new DataTable();
                        da.SelectCommand = cmd3;
                        da.SelectCommand.Connection = con;
                        da.Fill(dt1);
                        if (dt1.Rows.Count == 0)
                        {
                            Response.Redirect("dashboard.aspx");
                        }

                        string s = dt1.Rows[0]["Name"].ToString();


                        dt = new DataTable();
                        adapt = new SqlDataAdapter(@"SELECT [sprint number],[Developer],[feature],[task Header],[start date],[deadline],[priority],[status] ,[remarks],id from Sprint_backlog where [Developer]='" + s + "'", con);
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
                        Response.Write("<script>alert('developer has no pending tasks')</script>");
                    }

                    }
                }
            }


        protected void GridView1_RowEditing(object sender, System.Web.UI.WebControls.GridViewEditEventArgs e)
        {




            GridView1.EditIndex = e.NewEditIndex;
            ShowData();
            con.Close();

        }
        protected void GridView1_RowUpdating(object sender, System.Web.UI.WebControls.GridViewUpdateEventArgs e)
        {
            con.Open();
            //Finding the controls from Gridview for the row which is going to update  
            idd = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;

            developer = GridView1.Rows[e.RowIndex].FindControl("d_name") as Label;
            Label sprintt = GridView1.Rows[e.RowIndex].FindControl("sprint") as Label;
            Label feature = GridView1.Rows[e.RowIndex].FindControl("feat") as Label;
            Label deadline = GridView1.Rows[e.RowIndex].FindControl("dline") as Label;
            Label creation = GridView1.Rows[e.RowIndex].FindControl("cd") as Label;
            DropDownList priority = GridView1.Rows[e.RowIndex].FindControl("e_pr") as DropDownList;
            TextBox status = GridView1.Rows[e.RowIndex].FindControl("status") as TextBox;
            TextBox remarks = GridView1.Rows[e.RowIndex].FindControl("remarks") as TextBox;
            Label header = GridView1.Rows[e.RowIndex].FindControl("tHeader") as Label;

            //updating the records 
            SqlCommand cmd = new SqlCommand(@"Update Sprint_backlog set [sprint number]='" + sprintt.Text + "', Developer='" + developer.Text + "',feature = '" + feature.Text + "' ,[start date]='" + creation.Text + "' ,deadline='" + deadline.Text + "', priority='" + priority.SelectedItem.ToString() + "', remarks ='" + remarks.Text + "' , status = '" + status.Text + "' ,  [task Header] = '" + header.Text + "'  where ID=" + Convert.ToInt32(idd.Text), con);
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
            con.Open();
            Label Id = GridView1.Rows[e.RowIndex].FindControl("idd") as Label;
            SqlCommand cmd4 = new SqlCommand(@"delete from Sprint_backlog where id = '" + Convert.ToInt32(Id.Text) + "'", con);
            cmd4.ExecuteNonQuery();
            con.Close();
            ShowData();
        }


        protected void CreateTask_Click(object sender, EventArgs e)
        {
            Response.Redirect("sprint backlog.aspx");
        }

        protected void Bkbtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }

      
    }

}