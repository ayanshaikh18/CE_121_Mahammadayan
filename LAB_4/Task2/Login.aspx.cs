using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(TextBox1.Text!="admin" || TextBox2.Text != "admin")
            {
                Label1.Text = "Invalid Credentials";
            }
            else
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}