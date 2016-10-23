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
    //T and I
    public class BLTI_Code : IBLTI_Code
    {
        public string CreateTI_BL(IBOTI_Code tiobj)
        {
            IDALTI_Code da = DALFactoryCP_Code.getCreateDALTIObj();
            if (da.CreateTI_DAL(tiobj))
                return "success";
            else
                return "fail";
        }
        public DataSet DisplayTI_BL(IBOTI_Code tiobj)
        {
            IDALTI_Code da = DALFactoryCP_Code.getCreateDALTIObj();
            return da.DisplayTI_DAL(tiobj);
        }
        public string EditTI_BL(IBOTI_Code tiobj)
        {
            IDALTI_Code da = DALFactoryCP_Code.getCreateDALTIObj();
            if (da.EditTI_DAL(tiobj))
                return "success";
            else
                return "fail";
        }
        public DataSet EditDispTI_BL(IBOTI_Code tiobj)
        {
            IDALTI_Code da = DALFactoryCP_Code.getCreateDALTIObj();
            return da.EditDispTI_DAL(tiobj);
        }
        public DataTable GetMSDetails_BLL(IBOTI_Code tiobj)
        {
            IDALTI_Code da = DALFactoryCP_Code.getCreateDALTIObj();
            DataTable dt = da.GetMSDetails_DAL(tiobj);
            return dt;
        }
        public DataTable getTSDetails_BL(IBOTI_Code ibt)
        {
            IDALTI_Code idt = DALFactoryCP_Code.getCreateDALTIObj();
            DataTable dt = idt.getTSDetails_DAL(ibt);
            return dt;
        }
        public bool updateTSDetails_BL(IBOTI_Code ibt)
        {
            IDALTI_Code idl = DALFactoryCP_Code.getCreateDALTIObj();
            if (idl.updateTSDetails_DAL(ibt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ADDTestID(IBOTI_Code ibo)
        {
            IDALTI_Code idl = DALFactoryCP_Code.getCreateDALTIObj();
            if (idl.ADDDALTestID(ibo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
