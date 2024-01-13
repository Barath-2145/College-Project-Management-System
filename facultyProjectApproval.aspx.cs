using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;
using System.Net;

namespace CollegeProjectManagementSystem
{
    public partial class facultyProjectApproval : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = "";
            try
            {
                if (Session["role"].ToString() != null)
                {
                    id = Session["role"].ToString();
                }
                //SqlDataSource1.SelectCommand = "SELECT temp_project_tbl.project_id,project_title,technology,year,batch,status,faculty_id,subject FROM temp_project_tbl, temp_team_tbl WHERE temp_project_tbl.project_id = '" + id + "' AND temp_project_tbl.project_id = temp_team_tbl.project_id";
                SqlDataSource1.SelectCommand = "SELECT * FROM temp_project_tbl where status='pending' AND faculty_id='" + id + "'";
                if (!IsPostBack)
                {
                    projectApprovalGridView.DataSource = SqlDataSource1;
                    projectApprovalGridView.DataBind();
                }



            }
            catch (Exception ex)
            {

            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in projectApprovalGridView.Rows)
            {

                CheckBox status = (row.Cells[0].FindControl("CheckBox1") as CheckBox);

                string id = row.Cells[1].Text.ToString().Trim();

                if (status.Checked)
                {

                    updateRow(id, "approved");
                    updateTable(id);
                    // System.Diagnostics.Debug.Write(id); 
                    //Response.Write("<script>alert(' Project Approved Successfully...!');</script>");
                }
                //else
                //{
                //    updateRow(id, "pending");
                // }

            }
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("barath2145@gmail.com", "lsjiislrwkypzcpf");

            smtp.EnableSsl = true;
            MailMessage msg = new MailMessage();
            msg.Subject = "Approval of project!";
            msg.Body = "Your Project has been approved by the faculty go and check it..";
            string toAddress = "barath.p@pec.edu";
            msg.To.Add(toAddress);
            string fromAddress = "barath <barath2145@gmail.com>";
            msg.From = new MailAddress(fromAddress);
            try
            {
                smtp.Send(msg);
            }
            catch (Exception ex)
            {
                throw;
            }
            Response.Write("<script>alert('Mail Sent  Successfully! ')</script>");
            //  Response.Write("<script>alert(' Project Approved Successfully...!');</script>");
            SqlDataSource1.DataBind();
            projectApprovalGridView.DataSource = SqlDataSource1;
            projectApprovalGridView.DataBind();
            //projectApprovalGridView.DataBind();
        }
        void updateRow(string id, string st)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                string query = "UPDATE temp_project_tbl SET status = '" + st + "' WHERE project_id='" + id + "'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (Exception ex)
            {
                //
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }

        }
        void updateTable(string id)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                string query = "INSERT INTO project_tbl([project_id] ,[project_title],[technology] ,[year] ,[batch] ,[faculty_id],[subject]) SELECT [project_id],[project_title],[technology],[year],[batch],[faculty_id],[subject]FROM [CPMS].[dbo].[temp_project_tbl] WHERE temp_project_tbl.project_id='" + id + "'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (Exception ex)
            {
                //
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteTable(string id)
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand();
                string query = "DELETE FROM temp_project_tbl  WHERE project_id='" + id + "'";
                cmd.CommandText = query;
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
                con.Close();


            }


            catch (Exception ex)
            {
                //
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in projectApprovalGridView.Rows)
            {

                CheckBox status = (row.Cells[0].FindControl("CheckBox1") as CheckBox);

                string id = row.Cells[1].Text.ToString().Trim();

                if (status.Checked)
                {


                    deleteTable(id);
                    // System.Diagnostics.Debug.Write(id); 
                    Response.Write("<script>alert(' Project Rejected Successfully...!');</script>");
                }
                //else
                //{
                //    updateRow(id, "pending");
                // }

            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow row in projectApprovalGridView.Rows)
            {

                CheckBox status = (row.Cells[0].FindControl("CheckBox1") as CheckBox);

                string id = row.Cells[1].Text.ToString().Trim();

                if (status.Checked)
                {


                    // deleteTable(id);
                    // System.Diagnostics.Debug.Write(id); 
                    Response.Redirect("viewDetails.aspx?id=" + id + "");
                }
                //else
                //{
                //    updateRow(id, "pending");
                // }

            }
        }
    }
}
