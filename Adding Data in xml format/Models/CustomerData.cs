using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Adding_Data_in_xml_format.Models
{
    public class CustomerData
    {
        [DisplayName("Enter The Data")]
        public string Data { get; set; }
    }
}