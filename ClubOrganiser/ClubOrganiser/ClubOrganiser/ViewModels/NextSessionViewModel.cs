using ClubOrganiser.Data;
using ClubRestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubOrganiser.ViewModels
{
    public class NextSessionViewModel : BaseViewModel
    {
        private Session _nextSession;
        public Session NextSession
        {
            get { return _nextSession; }
            set
            {
                _nextSession = value;
                OnPropertyChanged("NextSession");
            }
        }

        public List<Excercise> Excercises
        {
            get { return MockData.GetMockExcerciseList(); }
        }

        public NextSessionViewModel()
        {
            NextSession = MockData.GetMockSession();
        }

    }
}
