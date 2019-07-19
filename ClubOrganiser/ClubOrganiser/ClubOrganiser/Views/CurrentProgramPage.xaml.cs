using ClubOrganiser.ViewModels;
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
	public partial class CurrentProgramPage : ContentPage
	{
		public CurrentProgramPage ()
		{
			InitializeComponent ();
            BindingContext = new CurrentProgramViewModel();
		}

        public async void OnListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            //This will open the selected element from the list and will open it again
            // if the user goes back and tries to reopen the same element.

            // But if they tap multiple times before the page opens it will open multiple times in a row
            //Program tappedItem = e.Item as Program;
            await Navigation.PushModalAsync(new NavigationPage(new SectionPage()));
        }
    }
}