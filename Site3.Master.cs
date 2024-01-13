using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class Site3 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    Response.Redirect("homePage.aspx");
                }


            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        protected void myProfileBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentUserProfile.aspx");
        }

        protected void logOutBtn_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Response.Redirect("homePage.aspx");
        }

        protected void createProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("createProjects.aspx");
        }

        protected void myProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentMyProject.aspx");
        }
    }
}