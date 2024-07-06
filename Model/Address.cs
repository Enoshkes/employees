using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees.Model
{
    internal class Address
    {
        public Address(string city, string streetName, int streetNumber)
        {
            City = city;
            StreetName = streetName;
            StreetNumber = streetNumber;
        }

        public string City { get; set; }

        public string StreetName { get; set; }
        public int StreetNumber { get; set; }
    }
}
