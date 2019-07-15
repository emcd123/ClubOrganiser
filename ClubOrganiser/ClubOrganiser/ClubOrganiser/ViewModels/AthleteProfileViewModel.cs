
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

        public int _snatchTraining;
        public int SnatchTraining
        {
            get { return _snatchTraining; }
            set
            {
                _snatchTraining = value;
                OnPropertyChanged("SnatchTraining");
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

        private string _editProfileButton;
        public string EditProfileButton
        {
            get { return _editProfileButton; }
            set
            {
                _editProfileButton = value;
                OnPropertyChanged("EditProfileButton");
            }
        }

        public AthleteProfileViewModel()
        {
            AthleteDetails = MockData.GetMockProfile();
            ProfileIcon = FontAwesome.FontAwesomeIcons.UserCircle;
            EditProfileButton = FontAwesome.FontAwesomeIcons.Wrench;
            SnatchTraining = AthleteDetails.MaxTrainingSnatch;
        }
    }
}
