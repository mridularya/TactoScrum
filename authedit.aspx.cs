using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace scrum
{
    public partial class authedit : System.Web.UI.Page
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
                SqlCommand cmdd = new SqlCommand("select * from auth1", con);
                SqlDataAdapter verifyempty = new SqlDataAdapter();
                verifyempty.SelectCommand = cmdd;
                verifyempty.SelectCommand.Connection = con;
                DataTable emptytest = new DataTable();
                verifyempty.Fill(emptytest);
                if (emptytest.Rows.Count == 0)
                {
                    Response.Redirect("dashboard.aspx");
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
                    adapt = new SqlDataAdapter(@"SELECT Name,username,password,id from auth1 where username != 'sadmin' ", con);
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

           // developer = GridView1.Rows[e.RowIndex].FindControl("d_name") as Label;
            Label Name = GridView1.Rows[e.RowIndex].FindControl("Name") as Label;
            Label Uname = GridView1.Rows[e.RowIndex].FindControl("Uname") as Label;
            Label pwd = GridView1.Rows[e.RowIndex].FindControl("pwd") as Label;
            TextBox e_name = GridView1.Rows[e.RowIndex].FindControl("e_Name") as TextBox;
            TextBox e_uname = GridView1.Rows[e.RowIndex].FindControl("e_Uname") as TextBox;
            TextBox e_pwd = GridView1.Rows[e.RowIndex].FindControl("e_pwd") as TextBox;

            //updating the records 
            SqlCommand cmd = new SqlCommand(@"Update auth1 set Name='" +e_name.Text + "', username='" + e_uname.Text + "', password = '" + e_pwd.Text + "' where id = '"+Convert.ToInt32(idd.Text)+"'", con);
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
            SqlCommand retrieve = new SqlCommand("select Name from auth1 where id = '" + Convert.ToInt32(Id.Text) + "'", con);
            SqlDataAdapter dta = new SqlDataAdapter();
            DataTable dtretrive = new DataTable();
            dta.SelectCommand = retrieve;
            dta.SelectCommand.Connection = con;
            dta.Fill(dtretrive);
            if(dtretrive.Rows.Count > 0)
            {
                string del = dtretrive.Rows[0][0].ToString();
                SqlCommand cmdx = new SqlCommand("delete from scrum_master1 where Name = '" + del + "'",con);
                cmdx.ExecuteNonQuery();

            }





            SqlCommand cmd4 = new SqlCommand(@"delete from auth1 where id = '" + Convert.ToInt32(Id.Text) + "'", con);
            cmd4.ExecuteNonQuery();
            con.Close();
            ShowData();
        }

    }

}