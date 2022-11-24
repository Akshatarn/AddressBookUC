using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ContactList contact = new ContactList();
            contact.WelcomeMessage();
        ReEnteringApp:                        
            Console.WriteLine("Select any one from below options \n" +
                "Press 1 : to Create/Add a new contact\n" +
                "Press 2 : to Edit/Modify any existing contact\n" +
                "Press 3 : to view all the contacts in Address book.");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    contact.AddPerson();        
                    break;
                case 2:
                    contact.EditPerson();       
                    break;
                case 3:
                    contact.ListPeople();       
                    break;
                case 4:
                    contact.DeletePerson();
                    break;
                default:
                    Console.WriteLine("Invalid Option selected , Please try again ");
                    break;
            }
            goto ReEnteringApp;     //for repeatation of same task from start point have used goto control statement .
        }
    }
}
