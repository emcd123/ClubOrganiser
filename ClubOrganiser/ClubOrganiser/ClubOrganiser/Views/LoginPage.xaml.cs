using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClubOrganiser.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{
			InitializeComponent ();
		}

        public async void DoLogin(object sender, System.EventArgs e)
        {
            try
            {
                NavigationPage Page = new NavigationPage(new MainPage());
                await Navigation.PushModalAsync(Page);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Cannot use PushAsync");
            }
        }
	}
}