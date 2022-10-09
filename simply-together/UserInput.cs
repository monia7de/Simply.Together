using System;

namespace simply_together
{
    public class UserInput
    {
        UIManager uiManager = new();
        Mixologist mixologist = new();

         internal void GetDrinkTypesInput()
        {
           // mixologist.GetDrinkTypes();

            uiManager.ChooseDrinkType();
            string drinkType = Console.ReadLine();

            while (!Validation.IsStringValid(drinkType))
            {
                UIManager.InvalidDrinkType();
                drinkType = Console.ReadLine();

            }

            GetDrinksInput(drinkType);

        }


        private void GetDrinksInput(string? drinkType)
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

        
    }
}
