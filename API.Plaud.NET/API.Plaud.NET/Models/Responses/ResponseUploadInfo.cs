using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseUploadInfo
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }
    }
}