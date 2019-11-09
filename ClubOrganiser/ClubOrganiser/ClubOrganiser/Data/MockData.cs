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
                MaxFrontSquat = 160,
                MaxPowerCJ = 105,
                MaxPowerSnatch = 85,
                RackJerk = 120,
                PowerJerk = 115
            };
        }

        public static Program GetMockProgram()
        {
            return new Program
            {
                EstimatedDurationInWeeks = 1,
                DaysTrained = 3,
                Sessions = GetMockSessions(),
                ProgramClassification = "Classic",
            };
        }

        public static List<Session> GetMockSessions()
        {
            return new List<Session> { GetMockSession() };
        }

        public static Session GetMockSession()
        {
            return new Session
            {
                EstimatedRPE = 9,
                Excercises = GetMockExcerciseList(),
                DayInProgram = 2,
                WeekInProgram = 1
            };
        }

        public static List<Excercise> GetMockExcerciseList()
        {
            return new List<Excercise>
            {
                new Excercise
                {
                    Name="Snatch",
                    Classification = "Olympic Lifts",
                    Reps = 2,
                    Sets = 6,
                    Percentage = "80",
                    ActualWeight = 73
                },
                new Excercise
                {
                    Name="Clean and Jerk",
                    Classification = "Olympic Lifts",
                    Reps = 1,
                    Sets = 5,
                    Percentage = "70"
                }
            };
        }

        public static Excercise GetMockExcercise()
        {
            return new Excercise
            {
                Name = "Snatch",
                Classification = "Olympic Lifts",
                Reps = 2,
                Sets = 6,
                Percentage = "80",
                ActualWeight = 73
            };
        }
    }
}
