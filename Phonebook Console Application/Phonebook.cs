using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Phonebook_Console_Application
{
    class Phonebook
    {
        private List<Contact> _contacts { get; set; } = new List<Contact>();

        //Display Contact Details method
        private void DisplayContactDetails(Contact contact)

        {
        
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");

        }

        //Display Contacts Details method
         private void DisplayContactsDetails(List<Contact> contacts)

        {

            foreach (var contact in contacts)

            {

                DisplayContactDetails(contact);

            }

        }
        //Add contact


        //Display contact
        public void DisplayContact(string number)
        {
            

        }

        //Display all contacts
        public void DisplayAllContact() 
        {
        
        
        
        }
        

        //Display matching Contact
        public void DisplayMatchingContact(string Searchphrase)
        {


        }
        

    }
}
