using NavigationMVVM.Commands;
using NavigationMVVM.Models;
using NavigationMVVM.Services;
using NavigationMVVM.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationMVVM.ViewModels
{
    public class LoginViewModel : ViewModelBase
    {
        private string userName;
        private string password;

        public string UserName
        {
            get => userName;
            set
            {
                userName = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public string Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        public ICommand LoginCommand { get; }
        public LoginViewModel(AccountStore accountStore, NavigationStore navigation)
        {
            NavigationService<AccountViewModel> navigationService = new NavigationService<AccountViewModel>(
                navigation,
                () => new AccountViewModel(accountStore, navigation));
            LoginCommand = new LoginCommand(this, accountStore, navigationService);
        }
    }
}
