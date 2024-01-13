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
    public partial class bookIssue : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            // if (!IsPostBack)
            // {

            facultyGridView.DataBind();
            //}

        }

        protected void facultyAddBtn_Click(object sender, EventArgs e)
        {
            if (checkFacultyExist())
            {
                Response.Write("<script>alert('Faculty or Faculty Id Already Exist..!');</script>");
            }
            else
            {
                addFaculty();
            }

        }

        protected void facultyUpdateBtn_Click(object sender, EventArgs e)
        {
            if (checkFacultyExist())
            {
                updateFaculty();
            }
            else
            {
                Response.Write("<script>alert('Faculty doesn't Exist..!');</script>");
            }
        }

        protected void facultyDeleteBtn_Click(object sender, EventArgs e)
        {
            if (checkFacultyExist())
            {
                deleteFaculty();
            }
            else
            {
                Response.Write("<script>alert('Faculty doesn't Exist..!');</script>");
            }
        }

        protected void goBtn_Click(object sender, EventArgs e)
        {

            if (checkFacultyExist())
            {
                go();
            }
            else
            {
                Response.Write("<script>alert('Faculty doesnot Exist..!');</script>");
            }
        }
        void addFaculty()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO faculty_tbl(faculty_id,faculty_first_name,faculty_last_name,department_id,faculty_email,faculty_mobile,faculty_password) VALUES (@faculty_id,@faculty_first_name,@faculty_last_name,@department_id,@faculty_email,@faculty_mobile,@faculty_password)", con);

                cmd.Parameters.AddWithValue("@faculty_id", facultyId.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_first_name", facultyFirtsName.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_last_name", facultyLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@department_id", departmentId.Text);
                cmd.Parameters.AddWithValue("@faculty_email", facultyEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_mobile", facultyMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_password", password.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Faculty added successfully...!');</script>");
                ClearForm();
                facultyGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updateFaculty()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE  faculty_tbl SET  faculty_first_name=@faculty_first_name ,faculty_last_name=@faculty_last_name, department_id=@department_id, faculty_email=@faculty_email, faculty_mobile=@faculty_mobile,  faculty_password=@faculty_password  WHERE faculty_id ='" + facultyId.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@faculty_first_name", facultyFirtsName.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_last_name", facultyLastName.Text.Trim());
                cmd.Parameters.AddWithValue("@department_id", departmentId.SelectedValue);
                cmd.Parameters.AddWithValue("@faculty_email", facultyEmail.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_mobile", facultyMobile.Text.Trim());
                cmd.Parameters.AddWithValue("@faculty_password", password.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Faculty Details Updated successfully...!');</script>");
                ClearForm();
                facultyGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteFaculty()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM faculty_tbl WHERE faculty_id ='" + facultyId.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Faculty Deleted successfully...!');</script>");
                ClearForm();
                facultyGridView.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        bool checkFacultyExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM faculty_tbl WHERE faculty_id = '" + facultyId.Text.Trim() + "'", con);

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
            facultyId.Text = "";
            facultyFirtsName.Text = "";
            facultyLastName.Text = "";
            facultyEmail.Text = "";
            facultyMobile.Text = "";

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

                SqlCommand cmd = new SqlCommand("SELECT * FROM faculty_tbl where faculty_id ='" + facultyId.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        facultyId.Text = dr.GetValue(0).ToString();
                        facultyFirtsName.Text = dr.GetValue(1).ToString();
                        facultyLastName.Text = dr.GetValue(2).ToString();
                        departmentId.ClearSelection();
                        var dept = dr.GetValue(3).ToString();

                        //departmentId.SelectedIndex = departmentId.Items.IndexOf(departmentId.Items.FindByValue(dr.GetValue(3).ToString()));
                        try
                        {
                            if (dept != null)
                            {
                                departmentId.Items.FindByValue(dept.Trim()).Selected = true;
                            }

                        }
                        catch (Exception ex)
                        {
                            Response.Write("<script>alert('" + ex.Message + "');</script>");
                        }

                        facultyEmail.Text = dr.GetValue(4).ToString();
                        facultyMobile.Text = dr.GetValue(5).ToString();
                        password.Text = dr.GetValue(6).ToString();



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