using System;

namespace ConsoleUI
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // Checks to make sure first and last names are valid.
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                Console.WriteLine("You did not give a valid first name.");
                
                return false;
            }

            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                Console.WriteLine("You did not give a valid last name.");
                
                return false;
            }

            return true;
        }
    }
}
