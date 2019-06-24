
using ClubRestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubOrganiser.ViewModels
{
    public class AthleteProfileViewModel : BaseViewModel
    {
        private Athlete _athleteDetails;
        public Athlete AtheleteDetails
        {
            get;set;
        }
        public AthleteProfileViewModel()
        {
        }


    }
}
