using ClubOrganiser.DataStores.Azure;
using ClubOrganiser.DataStores.Mock;
using ClubOrganiser.ViewModels;
using DataStores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubOrganiser.Helpers
{
    public class Globals
    {
        public static AthleteProfileViewModel ProfileVM = new AthleteProfileViewModel();
        public static IStoreManager StoreManagerInstance()
        {
#if !UITEST
            return new StoreManager();
#else
            return new MockStoreManager();
#endif
        }
    }
}
