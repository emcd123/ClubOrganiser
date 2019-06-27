using ClubRestAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClubOrganiser.Data
{
    public class MockData
    {
        public static Athlete GetMockProfile()
        {
            return new Athlete
            {
                Name = "Owen",
                WeightClass = 73,
                MaxTrainingSnatch = 92,
                MaxTrainingCJ = 120,
                MaxTrainingTotal = 210,
                MaxSquat = 170,
                MaxFrontSquat = 160
            };
        }
    }
}
