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
                BackgroundColor = "#AC172A ",
                PageType = new Xamarin.Forms.NavigationPage(new AthleteProfilePage()),
                Column = 0,
                Row = 0
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 2,
                Title = "Your Next Session",
                BackgroundColor = "#02264A ",
                Icon = FontAwesomeIcons.ClipboardList,
                IconFamily = "FontAwesomeSolid",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 0
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 3,
                Title = "Your Competitions",
                Icon = FontAwesomeIcons.Calendar,
                IconFamily = "FontAwesomeSolid",
                BackgroundColor = "#02264A",
                PageType = new Xamarin.Forms.NavigationPage(new ComingSoon()),
                Column = 0,
                Row = 1
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 4,
                Title = "Your Program",
                BackgroundColor = "#AC172A",
                Icon = FontAwesomeIcons.ClipboardList,
                IconFamily = "FontAwesomeSolid",
                PageType = new Xamarin.Forms.NavigationPage(new SectionPage()),
                Column = 1,
                Row = 1
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 5,
                Title = "Club News",
                BackgroundColor = "#AC172A",
                Icon = FontAwesomeIcons.ExclamationCircle,
                IconFamily = "FontAwesomeSolid",
                PageType = new Xamarin.Forms.NavigationPage(new ComingSoon()),
                Column = 0,
                Row = 2
            });

            HomePageTilesList.Add(new HomePageTileItem()
            {
                Id = 6,
                Title = "Contact Coach",
                BackgroundColor = "#02264A",
                Icon = FontAwesomeIcons.Envelope,
                IconFamily = "FontAwesomeSolid",
                PageType = new Xamarin.Forms.NavigationPage(new ComingSoon()),
                Column = 1,
                Row = 2
            });

            return HomePageTilesList;
        }
    }
}
