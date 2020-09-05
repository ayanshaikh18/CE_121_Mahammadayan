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
    public partial class Insert : System.Web.UI.Page
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

        protected void Submit_Click(object sender, EventArgs e)
        {
            string name,email_id, mob_no;
            int sem;
            name = Name.Text;
            email_id = EmailId.Text;
            sem = Int32.Parse(Sem.Text);
            mob_no=MobNo.Text;
            createConnection();
            try
            {
                using (conn)
                {
                    string query = @"insert into Student (name,sem,email_id,mob_no) values (@name,@sem,@email_id,@mob_no)";
                    SqlCommand cmd = new SqlCommand(query,conn);
                    cmd.Parameters.AddWithValue("@name",name);
                    cmd.Parameters.AddWithValue("@sem", sem);
                    cmd.Parameters.AddWithValue("@email_id", email_id);
                    cmd.Parameters.AddWithValue("@mob_no", mob_no);
                    conn.Open();
                    cmd.ExecuteReader();
                    Label1.Text = "Data Inserted Succesfully";
                    Err_Label.Text = "";
                }
            }
            catch(Exception err)
            {
                Label1.Text = "";
                Err_Label.Text = err.Message;
                //Err_Label.Text = "Error in updating database";
            }
        }
    }
}