using System;
using Tasks_Library;

namespace Task1_Console
{
    class GreetingProvider
    {
        static void Main(string[] args)
        {
            // Type your username
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Task 1 - Display the input value
            Console.WriteLine("Hello, " + userName);

            // Task 2 - Print the value of the variable with time and greeting
            Console.WriteLine(DateTimeProvider.GetResponseWithDateTime(userName));

           
        }
    }
}
