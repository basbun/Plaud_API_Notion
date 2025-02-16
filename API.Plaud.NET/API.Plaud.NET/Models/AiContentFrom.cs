using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class AiContentFrom
    {
        [JsonProperty("info")]
        public string Info { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }

        [JsonProperty("attendees")]
        public string Attendees { get; set; }

        [JsonProperty("date_time")]
        public string DateTime { get; set; }

        [JsonProperty("conclusion")]
        public string Conclusion { get; set; }

        [JsonProperty("insert_more")]
        public string InsertMore { get; set; }

        [JsonProperty("arrangements")]
        public string Arrangements { get; set; }

        [JsonProperty("ai_suggestions")]
        public string AiSuggestions { get; set; }
    }
}