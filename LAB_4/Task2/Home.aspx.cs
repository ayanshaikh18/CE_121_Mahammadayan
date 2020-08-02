using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab4
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }


        protected void State_SelectedIndexChanged(object sender, EventArgs e)
        {
            City.Items.Clear();
            if (State.SelectedValue == "Gujarat")
            {
                City.Items.Add("Ahmedabad");
                City.Items.Add("Vadodara");
            }
            else if(State.SelectedValue=="Maharashtra")
            {
                City.Items.Add("Mumbai");
                City.Items.Add("Pune");
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            string pan_no = args.Value;
            if ((pan_no[0] != 'A' && pan_no[0]!='B') || pan_no.Length!=10)
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = true;
            for (int i = 1; i < 9; i++)
            {
                if (pan_no[i] >= '0' && pan_no[i] <= '9')
                    continue;
                else
                {
                    args.IsValid = false;
                    return;
                }
            }
        }

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string text = "Data : <br>";
                text += ("\n"+FullName.Text+ "<br>");
                text += (Age.Text+ "<br>");
                text += (Password.Text + "<br>");
                text += (Gender.Text + "<br>");
                text += (Mobile.Text + "<br>");
                if (CheckBox1.Checked)
                    text += (CheckBox1.Text+"<br>");
                if (CheckBox2.Checked)
                    text += (CheckBox2.Text + "<br>");
                if (CheckBox3.Checked)
                    text += (CheckBox3.Text + "<br>");

                text += (State.Text + " , ");
                text += (City.Text + " , ");
                text += (PanNo.Text);
                text += "<br>";
                Data.Text = text;
            }
        }

        protected void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}