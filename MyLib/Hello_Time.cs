using System;

namespace MyLib
{
    public class Hello_Time
    {
        string username;
        DateTime current_time = DateTime.Now;
        public Hello_Time(string name)
        {
            this.username = name;
        }
        public string Print()
        {
            username = $"{current_time} Hello, {username}";
            return username;
        }
    }
}
