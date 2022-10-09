using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using simply_together.Models;


namespace simply_together
{

    public class ActivityService
    {
    
        /// <summary>
        /// Method <c>GetActivityForOneAsync</c> calls the external API and gets one randomly selected date activity 
        /// suitable for a date with themselves
        /// </summary>
        public async Task GetActivityForOneAsync()
        {

                string url = "https://www.boredapi.com/api/activity?participants=1";
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                
                var dateIdea = JsonConvert.DeserializeObject<DateIdea>(jsonResponse);   
                Console.WriteLine("\n\n");
                Console.WriteLine(dateIdea.Activity);
             
        }


        /// <summary>
        /// Method <c>GetActivityForTwoAsync</c> calls the external API and gets one randomly selected date activity 
        /// suitable for a date for two people
        /// </summary>
        public async Task GetActivityForTwoAsync()   // not working at the moment
        {

                string url = "https://www.boredapi.com/api/activity?participants=2";
                HttpClient client = new HttpClient();
                var response = await client.GetAsync(url);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                
                var dateIdea = JsonConvert.DeserializeObject<DateIdea>(jsonResponse);   
                Console.WriteLine("\n\n");
                Console.WriteLine(dateIdea.Activity);
             
        }

        /// <summary>
        /// Method <c>GetActivityForGroupAsync</c> calls the external API and gets one randomly selected date activity 
        /// suitable for a group of people
        /// </summary>
        public async Task GetActivityForGroupAsync()
        {

                string url = "https://www.boredapi.com/api/activity?participants=4";
                HttpClient client = new HttpClient();

                var response = await client.GetAsync(url);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                
                var dateIdea = JsonConvert.DeserializeObject<DateIdea>(jsonResponse); 
                Console.WriteLine("\n\n");  
                Console.WriteLine(dateIdea.Activity);
             
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
        public int Price { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }

        [JsonProperty("accessibility")]
        public double Accessibility { get; set; }
    }
}



