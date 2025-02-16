using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using API.Plaud.NET.Constants;
using API.Plaud.NET.DataAccess;
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

        /// <summary>
        /// Instance of the PlaudApi class used for handling direct API interactions.
        /// Responsible for communicating with the Plaud backend, including authentication and data retrieval processes.
        /// </summary>
        private readonly PlaudApi _plaudApi;

        /// <summary>
        /// Provides an implementation of the IPlaudApiService interface for interacting with the Plaud API.
        /// Handles authentication, data retrieval, and management of recordings using the PlaudApi class.
        /// </summary>
        public PlaudApiService()
        {
            _plaudApi = new PlaudApi();
        }
        
        /// <inheritdoc />
        public async Task<ResponseAuth> AuthenticateAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new Exception("Username or password cannot be empty.");
            }
            
            ResponseAuth authResponse = await _plaudApi.AuthWithApiAsync(username, password);
            if (string.IsNullOrEmpty(authResponse.AccessToken))
            {
                throw new Exception("Authentication failed.");
            }
            AccessToken = authResponse.AccessToken;
            return authResponse;
        }
        
        /// <inheritdoc />
        public async Task<ResponseUser> GetMyUserAsync()
        {
            return await _plaudApi.GetDataAsync<ResponseUser>(Endpoints.GetMyUser, AccessToken);
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