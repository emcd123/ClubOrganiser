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
	public partial class AthleteProfilePage : TabbedPage
	{
		public AthleteProfilePage ()
		{
			InitializeComponent ();
            BindingContext = new AthleteProfileViewModel();
        }

        /// <summary>When overridden, allows application developers to customize behavior immediately prior to the <see cref="T:Xamarin.Forms.Page" /> becoming visible.</summary>
        /// <remarks>To be added.</remarks>
        protected override void OnAppearing()
        {
            base.OnAppearing();
            var viewModelIsInherited = Children.First().BindingContext == this.BindingContext;
            if (viewModelIsInherited)
            {
                System.Diagnostics.Debug.WriteLine("Yay, it works");
            }
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