using PaginationDemo.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginationDemo
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainShell : Shell
	{
        Dictionary<string, Type> routes = new Dictionary<string, Type>();
        public Dictionary<string, Type> Routes { get { return routes; } }
        public MainShell ()
		{
			InitializeComponent ();
            RegisterRoutes();
        }
        void RegisterRoutes()
        {
            routes.Add("addaccount", typeof(AddAccount));
            routes.Add("accounts", typeof(AccountsView));
           
            foreach (var item in routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}