using System.Collections.Generic;
using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class AiContentHeader
    {
        [JsonProperty("headline")]
        public string Headline { get; set; }

        [JsonProperty("keywords")]
        public List<string> Keywords { get; set; }

        [JsonProperty("industry_category")]
        public string IndustryCategory { get; set; }

        [JsonProperty("recommend_questions")]
        public List<RecommendQuestion> RecommendQuestions { get; set; }
    }
}