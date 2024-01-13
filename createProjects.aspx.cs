using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CollegeProjectManagementSystem
{
    public partial class createProjects : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void goBtn1_Click(object sender, EventArgs e)
        {
            // SqlConnection con = new SqlConnection(db);
            if (checkStudentExist(studentId1.Text.ToString()))
            {
                goBtn1();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }

        }

        protected void go2_Click(object sender, EventArgs e)
        {
            if (checkStudentExist(studentId2.Text.ToString()))
            {
                goBtn2();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }
        }

        protected void go3_Click(object sender, EventArgs e)
        {
            if (checkStudentExist(studentId3.Text.ToString()))
            {
                goBtn3();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }
        }

        protected void go4_Click(object sender, EventArgs e)
        {
            if (checkStudentExist(facultyId.Text.ToString()))
            {
                goBtn4();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }
        }
        bool checkStudentExist(string id)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT student_first_name,student_last_name,department_id FROM student_academic_details_tbl WHERE student_id ='" + id.Trim() + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }


        }
        void ClearForm()
        {
            studentId1.Text = "";
            studentFirstName1.Text = "";
            studentLastName2.Text = "";
            department1.Text = "";
            studentId2.Text = "";
            studentFirstName2.Text = "";
            studentLastName2.Text = "";
            department2.Text = "";
            studentId3.Text = "";
            studentFirstName3.Text = "";
            studentLastName3.Text = "";
            department3.Text = "";
            studentId4.Text = "";
            studentFirstName4.Text = "";
            studentLastName4.Text = "";
            department4.Text = "";
            year.Text = "";
            subject.Text = "";
            //departmentId.Text = "";
            facultyId.Text = "";
            facultyFirstName.Text = "";
            tech.Text = "";

        }
        bool goBtn1()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT student_first_name,student_last_name,department_id FROM student_academic_details_tbl WHERE student_id ='" + studentId1.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {



                    while (dr.Read())
                    {


                        studentFirstName1.Text = dr.GetValue(0).ToString();
                        studentLastName1.Text = dr.GetValue(1).ToString();
                        department1.Text = dr.GetValue(2).ToString();


                    }
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }
        }
        bool goBtn2()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT student_first_name,student_last_name,department_id FROM student_academic_details_tbl WHERE student_id ='" + studentId2.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {



                    while (dr.Read())
                    {


                        studentFirstName2.Text = dr.GetValue(0).ToString();
                        studentLastName2.Text = dr.GetValue(1).ToString();
                        department2.Text = dr.GetValue(2).ToString();


                    }
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }
        }
        bool goBtn3()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT student_first_name,student_last_name,department_id FROM student_academic_details_tbl WHERE student_id ='" + studentId3.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {



                    while (dr.Read())
                    {


                        studentFirstName3.Text = dr.GetValue(0).ToString();
                        studentLastName3.Text = dr.GetValue(1).ToString();
                        department3.Text = dr.GetValue(2).ToString();


                    }
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }
        }

        bool goBtn4()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT student_first_name,student_last_name,department_id FROM student_academic_details_tbl WHERE student_id ='" + studentId4.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {



                    while (dr.Read())
                    {


                        studentFirstName4.Text = dr.GetValue(0).ToString();
                        studentLastName4.Text = dr.GetValue(1).ToString();
                        department4.Text = dr.GetValue(2).ToString();


                    }
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }
        }
        bool facultyGoBtn4()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT faculty_first_name,faculty_last_name FROM faculty_tbl WHERE faculty_id ='" + facultyId.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {



                    while (dr.Read())
                    {


                        facultyFirstName.Text = dr.GetValue(0).ToString();
                        facultyLastName.Text = dr.GetValue(1).ToString();



                    }
                    return true;
                }
                else
                {
                    return false;
                }



            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;

            }
        }

        protected void facultyGoBtn_Click(object sender, EventArgs e)
        {
            if (checkFacultyExist(facultyId.Text.ToString()))
            {
                facultyGoBtn4();
            }
            else
            {
                Response.Write("<script>alert('Faculty Doesnot exist!..');</script>");
            }
        }
        bool checkFacultyExist(string id)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT faculty_first_name,faculty_last_name FROM faculty_tbl WHERE faculty_id ='" + id.Trim() + "'", con);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count >= 1)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
                return false;
            }


        }

        protected void projectAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string projectId = abbreviation.Text.ToString() + batch.Text.ToString();
                string stId1, stId2, stId3, stId4;

                if (studentId1.Text.ToString() != null)
                {
                    stId1 = studentId1.Text.ToString().Trim();
                }
                else
                {
                    stId1 = "empty";
                }
                if (studentId2.Text.ToString() != null)
                {
                    stId2 = studentId2.Text.ToString().Trim();
                }
                else
                {
                    stId2 = "empty";
                }
                if (studentId3.Text.ToString() != null)
                {
                    stId3 = studentId3.Text.ToString().Trim();
                }
                else
                {
                    stId3 = "empty";
                }
                if (studentId4.Text.ToString() != null)
                {
                    stId4 = studentId4.Text.ToString().Trim();
                }
                else
                {
                    stId4 = "empty";
                }

                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                // Response.Write("<script>alert('"+projectId+"');</script>");

                SqlCommand cmd = new SqlCommand();



                cmd.Parameters.AddWithValue("@project_id", projectId);
                cmd.Parameters.AddWithValue("@project_title", projectTitle.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@technology", tech.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@year", year.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@batch", batch.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@status", "pending".ToString());
                cmd.Parameters.AddWithValue("@faculty_id", facultyId.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@subject", subject.Text.ToString().Trim());
                cmd.Parameters.AddWithValue("@student1_id", stId1.Trim());
                cmd.Parameters.AddWithValue("@student2_id", stId2.Trim());
                cmd.Parameters.AddWithValue("@student3_id", stId3.Trim());
                cmd.Parameters.AddWithValue("@student4_id", stId4.Trim());
                //   cmd.Parameters.AddWithValue("@n", Int32.Parse(count.Text));
                cmd.Connection = con;
                cmd.CommandText = "insertTempProject";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Request Sent Successfully!');</script>");
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}