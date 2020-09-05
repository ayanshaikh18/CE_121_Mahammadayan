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
    public partial class Edit : System.Web.UI.Page
    {
        SqlConnection conn;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                Panel1.Visible = false;
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
            catch(Exception err)
            {
                Err_Label.Text = "Something went wrong";
            }
        }

        public void createConnection()
        {
            conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }

        protected void Fetch_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(Id.Text);
            createConnection();
            try
            {
                using (conn)
                {
                    string query = @"select * from student where id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    SqlDataReader dr=cmd.ExecuteReader();
                    dr.Read();
                    Name.Text = dr["name"].ToString();
                    Sem.Text = dr["sem"].ToString();
                    EmailId.Text = dr["email_id"].ToString();
                    MobNo.Text = dr["mob_no"].ToString();
                    Err_Label.Text = ""; 
                    Panel1.Visible = true;
                }
            }
            catch(Exception err)
            {
                Panel1.Visible = false;
                Err_Label.Text = "Error in Fetching data from database";
            }
           
        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name, email_id, mob_no;
            int sem,id;
            name = Name.Text;
            email_id = EmailId.Text;
            sem = Int32.Parse(Sem.Text);
            mob_no = MobNo.Text;
            id = Int32.Parse(Id.Text);
            createConnection();
            try
            {
                using (conn)
                {
                    string query = @"update student set name=@name,sem=@sem,email_id=@email_id,mob_no=@mob_no where id=@id";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@sem", sem);
                    cmd.Parameters.AddWithValue("@email_id", email_id);
                    cmd.Parameters.AddWithValue("@mob_no", mob_no);
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();
                    cmd.ExecuteReader();
                    Err_Label.ForeColor = System.Drawing.Color.Green;
                    Err_Label.Text = "Record Updated Successfully";
                    Page_Load(sender,e);
                }
            }
            catch (Exception err)
            {
                Err_Label.ForeColor = System.Drawing.Color.Red;
                Err_Label.Text = "Error in updating database";
            }
        }
    }
}