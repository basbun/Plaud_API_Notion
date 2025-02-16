using System.Collections.Generic;
using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseFileTags
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("msg")]
        public string Msg { get; set; }

        [JsonProperty("data_filetag_total")]
        public int DataFiletagTotal { get; set; }

        [JsonProperty("data_filetag_list")]
        public List<DataFiletagList> DataFiletagList { get; set; }
    }
}