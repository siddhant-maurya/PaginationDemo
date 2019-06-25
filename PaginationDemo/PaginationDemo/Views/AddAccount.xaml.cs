using PaginationDemo.Helpers;
using PaginationDemo.Models;
using PaginationDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginationDemo.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddAccount : ContentPage
	{
        AddAccountViewModel addAccountViewModel = new AddAccountViewModel();
        public AddAccount ()
		{
			InitializeComponent ();
		}

        private void AddAccountSubmit(object sender, EventArgs e)
        {
            var userName = UserNameEntry.Text;
            var password = PasswordEntry.Text;
            var account = new Account {
                UserName = userName,
                Password = password
            };
           addAccountViewModel.AddNewAccount(account);
            Shell.Current.Navigation.PopAsync();
        }
    }
}