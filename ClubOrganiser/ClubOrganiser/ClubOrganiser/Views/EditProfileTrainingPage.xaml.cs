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
            Globals.ProfileVM.SnatchCompetition = Globals.ProfileVM.AthleteDetails.MaxCompetitionSnatch;
            Globals.ProfileVM.CleanAndJerkTraining = Globals.ProfileVM.AthleteDetails.MaxTrainingCJ;
            Globals.ProfileVM.CompetitionCJ = Globals.ProfileVM.AthleteDetails.MaxCompetitionCJ;
            Globals.ProfileVM.Squat = Globals.ProfileVM.AthleteDetails.MaxSquat;
            Globals.ProfileVM.FrontSquat = Globals.ProfileVM.AthleteDetails.MaxFrontSquat;
            Globals.ProfileVM.TrainingTotal = Globals.ProfileVM.AthleteDetails.MaxTrainingTotal;
            Globals.ProfileVM.CompetitionTotal = Globals.ProfileVM.AthleteDetails.MaxCompetitionTotal;
            Globals.ProfileVM.SinclairCompetition = Globals.ProfileVM.AthleteDetails.SinclairCompetition;
            Globals.ProfileVM.PowerCJ = Globals.ProfileVM.AthleteDetails.MaxPowerCJ;
            Globals.ProfileVM.PowerSnatch = Globals.ProfileVM.AthleteDetails.MaxPowerSnatch;
            Globals.ProfileVM.RackJerk = Globals.ProfileVM.AthleteDetails.RackJerk;
            Globals.ProfileVM.PowerJerk = Globals.ProfileVM.AthleteDetails.PowerJerk;
            await Navigation.PopModalAsync();
        }

        public async void OnSaved(object sender, EventArgs e)
        {
            Globals.ProfileVM.AthleteDetails.MaxTrainingSnatch = Globals.ProfileVM.SnatchTraining;
            Globals.ProfileVM.AthleteDetails.MaxCompetitionSnatch = Globals.ProfileVM.SnatchCompetition;
            Globals.ProfileVM.AthleteDetails.MaxTrainingCJ = Globals.ProfileVM.CleanAndJerkTraining;
            Globals.ProfileVM.AthleteDetails.MaxCompetitionCJ = Globals.ProfileVM.CompetitionCJ;
            Globals.ProfileVM.AthleteDetails.MaxSquat = Globals.ProfileVM.Squat;
            Globals.ProfileVM.AthleteDetails.MaxFrontSquat = Globals.ProfileVM.FrontSquat;
            Globals.ProfileVM.AthleteDetails.MaxTrainingTotal = Globals.ProfileVM.TrainingTotal;
            Globals.ProfileVM.AthleteDetails.MaxCompetitionTotal = Globals.ProfileVM.CompetitionTotal;
            Globals.ProfileVM.AthleteDetails.SinclairCompetition = Globals.ProfileVM.SinclairCompetition;
            Globals.ProfileVM.AthleteDetails.MaxPowerCJ = Globals.ProfileVM.PowerCJ;
            Globals.ProfileVM.AthleteDetails.MaxPowerSnatch = Globals.ProfileVM.PowerSnatch;
            Globals.ProfileVM.AthleteDetails.RackJerk = Globals.ProfileVM.RackJerk;
            Globals.ProfileVM.AthleteDetails.PowerJerk = Globals.ProfileVM.PowerJerk;
            // API Call(Not yet written)
            // UpdateProfile(Globals.ProfileVM.AthleteDetails);
            await Navigation.PopModalAsync();
        }
    }
}