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
	public partial class AthleteProfileTraining : ContentPage
	{
		public AthleteProfileTraining ()
		{
			InitializeComponent ();
            var inherited_vm = this.BindingContext;
        }
       
        public async void OnEditClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new EditProfileTrainingPage());
        }
    }
}