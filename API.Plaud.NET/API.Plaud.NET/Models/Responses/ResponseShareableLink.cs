using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseShareableLink
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}