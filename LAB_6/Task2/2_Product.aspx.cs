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
    public partial class Product : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                createConnection();
                try
                {
                    using (conn)
                    {
                        SqlCommand cmd = new SqlCommand("select * from Product", conn);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        GridView1.DataSource = dr;
                        GridView1.DataBind();
                        ListBox1.Items.Clear();
                        conn.Close();
                        conn.Open();
                        dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            ListItem item = new ListItem();
                            item.Text = dr["pname"].ToString();
                            item.Value = dr["pid"].ToString();
                            ListBox1.Items.Add(item);
                        }
                    }
                }
                catch (Exception err)
                {
                    Err_Label.Text = "Something went wrong";
                }
            }
        }

        public void createConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int oid,userid;
            userid = Int32.Parse(Session["userid"].ToString());
            createConnection();
            try
            {
                using (conn)
                {
                    string query1 = @"insert into [order_keys] (userid) values (@userid)";
                    SqlCommand cmd1 = new SqlCommand(query1, conn);
                    cmd1.Parameters.AddWithValue("@userid", userid);
                    conn.Open();
                    SqlDataReader dr1 = cmd1.ExecuteReader();
                    conn.Close();
                    string query2 = @"select id from [order_keys] where userid=@userid";
                    SqlCommand cmd2 = new SqlCommand(query2, conn);
                    cmd2.Parameters.AddWithValue("@userid", userid);
                    conn.Open();
                    SqlDataReader dr2 = cmd2.ExecuteReader();
                    dr2.Read();
                    oid = Int32.Parse(dr2["id"].ToString());
                    Session["oid"] = oid;
                    conn.Close();
                    foreach(ListItem item  in ListBox1.Items)
                    {
                        if (item.Selected)
                        {
                            conn.Open();
                            string insert_query = @"insert into [order] (oid,pid,userid) values (@oid,@pid,@userid)";
                            SqlCommand cmd3 = new SqlCommand(insert_query, conn);
                            int pid = Int32.Parse(item.Value);
                            cmd3.Parameters.AddWithValue("@oid", oid);
                            cmd3.Parameters.AddWithValue("@pid", pid);
                            cmd3.Parameters.AddWithValue("@userid", userid);
                            cmd3.ExecuteReader();
                            conn.Close();
                        }
                    }
                    Response.Redirect("2_order.aspx");
                }
            }
            catch(Exception err)
            {
                Err_Label.Text = err.Message;
            }
        }
    }
}