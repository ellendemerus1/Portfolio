using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp_Inlamn2
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string OrgNr { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Region { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string PhoneNr { get; set; }
    }

    //ska jag inte ha några metoder i Customer-klassen? CreateNewCustomer()?
}