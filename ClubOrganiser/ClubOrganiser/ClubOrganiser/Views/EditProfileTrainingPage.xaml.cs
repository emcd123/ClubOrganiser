using ClubOrganiser.Helpers;
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
	public partial class EditProfileTrainingPage : ContentPage
	{
		public EditProfileTrainingPage ()
		{
			InitializeComponent ();
            BindingContext = Globals.ProfileVM;
		}

        public async void OnClose(object sender, EventArgs e)
        {
            Globals.ProfileVM.SnatchTraining = Globals.ProfileVM.AthleteDetails.MaxTrainingSnatch;
            await Navigation.PopModalAsync();
        }

        public async void OnSaved(object sender, EventArgs e)
        {
            Globals.ProfileVM.AthleteDetails.MaxTrainingSnatch = Globals.ProfileVM.SnatchTraining;
            // API Call(Not yet written)
            // UpdateProfile(Globals.ProfileVM.AthleteDetails);
            await Navigation.PopModalAsync();
        }
    }
}