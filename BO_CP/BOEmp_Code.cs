using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using System.Data;

namespace BO_CP
{
    //Employee Class
    public class BOEmp_Code : IBOEmp_Code
    {
        //Employee Attributes
        List<int> employeeId;
        int eId;
        string eName;
        int isTestAdmin;
        int isHR;
        string eGender;
        string Designation;
        string Location;
        int eExp;
        DataTable dt;

        //Employee getter And setter
        public DataTable Dt
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
            }
        }
        public List<int> EmployeeId
        {
            get
            {
                return employeeId;
            }
            set
            {
                employeeId = value;
            }
        }
        public int EId
        {
            get
            {
                return eId;
            }
            set
            {
                eId = value;
            }
        }
        public string EName
        {
            get
            {
                return eName;
            }
            set
            {
                eName = value;
            }
        }
        public int IsTestAdmin
        {
            get
            {
                return isTestAdmin;
            }
            set
            {
                isTestAdmin = value;
            }
        }
        public int IsHR
        {
            get
            {
                return isHR;
            }
            set
            {
                isHR = value;
            }
        }
        public string EGender
        {
            get
            {
                return eGender;
            }
            set
            {
                eGender = value;
            }
        }
        public string EDesignation
        {
            get
            {
                return Designation;
            }
            set
            {
                Designation = value;
            }
        }
        public string ELocation
        {
            get
            {
                return Location;
            }
            set
            {
                Location = value;
            }
        }
        public int EExp
        {
            get
            {
                return eExp;
            }
            set
            {
                eExp = value;
            }
        }

        public BOEmp_Code(int eId)
        {
            this.eId = eId;
        }
        public BOEmp_Code(int eId, string eName, string Location, int eExp)
        {
            this.eId = eId;
            this.eName = eName;
            this.Location = Location;
            this.eExp = eExp;
        }
        public BOEmp_Code()
        {
        }
    }
}
