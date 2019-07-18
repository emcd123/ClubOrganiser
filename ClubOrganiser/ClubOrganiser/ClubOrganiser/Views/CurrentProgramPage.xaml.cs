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
	}
}