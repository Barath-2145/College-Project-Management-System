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
    public partial class viewDetails : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
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
            con.Close();
        }
    }
}