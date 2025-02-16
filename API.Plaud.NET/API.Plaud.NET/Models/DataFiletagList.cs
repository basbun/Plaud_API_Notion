using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class DataFiletagList
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("icon")]
        public string Icon { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }
    }
}