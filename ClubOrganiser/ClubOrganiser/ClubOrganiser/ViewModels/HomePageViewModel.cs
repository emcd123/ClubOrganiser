using ClubOrganiser.ClientModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ClubOrganiser.ViewModels
{
    public class HomePageViewModel : BaseViewModel
    {
        private List<HomePageTileItem> _homePageTiles;

        public List<HomePageTileItem> HomePageTilesList
        {
            get { return _homePageTiles; }
            set
            {
                _homePageTiles = value;
                OnPropertyChanged();
            }
        }

        public HomePageViewModel()
        {
            HomePageTilesList = new List<HomePageTileItem>();

            HomePageTilesList.Add( new HomePageTileItem() { });
        }
    }
}
