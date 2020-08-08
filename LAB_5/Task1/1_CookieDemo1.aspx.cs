using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class CookieDemo1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("data");
            cookie["name"] = Name.Text;
            cookie["phone"] = Phone.Text;
            cookie["email"] = Email.Text;
            cookie["city"] = City.Text;
            cookie["branch"] = Branch.SelectedValue;
            cookie["year"] = Year.SelectedValue;
            cookie.Expires = DateTime.Now.AddMinutes(5);
            Response.Cookies.Add(cookie);
            Response.Redirect("CookieDemo2.aspx");
        }
    }
}