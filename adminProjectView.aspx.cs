using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class adminProjectView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void adminProjectGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gR = adminProjectGridView.SelectedRow;
            string id = gR.Cells[1].Text.Trim().ToString();
            Response.Redirect("projectDetails.aspx?p_id=" + id + "");
        }
    }
}