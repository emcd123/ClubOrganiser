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
	public partial class AthleteProfileHistoryPage : ContentPage
	{
		public AthleteProfileHistoryPage ()
		{
			InitializeComponent ();
            var inherited_vm = this.BindingContext;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }
    }
}