using System.Collections.Generic;
using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class DataState
    {
        [JsonProperty("is_bind")]
        public int IsBind { get; set; }

        [JsonProperty("is_membership")]
        public int IsMembership { get; set; }

        [JsonProperty("autorenew_status_ios")]
        public bool AutorenewStatusIos { get; set; }

        [JsonProperty("autorenew_status_android")]
        public bool AutorenewStatusAndroid { get; set; }

        [JsonProperty("autorenew_status_web")]
        public bool AutorenewStatusWeb { get; set; }

        [JsonProperty("membership_flag")]
        public string MembershipFlag { get; set; }

        [JsonProperty("membership_type")]
        public string MembershipType { get; set; }

        [JsonProperty("next_data")]
        public List<NextDatum> NextData { get; set; }

        [JsonProperty("is_free_trial_now")]
        public int IsFreeTrialNow { get; set; }

        [JsonProperty("is_free_trial_history")]
        public int IsFreeTrialHistory { get; set; }

        [JsonProperty("is_inner")]
        public bool IsInner { get; set; }

        [JsonProperty("is_outer")]
        public bool IsOuter { get; set; }

        [JsonProperty("is_gray")]
        public bool IsGray { get; set; }

        [JsonProperty("is_virtual")]
        public bool IsVirtual { get; set; }

        [JsonProperty("created_at")]
        public int CreatedAt { get; set; }
    }
}