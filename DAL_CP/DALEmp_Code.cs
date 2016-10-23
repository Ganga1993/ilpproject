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
    //Employee Data Acess Layer
    public class DALEmp_Code : IDALEmp_Code
    {
        SqlConnection sc;
        SqlCommand sq;
        SqlDataAdapter adapt;
        SqlCommandBuilder scb;
        public void getConnection()
        {
            sc = new SqlConnection();
            sq = new SqlCommand();
            sc.ConnectionString = ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString;
            sq.CommandType = CommandType.StoredProcedure;
        }
        public bool addTestAdminValue(IBOEmp_Code iemp)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_Team2AddTA";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@eId1", iemp.EId);
                adapt = new SqlDataAdapter(sq);
                DataSet ds = new DataSet();
                scb = new SqlCommandBuilder(adapt);
                adapt.Fill(ds, "disc");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public List<int> getEmpIdValue()
        {
            IBOEmp_Code ib2 = BOFactoryCP_Code.getEmpBOObject();
            List<int> li = new List<int>();
            getConnection();
            sq.CommandText = "sp_Team2getEmpId";
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
                ib2.EmployeeId = li;
            }
            return ib2.EmployeeId;
        }
        public DataTable getEmpDatatable()
        {
            getConnection();
            sq.CommandText = "sp_team2GetEmptable";
            sq.Connection = sc;
            adapt = new SqlDataAdapter(sq);
            scb = new SqlCommandBuilder(adapt);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "disc");
            DataTable dt = ds.Tables["disc"];
            return dt;
        }
        public DataTable getDALEmpIDDatatable(IBOEmp_Code ibo)
        {
            getConnection();
            sq.CommandText = "sp_team2GetEmpIDtable";
            sq.Parameters.AddWithValue("@EID", ibo.EId);
            sq.Connection = sc;       
            adapt = new SqlDataAdapter(sq);
            scb = new SqlCommandBuilder(adapt);
            DataSet ds = new DataSet();
            adapt.Fill(ds, "disc");
            DataTable dt = ds.Tables["disc"];
            return dt;
        }
        public int DeleteTestAdminDal(IBOEmp_Code ibo)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_DeleteTestAdmin";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@eId", ibo.EId);
                adapt = new SqlDataAdapter(sq);
                DataSet ds = new DataSet();
                scb = new SqlCommandBuilder(adapt);
                adapt.Fill(ds, "disc");
                return 1;
            }
            catch (Exception e)
            {
                return 0;
            }
        }
        public bool addDALTALogin(IBOEmp_Code bo)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_team2ADDTestAdmin";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@password", "tcshyd");
                sq.Parameters.AddWithValue("@username",bo.EId);
                sq.Parameters.AddWithValue("@designation","testadmin");
                adapt = new SqlDataAdapter(sq);
                DataSet ds = new DataSet();
                scb = new SqlCommandBuilder(adapt);
                adapt.Fill(ds, "disc");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool deleteDALTestLogin(IBOEmp_Code bo)
        {
            try
            {
                getConnection();
                sq.CommandText = "sp_team2DeleteTestAdmin";
                sq.Connection = sc;
                sq.Parameters.AddWithValue("@EID", bo.EId);
                adapt = new SqlDataAdapter(sq);
                DataSet ds = new DataSet();
                scb = new SqlCommandBuilder(adapt);
                adapt.Fill(ds, "disc");
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}