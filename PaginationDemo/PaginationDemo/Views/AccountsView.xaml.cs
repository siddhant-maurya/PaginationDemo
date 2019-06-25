using Newtonsoft.Json;
using PaginationDemo.Models;
using PaginationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginationDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AccountsView : ContentPage
	{
        HttpClient _client = new HttpClient();
        private AccountsViewModel _accountViewModel;
        public AccountsView ()
		{
			InitializeComponent ();
            _accountViewModel = new AccountsViewModel();
            BindingContext = _accountViewModel;
		}
        protected override async void OnAppearing()
        {
            _accountViewModel.GetAccountsAsync();
        }
        private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        
        private void AddAccountClicked(object sender, EventArgs e)
        {
            Shell.Current.GoToAsync($"addaccount");
        }
    }
}