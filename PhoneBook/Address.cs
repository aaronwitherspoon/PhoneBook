using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Address : Person
    {
        string street;
        string city;
        string state;
        string zipcode;

        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string State
        {
            get { return this.state; }
            set { this.state = value; }
        }
        public string Zipcode
        {
            get { return this.zipcode; }
            set { this.zipcode = value; }
        }
    }
}
