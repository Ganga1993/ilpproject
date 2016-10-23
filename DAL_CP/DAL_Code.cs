using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using BOFactory_CP;
using Types_CP;

namespace DAL_CP
{
    //Candidate Access Layer
    public class DAL_Code:IDAL_Code
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
        public bool addCPValue(IBO_Code obj)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_Team2Displaydata";
                sq.Connection = sc;
                adapt = new SqlDataAdapter(sq);
                DataSet ds = new DataSet();
                scb = new SqlCommandBuilder(adapt);
                sq.Parameters.AddWithValue("@cPId", obj.CPId);
                sq.Parameters.AddWithValue("@vId", obj.VId);
                sq.Parameters.AddWithValue("@cName", obj.CName);
                sq.Parameters.AddWithValue("@cDob", obj.CDob);
                sq.Parameters.AddWithValue("@cLocation", obj.CLocation);
                sq.Parameters.AddWithValue("@cGender", obj.CGender);
                sq.Parameters.AddWithValue("@cPTenth", obj.CPTenth);
                sq.Parameters.AddWithValue("@cPTwelth", obj.CPTwelth);
                sq.Parameters.AddWithValue("@cGapInEdu", obj.CGapInEdu);
                sq.Parameters.AddWithValue("@cGapReasonEdu", obj.CGapReasonEdu);
                sq.Parameters.AddWithValue("@cGapEduYear", obj.CGapEduYear);
                sq.Parameters.AddWithValue("@cGapInExp", obj.CGapInExp);
                sq.Parameters.AddWithValue("@cGapReasonExp", obj.CGapReasonExp);
                sq.Parameters.AddWithValue("@cGapExpYear", obj.CGapExpYear);
                sq.Parameters.AddWithValue("@cExperience", obj.CExperience);
                sq.Parameters.AddWithValue("@cResume", obj.CResume);
                sq.Parameters.AddWithValue("@cTestId", obj.CTestId);
                sq.Parameters.AddWithValue("@cTestStatus", obj.CTestStatus);
                sq.Parameters.AddWithValue("@cMedicalTestStatus", obj.CMedicalStatus);
                sq.Parameters.AddWithValue("@cBGCTestId", obj.CBGCTestId);
                sq.Parameters.AddWithValue("@cBGCTestStatus", obj.CBGCTestStatus);
                sq.Parameters.AddWithValue("@WrittenTestStatus", obj.WrittenTestStatus);
                sq.Parameters.AddWithValue("@TechnicalTestStatus", obj.TechnicalTestStatus);
                sq.Parameters.AddWithValue("@HRTestStatus", obj.HrTestStatus);
                adapt.Fill(ds,"disc");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<int> getvIdValue()
        {
            IBO_Code ib2 = BOFactoryCP_Code.getCPBOObject();
            List<int> li = new List<int>();
            getConnection();
            sq.CommandText = "sp_Team2getvId";
            sq.Connection = sc;
            adapt = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            scb = new SqlCommandBuilder(adapt);
            adapt.Fill(ds, "disc");
            DataTable dt = ds.Tables["disc"];
            foreach (DataRow dr in dt.Rows)
            {
                int s = Convert.ToInt32(dr[0].ToString());
                li.Add(s);
                ib2.VacancyId = li;
            }
            return ib2.VacancyId;
        }
        public List<int> getTAIdValue()
        {
            IBO_Code ib2 = BOFactoryCP_Code.getCPBOObject();
            List<int> li = new List<int>();
            getConnection();
            sq.CommandText = "sp_Team2getTAId";
            sq.Connection = sc;
            adapt = new SqlDataAdapter(sq);
            DataSet ds = new DataSet();
            scb = new SqlCommandBuilder(adapt);
            adapt.Fill(ds, "disc");
            DataTable dt = ds.Tables["disc"];
            foreach (DataRow dr in dt.Rows)
            {
                int s = Convert.ToInt32(dr[0].ToString());
                li.Add(s);
                ib2.TAID = li;
            }
            return ib2.TAID;
        }
        public int Update_DAl(IBO_Code obj)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_Team2updateCP", cn);
            cmd.Parameters.AddWithValue("@cPId", obj.CPId);
            cmd.Parameters.AddWithValue("@vId", obj.VId);
            cmd.Parameters.AddWithValue("@cName", obj.CName);
            cmd.Parameters.AddWithValue("@cDob", obj.CDob);
            cmd.Parameters.AddWithValue("@cLocation", obj.CLocation);
            cmd.Parameters.AddWithValue("@cGender", obj.CGender);
            cmd.Parameters.AddWithValue("@cPTenth", obj.CPTenth);
            cmd.Parameters.AddWithValue("@cPTwelth", obj.CPTwelth);
            cmd.Parameters.AddWithValue("@cGapInEdu", obj.CGapInEdu);
            cmd.Parameters.AddWithValue("@cGapReasonEdu", obj.CGapReasonEdu);
            cmd.Parameters.AddWithValue("@cGapEduYear", obj.CGapEduYear);
            cmd.Parameters.AddWithValue("@cGapInExp", obj.CGapInExp);
            cmd.Parameters.AddWithValue("@cGapReasonExp", obj.CGapReasonExp);
            cmd.Parameters.AddWithValue("@cGapExpYear", obj.CGapExpYear);
            cmd.Parameters.AddWithValue("@cExperience", obj.CExperience);
            cmd.Parameters.AddWithValue("@cResume", obj.CResume);
            cmd.Parameters.AddWithValue("@cTestId", obj.CTestId);
            cmd.Parameters.AddWithValue("@cTestStatus", obj.CTestStatus);
            cmd.Parameters.AddWithValue("@cMedicalStatus", obj.CMedicalStatus);
            cmd.Parameters.AddWithValue("@cBGCTestId", obj.CBGCTestId);
            cmd.Parameters.AddWithValue("@cBGCTestStatus", obj.CBGCTestStatus);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds);
            return 1;
        }
        public int Delete_DAL(IBO_Code obj)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_Team2DeleteCP", cn);
            cmd.Parameters.AddWithValue("@cPId", obj.CPId);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adp = new SqlDataAdapter();
            DataSet ds = new DataSet();
            adp.SelectCommand = cmd;
            adp.Fill(ds);
            return 1;
        }
        public DataSet View_DAL(IBO_Code obj)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("sp_team2GetCP", cn);
                cmd.Parameters.AddWithValue("@vId",obj.VId);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch(Exception e)
            {
                 DataSet ds = new DataSet();
                return ds;
            }
        }
        public DataSet Display_DAL()
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("sp_team2DisplayCP", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception e)
            {
                DataSet ds = new DataSet();
                return ds;
            }
        }
        public bool UpdateDALMedicalStatus(IBO_Code ibo)
        {
            try
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString);
                SqlCommand cmd = new SqlCommand("sp_team2UpdateMS", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MS",ibo.CMedicalStatus);
                cmd.Parameters.AddWithValue("@CPID",ibo.CPId);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return true;
            }
            catch (Exception e)
            {
                DataSet ds = new DataSet();
                return false;
            }
        }
    }
}
