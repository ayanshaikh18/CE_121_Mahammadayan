using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab_5
{
    public partial class _4_CrossPagePostingDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public TextBox name
        {
            get { return Name; }
        }
        
        public TextBox email
        {
            get { return Email; }
        }

        public TextBox phone
        {
            get { return Phone; }
        }

        public TextBox city
        {
            get { return City; }
        }
    }
}