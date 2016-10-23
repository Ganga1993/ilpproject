using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using BOFactory_CP;
using DALFactory_CP;

namespace BL_CP
{
    //Login Code
    public class BLLogin_Code : IBLLogin_Code
    {
        public string BLCheckLogin(IBOLogin_Code ibl)
        {
            IDALLogin_Code idl = DALFactoryCP_Code.getLoginDALObject();
            string s = idl.CheckLogin(ibl);
            return s;
        }
    }
}
