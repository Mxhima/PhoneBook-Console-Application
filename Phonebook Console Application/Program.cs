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
                
            }
        }
    }
}
