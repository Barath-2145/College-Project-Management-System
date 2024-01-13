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
    public partial class WebForm6 : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

            go(Session["role"].ToString().Trim());
            //  newPassword.Text = "";
            oldPassword.DataBind();
            try
            {
                if (Session["role"].ToString() != null)
                {
                    string id = Session["role"].ToString();

                    SqlDataSource1.SelectCommand = "SELECT temp_project_tbl.project_id,project_title,technology,year,batch,status,faculty_id,subject FROM temp_project_tbl,temp_team_tbl WHERE   temp_project_tbl.project_id=temp_team_tbl.project_id AND temp_team_tbl.student_id = '" + id + "'";
                    //   projectApprovalGridView.DataSource = SqlDataSource1;
                    projectRequestGridView.DataBind();

                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

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

                SqlCommand cmd = new SqlCommand("SELECT * FROM student_academic_details_tbl where student_id ='" + ID.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        studentId.Text = dr.GetValue(0).ToString();
                        studentFirstName.Text = dr.GetValue(1).ToString();
                        studentLastName.Text = dr.GetValue(2).ToString();

                        oldPassword.Text = dr.GetValue(3).ToString();
                        department.Text = dr.GetValue(4).ToString();
                        batch.Text = dr.GetValue(5).ToString();
                        year.Text = dr.GetValue(6).ToString();
                        //  Response.Write("<script>alert('" + dr.GetValue(6).ToString() + "');</script>");
                        mobile.Text = dr.GetValue(7).ToString();
                        email.Text = dr.GetValue(8).ToString();
                        dob.Text = dr.GetValue(9).ToString();

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
                SqlCommand cmd = new SqlCommand("UPDATE  student_academic_details_tbl SET student_password = @student_password WHERE student_id='" + ID.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@student_password", newPassword.Text.Trim());


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