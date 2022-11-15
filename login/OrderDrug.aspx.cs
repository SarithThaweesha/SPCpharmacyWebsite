using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class OrderDrug : System.Web.UI.Page
    {
        ServiceReferenceManageDtls.WebServiceManageSoapClient obj = new ServiceReferenceManageDtls.WebServiceManageSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
            string value = obj.placeOrder(txtOrder.Text, txtDrugName.Text, txtQty.Text, txtDate.Text);
            int record = Int32.Parse(value.Trim());
            if (record >= 1)
            {
                lbltxt.Text = "Order Submitted!";
            }
            else
            {
                lblError.Text = "not inserted";
            }
        }
    }
}