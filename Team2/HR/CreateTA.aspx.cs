using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BOFactory_CP;
using Types_CP;
using BLFactory_CP;
using System.Data;

namespace Team2
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                IBOEmp_Code ibo = BOFactoryCP_Code.getEmpBOObject();
                IBLEmp_Code ibl = BLFactoryCP_Code.getEmpBLObject();
                ibo.EmployeeId = ibl.getEmpId();
                foreach (int i in ibo.EmployeeId)
                {
                    eId.Items.Add(new ListItem(i.ToString(), i.ToString()));
                }
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            int empid = Convert.ToInt32(eId.SelectedItem.Value.ToString());
            IBOEmp_Code boemp = BOFactoryCP_Code.getEmpBOObject();
            boemp.EId = empid;
            IBLEmp_Code iemp = BLFactoryCP_Code.getEmpBLObject();
            string b = iemp.addTestAdmin(boemp);
            bool c = iemp.addLogin(boemp);
        }
        public void FillGrid()
        {
            IBOEmp_Code ibo = BOFactoryCP_Code.getEmpBOObject();
            IBLEmp_Code ibl = BLFactoryCP_Code.getEmpBLObject();
            ibo.EId = Convert.ToInt32(eId.SelectedItem.Value);
            ibo.Dt = ibl.getBLLEmpIDDataTable(ibo);
            DataTable contacts = ibo.Dt;
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
        protected void eId_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}