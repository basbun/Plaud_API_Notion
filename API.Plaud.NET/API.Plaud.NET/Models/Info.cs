using API.Plaud.NET.Models.Requests;
using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class Info
    {
        [JsonProperty("event_cat")]
        public string EventCat { get; set; }

        [JsonProperty("event_param")]
        public EventParam EventParam { get; set; }
    }
}