﻿using Newtonsoft.Json;
using PaginationDemo.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PaginationDemo.Helpers
{
    public class AccountHelper
    {
        HttpClient _client = new HttpClient();
        private const string Url = "https://xamarinapi2019.azurewebsites.net/api/accounts";
        //private const string Url = "https://localhost:44314/api/accounts";

        public async Task AddNewAccount(Account account)
        {
            var json = JsonConvert.SerializeObject(account);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await _client.PostAsync(Url, content);
            var data = response.Content.ReadAsStringAsync().Result;
        }
        public async Task<ObservableCollection<Account>> GetAccounts()
        {
            var response = await _client.GetStringAsync(Url);
            var list = JsonConvert.DeserializeObject<ObservableCollection<Account>>(response);
            return list;
        }
    }
}
