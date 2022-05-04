﻿using System;

namespace ConsoleUI
{
    class Program
    {
        /*
         * Single Responsibility Principle - A class should have only one responsibility. A class should only have one
         * reason to change.
         * 
         * As written, if we want to change the way we talk to the user, the class will need to change. If we want to
         * change how we capture the user data, the class will need to change.
         * 
         * If we decide to change how we validate names, the class will need to change.
         * 
         * If we decide to change how we generate user names, this class will need to change.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my application!");

            // Ask for user information.
            Person user = new Person();

            Console.Write("What is your first name? ");
            user.FirstName = Console.ReadLine();

            Console.Write("What is your last name? ");
            user.LastName = Console.ReadLine();

            // Checks to make sure first and last names are valid.
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                Console.WriteLine("You did not give a valid first name.");
                Console.ReadLine();
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                Console.WriteLine("You did not give a valid last name.");
                Console.ReadLine();
                return;
            }

            // Create a username for the person.
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            Console.ReadLine();
        }
    }
}
