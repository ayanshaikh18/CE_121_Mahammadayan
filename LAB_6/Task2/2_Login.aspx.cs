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
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void createConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int userid;
            string password;
            userid = Int32.Parse(Username.Text);
            password = Password.Text;
            createConnection();
            try
            {
                using (conn)
                {
                    string query = @"select * from [User] where userid=@userid";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@userid", userid);
                    conn.Open();
                    SqlDataReader dr = cmd.ExecuteReader();
                    bool valid = false;
                    while (dr.Read())
                    {
                        string pwd = dr["password"].ToString();
                        if (pwd == password)
                        {
                            valid = true;
                            break;
                        }
                    }
                    if (valid)
                    {
                        Session["userid"] = userid;
                        Response.Redirect("2_Product.aspx");
                    }
                    else
                    {
                        Label1.Text = "Invalid Credentials";
                    }
                }
            }
            catch(Exception err)
            {
                Label1.Text = err.Message;
            }
        }
    }
}