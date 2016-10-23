using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using BO_CP;

namespace BOFactory_CP
{
    public static class BOFactoryCP_Code
    {
        //Candidate BO Factory
        public static IBO_Code getCPBOObject()
        {
            IBO_Code ibc = new BO_Code();
            return ibc;
        }
        //Employee BO Factory
        public static IBOEmp_Code getEmpBOObject()
        {
            IBOEmp_Code iemp = new BOEmp_Code();
            return iemp;
        }
        //TANDI
        public static IBOTI_Code getCreateBOTIObj()
        {
            IBOTI_Code botiobj = new BOTI_Code();
            return botiobj;
        }
        //Login
        public static IBOLogin_Code getLoginBOObject()
        {
            IBOLogin_Code ilogin = new BOLogin_Code();
            return ilogin;
        }
    }
}
