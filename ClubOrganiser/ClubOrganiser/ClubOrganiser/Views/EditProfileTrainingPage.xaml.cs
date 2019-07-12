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
		}

        public async void OnClose(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        public async void OnSaved(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}