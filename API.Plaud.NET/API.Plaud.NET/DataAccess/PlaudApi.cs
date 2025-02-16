using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using API.Plaud.NET.Constants;
using API.Plaud.NET.Models.Responses;
using Newtonsoft.Json;

namespace API.Plaud.NET.DataAccess
{
    /// <summary>
    /// Represents the API client for Plaud, designed to handle communication with the Plaud API.
    /// Provides methods for authenticating, retrieving, and posting data to the API using HTTP requests.
    /// </summary>
    internal class PlaudApi
    {
        /// <summary>
        /// Represents an instance of <see cref="HttpClient"/> used for handling HTTP requests
        /// and communication with the Plaud API, including setting the base address
        /// and configuring headers for authentication or specific API operations.
        /// </summary>
        private readonly HttpClient _httpClient;

        /// <summary>
        /// Represents the API client for Plaud, designed to handle communication with the Plaud API.
        /// Provides methods for authenticating, retrieving, and posting data to the API using HTTP requests.
        /// </summary>
        internal PlaudApi()
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(Endpoints.BaseUrl);
        }

        /// <summary>
        /// Sends a POST request to authenticate with the API using provided credentials and retrieves an authentication response.
        /// </summary>
        /// <param name="username">The username to be used for authentication.</param>
        /// <param name="password">The password associated with the provided username.</param>
        /// <returns>A Task representing the asynchronous operation, with a result containing the authentication response in the form of <see cref="ResponseAuth"/>.</returns>
        /// <exception cref="Exception">Thrown if the authentication request fails or the response cannot be processed.</exception>
        internal async Task<ResponseAuth> AuthWithApiAsync(string username, string password)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Clear();

                var formData = new List<KeyValuePair<string, string>>
                {
                    new KeyValuePair<string, string>("username", username),
                    new KeyValuePair<string, string>("password", password),
                    new KeyValuePair<string, string>("client_id", "web")
                };

                using (FormUrlEncodedContent content = new FormUrlEncodedContent(formData))
                {
                    using (HttpResponseMessage response = await _httpClient.PostAsync(Endpoints.Authentication, content))
                    {
                        response.EnsureSuccessStatusCode();
                        string responseContent = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<ResponseAuth>(responseContent);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("AuthWithApi: " + ex.Message, ex);
            }
        }


        /// <summary>
        /// Sends a GET request to a specified endpoint using the provided authentication token, and deserializes the response into the specified type.
        /// </summary>
        /// <typeparam name="T">The type of the object expected in the API response.</typeparam>
        /// <param name="endpoint">The API endpoint to which the GET request is sent.</param>
        /// <param name="accessToken">The authorization token to be included in the request header for authentication.</param>
        /// <returns>A Task representing the asynchronous operation, with a result of the specified type <typeparamref name="T"/>.</returns>
        /// <exception cref="Exception">Thrown if the GET request fails or the response cannot be deserialized.</exception>
        internal async Task<T> GetDataAsync<T>(string endpoint, string accessToken)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                HttpResponseMessage response = await _httpClient.GetAsync(endpoint);
                response.EnsureSuccessStatusCode();
                string content = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(content);
            }
            catch (Exception ex)
            {
                throw new Exception($"GetDataAsync: {ex.Message}",ex);
            }
        }

        /// <summary>
        /// Sends a POST request to a specified endpoint with the provided data and authentication token.
        /// </summary>
        /// <typeparam name="T">The type of the response object expected from the API.</typeparam>
        /// <param name="endpoint">The API endpoint to which the POST request is sent.</param>
        /// <param name="dataToPost">The data object to be serialized and included in the POST request body.</param>
        /// <param name="accessToken">The authorization token to be included in the request header for authentication.</param>
        /// <returns>A Task representing the asynchronous operation, with a result of the specified type <typeparamref name="T"/>.</returns>
        /// <exception cref="Exception">Thrown if the POST request fails or the response cannot be deserialized.</exception>
        internal async Task<T> PostDataAsync<T>(string endpoint, object dataToPost, string accessToken)
        {
            try
            {
                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {accessToken}");
                string jsonData = JsonConvert.SerializeObject(dataToPost);
                StringContent content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await _httpClient.PostAsync(endpoint, content);
                response.EnsureSuccessStatusCode();
                string responseContent = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<T>(responseContent);
            }
            catch (Exception ex)
            {
                throw new Exception($"PostDataAsync: {ex.Message}", ex);
            }
        }
    }
}