using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy1
{
    /// <summary>
    /// Summary description for WebServiceManage
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceManage : System.Web.Services.WebService
    {

        SqlConnection sqlCon;
        public SqlConnection getConnection()
        {
            try
            {
                sqlCon = new SqlConnection("data source=SARITH-THAWEESH;database=SPC;Integrated Security=True;");
                sqlCon.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error display data" + ex);
            }
            return sqlCon;
        }
        [WebMethod]
        public string placeOrder(string orderID, string drugName, string drugQty, string date)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into Orders values('" + orderID + "','" + drugName + "','" + drugQty + "','" + date + "' );", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }
        [WebMethod]
        public string placeOrderPh(string orderID, string pharmacyName, string contact, string drugName, string drugQty, string date)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into PharmacyOrder values('" + orderID + "','" + pharmacyName + "','" + contact + "','" + drugName + "','" + drugQty + "','" + date + "' );", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }
        [WebMethod]
        public DataSet getSPCorders()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select * from Orders", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "Orders");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return ds;
        }
        [WebMethod]
        public DataSet getPharmacyOrders()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select * from PharmacyOrder", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "PharmacyOrder");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return ds;
        }

        [WebMethod]
        public string registerStaff(string staffID, string staffName, string address, string contact, string email, string username, string password, string confirmPw)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into Staff values('" + staffID + "','" + staffName + "','" + address + "','" + contact + "','" + email + "','" + username + "','" + password + "','" + confirmPw + "');", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }

        [WebMethod]
        public string registerPharmacies(string pharmacyID, string pharmacyName, string address, string contact, string email, string username, string password, string confirmPw)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into Pharmacy values('" + pharmacyID + "','" + pharmacyName + "','" + address + "','" + contact + "','" + email + "','" + username + "','" + password + "','" + confirmPw + "');", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }
    }
}
