public class UserInput
{
        ActivitiesService activitiesService = new();



        internal void GetActivitiesInput(){
            activitiesService.GetActivities();
        }
}