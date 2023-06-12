using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Course
{
    public partial class Home : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
            {
                uprofile.Visible =false;
                ulogin.Visible =true;
                uregister.Visible =true;
                ulogout.Visible =false;
            }
            else
            {
                {
                    uprofile.Visible = true;
                    ulogin.Visible = false;
                    uregister.Visible = false;
                    ulogout.Visible = true;
                }
            }
            
            
        }
        protected void ulogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
            
        }
        protected void uregister_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }
        protected void ulogout_Click(object sender, EventArgs e)
        {
            Response.Redirect("logout.aspx");
        }
        protected void uprofile_Click(object sender, EventArgs e)
        {
            Response.Redirect("profile.aspx");
        }
        protected void defaultBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
        protected void aboutBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("aboutus.aspx");
        }
        protected void contactBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("contact.aspx");
        }


    }
}