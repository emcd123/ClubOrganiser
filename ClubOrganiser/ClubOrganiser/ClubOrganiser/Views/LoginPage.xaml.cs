using ClubOrganiser.ViewModels;
using LeoJHarris.FormsPlugin.Abstractions.Effects;
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
            var vm = new LoginViewModel();
            BindingContext = vm;
            PasswordField.Effects.Add( new ShowHiddenEntryEffect());

        }

        public async void DoLogin(object sender, System.EventArgs e)
        {
            try
            {
                NavigationPage Page = new NavigationPage(new HomePage());
                await Navigation.PushModalAsync(Page);
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Cannot use PushAsync");
            }
        }

        //This will override the Hardware Back button to deactivate it on this page.
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}