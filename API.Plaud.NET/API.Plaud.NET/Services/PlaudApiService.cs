using System.Collections.Generic;
using System.Threading.Tasks;
using API.Plaud.NET.Interfaces;
using API.Plaud.NET.Models.Requests;
using API.Plaud.NET.Models.Responses;

namespace API.Plaud.NET.Services
{
    /// <inheritdoc />
    public class PlaudApiService : IPlaudApiService
    {
        /// <inheritdoc />
        public string AccessToken { get; set; }
        
        /// <inheritdoc />
        public async Task<ResponseAuth> AuthenticateAsync(string username, string password)
        {
            throw new System.NotImplementedException();
        }
        
        /// <inheritdoc />
        public async Task<ResponseUser> GetMyUserAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ResponseStatus> GetStatusAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ResponseListRecordings> GetAllRecordingsAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ResponseListRecordings> GetRecordingsApplyFilterAsync(int skip, int limit, int isTrash, string sortBy, bool isDesc)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ResponseListRecordings> GetSpecificRecordingsAsync(List<string> recordingIds)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ResponseFileTags> GetFileTagsAsync()
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<ResponseShareableLink> CreateShareableLinkAsync(string recordingId, RequestShareableLinkPermissions permissions)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<string> DownloadAudioFileAsync(string recordingId)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<string> DownloadTranscriptFileAsync(string recordingId, string fileType)
        {
            throw new System.NotImplementedException();
        }

        /// <inheritdoc />
        public async Task<string> DownloadSummaryFileAsync(string recordingId, string fileType)
        {
            throw new System.NotImplementedException();
        }
    }
}