using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class facultyUserProfile : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            go(Session["role"].ToString().Trim());
            oldPassword.DataBind();
            // newPassword.Text = "";
        }
        void go(string ID)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM faculty_tbl where faculty_id ='" + ID.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        facultyId.Text = dr.GetValue(0).ToString();
                        facultyFirstName.Text = dr.GetValue(1).ToString();
                        facultyLastName.Text = dr.GetValue(2).ToString();


                        department.Text = dr.GetValue(3).ToString();


                        //  Response.Write("<script>alert('" + dr.GetValue(6).ToString() + "');</script>");

                        email.Text = dr.GetValue(4).ToString();
                        mobile.Text = dr.GetValue(5).ToString();
                        oldPassword.Text = dr.GetValue(6).ToString();

                    }
                }
            }

            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");

            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            updateStudent(Session["role"].ToString().Trim());
            oldPassword.Text = newPassword.Text.Trim();
        }
        void updateStudent(string ID)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE  faculty_tbl SET faculty_password = @faculty_password WHERE faculty_id='" + ID.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@faculty_password", newPassword.Text.Trim());


                cmd.ExecuteNonQuery();

                con.Close();
                Response.Write("<script>alert(' Details Updated successfully...!');</script>");

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}