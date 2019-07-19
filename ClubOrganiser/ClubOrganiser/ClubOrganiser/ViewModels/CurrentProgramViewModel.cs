using ClubOrganiser.Data;
using ClubRestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubOrganiser.ViewModels
{
    public class CurrentProgramViewModel : BaseViewModel
    {
        private Program _currentProgram;
        public Program CurrentProgram
        {
            get { return _currentProgram; }
            set
            {
                _currentProgram = value;
                OnPropertyChanged("CurrentProgram");
            }
        }

        private List<Session> _sessions;
        public List<Session> Sessions
        {
            get { return _sessions; }
            set
            {
                _sessions = value;
                OnPropertyChanged("Sessions");
            }
        }

        public CurrentProgramViewModel()
        {
            CurrentProgram = MockData.GetMockProgram();
            Sessions = CurrentProgram.Sessions;
        }
    }
}
