using simply_together;

public class UserInput
{
        ActivitiesService activitiesService = new();

        internal void GetCategoriesInput()
        {
            activitiesService.GetCategories();

            Console.WriteLine("Choose category:");

            string category = Console.ReadLine();

            while (!Validator.IsStringValid(category))
            {
                Console.WriteLine("\nInvalid category");
                category = Console.ReadLine();

            }

            GetDrinksInput(category);
        }

    private void GetDrinksInput(string category)
    {
        activitiesService.GetDrinksByCategory(category);
    }
}