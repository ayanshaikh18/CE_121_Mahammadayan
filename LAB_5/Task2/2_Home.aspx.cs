using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Welcome.Text = "Welcome " + Session["username"];
            if (!IsPostBack)
            {
                Dictionary<string, int> prizes = new Dictionary<string, int>();
                prizes.Add("Pendrive",200);
                prizes.Add("Laptop",35000);
                prizes.Add("Smart Phone",15000);
                prizes.Add("Keyboard",2000);
                prizes.Add("Mouse",500);
                prizes.Add("ANSI-C by Balagurusami",500);
                prizes.Add("Digital Design by Morrismeno",350);
                prizes.Add("CLR via C#",550);
                prizes.Add("Coreman",1000);
                Session["prizes"] = prizes;

            }
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox1.Items.Clear();
            if (RadioButtonList1.SelectedValue == "Electronics")
            {
                ListBox1.Items.Add("Pendrive");
                ListBox1.Items.Add("Laptop");
                ListBox1.Items.Add("Smart Phone");
                ListBox1.Items.Add("Keyboard");
                ListBox1.Items.Add("Mouse");
            }
            else if (RadioButtonList1.SelectedValue == "Books")
            {

                ListBox1.Items.Add("ANSI-C by Balagurusami");
                ListBox1.Items.Add("Digital Design by Morrismeno");
                ListBox1.Items.Add("CLR via C#");
                ListBox1.Items.Add("Coreman");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> prizes = (Dictionary<string, int>)Session["prizes"];
            Dictionary<string, int> order = new Dictionary<string, int>();
            foreach(ListItem item in ListBox1.Items)
            {
                if (item.Selected)
                {
                    order.Add(item.Value,prizes[item.Value]);
                }
            }
            Session["order"] = order;
            Response.Redirect("order.aspx");
        }
    }
}