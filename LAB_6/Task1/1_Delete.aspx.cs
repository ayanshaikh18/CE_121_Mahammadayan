using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Configuration;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab6
{
    public partial class Delete : System.Web.UI.Page
    {
        SqlConnection conn;

        protected void Page_Load(object sender, EventArgs e)
        {
            createConnection();
            try
            {
                using (conn)
                {
                    SqlCommand cmd = new SqlCommand("select * from student", conn);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }
            catch (Exception err)
            {
                Err_Label1.Text = "Something went wrong";
            }
        }

        public void createConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }

        protected void Delete_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Id.Text);
            createConnection();
            try
            {
                using (conn)
                {
                    string query = @"delete from student where id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    Err_Label1.ForeColor = System.Drawing.Color.Green;
                    Err_Label1.Text = "Record Deleted Successfully";
                    Page_Load(sender, e);    
                }
            }
            catch (Exception err)
            {
                Err_Label1.ForeColor = System.Drawing.Color.Red;
                Err_Label1.Text = "Error in Fetching data from database";
            }
        }
    }
}