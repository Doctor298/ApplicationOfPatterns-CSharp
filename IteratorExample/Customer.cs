using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace IteratorExample
{
    public class Customer
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CompanyName { get; set; }

        public MailAddress Email { get; set; }

        public string ShippingAddress { get; set; }

        public string ShippingCity { get; set; }    

        public string ShippingState { get; set; }

        public string ShippingZipCode { get; set; }
    }
}
