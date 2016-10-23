using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types_CP;
using BLFactory_CP;
using BOFactory_CP;

namespace Team2
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                int username = Convert.ToInt32(TextBox1.Text);
                string password = TextBox2.Text;
                IBOLogin_Code obj = BOFactoryCP_Code.getLoginBOObject();
                obj.Username = username;
                obj.Password = password;
                IBLLogin_Code ibl = BLFactoryCP_Code.getLoginBLObject();
                string s = ibl.BLCheckLogin(obj);
                string v = s.ToUpper();
                Session["id"] = username; 
                if (v.Equals("PLACEMENTCONSULTANT"))
                {
                    Response.Redirect("~/PlacementConsultant/PCHome.aspx?id="+username);
                }
                else if(v.Equals("TESTADMIN"))
                {
                    Response.Redirect("~/TestAdmin/TAHome.aspx?id="+username);
                }
                else if(v.Equals("HR"))
                {
                    Response.Redirect("~/HR/HRHome.aspx?id="+username);
                }
                else
                {
                    ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Invalid UserName Or Password')", true);
                }
            }
            catch (Exception exp)
            {
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Invalid UserName Or Password')", true);
            }
        }
    }
}