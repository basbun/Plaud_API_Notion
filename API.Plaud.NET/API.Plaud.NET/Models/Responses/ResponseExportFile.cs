using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseExportFile
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}