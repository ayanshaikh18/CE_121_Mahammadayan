using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7
{
    public partial class _4_update : System.Web.UI.Page
    {
        Student student;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid = Int32.Parse(Sid.Text);
            using (DataClasses1DataContext dbcontext=new DataClasses1DataContext())
            {
                student=dbcontext.Students.SingleOrDefault(n => n.sid == sid);
                if (student == null)
                {
                    Err_Label.Text = "No Record Found!!!";
                    Panel1.Visible = false;
                    return;
                }
                Name.Text = student.name;
                Cpi.Text = "" + student.cpi;
                Sem.SelectedValue =""+ student.sem;
                ContactNo.Text = student.contactno;
                Email.Text = student.emailid;
                Panel1.Visible = true;
                Err_Label.Text = "";
                Label1.Text = "";
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            string name, contact_no, email;
            int sid,sem;
            sid = Int32.Parse(Sid.Text);
            double cpi = Double.Parse(Cpi.Text);
            name = Name.Text;
            contact_no = ContactNo.Text;
            email = Email.Text;
            sem = Int32.Parse(Sem.Text);
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {
                student = dbContext.Students.SingleOrDefault(n => n.sid == sid);
                student.name = name;
                student.sem = sem;
                student.cpi = cpi;
                student.contactno = contact_no;
                student.emailid = email;
                dbContext.SubmitChanges();
            }
            Label1.Text = "Data Updated Successfully";
        }

    }
}