using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace API.Plaud.NET.DataAccess
{
    /// <summary>
    /// Provides functionality for downloading files and encoding them as Base64 strings.
    /// </summary>
    internal static class DownloadFile
    {
        /// <summary>
        /// A static instance of the <see cref="HttpClient"/> class used to send HTTP requests and receive HTTP responses.
        /// </summary>
        private static readonly HttpClient _httpClient = new HttpClient();

        /// <summary>
        /// Downloads a file from the given URL and returns its contents encoded as a Base64 string.
        /// </summary>
        /// <param name="fileUrl">The URL of the file to be downloaded.</param>
        /// <returns>A Task representing the asynchronous operation. The task result contains the Base64 encoded string of the downloaded file's contents.</returns>
        /// <exception cref="Exception">Thrown when there is an error downloading the file or the HTTP response is unsuccessful.</exception>
        internal static async Task<string> DownloadFileAsBase64Async(string fileUrl)
        {
            System.Net.ServicePointManager.SecurityProtocol = System.Net.SecurityProtocolType.Tls12;

            try
            {
                using (HttpResponseMessage response = await _httpClient.GetAsync(fileUrl))
                {
                    response.EnsureSuccessStatusCode();
                    byte[] fileBytes = await response.Content.ReadAsByteArrayAsync();
                    return Convert.ToBase64String(fileBytes);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"DownloadFileAsBase64Async: {ex.Message}", ex);
            }
        }
    }
}