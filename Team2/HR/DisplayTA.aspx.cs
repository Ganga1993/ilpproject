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
    public partial class WebForm4 : System.Web.UI.Page
    {
        DataTable contacts;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                FillGrid();
            }
        }
        public void FillGrid()
        {
            IBOEmp_Code ibo = BOFactoryCP_Code.getEmpBOObject();
            IBLEmp_Code ibl = BLFactoryCP_Code.getEmpBLObject();
            ibo.Dt = ibl.getBLLEmpDataTable();
            contacts = ibo.Dt;
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
        public SortDirection direction
        {
            get
            {
                if (ViewState["dirview"] == null)
                {
                    ViewState["dirview"] = SortDirection.Ascending;
                }
                return (SortDirection) ViewState["dirview"];
            }
            set
            {
                ViewState["dirview"] = value;
            }
        }
        protected void gridview1_Sorting(object sender, GridViewSortEventArgs e)
        {
            FillGrid();
            string sortDirection = string.Empty;
            if (direction == SortDirection.Ascending)
            {
                direction = SortDirection.Descending;
                sortDirection = "Desc";
            }
            else
            {
                direction = SortDirection.Ascending;
                sortDirection = "Asc";
            }
            if (contacts != null)
            {
                contacts.DefaultView.Sort = e.SortExpression + " " + sortDirection;
                gridview1.DataSource = contacts;
                gridview1.DataBind();
            }
        }
    }
}