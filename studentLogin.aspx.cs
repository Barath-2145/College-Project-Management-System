using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace CollegeProjectManagementSystem
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM student_academic_details_tbl where student_id ='" + studentId.Text.Trim() + "' AND student_password='" + password.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        Response.Write("<script>alert('Login Successfull.." + dr.GetValue(2).ToString() + "!');</script>");
                        Session["role"] = studentId.Text.Trim();

                    }
                    Response.Redirect("studentUserProfile.aspx");
                }
                else
                {
                    Response.Write("<script>alert('Invalid UserName or Password..!');</script>");
                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }
    }
}