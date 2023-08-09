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
    public class AccountViewModel : ViewModelBase
    {
        private readonly AccountStore _account;
        public string UserName => _account.CurrentAccount?.UserName;
        public string Email => _account.CurrentAccount?.Email;
        public ICommand NavigateHomeCommand { get; }
        public AccountViewModel(AccountStore accountStore, NavigationStore navigationStore)
        {
            _account = accountStore;
            NavigateHomeCommand = new NavigateCommand<HomeViewModel>(new NavigationService<HomeViewModel>(navigationStore, () => new HomeViewModel(accountStore, navigationStore)));
        }
    }
}
