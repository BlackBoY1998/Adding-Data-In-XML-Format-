using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml;
using System.Xml.Linq;

namespace Adding_Data_in_xml_format.Models
{
    public class CustomerRepo
    {
        string constr = ConfigurationManager.ConnectionStrings["Customercon"].ConnectionString;
        SqlConnection con;
    
        public void CustomerDetails(Customer cust)
        {
                XDocument customerDetails = new XDocument(new XDeclaration("1.0", "UTF - 8", "yes"),
                new XElement("Customer",
                new XElement("Id", cust.Id),
                new XElement("UCCNo", cust.UCCNo),
                new XElement("Name", cust.Name),
                new XElement("Gender", cust.Gender),
                new XElement("DOB", cust.DOB),
                new XElement("EmailId", cust.EmailId),
                new XElement("MobileNo", cust.Mobile),
                new XElement("LandLine", cust.Landline),
                new XElement("Address", cust.Address),
                new XElement("PinCode", cust.PinCode),
                new XElement("DepositoryType", cust.DepositoryType),
                new XElement("PanCardNo", cust.PanCardNo)));


                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("AddCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id", cust.Id);
                cmd.Parameters.AddWithValue("@UCCNo", cust.UCCNo);
                cmd.Parameters.AddWithValue("@Name", cust.Name);
                cmd.Parameters.AddWithValue("@Gender", cust.Gender);
                cmd.Parameters.AddWithValue("@DOB", cust.DOB);
                cmd.Parameters.AddWithValue("@EmailID", cust.EmailId);
                cmd.Parameters.AddWithValue("@Mobile", cust.Mobile);
                cmd.Parameters.AddWithValue("@Landline", cust.Landline);
                cmd.Parameters.AddWithValue("@Address", cust.Address);
                cmd.Parameters.AddWithValue("@PinCode", cust.PinCode);
                cmd.Parameters.AddWithValue("@DepositoryType", cust.DepositoryType);
                cmd.Parameters.AddWithValue("@PanCardNo", cust.PanCardNo);
                cmd.Parameters.AddWithValue("@Details", customerDetails.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
        }
    }
}