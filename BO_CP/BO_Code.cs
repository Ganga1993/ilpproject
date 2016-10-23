using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types_CP;
using System.Data;

namespace BO_CP
{
    //Candidate Class
    public class BO_Code:IBO_Code
    {
        List<int> vacancyId;
        List<int> TAId;
        //Candidate attributes
        int cPId;
        int vId;
        string cName;
        DateTime cDob;
        string cLocation;
        string cGender;
        float cPTenth;
        float cPTwelth;
        string cGapInEdu;
        string cGapReasonEdu;
        int cGapEduYear;
        string cGapInExp;
        string cGapReasonExp;
        int cGapExpYear;
        int cExperience;
        string cResume;
        int cTestId;
        int cTestStatus;
        int cMedicalStatus;
        int cBGCTestId;
        int cBGCTestStatus;
        string writtenTest;
        string technicalTestStatus;
        string hrTestStatus;

        //candidate getters and setters
        public string WrittenTestStatus
        {
            get
            {
                return writtenTest;
            }
            set
            {
                writtenTest = value;
            }
        }
        public string TechnicalTestStatus
        {
            get
            {
                return technicalTestStatus;
            }
            set
            {
                technicalTestStatus = value;
            }
        }
        public string HrTestStatus
        {
            get
            {
                return hrTestStatus;
            }
            set
            {
                hrTestStatus = value;
            }
        }
        public List<int> VacancyId
        {
            get
            {
                return vacancyId;
            }
            set
            {
                vacancyId = value;
            }
        }
        public List<int> TAID
        {
            get
            {
                return TAId;
            }
            set
            {
                TAId = value;
            }
        }
        public int CPId
        {
            get
            {
                return cPId;
            }
            set
            {
                cPId = value;
            }
        }
        public int VId
        {
            get
            {
                return vId;
            }
            set
            {
                vId = value;
            }
        }
        public string CName
        {
            get
            {
                return cName;
            }
            set
            {
                cName = value;
            }
        }
        public DateTime CDob
        {
            get
            {
                return cDob;
            }
            set
            {
                cDob = value;
            }
        }
        public string CLocation
        {
            get
            {
                return cLocation;
            }
            set
            {
                cLocation = value;
            }
        }
        public string CGender
        {
            get
            {
                return cGender;
            }
            set
            {
                cGender = value;
            }
        }
        public float CPTenth
        {
            get
            {
                return cPTenth;
            }
            set
            {
                cPTenth = value;
            }
        }
        public float CPTwelth
        {
            get
            {
                return cPTwelth;
            }
            set
            {
                cPTwelth = value;
            }
        }
        public string CGapInEdu
        {
            get
            {
                return cGapInEdu;
            }
            set
            {
                cGapInEdu = value;
            }
        }
        public string CGapReasonEdu
        {
            get
            {
                return cGapReasonEdu;
            }
            set
            {
                cGapReasonEdu = value;
            }
        }
        public int CGapEduYear
        {
            get
            {
                return cGapEduYear;
            }
            set
            {
                cGapEduYear = value;
            }
        }
        public string CGapInExp
        {
            get
            {
                return cGapInExp;
            }
            set
            {
                cGapInExp = value;
            }
        }
        public string CGapReasonExp
        {
            get
            {
                return cGapReasonExp;
            }
            set
            {
                cGapReasonExp = value;
            }
        }
        public int CGapExpYear
        {
            get
            {
                return cGapExpYear;
            }
            set
            {
                cGapExpYear = value;
            }
        }
        public int CExperience
        {
            get
            {
                return cExperience;
            }
            set
            {
                cExperience = value;
            }
        }
        public string CResume
        {
            get
            {
                return cResume;
            }
            set
            {
                cResume = value;
            }
        }
        public int CTestId
        {
            get
            {
                return cTestId;
            }
            set
            {
                cTestId = value;
            }
        }
        public int CTestStatus
        {
            get
            {
                return cTestStatus;
            }
            set
            {
                cTestStatus = value;
            }
        }
        public int CMedicalStatus
        {
            get
            {
                return cMedicalStatus;
            }
            set
            {
                cMedicalStatus = value;
            }
        }
        public int CBGCTestId
        {
            get
            {
                return cBGCTestId;
            }
            set
            {
                cBGCTestId = value;
            }
        }
        public int CBGCTestStatus
        {
            get
            {
                return cBGCTestStatus;
            }
            set
            {
                cBGCTestStatus = value;
            }
        }

        public BO_Code
        (
            int cPId,
            int vId,
            string cName,
            DateTime cDob,
            string cLocation,
            string cGender,
            float cPTenth,
            float cPTwelth,
            string cGapInEdu,
            string cGapReasonEdu,
            int cGapEduYear,
            string cGapInExp,
            string cGapReasonExp,
            int cGapExpYear,
            int cExperience,
            string cResume,
            int cTestId,
            int cTestStatus,
            int cMedicalStatus,
            int cBGCTestId,
            int cBGCTestStatus
        )
        {
            this.cPId = cPId;
            this.vId = vId;
            this.cName = cName;
            this.cDob = cDob;
            this.cLocation = cLocation;
            this.cGender = cGender;
            this.cPTenth = cPTenth;
            this.cPTwelth = cPTwelth;
            this.cGapInEdu = cGapInEdu;
            this.cGapReasonEdu = cGapReasonEdu;
            this.cGapEduYear = cGapEduYear;
            this.cGapInExp = cGapInExp;
            this.cGapReasonExp = cGapReasonExp;
            this.cGapExpYear = cGapExpYear;
            this.cExperience = cExperience;
            this.cResume = cResume;
            this.cTestId = cTestId;
            this.cTestStatus = cTestId;
            this.cMedicalStatus = cMedicalStatus;
            this.cBGCTestId = cBGCTestId;
            this.cBGCTestStatus = cBGCTestStatus;
        }
        public BO_Code()
        {
        }     
    }
}
