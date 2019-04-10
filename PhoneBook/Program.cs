using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Entry> EList = new List<Entry>();
            string answer = "0", firstName, lastName, phone, myStreet, myCity, myState, myZipcode, search;

            EList.Add(new Entry()
            {
                FName = "Aaron",
                LName = "Witherspoon",
                PhoneNumber = "1234567890",
                Street = "123 Main St",
                City = "St Louis",
                State = "MO",
                Zipcode = "63123"
            });
            EList.Add(new Entry()
            {
                FName = "Kevin",
                LName = "Brueggeman",
                PhoneNumber = "9876543210",
                Street = "345 Hooker St",
                City = "Washington",
                State = "MO",
                Zipcode = "63090",
            });
            EList.Add(new Entry()
            {
                FName = "Praneeth",
                LName = "Medari",
                PhoneNumber = "4567891230",
                Street = "789 Claim St",
                City = "St Louis",
                State = "MO",
                Zipcode = "63125"
            });

            while (answer != "9")
            {
                answer = displayMenu();

                switch (answer)
                {
                    case "1":
                        Console.WriteLine("Enter your first name: ");
                        firstName = Console.ReadLine();
                        Console.WriteLine("Enter your last name: ");
                        lastName = Console.ReadLine();
                        Console.WriteLine("Enter your phone number without hyphens or spaces");
                        phone = Console.ReadLine();
                        Console.WriteLine("Enter your street address: ");
                        myStreet = Console.ReadLine();
                        Console.WriteLine("Enter your city: ");
                        myCity = Console.ReadLine();
                        Console.WriteLine("Enter your state: ");
                        myState = Console.ReadLine();
                        Console.WriteLine("Enter your zipcode: ");
                        myZipcode = Console.ReadLine();
                        EList.Add(new Entry()
                        {
                            FName = firstName,
                            LName = lastName,
                            PhoneNumber = phone,
                            Street = myStreet,
                            City = myCity,
                            State = myState,
                            Zipcode = myZipcode
                        });
                        Console.WriteLine("Adding {0} {1} to the phone book...", firstName, lastName);
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Enter the first name to search by: ");
                        search = Console.ReadLine();
                        foreach (Entry entry in EList)
                        {
                            if (search == entry.FName)
                            {
                                displayPeople(entry);
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Enter the last name to search by: ");
                        search = Console.ReadLine();
                        foreach (Entry entry in EList)
                        {
                            if (search == entry.LName)
                            {
                                displayPeople(entry);
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Enter the city to search by: ");
                        search = Console.ReadLine();
                        foreach (Entry entry in EList)
                        {
                            if (search == entry.City)
                            {
                                displayPeople(entry);
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Enter the state to search by: ");
                        search = Console.ReadLine();
                        foreach (Entry entry in EList)
                        {
                            if (search == entry.State)
                            {
                                displayPeople(entry);
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Enter phone number on record to delete: ");
                        search = Console.ReadLine();
                        foreach (Entry entry in EList.ToList())
                        {
                                if (search == entry.PhoneNumber)
                                {
                                    Console.WriteLine("Removing {0} {1}...", entry.FName, entry.LName);
                                    EList.Remove(entry);
                                }
                        }
                        Console.ReadLine();
                        break;
                    case "7":
                        Console.WriteLine("Enter phone number on record to update first name: ");
                        search = Console.ReadLine();
                        foreach (Entry entry in EList.ToList())
                        {
                            if (search == entry.PhoneNumber)
                            {
                                Console.WriteLine("Enter new first name: ");
                                firstName = Console.ReadLine();
                                Console.WriteLine("Updating {0} {1}...", entry.FName, entry.LName);
                                entry.FName = firstName;
                                Console.WriteLine("{0} {1} is the new name", entry.FName, entry.LName);
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "8":
                        var sortedList = EList.OrderBy(x => x.LName);
                        Console.WriteLine("Displaying phone book entries alphabetically by last name");
                        foreach (Entry entry in sortedList)
                        {
                            displayPeople(entry);
                        }
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }
        }

        public static string displayMenu()
        {
            Console.Clear();
            Console.WriteLine("PhoneBook. Choose an option:");
            Console.WriteLine("1. Add new entry");
            Console.WriteLine("2. Search by first name");
            Console.WriteLine("3. Search by last name");
            Console.WriteLine("4. Search by city");
            Console.WriteLine("5. Search by state");
            Console.WriteLine("6. Delete record");
            Console.WriteLine("7. Update first name");
            Console.WriteLine("8. Show records in last name ascending order");
            Console.WriteLine("9. Exit");
            Console.Write("Enter your selection: ");
            string answer = Console.ReadLine();
            Console.Clear();
            return answer;
        }

        public static void displayPeople(Entry entry)
        {
            Console.Write("{0} {1}, ", entry.FName, entry.LName, entry.PhoneNumber);
            Console.Write("{0}, {1}, {2}, {3} ", entry.Street, entry.City, entry.State, entry.Zipcode, entry.PhoneNumber);
            Console.Write("{0:(###)-###-####}\n", double.Parse(entry.PhoneNumber));
        }

    }
}
