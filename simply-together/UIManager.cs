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
            Console.WriteLine("\nInvalid drink type. Please look at the menu and choose again");
        }

        
    }
}
