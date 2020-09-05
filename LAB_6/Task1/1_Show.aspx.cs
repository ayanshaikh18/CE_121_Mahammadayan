using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab6
{
    public partial class Show : System.Web.UI.Page
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
    }
}