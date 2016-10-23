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
    //Login DAL
    public class DALLogin_Code : IDALLogin_Code
    {
        public string CheckLogin(IBOLogin_Code obj1)
        {
            SqlConnection sc = new SqlConnection();
            try
            {
                sc.ConnectionString = ConfigurationManager.ConnectionStrings["DB01HMS79ConnectionString"].ConnectionString;
                SqlCommand sq = new SqlCommand();
                sq.CommandType = CommandType.StoredProcedure;
                sq.CommandText = "sp_checklogin";
                sq.Parameters.AddWithValue("@username", obj1.Username);
                sq.Parameters.AddWithValue("@password", obj1.Password);
                sq.Connection = sc;
                SqlDataAdapter adapt = new SqlDataAdapter(sq);
                DataSet ds = new DataSet();
                SqlCommandBuilder scb = new SqlCommandBuilder(adapt);
                adapt.Fill(ds,"disc");
                DataTable dt = ds.Tables["disc"];
                DataRow dr = dt.Rows[0];
                string s = dr["designation"].ToString();
                return s;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
