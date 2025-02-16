using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class TransContent
    {
        [JsonProperty("content")]
        public string Content { get; set; }

        [JsonProperty("speaker")]
        public string Speaker { get; set; }

        [JsonProperty("end_time")]
        public int EndTime { get; set; }

        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        [JsonProperty("embeddingKey")]
        public string EmbeddingKey { get; set; }
    }
}