using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Timers;

namespace CollegeProjectManagementSystem
{
    public partial class uploadFile : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Request.QueryString["p_id"] != null)
                {
                    string pId = Request.QueryString["p_id"].ToString().Trim();
                    projectId.Text = pId;
                }




            }
            catch (Exception ex)
            {
                Response.Write("<scritp>alert('" + ex.Message + "')</script>");
            }
        }

        protected void fileUploadBtn_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(db);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("UPDATE project_tbl SET fileName=@fileName,filePath=@filePath WHERE project_id='" + projectId.Text.ToString().Trim() + "'", con);
            string fileName = projectId.Text.ToString().Trim() + Path.GetExtension(file.FileName);

            string contenType = file.PostedFile.ContentType;

            //  if(contenType == ".pdf")
            //  {

            string filePath = "~/Files/" + fileName;

            file.PostedFile.SaveAs(Server.MapPath("~/Files/" + fileName));

            cmd.Parameters.AddWithValue("@FileName", fileName);

            cmd.Parameters.AddWithValue("@FilePath", filePath);



            cmd.ExecuteNonQuery();
            Response.Write("<script>alert('File Uploaded Successfully')</script>");
            con.Close();
            //  }
            // else
            //   {
            //    Response.Write("<script>alert(' Upload File in pdf Format only ')</script>");
            //   }



        }
    }
}