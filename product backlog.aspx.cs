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
    public partial class WebForm2 : System.Web.UI.Page
    {
        DataTable dt;
        DataTable dtCurrentTable;
        TextBox box1;
        TextBox box2;
        TextBox box3;
        SqlDataReader rdr3;
        SqlConnection con;
        string conn = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;

        string u, p;
        private void SetInitialRow()

        {

            dt = new DataTable();

            DataRow dr = null;

            dt.Columns.Add(new DataColumn("RowNumber", typeof(string)));

            dt.Columns.Add(new DataColumn("Feature", typeof(string)));

            dt.Columns.Add(new DataColumn("Description", typeof(string)));

            dt.Columns.Add(new DataColumn("Acceptence", typeof(string)));

            dr = dt.NewRow();

            dr["RowNumber"] = 1;

            dr["Feature"] = string.Empty;

            dr["Description"] = string.Empty;

            dr["Acceptence"] = string.Empty;

            dt.Rows.Add(dr);

            //dr = dt.NewRow();



            //Store the DataTable in ViewState

            ViewState["CurrentTable"] = dt;



            Gridview1.DataSource = dt;

            Gridview1.DataBind();

        }
        

        private void AddNewRowToGrid()

        {

            if (ViewState["CurrentTable"] != null)

            {

                dtCurrentTable = (DataTable)ViewState["CurrentTable"];

                DataRow drCurrentRow = null;

                if (dtCurrentTable.Rows.Count > 0)

                {

                    //for (int i = 1; i <= dtCurrentTable.Rows.Count; i++)

                    //{

                    //extract the TextBox values

                    int rowIndex = dtCurrentTable.Rows.Count;
                    try
                    {
                        box1 = (TextBox)Gridview1.Rows[rowIndex - 1].Cells[1].FindControl("TextBox1");

                        box2 = (TextBox)Gridview1.Rows[rowIndex - 1].Cells[2].FindControl("TextBox2");

                        box3 = (TextBox)Gridview1.Rows[rowIndex - 1].Cells[3].FindControl("TextBox3");
                    }
                    catch (Exception w) { }

                    drCurrentRow = dtCurrentTable.NewRow();
                    dtCurrentTable.Rows.Add(drCurrentRow);
                    drCurrentRow["RowNumber"] = dtCurrentTable.Rows.Count;

                    //if (dtCurrentTable.Rows[0][1].ToString() == "")
                    //{
                    //    dtCurrentTable.Rows[0].Delete();
                    //    dtCurrentTable.AcceptChanges();
                    //}

                    //drCurrentRow = dtCurrentTable.NewRow();

                    dtCurrentTable.Rows[dtCurrentTable.Rows.Count - 2]["RowNumber"] = dtCurrentTable.Rows.Count - 1;
                    dtCurrentTable.Rows[dtCurrentTable.Rows.Count - 2]["Feature"] = box1.Text;
                    dtCurrentTable.Rows[dtCurrentTable.Rows.Count - 2]["Description"] = box2.Text;
                    dtCurrentTable.Rows[dtCurrentTable.Rows.Count - 2]["Acceptence"] = box3.Text;


                    //dtCurrentTable.Rows.Add(drCurrentRow);

                    //drCurrentRow = dtCurrentTable.NewRow();
                    //dtCurrentTable.Rows.Add(drCurrentRow);
                    //drCurrentRow["RowNumber"] = dtCurrentTable.Rows.Count;
                    //dtCurrentTable.AcceptChanges();

                    //    rowIndex++;

                    //}

                    //dtCurrentTable.Rows.Add(drCurrentRow);

                    ViewState["CurrentTable"] = dtCurrentTable;


                    Gridview1.DataSource = dtCurrentTable;

                    Gridview1.DataBind();

                }

            }

            else

            {

                Response.Write("ViewState is null");

            }



            //Set Previous Data on Postbacks

            SetPreviousData();

        }
        private void SetPreviousData()

        {

            int rowIndex = 0;

            if (ViewState["CurrentTable"] != null)

            {

                dt = (DataTable)ViewState["CurrentTable"];

                if (dt.Rows.Count > 0)

                {

                    for (int i = 0; i < dt.Rows.Count; i++)

                    {

                        TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("TextBox1");

                        TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("TextBox2");

                        TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("TextBox3");



                        box1.Text = dt.Rows[i]["Feature"].ToString();
                        //                Session["x"] = box1.Text;
                        box2.Text = dt.Rows[i]["Description"].ToString();
                        //                Session["y"] = box2.Text;
                        box3.Text = dt.Rows[i]["Acceptence"].ToString();
                        //                Session["z"] = box3.Text;


                        rowIndex++;

                    }

                }

            }
            dt = (DataTable)ViewState["CurrentTable"];

        }
        protected void ButtonAdd_Click(object sender, EventArgs e)
        {
            AddNewRowToGrid();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(conn);

            if (!IsPostBack)
            {
                if (Session["username"] != null && Session["password"] != null)
                {
                    u = Session["username"].ToString();
                    p = Session["password"].ToString();
                }
                 DataTable var = new DataTable();
                SqlDataAdapter vAR = new SqlDataAdapter("select * from scrum_master1 where Username = '" + u + "' and Password = '" + p + "' ", con);
                vAR.Fill(var);
                if (var.Rows.Count == 0)
                {
                    Response.Write("<script>alert('only scrum master create roles')</script>");
                    Response.Redirect("dashboard.aspx");
                    con.Close();
                }
                else
                {
                    SetInitialRow();
                    SqlDataAdapter da = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand("Select * FROM scrum_roles2 where Role='Product Master'");
                    DataTable dt1 = new DataTable();
                    da.SelectCommand = cmd;
                    da.SelectCommand.Connection = con;
                    da.Fill(dt1);
                    Dd1.DataSource = dt1;
                    Dd1.DataTextField = "Name";
                    Dd1.DataValueField = "Name";
                    Dd1.DataBind();
                }
            }

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            //string pm = Dd1.SelectedValue.ToString();
            string p = Dd2.SelectedValue.ToString();
            con.Open();
            SqlDataReader rdr3;
            string check = "select * from product_backlog where Name = '" + tb1.Text + "'";
            SqlCommand cmd3 = new SqlCommand(check, con);
            rdr3 = cmd3.ExecuteReader();
            if (rdr3.HasRows)
            {
                Response.Write("<script>alert('Backlog already exists')</script>");
                rdr3.Close();
                con.Close();
            }
            else
            {
                rdr3.Close();
                string insert = "insert into product_backlog([Product Master Name],Name,[Creation Date],Deadline,Priority) values('" + Dd1.SelectedValue + "','" + tb1.Text + "','" + date1.Text + "','" + date2.Text + "','" + p + "') SELECT SCOPE_IDENTITY() AS [@id];";
            SqlCommand cmd1 = new SqlCommand(insert, con);
            int ID = int.Parse(cmd1.ExecuteScalar().ToString());
            dtCurrentTable = (DataTable)ViewState["CurrentTable"];
            DataColumnCollection c = dtCurrentTable.Columns;
            if (!c.Contains("id"))
            {
                dtCurrentTable.Columns.Add("id");
            }
            dtCurrentTable.Rows[dtCurrentTable.Rows.Count - 1].Delete();
            dtCurrentTable.AcceptChanges();
            // int x = dt.Rows.Count;
            foreach (DataRow row in dtCurrentTable.Rows)
            {


                row["id"] = ID;
            }

         
                SqlBulkCopy objbulk = new SqlBulkCopy(con);
                //assigning Destination table name  
                objbulk.DestinationTableName = "features";
                //Mapping Table column  
                objbulk.ColumnMappings.Add("id", "id");
                objbulk.ColumnMappings.Add("Feature", "Feature");
                objbulk.ColumnMappings.Add("Description", "Description");
                objbulk.ColumnMappings.Add("Acceptence", "Acceptence");
                //inserting bulk Records into DataBase   
                objbulk.WriteToServer(dtCurrentTable);
             

                string join = @"INSERT INTO master([Product Master Name],[Backlog Name],[creation date],Deadline,Priority,Feature,Description,Acceptence) select [Product Master Name],Name,[creation date], deadline, Priority, Feature, Description, Acceptence
FROM features t1 JOIN product_backlog t2
ON t1.id = t2.id";
                SqlCommand cmd2 = new SqlCommand(join, con);

                rdr3 = cmd2.ExecuteReader();



                int rowIndex = 0;

                if (ViewState["CurrentTable"] != null)

                {

                    dt = (DataTable)ViewState["CurrentTable"];

                    if (dt.Rows.Count > 0)

                    {


                        for (int i = 0; i < dt.Rows.Count; i++)

                        {

                            TextBox box1 = (TextBox)Gridview1.Rows[rowIndex].Cells[1].FindControl("TextBox1");

                            TextBox box2 = (TextBox)Gridview1.Rows[rowIndex].Cells[2].FindControl("TextBox2");

                            TextBox box3 = (TextBox)Gridview1.Rows[rowIndex].Cells[3].FindControl("TextBox3");



                            box1.Text = string.Empty;
                            //                Session["x"] = box1.Text;
                            box2.Text = string.Empty;
                            //                Session["y"] = box2.Text;
                            box3.Text = string.Empty;
                            //                Session["z"] = box3.Text;


                            rowIndex++;

                        }
                    }

                }


                tb1.Text = string.Empty;
                Response.Redirect("dashboard.aspx");

                con.Close();



















            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("dashboard.aspx");
        }
    }
}
