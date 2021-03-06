using System;

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
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);

            if (!isUserValid)
            {
                StandardMessages.EndApplication();
                return;
            }

            // Create a username for the person.
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}");
            StandardMessages.EndApplication();
        }
    }
}
