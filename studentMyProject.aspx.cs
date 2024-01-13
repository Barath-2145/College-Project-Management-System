using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class studentMyProject : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Session["role"].ToString();
                //   Response.Write("<script>alert('" + id + "')</script>;");
                if (Session["role"].ToString() != null)
                {


                    SqlDataSource1.SelectCommand = "SELECT  DISTINCT project_tbl.project_id,project_title,technology,year,batch,status,faculty_id,subject,deadline,remarks FROM project_tbl,temp_team_tbl WHERE temp_team_tbl.student_id='" + id + "'";

                    projectApprovalGridView.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }

        protected void projectApprovalGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gR = projectApprovalGridView.SelectedRow;
            Response.Redirect("uploadFile.aspx?p_id=" + gR.Cells[1].Text);
        }
    }
}