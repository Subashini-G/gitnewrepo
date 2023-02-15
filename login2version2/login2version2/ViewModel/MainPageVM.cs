using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace login2version2.ViewModel
{
    public class MainPageVM : INotifyPropertyChanged
    {
        private bool _isvalid;
        public bool isvalid
        {
            get
            {
                return _isvalid;
            }
            set
            {
                _isvalid = value;
            }
        }
        private bool _btnenabled;
        public bool btnenabled
        {
            get
            {
                return _btnenabled;
            }
            set
            {
                _btnenabled = value;
            }
        }
        public MainPageVM()
        {
        }
        public Command MainPageLoginCommand
        {
            get
            {
                return new Command(MainPageLogin);
            }
        }

        private void MainPageLogin(object obj)
        {
            if (_isvalid.Equals(true))
            {
                btnenabled = false;
                return;
            }
                App.Current.MainPage.Navigation.PushAsync(new View.LoginPage());
            
        }

        public Command SignUpCommand
        {
            get
            {
                return new Command(SignUp);
            }
        }

        private void SignUp(object obj)
        {
            App.Current.MainPage.Navigation.PushAsync(new View.SignUpPage());
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

