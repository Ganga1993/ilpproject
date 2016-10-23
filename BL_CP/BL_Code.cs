using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOFactory_CP;
using DALFactory_CP;
using Types_CP;
using System.Data;

namespace BL_CP
{
    //Candidate BUsiness logic
    public class BL_Code:IBL_Code
    {
        public string addCP(IBO_Code bc)
        {
            IDAL_Code dlc = DALFactoryCP_Code.getCPDALObject();
            if (dlc.addCPValue(bc))
            {
                return "SuccessfulAttempt";
            }
            else
            {
                return "UnSuccessfulAttempt";
            }
        }
        public List<int> getvId()
        {
            IBO_Code ib1 = BOFactoryCP_Code.getCPBOObject();
            IDAL_Code dlc1 = DALFactoryCP_Code.getCPDALObject();
            ib1.VacancyId = dlc1.getvIdValue();
            return ib1.VacancyId;
        }
        public List<int> getTAId()
        {
            IBO_Code ib1 = BOFactoryCP_Code.getCPBOObject();
            IDAL_Code dlc1 = DALFactoryCP_Code.getCPDALObject();
            ib1.TAID = dlc1.getTAIdValue();
            return ib1.TAID;
        }
        public int Update_BL(IBO_Code obj)
        {
            IDAL_Code obj1 = DALFactoryCP_Code.getCPDALObject();
            int s = obj1.Update_DAl(obj);
            return s;
        }
        public int Delete_BL(IBO_Code obj)
        {
            IDAL_Code obj1 = DALFactoryCP_Code.getCPDALObject();
            int s = obj1.Delete_DAL(obj);
            return s;
        }
        public DataSet View_BL(IBO_Code obj)
        {
            IDAL_Code obj1 = DALFactoryCP_Code.getCPDALObject();
            DataSet ds = obj1.View_DAL(obj);
            return ds;
        }
        public DataSet Display_BL()
        {
            IDAL_Code obj1 = DALFactoryCP_Code.getCPDALObject();
            DataSet ds = obj1.Display_DAL();
            return ds;
        }
        public bool UpdateBLMedicalStatus(IBO_Code ibo)
        {
            IDAL_Code idl = DALFactoryCP_Code.getCPDALObject();
            bool s = idl.UpdateDALMedicalStatus(ibo);
            return s;
        }
    }
}
