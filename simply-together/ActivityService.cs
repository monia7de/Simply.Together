using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;


namespace simply_together
{
    public class ActivityService
    {
        static async Task GetActivitiesForOne()
        {
            string url = "https://www.boredapi.com/api/activity?participants=1";
            HttpClient client = new HttpClient();

            string response = await client.GetStringAsync(url);
            string jsonResponse = await response.Content.ReadAsStringAsync(); 

            var dateIdea = JsonConvert.DeserializeObject<DateIdea>(jsonResponse);

            Console.WriteLine(dateIdea.Activity);        
            

        }
    }
}
