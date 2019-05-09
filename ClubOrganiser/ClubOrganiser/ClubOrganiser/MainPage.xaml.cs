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
        }

        int count = 0;
        public async void Button_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new NavigationPage( new SectionPage()));
        }
    }
}
