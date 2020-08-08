using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            if(username=="ayan" && password == "123")
            {
                Session["username"] = username;
                Response.Redirect("Home.aspx");
            }
            else
            {
                Label3.Text = "Invalid Credenrials";
            }
        }
    }
}