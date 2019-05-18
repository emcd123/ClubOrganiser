using ClubOrganiser.ClientModels;
using ClubOrganiser.Interfaces;
using ClubOrganiser.Views;
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
                Title = "Top Left",
                BackgroundColor = "#6B2851",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 0,
                Row = 0
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 2,
                Title = "Top Right",
                BackgroundColor = "#338F84",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 0
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 3,
                Title = "Middle Left",
                BackgroundColor = "#338F84",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 0,
                Row = 1
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 4,
                Title = "Middle Right",
                BackgroundColor = "#6B2851",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 1
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 5,
                Title = "Bottom Left",
                BackgroundColor = "#6B2851",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 0,
                Row = 2
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 6,
                Title = "Bottom Right",
                BackgroundColor = "#338F84",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 2
            });

            return HomePageTilesList;
        }
    }
}
