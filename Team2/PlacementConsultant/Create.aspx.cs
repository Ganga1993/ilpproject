using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOFactory_CP;
using BLFactory_CP;
using Types_CP;

namespace Team2
{
    public partial class WebForm17 : System.Web.UI.Page
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
                    vId.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            IBO_Code bc = BOFactoryCP_Code.getCPBOObject();
            Random rand = new Random();
            bc.CPId = rand.Next(100000,1000000);
            bc.VId = Int32.Parse(vId.SelectedItem.Value);
            bc.CName = cName.Text;
            bc.CDob = Convert.ToDateTime(cDob.Text);
            bc.CLocation = cLocation.SelectedItem.Value;
            bc.CGender = cGender.SelectedItem.Value;
            bc.CPTenth = float.Parse(cPTenth.Text);
            bc.CPTwelth = float.Parse(cPTwelth.Text);
            bc.CGapInEdu = cGapInEdu.SelectedItem.Value;
            bc.CGapReasonEdu = cGapReasonEdu.Text;
            bc.CGapEduYear = Int32.Parse(cGapEduYear.Text);
            bc.CGapInExp = cGapInExp.SelectedItem.Value;
            bc.CGapReasonExp = cGapReasonExp.Text;
            bc.CGapExpYear = Int32.Parse(cGapExpYear.Text);
            bc.CExperience = Int32.Parse(cExperience.Text);
            bc.WrittenTestStatus = "pending";
            bc.TechnicalTestStatus = "pending";
            bc.HrTestStatus = "pending";
            bc.CResume = "Done";
            bc.CTestId = 0;
            bc.CTestStatus = 0;
            bc.CMedicalStatus = 0;
            bc.CBGCTestId = 0;
            bc.CBGCTestStatus = 0;
            IBL_Code blc = BLFactoryCP_Code.getCPBLObject();
            string message = blc.addCP(bc);
            if (message.Equals("SuccessfulAttempt"))
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Your Details Are Added Succesfully')", true);
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
        }
    }
}