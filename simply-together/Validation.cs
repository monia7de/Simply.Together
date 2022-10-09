using System;

namespace simply_together
{
    public class Validation
    {
        /// <summary>
        /// Method <c>IsStringValid</c> takes the user's inputted drink category <paramref name="drinkType/"> 
        ///and checks if the string is null or empty and returns a bool.
        /// </summary>
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

        /// <summary>
        /// Method <c>IdValid</c> takes the user's inputted drink <paramref name="drink"/> and checks if the string is null or empty
        /// and that it is chategorised as Unicode decimal digit; returns a bool
        /// </summary>
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

        /// <summary>
        /// Method <c>IsNoOfParticipantsValid</c> takes the user's preferred number of participants and checks if the string is null or empty
        /// It returns the numberOfParticipants.
        /// </summary>
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
