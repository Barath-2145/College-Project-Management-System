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
    public partial class projectDetails : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        string fileName = "";
        string id = "";
        List<string> sId = new List<string>(4)
        {

        };
        protected void Page_Load(object sender, EventArgs e)
        {
            id = Request.QueryString["p_id"].ToString();
            // Response.Write("<script>alert('" + id + "')</script>");
            SqlConnection con = new SqlConnection(db);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("SELECT student_id FROM [temp_team_tbl] WHERE  project_id = '" + id + "' ", con);
            //  List<string> sId = new List<string>();

            SqlDataReader dr = cmd.ExecuteReader();


            string sid = "";
            while (dr.Read())
            {
                sid = dr.GetValue(0).ToString();
                sId.Add(sid);


                // Response.Write("<script>alert('" + sid + "')</script>");
            }
            con.Close();
            //Response.Write("<script>alert('" + sId[0] + "')</script>");


            SqlConnection con2 = new SqlConnection(db);
            if (con2.State == ConnectionState.Closed)
            {
                con2.Open();
            }
            SqlCommand cmd2 = new SqlCommand("SELECT DISTINCT [project_id],[project_title],[technology],[year],[batch],[status],[faculty_id],[subject] ,[remarks],[deadline],[fileName],[filePath] FROM [CPMS].[dbo].[project_tbl] WHERE project_id='" + id + "'", con2);
            SqlDataReader dr2 = cmd2.ExecuteReader();


            while (dr2.Read())
            {
                projectId.Text = dr2.GetValue(0).ToString();
                projectTitle.Text = dr2.GetValue(1).ToString();
                year.Text = dr2.GetValue(3).ToString();
                tech.Text = dr2.GetValue(2).ToString();
                batch.Text = dr2.GetValue(4).ToString();
                status.Text = dr2.GetValue(5).ToString();
                facultyId.Text = dr2.GetValue(6).ToString();
                subject.Text = dr2.GetValue(7).ToString();
                //  Response.Write("<script>alert('" + sId[0] + "')</script>");
                remarks.Text = dr2.GetValue(8).ToString();
                deadLine.Text = dr2.GetValue(9).ToString();


                if (sId[0].Equals(""))
                {
                    studentId1.Text = "none";
                }
                else
                {
                    studentId1.Text = sId[0];
                }
                if (sId[1].Equals(""))
                {
                    studentId2.Text = "none";
                }
                else
                {
                    studentId2.Text = sId[1];
                }
                if (sId[2].Equals(""))
                {
                    studentId3.Text = "none";
                }
                else
                {
                    studentId3.Text = sId[2];
                }
                if (sId[3].Equals(""))
                {
                    studentId4.Text = "none";
                }
                else
                {
                    studentId4.Text = sId[3];
                }
                fileName = dr2.GetValue(10).ToString();
            }
            con2.Close();
        }

        protected void viewReportBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con4 = new SqlConnection(db);
            SqlCommand cmd4 = new SqlCommand("SELECT fileName FROM project_tbl WHERE project_id ='" + id + "'", con4);
            SqlDataAdapter da = new SqlDataAdapter(cmd4);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                Response.Redirect("~/FILES/" + fileName);
            }
            else
            {
                Response.Write("<script>alert('This Project doenot contain any reports...!')</script>");
            }
        }
    }
}