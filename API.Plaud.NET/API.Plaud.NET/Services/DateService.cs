using System;

namespace API.Plaud.NET.Services
{
    internal static class DateService
    {
        internal static string ConvertTimeStampToFormattedDateTime(long timestampToConvert)
        {
            DateTimeOffset timestamp = DateTimeOffset.FromUnixTimeMilliseconds(timestampToConvert);
            return timestamp.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}