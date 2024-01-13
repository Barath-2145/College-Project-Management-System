using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class Site4 : System.Web.UI.MasterPage
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
            Response.Redirect("facultyUserProfile.aspx");
        }

        protected void logOutBtn_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Response.Redirect("homePage.aspx");
        }

        protected void requestProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("facultyProjectApproval.aspx");
        }

        protected void approvedProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("facultyApprovedProjects.aspx");
        }

        protected void CreateProject_Click(object sender, EventArgs e)
        {
            Response.Redirect("facultyCreateProject.aspx");
        }
    }
}