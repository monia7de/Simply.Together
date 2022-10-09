using System;

namespace simply_together
{
    public class UIManager
    {
        Mixologist mixologist = new();
        

        /// <summary>
        /// Method <c>WelcomeMessage</c> prints the welcoming message to the user
        /// </summary>
        internal static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the 'Simply Together' app!");
            Console.WriteLine("Please sit there and relax while the app plans your perfect date for you!!!");
            Console.WriteLine("Press ENTER to begin!");
            Console.ReadLine();
        }


        // Add: ask the user if they want a drink (if, not, they can go straight to DateIdeas selection)


        /// <summary>
        /// Method <c>ChooseDrinkType</c> calls the mixologist to display the list of drink categories and asks the user
        /// for their choice
        /// </summary>
        internal void ChooseDrinkType()
        {
            mixologist.GetDrinkTypes();
            Console.WriteLine("What type of drink would you like?");
        }



        /// <summary>
        /// Method <c>InvalidDrinkType</c> prints the message that the user did not enter correct input
        /// </summary>
        internal static void InvalidDrinkType()
        {
            Console.WriteLine("\nInvalid drink type. Please look at the menu and choose again.");
        }


        /// <summary>
        /// Method <c>ChooseDrink</c> calls the mixologist to display the list of drinks in the chosen category 
        ///and asks the user for their choice
        /// </summary>
        internal void ChooseDrink(string? drinkType)
        {
            mixologist.GetDrinksByType(drinkType);
            Console.WriteLine("Choose a drink ID number or type 0 to go back to the drink type menu:");

        }

        /// <summary>
        /// Method <c>InvalidDrink</c> prints the message that the user did not enter correct input
        /// </summary>
        internal static void InvalidDrink()
        {
            Console.WriteLine("\nInvalid drink. Please look at the drink selection and type in the ID number again.");
        }


        /// <summary>
        /// Method <c>ChooseNumberOfParticipants</c> displays the menu with a choice of three types of dates
        /// </summary>
        public void ChooseNumberOfParticipants()
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

