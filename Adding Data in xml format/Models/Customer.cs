using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adding_Data_in_xml_format.Models
{
    public class Customer
    {
        public string Id { get; set; }
        public string UCCNo { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public DateTime DOB { get; set; }
        public string EmailId { get; set; }
        public string Mobile { get; set; }
        public string Landline { get; set; }
        public string Address { get; set; }
        public string PinCode { get; set; }
        public string DepositoryType { get; set; }
        public string PanCardNo { get; set; }
    }
}