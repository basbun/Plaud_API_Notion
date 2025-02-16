using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class ExtraData
    {
        [JsonProperty("tranConfig")]
        public TranConfig TranConfig { get; set; }

        [JsonProperty("aiContentFrom")]
        public AiContentFrom AiContentFrom { get; set; }

        [JsonProperty("aiContentHeader")]
        public AiContentHeader AiContentHeader { get; set; }
    }
}