using ClubOrganiser.ViewModels;
using ClubRestAPI.DataModels;
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
	public partial class NextSessionPage : ContentPage
	{
		public NextSessionPage ()
		{
			InitializeComponent ();
            var vm = new NextSessionViewModel();
            BindingContext = vm;
		}

        public async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            //This will open the selected element from the list but wont open it again
            // if the user goes back and tries to reopen the same element
            Excercise selectedItem = e.SelectedItem as Excercise;
            await Navigation.PushModalAsync(new NavigationPage(new SectionPage()));
        }

        public async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            //This will open the selected element from the list and will open it again
            // if the user goes back and tries to reopen the same element.

            // But if they tap multiple times before the page opens it will open multiple times in a row
            Excercise tappedItem = e.Item as Excercise;
            await Navigation.PushModalAsync(new NavigationPage(new SectionPage()));
        }

        public async void HomeButton_Activated(object sender, System.EventArgs e)
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
    }
}