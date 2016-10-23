using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types_CP;
using BOFactory_CP;
using BLFactory_CP;

namespace Team2
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IBO_Code bc1 = BOFactoryCP_Code.getCPBOObject();
                IBL_Code blc1 = BLFactoryCP_Code.getCPBLObject();
                bc1.VacancyId = blc1.getvId();
                foreach (int i in bc1.VacancyId)
                {
                    VacancyId.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
                bc1.TAID = blc1.getTAId();
                foreach (int i in bc1.TAID)
                {
                    vId.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
            }
        }
        protected void TestAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vId.SelectedValue == "select")
            {
                Label6.Visible = true;
            }
            else
            {
                Label6.Visible = false;
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (vId.SelectedValue == "select")
            {
                Label6.Visible = true;
            }
            else
            {
                Label6.Visible = false;
            }
            if (VacancyId.SelectedValue == "select")
            {
                Label7.Visible = true;
            }
            else
            {
                Label7.Visible = false;
            }
            if (vId.SelectedValue != "select" & VacancyId.SelectedValue != "select")
            {
                int Testadmin = Convert.ToInt32(vId.SelectedValue);
                int Vacancyid = Convert.ToInt32(VacancyId.SelectedValue);
                DateTime WrittenTestdate = Convert.ToDateTime(WrittenTestDate.Text);
                DateTime TechnicalInterviewdate = Convert.ToDateTime(TechnicalInterviewDate.Text);
                DateTime HRInterviewdate = Convert.ToDateTime(HRInterviewDate.Text);

                DateTime Createddate = DateTime.Today;

                IBOTI_Code iboti = BOFactoryCP_Code.getCreateBOTIObj();
                Random rand = new Random();
                iboti.TestID = rand.Next(100000, 1000000);
                IBLTI_Code bl = BLFactoryCP_Code.CreateTI_BL(iboti);
                iboti.Testadmin = Testadmin;
                iboti.Vacancyid = Vacancyid;
                bl.ADDTestID(iboti);
                iboti.WrittenTestdate = WrittenTestdate;
                iboti.TechnicalInterviewdate = TechnicalInterviewdate;
                iboti.HRInterviewdate = HRInterviewdate;
                iboti.CreatedBy = "ABC";
                iboti.CreatedDate = Createddate;
                string reply = bl.CreateTI_BL(iboti);
                if (reply == "success")
                {
                    Console.WriteLine("Test ID is: " + iboti.TestID);
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Details are added successfully' )", true);
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
                }
            }

        }
        protected void WrittenTestDate_TextChanged(object sender, EventArgs e)
        {
            DateTime WrittenTestdate = Convert.ToDateTime(WrittenTestDate.Text);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            if (WrittenTestdate < dt)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please select future Date')", true);
            }
        }
        protected void TechnicalInterviewDate_TextChanged(object sender, EventArgs e)
        {
            DateTime TechincalInterviewdate = Convert.ToDateTime(TechnicalInterviewDate.Text);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            if (TechincalInterviewdate < dt)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please select future Date')", true);
            }
        }
        protected void HRInterviewDate_TextChanged(object sender, EventArgs e)
        {
            DateTime HRInterviewdate = Convert.ToDateTime(HRInterviewDate.Text);
            DateTime dt = new DateTime();
            dt = DateTime.Today;
            if (HRInterviewdate < dt)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please select future Date')", true);
            }
        }
    }
}