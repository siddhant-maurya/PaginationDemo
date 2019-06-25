using PaginationDemo.Helpers;
using PaginationDemo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaginationDemo.ViewModels
{
    public class AddAccountViewModel
    {
        public AccountHelper _accountHelper = new AccountHelper();

        public AddAccountViewModel()
        {

        }
        public bool AddNewAccount(Account account)
        {
            var response = _accountHelper.AddNewAccount(account);
            return response.IsCompleted;
        }

    }
}
