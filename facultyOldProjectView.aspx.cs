using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class facultyOldProjectView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Session["role"].ToString();
                //   Response.Write("<script>alert('" + id + "')</script>;");
                if (Session["role"].ToString() != null)
                {


                    SqlDataSource1.SelectCommand = "SELECT DISTINCT [project_id],[project_title],[technology],[year],[batch],[status],[faculty_id],[subject],[remarks],[deadline] FROM[CPMS].[dbo].[project_tbl] WHERE year <> 1 AND year <> 2 AND year<> 3 AND year <> 4 ";

                    facultyOldProjectGridView.DataKeyNames = new string[] { "project_id" };



                    facultyOldProjectGridView.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void facultyOldProjectGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gR = facultyOldProjectGridView.SelectedRow;
                string id = gR.Cells[1].Text.Trim().ToString();
                Response.Redirect("approvedProjectDetails.aspx?p_id=" + id + "");
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
        }
    }
}