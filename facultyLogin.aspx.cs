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
    public partial class facultyLogin : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void registrarLoginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM faculty_tbl where faculty_id ='" + facultyId.Text.Trim() + "' AND faculty_password='" + password.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        Response.Write("<script>alert('Login Successfull.." + dr.GetValue(2).ToString() + "!');</script>");
                        Session["role"] = facultyId.Text.Trim();

                    }
                    Response.Redirect("facultyUserProfile.aspx");
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