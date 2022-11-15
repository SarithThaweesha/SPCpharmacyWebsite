using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace login
{
    public partial class supplierRegister : System.Web.UI.Page
    {
        ServiceReferenceSupplier.WebServiceSupplierSoapClient obj = new ServiceReferenceSupplier.WebServiceSupplierSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            

            string value = obj.insertSupplier(txtSupId.Text, txtSupName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtUsername.Text, txtPw.Text, txtConPw.Text);
            int record = Int32.Parse(value.Trim());
            if (record >= 1)
            {
                lbltxt.Text = "Supplier registered!Now you can login as a supplier";
            }
            else
            {
                lblError.Text = "not inserted";
            }
        }
    }
}