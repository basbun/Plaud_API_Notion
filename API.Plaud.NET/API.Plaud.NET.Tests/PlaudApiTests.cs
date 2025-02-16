using API.Plaud.NET.Interfaces;
using API.Plaud.NET.Models.Responses;
using API.Plaud.NET.Services;

namespace API.Plaud.NET.Tests
{
    public class Tests
    {
        private IPlaudApiService _plaudApiService;
        private string? _PlaudUserName;
        private string? _PlaudPassword;
        private ResponseAuth? _AuthResponse;
        
        [OneTimeSetUp]
        public void Setup()
        {
            _plaudApiService = new PlaudApiService();
            _PlaudUserName = Environment.GetEnvironmentVariable("PlaudUserName", EnvironmentVariableTarget.User);
            _PlaudPassword = Environment.GetEnvironmentVariable("PlaudPassword", EnvironmentVariableTarget.User);
            _AuthResponse = _plaudApiService.AuthenticateAsync(_PlaudUserName,_PlaudPassword).Result;
        }

        [Test]
        public void AuthenticationTest()
        {
            Assert.That(_AuthResponse, Is.Not.Null);
            Assert.That(_AuthResponse.AccessToken, Is.Not.Null);
            Assert.That(_plaudApiService.AccessToken, Is.Not.Null);
            Assert.That(_AuthResponse.AccessToken, Is.EqualTo(_plaudApiService.AccessToken));
        }
    }
}