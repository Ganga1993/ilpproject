using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BOFactory_CP;
using System.Configuration;
using Types_CP;

namespace DAL_CP
{
    //T and I
    public class DALTI_Code : IDALTI_Code
    {
        SqlConnection sc;
        SqlCommand sq;
        SqlDataAdapter adapt;
        SqlCommandBuilder scb;
        DataTable dt;
        DataRow dr;
        public void getConnection()
        {
            sc = new SqlConnection();
            sq = new SqlCommand();
            sc.ConnectionString = ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString;
            sq.CommandType = CommandType.StoredProcedure;
        }
        public bool CreateTI_DAL(IBOTI_Code tiobj)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ToString());
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_Team2CreateTI";
                cmd.Connection = conn;
                conn.Open();
                cmd.Parameters.AddWithValue("@testid", tiobj.TestID);
                cmd.Parameters.AddWithValue("@testadmin", tiobj.Testadmin);
                cmd.Parameters.AddWithValue("@vacancyid", tiobj.Vacancyid);
                cmd.Parameters.AddWithValue("@writtentestdate", tiobj.WrittenTestdate);
                cmd.Parameters.AddWithValue("@technicalinterviewdate", tiobj.TechnicalInterviewdate);
                cmd.Parameters.AddWithValue("@hrinterviewdate", tiobj.HRInterviewdate);
                cmd.Parameters.AddWithValue("@createdby", tiobj.CreatedBy);
                cmd.Parameters.AddWithValue("@createddate", tiobj.CreatedDate);
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occured:" + e.Message);
                return false;
            }
        }
        public DataSet DisplayTI_DAL(IBOTI_Code tiobj)
        {
            try
            {
               
                SqlConnection con = new SqlConnection( ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_test11";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@vid", tiobj.Vacancyid);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "dispTI");
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured:" + ex.Message);
                return null;
            }
        }
        public bool EditTI_DAL(IBOTI_Code tiobj)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_test33";
                cmd.Connection = con;

                cmd.Parameters.AddWithValue("@tid", tiobj.TestID);
                cmd.Parameters.AddWithValue("@wtd", tiobj.WrittenTestdate);
                cmd.Parameters.AddWithValue("@tidt", tiobj.TechnicalInterviewdate);
                cmd.Parameters.AddWithValue("@hid", tiobj.HRInterviewdate);

                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured:" + ex.Message);
                return false;
            }
        }
        public DataSet EditDispTI_DAL(IBOTI_Code tiobj)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_test22";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@vid", tiobj.Vacancyid);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "edispTI");
                return ds;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occured:" + ex.Message);
                return null;
            }
        }
        public DataTable GetMSDetails_DAL(IBOTI_Code tiobj)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_getMS";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@vId",tiobj.Vacancyid);
                adapt = new SqlDataAdapter(sq);
                scb = new SqlCommandBuilder(adapt);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "disc");
                DataTable dt = ds.Tables["disc"];
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception Occired:" + e.Message);
                return null;
            }
        }
        public DataTable getTSDetails_DAL(IBOTI_Code ibt)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_getTS";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@vId", ibt.Vacancyid);
                adapt = new SqlDataAdapter(sq);
                scb = new SqlCommandBuilder(adapt);
                DataSet ds = new DataSet();
                adapt.Fill(ds, "disc");
                DataTable dt = ds.Tables["disc"];
                return dt;
            }
            catch (Exception e)
            {
                return null;
            }
        }
        public bool updateTSDetails_DAL(IBOTI_Code ibt)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_updateTS";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@wstatus", ibt.Wstatus);
                sq.Parameters.AddWithValue("@tstatus", ibt.Tstatus);
                sq.Parameters.AddWithValue("@hstatus", ibt.Hstatus);
                sq.Parameters.AddWithValue("@status", ibt.Status);
                sq.Parameters.AddWithValue("@cpId", ibt.cpID);
                DataSet ds = new DataSet();
                adapt = new SqlDataAdapter(sq);
                adapt.Fill(ds);
                scb = new SqlCommandBuilder(adapt);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
        public bool ADDDALTestID(IBOTI_Code ibo)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_Team2AddTestID";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@cTestId", ibo.TestID);
                sq.Parameters.AddWithValue("@vId", ibo.Vacancyid);
                DataSet ds = new DataSet();
                adapt = new SqlDataAdapter(sq);
                adapt.Fill(ds);
                return true;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
