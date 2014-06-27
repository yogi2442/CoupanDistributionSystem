using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class adminLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void login(object sender, EventArgs e)
        {
            string username = textbox_username.Text;
            string password = textbox_password.Text;

            if (username == "admin" && password == "admin")
            {
                //Response.Redirect("");  // redirect to the admin page;
                Response.Write(@"<script language='javascript'>alert('Successfully logged In..!');</script>");
            }
            else
            {
                Response.Write(@"<script language='javascript'>alert('Wrong username or password..!!');</script>");
            }
        }
    }
}