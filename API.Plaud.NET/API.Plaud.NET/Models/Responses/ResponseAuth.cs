using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseAuth
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("access_token")]
        public string AccessToken { get; set; }

        [JsonProperty("token_type")]
        public string TokenType { get; set; }

        [JsonProperty("login_count_per_hour")]
        public int LoginCountPerHour { get; set; }

        [JsonProperty("login_total_per_hour")]
        public int LoginTotalPerHour { get; set; }
    }
}