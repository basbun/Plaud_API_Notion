using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class NextDatum
    {
        [JsonProperty("membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty("membership_months")]
        public int MembershipMonths { get; set; }

        [JsonProperty("membership_seconds")]
        public int MembershipSeconds { get; set; }

        [JsonProperty("period_curr")]
        public int PeriodCurr { get; set; }

        [JsonProperty("period_left")]
        public int PeriodLeft { get; set; }

        [JsonProperty("seconds_left")]
        public int SecondsLeft { get; set; }

        [JsonProperty("seconds_total")]
        public int SecondsTotal { get; set; }

        [JsonProperty("autorenew_status")]
        public int AutorenewStatus { get; set; }
    }
}