public class UserInput
{
        ActivitiesService activitiesService = new();

        internal void GetCategoriesInput(){
            activitiesService.GetCategories();
        }
}