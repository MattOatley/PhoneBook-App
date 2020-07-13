﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class UserInt :Contact
    {
        Contact contactList = new Contact();
        

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


        public void UserSelection()
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
                    DeleteContact();

                    Introduction();
                    UserSelection();
                    break;
                case "5":
                    EndApp();

                    Introduction();
                    UserSelection();
                    break;


            }
        }

        public void AddContact()
        {

            Console.WriteLine("Please enter a the contacts name");
            contactList.contactName = Console.ReadLine();
            Console.WriteLine("Please enter your contacts address");
            contactList.contactAddress = Console.ReadLine();
            Console.WriteLine("Please enter your contacts phone number");
            contactList.contactNumber = int.Parse(Console.ReadLine());

        }

        public static void ReadContacts()
        {

        }

        public static void UpdateContacts()
        {

        }

        public static void DeleteContact()
        {

        }

        public static void EndApp()
        {

        }
    }
}
