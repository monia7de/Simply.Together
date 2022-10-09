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
    }
}
