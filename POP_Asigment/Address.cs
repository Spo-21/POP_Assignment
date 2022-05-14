using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POP_Asigment
{
    internal class Address
    {
        public string Street { get; set; }
        public string City { get; set; }
        public string Country{ get; set; }

        public string FullAddress
        {
            get
            {
                return $"{Street} {City} {Country}";
            }
        }

        public Address()
        {
        }

        public Address(string street, string city, string country)
        {
            Street = street;
            City = city;
            Country = country;
        }
    }
}
