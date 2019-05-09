using ClubOrganiser.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClubOrganiser
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Want the navigation bar hidden since the homepage has nothing to navigate to.           
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public async void Button_Clicked(object sender, System.EventArgs e)
        {
            //Using PushAsync to push from one NavigationPage to another. This will allow us a Back Button
            //on the navigation bar.
            try
            {
                await Navigation.PushAsync(new SectionPage());
            }
            catch (Exception)
            {

                throw new InvalidOperationException("Cannot use PushAsync");
            }
        }
    }
}
