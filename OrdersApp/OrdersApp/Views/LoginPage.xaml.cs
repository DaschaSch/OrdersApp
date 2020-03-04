using OrdersApp.Models;
using OrdersApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace OrdersApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

		public LoginPage()
        {
            InitializeComponent();
        }


		private void OnLoginButtonClicked(object sender, EventArgs e)
		{

			if (usernameEntry.Text == "Demo" && passwordEntry.Text == "Demo")
			{
				
				Navigation.PushModalAsync(new MainPage());
			}
			else
			{
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}


	}
}