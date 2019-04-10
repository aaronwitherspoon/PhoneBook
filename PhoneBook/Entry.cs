using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Entry : Address
    {
        public Entry()
        {
        }

        public Entry(string firstName, string lastName, string phoneNumber, string street, string city, string state, string zipcode)
        {
            this.FName = firstName;
            this.LName = lastName;
            this.PhoneNumber = phoneNumber;
            this.Street = street;
            this.City = city;
            this.State = state;
            this.Zipcode = zipcode;
        }
    }
}
