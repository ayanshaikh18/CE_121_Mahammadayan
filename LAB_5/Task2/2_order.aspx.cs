using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Welcome.Text = "Welcome " + Session["username"];
            if (!IsPostBack)
            {
                int total = 0;
                Dictionary<string, int> order = (Dictionary<string, int>)Session["order"];
                foreach(KeyValuePair<string,int>item in order)
                {
                    TableRow tr = new TableRow();
                    TableCell td1 = new TableCell();
                    td1.Text = item.Key;
                    TableCell td2 = new TableCell();
                    td2.Text =""+ item.Value;
                    tr.Cells.Add(td1);
                    tr.Cells.Add(td2);
                    myTable.Rows.Add(tr);
                    total += item.Value;
                }
                Total.Text += total;
            }
        }
    }
}