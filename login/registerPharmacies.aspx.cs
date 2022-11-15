using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class registerPharmacies : System.Web.UI.Page
    {
        ServiceReferenceManageDtls.WebServiceManageSoapClient obj = new ServiceReferenceManageDtls.WebServiceManageSoapClient();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string value = obj.registerPharmacies(txtPhId.Text, txtPhName.Text, txtAddress.Text, txtContact.Text, txtEmail.Text, txtUsername.Text, txtPw.Text, txtConPw.Text);
            int record = Int32.Parse(value.Trim());
            if (record >= 1)
            {
                lbltxt.Text = "Pharmacy registered and new login created!";
            }
            else
            {
                lblError.Text = "not inserted";
            }
        }
    }
}