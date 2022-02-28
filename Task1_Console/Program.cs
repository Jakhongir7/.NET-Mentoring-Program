using System;
using MyLib;

namespace Task1_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            // Type your username
            Console.WriteLine("Enter username:");

            // Create a string variable and get user input from the keyboard and store it in the variable
            string userName = Console.ReadLine();

            // Send the username to the library
            Hello_Time username = new(userName);

            // Display the input value
            Console.WriteLine("Hello, " + userName);

            // Task 2 Print the value of the variable with Time and Hello
            Console.WriteLine(username.Print());

           
        }
    }
}
