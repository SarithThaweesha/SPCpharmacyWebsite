using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class pharmacyHome : System.Web.UI.Page
    {
        ServiceReferenceDrug.WebServiceDrugStockSoapClient obj = new ServiceReferenceDrug.WebServiceDrugStockSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            gridDrg1.DataSource = obj.searchDrug(txtSearch.Text);
            gridDrg1.DataBind();
        }
    }
}