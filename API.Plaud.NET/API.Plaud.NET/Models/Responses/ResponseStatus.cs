using System.Collections.Generic;
using Newtonsoft.Json;

namespace API.Plaud.NET.Models.Responses
{
    public class ResponseStatus
    {
        [JsonProperty("status")]
        public int Status { get; set; }

        [JsonProperty("data_processing")]
        public List<object> DataProcessing { get; set; }

        [JsonProperty("data_processing_chatllm")]
        public List<object> DataProcessingChatllm { get; set; }

        [JsonProperty("data_processing_transsumm")]
        public DataProcessingTranssumm DataProcessingTranssumm { get; set; }

        [JsonProperty("data_processing_ai")]
        public List<object> DataProcessingAi { get; set; }

        [JsonProperty("data_processing_chatllm_ai")]
        public List<object> DataProcessingChatllmAi { get; set; }

        [JsonProperty("data_processing_transsumm_ai")]
        public DataProcessingTranssummAi DataProcessingTranssummAi { get; set; }

        [JsonProperty("data_processing_edit")]
        public List<object> DataProcessingEdit { get; set; }
    }
}