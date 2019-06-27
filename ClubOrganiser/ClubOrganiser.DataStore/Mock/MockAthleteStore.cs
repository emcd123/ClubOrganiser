using ClubOrganiser.DataStore.Interfaces;
using ClubRestAPI.DataModels;
using DataStores.Mock;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubOrganiser.DataStore.Mock
{
    public class MockAthleteStore : MockBaseStore<Athlete>, IAthleteStore
    {
        List<Athlete> AthletesStats { get; }
        public MockAthleteStore()
        {
            AthletesStats = new List<Athlete>();
        }

        public override async Task InitializeStore()
        {
            if (AthletesStats.Count != 0)
                return;

            AthletesStats.Add(new Athlete
            {
                Name = "Owen",
                WeightClass = 73,
                MaxTrainingSnatch = 92,
                MaxTrainingCJ = 120,
                MaxTrainingTotal = 210
            });
            await Task.Delay(100);
        }

        public override async Task<IEnumerable<Athlete>> GetItemsAsync(bool forceRefresh = false)
        {
            await InitializeStore();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(AthletesStats);
            return AthletesStats;
        }

        public override async Task<Athlete> GetItemAsync(string id)
        {
            await InitializeStore();

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(AthletesStats);            
            return AthletesStats.Where(s => s.Id == id).FirstOrDefault();
        }
    }
}
