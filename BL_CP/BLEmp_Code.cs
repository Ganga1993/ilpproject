using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using BOFactory_CP;
using DALFactory_CP;
using System.Data;

namespace BL_CP
{
    //Employee Business Logic.
    public class BLEmp_Code : IBLEmp_Code
    {
        public string addTestAdmin(IBOEmp_Code iemp)
        {
            IDALEmp_Code dlc = DALFactoryCP_Code.getEmpDALObject();
            if (dlc.addTestAdminValue(iemp))
            {
                return "done";
            }
            else
            {
                return "error";
            }
        }
        public List<int> getEmpId()
        {
            IBOEmp_Code ib1 = BOFactoryCP_Code.getEmpBOObject();
            IDALEmp_Code idal = DALFactoryCP_Code.getEmpDALObject();
            ib1.EmployeeId = idal.getEmpIdValue();
            return ib1.EmployeeId;
        }
        public DataTable getBLLEmpDataTable()
        {
            IDALEmp_Code dlc = DALFactoryCP_Code.getEmpDALObject();
            DataTable dt = dlc.getEmpDatatable();
            return dt;
        }
        public DataTable getBLLEmpIDDataTable(IBOEmp_Code ibo)
        {
            IDALEmp_Code dlc = DALFactoryCP_Code.getEmpDALObject();
            DataTable dt = dlc.getDALEmpIDDatatable(ibo);
            return dt;
        }
        public int DeleteTestAdminBL(IBOEmp_Code ibo)
        {
            IDALEmp_Code idl = DALFactoryCP_Code.getEmpDALObject();
            int r = idl.DeleteTestAdminDal(ibo);
            return r;
        }
        public bool addLogin(IBOEmp_Code bo)
        {
            IDALEmp_Code idl = DALFactoryCP_Code.getEmpDALObject();
            bool s = idl.addDALTALogin(bo);
            return s;
        }
        public bool deleteTestBLLogin(IBOEmp_Code ibo)
        {
            IDALEmp_Code idl = DALFactoryCP_Code.getEmpDALObject();
            bool s = idl.deleteDALTestLogin(ibo);
            return s;
        }
    }
}
