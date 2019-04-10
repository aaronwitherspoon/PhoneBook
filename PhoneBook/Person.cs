using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Person
    {
        string fName;
        string lName;
        string phoneNumber;

        public string FName
        {
            get { return this.fName; }
            set { this.fName = value; }
        }
        public string LName
        {
            get { return this.lName; }
            set { this.lName = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
    }
}
