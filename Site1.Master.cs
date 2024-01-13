using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["role"] != null)
            {
                logOutBtn.Visible = true;
            }
            else
            {
                logOutBtn.Visible = false;
            }
        }


        protected void adminLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }
        protected void registrarLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrarLogin.aspx");
        }

        protected void studentLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentLogin.aspx");
        }

        protected void homePage_Click(object sender, EventArgs e)
        {
            Response.Redirect("homePage.aspx");
        }

        protected void facultyLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("facultyLogin.aspx");
        }



        protected void registrarLoginFooter_Click(object sender, EventArgs e)
        {
            Response.Redirect("registrarLogin.aspx");
        }
        protected void adminLoginFooter_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }


        protected void logOutBtn_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Response.Redirect("homePage.aspx");
        }

        protected void facultyLoginFooter_Click(object sender, EventArgs e)
        {
            Response.Redirect("facultyLogin.aspx");
        }
        protected void studentLoginFooter_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentLogin.aspx");
        }
    }

}