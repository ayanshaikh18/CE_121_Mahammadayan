using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace Lab6
{
    public partial class order : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int total = 0,userid,oid;
                userid = Int32.Parse(Session["userid"].ToString());
                oid = Int32.Parse(Session["oid"].ToString());
                createConnection();
                try
                {
                    using (conn)
                    {
                        string query= "select pname,cost from [Product] where pid in (Select pid from [Order] where userid=@userid and oid=@oid)";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@userid", userid);
                        cmd.Parameters.AddWithValue("@oid", oid);
                        conn.Open();
                        SqlDataReader dr = cmd.ExecuteReader();
                        while (dr.Read())
                        {
                            TableRow tr = new TableRow();
                            TableCell td1 = new TableCell();
                            td1.Text = dr["pname"].ToString();
                            TableCell td2 = new TableCell();
                            td2.Text = dr["cost"].ToString();
                            tr.Cells.Add(td1);
                            tr.Cells.Add(td2);
                            myTable.Rows.Add(tr);
                            total += Int32.Parse(dr["cost"].ToString());
                        }
                        Total.Text += total;
                    }
                }
                catch (Exception err)
                {
                    Err_Label.Text = err.Message;
                    //Err_Label.Text = "Something went wrong";
                }
            }
        }
        public void createConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
    }
}