
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

        private int _snatchTraining;
        public int SnatchTraining
        {
            get { return _snatchTraining; }
            set
            {
                _snatchTraining = value;
                OnPropertyChanged("SnatchTraining");
            }
        }

        private int _cleanAndJerkTraining;
        public int CleanAndJerkTraining
        {
            get { return _cleanAndJerkTraining; }
            set
            {
                _cleanAndJerkTraining = value;
                OnPropertyChanged("CleanAndJerkTraining");
            }
        }
        private int _weightClass;
        public int WeightClass {
            get { return _weightClass; }
            set
            {
                _weightClass = value;
                OnPropertyChanged("WeightClass");
            }
        }

        private int _trainingTotal;
        public int TrainingTotal {
            get { return _trainingTotal; }
            set
            {
                _trainingTotal = value;
                OnPropertyChanged("TrainingTotal");
            }
        }

        private int _competitionTotal;
        public int CompetitionTotal {
            get { return _competitionTotal; }
            set
            {
                _competitionTotal = value;
                OnPropertyChanged("CompetitionTotal");
            }
        }

        private int _snatchCompetition;
        public int SnatchCompetition
        {
            get { return _snatchCompetition; }
            set
            {
                _snatchCompetition = value;
                OnPropertyChanged("SnatchCompetition");
            }
        }

        private int _competitionCJ;
        public int CompetitionCJ
        {
            get { return _competitionCJ; }
            set
            {
                _competitionCJ = value;
                OnPropertyChanged("CompetitionCJ");
            }
        }

        private double _sinclairCompetition;
        public double SinclairCompetition
        {
            get { return _sinclairCompetition; }
            set
            {
                _sinclairCompetition = value;
                OnPropertyChanged("SinclairCompetition");
            }
        }

        private int _squat;
        public int Squat
        {
            get { return _squat; }
            set
            {
                _squat = value;
                OnPropertyChanged("Squat");
            }
        }

        private int _frontSquat;
        public int FrontSquat
        {
            get { return _frontSquat; }
            set
            {
                _frontSquat = value;
                OnPropertyChanged("FrontSquat");
            }
        }

        private int _powerCJ;
        public int PowerCJ
        {
            get { return _powerCJ; }
            set
            {
                _powerCJ = value;
                OnPropertyChanged("PowerCJ");
            }
        }

        private int _powerSnatch;
        public int PowerSnatch
        {
            get { return _powerSnatch; }
            set
            {
                _powerSnatch = value;
                OnPropertyChanged("PowerSnatch");
            }
        }

        private int _rackJerk;
        public int RackJerk
        {
            get { return _rackJerk; }
            set
            {
                _rackJerk = value;
                OnPropertyChanged("RackJerk");
            }
        }

        public int _powerJerk;
        public int PowerJerk {
            get { return _powerJerk; }
            set
            {
                _powerJerk = value;
                OnPropertyChanged("PowerJerk");
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
            WeightClass = AthleteDetails.WeightClass;
            SnatchTraining = AthleteDetails.MaxTrainingSnatch;
            SnatchCompetition = AthleteDetails.MaxCompetitionSnatch;
            CleanAndJerkTraining = AthleteDetails.MaxTrainingCJ;
            CompetitionCJ = AthleteDetails.MaxCompetitionCJ;
            Squat = AthleteDetails.MaxSquat;
            FrontSquat = AthleteDetails.MaxFrontSquat;
            TrainingTotal = AthleteDetails.MaxTrainingTotal;
            CompetitionTotal = AthleteDetails.MaxCompetitionTotal;
            SinclairCompetition = AthleteDetails.SinclairCompetition;
            PowerCJ = AthleteDetails.MaxPowerCJ;
            PowerSnatch = AthleteDetails.MaxPowerSnatch;
            RackJerk = AthleteDetails.RackJerk;
            PowerJerk = AthleteDetails.PowerJerk;
        }
    }
}
