using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Image : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int count=Int32.Parse(HiddenField1.Value);
            if (count % 2 == 1)
            {
                Image1.Visible=false;
                Button1.Text = "Click to see image";
            }
            else
            {
                Image1.Visible = true;
                Button1.Text = "Click to hide image";
            }
            HiddenField1.Value = "" + (count + 1);

        }
    }
}