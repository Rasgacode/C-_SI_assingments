using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
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

namespace regular_expression
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

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            ValidData();
        }

        private bool ValidData()
        {
            if (!ValidName(NameTextbox))
            {
                MessageBox.Show("The name is invalid (only alphabetical characters are allowed)", "Character error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (PhoneTextbox.Text.Length == 0 || !ValidPhone(CreatePhoneNum(PhoneTextbox)))
            {
                MessageBox.Show("The phone number is invalid", "Phone number error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            if (!ValidEmail(EmailTextbox))
            {
                MessageBox.Show("The Email is invalid", "Email error", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            return true;
        }

        private void SaveBtn_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private bool ValidName(TextBox name)
        {
            if (!Regex.IsMatch(name.Text, @"^([A-Za-z]+\s*)+$")) return false;

            return true;
        }
        
        private bool ValidPhone(string number)
        {
            if (!Regex.IsMatch(number, @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$")) return false;

            return true;
        }

        private bool ValidEmail(TextBox email)
        {
            if (!Regex.IsMatch(email.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")) return false;

            return true;
        }

        private string CreatePhoneNum(TextBox number)
        {
            return Convert.ToInt64(number.Text).ToString("(000) 000-0000");
        }
    }
}
