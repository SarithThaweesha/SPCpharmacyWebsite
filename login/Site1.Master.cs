using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace login
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void btnSupLog_Click(object sender, EventArgs e)
        {
            Response.Redirect("supplierLogin.aspx");
        }

        protected void btnStfLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("staffLogin.aspx");
        }

        protected void btnAdmLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminLogin.aspx");
        }

        protected void btnSupReg_Click(object sender, EventArgs e)
        {
            Response.Redirect("supplierRegister.aspx");
        }

        protected void btnPharmaLogin_Click(object sender, EventArgs e)
        {
            Response.Redirect("pharmacyLogin.aspx");
        }
    }
}