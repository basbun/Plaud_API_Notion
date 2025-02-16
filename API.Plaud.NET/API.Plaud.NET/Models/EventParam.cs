using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class EventParam
    {
        [JsonProperty("action")]
        public string Action { get; set; }

        [JsonProperty("fileID")]
        public string FileID { get; set; }

        [JsonProperty("fileKey")]
        public string FileKey { get; set; }

        [JsonProperty("from")]
        public string From { get; set; }
    }
}