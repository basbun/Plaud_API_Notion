using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Requests
{
    public class RequestUploadInfo
    {
        [JsonProperty("info")]
        public Info Info { get; set; }
    }
}