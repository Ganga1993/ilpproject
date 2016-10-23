using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Types_CP;
using BOFactory_CP;
using BLFactory_CP;
using System.Data;

namespace Team2
{
    public partial class WebForm9 : System.Web.UI.Page
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
        void ShowDetails()
        {

            IBOTI_Code iboti = BOFactoryCP_Code.getCreateBOTIObj();
            iboti.Vacancyid = Convert.ToInt32(vId.Text);
            IBLTI_Code bl = BLFactoryCP_Code.CreateTI_BL(iboti);
            DataSet ds = bl.EditDispTI_BL(iboti);

            DataView dv = ds.Tables[0].DefaultView;
            if (ViewState["SortDirection"] != null)
                dv.Sort = ViewState["SortExpression"].ToString() + " " + ViewState["SortDirection"].ToString();
            GridView1.DataSource = ds;
            GridView1.DataBind();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {

            GridView1.EditIndex = -1;
            ShowDetails();
        }
        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            ShowDetails();
        }
        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvr = GridView1.Rows[e.RowIndex];

            int tid = Int32.Parse(((Label)gvr.FindControl("tid")).Text);
            int vid = Int32.Parse(((Label)gvr.FindControl("vid")).Text);
            DateTime wtd = Convert.ToDateTime(((TextBox)gvr.FindControl("wtd")).Text);
            DateTime tidt = Convert.ToDateTime(((TextBox)gvr.FindControl("tidt")).Text);
            DateTime hid = Convert.ToDateTime(((TextBox)gvr.FindControl("hid")).Text);

            IBOTI_Code botiobj = BOFactoryCP_Code.getCreateBOTIObj();
            botiobj.TestID = tid;
            botiobj.WrittenTestdate = wtd;
            botiobj.TechnicalInterviewdate = tidt;
            botiobj.HRInterviewdate = hid;
            IBLTI_Code bltiobj = BLFactoryCP_Code.CreateTI_BL(botiobj);
            string s = bltiobj.EditTI_BL(botiobj);
            //int s = ModifyDetails(tid,vid,rbd,wtd,tidt,hid);
            if (s.Equals("success"))
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Details are modified successfully')", true);
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
            GridView1.EditIndex = -1;
            ShowDetails();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            ShowDetails();
        }
    }
}