using System;

namespace Tasks_Library
{
    public static class DateTimeProvider
    {
        private const string greeting = "Hello";

        // Get property that provides a greeting with the current time 
        public static string GetResponseWithDateTime(string username)
        {
            string greeting_response = $"{DateTime.Now} {greeting}, {username}";
            return greeting_response;
        }
    }
}
