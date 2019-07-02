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
    public partial class viewtasks : System.Web.UI.Page
    {

        string constr = @"Data Source = ARYA-PC\SQLEXPRESS; Initial Catalog = scrum; User ID = sa; Password = 123";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                this.BindGrid();
            }

        }


        private void BindGrid()
        {
            string constr = @"Data Source = ARYA-PC\SQLEXPRESS; Initial Catalog = scrum; User ID = sa; Password = 123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand("SELECT feature,description,acceptence,deadline FROM master"))
                {
                    using (SqlDataAdapter sda = new SqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            GridView1.DataSource = dt;
                            GridView1.DataBind();
                        }
                    }
                }
            }
        }

        protected void OnRowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            this.BindGrid();
        }

        protected void OnRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow row = GridView1.Rows[e.RowIndex];
            int reference = Convert.ToInt32(GridView1.DataKeys[e.RowIndex].Values[0]);
            string fname  = (row.Cells[1].Controls[0] as TextBox).Text;
            string description = (row.Cells[2].Controls[0] as TextBox).Text;
            string acceptence = (row.Cells[3].Controls[0] as TextBox).Text;
            string deadline = (row.Cells[4].Controls[0] as TextBox).Text;


            using (SqlConnection con = new SqlConnection(constr))
            { 
                if()
                using (SqlCommand cmd = new SqlCommand("UPDATE master SET Name = @Name, Country = @Country WHERE CustomerId = @CustomerId"))
                {
                    cmd.Parameters.AddWithValue("@CustomerId", customerId);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Country", country);
                    cmd.Connection = con;
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            GridView1.EditIndex = -1;
            this.BindGrid();
        }

    }
}