using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using BL_CP;

namespace BLFactory_CP
{
    public static class BLFactoryCP_Code
    {
        //Candidate BL Factory
        public static IBL_Code getCPBLObject()
        {
            IBL_Code ibl = new BL_Code();
            return ibl;
        }
        //Employee BL Factory
        public static IBLEmp_Code getEmpBLObject()
        {
            IBLEmp_Code iemp = new BLEmp_Code();
            return iemp;
        }
        // T and I
        public static IBLTI_Code getTIBLObject()
        {
            IBLTI_Code bltiobj = new BLTI_Code();
            return bltiobj;
        }
        public static IBLTI_Code CreateTI_BL(IBOTI_Code tiobj)
        {
             IBLTI_Code bltiobj = new BLTI_Code();
             return bltiobj;
        }
        //Login
        public static IBLLogin_Code getLoginBLObject()
        {
            IBLLogin_Code ibl = new BLLogin_Code();
            return ibl;
        }
    }
}
