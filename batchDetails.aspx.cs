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
    public partial class batchDetails : System.Web.UI.Page
    {
        string db = ConfigurationManager.ConnectionStrings["con"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            batchGridView.DataBind();
        }

        protected void goBtn_Click(object sender, EventArgs e)
        {
            if (checkBatchExist())
            {
                go();
            }
            else
            {
                Response.Write("<script>alert('Batch doesn't Exist..!');</script>");
            }
        }

        protected void addBtn_Click(object sender, EventArgs e)
        {
            if (checkBatchExist())
            {
                Response.Write("<script>alert('Batch or Batch Id Already Exist..!');</script>");
            }
            else
            {
                addBatch();
            }
        }

        protected void updateBtn_Click(object sender, EventArgs e)
        {
            if (checkBatchExist())
            {
                updateBatch();
            }
            else
            {
                Response.Write("<script>alert('Batch doesn't Exist..!');</script>");
            }
        }

        protected void deleteBtn_Click(object sender, EventArgs e)
        {
            if (checkBatchExist())
            {
                deleteBatch();
            }
            else
            {
                Response.Write("<script>alert('Department doesn't Exist..!');</script>");
            }
        }

        bool checkBatchExist()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("SELECT * FROM students_batch_tbl WHERE batch_id = '" + batchId.Text.Trim() + "' OR batch ='" + batch.Text.Trim() + "'", con);

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
            batchId.Text = "";
            batch.Text = "";
            lastDate.Text = "";
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

                SqlCommand cmd = new SqlCommand("SELECT * FROM students_batch_tbl where batch_id ='" + batchId.Text.Trim() + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();


                if (dr.HasRows)
                {

                    while (dr.Read())
                    {

                        batch.Text = dr.GetValue(1).ToString();
                        //  DateTime dateTime = DateTime.Parse(dr.GetValue(2).ToString());
                        lastDate.Text = dr.GetValue(2).ToString();

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
        void addBatch()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("INSERT INTO students_batch_tbl(batch_id,batch,last_date) VALUES (@batch_id,@batch,@last_date)", con);

                cmd.Parameters.AddWithValue("@batch_id", batchId.Text.Trim());
                cmd.Parameters.AddWithValue("@batch", batch.Text.Trim());
                cmd.Parameters.AddWithValue("@last_date", lastDate.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Batch added successfully...!');</script>");
                ClearForm();
                batchGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void updateBatch()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("UPDATE  students_batch_tbl SET  batch=@batch ,last_date=@last_date WHERE batch_id ='" + batchId.Text.Trim() + "'", con);


                cmd.Parameters.AddWithValue("@batch", batch.Text.Trim());
                cmd.Parameters.AddWithValue("@last_date", lastDate.Text.Trim());

                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Batch Details Updated successfully...!');</script>");
                ClearForm();
                batchGridView.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
        void deleteBatch()
        {
            try
            {
                SqlConnection con = new SqlConnection(db);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("DELETE FROM students_batch_tbl WHERE batch_id ='" + batchId.Text.Trim() + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('Department Deleted successfully...!');</script>");
                ClearForm();
                batchGridView.DataBind();

            }
            catch (Exception ex)
            {
                Response.Write("<script>alert('" + ex.Message + "');</script>");
            }
        }
    }
}