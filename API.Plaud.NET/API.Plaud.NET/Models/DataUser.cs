using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class DataUser
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("avatar")]
        public object Avatar { get; set; }

        [JsonProperty("nickname")]
        public string Nickname { get; set; }

        [JsonProperty("birthday")]
        public object Birthday { get; set; }

        [JsonProperty("gender")]
        public object Gender { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("address")]
        public object Address { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("email_verified")]
        public bool EmailVerified { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("phone_verified")]
        public bool PhoneVerified { get; set; }

        [JsonProperty("membership_id")]
        public int MembershipId { get; set; }

        [JsonProperty("start_time")]
        public int StartTime { get; set; }

        [JsonProperty("expire_time")]
        public int ExpireTime { get; set; }

        [JsonProperty("reset_time")]
        public int ResetTime { get; set; }

        [JsonProperty("seconds_left")]
        public int SecondsLeft { get; set; }

        [JsonProperty("seconds_total")]
        public int SecondsTotal { get; set; }

        [JsonProperty("membership_id_traffic")]
        public int MembershipIdTraffic { get; set; }

        [JsonProperty("start_time_traffic")]
        public int StartTimeTraffic { get; set; }

        [JsonProperty("expire_time_traffic")]
        public int ExpireTimeTraffic { get; set; }

        [JsonProperty("seconds_left_traffic")]
        public int SecondsLeftTraffic { get; set; }

        [JsonProperty("seconds_total_traffic")]
        public int SecondsTotalTraffic { get; set; }
    }
}