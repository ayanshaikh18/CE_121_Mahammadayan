using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class CookieDemo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["data"];
            if (cookie == null)
            {
                Label1.Text = "Cookie is not available";
                Name.Text = "";
                Email.Text = "";
                Phone.Text = "";
                City.Text = "";
                Branch.Text = "";
                Year.Text = "";
                return;
            }
            Label1.Text = "Cookie is available";
            Name.Text = cookie["name"];
            Email.Text = cookie["email"];
            Phone.Text = cookie["phone"];
            City.Text = cookie["city"];
            Branch.Text = cookie["branch"];
            Year.Text = cookie["year"];
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Cookies["data"].Expires = DateTime.Now.AddMinutes(-1);
            Label1.Text = "Cookie is not available";
            Name.Text = "";
            Email.Text = "";
            Phone.Text = "";
            City.Text = "";
            Branch.Text = "";
            Year.Text = "";
        }
    }
}