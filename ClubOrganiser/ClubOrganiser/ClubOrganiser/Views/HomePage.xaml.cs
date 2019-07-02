using ClubOrganiser.ClientModels;
using ClubOrganiser.ViewModels;
using ClubOrganiser.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ClubOrganiser
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
            //Initialise the viewmodel for this page
            var vm = new HomePageViewModel();
            BindingContext = vm;
        }

        //private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        //{
        //    (sender as ListView).SelectedItem = null;

        //    if (args.SelectedItem != null)
        //    {
        //        HomePageTileItem tileData = args.SelectedItem as HomePageTileItem;
        //        NavigationPage page = tileData.PageType;
        //        await Navigation.PushModalAsync(page);
        //    }
        //}

        public async void OnItemTapped(object sender, TappedEventArgs args)
        {
            if (sender.ToString() != null)
            {
                var myObject = args.Parameter;
                HomePageTileItem tileData = myObject as HomePageTileItem;
                Page page = tileData.PageType;
                await Navigation.PushModalAsync(page);
            }
        }

        public async void OnLogout(object sender, System.EventArgs e)
        {
            try
            {
                await Navigation.PushModalAsync(new LoginPage());
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Cannot Logout");
            }
        }

        //This will override the Hardware Back button to deactivate it on this page.
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}