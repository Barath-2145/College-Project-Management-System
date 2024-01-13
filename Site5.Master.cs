using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class Site5 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void linkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("departmentDetails-C.aspx");
        }

        protected void linkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect(" facultyDetails.aspx");
        }

        protected void logOutBtn_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Response.Redirect("homePage.aspx");
        }

        protected void linkButton13_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminProjectView.aspx");
        }
    }
}