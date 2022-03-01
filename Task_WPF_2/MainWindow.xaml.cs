using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Tasks_Library;

namespace Task_WPF_2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void BtnSend(object sender, RoutedEventArgs e)
        {
            // Create a string variable and get user input from the keyboard and store it in the variable
            string username = userName.Text;
            const string greeting = "Hello";

            // Send the username to the library
            DateTimeProvider name = new(username);

            if (!string.IsNullOrEmpty(username))
            {
                // Task 1 - Display the input value
                // Task 2 - Print the value of the variable with time and greeting
                MessageBox.Show(greeting + ", " + username + "\n"
                    + name.GetResponseWithDateTime());
            }
            else
            {
                MessageBox.Show("Enter your name please!");
            }
        }
    }
}
