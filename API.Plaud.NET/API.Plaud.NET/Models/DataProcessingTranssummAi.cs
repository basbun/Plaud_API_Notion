using System.Collections.Generic;
using Newtonsoft.Json;

namespace API.Plaud.NET.Models
{
    public class DataProcessingTranssummAi
    {
        [JsonProperty("files_trans")]
        public List<object> FilesTrans { get; set; }

        [JsonProperty("files_summ")]
        public List<object> FilesSumm { get; set; }
    }
}