using PaginationDemo.Helpers;
using PaginationDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms.Extended;

namespace PaginationDemo.ViewModels
{
    public class AccountsViewModel : INotifyPropertyChanged
    {
        private bool _isBusy;

        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; }
        }

        private const int PageSize = 10;
        public ObservableCollection<Account> AccountsList { get;  set; }
        //public InfiniteScrollCollection<Account> AccountsList { get; set; }
        public AccountHelper _accountHelper = new AccountHelper();

        public AccountsViewModel()
        {
            GetAccountsAsync();
        }
        public async void GetAccountsAsync()
        {
            //var items = await _accountHelper.GetAccounts(pageIndex:0,pageSize:PageSize);
            //AccountsList.AddRange(items);

            AccountsList =  await _accountHelper.GetAccounts();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
