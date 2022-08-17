using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Xml.Linq;

namespace Adding_Data_in_xml_format.Models
{
    public class CustomerRepo2
    {
        string constr = ConfigurationManager.ConnectionStrings["Customercon"].ConnectionString;
        SqlConnection con;

        public void CustomerDetails(CustomerData cd)
        {
            string[] File = Regex.Split(cd.Data.ToString(), @"\r\n");

               for(int i=0;i<File.Length;i++)
               {
                string[] dt=File[i].Split('|');
                XDocument customerDetails = new XDocument(new XDeclaration("1.0", "UTF - 8", "yes"),
                new XElement("Customer",
                new XElement("Id", dt[0]),
                new XElement("UCCNo", dt[1]),
                new XElement("Name", dt[2]),
                new XElement("Gender", dt[3]),
                new XElement("DOB", dt[4]),
                new XElement("EmailId", dt[5]),
                new XElement("MobileNo", dt[6]),
                new XElement("LandLine", dt[7]),
                new XElement("Address", dt[8]),
                new XElement("PinCode", dt[9]),
                new XElement("DepositoryType", dt[10]),
                new XElement("PanCardNo", dt[11])));


                con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand("AddCustomer", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id",  dt[0]);
                cmd.Parameters.AddWithValue("@UCCNo",dt[1]);
                cmd.Parameters.AddWithValue("@Name", dt[2]);
                cmd.Parameters.AddWithValue("@Gender", dt[3]);
                cmd.Parameters.AddWithValue("@DOB", dt[4]);
                cmd.Parameters.AddWithValue("@EmailID", dt[5]);
                cmd.Parameters.AddWithValue("@Mobile",dt[6]);
                cmd.Parameters.AddWithValue("@Landline", dt[7]);
                cmd.Parameters.AddWithValue("@Address", dt[8]);
                cmd.Parameters.AddWithValue("@PinCode", dt[9]);
                cmd.Parameters.AddWithValue("@DepositoryType",dt[10]);
                cmd.Parameters.AddWithValue("@PanCardNo", dt[11]);
                cmd.Parameters.AddWithValue("@Details", customerDetails.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
               }
        }
    }
}