using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class Address
    {
        public Address(string postalCode, string address)
        {
            PostalCode = postalCode;
            DeliveryAddress = address;
        }

        public string DeliveryAddress { get; set; }
        public string PostalCode { get; set; }
    }
}
