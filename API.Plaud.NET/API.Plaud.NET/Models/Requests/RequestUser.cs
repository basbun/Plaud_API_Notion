using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Requests
{
    public class RequestUser
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data_user")]
        public DataUser DataUser { get; set; }

        [JsonProperty("data_state")]
        public DataState DataState { get; set; }
    }
}