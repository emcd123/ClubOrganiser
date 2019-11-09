using ClubOrganiser.Data;
using ClubRestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

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

        private bool _isCompleted;
        public bool IsCompleted
        {
            get { return _isCompleted; }
            set
            {
                _isCompleted = value;
                OnPropertyChanged("IsCompleted");
                OnPropertyChanged("NextSession");
            }
        }

        private bool _isFailed;
        public bool IsFailed
        {
            get { return _isFailed; }
            set
            {
                _isFailed = value;
                OnPropertyChanged("IsFailed");
                OnPropertyChanged("NextSession");
            }
        }

        public List<Excercise> Excercises
        {
            get { return NextSession.Excercises; }
        }

        public NextSessionViewModel()
        {
            NextSession = MockData.GetMockSession();
        }

        //public Command TapCompleteCommand
        //{
        //    get
        //    {
        //        return new Command(async val => {
        //            bool data;
        //            if (val != null)
        //            {
        //                data = (bool)val;
        //                if (!data)
        //                {                            
        //                    NextSession.IsCompleted = true;
        //                    IsCompleted = true;
        //                }
        //            }
        //        });
        //    }
        //}

        //public Command TapMissedCommand
        //{
        //    get
        //    {
        //        return new Command(async val => {
        //            bool data;
        //            if (val != null)
        //            {
        //                data = (bool)val;
        //                if (!data)
        //                {
        //                    NextSession.IsFailed = true;
        //                    IsFailed = true;
        //                }
        //            }
        //        });
        //    }
        //}
    }
}
