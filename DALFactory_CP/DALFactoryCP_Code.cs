using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using DAL_CP;

namespace DALFactory_CP
{
    public static class DALFactoryCP_Code
    {
        //Candidate DAL Factory
        public static IDAL_Code getCPDALObject()
        {
            IDAL_Code idl = new DAL_Code();
            return idl;
        }
        //Employee DAL Factory
        public static IDALEmp_Code getEmpDALObject()
        {
            IDALEmp_Code iemp = new DALEmp_Code();
            return iemp;
        }
        //T and I
        public static IDALTI_Code getCreateDALTIObj()
        {
            IDALTI_Code daltiobj = new DALTI_Code();
            return daltiobj;
        }
        //Login
        public static IDALLogin_Code getLoginDALObject()
        {
            IDALLogin_Code idl = new DALLogin_Code();
            return idl;
        }
    }
}
