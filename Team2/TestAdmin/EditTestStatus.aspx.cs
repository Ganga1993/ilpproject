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
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getVID();
            }
        }
        public void getVID()
        {
            IBO_Code bc1 = BOFactoryCP_Code.getCPBOObject();
            IBL_Code blc1 = BLFactoryCP_Code.getCPBLObject();
            bc1.VacancyId = blc1.getvId();
            foreach (int i in bc1.VacancyId)
            {
                vId.Items.Add(new ListItem(i.ToString(), i.ToString()));
            }
        }
        public void BindData()
        {
            IBOTI_Code bti = BOFactoryCP_Code.getCreateBOTIObj();
            bti.Vacancyid = Convert.ToInt32(vId.SelectedItem.Value);
            IBLTI_Code blti = BLFactoryCP_Code.getTIBLObject();
            DataTable contacts = blti.getTSDetails_BL(bti);
            if (contacts.Rows.Count > 0)
            {
                GridView2.DataSource = contacts;
                GridView2.DataBind();
            }
            else
            {
                contacts.Rows.Add(contacts.NewRow());
                GridView2.DataSource = contacts;
                GridView2.DataBind();

                int TotalColumns = GridView2.Rows[0].Cells.Count;
                GridView2.Rows[0].Cells.Clear();
                GridView2.Rows[0].Cells.Add(new TableCell());
                GridView2.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                GridView2.Rows[0].Cells[0].Text = "No Record Found";
            }

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            BindData();
        }
        protected void GridView2_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            BindData();
        }
        protected void GridView2_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow grd = GridView2.Rows[e.RowIndex];
            string wstatus = ((DropDownList)grd.FindControl("DropDownList1")).SelectedItem.Value;
            string tstatus = ((TextBox)grd.FindControl("TextBox2")).Text;
            string hstatus = ((TextBox)grd.FindControl("TextBox3")).Text;
            int cpid = Int32.Parse(((Label)grd.FindControl("Label1")).Text);

            IBOTI_Code ibt = BOFactoryCP_Code.getCreateBOTIObj();
            IBLTI_Code iblt = BLFactoryCP_Code.getTIBLObject();
            ibt.Wstatus = wstatus;
            ibt.Tstatus = tstatus;
            ibt.Hstatus = hstatus;
            ibt.cpID = cpid;
            if (wstatus.Equals("approved") && tstatus.Equals("approved") && hstatus.Equals("approved"))
                ibt.Status = 3;
            else if (wstatus.Equals("approved") && tstatus.Equals("approved"))
                ibt.Status = 2;
            else if (wstatus.Equals("approved"))
                ibt.Status = 1;
            else
                ibt.Status = 0;
            bool b = iblt.updateTSDetails_BL(ibt);
            if (b)
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Details are modified successfully')", true);
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
            GridView2.EditIndex = -1;
            BindData();
        }
        protected void GridView2_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            BindData();
        }
    }
}