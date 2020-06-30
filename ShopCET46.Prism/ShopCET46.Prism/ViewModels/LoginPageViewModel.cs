using Prism.Commands;
using Prism.Navigation;
using System;

namespace ShopCET46.Prism.ViewModels
{
    public class LoginPageViewModel : ViewModelBase
    {
        private string _password;
        private bool _isRunning;
        private bool _isEnabled;
        private DelegateCommand _loginCommand;

        public LoginPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Login Page";
            IsEnabled = true;
        }


        public DelegateCommand LoginCommand => _loginCommand ?? (_loginCommand = new DelegateCommand(Login));


        public string Email { get; set; }


        public bool IsEnabled
        {
            get => _isEnabled;

            set => SetProperty(ref _isEnabled, value);
        }


        public string Password
        {
            get => _password;

            set => SetProperty(ref _password, value);
        }


        public bool IsRunning
        {
            get => _isRunning;

            set => SetProperty(ref _isRunning, value);
        }


        private async void Login()
        {
            if (string.IsNullOrEmpty(Email))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter an email.", "Accept");
                return;
            }

            if (string.IsNullOrEmpty(Password))
            {
                await App.Current.MainPage.DisplayAlert("Error", "You must enter a Password.", "Accept");
                return;
            }

            await App.Current.MainPage.DisplayAlert("Ok", "Fuck yeah!!!!", "Accept");
        }
    }
}
