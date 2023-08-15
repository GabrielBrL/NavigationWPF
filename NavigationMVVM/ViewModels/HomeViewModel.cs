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
        public HomeViewModel(INavigationService<LoginViewModel> loginNavigationService)
        {            
            NavigateAccountCommand = new NavigateCommand<LoginViewModel>(loginNavigationService);
        }
    }
}
