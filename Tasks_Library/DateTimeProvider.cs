using System;

namespace Tasks_Library
{
    public static class DateTimeProvider
    {
        private const string greeting = "Hello";
        private static DateTime current_time = DateTime.Now;

        // Get property that provides a greeting with the current time 
        public static string GetResponseWithDateTime(string username)
        {
            string greeting_response = $"{current_time} {greeting}, {username}";
            return greeting_response;
        }
    }
}
