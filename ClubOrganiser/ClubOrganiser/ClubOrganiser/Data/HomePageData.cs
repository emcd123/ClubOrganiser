using ClubOrganiser.ClientModels;
using ClubOrganiser.Interfaces;
using ClubOrganiser.Views;
using FontAwesome;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ClubOrganiser.Data
{
    public class HomePageData
    {      
        public static List<ITileItem> CreateHomePageTileList()
        {
            List<ITileItem> HomePageTilesList = new List<ITileItem>() { };
            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 1,
                Title = "Your Profile",
                Icon = FontAwesomeIcons.User,
                IconFamily = "FontAwesomeSolid",
                BackgroundColor = "#6B2851",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 0,
                Row = 0
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 2,
                Title = "Your Next Session",
                BackgroundColor = "#338F84",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 0
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 3,
                Title = "Your Competitions",
                BackgroundColor = "#338F84",
                PageType = new Xamarin.Forms.NavigationPage(new ComingSoon()),
                Column = 0,
                Row = 1
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 4,
                Title = "Your Program",
                BackgroundColor = "#6B2851",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 1
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 5,
                Title = "Club News",
                BackgroundColor = "#6B2851",
                PageType = new Xamarin.Forms.NavigationPage(new ComingSoon()),
                Column = 0,
                Row = 2
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 6,
                Title = "Contact Coach",
                BackgroundColor = "#338F84",
                PageType = new Xamarin.Forms.NavigationPage(new ComingSoon()),
                Column = 1,
                Row = 2
            });

            return HomePageTilesList;
        }
    }
}
