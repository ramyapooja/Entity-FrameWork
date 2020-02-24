using System;
using System.Collections.Generic;

namespace EFCOREDBFirst.Models
{
    public partial class Customers
    {
        public string Customerid { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Caddress { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
