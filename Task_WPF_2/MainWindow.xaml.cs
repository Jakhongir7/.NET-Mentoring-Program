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
using MyLib;

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
            string text = userName.Text;

            // Send the username to the library
            Hello_Time username = new(text);

            if (text != "")
            {
                // Display the input value
                // Task 2 Print the value of the variable with Time and Hello
                MessageBox.Show("Hello, " + text + "\n"
                    + username.Print());
            }
            else
            {
                MessageBox.Show("Enter your name please!");
            }
        }
    }
}
