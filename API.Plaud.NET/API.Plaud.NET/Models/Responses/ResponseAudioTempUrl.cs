using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseAudioTempUrl
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("temp_url")]
        public string TempUrl { get; set; }

        [JsonProperty("temp_url_opus")]
        public object TempUrlOpus { get; set; }
    }
}