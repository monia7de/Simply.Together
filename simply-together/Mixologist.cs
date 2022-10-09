using System;

using Newtonsoft.Json;
using RestSharp;
using simply_together.Models;

namespace simply_together
{
    public class Mixologist
    {
        internal void GetDrinkTypes()
        {
            var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1");
            var request = new RestRequest("list.php?c=list");
            var response = client.ExecuteAsync(request);

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<DrinkTypes>(rawResponse);

            List<DrinkType> returnedList = serialize.DrinkTypesList;

            TableVisualisation.DisplayTable(returnedList, "Drinks Menu");

                
            }
        }

        internal void GetDrinksByType(string? drinkType)
        {
            var client = new RestClient("http://www.thecocktaildb.com/api/json/v1/1/");
            var request = new RestRequest($"filter.php?c={System.Web.HttpUtility.UrlEncode(drinkType)}");
            var response = client.ExecuteAsync(request);

            if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                string rawResponse = response.Result.Content;
                var serialize = JsonConvert.DeserializeObject<Drinks>(rawResponse);
                List<Drink> returnedList = serialize.DrinksList;

                TableVisualisation.DisplayTable(returnedList, "Drinks Selection");
                
            }
        }
    }
}
