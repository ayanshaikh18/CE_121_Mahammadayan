using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class _4_CrossPagePostingDemo2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                _4_CrossPagePostingDemo prev = PreviousPage as _4_CrossPagePostingDemo;
                if (prev != null)
                {
                    Name.Text = prev.name.Text;
                    Email.Text = prev.email.Text;
                    Phone.Text = prev.phone.Text;
                    City.Text = prev.city.Text;
                }
            }
        }
    }
}