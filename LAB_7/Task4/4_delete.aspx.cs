using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7
{
    public partial class _4_delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(Sid.Text);
            using (DataClasses1DataContext datacontext=new DataClasses1DataContext())
            {
                Student student = datacontext.Students.SingleOrDefault(n=>n.sid==sid);
                if (student == null)
                {
                    Label1.Text = "";
                    Err_Label.Text = "No Record Found";
                    return;
                }
                datacontext.Students.DeleteOnSubmit(student);
                datacontext.SubmitChanges();
                Label1.Text = "Record Deleted Successfully";
                Err_Label.Text = "";
            }
        }
    }
}