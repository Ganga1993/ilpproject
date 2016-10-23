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
    public partial class WebForm20 : System.Web.UI.Page
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
        void fillGrid()
        {
            IBOTI_Code ibo = BOFactoryCP_Code.getCreateBOTIObj();
            IBLTI_Code ibl = BLFactoryCP_Code.getTIBLObject();
            ibo.Vacancyid = Convert.ToInt32(vId.SelectedItem.Value);
            ibo.Dt = ibl.GetMSDetails_BLL(ibo);
            DataTable contacts = ibo.Dt;
            if (contacts.Rows.Count > 0)
            {
                gridview1.DataSource = contacts;
                gridview1.DataBind();
            }
            else
            {
                contacts.Rows.Add(contacts.NewRow());
                gridview1.DataSource = contacts;
                gridview1.DataBind();

                int TotalColumns = gridview1.Rows[0].Cells.Count;
                gridview1.Rows[0].Cells.Clear();
                gridview1.Rows[0].Cells.Add(new TableCell());
                gridview1.Rows[0].Cells[0].ColumnSpan = TotalColumns;
                gridview1.Rows[0].Cells[0].Text = "No Record Found";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            fillGrid();
        }
        protected void gridview1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            GridViewRow gvr = gridview1.Rows[e.RowIndex];
            IBO_Code ibo = BOFactoryCP_Code.getCPBOObject();
            IBL_Code ibl = BLFactoryCP_Code.getCPBLObject();
            ibo.CMedicalStatus = Int32.Parse(((TextBox)gvr.FindControl("txtexperience1")).Text);
            ibo.CPId = Int32.Parse(((Label)gvr.FindControl("lblname")).Text);
            bool b = ibl.UpdateBLMedicalStatus(ibo);
            if (b)
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Details are modified successfully')", true);
            else
                ClientScript.RegisterClientScriptBlock(this.GetType(), "Message", "alert('Please recheck the details and submit them again')", true);
            gridview1.EditIndex = -1;
            fillGrid();
        }
        protected void gridview1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gridview1.EditIndex = -1;
            fillGrid();
        }
        protected void gridview1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gridview1.EditIndex = e.NewEditIndex;
            fillGrid();
        }
    }
}