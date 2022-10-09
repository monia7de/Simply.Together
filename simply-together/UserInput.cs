using System;

namespace simply_together
{
    public class UserInput
    {
        UIManager uiManager = new();
        Mixologist mixologist = new();

        

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

        public void GetActivityInput()
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
