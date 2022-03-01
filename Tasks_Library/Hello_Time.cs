using System;

namespace Tasks_Library
{
    public class DateTimeProvider
    {
        private string username;
        const string greeting = "Hello";
        DateTime current_time = DateTime.Now;

        // The constructor of the class to initialize username
        public DateTimeProvider(string username)
        {
            this.username = username;
        }

        // Get property that provides a greeting with the current time 
        public string GetResponseWithDateTime()
        {
            string greeting_response = $"{current_time} {greeting}, {username}";
            return greeting_response;
        }
    }
}
