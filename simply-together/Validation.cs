using System;

namespace simply_together
{
    public class Validation
    {
        internal static bool IsStringValid(string? drinkType)
        {
            if (String.IsNullOrEmpty(drinkType))
            {
                return false;
            }

            foreach (char c in drinkType)
            {
                if (!Char.IsLetter(c) && c != ' ')
                return false;
            }

            return true;
        }

        public static bool IsIdValid(string? drink)
        {
            if (String.IsNullOrEmpty(drink))
            {
                return false;
            }

            foreach (char c in drink)
            {
                if (!Char.IsDigit(c))
                    return false;
            }

            return true;
        }

        internal string IsNoOfParticipantsValid(string? numberOfParticipants)
        {
            while (string.IsNullOrEmpty(numberOfParticipants))
            {
                Console.WriteLine("Invalid Command. Please type a number between 1-3 \n");
                numberOfParticipants = Console.ReadLine();

            }
            return numberOfParticipants;
        }
    }
}
