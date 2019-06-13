using ClubOrganiser.ClientModels;
using ClubOrganiser.Data;
using ClubOrganiser.Interfaces;
using ClubOrganiser.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ClubOrganiser.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _brandIcon;

        public string BrandIcon
        {
            get { return _brandIcon; }
            set
            {
                _brandIcon = value;
                OnPropertyChanged("BrandIcon");
            }
        }
        public LoginViewModel()
        {
            BrandIcon = FontAwesome.FontAwesomeIcons.Android;
        }
    }
}
