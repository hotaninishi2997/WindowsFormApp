using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp6.Newform
{
    class submitClass
    {
        public string Institute { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int StudentRollNo { get; set; }
        public DateTime DOB { get; set; }
        public int Contact { get; set; }
        public string EmailID { get; set; }
        public string Address { get; set; }
        public int Pincode { get; set; }
        public string Landmark { get; set; }

        static string myconnstrng = ConfigurationManager.ConnectionStrings["con"].ConnectionString;

        public DataTable Select()
        {
            SqlConnection con = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                string sql = "SELECT * FROM Details";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                con.Open();
                adapter.Fill(dt);
                
            }
            catch (Exception ex)
            {
                
            }
            finally
            {
                con.Close();

            }
            return dt;
        } 
        public bool Insert(submitClass c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                string sql = "INSERT INTO Details(Institute, FirstName, LastName, StudentRollNo, DOB, Contact, EmailID, Address, Pincode, Landmark)VALUES(@Institute, @FirstName, @LastName, @StudentRollNo, @DOB, @Contact, @EmailID, @Address, @Pincode, @Landmark)";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Institute", c.Institute);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@StudentRollNo", c.StudentRollNo);
                cmd.Parameters.AddWithValue("@DOB", c.DOB);
                cmd.Parameters.AddWithValue("@Contact", c.Contact);
                cmd.Parameters.AddWithValue("@EmailID", c.EmailID);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Pincode", c.Pincode);
                cmd.Parameters.AddWithValue("@Landmark", c.Landmark);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
            }
            return isSuccess;

        }
        public bool Update(submitClass c )
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                string sql = "UPDATE Details SET Institute=@Institute, FirstName=@FirstName, LastName=@LastName, StudentRollNo=@StudentRollNo, DOB=@DOB, Contact=@Contact, EmailID=@EmailID, Address=@Address, Pincode=@Pincode, Landmark=@Landmark WHERE StudentRollNo=@StudentRollNo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@Institute", c.Institute);
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@StudentRollNo", c.StudentRollNo);
                cmd.Parameters.AddWithValue("@DOB", c.DOB);
                cmd.Parameters.AddWithValue("@Contact", c.Contact);
                cmd.Parameters.AddWithValue("@EmailID", c.EmailID);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Pincode", c.Pincode);
                cmd.Parameters.AddWithValue("@Landmark", c.Landmark);
                con.Open();

                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }


            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();

            }
            return isSuccess;

        }
        public bool Delete(submitClass c)
        {
            bool isSuccess = false;
            SqlConnection con = new SqlConnection(myconnstrng);
            try
            {
                string sql = "DELETE FROM Details WHERE StudentRollNo=@StudentRollNo";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.Parameters.AddWithValue("@StudentRollNo", c.StudentRollNo);
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                if(rows>0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;

                }
            }
            catch(Exception ex)
            {

            }
            finally
            {
                con.Close();
               
            }
            
            return isSuccess;
        }

    }

    
}
