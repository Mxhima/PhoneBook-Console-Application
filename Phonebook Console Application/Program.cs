using System;

namespace Phonebook_Console_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            //Operations 
            Console.WriteLine("Hello this is my Phonebook console program");

            Console.WriteLine("Select the Operation");

            Console.WriteLine("1 Add Contact");

            Console.WriteLine("2 Display Contact by Number");

            Console.WriteLine("3 View all Contacts");

            Console.WriteLine("4 Search for contacts for a given name");

            Console.WriteLine("Press 'x' to exit");

            Console.WriteLine("");



            var UserInput = Console.ReadLine();



            var PhoneBook = new Phonebook();

            //Operation Outputs
            while (true)
            {
                switch (UserInput)

                {

                    case "1":

                        Console.WriteLine("Contact Name: ");

                        var name = Console.ReadLine();

                        Console.WriteLine("Contact Number: ");

                        var number = Console.ReadLine();



                        var newContact = new Contact(name, number);

                        PhoneBook.AddContact(newContact);

                        break;



                    case "2":

                        Console.WriteLine("Contact number to search: ");

                        var searchNumber = Console.ReadLine();

                        PhoneBook.DisplayContact(searchNumber);

                        break;



                    case "3":

                        PhoneBook.DisplayAllContact();

                        break;



                    case "4":

                        Console.WriteLine("Name search phrase: ");

                        var searchPhrase = Console.ReadLine();

                        PhoneBook.DisplayMatchingContact(searchPhrase);

                        break;



                    case "x":

                        return;



                    default:

                        Console.WriteLine("Select valid Operation");

                        break;

                }



                Console.WriteLine("Select the Operation");

                UserInput = Console.ReadLine();
            }
        }
    }
}
