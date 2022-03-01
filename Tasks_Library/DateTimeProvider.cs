using System;

namespace Tasks_Library
{
    public class DateTimeProvider
    {
        const string greeting = "Hello";
        DateTime current_time = DateTime.Now;

        // Get property that provides a greeting with the current time 
        public string GetResponseWithDateTime(string username)
        {
            string greeting_response = $"{current_time} {greeting}, {username}";
            return greeting_response;
        }
    }
}
