using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace login
{
    public partial class WHouseStfManPlntHome : System.Web.UI.Page
    {
        ServiceReferenceDrug.WebServiceDrugStockSoapClient obj=new ServiceReferenceDrug.WebServiceDrugStockSoapClient();
        ServiceReferenceManageDtls.WebServiceManageSoapClient obj1 = new ServiceReferenceManageDtls.WebServiceManageSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds1 = obj1.getSPCorders();
                GridSPCOrd.DataSource = ds1;
                GridSPCOrd.DataBind();
            }
            if (!IsPostBack)
            {
                DataSet ds2 = obj1.getPharmacyOrders();
                GridPharOrd.DataSource = ds2;
                GridPharOrd.DataBind();
            }
        }

      
        protected void btnAdd_Click(object sender, EventArgs e)
        {
            string value = obj.insertDrug(txtDrugId.Text, txtDrugName.Text, txtQty.Text, txtPrice.Text);
            int record = Int32.Parse(value.Trim());
            if (record >= 1)
            {
                lbltxt.Text = "Drug added!";
            }
            else
            {
                lblError.Text = "not inserted";
            }
        }
    }
}