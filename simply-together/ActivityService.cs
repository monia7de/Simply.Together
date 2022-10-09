using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using simply_together.Models;

/*
namespace simply_together
{
    public class ActivityService
    {
        public async Task GetActivitiesForOne()
        {
            string url = "https://www.boredapi.com/api/activity?participants=1";
            HttpClient client = new HttpClient();

            var response = await client.GetStringAsync(url);
            string jsonResponse = await response.Content.ReadAsStringAsync(); 

            var dateIdea = JsonConvert.DeserializeObject<DateIdea>(jsonResponse);

            Console.WriteLine(dateIdea.Activity);        
            

        }
    }
}
*/

namespace simply_together
{

    public class ActivityService
    {
    
        public async Task GetActivityForOneAsync()
        {
            
            //static async Task GetRandomActivityForOne()
            //{

                string url = "https://www.boredapi.com/api/activity";
                HttpClient client = new HttpClient();

                //Program program = new Program();
                //await program.GetTodoItems();
                //}

                //private async Task GetTodoItems()
                
                var response = await client.GetAsync(url);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                    
                    //Console.WriteLine(jsonResponse);


                var dateIdea = JsonConvert.DeserializeObject<DateIdea>(jsonResponse);   
                    //Todo todo = JsonConvert.DeserializeObject<Todo>(response);

                Console.WriteLine(dateIdea.Activity);

                    //Console.WriteLine(todo);
           // }


        }

    }
    public class DateIdea
    {
        [JsonProperty("activity")]
        public string Activity { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("participants")]
        public int Participants { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("accessibility")]
        public double Accessibility { get; set; }
    }
    /*
    public class Todo
    {
        public string activity { get; set; } = string.Empty;
        public string type { get; set; } = string.Empty;
        public int participants { get; set; }
        public double price { get; set; }
        public string link { get; set; } = string.Empty;
        public string key { get; set; } = string.Empty;
        public double accessibility { get; set; }

        public override string ToString()
        {
            return $"The activity that you should consider doing: {activity}.\nIt requires {participants} person(s)." +
                $"\nThe type of activity: {type}.";
        }
    }

    */






}
        