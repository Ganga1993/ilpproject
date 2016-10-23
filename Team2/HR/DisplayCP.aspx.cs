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
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
                IBO_Code obj = BOFactoryCP_Code.getCPBOObject();
                IBL_Code obj1 = BLFactoryCP_Code.getCPBLObject();
                DataSet ds = obj1.Display_BL();
                DataTable contacts = ds.Tables[0];
                GridView2.DataSource = ds;
                GridView2.DataBind();
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
        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView2.PageIndex = e.NewPageIndex;
            BindData();
        }
    }
}