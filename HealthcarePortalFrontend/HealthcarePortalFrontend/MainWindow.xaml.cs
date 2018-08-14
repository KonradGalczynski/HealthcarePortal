using System;
using System.Windows;
using Refit;

namespace HealthcarePortalFrontend
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RegisterUser(object sender, RoutedEventArgs e)
        {
            var userRegistrationRequest = new UserRegistrationRequest
            {
                Login = UserLogin.Text,
                Password = UserPassword.Text
            };

            var userRegistrationApi = RestService.For<IUserRegistration>("https://localhost:44396");
            var result = userRegistrationApi.Post(userRegistrationRequest).Result;
        }
    }
}