
using ClubOrganiser.Data;
using ClubRestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubOrganiser.ViewModels
{
    public class AthleteProfileViewModel : BaseViewModel
    {
        private Athlete _athleteDetails;
        public Athlete AthleteDetails
        {
            get { return _athleteDetails; }
            set
            {
                _athleteDetails = value;
                OnPropertyChanged("AthleteDetails");
            }
        }

        private string _profileIcon;
        public string ProfileIcon
        {
            get { return _profileIcon; }
            set
            {
                _profileIcon = value;
                OnPropertyChanged("ProfileIcon");
            }
        }
        public AthleteProfileViewModel()
        {
            AthleteDetails = MockData.GetMockProfile();
            ProfileIcon = FontAwesome.FontAwesomeIcons.UserCircle;
        }
    }
}
