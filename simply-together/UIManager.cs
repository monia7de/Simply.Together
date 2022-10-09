using System;

namespace simply_together
{
    public class UIManager
    {
        Mixologist mixologist = new();
        internal void ChooseDrinkType()
        {
            mixologist.GetDrinkTypes();
            Console.WriteLine("What type of drink would you like?");
        }

        internal static void InvalidDrinkType()
        {
            Console.WriteLine("\nInvalid drink type. Please look at the menu and choose again.");
        }

        internal void ChooseDrink(string? drinkType)
        {
            mixologist.GetDrinksByType(drinkType);
            Console.WriteLine("Choose a drink id number or type 0 to go back to the drink type menu:");

        }

        internal static void InvalidDrink()
        {
            Console.WriteLine("\nInvalid drink. Please look at the drink selection and choose the id number again.");
        }

        internal static void ChooseNumberOfParticipants()
        {
            Console.WriteLine("\nEnjoy your drink, and while doing that, please think about who you would like to have your date with: ");
            Console.WriteLine("\n I'M PLANNING TO HAVE A DATE WITH:");
            Console.WriteLine("\n 1) my cat/ dog/ rubber duck (Please type 1)");
            Console.WriteLine("\n 2) a partner/ friend (Please type 2)");
            Console.WriteLine("\n 3) a group of friends (Please type 3)");
            Console.WriteLine("\n");
            Console.WriteLine("\n Type 0 if you would like to exit the app");
        }
    }
}

