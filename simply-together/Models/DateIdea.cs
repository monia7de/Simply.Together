using System;
using Newtonsoft.Json;

namespace simply_together.Models
{
  // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
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
