using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Types_CP
{
    //Candidate Interface
    public interface IBO_Code
    {
        int CPId { get; set; }
        int VId { get; set; }
        string CName { get; set; }
        DateTime CDob { get; set; }
        string CLocation { get; set; }
        string CGender { get; set; }
        float CPTenth { get; set; }
        float CPTwelth { get; set; }
        string CGapInEdu { get; set; }
        string CGapReasonEdu { get; set; }
        int CGapEduYear { get; set; }
        string CGapInExp { get; set; }
        string CGapReasonExp { get; set; }
        int CGapExpYear { get; set; }
        int CExperience { get; set; }
        string CResume { get; set; }
        int CTestId { get; set; }
        int CTestStatus { get; set; }
        int CMedicalStatus { get; set; }
        int CBGCTestId { get; set; }
        int CBGCTestStatus { get; set; }
        List<int> VacancyId { get; set; }
        List<int> TAID { get; set; }
        string WrittenTestStatus { get; set; }
        string TechnicalTestStatus { get; set; }
        string HrTestStatus { get; set; }
    }
    public interface IBL_Code
    {
        string addCP(IBO_Code bc);
        List<int> getvId();
        int Update_BL(IBO_Code obj);
        int Delete_BL(IBO_Code obj);
        DataSet View_BL(IBO_Code obj);
        DataSet Display_BL();
        List<int> getTAId();
        bool UpdateBLMedicalStatus(IBO_Code ibo);
    }
    public interface IDAL_Code
    {
        bool addCPValue(IBO_Code bc);
        List<int> getvIdValue();
        int Update_DAl(IBO_Code obj);
        int Delete_DAL(IBO_Code obj);
        DataSet View_DAL(IBO_Code obj);
        DataSet Display_DAL();
        List<int> getTAIdValue();
        bool UpdateDALMedicalStatus(IBO_Code ibo);
    }


    //Employee Interface
    public interface IBOEmp_Code
    {
        int EId { get; set; }
        string EName { get; set; }
        int IsTestAdmin { get; set; }
        int IsHR { get; set; }
        string EGender { get; set; }
        string EDesignation { get; set; }
        string ELocation { get; set; }
        int EExp { get; set; }
        List<int> EmployeeId { get; set; }
        DataTable Dt { get; set; }
    }
    public interface IBLEmp_Code
    {
        string addTestAdmin(IBOEmp_Code iemp);
        List<int> getEmpId();
        DataTable getBLLEmpDataTable();
        DataTable getBLLEmpIDDataTable(IBOEmp_Code ibo);
        int DeleteTestAdminBL(IBOEmp_Code ibo);
        bool addLogin(IBOEmp_Code bo);
        bool deleteTestBLLogin(IBOEmp_Code ibo);
    }
    public interface IDALEmp_Code
    {
        bool addTestAdminValue(IBOEmp_Code iemp);
        List<int> getEmpIdValue();
        DataTable getEmpDatatable();
        DataTable getDALEmpIDDatatable(IBOEmp_Code ibo);
        int DeleteTestAdminDal(IBOEmp_Code ibo);
        bool addDALTALogin(IBOEmp_Code bo);
        bool deleteDALTestLogin(IBOEmp_Code bo);
    }
    //Test And Interview 
    public interface IBOTI_Code
    {
        int Status
        {
            get;
            set;
        }
        int cpID
        {
            get;
            set;
        }
        string Wstatus
        {
            get;
            set;
        }
        string Tstatus
        {
            get;
            set;
        }
        string Hstatus
        {
            get;
            set;
        }
        int TestID
        {
            get;
            set;
        }
        int Testadmin
        {
            get;
            set;
        }
        int Vacancyid
        {
            get;
            set;
        }
        DateTime WrittenTestdate
        {
            get;
            set;
        }
        DateTime TechnicalInterviewdate
        {
            get;
            set;
        }
        DateTime HRInterviewdate
        {
            get;
            set;
        }
        DateTime CreatedDate
        {
            get;
            set;
        }
        string CreatedBy
        {
            get;
            set;
        }
        DataTable Dt { get; set;}
    }
    public interface IBLTI_Code
    {
        string CreateTI_BL(IBOTI_Code tiobj);
        DataTable GetMSDetails_BLL(IBOTI_Code tiobj);
        DataSet DisplayTI_BL(IBOTI_Code tiobj);
        string EditTI_BL(IBOTI_Code tiobj);
        DataSet EditDispTI_BL(IBOTI_Code tiobj);
        DataTable getTSDetails_BL(IBOTI_Code ibt);
        bool updateTSDetails_BL(IBOTI_Code ibt);
        bool ADDTestID(IBOTI_Code ibo);
    }
    public interface IDALTI_Code
    {
        bool CreateTI_DAL(IBOTI_Code tiobj);
        DataTable GetMSDetails_DAL(IBOTI_Code tiobj);
        DataSet DisplayTI_DAL(IBOTI_Code tiobj);
        bool EditTI_DAL(IBOTI_Code tiobj);
        DataSet EditDispTI_DAL(IBOTI_Code tiobj);
        DataTable getTSDetails_DAL(IBOTI_Code ibt);
        bool updateTSDetails_DAL(IBOTI_Code ibt);
        bool ADDDALTestID(IBOTI_Code ibo);
    }
    //Login Interface
    public interface IBOLogin_Code
    {
        int Username { get; set; }
        string Password { get; set; }
    }
    public interface IBLLogin_Code
    {
        string BLCheckLogin(IBOLogin_Code ibl);
    }
    public interface IDALLogin_Code
    {
        string CheckLogin(IBOLogin_Code obj1);
    }
}
