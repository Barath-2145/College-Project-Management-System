using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace E_LibraryManagement
{
    public partial class registrarStudentManagement : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            studentGridView.DataBind();
        }

        protected void goBtn_Click(object sender, EventArgs e)
        {
            if(checkStudentExist())
            {
                go();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }
        }

        protected void studentAddBtn_Click(object sender, EventArgs e)
        {
            if (checkStudentExist())
            {

                Response.Write("<script>alert('Student already exist!..');</script>");
            }
            else
            {
                addStudent();
            }
        }

        protected void studentUpdateBtn_Click(object sender, EventArgs e)
        {
            if (checkStudentExist())
            {
                updateStudent();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }
        }

        protected void studentDeleteBtn_Click(object sender, EventArgs e)
        {
            if (checkStudentExist())
            {
                deleteStudent();
            }
            else
            {
                Response.Write("<script>alert('Student Doesnot exist!..');</script>");
            }
        }
        void addStudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
               
                SqlCommand cmd = new SqlCommand("INSERT INTO student_academic_details_tbl(student_id,student_first_name,student_last_name,student_password,department_id,batch_id,year,mobile_number,student_email,date_of_birth) VALUES (@student_id,@student_first_name,@student_last_name,@student_password,@department_id,@batch_id,@year,@mobile_number,@student_email,@date_of_birth)", con);

                cmd.Parameters.AddWithValue("@student_id", studentId.Text.Trim());
                cmd.Parameters.AddWithValue("@student_first_name", studentFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@student_last_name", studentLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@student_password", password.Text.Trim());
                cmd.Parameters.AddWithValue("@department_id", departmentId.SelectedValue.Trim());
                cmd.Parameters.AddWithValue("@batch_id", batch.SelectedValue.Trim());
                cmd.Parameters.AddWithValue("@year", year.Text.Trim());
                cmd.Parameters.AddWithValue("@mobile_number", studentMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@student_email", studentEmail.Text.Trim());
 
                cmd.Parameters.AddWithValue("@date_of_birth", dob.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student added successfully...!');</script>");
                ClearForm();
                studentGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updateStudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE  student_academic_details_tbl SET  student_first_name=@student_first_name ,studenty_last_name=@student_last_name, department_id=@department_id, student_email=@student_email, student_mobile=@student_mobile, year=@year,batch_id=@batch_id ,student_password=@student_password,date_of_birth=@date_of_birth WHERE student_id ='" + studentId.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@student_first_name", studentFirstName.Text.Trim());
                cmd.Parameters.AddWithValue("@student_last_name", studentLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@department_id", departmentId.SelectedValue);
                cmd.Parameters.AddWithValue("@student_email", studentEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@student_mobile", studentMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@year", year.Text.Trim());
                cmd.Parameters.AddWithValue("@batch_id", batch.SelectedValue.Trim());
                cmd.Parameters.AddWithValue("@student_password", password.Text.Trim());
                cmd.Parameters.AddWithValue("@date_of_birth", dob.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Students Details Updated successfully...!');</script>");
                ClearForm();
                studentGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteStudent()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM student_academic_details_tbl WHERE studenty_id ='" + studentId.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Student Deleted successfully...!');</script>");
                ClearForm();
                studentGridView.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkStudentExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM student_academic_details_tbl WHERE student_id = '" + studentId.Text.Trim() + "'", con);

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
            studentId.Text = "";
            studentFirstName.Text = "";
            studentLastName.Text = "";
            studentEmail.Text = "";
            studentMobile.Text = "";
            //departmentId.Text = "";
            password.Text = "";
            
        }
        bool go()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM student_academic_details_tbl where student_id ='" + studentId.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        studentId.Text = dr.GetValue(0).ToString();
                        studentFirstName.Text = dr.GetValue(1).ToString();
                        studentLastName.Text = dr.GetValue(2).ToString();
                        departmentId.ClearSelection();
                        
                        batch.ClearSelection();
                        password.Text = dr.GetValue(3).ToString();
                        var dept = dr.GetValue(4).ToString();
                        var batchTemp = dr.GetValue(5).ToString();
                         year.Text = dr.GetValue(6).ToString();
                        
                        //departmentId.SelectedIndex = departmentId.Items.IndexOf(departmentId.Items.FindByValue(dr.GetValue(3).ToString()));                       
                        try
                        {
                            if (dept != null)
                            {
                                departmentId.Items.FindByValue(dept.Trim()).Selected = true;
                            }
                            
                            if (batchTemp != null)
                            {
                               batch.Items.FindByValue(batchTemp.Trim()).Selected = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            Response.Write("<script>alert('" + ex.Message + "');</script>");
                        }
                       
                        try
                        {
                            if (batchTemp != null)
                            {
                                batch.Items.FindByValue(batchTemp.Trim()).Selected = true;
                            }
                        }
                        catch
                        (Exception ex)
                        {
                            Response.Write("<script>alert('" + ex.Message + "');</script>");
                        }
                       
                        studentMobile.Text = dr.GetValue(7).ToString();
                        studentEmail.Text = dr.GetValue(8).ToString();
                        dob.Text = dr.GetValue(9).ToString();
                    
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
    }
}