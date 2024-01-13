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
    public partial class batchAndDepartments : System.Web.UI.Page
    {
        //DB Connection
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            //deptName.Attributes.Add("onblur", "deptIdValidate();");
            // deptId.Attributes.Add("onblur", "deptValidate();");
            // 

            deptGridView.DataBind();
        }
        //Adding Departments when Add Button is clicked
        protected void addBtn_Click(object sender, EventArgs e)
        {
            // Response.Write("<script>alert('hi');</script>");
            if (checkDepartmentExist())
            {
                Response.Write("<script>alert('Department or Department Id Already Exist..!');</script>");
            }
            else
            {
                addDepartments();
            }
        }


        protected void goBtn_Click(object sender, EventArgs e)
        {
            if (checkDepartmentExist())
            {
                go();
            }
            else
            {
                Response.Write("<script>alert('Department doesn't Exist..!');</script>");
            }


        }


        protected void updateBtn_Click(object sender, EventArgs e)
        {
            if (checkDepartmentExist())
            {
                updateDepartments();
            }
            else
            {
                Response.Write("<script>alert('Department doesn't Exist..!');</script>");
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            if (checkDepartmentExist())
            {
                deleteDepartments();
            }
            else
            {
                Response.Write("<script>alert('Department doesn't Exist..!');</script>");
            }
        }
        bool checkDepartmentExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM departments_tbl where department_id = '" + deptId.Text.Trim() + "' OR department ='" + deptName.Text.Trim() + "'", con);

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
        void addDepartments()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO departments_tbl(department_id,department) VALUES (@department_id,@department)", con);

                cmd.Parameters.AddWithValue("@department_id", deptId.Text.Trim());
                cmd.Parameters.AddWithValue("@department", deptName.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Department added successfully...!');</script>");
                ClearForm();
                deptGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }

        void updateDepartments()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE  departments_tbl SET  department=@department WHERE department_id ='" + deptId.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@department", deptName.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Department Updated successfully...!');</script>");
                ClearForm();
                deptGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteDepartments()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM departments_tbl WHERE department_id ='" + deptId.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Department Deleted successfully...!');</script>");
                ClearForm();
                deptGridView.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM departments_tbl where department_id ='" + deptId.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        deptName.Text = dr.GetValue(1).ToString();

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
        void ClearForm()
        {
            deptId.Text = "";
            deptName.Text = "";
        }
    }
}