using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class Site2 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"] == null)
                {
                    Response.Redirect("homePage.aspx");
                }

                else if (Session["role"].Equals("admin"))
                {
                    logoutBtn.Visible = false;

                }

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }

        }

        protected void studentBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("studentDetails.aspx");
        }

        protected void facultyBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("facultyDetails.aspx");
        }

        protected void departmentBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("departmentDetails.aspx");
        }

        protected void batchBtn_Click(object sender, EventArgs e)
        {
            Response.Redirect("batchDetails.aspx");
        }

        protected void logoutBtn_Click(object sender, EventArgs e)
        {
            Session["role"] = "";
            Response.Redirect("homePage.aspx");
        }
    }
}