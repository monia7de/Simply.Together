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
    }
}

