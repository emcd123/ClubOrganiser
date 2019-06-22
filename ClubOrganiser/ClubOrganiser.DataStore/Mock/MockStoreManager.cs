using ClubOrganiser.DataStore.Interfaces;
using DataStores.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ClubOrganiser.DataStores.Mock
{
    public class MockStoreManager : IStoreManager
    {
        #region IStoreManager implementation

        public Task<bool> SyncAllAsync(bool syncUserSpecific)
        {
            return Task.FromResult(true);
        }

        public bool IsInitialized { get { return true; } }
        public Task InitializeAsync()
        {
            return Task.FromResult(true);
        }

        #endregion

        public Task DropEverythingAsync()
        {
            return Task.FromResult(true);
        }

        IAthleteStore athleteStore;
        public IAthleteStore AthleteStore => athleteStore ?? (athleteStore = new MockAthleteStore());


    }
}
