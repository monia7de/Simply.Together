using System;
using Newtonsoft.Json;

namespace simply_together.Models
{
    public class DrinkType
    {
        public string strCategory { get; set; } 
    }


    public class DrinkTypes
    {
        [JsonProperty("drinks")]
        public List<DrinkType> DrinkTypesList { get; set; }
    }
}
