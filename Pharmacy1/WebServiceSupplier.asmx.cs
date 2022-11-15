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
    /// Summary description for WebServiceSupplier
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceSupplier : System.Web.Services.WebService
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
        public string AutoSupplierId()
        {
            string SupplierId = null;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select SupplierID from Supplier", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();
                string id = "";
                bool records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        id = dr[0].ToString();
                    }
                    string idString = id.Substring(1);
                    int CTR = Int32.Parse(idString);
                    if (CTR >= 1 && CTR < 9)
                    {
                        CTR = CTR + 1;
                        SupplierId = "S00" + CTR;

                    }
                    else if (CTR >= 10 && CTR < 99)
                    {
                        CTR = CTR + 1;
                        SupplierId = "S0" + CTR;
                    }
                    else if (CTR > 99)
                    {
                        CTR = CTR + 1;
                        SupplierId = "S" + CTR;
                    }
                }
                else
                {
                    SupplierId = "S001";
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                SupplierId = ex.ToString();
            }
            return SupplierId;
        }

        [WebMethod]
        public string insertSupplier(string supplierID, string supplierName, string address, string contact, string email, string username, string password, string confirmPw)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into Supplier values('" + supplierID + "','" + supplierName + "','" + address + "','" + contact + "','" + email + "','" + username + "','" + password + "','" + confirmPw + "');", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }

        [WebMethod]
        public string insertProposal(string proposalID,string supplierID, string drugId, string contact, string email, string date, string price)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into Proposal values('" + proposalID + "','" + supplierID + "','" + drugId + "','" + contact + "','" + email + "','" + date + "','" + price + "');", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }


        [WebMethod]
        public DataSet getDrugName()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select DrugName from Drugs", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "Drugs");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return ds;
        }
        [WebMethod]
        public DataSet getSupplierId()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select SupplierID from Supplier", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "Supplier");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return ds;
        }
       

        [WebMethod]
        public string getDrugId(string drugName)
        {
            string DrugID = "";
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("Select DrugID from Drugs where DrugName='" + drugName + "'", sqlCon);
                SqlDataReader dr = cmd.ExecuteReader();

                Boolean records = dr.HasRows;
                if (records)
                {
                    while (dr.Read())
                    {
                        DrugID = dr[0].ToString();
                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching drug" + ex);
            }
            return DrugID;
        }

        [WebMethod]
        public DataSet getTenders()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select * from Advertisement", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "Advertisement");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return ds;
        }



    }
}

