using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7
{
    public partial class _4_insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name, contact_no, email;
            int sid, sem;
            double cpi = Double.Parse(Cpi.Text);
            name = Name.Text;
            contact_no = ContactNo.Text;
            email = Email.Text;
            sid = Int32.Parse(Sid.Text);
            sem = Int32.Parse(Sem.Text);
            using (DataClasses1DataContext dbContext = new DataClasses1DataContext())
            {
                dbContext.Students.InsertOnSubmit(new Student { sid = sid, name = name, sem = sem, cpi = cpi, contactno = contact_no, emailid = email });
                dbContext.SubmitChanges();
            }
            Label1.Text = "Data Inserted Successfully";
        }
    }
}