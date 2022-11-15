using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace login
{
    public partial class SPC_AdminHome : System.Web.UI.Page
    {
        ServiceReferenceSupplier.WebServiceSupplierSoapClient obj = new ServiceReferenceSupplier.WebServiceSupplierSoapClient();
        ServiceReferenceDrug.WebServiceDrugStockSoapClient obj1 = new ServiceReferenceDrug.WebServiceDrugStockSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = obj.getDrugName();
                DlDrgName.DataSource = ds;
                DlDrgName.DataBind();

                DlDrgName.DataValueField = "DrugName";
                DlDrgName.DataBind();
            }

            if (!IsPostBack)
            {
                DataSet ds1 = obj1.getTenderProposal();
                GridProposal.DataSource = ds1;
                GridProposal.DataBind();

                
            }
        }

        protected void btnAdvertisement_Click(object sender, EventArgs e)
        {
            string DrugId = obj.getDrugId(DlDrgName.Text);


            string value = obj1.sendAdvertisement(DrugId, txtAmount.Text, txtDate.Text,  txtPrice.Text);
            int record = Int32.Parse(value.Trim());
            if (record >= 1)
            {
                lbltxt.Text = "Advertisement sent!";
            }
            else
            {
                lblError.Text = "not Sent";
            }
        }
    }
    }
