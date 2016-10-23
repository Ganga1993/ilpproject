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
    public partial class WebForm10 : System.Web.UI.Page
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
        protected void Button1_Click(object sender, EventArgs e)
        {
            IBOTI_Code iboti = BOFactoryCP_Code.getCreateBOTIObj();
            iboti.Vacancyid = Convert.ToInt32(vId.Text);
            IBLTI_Code bl = BLFactoryCP_Code.CreateTI_BL(iboti);
            DataSet ds = bl.DisplayTI_BL(iboti);
            DataTable contacts = ds.Tables[0];
            if (contacts.Rows.Count > 0)
            {
                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
            else
            {
                contacts.Rows.Add(contacts.NewRow());
                GridView1.DataSource = contacts;
                GridView1.DataBind();
                int totalcolumns = GridView1.Rows[0].Cells.Count;
                GridView1.Rows[0].Cells.Add(new TableCell());
                GridView1.Rows[0].Cells[0].ColumnSpan = totalcolumns;
                GridView1.Rows[0].Cells[0].Text = "No Record Found";
            }
        }
    }
}