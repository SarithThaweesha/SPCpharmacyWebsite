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
    /// Summary description for WebServiceDrugStock
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceDrugStock : System.Web.Services.WebService
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
        public bool AddStock(string drugId, string newStock)
        {
            bool records = false;
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Update Drugs set DrugQty=DrugQty + " + newStock + "  where DrugID='" + drugId + "'", sqlCon);
                SqlDataReader dr = cmdCategory.ExecuteReader();

                records = dr.HasRows;
                dr.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error update stock " + ex);
            }
            return records;
        }
        [WebMethod]
        public DataSet searchDrug(string drugId)
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select * from Drugs where DrugID='" + drugId + "'", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "Drugs");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error searching product " + ex);
            }
            return ds;
        }
        [WebMethod]
        public string insertDrug(string drugID, string drugName, string drugQty, string price)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
      SqlCommand cmd = new SqlCommand("insert into Drugs values('" + drugID + "','" + drugName + "','" + drugQty + "','" + price + "' );", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }

        [WebMethod]
        public string sendAdvertisement(string drugID, string drugAmnt, string drugQty, string price)
        {
            int noOfRec = 0;
            try
            {
                getConnection();
                SqlCommand cmd = new SqlCommand("insert into Advertisement values('" + drugID + "','" + drugAmnt + "','" + drugQty + "','" + price + "' );", sqlCon);
                noOfRec = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
            return noOfRec.ToString();
        }

        [WebMethod]
        public DataSet getDrugs()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select DrugID,DrugName from Drugs", sqlCon);
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
        public DataSet getTenderProposal()
        {
            DataSet ds = new DataSet();
            try
            {
                getConnection();
                SqlCommand cmdCategory = new SqlCommand("Select * from Proposal", sqlCon);
                SqlDataAdapter da = new SqlDataAdapter(cmdCategory);

                da.Fill(ds, "Proposal");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error" + ex);
            }
            return ds;
        }
    }
}
