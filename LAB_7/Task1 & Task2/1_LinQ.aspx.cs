using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7
{
    public partial class _1_LinQ : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<h2>Task1</h2>");
            int[] a = Enumerable.Range(1, 100).ToArray();
            Response.Write("<b>Even Numbers from 1 to 100: </b><br>");
            var even_nums = a.Where(n=>n%2==0);
            foreach(var num in even_nums)
                Response.Write(num+", ");

            Response.Write("<br><br><b>Odd Numbers from 1 to 100 :</b><br>");
            var odd_nums = a.Where(n => n % 2 == 1);
            foreach (var num in odd_nums)
                Response.Write(num + ", ");

            Response.Write("<br><br><b>All Numbers from 1 to 100 : </b><br>");
            var all = a.Where(n=>true);
            foreach (var num in all)
                Response.Write(num + ", ");

            Response.Write("<br><br><b>Max : </b>");
            var max = a.Max();
            Response.Write(max+"<br>");

            Response.Write("<br><br><b>Min : </b>");
            var min = a.Min();
            Response.Write(min + "<br><br><hr>");

            Response.Write("<h2>Task2</h2>");

            string[] names = {"Dhoni","Kohli","Raina","Yuzi","Kuldeep","Rohit","Yuvraj","Zak","KL","Bumrah" };
            Response.Write("<b>Names With first letter 'K' :</b><br>");
            var nameStartingWithK = names.Where(n=>n.StartsWith("K"));
            foreach (var name in nameStartingWithK)
                Response.Write(name+ ", ");

            Response.Write("<br><br><b>Names With length less than 4 :</b><br>");
            var nameLessThan4 = names.Where(n=>n.Length<4);
            foreach (var name in nameLessThan4)
                Response.Write(name + ", ");

            Response.Write("<br><br><b>Names with length 3 :</b><br>");
            var name3 = names.Where(n=>n.Length==3);
            foreach (var name in name3)
                Response.Write(name + ", ");

            Response.Write("<br><br><b>Names in Ascending Order :</b><br>");
            var sortedNames = names.OrderBy(n=>n);
            foreach (var name in sortedNames)
                Response.Write(name + ", ");
        }


    }
}