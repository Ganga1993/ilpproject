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
    public partial class WebForm2 : System.Web.UI.Page
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
        void ShowDetails(int id)
       {
           IBO_Code obj = BOFactoryCP_Code.getCPBOObject();
           IBL_Code obj1 = BLFactoryCP_Code.getCPBLObject();
           obj.VId = id;
           DataSet ds = obj1.View_BL(obj);
           DataTable contacts = ds.Tables[0];
           GridView1.DataSource = ds;
           GridView1.DataBind();
           if (contacts.Rows.Count > 0)
           {
               GridView1.DataSource = contacts;
               GridView1.DataBind();
           }
           else
           {
               contacts.Rows.Add(contacts.NewRow());
               GridView1.DataSource = contacts;
               GridView1.DataBind();

               int TotalColumns = GridView1.Rows[0].Cells.Count;
               GridView1.Rows[0].Cells.Clear();
               GridView1.Rows[0].Cells.Add(new TableCell());
               GridView1.Rows[0].Cells[0].ColumnSpan = TotalColumns;
               GridView1.Rows[0].Cells[0].Text = "No Record Found";
           }
       }
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            int vid = Convert.ToInt32(vId.SelectedItem.Value);
            GridView1.EditIndex = -1;
            ShowDetails(vid);
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int vid = Convert.ToInt32(vId.SelectedItem.Value);
            GridViewRow gvr = GridView1.Rows[e.RowIndex];
            int cid = Int32.Parse(((Label)gvr.FindControl("Label1")).Text);
            IBO_Code obj = BOFactoryCP_Code.getCPBOObject();
            IBL_Code obj1 = BLFactoryCP_Code.getCPBLObject();
            obj.CPId = cid;
            int s = obj1.Delete_BL(obj);
            if (s > 0)
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Details are removed successfully')", true);
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
            ShowDetails(vid);
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            int vid = Convert.ToInt32(vId.SelectedItem.Value);
            GridView1.EditIndex = e.NewEditIndex;
            ShowDetails(vid);
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvr = GridView1.Rows[e.RowIndex];
            int cid = Int32.Parse(((Label)gvr.FindControl("lcp")).Text);
            int vid = Convert.ToInt32(vId.SelectedItem.Value);
            string name = ((TextBox)gvr.FindControl("lname")).Text;
            DateTime dob = Convert.ToDateTime(((TextBox)gvr.FindControl("ldob")).Text);
            string location = ((TextBox)gvr.FindControl("llocation")).Text;
            string gender = ((TextBox)gvr.FindControl("lgender")).Text;
            float ten = Single.Parse(((TextBox)gvr.FindControl("lten")).Text);
            float twelve = Single.Parse(((TextBox)gvr.FindControl("ltwelth")).Text);
            string edugap = ((TextBox)gvr.FindControl("lgapedu")).Text;
            string edureason = ((TextBox)gvr.FindControl("lgapreason")).Text;
            int eduyear = Int32.Parse(((TextBox)gvr.FindControl("lyear")).Text);
            string expgap = ((TextBox)gvr.FindControl("lgapexp")).Text;
            string expreason = ((TextBox)gvr.FindControl("lgapexpreason")).Text;
            int expyear = Int32.Parse(((TextBox)gvr.FindControl("lgapexpyear")).Text);
            int exp = Int32.Parse(((TextBox)gvr.FindControl("lexpyear")).Text);
            string resume = ((TextBox)gvr.FindControl("lresume")).Text;
            int tid = Int32.Parse(((Label)gvr.FindControl("ltestid")).Text);
            int ts = Int32.Parse(((Label)gvr.FindControl("lteststatus")).Text);
            int ms = Int32.Parse(((Label)gvr.FindControl("lmedstatus")).Text);
            int btid = Int32.Parse(((Label)gvr.FindControl("lbgctestid")).Text);
            int bts = Int32.Parse(((Label)gvr.FindControl("lbgcteststatus")).Text);
            IBO_Code obj = BOFactoryCP_Code.getCPBOObject();
            IBL_Code obj1 = BLFactoryCP_Code.getCPBLObject(); 
            obj.CPId = cid;
            obj.VId = vid;
            obj.CName = name;
            obj.CDob = dob;
            obj.CLocation = location;
            obj.CGender = gender;
            obj.CPTenth= ten;
            obj.CPTwelth = twelve;
            obj.CGapInEdu = edugap;
            obj.CGapReasonEdu = edureason;
            obj.CGapEduYear = eduyear;
            obj.CGapInExp = expgap;
            obj.CGapReasonExp = expreason;
            obj.CGapExpYear = expyear;
            obj.CExperience = exp;
            obj.CResume = resume;
            obj.CTestId = tid;
            obj.CTestStatus= ts;
            obj.CMedicalStatus = ms;
            obj.CBGCTestId = btid;
            obj.CBGCTestStatus = bts;
            int s = obj1.Update_BL(obj);
            if (s > 0)
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Details are modified successfully')", true);
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
            GridView1.EditIndex = -1;
            ShowDetails(vid);
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int vid = Convert.ToInt32(vId.SelectedItem.Value); 
            ShowDetails(vid);
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            IBO_Code obj = BOFactoryCP_Code.getCPBOObject();
            IBL_Code obj1 = BLFactoryCP_Code.getCPBLObject();
            DataSet ds = obj1.Display_BL();
            DataTable contacts = ds.Tables[0];
            GridView1.DataSource = ds;
            GridView1.DataBind();
            if (contacts.Rows.Count > 0)
            {
                GridView1.DataSource = contacts;
                GridView1.DataBind();
            }
            else
            {
                contacts.Rows.Add(contacts.NewRow());
                GridView1.DataSource = contacts;
                GridView1.DataBind();

                int TotalColumns = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Clear();
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                GridView1.Rows[0].Cells[0].Text = "No Record Found";
            }
        }
    }
}
