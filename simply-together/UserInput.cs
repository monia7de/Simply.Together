using System;

namespace simply_together
{
    public class UserInput
    {
        UIManager uiManager = new();
        Mixologist mixologist = new();

        
        /// <summary>
        /// Method <c>GetDrinkTypesInput</c> calls the uiManager method ChooseDrinkType and takes user input 
        /// for their preferred drink category. It calls the Validation class method to check if the string is not null or empty.
        /// Calls the GetDrinksInput method to which it passes on the user's chosen drink category
        /// </summary>
         internal void GetDrinkTypesInput()
        {
            uiManager.ChooseDrinkType();
            string drinkType = Console.ReadLine();

            while (!Validation.IsStringValid(drinkType))
            {
                UIManager.InvalidDrinkType();
                drinkType = Console.ReadLine();

            }

            GetDrinksInput(drinkType);

        }


        /// <summary>
        /// Method <c>GetDrinksInput</c> calls the uiManager method ChooseDrink and takes user input 
        /// for their preferred drink from the chosen previously category. It calls the Validation class method to check if the input is valid.
        /// Calls the GetDrinksInput method to which it passes on the user's chosen drink category
        /// </summary>
        public void GetDrinksInput(string? drinkType)
        {
           
            uiManager.ChooseDrink(drinkType);
            string drink = Console.ReadLine();

            if (drink == "0")
            {
               GetDrinkTypesInput(); 
            } 

            while (!Validation.IsIdValid(drink))
            {
                UIManager.InvalidDrink();
                drink = Console.ReadLine();
            }

            mixologist.GetDrink(drink);
            
        }

        /// <summary>
        /// Method <c>GetActivityInput</c> calls the uiManager method ChooseNumberOfParticipants to offer the user a choice 
        /// of three types of dates and calls different methods for this purpose. The user can only choose to close the app.
        /// </summary>
        public void GetActivityInput()         // only case 1 works at the moment
        {
            ActivityService activityService = new();
            Validation validation = new();           
            UIManager uiManager = new();
           
            bool closeApp = false;
            while (closeApp == false)
            { 
                uiManager.ChooseNumberOfParticipants();
                string numberOfParticipants = Console.ReadLine();

                var numberOfParticipantsValidated = validation.IsNoOfParticipantsValid(numberOfParticipants);

                switch (numberOfParticipantsValidated)
                {
                    case "0":
                        Console.WriteLine("\nGoodbye!\n");
                        closeApp = true;
                        Environment.Exit(0);
                        break;

                    case "1":                        
                        activityService.GetActivityForOneAsync();
                        break;

                    case "2":
                        activityService.GetActivityForTwoAsync();
                        break;

                    case "3":
                        activityService.GetActivityForGroupAsync();
                        break;


                }

            
            }
        }
    }
}
