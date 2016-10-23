using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using System.Data;

namespace BO_CP
{
    //TestAndInterview Class
    public class BOTI_Code : IBOTI_Code
    {
        int status;
        int cpId;
        int testID;
        int testAdmin;
        int vacancyID;
        DateTime writtenTestDate;
        DateTime technicalInterviewDate;
        DateTime hrInterviewDate;
        DateTime createdDate;
        string createdBy;
        string wstatus;
        string tstatus;
        string hstatus;

        public int Status
        {
            get
            {
                return status;
            }
            set
            {
                status = value;
            }
        }
        public string Wstatus
        {
            get
            {
                return wstatus;
            }
            set
            {
                wstatus = value;
            }
        }
        public string Tstatus
        {
            get
            {
                return tstatus;
            }
            set
            {
                tstatus = value;
            }
        }
        public string Hstatus
        {
            get
            {
                return hstatus;
            }
            set
            {
                hstatus = value;
            }
        }
        public int cpID
        {
            get
            {
                return cpId;
            }
            set
            {
                cpId = value;
            }
        }
        public int TestID
        {
            set
            {
                testID = value;
            }
            get
            {
                return testID;
            }
        }
        public int Testadmin
        {
            set
            {
                testAdmin = value;
            }
            get
            {
                return testAdmin;
            }
        }
        public int Vacancyid
        {
            set
            {
                vacancyID = value;
            }
            get
            {
                return vacancyID;
            }
        }
        public DateTime WrittenTestdate
        {
            set
            {
                writtenTestDate = value;
            }
            get
            {
                return writtenTestDate;
            }
        }
        public DateTime TechnicalInterviewdate
        {
            set
            {
                technicalInterviewDate = value;
            }
            get
            {
                return technicalInterviewDate;
            }
        }
        public DateTime HRInterviewdate
        {
            set
            {
                hrInterviewDate = value;
            }
            get
            {
                return hrInterviewDate;
            }
        }
        public DateTime CreatedDate
        {
            set
            {
                createdDate = value;
            }
            get
            {
                return createdDate;
            }
        }
        public string CreatedBy
        {
            set
            {
                createdBy = value;
            }
            get
            {
                return createdBy;
            }
        }

        public BOTI_Code(int testID,
        int testAdmin,
        int vacancyID,
        DateTime writtenTestDate,
        DateTime technicalInterviewDate,
        DateTime hrInterviewDate,
        DateTime createdDate,
        string createdBy)
        {
            this.testID = testID;
            this.testAdmin = testAdmin;
            this.vacancyID = vacancyID;
            this.writtenTestDate = writtenTestDate;
            this.technicalInterviewDate = technicalInterviewDate;
            this.hrInterviewDate = hrInterviewDate;
            this.createdDate = createdDate;
            this.createdBy = createdBy;
        }
        public BOTI_Code()
        {
        }

        DataTable dt;
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
    }
}
