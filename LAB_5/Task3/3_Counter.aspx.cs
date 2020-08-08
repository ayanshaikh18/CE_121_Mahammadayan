using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class Counter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ViewState["count"] = 0;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int cnt=Int32.Parse(ViewState["count"].ToString());
            count.Text = "Count : " + (++cnt);
            ViewState["count"] = cnt;
        }
    }
}