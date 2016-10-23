using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using BOFactory_CP;
using BLFactory_CP;
using Types_CP;

namespace Team2
{
    public partial class WebForm19 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FillGrid();
        }
        public void FillGrid()
        {
            IBOEmp_Code ibo = BOFactoryCP_Code.getEmpBOObject();
            IBLEmp_Code ibl = BLFactoryCP_Code.getEmpBLObject();
            ibo.Dt = ibl.getBLLEmpDataTable();
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
        protected void gridview1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            IBOEmp_Code ibo = BOFactoryCP_Code.getEmpBOObject();
            IBLEmp_Code ibl = BLFactoryCP_Code.getEmpBLObject();
            GridViewRow row = gridview1.Rows[e.RowIndex];
            HiddenField hdid = new HiddenField();
            hdid = (HiddenField)row.FindControl("hdnid1");
            int id = Convert.ToInt32(hdid.Value);
            ibo.EId = id;
            int s = ibl.DeleteTestAdminBL(ibo);
            bool b = ibl.deleteTestBLLogin(ibo);
            gridview1.EditIndex = -1;
            FillGrid();
            
        }
    }
}