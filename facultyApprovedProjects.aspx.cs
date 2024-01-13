using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class facultyApprovedPrpojects : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                string id = Session["role"].ToString();
                //   Response.Write("<script>alert('" + id + "')</script>;");
                if (Session["role"].ToString() != null)
                {


                    SqlDataSource2.SelectCommand = "SELECT DISTINCT [project_id],[project_title],[technology],[year],[batch],[status],[faculty_id],[subject],[remarks],[deadline] FROM[CPMS].[dbo].[project_tbl] WHERE faculty_id='" + id + "'";

                    facultyApprovedProjectGridView.DataKeyNames = new string[] { "project_id" };



                    facultyApprovedProjectGridView.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        protected void facultyApprovedProjectGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GridViewRow gR = facultyApprovedProjectGridView.SelectedRow;
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