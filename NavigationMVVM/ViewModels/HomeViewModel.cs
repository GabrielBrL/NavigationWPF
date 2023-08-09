using NavigationMVVM.Commands;
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
    public class HomeViewModel : ViewModelBase
    {
        public string WelcomeMessage => "Welcome!";
        public ICommand NavigateAccountCommand { get; }
        public HomeViewModel(AccountStore accountStore, NavigationStore navigateStore)
        {
            NavigateAccountCommand = new NavigateCommand<LoginViewModel>(new NavigationService<LoginViewModel>(navigateStore, () => new LoginViewModel(accountStore, navigateStore)));
        }
    }
}
