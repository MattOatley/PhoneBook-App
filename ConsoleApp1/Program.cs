using System;
using System.Security.Cryptography.X509Certificates;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to your phonebook!");
            Console.WriteLine("How would you like to proceed?");
            Console.WriteLine("1. Create a new contact");
            Console.WriteLine("2. Read all contacts");
            Console.WriteLine("3. Update an existing contact");
            Console.WriteLine("4. Delete an existing contact");
            Console.WriteLine("5. End the application");

            int selection = int.Parse(Console.ReadLine());
            Console.WriteLine(Contact.Intro(selection)); 


           

            
        }
    }
}
