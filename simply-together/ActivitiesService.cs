using Newtonsoft.Json;
using RestSharp;
using simply_together;
using simply_together.Models;

public class ActivitiesService
{
    public void GetCategories()
    {

        var client = new RestClient("http://www.boredpi.com/api");
        var request = new RestRequest("/api/activity/");
        var response = client.ExecuteAsync(request);

        if (response.Result.StatusCode == System.Net.HttpStatusCode.OK)
        {
            string rawResponse = response.Result.Content;
            var serialize = JsonConvert.DeserializeObject<Categories>(rawResponse);

            List<Category> returnedList = serialize.CategoriesList;

            TableVisualisationEngine.ShowTable(returnedList, "Categories");

        }



    }
}





