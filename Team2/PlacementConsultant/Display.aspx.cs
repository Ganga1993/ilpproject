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
    public partial class WebForm1 : System.Web.UI.Page
    {
        DataTable contacts;
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
                contacts = ds.Tables[0];
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
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            BindData();
        }
    }
}