using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
namespace login
{
    public partial class SupplierHome : System.Web.UI.Page
    {
        ServiceReferenceSupplier.WebServiceSupplierSoapClient obj = new ServiceReferenceSupplier.WebServiceSupplierSoapClient();
        ServiceReferenceDrug.WebServiceDrugStockSoapClient obj1 = new ServiceReferenceDrug.WebServiceDrugStockSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataSet ds = obj.getDrugName();
                Dldrug.DataSource = ds;
                Dldrug.DataBind();

                Dldrug.DataValueField = "DrugName";
                Dldrug.DataBind();
            }

            if(!IsPostBack)
            {
                DataSet ds1 = obj.getSupplierId();
                DlSup.DataSource = ds1;
                DlSup.DataBind();

                DlSup.DataValueField = "SupplierID";
                DlSup.DataBind();
            }

            if (!IsPostBack)
            {
                DataSet ds2 = obj.getTenders();
                GridView1.DataSource = ds2;
                GridView1.DataBind();              
            }
            if (!IsPostBack)
            {
                DataSet ds3 = obj1.getDrugs();
                GridView2.DataSource = ds3;
                GridView2.DataBind();
            }
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string DrugId = obj.getDrugId(Dldrug.Text);
            

            string value = obj.insertProposal(txtPropId.Text, DlSup.Text,  DrugId, txtContact.Text, txtEmail.Text, txtDate.Text, txtPrice.Text);
            int record = Int32.Parse(value.Trim());
            if (record >= 1)
            {
                lbltxt.Text = "Proposal submitted";
            }
            else
            {
                lblError.Text = "not inserted";
            }
        }

        
    }
}