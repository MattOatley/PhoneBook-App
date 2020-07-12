using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UserInt :Contact
    {

        public static void Introduction()
        {
            Console.WriteLine("Welcome to your phonebook!");
            Console.WriteLine("How would you like to proceed?");
            Console.WriteLine("1. Create a new contact");
            Console.WriteLine("2. Read all contacts");
            Console.WriteLine("3. Update an existing contact");
            Console.WriteLine("4. Delete an existing contact");
            Console.WriteLine("5. End the application");
        }


        public static void UserSelection()
        {
            string userAnswer = Console.ReadLine();
            switch (userAnswer)
            {
                case "1":
                    AddContact();

                    Introduction();
                    UserSelection();
                    break;
                case "2":
                    ReadContacts();

                    Introduction();
                    UserSelection();
                    break;
                case "3":
                    UpdateContacts();

                    Introduction();
                    UserSelection();
                    break;
                case "4":

            }
        }

        public static void AddContact()
        {

            Console.WriteLine("Please enter a the contacts name");
            Console.ReadLine();
            Console.WriteLine("Please enter your contacts address");
            Console.ReadLine();
            Console.WriteLine("Please enter your contacts phone number");
            Console.ReadLine();

        }

        public static string ReadContacts()
        {

        }

        public static void UpdateContacts()
        {

        }
    }
}
